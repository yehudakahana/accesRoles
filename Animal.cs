using accesRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accesRoles
{
    internal class Animal
    {
        protected string Species { get; set; }

        public string GetSpecies()
        { return this.Species; }
    }
    internal class Dog : Animal
    {
        public void SetSpecies(string species)
        {
            this.Species = species;
        }
    }

}

