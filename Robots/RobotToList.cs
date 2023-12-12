namespace Robots
{
    public class RobotToList
    {
        public int ID;
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime CreationDate;


        // constructeur
        public RobotToList(string Name, int ID, string Status, DateTime CreationDate) 
        { 
            this.ID = ID;
            this.Name = Name;
            this.Status = Status;
            this.CreationDate = CreationDate;
        }

    }

}