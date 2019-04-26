using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace gam
{
    class Program
    {
         
        string[] bag = new string[100];
        static void Main(string[] args)
        {



            //console
            if (args.Length != 0)
            {
                if (args[0] == "1")
                {
                    AlternatePathOfExecution();
                }
                //add other options here and below              
            }
            else
            {
                NormalPathOfExectution();
            }
            //




            string m_pName = "";
            char status = 'n';
            string uEntry;

            string command = "";
            WriteLine("Hello Welcome to the World of Verdorbenes Schicksal");
          
            while (status != 'y')
            {
                WriteLine("Enter your name:");
                m_pName = ReadLine();
                // WriteLine(p.getName());
                WriteLine("Are you sure you want to keep this name? (enter y for yes, n for no");
                uEntry = ReadLine();
                char.TryParse(uEntry, out status);
            }
            Player p = new Player(m_pName);

        
          

            WriteLine("Great, " + p.getName() + " You are ready");
            Thread.Sleep(1000);
            WriteLine("Good Luck on your quest to reach Sage Clarke...");
            Thread.Sleep(3000);
            Write("You'll Need it.");
            Thread.Sleep(2000);

            Console.Clear();

            WriteLine("Hello " + m_pName + " My name is Colin, I am a disciple of Sage Clarke.");
            status = 'n';
            while (status != 'y')
            {
                WriteLine("I see you want to start a new journey, is that correct? ");
                Thread.Sleep(3000);
                WriteLine("(enter y for yes, n for no)");
                uEntry = ReadLine();
                char.TryParse(uEntry, out status);
                Thread.Sleep(500);
                if (status == 'n')
                {


                    WriteLine("Wrong Answer");
                }
            }
            Thread.Sleep(2000);
            Console.Clear();

            WriteLine("Great!, right now I will teach you how to access your bag");
            WriteLine("<Type 'bag' to access your bag at any time");
            Thread.Sleep(2000);
            WriteLine("How to access your stats...");
            WriteLine(",Type 'stats' to access your status at any time");
            Thread.Sleep(2000);

            //Tutorial
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------

            if (ReadLine() != "bag" || ReadLine() != "stats")
            {
                WriteLine("Also, what class would you like to be?");
                Thread.Sleep(1500);
                WriteLine("Mages are glass cannons, they do massive damage but lack defense");
                Thread.Sleep(2500);
                WriteLine("Paladins are tanks, they can take alot but can dish out very little");
                Thread.Sleep(2500);
                WriteLine("As for me I am an epic gamer...");
                Thread.Sleep(2500);
                WriteLine("I have no strengths what so ever.");
                Thread.Sleep(2500);
                WriteLine("oh... yeah you can also be a swordsman... have decent defense and attack, y'know?");
                Thread.Sleep(3000);
                Console.Clear();
                ReadLine();

            }
             else if (ReadLine() == "bag")
            {

            }
            else if (ReadLine() == "stats")
            {
                WriteLine(p.getCharacterInfo());
            }
            
            
        
           
            ReadKey();
        }
        private static void NormalPathOfExectution()
        {
            Console.WriteLine("Doing something here");
            //need one of these for each additional console window
            System.Diagnostics.Process.Start("gam.exe", "1");
            Console.ReadLine();

        }
        private static void AlternatePathOfExecution()
        {
            Console.WriteLine("Write something different on other Console");
            Console.ReadLine();

        }

    }
}
