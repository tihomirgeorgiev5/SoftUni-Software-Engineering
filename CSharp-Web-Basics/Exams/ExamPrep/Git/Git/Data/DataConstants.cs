namespace Git.Data
{
    public class DataConstants
    {
        public const int UserMinUsername = 5;
        public const int UserMaxDefaultLength = 20;
        public const int UserMinPassword = 6;
        public const int IdMaxLength = 40;
        public const string UserEmailRegEx = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

        public const int RepoMinName = 3;
        public const int RepoMaxName = 10;

        public const int CommitMinDescription = 5;









    }
}
