
using HomeWork3;

Phone first = new Phone();

Console.WriteLine("Ievadiet telefona marku");
string brand = Console.ReadLine();

Console.WriteLine("Ievadiet telefona modeli");
string model = Console.ReadLine();

Console.WriteLine("Ievadiet telefona garumu");
string lengthText = Console.ReadLine();
int length = int.Parse(lengthText);

Console.WriteLine("Ievadiet telefona platumu");
string widthText = Console.ReadLine();
int width = int.Parse(widthText);

Console.WriteLine("Ievadiet telefona augstumu");
string heightText = Console.ReadLine();
int height = int.Parse(heightText);

first.Brand = brand;
first.Model = model;
first.Length = length;
first.Width = width;
first.Height = height;

Console.WriteLine($"Apsveicam, Jūsu {brand} {model} telefons ar parametriem: garums - {length}; platums - {width}; augstums - {height} ir atrasts!");