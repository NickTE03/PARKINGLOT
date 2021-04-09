using System;
using System.Collections.Generic;
using System.Text;

namespace PARKINGLOT
{
    class PARKINGLOT
    {
        private int Large;
        private int Medium;
        private int Small;


        public PARKINGLOT(int Large, int Medium, int Small)
        {
            this.Large = Large;
            this.Medium = Medium;
            this.Small = Small;
        }

        public bool AddCar(string carType)
        {
            bool check = false;
            carType = carType.ToLower();

            if (carType == "large" && Large > 0)
            {
                check = true;
                Large--;
            }
            else if (carType == "medium" && Medium > 0)
            {
                check = true;
                Medium--;
            }
            else if (carType == "small" && Small > 0)
            {
                check = true;
                Small--;
            }
            return check;
        }
    }
}
