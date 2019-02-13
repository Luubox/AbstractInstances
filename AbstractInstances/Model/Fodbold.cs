using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInstances
{
    class Fodbold : Bold
    {
        public Fodbold(int diameter, string placering, string navn, double pris) : base(diameter, placering, navn, pris)
        {
        }

        public override void Pump()
        {
            throw new NotImplementedException();
        }

        public override void Hop()
        {
            Console.WriteLine("Hop!");
        }

        public override string Placering { get; set; }
        public override string Navn { get; set; }
        public override double Pris { get; set; }
    }
}
