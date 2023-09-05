namespace bank{

    abstract class Account{

        public decimal balance { get;  set; }
        public int agency {get ; private set;}

        public int number {get; private set;}

        public  Client owner {get; private set;}    


    //construtor
        public Account( int agency, int number, Client owner)
        {
          
            this.agency = agency; 
            this.number = number;
            this.owner = owner;
        }

        //metados


        public abstract void deposit(decimal balance);

    //retirar
        public abstract Boolean withdraw(decimal balance);

    //transfere
        public abstract Boolean Transfer( CheckingAccount c1, decimal money, CheckingAccount c2);
    }
       
}
