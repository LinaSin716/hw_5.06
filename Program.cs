namespace hw_5._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mission> missions = new List<Mission>();
            List<Spaceship> spaceships = new List<Spaceship>();
            CommandFleet commandFleet = new CommandFleet("Cat", "Meow", "Meow?");

            commandFleet.AddSpaceship(spaceships, new Spaceship
            { ID = "001", Name = "Ship1", Price = 500m, Type = "Small ship" });
            commandFleet.AddSpaceship(spaceships, new Spaceship
            { ID = "002", Name = "Ship2", Price = 1000m, Type = "Big ship" });
            commandFleet.AddSpaceship(spaceships, new Spaceship
            { ID = "003", Name = "Ship3", Price = 700m, Type = "Super ship" });
            commandFleet.AddSpaceship(spaceships, new Spaceship
            { ID = "004", Name = "Ship4", Price = 750m, Type = "Super ship" });
            commandFleet.AddSpaceship(spaceships, new Spaceship
            { ID = "005", Name = "Ship5", Price = 1200m, Type = "Super x5 ship" });

            commandFleet.AddMission("001", "mission1_1", "pur1", "1.05.1650", missions);
            commandFleet.AddMission("001", "mission1_2", "pur2", "3.01.2000", missions);
            commandFleet.AddMission("001", "mission1_3", "pur3", "26.11.1866", missions);
            commandFleet.AddMission("005", "mission5_1", "pur1", "1.05.2005", missions);
            commandFleet.AddMission("005", "mission5_2", "pur2", "15.06.1988", missions);
            commandFleet.AddMission("003", "mission3_1", "pur1", "31.01.650", missions);
            commandFleet.AddMission("004", "mission4_1", "pur1", "29.12.1358", missions);

            commandFleet.PrintShips(spaceships);

            Console.WriteLine("удалим Ship2");
            commandFleet.RemoveSpaceship(spaceships, new Spaceship
            { ID = "002", Name = "Ship2", Price = 1000m, Type = "Big ship" });

            commandFleet.PrintShips(spaceships);

            Console.WriteLine("Корабли с моделью Super ship: ");
            List<Spaceship> ans = spaceships.Where(s => s.Type == "Super ship").ToList();
            commandFleet.PrintShips(ans);

            Console.WriteLine("Корабли с ценой от 400 до 1150: ");
            ans = spaceships.Where(s => s.Price >= 400m && s.Price <= 1150m).ToList();
            commandFleet.PrintShips(ans);

            Console.WriteLine("Миссии корабля 001:");
            commandFleet.PrintMissions(commandFleet.GetMissions("001", missions));
        }
    }
}