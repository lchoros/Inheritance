using System;

namespace BookShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {

            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
