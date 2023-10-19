using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class RobotMobile : Robot
    {
        public int Vitesse;

        // constructeur
        public RobotMobile(string Nom, int PositionX, int PositionY, int Vitesse):base(Nom, PositionX, PositionY)
        {
            this.Vitesse = Vitesse;
        }

        private int CalculerDistance (int posX, int posY)
        {
            int distance = 0;
            distance = Math.Abs(posX - _positionX) + Math.Abs(posY - _positionY);
            return distance;
        }

        public int CalculerDureeDeDeplacement(int posX, int posY)
        {
            int duree = 0;
            duree = CalculerDistance(posX, posY) / Vitesse;
            return duree;
        }

        public new string AfficherPosition() // methode surchargé
        {
            return $"Position X: {_positionX}, Y: {_positionY}";
        }
    }
}
