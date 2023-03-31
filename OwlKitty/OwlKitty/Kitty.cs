using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwlKitty
{
    internal class Kitty
    {
        //Atritubes for class Kitty and methods returning them

        private string fluffy = "fluff";
        private int legNumber = 4;
        private string feature = "cuddly";

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
