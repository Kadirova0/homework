namespace task_1
{
   
        public class Person
        {
            public string Name { get; private set; }
            public string Surname { get; private set; }
            public  int Age { get; private set; }
            public decimal Weight { get; private set; }
            public decimal Height { get; private set; }
            public Person (string name, string surname,  int age, decimal weight, decimal height)
            {
                Name = name;
                Surname = surname;
                Age = age;
                Weight = weight;
                Height = height;
            }

        public override string ToString()
            {
                return Name + " " + Surname + " " + Age + " " + Weight + " " + Height;
            }
        }
         public  class Program
    { 
        static void Main(string[] args)
        {
            var person = new Person("Fatima", "Qadirova", 22, 47m, 1.61m);

            Console.WriteLine(person);

              Console.WriteLine("Enter your outward appearance: ");

               string input = Console.ReadLine();
        }
    } 
}