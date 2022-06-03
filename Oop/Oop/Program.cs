// See https://aka.ms/new-console-template for more information

//Inheritance
using Oop.Abstraction;
using Oop.Inheritance;
using Oop.Interface;
using Oop.Polymorphism;

Car NewCar = new Car()
{
    ModelName = "Tiba"
};
Console.WriteLine(NewCar.ModelName);
Console.WriteLine(NewCar.BrandName);
NewCar.GetInfo();

Console.WriteLine();

//Polymorphism
Animal Obj = new Dog();
Obj.AnimalSound();
Obj.AnimalInfo();

Console.WriteLine();

//abstract
Women women = new Women();
women.Sleep();
women.ShowInfo();

Console.WriteLine();

//Interface
Square square = new Square(4);

Console.WriteLine(square.GetArea());
Console.WriteLine();

Console.WriteLine("Hello, World!");
Console.ReadKey();
