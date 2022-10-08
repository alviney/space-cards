using System.Collections.Generic;

public class ShipsManager : Manager
{
    public List<Ship> ships = new List<Ship>();

    public void Initialise(ShipInitialiser shipInitialiser)
    {
        foreach (ShipModel model in shipInitialiser.ships)
        {
            ships.Add(((ShipSpawner)spawner).SpawnShip(model));
        }
    }
}
