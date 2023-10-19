using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class RobotMobile : Robot, IRobotNettoyage
    {
        public int Vitesse;
        public Point Position;

        // constructeur
        public RobotMobile(string Nom, int PositionX, int PositionY, int Vitesse, Point Position):base(Nom, PositionX, PositionY)
        {
            this.Vitesse = Vitesse;
            this.Position = Position;
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

        public override string AfficherPosition() // methode surchargé
        {
            return $"Position X: {_positionX}, Y: {_positionY}";
        }

        public override string Demarrer()
        {
            return "J'ai bougé car je suis mobile !";
        }

        public string Nettoyer ()
        {
            return $"Le robot mobile {this.Nom} nettoie le sol";
        }

        public double SeDeplacer (Point Position)
        {
            return Utils.CalculerDistance(this.Position, Position);
        }
    }
}
