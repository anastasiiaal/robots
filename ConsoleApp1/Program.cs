// See https://aka.ms/new-console-template for more information

using Robots;


Robot robot = new Robot("Vally", 0, 0);

RobotMobile robot2 = new RobotMobile("R2D2", 0, 0, 2);

robot.Nom = "Eva";
var duree = robot2.CalculerDureeDeDeplacement(1, 10);
Console.WriteLine(duree);

Console.WriteLine(robot.AfficherPosition().ToString());
Console.WriteLine(robot.Nom.ToString());
robot.Avancer(2,2);
Console.WriteLine(robot.AfficherPosition());

Console.ReadLine();
