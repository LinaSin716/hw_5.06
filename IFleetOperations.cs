using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_5._06
{
    public interface IFleetOperations
    {
        List<Spaceship> AddSpaceship(List<Spaceship> spaceshipList, Spaceship spaceship);
        List<Spaceship> RemoveSpaceship(List<Spaceship> spaceshipList, Spaceship spaceship);
        List<Mission> AddMission(string idShip, string name, string purpose, string Date, List<Mission> missions);
    }
}
