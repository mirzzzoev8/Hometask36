using Task1;
Console.WriteLine("Enter  fuel : ");
int Fuel = Convert.ToInt32(Console.ReadLine());
Car car = new Car(Fuel);
Console.WriteLine("Enter amount refuel: ");
int fuelToRefuel = Convert.ToInt32(Console.ReadLine());
car.Refuel(fuelToRefuel);
car.Drive();