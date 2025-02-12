using System;
using System.Windows.Forms;
namespace زياد_عبده_احمد_محمد_ابوراس_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char c;
            Console.WriteLine("Enter 1 to launch Form1 lab12\n");
            Console.WriteLine("Enter 2 to launch Form2 lab12\n");
            Console.WriteLine("Enter 2 to exit \n >>>>>>>>> :  ");
            do
            {
                c = Console.ReadKey().KeyChar;
                switch (c)
                {
                    case '0':
                        Application.Exit();
                        return;
                    case '1':
                        Application.Run(new Form1Lab12());
                        return;
                    case '2':
                        Application.Run(new Form2Lab12());
                        return;
                    default:
                        Console.WriteLine("please enter valid value (0,1,2) \n >>>>>>>>> :  ");
                        break;
                }

            } while (c != 48 || c != 49 || c != 50);
        }
    }
}
