namespace Mirai_Paradise_Hotel
{
    public static class UserSession
    {
        private static User _currentUser;

        public static User CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

        public static bool IsLoggedIn => _currentUser != null;
    }
}
