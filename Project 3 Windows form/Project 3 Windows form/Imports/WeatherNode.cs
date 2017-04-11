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
        int speed;
        DateTime dag;
        public WeatherNode(int AVGTemp, int speed, DateTime dag)
        {
            this.AVGTemp = AVGTemp;
            this.speed = speed;
            this.dag = dag;
        }
        public int GetSpeed()
        {
            return speed;
        }
        public int getAVGTemp()
        {
            return AVGTemp;
        }
    }
}
