namespace Laboratorna8;

public enum Birdtype
{
    Flying, Ground
}

public class Bird : Animal
{
    private Birdtype _type;


    public Birdtype type => _type;

    public Bird() : base()
    {
        _type = Birdtype.Flying;
    }

    public Bird(Bird other) : base(other)
    {
        _type = other._type;
    }

    public Bird(byte age, uint weight, AnimalGender gender, Birdtype type) : base(age, weight, gender)
    {
        _type = type;
    }

    public override void ChangeType()
    {
        if(_type == Birdtype.Flying)
        {
            _type = Birdtype.Ground;
        }
        else
        {
            _type = Birdtype.Flying;
        }
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Type: {type} -- Bird");
    }

    
}