// See https://aka.ms/new-console-template for more information

using Robots;


Robot robot = new Robot("Vally", 0, 0);
RobotMobile robot2 = new RobotMobile("R2D2", 0, 0, 2);


Console.WriteLine(robot2.Demarrer());
Console.WriteLine(robot2.Nettoyer());

Console.ReadLine();


robot.Nom = "Eva";
robot2.Avancer(10, 10);
Console.WriteLine(robot2.CalculerDureeDeDeplacement(1, 10));

Console.WriteLine(robot.AfficherPosition().ToString());
Console.WriteLine(robot.Nom.ToString());
robot.Avancer(2,2);
Console.WriteLine(robot.AfficherPosition());
Console.WriteLine(robot2.AfficherPosition());
Console.WriteLine(robot.Demarrer());

