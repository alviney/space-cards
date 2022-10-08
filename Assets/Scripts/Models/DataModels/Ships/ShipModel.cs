public class ShipModel : DatabaseModel, I_Ship
{
    public float fuel { get; set; }

    public ShipModel(string id, float fuel): base(id) {
        
    }
}
