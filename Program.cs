
namespace bank
{
    internal class Program
        {
            private static void Main(string[] args)
            {
                var ac1 = new Client("rada", "23434-322");
                Console.WriteLine(ac1.name);


                var c1 = new CheckingAccount(123,43, ac1);

                c1.deposit(270);
                c1.deposit(200);
                Console.WriteLine($"saldo: {c1.getBalance()}");
                c1.withdraw(70);
                Console.WriteLine($"saldo apos a retirada: {c1.getBalance()}");

                Console.WriteLine("----------------");                    

                var ac2 = new Client("davi", "425363");
                var c2 = new CheckingAccount(123, 45, ac2);

                c2.deposit(1000);
                Console.WriteLine($"valor da conta do davi: {c2.getBalance()}");

                c2.Transfer(c2,300,c1);

                Console.WriteLine($"valor da conta do {c2.owner.name} depois da tranferencia: {c2.getBalance()}");
                Console.WriteLine($"valor da conta do {c1.owner.name} depois da tranferencia: {c1.getBalance()}");
            
            }
    }
}

