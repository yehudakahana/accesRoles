using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accesRoles
{
    internal class Person
    {
        private int Age {  get; set; }
        
        public void SetAge(int age)
            { this.Age = age; }

        public int GetAge() { return this.Age; }

    }
}
