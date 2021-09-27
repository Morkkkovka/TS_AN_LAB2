using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_AN_LAB2__task3_
{
    class Book
    {
        public class Title
        {

            public string title;

            public void Show()
            {

                if (title == "")
                {
                    title = "Аліса в країні чудес!";
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"{title}\n\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"{title}\n\n");
                }
            }
        }

        public class Author
        {

            public string author;

            public void Show()
            {

                if (author == "")
                {
                    author = " Льюїс Керрол";
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Автор книги: {author}\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Автор книги: {author}\n");
                }
            }
        }
        public class Content
        {

            public string content;

            public void Show()
            {
                if (content == "")
                {
                    content = "Маленька дівчинка, кролик з годинником, чудеса, пригоди";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Книга написана о {content}\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Книга про  {content}\n");
                    Console.ResetColor();
                }
            }
        }
    }

    class Program

    {
        static void Main(string[] args)

        {

            Book.Title name = new Book.Title();
            Book.Author writer = new Book.Author();
            Book.Content consist = new Book.Content();

            Console.WriteLine("Ведіть назву вашої книги");
            name.title = Console.ReadLine();
            Console.WriteLine("Введіть назву автора");
            writer.author = Console.ReadLine();
            Console.WriteLine("Введіть ключові слова книги");
            consist.content = Console.ReadLine();
            
            Console.WriteLine("Ваша книга!\n");
            name.Show();
            writer.Show();
            consist.Show();
        }
                    
     
        
    }
}
