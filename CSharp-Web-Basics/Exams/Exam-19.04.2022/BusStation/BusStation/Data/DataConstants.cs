namespace BusStation.Data
{
    public class DataConstants
    {
        public class User
        {
            public const int IdMaxLength = 40;


            public const int UsernameMinLength = 5;
            public const int UsernameMaxLength = 20;

            public const int EmailMinLength = 10;
            public const int EmailMaxLength = 60;
            public const string UserEmailRegularExpression = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            public const int PasswordMinLength = 5;
            public const int PasswordMaxLength = 20;
            
   
        }

        public class Destination
        {
            public const int DestinationNameMinLenght = 2;
            public const int DestinationNameMaxLenght = 50;

            public const int OriginMinLenght = 2;
            public const int OriginMaxLenght = 50;

            public const int DateMaxLenght = 30;

            public const int TimeMaxLenght = 30;

            public const int ImageUrlMaxLenght = 2048;
        }
    }
}
