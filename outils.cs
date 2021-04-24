using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// generateur_mot_de_passe.outils.DemanderNombrePositifNonNul

namespace UtilesCS
{
    static class outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue, "ERREUR : Le nombre doit être positif et non null");
        }


        public static int DemanderNombreEntre(string question, int min, int max, string messageErreurPersonnalise = null)
        {
            while (true)
            {
                int nombre = DemanderNombre(question);

                if (nombre >= min && nombre <= max)
                {
                    return nombre;
                }
                if(messageErreurPersonnalise == null)
                {
                    Console.WriteLine($"ERREUR : Le nombre doit être entre {min} et {max}");
                }
                else
                {
                    Console.WriteLine(messageErreurPersonnalise);
                }
                    
                Console.WriteLine();
            }
        }

        public static int DemanderNombre(string question)
        {

            int reponseInt = 0;

            while (true)
            {
                Console.Write(question);
                string reponse = Console.ReadLine();

                try
                {
                    reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine("ERREUR : il faut un nombre !");
                    Console.WriteLine();
                }
            }
        }
    }
}
