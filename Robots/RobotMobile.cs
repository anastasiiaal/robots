using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class RobotMobile : Robot
    {
        private int _vitesse;

        // constructeur
        public RobotMobile(string Nom, int PositionX, int PositionY, int Vitesse):base(Nom, PositionX, PositionY)
        {
            _vitesse = Vitesse;
        }

        public int CalculerDureeDeDeplacement(int prevPos, int pos)
        {
            return (pos - prevPos) / _vitesse;
        }

        public new string AfficherPosition() // methode surchargé
        {
            return $"Position X: {_positionX}, Y: {_positionY}";
        }
    }
}
