using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInstances
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRedskab> redskabsSkur = new List<IRedskab>
            {
                new Fodbold(15, "Vipperoed", "Select", 19.99),
                new Haandbold(5, "Vipperoed", "select 2", 15.5),
                new Fjerbold("Vipperoed", "Ostemad", 3.75),
                new BadmintonNet("Vipperoed", "Netty McNetface", 11.11),
                new BadmintonNet("Roskilde", "NogetAndet", 0.00)
                //polymorphism en fodbold kan både være en fodbold og et redskab, casting etc etc.
            };

            int counter = 0;
            foreach (IRedskab r in redskabsSkur)
            {
                if (r.Placering == "Vipperoed") counter++;

                if (r is Fodbold) //hvorfor virker det ...
                {
                    Fodbold f = (Fodbold) r; //casting, pas på pga runtime error
                    f.Hop();
                    Console.WriteLine("Det er en fucking fodbold!");
                }
            }

            Console.WriteLine($"Der er {counter} redskaber i skuret i vipperoed");
            Console.ReadKey();
        }
    }
}
