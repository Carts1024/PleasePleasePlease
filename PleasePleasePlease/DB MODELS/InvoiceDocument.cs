using System.Globalization;
using System.Linq;
using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Image = QuestPDF.Infrastructure.Image;

namespace Mirai_Paradise_Hotel
{
    public class InvoiceDocument : IDocument
    {
        public static Image LogoImage { get; } = Image.FromFile("C:\\Users\\Carl\\source\\repos\\Carts1024\\PleasePleasePlease\\PleasePleasePlease\\logo.jpg");

        private readonly InvoiceModel _invoice;
        private readonly Guest _guest;

        private const string CompanyName = "Mirai Paradise Hotel";
        private const string Street = "123 Paradise St";
        private const string City = "Hotel City";
        private const string State = "Hotel State";
        private const string Email = "info@miraihotel.com";
        private const string Phone = "123-456-7890";

        public InvoiceDocument(InvoiceModel invoice, Guest guest)
        {
            _invoice = invoice;
            _guest = guest;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
        public DocumentSettings GetSettings() => DocumentSettings.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(70);
                page.Size(PageSizes.A3.Landscape());
                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);
                page.Footer().AlignCenter().Text(text =>
                {
                    text.CurrentPageNumber();
                    text.Span(" / ");
                    text.TotalPages();
                });
            });
        }

        void ComposeHeader(IContainer container)
        {
            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    column
                        .Item().Text(CompanyName).FontSize(24).Bold().FontColor(Colors.Blue.Darken2);
                    column.Item().Text(Street);
                    column.Item().Text($"{City}, {State}");
                    column.Item().Text(Email);
                    column.Item().Text(Phone);
                });

                row.RelativeItem().Column(column =>
                {
                    column
                        .Item().Text($"Invoice #{_invoice.InvoiceNumber}")
                        .FontSize(40).SemiBold().FontColor(Colors.Blue.Medium).FontFamily("Times New Roman");

                    column.Item().Text(text =>
                    {
                        text.Span("Issue date: ").SemiBold();
                        text.Span($"{_invoice.IssueDate:d}");
                    });

                    column.Item().Text(text =>
                    {
                        text.Span("Due date: ").SemiBold();
                        text.Span($"{_invoice.DueDate:d}");
                    });
                });

                row.ConstantItem(175).Image(LogoImage);
            });
        }

        void ComposeContent(IContainer container)
        {
            container.PaddingVertical(40).Column(column =>
            {
                column.Spacing(20);

                column.Item().Row(row =>
                {
                    row.RelativeItem().Component(new GuestComponent("Guest Information", _guest));
                });

                column.Item().Element(ComposeTable);

                var roomTotal = _invoice.TotalAmount;
                var subtotal = roomTotal;
                var tax = subtotal * 0.05m;
                var totalDue = subtotal + tax;

                column.Item().PaddingRight(5).AlignRight().Text($"Subtotal: {subtotal:C}").SemiBold();
                column.Item().PaddingRight(5).AlignRight().Text($"Tax (5%): {tax:C}").SemiBold();
                column.Item().PaddingRight(5).AlignRight().Text($"Total Due: {totalDue:C}").SemiBold();

                if (!string.IsNullOrWhiteSpace(_invoice.Comments))
                    column.Item().PaddingTop(25).Element(ComposeComments);
            });
        }

        void ComposeTable(IContainer container)
        {
            var headerStyle = TextStyle.Default.SemiBold();

            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(25);
                    columns.RelativeColumn(3);
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                });

                table.Header(header =>
                {
                    header.Cell().Text("#");
                    header.Cell().Text("Description").Style(headerStyle);
                    header.Cell().AlignRight().Text("Room Type").Style(headerStyle);
                    header.Cell().AlignRight().Text("Room Price").Style(headerStyle);
                    header.Cell().AlignRight().Text("Number of Nights").Style(headerStyle);
                    header.Cell().AlignRight().Text("Total").Style(headerStyle);

                    header.Cell().ColumnSpan(6).PaddingTop(5).BorderBottom(1).BorderColor(Colors.Black);
                });

                int numberOfNights = (_invoice.Booking.CheckOutDate - _invoice.Booking.CheckInDate).Days;

                // Adding other items without room details
                foreach (var item in _invoice.Items)
                {
                    var index = _invoice.Items.IndexOf(item) + 1; // start from 2 because room details are the first row

                    table.Cell().Element(CellStyle).Text($"{index}");
                    table.Cell().Element(CellStyle).Text(item.Name);
                    table.Cell().Element(CellStyle).AlignRight().Text($"{_invoice.Booking.Room.RoomType}"); // Room type not applicable to other items
                    table.Cell().Element(CellStyle).AlignRight().Text($"{_invoice.Booking.Room.RoomPrice}"); // Room price not applicable to other items
                    table.Cell().Element(CellStyle).AlignRight().Text($"{item.Quantity}");
                    table.Cell().Element(CellStyle).AlignRight().Text($"{_invoice.TotalAmount}");
                } 

                static IContainer CellStyle(IContainer container) => container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
            });
        }

        void ComposeComments(IContainer container)
        {
            container.ShowEntire().Background(Colors.Grey.Lighten3).Padding(10).Column(column =>
            {
                column.Spacing(5);
                column.Item().Text("Comments").FontSize(14).SemiBold();
                column.Item().Text(_invoice.Comments);
            });
        }

        public class GuestComponent : IComponent
        {
            private string Title { get; }
            private Guest Guest { get; }

            public GuestComponent(string title, Guest guest)
            {
                Title = title;
                Guest = guest;
            }

            public void Compose(IContainer container)
            {
                container.ShowEntire().Column(column =>
                {
                    column.Spacing(2);

                    column.Item().Text(Title).SemiBold();
                    column.Item().PaddingBottom(5).LineHorizontal(1);

                    if (Guest.Gender == "Male")
                    {
                        column.Item().Text($"Name: Mr.{Guest.FirstName} {Guest.LastName}");
                    }
                    else
                    {
                        column.Item().Text($"Name: Ms.{Guest.FirstName} {Guest.LastName}");
                    }


                    
                    column.Item().Text($"Address: {Guest.StreetAddress}");
                    column.Item().Text($"{Guest.CityAddress}, {Guest.StateAddress}");
                    column.Item().Text($"Phone: {Guest.PhoneNumber}");
                    column.Item().Text($"Email: {Guest.Email}");
                });
            }
        }
    }
}
