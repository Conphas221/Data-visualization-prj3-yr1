using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_Windows_form.Imports
{
    public class WeatherNode
    {
        int AVGTemp;
        int cars;
        public WeatherNode(int AVGTemp, int cars)
        {
            this.AVGTemp = AVGTemp;
            this.cars = cars;
        }
        public int GetAVGCars()
        {
            return cars;
        }
        public int getAVGTemp()
        {
            return AVGTemp;
        }
    }
}
