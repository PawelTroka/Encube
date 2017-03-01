using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;


namespace Encube
{
    class Dice
    {
        public Dice(int n, Random random)
        {
            this.n = n;
            this.random = random;
        }

        public void roll()
        {
            this.number=random.Next(1,this.n+1);
        }

        public override string ToString()
        {
            return "Kostka "+this.n.ToString()+"-ścienna"+"\n"+"Wyrzucono:"+number.ToString();
        }
        [DisplayName("numer")]
        public int number { get; set; }

        private Random random;
        private int n;

    }
}
