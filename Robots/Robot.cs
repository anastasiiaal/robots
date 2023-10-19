namespace Robots
{
    public class Robot : RobotAbstract
    {
        protected int _positionX;
        protected int _positionY;
        public string Nom { get; set; }

        // constructeur
        public Robot(string Nom, int PositionX, int PositionY) 
        { 
            this.Nom = Nom;
            this._positionX = PositionX;
            this._positionY = PositionY;
        }

        public override string Demarrer()
        {
            return "J'ai bougé !";
        }

        public void Avancer(int directionX, int directionY)
        {
            _positionX += directionX;
            _positionY += directionY;
        }

        public virtual string AfficherPosition()
        {
            return $"Position de Robot Mobile X: {_positionX}, Y: {_positionY}";
        }
    }

}