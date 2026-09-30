namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Je m'appelle Yannick et mon jeu preferer est Elden Ring");

        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.Write("Quel est ton prénom ? ");
        string prenom = Console.ReadLine();

        Console.Write("Quel âge as-tu ? ");
        int age = int.Parse(Console.ReadLine());
        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        if (age >= 18)
        {
            Console.WriteLine("Tu es majeur");
        }
        else
        {
            Console.WriteLine("Tu es mineur");
        }
        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
        Console.Write("Combien d'euros as-tu ? ");
        double argent = double.Parse(Console.ReadLine());
        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
        Console.WriteLine("1 - Épée    : 50 euros");
        Console.WriteLine("2 - Arc     : 35 euros");
        Console.WriteLine("3 - Hache   : 60 euros");
        Console.WriteLine("4 - Dague   : 20 euros");
        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
        Console.Write("Choisis une arme (1, 2, 3 ou 4) : ");
        int choix = int.Parse(Console.ReadLine());
        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4
        if (age >= 18 && argent >= prix)
        {
            argent = argent - prix;   // on retire le prix
            Console.WriteLine("Achat réussi ! Il te reste " + argent + " euros.");
        }
        else
        {
            Console.WriteLine("L'action n'a pas été possible.");
        }

        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}