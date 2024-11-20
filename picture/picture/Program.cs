using pictureLib;
while (true)
{
    Console.WriteLine("Введите имя художника: ");
    string user = Console.ReadLine();
    Picture us = new(user);
    us.Print();

    us.Time();
    Console.Write("выйти из приложения, да или нет : ");
    string esc = Console.ReadLine();

    if (esc.ToLower() == "да")
    {
        break;
    }
}

