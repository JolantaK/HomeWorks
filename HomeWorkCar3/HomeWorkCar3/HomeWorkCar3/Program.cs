// Izveidot klasi mašīna. Mašinai ir marka, nummurzīme un ātrums. Mašīna māk sākt braukt, palielināt ātrumu, beigt braukt, samazināt ātrumu. Mašīna māk arī uztaurēt (Izvada konsolē "Beep beep")

using HomeWorkCar3;

Car first = new Car();

Console.WriteLine("Ievadi automašīnas marku");
string brand = Console.ReadLine();

Console.WriteLine("Ievadi automašīnas numuru");
string numberPlate = Console.ReadLine();

Console.WriteLine("Ievadi automašīnas ātrumu");
string speedText = Console.ReadLine();
double speed = double.Parse(speedText);

first.Brand = brand;
first.NumberPlate = numberPlate;
first.Speed = speed;

first.Cheer();
