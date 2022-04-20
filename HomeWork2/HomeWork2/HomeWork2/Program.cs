// See https://aka.ms/new-console-template for more information

// 1.Izveidot konsoles aplikāciju, kas pavaicā un  iegūst lietotāja vārdu, un sasveicinās ar konkrēto lietotāju

Console.WriteLine("Kā tevi sauc?");
string userName = Console.ReadLine();
Console.WriteLine($"Sveiks, {userName}!");

Console.WriteLine();
Console.WriteLine("========================================================");
Console.WriteLine();


// 2. Iegūst lietotāja vecumu un izvada lietotājam cik gadi viņam paliks nākamgad int.Parse.

Console.WriteLine("Kāds ir tavs vecums?");
string userAgeText = Console.ReadLine();
int userAge = int.Parse(userAgeText);
int userAgeNext = userAge + 1;
Console.WriteLine($"Nākamgad tev paliks {userAgeNext}, Tu esi pilngadīgs");


Console.WriteLine();
Console.WriteLine("========================================================");
Console.WriteLine();

// Iegūt no lietotāja skaitļus

Console.WriteLine("Norādi divus skaitļus");
Console.WriteLine("Pirmais skaitlis:");
string xText = Console.ReadLine();
int x = int.Parse(xText);
Console.WriteLine("Otrs skaitlis:");
string yText = Console.ReadLine();
int y = int.Parse(yText);

Console.WriteLine();
Console.WriteLine("========================================================");
Console.WriteLine();

// 3.Atrādīt lietotājam lielāko skaitli izmantojot Math.Max
int maxNumber = Math.Max(x, y);
Console.WriteLine($"Lielākais no norādītajiem skaitļiem ir {maxNumber}");

Console.WriteLine();
Console.WriteLine("========================================================");
Console.WriteLine();

// 4.Atrādīt lietotājam mazāko skaitli izmantojot Math. Min 
int minNumber = Math.Min(x, y);
Console.WriteLine($"Mazākais no norādītajiem skaitļiem ir {minNumber}");

Console.WriteLine();
Console.WriteLine("========================================================");
Console.WriteLine();

// 5.Iegūt skaitļu dalījuma atlikumu izmantojot - %
int numberBalance = x % y;
Console.WriteLine($"Skaitļu dalījuma atlikums no norādītajiem skaitļiem ir {numberBalance}");

Console.WriteLine();
Console.WriteLine("========================================================");
Console.WriteLine();

// 6.Parādīt vai lietotājs ievadījis pāra vai nepāra skaitli
int xDivide = x % 2;
bool xTrue = xDivide == 0;

Console.WriteLine($"Pirmais ievadītais skaitlis ir pāra skaitlis:{xTrue}");

int yDivide = y % 2;
bool yTrue = yDivide == 0;

Console.WriteLine($"Otrs ievadītais skaitlis ir pāra skaitlis:{yTrue}");

Console.WriteLine();
Console.WriteLine("========================================================");
Console.WriteLine();

// 7. Iegūt no lietotāja taisnstūra malu vērtības un aprēķināt taisnstūra laukumu. Decimāldaļās jānoapaļo ar 2 cipariem aiz komata

Console.WriteLine("Norādi taisnstūra malu vertības");
Console.WriteLine("Vienas malas vērtība:");
string aText = Console.ReadLine();
double a = double.Parse(aText);
Console.WriteLine("Otras malas vērtība:");
string bText = Console.ReadLine();
double b = double.Parse(bText);

double resultArea = a * b;
double raundedResult = Math.Round(resultArea, 2);
Console.WriteLine($"Taisnstūra laukums ir {raundedResult}");

Console.WriteLine();
Console.WriteLine("========================================================");
Console.WriteLine();

// 8.Iegūt no lietotāja skaitli, lai aprēķinātu taisnleņķa vienādsānu trijstūra laukumu 

Console.WriteLine("Norādi sānu malas garumu");
string LenghtText = Console.ReadLine();
int Lenght = int.Parse(LenghtText);
int Area = (Lenght * Lenght) / 2;
Console.WriteLine($"Taisnleņķa vienādsānu trijstūra laukums ir {Area}");

Console.WriteLine();
Console.WriteLine("========================================================");
Console.WriteLine();

// 9. Iegūst lietotāja vecumu un izvada lietotājam vārdu un vecumu izmantojot interpolāciju

Console.WriteLine("Kāds ir tavs vārds?");
string Name = Console.ReadLine();
Console.WriteLine("Kāds ir tavs vecums?");
string ageText = Console.ReadLine();
int age = int.Parse(ageText);
Console.WriteLine($"Sveiks {Name}, tavs vecums ir {age}");


