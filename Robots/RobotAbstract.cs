using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public abstract class RobotAbstract
    {
        public abstract string Demarrer();

        public string Arreter()
        {
            return "Robot arreté";
        }
    }
}
