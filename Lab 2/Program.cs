using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2Lib
{
    public class TV
    {
        public string Model;
        public string Diagonal;
        public string Display;
        public string Resolution;
        public string Platform;
        public string Tuner;
        public string Technology;

        public string TV4k
        {
            get
            {
                return Is4k() ? "TV has 4k" : "TV doesn't have 4k";
            }
        }

        public bool Is4k()
        {

            if (!string.IsNullOrEmpty(Display) && Display[0] == '4')
            {
                return true;
            }
            return false;
        }
    }

}

