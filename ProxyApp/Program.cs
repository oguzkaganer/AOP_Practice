namespace ProxyApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessModuleProxy businessModuleProxy= new BusinessModuleProxy();

            businessModuleProxy.Method();

            Console.ReadLine();
        }
    }
}