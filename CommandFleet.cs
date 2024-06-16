using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_5._06
// без JSON
{
    public class CommandFleet : Fleet
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public string Experience { get; set; }
        public CommandFleet(string name, string rank, string experience)
        {
            Name = name;
            Rank = rank;
            Experience = experience;
        }

        public void PrintShips(List<Spaceship> spaceships)
        {
            Console.WriteLine("Корабли: \n\nID\tназвание\tмодель\t\tстоимость");
            foreach (Spaceship spaceship in spaceships)
            {
                Console.WriteLine($"{spaceship.ID}\t{spaceship.Name}\t\t{spaceship.Type}\t{spaceship.Price}");
            }
            Console.WriteLine();
        }
        public void PrintMissions(List<Mission> missions)
        {
            Console.WriteLine("Миссии: \n\nID\tназвание\tцель\tдата начала");
            foreach (Mission mission in missions)
            {
                Console.WriteLine($"{mission.ID}\t{mission.Name}\t{mission.Purpose}\t{mission.Date}");
            }
            Console.WriteLine();
        }

        public List<Mission> GetMissions(string Id, List<Mission> missions)
        {
            return missions.Where(m => m.ID == Id).ToList();
        }
    }
}
