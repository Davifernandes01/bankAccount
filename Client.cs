namespace bank
{
    class Client
    {
        public string name { get; set; }
        public string cpf { get; set; }

        public Client(string name, string cpf)
        {
            this.name = name;
            this.cpf = cpf;
        }
    }
}