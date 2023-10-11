//Funtion

// Main command
string ID, Name; ID = Name = "";
double Price, Amout, price = Amout = 0.00;
Input();
display();

// Function
void display()
{
    Console.WriteLine($"ID : {ID} | Name : {Name} | Price : {price} | Amout : {Amout}");
}
void Input()
{
    Console.Write("ID    | ");ID = Console.ReadLine();
    Console.Write("name  | ");Name = Console.ReadLine();
    Console.Write("price | ");price = double.Parse(Console.ReadLine());
    Console.Write("Amout | ");Amout = Process();
}
double Process()
{
    double sum = 20.25;
    return price * sum;
}