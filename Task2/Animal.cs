namespace Task2;
public abstract class Animal
{
    public string Name { get; set; }

    public void SetName(string _name)
    {
        Name = _name;
    }

    public string GetName()
    {
        return Name;
    }

    public abstract void Eat();
}
