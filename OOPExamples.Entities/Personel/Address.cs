using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples.Entities.Personel
{
    /// <summary>
    /// 
    /// </summary>
    public class Address
    {

        /* propfull
        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        */

        // prop 
        public int MyProperty1 { get; set; }

        public int MyProperty2 { get; }

        







        public override string ToString()
        {
            return base.ToString();
        }
    }
}
