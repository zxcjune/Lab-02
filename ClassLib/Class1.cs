using System;
namespace ClassLib
{
    public class TV
    {
        public string Model { get; set; }
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