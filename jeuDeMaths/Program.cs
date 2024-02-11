namespace jeuDeMaths
{
    internal class Program
    {
        enum e_Operateur
        {
            ADDITION = 1,
            SUBTRACTION = 2,
            MULTIPLICATION = 3,
            DIVISION = 4,
        }

        static bool PoserQuestion(int MIN, int MAX)
        {
            int reponseNum = MAX + 1;

            while (true)
            {
                int a = new Random().Next(MIN, MAX + 1);
                int b = new Random().Next(MIN, MAX);
                const int OPERATEUR_MIN = 0;
                const int OPERATEUR_MAX = 4;
                e_Operateur operateur = (e_Operateur) new Random().Next(OPERATEUR_MIN, OPERATEUR_MAX + 1);
                int operation = OPERATEUR_MAX + 1;

               /* if (operateur == e_Operateur.ADDITION)
                {
                    operation = a + b;
                    Console.Write("{0} + {1} = ", a, b);
                }
                else if (operateur == e_Operateur.SUBTRACTION)
                {
                    operation = a - b;
                    Console.Write("{0} - {1} = ", a, b);
                }
                else if(operateur == e_Operateur.MULTIPLICATION)
                {
                    operation = a * b;
                    Console.Write("{0} x {1} = ", a, b);
                }
                else if (operateur == e_Operateur.DIVISION)
                {
                    operation = a / b;
                    Console.Write("{0} / {1} = ", a, b);
                }
                else
                {
                    Console.WriteLine("Erreur! Opération non valide");
                    return false;
                }*/

                switch(operateur)
                {
                    case e_Operateur.ADDITION:
                        operation = a + b;
                        Console.Write("{0} + {1} = ", a, b);
                        break;

                    case e_Operateur.SUBTRACTION:
                        operation = a - b;
                        Console.Write("{0} - {1} = ", a, b);
                        break;

                    case e_Operateur.MULTIPLICATION:
                        operation = a * b;
                        Console.Write("{0} x {1} = ", a, b);
                        break;

                    case e_Operateur.DIVISION:
                        operation = a / b;
                        Console.Write("{0} / {1} = ", a, b);
                        break;

                    default:
                        Console.WriteLine("Erreur! Opérateur inconnu.");
                        return false;
                }

                string reponse = Console.ReadLine();

                try
                {
                    reponseNum = int.Parse(reponse);

                    if (reponseNum == operation)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch
                {
                    Console.WriteLine("Erreur!! Entrez un nombre valide");
                }
            }
            
                        
            /*
            if ()
            {
                Console.WriteLine("Bonne réponse!");
            }
            else
            {
                Console.WriteLine("Mauvaise réponse");
            }*/
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans notre jeu de math");
            const int MIN = 0;
            const int MAX = 10;
            const int NB_QUESTION = 3;
            int points = 0;

            for (int i = 0; i < NB_QUESTION; i++)
            {                
                Console.WriteLine("Question n° {0} sur {1}", (i + 1), NB_QUESTION);
                Console.WriteLine();

                bool bonneReponse = PoserQuestion(MIN, MAX);

                if (bonneReponse)
                {
                    Console.WriteLine("Bonne réponse!");
                    points++;
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse");
                }
            }

            Console.WriteLine("Nombres de points: {0} sur {1}", points, NB_QUESTION);

            int moyenne = NB_QUESTION / 2;

            if (points == NB_QUESTION)
            {
                Console.WriteLine("Excellent!");
            }
            else if (points == 0)
            {
                Console.WriteLine("Révisez vos maths");
            }
            else if (points > moyenne)
            {
                Console.WriteLine("Pas mal!");
            }
            else if (points <= moyenne)
            {
                Console.WriteLine("Peut mieux faire!");
            }
        }
    }
}
