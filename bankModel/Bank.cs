using System.Net.Http.Headers;
using client;

namespace bank{

    abstract class Account{

        protected decimal balance { get; private set; }
        public int agency {get ; private set;}

        public  int number {get; private set;}

        public  Client owner {get; private set;}    


    //construtor
        public Account(decimal balance, int agency, int number, Client owner)
        {
            this.balance = balance;
            this.agency = agency;
            this.number = number;
            this.owner = owner;
        }

        //metados


        public abstract void deposit();

    //retirar
        public abstract Boolean withdraw();

    //transfere
        public abstract Boolean Transfer();
    }
       
}
