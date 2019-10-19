namespace TopCoderStarterApp
{
    public class PostgreysDBConfig
    {
        public string Database { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Password))
                    return $@"host={Host};port={Port};database={Database}";

                return $@"host={Host};port={Port};database={Database};username={User};password={Password}";
            }
        }
    }
}
