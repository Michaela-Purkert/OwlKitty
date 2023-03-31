using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwlKitty
{
    internal class Owl:IOwl
    {
        //Atritubes for class Owl and methods returning them

        private string feathers;
        private int legNumber;
        private int wingsNumber;
        private string nature;

        public Owl()
        {
            feathers = "feathered";
            legNumber = 2;
            wingsNumber = 2;
            nature = "stubborn";
        }
        public string Feathers()
        {
            return feathers;
        }

        public int Legs()
        {
            return legNumber;
        }

        public int Wings()
        {
            return wingsNumber;
        }

        public string Nature()
        {
            return nature;
        }
    }
}
