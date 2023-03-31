using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwlKitty
{
    internal class Kitty:IKitty
    {
        //Atritubes for class Kitty and methods returning them

        private string fluffy;
        private int legNumber;
        private string feature;

        public Kitty()
        {
            fluffy = "fluff";
            legNumber = 4;
            feature = "cuddly";
        }

        public string Fluffy()
        {
            return fluffy;
        }

        public int LegNumber()
        {
            return legNumber;
        }

        private string Feature()
        {
            return feature;
        }
    }
}
