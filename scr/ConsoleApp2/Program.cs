
using System.Security.Cryptography;

bool tumb = false, krovat = false, vent = false;
bool masterKey = false;
bool lockpick = false;
Main();
void Main()
{
    
    string name = "";
    Console.WriteLine("Введите своё имя");
    name = Console.ReadLine();
    Console.WriteLine("Здравтсвуй " + name + ",Вы очнулись в неизвестном вам помещении. Оглядевшись вы понимаеше, что вокруг вас никого нету." +
        "Рядом вы замечаете дверь, сундук и несколько дверных проёмов.");
    start();

}
void start()
{
    Console.Clear();
    string choice = "";
    Console.WriteLine("1 - открыть дверь\n2 - заглянуть под кровать\n3 - открыть ящик в углу комнаты\n4 - открыть винтеляцию.\n5 - взглянуть на тумбочку\n6 - посмотреть на статую");
    choice = Console.ReadLine();
    if (choice == "1")
    {
    if (lockpick==true)
        {
            Console.WriteLine("Вы открыли дверь при помощи отмычки");
            Console.WriteLine("Вы сбежали");
        }
    else
        {
            Console.WriteLine("Вы не можете открыть дверь");
            Console.WriteLine("нажмите любую клавишу для возвращение в комнату");
            Console.ReadLine();
            start();
        }
    }
    else if (choice == "2")
    {
        krovat = true;
        Console.WriteLine("вы нашли артефакт под кроватью.\nнажмите любую клавишу для возвращение в комнату");
        Console.ReadLine();
        start();
    }
    else if (choice == "3")
    {
        if (masterKey == true)
        {
            Console.WriteLine("Вы смогли открыть ящик при помощи ключа\nНа дне ящика вы видите отмычку и берёте её\n Отмычка получена");
            lockpick = true;
            Console.ReadLine();
            start();
            
        }
        else
        {

        Console.WriteLine("Вы не можете открыть ящик\nнажмите любую клавишу для возвращение в комнату");
        Console.ReadLine();
        start();
        }
    }
    else if (choice == "4")
    {
        vent = true;
        Console.WriteLine("вы нашли артефакт в винтеляции.\nнажмите любую клавишу для возвращение в комнату");
        Console.ReadLine();
        start();
    }
    else if (choice == "5")
    {
        tumb = true;
        Console.WriteLine("вы нашли артефакт на тумбочке.\nнажмите любую клавишу для возвращение в комнату");
        Console.ReadLine();
        start();
    }
    else if (choice == "6")
    {
        Console.WriteLine("Вы смотрете на стутую");
        if (tumb == true && krovat == true && vent == true)
        {
            Console.WriteLine("Вы активировали статую.\n Ключ получен");
            masterKey = true;
            Console.WriteLine("Нажмите любую клавишу для возвращение в комнату");
            Console.ReadLine();
            start();
        }
        else
        {
            Console.WriteLine("Вы не можете активировать статую.");
            Console.WriteLine("нажмите любую клавишу для возвращение в комнату");
            Console.ReadLine();
            start();
        }
    }
}
