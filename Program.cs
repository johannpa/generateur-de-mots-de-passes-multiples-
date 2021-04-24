using System;
using UtilesCS;

namespace generateur_mot_de_passe
{
    class Program
    {
        
        static void Main(string[] args)
        {
            const int NB_MOT_DE_PASSE = 10;
            
            int longueurMotDPasse = outils.DemanderNombrePositifNonNul("Longueur du mot de passe : ");



            Console.WriteLine();

            int choixAlphabet = outils.DemanderNombreEntre("Vous voulez un mot de passe avec: \n" +
                "1 - Uniquement des caractères en miniscule \n" +
                "2 - Des caractères minuscule et majuscules \n" +
                "3 - Des caractères et des chiffres \n" +
                "4 - Caractères, chiffres et caractères spéciaux \n" +
                "Votre choix : ", 1, 4);

            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string chiffres = "0123456789";
            string caracteresSpeciaux = "#&+-/*€%$,;!";
            string alphabet;
            string motDePasse = "";
            Random rand = new Random();

            if (choixAlphabet == 1)
                alphabet = minuscules;
            else if (choixAlphabet == 2)
                alphabet = minuscules + majuscules;
            else if (choixAlphabet == 3)
                alphabet = minuscules + majuscules + chiffres;
            else
                alphabet = minuscules + majuscules + caracteresSpeciaux;


            int longueurAlphabet = alphabet.Length;

            for(int j = 0; j < NB_MOT_DE_PASSE; j++)
            {
                motDePasse = "";
                for (int i = 0; i < longueurMotDPasse; i++)
                {
                    int index = rand.Next(0, longueurAlphabet);
                    motDePasse += alphabet[index];
                }


                Console.WriteLine($"Mot de passe : {motDePasse}");
            }
            
            
            
   
        }
    }
}
