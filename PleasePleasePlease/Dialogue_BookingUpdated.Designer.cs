namespace Mirai_Paradise_Hotel
{
    partial class Dialogue_BookingUpdated
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialogue_BookingUpdated));
            panel1 = new Panel();
            label1 = new Label();
            labelRConfirmation = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelRConfirmation);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 358);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(62, 291);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(230, 16);
            label1.TabIndex = 2;
            label1.Text = "Booking has been successfully updated.";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelRConfirmation
            // 
            labelRConfirmation.AutoSize = true;
            labelRConfirmation.BackColor = Color.Transparent;
            labelRConfirmation.Font = new Font("SF Pro Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRConfirmation.ForeColor = Color.Black;
            labelRConfirmation.Location = new Point(61, 247);
            labelRConfirmation.Name = "labelRConfirmation";
            labelRConfirmation.RightToLeft = RightToLeft.No;
            labelRConfirmation.Size = new Size(235, 32);
            labelRConfirmation.TabIndex = 1;
            labelRConfirmation.Text = "Booking Updated!";
            labelRConfirmation.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(34, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 234);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Dialogue_BookingUpdated
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 358);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dialogue_BookingUpdated";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Booking";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label labelRConfirmation;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}