using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizenko.TempConv
{
    public class Rover
    {
        string direction = "N";
        int x = 0;
        int y = 0;

        public string getDirection()
        {
            return direction;
        }

        public int getXCoorindate()
        {
            return x;
        }

        public int getYCoordinate()
        {
            return y;
        }

        public void moveForward(int spots)
        {
            switch(getDirection())
            {
                case "N":
                    x = x + spots;
                    return;
                case "S":
                    x = x - spots;
                    return;
                case "W":
                    y = y - spots;
                    return;
                case "E":
                    y = y + spots;
                    return;
            }
        }

        public void moveBackward(int spots)
        {
            switch (getDirection())
            {
                case "N":
                    x = x - spots;
                    return;
                case "S":
                    x = x + spots;
                    return;
                case "W":
                    y = y + spots;
                    return;
                case "E":
                    y = y - spots;
                    return;
            }
        }

        public void turnLeft()
        {
            switch (getDirection())
            {
                case "N":
                    direction = "W";
                    return;
                case "E":
                    direction = "N";
                    return;
                case "S":
                    direction = "E";
                    return;
                case "W":
                    direction = "S";
                    return;
            }
        }

        public void turnRight()
        {
            turnLeft();
            turnLeft();
            turnLeft();
        }

    }
}
