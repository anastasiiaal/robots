namespace Robots
{
    public class Robot
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

        public void Avancer(int directionX, int directionY)
        {
            _positionX += directionX;
            _positionY += directionY;
        }

        public string AfficherPosition()
        {
            return $"Position X: {_positionX}, Y: {_positionY}";
        }
    }

}