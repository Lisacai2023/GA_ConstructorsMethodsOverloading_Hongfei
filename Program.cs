namespace GA_ConstructorsMethodsOverloading_Hongfei
{
    internal class Program
    {
        //Week2_GA_ConstructorsMethodsOverloading
        //Hongfei
        //01-25-2024
        static void Main(string[] args)
        {
            Car defaultCar = new Car();
            Car makeModelCar = new Car("Honda","Pilot");
            Car fullCar = new Car("Honda","Pilot",2024,10);

            Console.WriteLine("Car infornation");
            Console.WriteLine(defaultCar);
            Console.WriteLine(makeModelCar);
            Console.WriteLine(fullCar);

            BankAccount account = new BankAccount("1001","Lisa Cai",20);
            Console.WriteLine("Bank Account information");
            Console.WriteLine(account);
            account.Deposit(500);
            Console.WriteLine(account);
            account.Deposit(-1000);
            Console.WriteLine(account);
            account.WithDraw(300);
            Console.WriteLine(account);
            account.WithDraw(-500);
            Console.WriteLine(account);


        }
    }
}
