using System;
namespace bank{

    class CheckingAccount : Account {

      
      //construtor(usando herança)
        public CheckingAccount(int agency, int number, Client owner) : 
         base( agency,number, owner) {


        }

        public override void deposit(decimal balance){

            this.balance += balance;
        }

        //retirar
        public override Boolean withdraw(decimal balance){

            if (balance <= this.balance) {
               
                this.balance -= balance;
                return true;
                
            }

            return false;
        }

        //trasfere dinheiro de uma conta pra outra
        public override Boolean Transfer(CheckingAccount c1, decimal money, CheckingAccount c2){

            if (c1.balance >= money){
                c1.withdraw(money);
                c2.deposit(money);
                return true;

            }
            return false;
        }

        public decimal getBalance(){

            return balance;
        }

    }
}