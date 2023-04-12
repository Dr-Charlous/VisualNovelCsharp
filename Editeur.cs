using System;
using System.IO;

namespace Adventure
{
    class Editeur
    {
        public string[] lines;
        public string[] linesNext;
        public bool _Obj;

        public void Main(string file)
        {
            Console.Clear();

            if (file.Contains("Obtenu"))
            {
                _Obj = true;
            }

            try
            {
                lines = File.ReadAllLines(file);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            linesNext = lines[lines.Length - 1].Split(',');

            for (int i = 0; i < lines.Length; i++)
            {
                if (i < lines.Length - 1)
                {
                    Console.WriteLine(lines[i]);
                    if (i == 0 || i == lines.Length - 3) 
                    {
                        Console.WriteLine();
                    }
                }
                else
                {
                    for (int j = 0; j < linesNext.Length; j++)
                    {
                        Console.WriteLine($"{j} : {linesNext[j]}");
                    }
                }
            }


            int go = int.Parse(Console.ReadLine());


            if (go < linesNext.Length)
            {
                Main($@"{linesNext[go]}.txt");
            }
            else
            {
                Main(file);
            }
        }
    }
}
