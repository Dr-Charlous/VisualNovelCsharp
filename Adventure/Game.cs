using System;
using System.IO;

namespace Adventure
{
    public class Game
    {
        bool _hasSword;
        bool _hasShield;
        bool _isHurt;

        public void Start()
        {
            Console.Clear();

            try
            {
                string asciiArt = File.ReadAllText("Forest.txt");
                Console.WriteLine(asciiArt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            Console.WriteLine("Bonjour Aventurier !");
            Console.WriteLine("Tu te réveilles dans une merveilleuse forêt.");
            Console.WriteLine("Tu ne comprends pas trop ce que tu fais là mais qu'importe");
            Console.WriteLine("Souhaites-tu te diriger vers");
            Console.WriteLine("1 : Le village");
            Console.WriteLine("2 : La montagne");

            string answer = Console.ReadLine();

            if (answer == "1")
            {
                Village();
            }
            else if (answer == "2")
            {
                Mountain();
            }
            else
            {
                Console.WriteLine("Votre réponse est trop grande !");
                Console.ReadLine();
                Start();
            }
        }

        public void Village()
        {
            Console.Clear();

            try
            {
                string asciiArt = File.ReadAllText("Village.txt");
                Console.WriteLine(asciiArt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            if (_hasSword == true && _hasShield == true && _isHurt == true)
            {
                Console.WriteLine("Tu as ramassé tout l'équipement qu'il y avait.");
                Console.WriteLine("Il n'y a plus rien dans le village tu retournes dans la forêt.");
                Console.ReadLine();
                Forest();

                return;
            }

            if (_hasSword == true && _hasShield == true && _isHurt == false)
            {
                try
                {
                    string asciiArt = File.ReadAllText("Puit.txt");
                    Console.WriteLine(asciiArt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine();

                Console.WriteLine("Tu as ramassé tout l'équipement qu'il y avait.");
                Console.WriteLine("Il n'y a plus rien dans le village appart le puit mystérieux.");
                Console.WriteLine("Que fais-tu ?");
                Console.WriteLine("1 : Aller dans le puit");
                Console.WriteLine("2 : Retourner dans la forêt");

                string _answer = Console.ReadLine();

                if (_answer == "1")
                {
                    Hole();
                }
                else if (_answer == "2")
                {
                    Forest();
                }
                else
                {
                    Console.WriteLine("Votre réponse est trop grande !");
                    Console.ReadLine();
                    Village();
                }

                return;
            }

            if (_hasSword == true)
            {
                Console.Clear();

                try
                {
                    string asciiArt = File.ReadAllText("Puit.txt");
                    Console.WriteLine(asciiArt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine();

                Console.WriteLine("Tu as déjà ramassé l'épée, celle-ci te semble légère.");
                Console.WriteLine("Il n'y a personne mais tu aperçois un puit mustérieux en plus de la forge.");
                Console.WriteLine("Que fais-tu ?");
                Console.WriteLine("1 : Aller dans la forge");
                Console.WriteLine("2 : Aller dans le puit");
                Console.WriteLine("3 : Retourner dans la forêt");

                string _answer = Console.ReadLine();

                if (_answer == "1")
                {
                    Forge();
                }
                else if (_answer == "2")
                {
                    Hole();
                }
                else if (_answer == "3")
                {
                    Forest();
                }
                else
                {
                    Console.WriteLine("Votre réponse est trop grande !");
                    Console.ReadLine();
                    Village();
                }

                return;
            }

            Console.WriteLine("Te voilà au village");
            Console.WriteLine("Il n'y a personne mais tu aperçois une épée magique et une forge.");
            Console.WriteLine("Que fais-tu ?");
            Console.WriteLine("1 : Récupérer l'épée");
            Console.WriteLine("2 : Aller dans la forge");
            Console.WriteLine("3 : Aller dans le puit");
            Console.WriteLine("4 : Retourner dans la forêt");

            string answer = Console.ReadLine();

            if (answer == "1")
            {
                Console.Clear();

                try
                {
                    string asciiArt = File.ReadAllText("Sword.txt");
                    Console.WriteLine(asciiArt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine();

                _hasSword = true;
                Console.WriteLine("Tu as ramassé l'épée, celle-ci te semble légère.");
                Console.WriteLine("Tu te balades un peu.");
                Console.ReadLine();
                Village();
            }
            else if (answer == "2")
            {
                Forge();
            }
            else if (answer == "3")
            {
                Hole();
            }
            else if (answer == "4")
            {
                Forest();
            }
            else
            {
                Console.WriteLine("Votre réponse est trop grande !");
                Console.ReadLine();
                Village();
            }
        }

        public void Forge()
        {
            Console.Clear();

            try
            {
                string asciiArt = File.ReadAllText("Forge.txt");
                Console.WriteLine(asciiArt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            if (_hasShield == true)
            {
                Console.Clear();

                try
                {
                    string asciiArt = File.ReadAllText("Shield.txt");
                    Console.WriteLine(asciiArt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine();

                Console.WriteLine("Tu as ramassé le bouclier, celui-ci te semble léger.");
                Console.WriteLine("Il n'y a plus rien dans la forge tu retournes dans le village.");
                Console.ReadLine();
                Village();

                return;
            }

            Console.WriteLine("Te voilà dans la forge du village");
            Console.WriteLine("Il n'y a personne mais tu aperçois un bouclier.");
            Console.WriteLine("Que fais-tu ?");
            Console.WriteLine("1 : Récupérer le bouclier");
            Console.WriteLine("2 : Retourner dans le village");

            string answer = Console.ReadLine();

            if (answer == "1")
            {
                Console.Clear();
                _hasShield = true;

                try
                {
                    string asciiArt = File.ReadAllText("Shield.txt");
                    Console.WriteLine(asciiArt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine();

                Console.WriteLine("Tu as ramassé le bouclier, celui-ci te semble léger.");
                Console.WriteLine("Il n'y a plus rien dans la forge tu retournes dans le village.");
                Console.ReadLine();
                Village();
            }
            else if (answer == "2")
            {
                Village();
            }
            else
            {
                Console.WriteLine("Votre réponse est trop grande !");
                Console.ReadLine();
                Forge();
            }
        }

        public void Mountain()
        {
            Console.Clear();

            try
            {
                string asciiArt = File.ReadAllText("Montagne.txt");
                Console.WriteLine(asciiArt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            Console.WriteLine("En haut de la montagne tu trouvez une grotte");
            Console.WriteLine("Une chaleur étouffante semble provenir de la grotte");
            Console.WriteLine("Que fais-tu ?");
            Console.WriteLine("1 : Entrer dans la grotte");
            Console.WriteLine("2 : Retourner dans la forêt");

            string answer = Console.ReadLine();

            if (answer == "1")
            {
                Cave();
            }
            else if (answer == "2")
            {
                Forest();
            }
            else
            {
                Console.WriteLine("Votre réponse est trop grande !");
                Console.ReadLine();
                Mountain();
            }
        }

        public void Forest()
        {
            Console.Clear();

            try
            {
                string asciiArt = File.ReadAllText("Forest.txt");
                Console.WriteLine(asciiArt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            Console.WriteLine("Tu te retrouves dans une merveilleuse forêt.");
            Console.WriteLine("Souhaites-tu te diriger vers");
            Console.WriteLine("1 : Le village");
            Console.WriteLine("2 : La montagne");

            string answer = Console.ReadLine();

            if (answer == "1")
            {
                Village();
            }
            else if (answer == "2")
            {
                Mountain();
            }
            else
            {
                Console.WriteLine("Votre réponse est trop grande !");
                Console.ReadLine();
                Forest();
            }
        }

        public void Hole()
        {
            Console.Clear();

            try
            {
                string asciiArt = File.ReadAllText("Spider.txt");
                Console.WriteLine(asciiArt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            Console.WriteLine("Tu te retrouves nez à nez avec une araignée");

            if (_hasSword == true)
            {
                Console.WriteLine("Heureusement tu disposes de l'épée magique qui permet de la terrasser sans le moindre effort");
                Console.WriteLine("Tu ressors ainsi victorieux et entier de cette bataille !");
                Console.ReadLine();
                Village();
            }
            else if (_isHurt == true)
            {
                Console.WriteLine("Malheureusement sans arme tu n'es qu'un amuse bouche pour l'araignée...");
                Console.WriteLine("Tu n'arrives pas a t'enfuir et meurt dans d'attroces douleurs.");
                Console.WriteLine("GAME OVER");
                Console.ReadLine();
            }
            else
            {
                _isHurt = true;
                Console.WriteLine("Malheureusement sans arme tu n'es qu'un amuse bouche pour l'araignée...");
                Console.WriteLine("Tu arrives a t'enfuir mais en étant blessé.");
                Console.ReadLine();
                Village();
            }
        }

        public void Cave()
        {
            Console.Clear();

            try
            {
                string asciiArt = File.ReadAllText("Dragon.txt");
                Console.WriteLine(asciiArt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            Console.WriteLine("Tu te retrouves nez à nez avec un dragon");

            if (_hasSword == true && _hasShield == true && _isHurt == false)
            {
                Console.WriteLine("Heureusement tu disposes de l'épée magique et d'un bouclier qui permet de le terrasser sans le moindre effort");
                Console.WriteLine("Tu ressors ainsi victorieux et riche de cette aventure !");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Malheureusement sans arme tu n'es qu'une brochette pour le dragon...");
                Console.WriteLine("GAME OVER");
                Console.ReadLine();
            }
        }
    }
}
