using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwlKitty
{
    internal class OwlKittyOffspring
    {
        IKitty kitty;
        IOwl owl;

        public OwlKittyOffspring()
        {
            owl = new Owl();
            kitty = new Kitty();
        }

        //methods from both classes Kitty and Owl used thanks to interfaces
        public string Fluffy()
        {
            return kitty.Fluffy();
        }

        public int LegNumber()
        {
            return kitty.LegNumber();
        }

        public string Feathers()
        {
            return owl.Feathers();
        }

        public int Wings()
        {
            return owl.Wings();
        }

        public string Nature()
        {
            return owl.Nature();
        }
    }
}
