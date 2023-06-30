namespace task_3
{
    public class MathHelper
    {
        public MathHelper(string a, string b)
        {
        }

        public static int PrintValue (int a, int b)
        {
            return a + b;
        }
        public static bool PrintValue (int c) 
        {
                return true; 
        } 
        public static void PrintValue (string a, string b)
        {
            Console.WriteLine(a + b);
        }
        public static int PrintValue (int a, int b, int c) 
        {
            return a*b*c;
        }
    }
    internal class Program
     {
        static void Main(string[] args)
        {
            var mathHelper = new MathHelper("Fatima", "Qadirova");
            int a = 10;
            int b = 15;



            Console.WriteLine(a + b);

           
        } 

      
    }
}