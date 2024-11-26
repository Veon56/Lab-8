namespace Laboratorna8;

public enum AnimalGender 
{
    Male, Female
}

public abstract class Animal
{
    private byte _age;
    private double _weight;
    private AnimalGender _gender;
    
    public byte Age => _age;
    public double Weight => _weight;
    public AnimalGender Gender => _gender;

    public Animal()
    {
        _age = 0;
        _weight = 0;
        _gender = AnimalGender.Male;
    }


    public Animal(Animal other)
    {
        _age = other._age;
        _weight = other._weight;
        _gender = other._gender;
    }

    public Animal(byte age, double weight, AnimalGender gender)
    {
        _age = age;
        _weight = weight;
        _gender = gender;
    }

    public void Birthday()
    {
        _age++;
    }

    public void ChangeWeight()
    {
        Console.WriteLine("Input new weight");
        double newWeight = Convert.ToDouble(Console.ReadLine());
        _weight = newWeight;
    }
    
    public abstract void ChangeType();


    public virtual void ShowInfo()
    {
        Console.Write($"Age: {Age}, Weight: {Weight}, Gender: {Gender} ");
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }


    public override bool Equals(object? obj)
    {
        if ( obj is null ) return false;
        var other = (Animal) obj;

        return this._age == other._age
            && this._gender == other._gender
            && Math.Abs(this._weight - other._weight) < double.Epsilon;
    }

    public static bool operator ==(Animal x, Animal y)
    {
        return x.Equals(y);
    }

    public static bool operator !=(Animal x, Animal y)
    {
        return !x.Equals(y);
    }
}

