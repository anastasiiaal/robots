// See https://aka.ms/new-console-template for more information

using Robots;


Robot robot = new Robot("Vally", 0, 0);
Point thisRobotPoint = new Point(1, 1);
Point thisRobotNewPoint = new Point(2, 2);
RobotMobile robotMobile = new RobotMobile("R2D2", 0, 0, 2, thisRobotPoint);
Console.WriteLine(robotMobile.SeDeplacer(thisRobotNewPoint));

Console.WriteLine(robotMobile.Demarrer());
Console.WriteLine(robotMobile.Nettoyer());

Console.ReadLine();


robot.Nom = "Eva";
robotMobile.Avancer(10, 10);
Console.WriteLine(robotMobile.CalculerDureeDeDeplacement(1, 10));

Console.WriteLine(robot.AfficherPosition().ToString());
Console.WriteLine(robot.Nom.ToString());
robot.Avancer(2,2);
Console.WriteLine(robot.AfficherPosition());
Console.WriteLine(robotMobile.AfficherPosition());
Console.WriteLine(robot.Demarrer());

