using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accesRoles
{

    using System;

    namespace accesRoles
    {

        //class calculatore
        internal class Calculatore
        {
            internal int Add(int x, int y)
            {
                return x + y;
            }
        }

        //class MathOperations
        public class MathOperations
        {
            public int PublicAdd(int x, int y)
            {
                //create a new instance of the class calculatore
                Calculatore calculator = new Calculatore();
                return calculator.Add(x, y);
            }
        }
    }






}
