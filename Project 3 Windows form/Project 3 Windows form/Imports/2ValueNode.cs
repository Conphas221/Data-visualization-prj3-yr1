using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_Windows_form.Imports
{
    public class _2ValueNodes
    {
        private int Data1;
        private int Data2;
        public _2ValueNodes(int AVGTemp, int cars)
        {
            this.Data1 = AVGTemp;
            this.Data2 = cars;
        }
        public int getData1()
        {
            return Data1;
        }
        public int getData2()
        {
            return Data2;
        }
    }
}
