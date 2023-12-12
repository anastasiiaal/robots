// See https://aka.ms/new-console-template for more information

using Robots;


Robot robot = new Robot("Vally", 0, 0);
Point thisRobotPoint = new Point(1, 1);
Point thisRobotNewPoint = new Point(2, 2);
RobotMobile robotMobile = new RobotMobile("R2D2", 0, 0, 2, thisRobotPoint);
Console.WriteLine(robotMobile.SeDeplacer(thisRobotNewPoint));

Console.WriteLine(robotMobile.Demarrer());
Console.WriteLine(robotMobile.Nettoyer());

robot.Nom = "Eva";
robotMobile.Avancer(10, 10);
Console.WriteLine(robotMobile.CalculerDureeDeDeplacement(1, 10));

Console.WriteLine(robot.AfficherPosition().ToString());
Console.WriteLine(robot.Nom.ToString());
robot.Avancer(2,2);
Console.WriteLine(robot.AfficherPosition());
Console.WriteLine(robotMobile.AfficherPosition());
Console.WriteLine(robot.Demarrer());

Robot AfficherNomRobot (Robot robot, string nouveauNom)
{
    robot.Nom = nouveauNom;
    return robot;
}

Robot robotNew = new Robot("Sally", 0, 0);
var newName = AfficherNomRobot(robotNew, "Not Sally Anymore");
Console.WriteLine(newName.Nom);

var x = 5;

var result = add(ref x, 5);
Console.WriteLine(result);

int add(ref int x, int y)
{
    x = 10;
    return x + y;
}

const int MAX_ROBOTS = 5;

var robots = new RobotMobile[MAX_ROBOTS];

RobotMobile robot01 = new RobotMobile("First Vally", 0, 0, 10, thisRobotPoint);
RobotMobile robot02 = new RobotMobile("Second Vally", 1, 1, 5, thisRobotPoint);
RobotMobile robot03 = new RobotMobile("Third Vally", 2, 2, 8, thisRobotPoint);

robots[0] = robot01;
robots[1] = robot02;
robots[2] = robot03;

RobotMobile robot04 = new RobotMobile("Fourth Vally", 2, 2, 1, thisRobotPoint);
robots[2] = robot04;

int calculateAverageSpeed(RobotMobile[] robots)
{
    int totalSpeed = 0;
    int count = 0;

    foreach (var robot in robots)
    {
        if (robot != null)
        {
            totalSpeed += robot.Vitesse;
            count++;
        }
    }

    if (count == 0) return 0;

    return (int)totalSpeed / count;
}

int vitesseMoyenne = calculateAverageSpeed(robots);
Console.WriteLine(vitesseMoyenne);



List<RobotToList> robotsList = new List<RobotToList>();

// Ajout des instances à la liste
robotsList.Add(new RobotToList("Robot1", 1, "Actif", DateTime.Now));
robotsList.Add(new RobotToList("Robot2", 2, "Inactif", DateTime.Now));
robotsList.Add(new RobotToList("Robot3", 3, "En Maintenance", DateTime.Now));

// Affichage des informations des robots (optionnel)
foreach (var robotInList in robotsList)
{
    Console.WriteLine($"ID: {robotInList.ID}, Nom: {robotInList.Name}, Status: {robotInList.Status}, Date de Création: {robotInList.CreationDate}");
}

Dictionary<int, RobotToList> robotDictionary = new Dictionary<int, RobotToList>();
foreach (var robotInDict in robotsList)
{
    robotDictionary.Add(robotInDict.ID, robotInDict);
}

// Affichage des informations des robots (optionnel)
foreach (var robotInDict in robotDictionary)
{
    Console.WriteLine($"ID: {robotInDict.Key}, Nom: {robotInDict.Value.Name}, Status: {robotInDict.Value.Status}, Date de Création: {robotInDict.Value.CreationDate}");
}





Console.ReadLine();