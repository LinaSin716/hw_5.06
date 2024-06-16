using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_5._06
{
    public class Fleet : IFleetOperations
    {
        public List<Spaceship> AddSpaceship(List<Spaceship> spaceshipList, Spaceship spaceship)
        {
            spaceshipList.Add(spaceship);
            return spaceshipList;
        }
        public List<Spaceship> RemoveSpaceship(List<Spaceship> spaceshipList, Spaceship spaceship)
        {
            spaceshipList.Remove(spaceship);
            return spaceshipList;
        }
        public List<Mission> AddMission(string idShip, string name, string purpose, string Date, List<Mission> missions)
        {
            missions.Add(new Mission { Date = Date, ID = idShip, Name = name, Purpose = purpose });
            return missions;
        }
    }
}
