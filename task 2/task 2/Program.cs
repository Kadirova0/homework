namespace task_2
{
    public class UnibankCard
    {
        public UnibankCard(string name, string surname, string code, string cvv, decimal balance)
        {
            Name = name;
            Surname = surname;  
            Code = code;    
            CVV = cvv;
            Balance = balance;
        }

        public string Name { get;  set; }    
        public string Surname { get; set; }
        public string Code { get;  set; }
        public string CVV { get;  set; }
        public decimal Balance { get;  set; }

        public override string ToString()
        {
            return Name + " " + Surname + " " + Code + " " + CVV + " " + Balance;
        }

       private void Withdraw(decimal amount, decimal balance)
        {
            Balance += amount;
        }
        private void Deposit(decimal amount, decimal balance)
        {
            Balance -= amount - (amount * 1.5m);
        }
    }
    public class AccessbankCard : UnibankCard
    {
        public AccessbankCard(string name, string surname, string code, string cvv, decimal balance) : base(name, surname, code, cvv, balance)
        {
        }

        public void Withdraw (decimal amount, decimal balance)
        {
            balance += amount - (amount * 0.3m);
        }
        public void Deposit (decimal amount, decimal balance)
        {
            Balance -= amount - (amount * 1.6m);
        }
    }
    public class PashabankCard : UnibankCard
    {

        public PashabankCard(string name, string surname, string code, string cvv, decimal balance) : base(name, surname, code, cvv , balance)
        {
        }
       

        public void Withdraw(decimal amount, decimal balance)
        {
            Balance += amount - (amount * 0.6m);
        }
        public void Deposit(decimal amount, decimal balance)
        {
            Balance -= amount - (amount * 1.1m);
        }
    }
    public class LeobankCard : UnibankCard
    {
        public LeobankCard(string name, string surname, string code, string cvv, decimal balance) : base(name, surname, code, cvv, balance)
        {
        }

        public void Withdraw(decimal amount, decimal balance)
        {
            Balance += amount;
        }
        public void Deposit(decimal amount, decimal balance)
        {
            Balance -= amount;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
           UnibankCard unibankCard = new UnibankCard("Gunay", "Amirjanova", "0000 0000 0000 0000", "000", 950m);
            AccessbankCard accsessbankCard = new AccessbankCard("Fatima", "Qadirova", "0000 0000 0000 0000", "000", 1000m);
             PashabankCard pashabankCard = new PashabankCard("Zahra", "Qadirova", "0000 0000 0000 0000", "123", 800m);
              LeobankCard leobankCard = new LeobankCard("Laman", "Jabrailova", "0000 0000 0000 0000", "125", 1200m);

              Console.WriteLine(unibankCard);
               Console.WriteLine(accsessbankCard);
                Console.WriteLine(pashabankCard);
                 Console.WriteLine(leobankCard);
        }
    }
}