namespace ConsoleApp3 
{ 
    internal class Program 
    { 
        static void Main(string[] args) 
        { 
            while (true) 
            { 
                Console.Write("\n Введите номер дня недели:  "); 
                int num = int.Parse(Console.ReadLine()); 
                if (num >= 1 && num <= 5) 
                { 
                    Console.Write(" Нет "); 
                } 
 
                else if (num >= 6 && num <= 7) 
                { 
                    Console.Write(" Да "); 
                } 
                else Console.Write(" Нет "); 
                break;
            } 
        } 
    } 
}