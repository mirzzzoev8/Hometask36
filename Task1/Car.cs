namespace Task1;

public class Car
{
    int fuel;
    public Car(int _ff)
    {
        fuel = _ff;
    }
    public void Drive(){
        if(fuel > 0)
        System.Console.WriteLine("Driving");
    }
    public bool Refuel(int a){
        fuel+=a;
        return true;
    }
}
