using System;

namespace Tasca_BanquerAnalogic
{
    class Program
    {
        static void Main(string[] args)
        {
            var banquer = new Banker();
            
            banquer.CreaClient("Frederic");
            
            Console.WriteLine(banquer.PosarDiners("Frederic",100));
            Console.WriteLine(banquer.TreureDiners("Frederic",200));
            Console.WriteLine(banquer.PosarDiners("Frederic",10));
            
            Console.WriteLine(banquer.TreureDiners("Manel",100));
            
            banquer.CreaClient("Manel");
            Console.WriteLine(banquer.PosarDiners("Manel",100));
        }
    }
}