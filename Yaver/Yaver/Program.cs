Console.WriteLine("0.Close App");
Console.WriteLine("1.Register");
Console.WriteLine("2.Login");
Console.WriteLine();

string Request = Console.ReadLine().Trim();

while (Request != "0") 
{ 
Console.Clear();
    switch(Request)
    {
        case "1":
            Console.WriteLine();
            break;
            case "2": Console.WriteLine(); break;
            case "3": Console.WriteLine(); break;
            case "4": Console.WriteLine(); break;
            case "5": Console.WriteLine(); break;
            default: Console.WriteLine(); break;
    }
    Console.WriteLine("0.Close App");
    Console.WriteLine("1.Register");
    Console.WriteLine("2.Login");
    Console.WriteLine();
    Request = Console.ReadLine().Trim();

}