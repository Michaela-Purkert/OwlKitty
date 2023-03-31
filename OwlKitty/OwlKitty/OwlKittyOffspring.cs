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

       OwlKittyOffspring()
        {
            owl = new Owl();
            kitty = new Kitty();
        }

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
