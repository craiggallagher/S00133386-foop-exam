using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00133386_foop_exam
{
    class Music
    {
        public string album { get; set; }
        public string artists { get; set; }
        private double cost;
        public double Cost 
        {
            get
            {
                return cost;
            }
            set
            {
                if (value > 0 && value <100)
                {
                    cost = value;
                }
                else value = -1;
            }
        }
        public Music()
        {

        }
        public Music( string alb, string ar, double c)
        {
            album = alb;
            artists = ar;
            Cost = c;
        }
        public override string ToString()
        {
            return string.Format("Album name is {0} arist name is {1} cost is {2:c}", album, artists, Cost );
        }
    }
}
