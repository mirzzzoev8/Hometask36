using Task2;
string dogName = Console.ReadLine();
Dog dog = new Dog();
dog.SetName(dogName);
Console.WriteLine("Dog's name =  " + dog.GetName());
dog.Eat();