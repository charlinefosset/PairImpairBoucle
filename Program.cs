using System.ComponentModel.DataAnnotations;

namespace PairImpairBoucle;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes
         * Demandez à l'utilisateur un nombre
         *
         * Dites à l'utilisateur si le nombre fourni est pair ou impair
         * Demandez à l'utilisateur s'il veut proposer un autre nombre
         *  On lui permet de le faire lorsqu'il entre "y". Dans les autres cas, on termine le programme
         */
        string yesno;

        int number;
        do
        {
            Console.WriteLine("Dites un nombre entier");
            number = Convert.ToInt32(Console.ReadLine());
            if (number%2==0)
            {
                Console.WriteLine("C'est pair");
            }
            else
            {
                Console.WriteLine("C'est impair");
            }

            Console.WriteLine("Voulez-vous tester un autre nombre? (y/n)");
            yesno = Console.ReadLine();
        } while ( yesno  == "y");

        Console.WriteLine("Merci d'avoir essayé!!");
     
            
       
        
       
    }
    
}
