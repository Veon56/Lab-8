namespace Laboratorna8;

public enum Fishtype
{
    Freshwater, Oceanic
}

public class Fish : Animal
{
    private Fishtype _type;


    public Fishtype type => _type;

    public Fish() : base()
    {
        _type = Fishtype.Oceanic;
    }

    public Fish(Fish other) : base(other)
    {
        _type = other._type;
    }

    public Fish(byte age, uint weight, AnimalGender gender, Fishtype type) : base(age, weight, gender)
    {
        _type = type;
    }

    public override void ChangeType()
    {
        if(_type == Fishtype.Freshwater)
        {
            _type = Fishtype.Oceanic;
        }
        else
        {
            _type = Fishtype.Freshwater;
        }
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Type: {type} -- Fish");
    }
}