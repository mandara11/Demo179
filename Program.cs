namespace FlipTheCoin
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of Flips");

            int flips = Convert.ToInt32(Console.ReadLine());

            Flip.CalculatePercentage();

            Flip.Display();   
        }    
    }
}