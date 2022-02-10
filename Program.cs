namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            bool result = x.IsEventNUmber();
            Console.WriteLine(x + " is event number: " + result);
        }
    }

    public static class MyExtensionClasss
    {
        public static bool IsEventNUmber(this int value)
        {
            return value%2==0;
        }
    }
}


