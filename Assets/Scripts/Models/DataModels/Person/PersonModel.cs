public class PersonModel : DatabaseModel
{
    public string name;

    public int level;

    public int health;
    public int speed;
    public int strength;
    public int defence;

    public int fear;
    public int bond;

    // Special
    public int cook;
    public int pilot;
    public int cargo;
    public int spy;
    public int engineer;
    public int medical;
    public int combat;

    public string[] actions;

    public PersonModel(string id) : base(id)
    {

    }
}