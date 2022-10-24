using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolekcijeAuti
{
    internal class Auti
    {
        private string model, dodatak;
        private int godinaPro, brojKotaca;

        public Auti(string model, int godinaPro, int brojKotaca, string dodatak)
        {
            this.model = model;
            this.godinaPro = godinaPro;
            this.brojKotaca = brojKotaca;
            this.dodatak = dodatak;
        }

        public override string ToString()
        {
            string ispis = this.model + "\t" + this.godinaPro + "\t" + this.brojKotaca + "\t\t" + this.dodatak;
            return ispis;
        }

        public string Model { get => model; set => model = value; }
        public string Dodatak { get => dodatak; set => dodatak = value; }
        public int GodinaPro { get => godinaPro; set => godinaPro = value; }
        public int BrojKotaca { get => brojKotaca; set => brojKotaca = value; }
    }
}
