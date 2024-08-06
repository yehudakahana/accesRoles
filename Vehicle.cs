using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accesRoles
{
    internal class Vehicle
    {
        // משתנה פרטי
        protected string Model { get; set; }

        // משתנה מוגן
        private string engineCapacity { get; set; }
    }


    internal class Car : Vehicle
    {
        public void SetMoodel(string model)
        {
            Model = model;
        }

        //func that bring the total information of the car
        private string NumOfDoors {  get; set; }

        public  string CarInfo() 
        {
            return (Model + NumOfDoors);
        
        }

    }

}
