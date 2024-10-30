namespace TheFinalSolution.Entities;

public class Character
{
    public Character()
    {
    }

    public Character(Guid id, string name, string @class, int stamina)
    {
       
        Id = id;
        Name = name;
        Class = @class;
        Stamina = stamina;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Class { get; set; }
    public int Stamina { get; set; }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}