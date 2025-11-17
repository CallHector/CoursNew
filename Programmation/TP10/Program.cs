using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10
{

    //Exercice 2

      public class Personnage
      {
          private int vie; //attribut
          private double vitesse; //attribut
          private int id; //attribut
          public Personnage()
          { //constructeur
              vie = 100;
              vitesse = 5;
          }
          public void marche()
          { //méthode
              Console.WriteLine("Je marche");
          }
          public void arrete()
          { //méthode
              Console.WriteLine("Je m’arrete");
          }

         public void soigneAllie() // Exercice 5
         {
            Console.WriteLine("Je soigne mon allié"); 
         }

        public void soignePerso() // Exercice 5
        {
            Console.WriteLine("Je me soigne");
        }

        public void Hit() // Exercice 5
        {
            Console.WriteLine("Vous êtes touché");
        }

        public int getVie()
          { //méthode de type « get »
              return vie;
          }
          public void setVie(int nouvelleValeur)
          { //méthode de type « set »
              vie = nouvelleValeur;
          }
      }

      public class Ennemi
      {
          private int pointsAttaque;
          private double vitesse;
          private int id;
          private int vie;
          public Ennemi()
          {
              vie = 100;
              vitesse = 5;
              pointsAttaque = 200;
          }

          public void attaque()
          { //méthode
              Console.WriteLine(" J’attaque: - " + pointsAttaque);
          }
          public void defend()
          { //méthode
              Console.WriteLine(" Je me défend ");
          }
          public void incrementerPointAttaque()
          { //méthode
              Console.WriteLine(" Je prépare mon attaque! ");
              pointsAttaque++;
          }
          public int getVie()
          { //méthode de type « get »
              return vie;
          }

        public void setVie(int nouvelleValeur) //Exercice 5
        { //méthode de type « set »
            vie = nouvelleValeur;
        }
        public int getAttaque()
          { //méthode de type « get »
              return pointsAttaque;
          }

        public void Hit() // Exercice 5
        {
            Console.WriteLine("L'ennemi subit des dégâts");
        }

    }

    //Exercice 3

    public class Allie
    {
        private int pointsAttaque;
        private int id;
        private int vie;
        public Allie()
        {
            vie = 100;
            pointsAttaque = 200;
        }

        public void attaque()
        { //méthode
            Console.WriteLine("L'allié attaque");
        }
        public void defendPersonnage()
        { //méthode
            Console.WriteLine("L'allié me défend");
        }
        public int getVie()
        { //méthode de type « get »
            return vie;
        }
        public void setVie(int nouvelleValeur)
        { //méthode de type « set »
            vie = nouvelleValeur;
        }
        public int getPointsAttaque()
        { //méthode de type « get »
            return pointsAttaque;
        }
        public void setPointsAttaque(int nouvelleValeurAttaque)
        { //méthode de type « set »
            pointsAttaque = nouvelleValeurAttaque;
        }

        public void Hit()
        {
            Console.WriteLine("L'allié subit des dégâts");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {

            // Exercice 2

            /* Personnage monPerso = new Personnage();
             Ennemi ennemi1 = new Ennemi();

             while (monPerso.getVie() > 0)
             {
                 monPerso.marche();
                 ennemi1.attaque();
                 Console.WriteLine("Vie personnage :" + monPerso.getVie());
                 Console.WriteLine("Vie ennemi :" + ennemi1.getVie());
                 Console.WriteLine("L’ennemi attaque :" + ennemi1.getAttaque());
                 monPerso.setVie(monPerso.getVie() - 20);
                 ennemi1.incrementerPointAttaque();
             }
             Console.WriteLine("C'est fini. Game Over!"); */

            //Exercice 3

            /* Personnage monPerso = new Personnage();
            Ennemi ennemi1 = new Ennemi();
            Allie allie1 = new Allie();  

            while (monPerso.getVie() > 0)
            {
                monPerso.marche();
                ennemi1.attaque();
                Console.WriteLine("Vie Allie :" + allie1.getVie());
                Console.WriteLine("Vie personnage :" + monPerso.getVie());
                Console.WriteLine("Vie ennemi :" + ennemi1.getVie());
                Console.WriteLine("L’ennemi attaque :" + ennemi1.getAttaque());
                monPerso.setVie(monPerso.getVie() - 20);
                ennemi1.incrementerPointAttaque();
            }
            Console.WriteLine("C'est fini. Game Over!"); 

            //Exercice 4 

            Personnage monPerso = new Personnage();
            Ennemi ennemi1 = new Ennemi();
            Allie allie1 = new Allie();
            int nbTours;
            nbTours = 5;

            while (nbTours >= 1 && monPerso.getVie() > 0)
            {
                monPerso.marche();
                ennemi1.attaque();
                Console.WriteLine("Vie Allie :" + allie1.getVie());
                Console.WriteLine("Vie personnage :" + monPerso.getVie());
                Console.WriteLine("Vie ennemi :" + ennemi1.getVie());
                Console.WriteLine("L’ennemi attaque :" + ennemi1.getAttaque());
                allie1.defendPersonnage();
                allie1.setVie(allie1.getVie() - 20);
                ennemi1.incrementerPointAttaque();
                nbTours--;
            }
            Console.WriteLine("C'est fini. Game Over!");
        } */

        //Exercice 5

        Personnage monPerso = new Personnage();
        Ennemi ennemi1 = new Ennemi();
        Allie allie1 = new Allie();
        int nbTours;
            nbTours = 10;
            string action ="";

            while (nbTours >= 1 && monPerso.getVie() > 0 && ennemi1.getVie() > 0)
            {
                Console.WriteLine("Vie Allie : " + allie1.getVie());
                Console.WriteLine("Vie personnage : " + monPerso.getVie());
                Console.WriteLine("Vie ennemi : " + ennemi1.getVie());
                Console.WriteLine("Choisissezvotre action : d pour se défendre, z pour soigner l'allié, a pour attaquer");
                action = Console.ReadLine();
                if (action == "d" || action == "D") // l'allié nous défend et on se soigne
                {
                    if (allie1.getVie() >= 0) // si l'allié est en vie
                    {

                        Console.WriteLine("L’ennemi attaque");
                        allie1.defendPersonnage();
                        allie1.setVie(allie1.getVie() - 20);
                        allie1.Hit();
                        if (monPerso.getVie() <= 80) // si on n'est pas déjà à la vie max, on se soigne, sinon il ne se passe rien
                        {
                            Console.WriteLine("Vous vous soignez");
                            monPerso.setVie(monPerso.getVie() + 20);
                        }
                    }
                    else // si l'allié est mort
                    {
                        if (monPerso.getVie() <= 80) // on se soigne si on n'est pas à la vie max
                        {
                            monPerso.soignePerso();
                            monPerso.setVie(monPerso.getVie() + 20);
                            Console.WriteLine("L’ennemi attaque");
                            monPerso.setVie(monPerso.getVie() - 20);
                            monPerso.Hit();
                        }
                        else // on subit juste l'attaque
                        {
                            Console.WriteLine("L’ennemi attaque");
                            monPerso.setVie(monPerso.getVie() - 20);
                            monPerso.Hit();
                        }
                    }
                }
                else if (action == "z" || action == "Z") //on soigne l'allié s'il est en vie
                {
                    if (allie1.getVie() <= 0 || allie1.getVie() > 80 && monPerso.getVie() <= 80) //on se soigne si l'allié est mort ou que sa santé est max et que la notre ne l'est pas
                    {
                        monPerso.soignePerso();
                        monPerso.setVie(monPerso.getVie() + 20);
                        Console.WriteLine("L’ennemi attaque");
                        monPerso.setVie(monPerso.getVie() - 20);
                        monPerso.Hit();
                    }
                    if (allie1.getVie() <= 80) // on soigne l'allié
                    {
                        monPerso.soigneAllie();
                        allie1.setVie(allie1.getVie() + 20);
                        Console.WriteLine("L’ennemi attaque");
                        monPerso.setVie(monPerso.getVie() - 20);
                        monPerso.Hit();
                    }
                    else //on ne soigne personne et on subit l'attaque
                    {
                        Console.WriteLine("L’ennemi attaque");
                        monPerso.setVie(monPerso.getVie() - 20);
                        monPerso.Hit();
                    }
                }
                else if (action == "a" || action == "A")
                {
                    allie1.attaque();
                    ennemi1.setVie(ennemi1.getVie() - 20);
                    ennemi1.Hit();
                    if (ennemi1.getVie() <= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("L’ennemi attaque");
                        monPerso.setVie(monPerso.getVie() - 20);
                        monPerso.Hit();
                    }
                }

                else
                {
                    Console.WriteLine("L’ennemi attaque");
                    monPerso.setVie(monPerso.getVie() - 20);
                    monPerso.Hit();
                }
                
 
                nbTours--;
            }
            if (nbTours <= 0 || ennemi1.getVie() <= 0)
            {
                Console.WriteLine("Félicitations, vous avez gagné !");
            }
            else if (monPerso.getVie() <= 0)
            {
                Console.WriteLine("C'est fini. Game Over!");
            }
    
        }
    }
}



    
