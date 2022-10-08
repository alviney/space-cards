using System.Collections.Generic;

public class ShipInitialiser : Initialiser
{
    public SO_ShipTemplate shipTemplate;

    public List<ShipModel> ships;

    protected override void LoadDependencies()
    {
        if (Store.data.ships.Count == 0)
        {
            Store.data.ships.Add(new ShipModel("1", 100f));
        }

        ships = Store.data.ships;
    }

    public override void Initialise()
    {
        base.Initialise();
    }
}
