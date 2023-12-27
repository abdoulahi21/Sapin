using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapinNoel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //n egal nombre de ligne du sapin
            int n = 10;
           
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-i-1; j++) {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2*i+1; k++)
                {
                   
                    // Changer la couleur à chaque étoile
                    SetRandomConsoleColor();
                    Console.Write("*");
                    // Délai pour chaque caractère
                    Thread.Sleep(50);
                }
                Console.WriteLine();
            }
                for(int i = 0;i < n-1; i++)
                { 
                  Console.Write(" ");
            
                }
                Console.WriteLine("**");
                // Délai pour afficher le tronc
                Thread.Sleep(500);
            // Réinitialisation de la couleur
            Console.ResetColor();

        }
        static void SetRandomConsoleColor()
            {
                // Choisir une couleur aléatoire pour la console
                Array values = Enum.GetValues(typeof(ConsoleColor));
                ConsoleColor randomColor = (ConsoleColor)values.GetValue(new Random().Next(values.Length));
                Console.ForegroundColor = randomColor;
            }
    }
   
}
