namespace FootballManager.Data
{
    public class DataConstants
    {
        public const int IdMaxLength = 40;

        public const int UserMinUsername = 5;
        public const int UserMaxUsername = 20;
        public const int UserMaxEmail = 60;
        public const int UserMinEmail = 10;
        public const int UserMinPassword = 5;
        public const int UserMaxPassword = 20;
        public const string UserEmailRegEx = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
       

        public const int PlayerMinFullName = 5;
        public const int PlayerMaxFullName = 80;
        public const int PlayerMaxPosition = 20;
        public const int PlayerMinPosition = 5;
        public const byte PlayerMaxSpeed = 10;
        public const byte PlayerMaxEndurance = 10;
        public const int PlayerMaxStringDescription = 200;

       
    }
}
