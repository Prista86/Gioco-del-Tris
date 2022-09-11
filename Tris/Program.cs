using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tris
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Esercizi per casa !!!
            //- scrivere un programma che simuli il gioco del tris:
            //- 2 giocatori
            //- box di 3x3, simboli O, X
            //- vince il giocatore che fa tris+

            Console.WriteLine("Ciao! Benvenuto nel fantastico gioco del tris!!! ");
            Console.WriteLine("Preferisci giocare una partita a due giocatori '2' o da solo contro il computer '1' ?");
            string sceltaC = Console.ReadLine();
            bool success = int.TryParse(sceltaC, out int scelta);            
            if (scelta == 2)
            {
                Console.Clear();
                Console.WriteLine("Bene hai scelto la partita a 2 giocatori! Buon divertimento!");
                Console.WriteLine("");
                string simbolo = "";
                int count = 0;
                string[] riga1 = new string[] { "1", " ", "|", " ", "|", " " };
                string[] riga2 = new string[] { "2", " ", "|", " ", "|", " " };
                string[] riga3 = new string[] { "3", " ", "|", " ", "|", " " };
                                
                Console.Write(riga1[0]);
                Console.Write(riga1[1]);
                Console.Write(riga1[2]);
                Console.Write(riga1[3]);
                Console.Write(riga1[4]);
                Console.WriteLine(riga1[5]);
                Console.WriteLine(" -+-+-");

                Console.Write(riga2[0]);
                Console.Write(riga2[1]);
                Console.Write(riga2[2]);
                Console.Write(riga2[3]);
                Console.Write(riga2[4]);
                Console.WriteLine(riga2[5]);
                Console.WriteLine(" -+-+-");

                Console.Write(riga3[0]);
                Console.Write(riga3[1]);
                Console.Write(riga3[2]);
                Console.Write(riga3[3]);
                Console.Write(riga3[4]);
                Console.WriteLine(riga3[5]);
                Console.WriteLine(" a b c");



                while (true)
                {
                    count++;
                    if (count % 2 == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(" Tocca a SECONDO Giocatore ! ( O ) ");
                        simbolo = "O";
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine(" Tocca a PRIMO Giocatore ! ( X ) ");
                        simbolo = "X";
                    }

                    Console.WriteLine("Inserisci le cordinate ( per esempio a1 ) ");
                    String cordinate = Console.ReadLine();
                    if (cordinate == "a1")
                    {
                        if (riga1[1] == " ")
                        {
                            Console.Clear();
                            riga1[1] = simbolo;
                            Console.Write(riga1[0]);
                            Console.Write(riga1[1]);
                            Console.Write(riga1[2]);
                            Console.Write(riga1[3]);
                            Console.Write(riga1[4]);
                            Console.WriteLine(riga1[5]);
                            Console.WriteLine(" -+-+-");

                            Console.Write(riga2[0]);
                            Console.Write(riga2[1]);
                            Console.Write(riga2[2]);
                            Console.Write(riga2[3]);
                            Console.Write(riga2[4]);
                            Console.WriteLine(riga2[5]);
                            Console.WriteLine(" -+-+-");

                            Console.Write(riga3[0]);
                            Console.Write(riga3[1]);
                            Console.Write(riga3[2]);
                            Console.Write(riga3[3]);
                            Console.Write(riga3[4]);
                            Console.WriteLine(riga3[5]);
                            Console.WriteLine(" a b c");
                        }
                        else
                        {
                            Console.WriteLine("Mi dispiace non puoi inserlo li");
                            count--;
                        }

                    }
                    else if (cordinate == "b1")
                    {
                        if (riga1[3] == " ")
                        {
                            Console.Clear();
                            riga1[3] = simbolo;
                            Console.Write(riga1[0]);
                            Console.Write(riga1[1]);
                            Console.Write(riga1[2]);
                            Console.Write(riga1[3]);
                            Console.Write(riga1[4]);
                            Console.WriteLine(riga1[5]);
                            Console.WriteLine(" -+-+-");

                            Console.Write(riga2[0]);
                            Console.Write(riga2[1]);
                            Console.Write(riga2[2]);
                            Console.Write(riga2[3]);
                            Console.Write(riga2[4]);
                            Console.WriteLine(riga2[5]);
                            Console.WriteLine(" -+-+-");

                            Console.Write(riga3[0]);
                            Console.Write(riga3[1]);
                            Console.Write(riga3[2]);
                            Console.Write(riga3[3]);
                            Console.Write(riga3[4]);
                            Console.WriteLine(riga3[5]);
                            Console.WriteLine(" a b c");
                        }
                        else
                        {
                            Console.WriteLine("Mi dispiace non puoi inserlo li");
                            count--;
                        }
                    }
                    else if (cordinate == "c1")
                    {
                        if (riga1[5] == " ")
                        {
                            Console.Clear();
                            riga1[5] = simbolo;
                            Console.Write(riga1[0]);
                            Console.Write(riga1[1]);
                            Console.Write(riga1[2]);
                            Console.Write(riga1[3]);
                            Console.Write(riga1[4]);
                            Console.WriteLine(riga1[5]);
                            Console.WriteLine(" -+-+-");

                            Console.Write(riga2[0]);
                            Console.Write(riga2[1]);
                            Console.Write(riga2[2]);
                            Console.Write(riga2[3]);
                            Console.Write(riga2[4]);
                            Console.WriteLine(riga2[5]);
                            Console.WriteLine(" -+-+-");

                            Console.Write(riga3[0]);
                            Console.Write(riga3[1]);
                            Console.Write(riga3[2]);
                            Console.Write(riga3[3]);
                            Console.Write(riga3[4]);
                            Console.WriteLine(riga3[5]);
                            Console.WriteLine(" a b c");
                        }
                        else
                        {
                            Console.WriteLine("Mi dispiace non puoi inserlo li");
                            count--;
                        }
                    }
                    else if (cordinate == "a2")
                    {
                        if (riga2[1] == " ")
                        {
                            Console.Clear();
                            riga2[1] = simbolo;
                            Console.Write(riga1[0]);
                            Console.Write(riga1[1]);
                            Console.Write(riga1[2]);
                            Console.Write(riga1[3]);
                            Console.Write(riga1[4]);
                            Console.WriteLine(riga1[5]);
                            Console.WriteLine(" -+-+-");

                            Console.Write(riga2[0]);
                            Console.Write(riga2[1]);
                            Console.Write(riga2[2]);
                            Console.Write(riga2[3]);
                            Console.Write(riga2[4]);
                            Console.WriteLine(riga2[5]);
                            Console.WriteLine(" -+-+-");

                            Console.Write(riga3[0]);
                            Console.Write(riga3[1]);
                            Console.Write(riga3[2]);
                            Console.Write(riga3[3]);
                            Console.Write(riga3[4]);
                            Console.WriteLine(riga3[5]);
                            Console.WriteLine(" a b c");
                        }
                        else
                        {
                            Console.WriteLine("Mi dispiace non puoi inserlo li");
                            count--;
                        }
                    }
                    else if (cordinate == "b2")
                    {
                        if (riga2[3] == " ")
                        {
                            Console.Clear();
                            riga2[3] = simbolo;
                            Console.Write(riga1[0]);
                            Console.Write(riga1[1]);
                            Console.Write(riga1[2]);
                            Console.Write(riga1[3]);
                            Console.Write(riga1[4]);
                            Console.WriteLine(riga1[5]);
                            Console.WriteLine(" -+-+-");

                            Console.Write(riga2[0]);
                            Console.Write(riga2[1]);
                            Console.Write(riga2[2]);
                            Console.Write(riga2[3]);
                            Console.Write(riga2[4]);
                            Console.WriteLine(riga2[5]);
                            Console.WriteLine(" -+-+-");

                            Console.Write(riga3[0]);
                            Console.Write(riga3[1]);
                            Console.Write(riga3[2]);
                            Console.Write(riga3[3]);
                            Console.Write(riga3[4]);
                            Console.WriteLine(riga3[5]);
                            Console.WriteLine(" a b c");
                        }
                        else
                        {
                            Console.WriteLine("Mi dispiace non puoi inserlo li");
                            count--;
                        }
                    }
                    else if (cordinate == "c2")
                    {
                        if (riga2[5] == " ")
                        {
                            Console.Clear();
                            riga2[5] = simbolo;
                            Console.Write(riga1[0]);
                            Console.Write(riga1[1]);
                            Console.Write(riga1[2]);
                            Console.Write(riga1[3]);
                            Console.Write(riga1[4]);
                            Console.WriteLine(riga1[5]);
                            Console.WriteLine(" -+-+-");

                            Console.Write(riga2[0]);
                            Console.Write(riga2[1]);
                            Console.Write(riga2[2]);
                            Console.Write(riga2[3]);
                            Console.Write(riga2[4]);
                            Console.WriteLine(riga2[5]);
                            Console.WriteLine(" -+-+-");

                            Console.Write(riga3[0]);
                            Console.Write(riga3[1]);
                            Console.Write(riga3[2]);
                            Console.Write(riga3[3]);
                            Console.Write(riga3[4]);
                            Console.WriteLine(riga3[5]);
                            Console.WriteLine(" a b c");
                        }
                        else
                        {
                            Console.WriteLine("Mi dispiace non puoi inserlo li");
                            count--;
                        }
                    }
                    else if (cordinate == "a3")
                    {
                        if (riga3[1] == " ")
                        {
                            Console.Clear();
                            riga3[1] = simbolo;
                            Console.Write(riga1[0]);
                            Console.Write(riga1[1]);
                            Console.Write(riga1[2]);
                            Console.Write(riga1[3]);
                            Console.Write(riga1[4]);
                            Console.WriteLine(riga1[5]);
                            Console.WriteLine(" -+-+-");

                            Console.Write(riga2[0]);
                            Console.Write(riga2[1]);
                            Console.Write(riga2[2]);
                            Console.Write(riga2[3]);
                            Console.Write(riga2[4]);
                            Console.WriteLine(riga2[5]);
                            Console.WriteLine(" -+-+-");

                            Console.Write(riga3[0]);
                            Console.Write(riga3[1]);
                            Console.Write(riga3[2]);
                            Console.Write(riga3[3]);
                            Console.Write(riga3[4]);
                            Console.WriteLine(riga3[5]);
                            Console.WriteLine(" a b c");
                        }
                        else
                        {
                            Console.WriteLine("Mi dispiace non puoi inserlo li");
                            count--;
                        }
                    }
                    else if (cordinate == "b3")
                    {
                        if (riga3[3] == " ")
                        {
                            Console.Clear();
                            riga3[3] = simbolo;
                            Console.Write(riga1[0]);
                            Console.Write(riga1[1]);
                            Console.Write(riga1[2]);
                            Console.Write(riga1[3]);
                            Console.Write(riga1[4]);
                            Console.WriteLine(riga1[5]);
                            Console.WriteLine(" -+-+-");

                            Console.Write(riga2[0]);
                            Console.Write(riga2[1]);
                            Console.Write(riga2[2]);
                            Console.Write(riga2[3]);
                            Console.Write(riga2[4]);
                            Console.WriteLine(riga2[5]);
                            Console.WriteLine(" -+-+-");

                            Console.Write(riga3[0]);
                            Console.Write(riga3[1]);
                            Console.Write(riga3[2]);
                            Console.Write(riga3[3]);
                            Console.Write(riga3[4]);
                            Console.WriteLine(riga3[5]);
                            Console.WriteLine(" a b c");
                        }
                        else
                        {
                            Console.WriteLine("Mi dispiace non puoi inserlo li");
                            count--;
                        }
                    }
                    else if (cordinate == "c3")
                    {
                        if (riga3[5] == " ")
                        {
                            Console.Clear();
                            riga3[5] = simbolo;
                            Console.Write(riga1[0]);
                            Console.Write(riga1[1]);
                            Console.Write(riga1[2]);
                            Console.Write(riga1[3]);
                            Console.Write(riga1[4]);
                            Console.WriteLine(riga1[5]);
                            Console.WriteLine(" -+-+-");

                            Console.Write(riga2[0]);
                            Console.Write(riga2[1]);
                            Console.Write(riga2[2]);
                            Console.Write(riga2[3]);
                            Console.Write(riga2[4]);
                            Console.WriteLine(riga2[5]);
                            Console.WriteLine(" -+-+-");

                            Console.Write(riga3[0]);
                            Console.Write(riga3[1]);
                            Console.Write(riga3[2]);
                            Console.Write(riga3[3]);
                            Console.Write(riga3[4]);
                            Console.WriteLine(riga3[5]);
                            Console.WriteLine(" a b c");
                        }
                        else
                        {
                            Console.WriteLine("Mi dispiace non puoi inserlo li");
                            count--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Devi inserire le cordinate in maniera corretta");
                        count--;
                    }
                    if (
                        riga1[1] == "O" && riga1[3] == "O" && riga1[5] == "O" ||
                        riga2[1] == "O" && riga2[3] == "O" && riga2[5] == "O" ||
                        riga3[1] == "O" && riga3[3] == "O" && riga3[5] == "O" ||
                        riga1[1] == "X" && riga1[3] == "X" && riga1[5] == "X" ||
                        riga2[1] == "X" && riga2[3] == "X" && riga2[5] == "X" ||
                        riga3[1] == "X" && riga3[3] == "X" && riga3[5] == "X" ||



                        riga1[1] == "O" && riga2[1] == "O" && riga3[1] == "O" ||
                        riga1[3] == "O" && riga2[3] == "O" && riga3[3] == "O" ||
                        riga1[5] == "O" && riga2[5] == "O" && riga3[5] == "O" ||
                        riga1[1] == "X" && riga2[1] == "X" && riga3[1] == "X" ||
                        riga1[3] == "X" && riga2[3] == "X" && riga3[3] == "X" ||
                        riga1[5] == "X" && riga2[5] == "X" && riga3[5] == "X" ||




                        riga1[1] == "O" && riga2[3] == "O" && riga3[5] == "O" ||
                        riga1[1] == "X" && riga2[3] == "X" && riga3[5] == "X" ||
                        riga3[1] == "O" && riga2[3] == "O" && riga1[5] == "O" ||
                        riga3[1] == "X" && riga2[3] == "X" && riga1[5] == "X"
                        )
                    {
                        Console.WriteLine("bravo hai vinto!");
                        Console.ReadKey();
                        break;
                    }
                }

            }
            else if (scelta == 1)
            {
                //PROVA CON RANDOM 
                string simbolo = "";
                int count = 1;
                int pattaC = 0;
                string ascissa = "";
                string cordinatapc = "";
                string[] riga1 = new string[] { "1 ", " ", "|", " ", "|", " " };
                string[] riga2 = new string[] { "2 ", " ", "|", " ", "|", " " };
                string[] riga3 = new string[] { "3 ", " ", "|", " ", "|", " " };

                Console.WriteLine("Ciao! Benvenuto nel fantastico gioco del tris!!! ");
                Console.Write(riga1[0]);
                Console.Write(riga1[1]);
                Console.Write(riga1[2]);
                Console.Write(riga1[3]);
                Console.Write(riga1[4]);
                Console.WriteLine(riga1[5]);
                Console.WriteLine("  -+-+-");

                Console.Write(riga2[0]);
                Console.Write(riga2[1]);
                Console.Write(riga2[2]);
                Console.Write(riga2[3]);
                Console.Write(riga2[4]);
                Console.WriteLine(riga2[5]);
                Console.WriteLine("  -+-+-");

                Console.Write(riga3[0]);
                Console.Write(riga3[1]);
                Console.Write(riga3[2]);
                Console.Write(riga3[3]);
                Console.Write(riga3[4]);
                Console.WriteLine(riga3[5]);
                Console.WriteLine("  a b c");

                while (true)
                {
                    count++;

                    if (count % 2 == 0)
                    {
                        //Console.Clear();
                        Console.WriteLine("Giocatore tocca a TE ! ( che gioca con la 'O' ) ");
                        Console.WriteLine();
                        simbolo = "O";
                        Console.WriteLine("Inserisci le cordinate ( per esempio a1 ) ");
                        String cordinate = Console.ReadLine();
                        if (cordinate == "a1")
                        {
                            if (riga1[1] == " ")
                            {
                                riga1[1] = simbolo;
                                pattaC++;
                            }
                            else
                            {
                                Console.WriteLine("Mi dispiace non puoi inserlo li");
                                count--;
                            }
                        }
                        else if (cordinate == "b1")
                        {
                            if (riga1[3] == " ")
                            {
                                riga1[3] = simbolo;
                                pattaC++;
                            }
                            else
                            {
                                Console.WriteLine("Mi dispiace non puoi inserlo li");
                                count--;
                            }
                        }
                        else if (cordinate == "c1")
                        {
                            if (riga1[5] == " ")
                            {
                                riga1[5] = simbolo;
                                pattaC++;
                            }
                            else
                            {
                                Console.WriteLine("Mi dispiace non puoi inserlo li");
                                count--;
                            }
                        }
                        else if (cordinate == "a2")
                        {
                            if (riga2[1] == " ")
                            {
                                riga2[1] = simbolo;
                                pattaC++;
                            }
                            else
                            {
                                Console.WriteLine("Mi dispiace non puoi inserlo li");
                                count--;
                            }
                        }
                        else if (cordinate == "b2")
                        {
                            if (riga2[3] == " ")
                            {
                                riga2[3] = simbolo;
                                pattaC++;
                            }
                            else
                            {
                                Console.WriteLine("Mi dispiace non puoi inserlo li");
                                count--;
                            }
                        }
                        else if (cordinate == "c2")
                        {
                            if (riga2[5] == " ")
                            {
                                riga2[5] = simbolo;
                                pattaC++;
                            }
                            else
                            {
                                Console.WriteLine("Mi dispiace non puoi inserlo li");
                                count--;
                            }
                        }
                        else if (cordinate == "a3")
                        {
                            if (riga3[1] == " ")
                            {
                                riga3[1] = simbolo;
                                pattaC++;
                            }
                            else
                            {
                                Console.WriteLine("Mi dispiace non puoi inserlo li");
                                count--;
                            }
                        }
                        else if (cordinate == "b3")
                        {
                            if (riga3[3] == " ")
                            {
                                riga3[3] = simbolo;
                                pattaC++;
                            }
                            else
                            {
                                Console.WriteLine("Mi dispiace non puoi inserlo li");
                                count--;
                            }
                        }
                        else if (cordinate == "c3")
                        {
                            if (riga3[5] == " ")
                            {
                                riga3[5] = simbolo;
                                pattaC++;
                            }
                            else
                            {
                                Console.WriteLine("Mi dispiace non puoi inserlo li");
                                count--;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Devi inserire le cordinate in maniera corretta");
                            count--;
                        }
                        if (riga1[1] == "O" && riga1[3] == "O" && riga1[5] == "O" ||
                            riga2[1] == "O" && riga2[3] == "O" && riga2[5] == "O" ||
                            riga3[1] == "O" && riga3[3] == "O" && riga3[5] == "O" ||
                            riga1[1] == "O" && riga2[1] == "O" && riga3[1] == "O" ||
                            riga1[3] == "O" && riga2[3] == "O" && riga3[3] == "O" ||
                            riga1[5] == "O" && riga2[5] == "O" && riga3[5] == "O" ||
                            riga1[1] == "O" && riga2[3] == "O" && riga3[5] == "O" ||
                            riga3[5] == "O" && riga2[3] == "O" && riga1[1] == "O" ||
                            riga1[1] == "X" && riga1[3] == "X" && riga1[5] == "X" ||
                            riga2[1] == "X" && riga2[3] == "X" && riga2[5] == "X" ||
                            riga3[1] == "X" && riga3[3] == "X" && riga3[5] == "X" ||
                            riga1[1] == "X" && riga2[1] == "X" && riga3[1] == "X" ||
                            riga1[3] == "X" && riga2[3] == "X" && riga3[3] == "X" ||
                            riga1[5] == "X" && riga2[5] == "X" && riga3[5] == "X" ||
                            riga1[1] == "X" && riga2[3] == "X" && riga3[5] == "X" ||
                            riga3[5] == "X" && riga2[3] == "X" && riga1[1] == "X")
                        {
                            Console.Clear();
                            Console.Write(riga1[0]);
                            Console.Write(riga1[1]);
                            Console.Write(riga1[2]);
                            Console.Write(riga1[3]);
                            Console.Write(riga1[4]);
                            Console.WriteLine(riga1[5]);
                            Console.WriteLine("  -+-+-");

                            Console.Write(riga2[0]);
                            Console.Write(riga2[1]);
                            Console.Write(riga2[2]);
                            Console.Write(riga2[3]);
                            Console.Write(riga2[4]);
                            Console.WriteLine(riga2[5]);
                            Console.WriteLine("  -+-+-");

                            Console.Write(riga3[0]);
                            Console.Write(riga3[1]);
                            Console.Write(riga3[2]);
                            Console.Write(riga3[3]);
                            Console.Write(riga3[4]);
                            Console.WriteLine(riga3[5]);
                            Console.WriteLine("  a b c");
                            Console.WriteLine("bravo hai vinto contro il computer!");
                            Console.ReadKey();
                            break;
                        }
                        if (pattaC == 5)
                        {
                            Console.Clear();
                            Console.Write(riga1[0]);
                            Console.Write(riga1[1]);
                            Console.Write(riga1[2]);
                            Console.Write(riga1[3]);
                            Console.Write(riga1[4]);
                            Console.WriteLine(riga1[5]);
                            Console.WriteLine("  -+-+-");

                            Console.Write(riga2[0]);
                            Console.Write(riga2[1]);
                            Console.Write(riga2[2]);
                            Console.Write(riga2[3]);
                            Console.Write(riga2[4]);
                            Console.WriteLine(riga2[5]);
                            Console.WriteLine("  -+-+-");

                            Console.Write(riga3[0]);
                            Console.Write(riga3[1]);
                            Console.Write(riga3[2]);
                            Console.Write(riga3[3]);
                            Console.Write(riga3[4]);
                            Console.WriteLine(riga3[5]);
                            Console.WriteLine("  a b c");
                            Console.WriteLine("Partita Patta mi dispiace");
                            Console.ReadKey();
                            break;
                        }
                    }
                    else
                    {
                        simbolo = "X";
                        Random rnd = new Random();
                        int ascissarnd = rnd.Next(1, 4);
                        int ordinatarnd = rnd.Next(1, 4);
                        if (ascissarnd == 1)
                            ascissa = "a";
                        else if (ascissarnd == 2)
                            ascissa = "b";
                        else
                            ascissa = "c";
                        cordinatapc = ascissa + ordinatarnd;
                        Console.WriteLine();

                        if (cordinatapc == "a1")
                        {
                            if (riga1[1] == " ")
                            {
                                Console.Clear();
                                Console.WriteLine("Il computer sceglie " + cordinatapc);
                                Console.WriteLine("");
                                riga1[1] = simbolo;
                                Console.Write(riga1[0]);
                                Console.Write(riga1[1]);
                                Console.Write(riga1[2]);
                                Console.Write(riga1[3]);
                                Console.Write(riga1[4]);
                                Console.WriteLine(riga1[5]);
                                Console.WriteLine("  -+-+-");

                                Console.Write(riga2[0]);
                                Console.Write(riga2[1]);
                                Console.Write(riga2[2]);
                                Console.Write(riga2[3]);
                                Console.Write(riga2[4]);
                                Console.WriteLine(riga2[5]);
                                Console.WriteLine("  -+-+-");

                                Console.Write(riga3[0]);
                                Console.Write(riga3[1]);
                                Console.Write(riga3[2]);
                                Console.Write(riga3[3]);
                                Console.Write(riga3[4]);
                                Console.WriteLine(riga3[5]);
                                Console.WriteLine("  a b c");
                            }
                            else
                            {
                                count--;
                            }
                        }
                        else if (cordinatapc == "b1")
                        {
                            if (riga1[3] == " ")
                            {
                                Console.Clear();
                                Console.WriteLine("Il computer sceglie " + cordinatapc);
                                Console.WriteLine("");
                                riga1[3] = simbolo;
                                Console.Write(riga1[0]);
                                Console.Write(riga1[1]);
                                Console.Write(riga1[2]);
                                Console.Write(riga1[3]);
                                Console.Write(riga1[4]);
                                Console.WriteLine(riga1[5]);
                                Console.WriteLine("  -+-+-");

                                Console.Write(riga2[0]);
                                Console.Write(riga2[1]);
                                Console.Write(riga2[2]);
                                Console.Write(riga2[3]);
                                Console.Write(riga2[4]);
                                Console.WriteLine(riga2[5]);
                                Console.WriteLine("  -+-+-");

                                Console.Write(riga3[0]);
                                Console.Write(riga3[1]);
                                Console.Write(riga3[2]);
                                Console.Write(riga3[3]);
                                Console.Write(riga3[4]);
                                Console.WriteLine(riga3[5]);
                                Console.WriteLine("  a b c");
                            }
                            else
                            {
                                count--;
                            }
                        }
                        else if (cordinatapc == "c1")
                        {
                            if (riga1[5] == " ")
                            {
                                Console.Clear();
                                Console.WriteLine("Il computer sceglie " + cordinatapc);
                                Console.WriteLine("");
                                riga1[5] = simbolo;
                                Console.Write(riga1[0]);
                                Console.Write(riga1[1]);
                                Console.Write(riga1[2]);
                                Console.Write(riga1[3]);
                                Console.Write(riga1[4]);
                                Console.WriteLine(riga1[5]);
                                Console.WriteLine("  -+-+-");

                                Console.Write(riga2[0]);
                                Console.Write(riga2[1]);
                                Console.Write(riga2[2]);
                                Console.Write(riga2[3]);
                                Console.Write(riga2[4]);
                                Console.WriteLine(riga2[5]);
                                Console.WriteLine("  -+-+-");

                                Console.Write(riga3[0]);
                                Console.Write(riga3[1]);
                                Console.Write(riga3[2]);
                                Console.Write(riga3[3]);
                                Console.Write(riga3[4]);
                                Console.WriteLine(riga3[5]);
                                Console.WriteLine("  a b c");
                            }
                            else
                            {
                                count--;
                            }
                        }
                        else if (cordinatapc == "a2")
                        {
                            if (riga2[1] == " ")
                            {
                                Console.Clear();
                                Console.WriteLine("Il computer sceglie " + cordinatapc);
                                Console.WriteLine("");
                                riga2[1] = simbolo;
                                Console.Write(riga1[0]);
                                Console.Write(riga1[1]);
                                Console.Write(riga1[2]);
                                Console.Write(riga1[3]);
                                Console.Write(riga1[4]);
                                Console.WriteLine(riga1[5]);
                                Console.WriteLine("  -+-+-");

                                Console.Write(riga2[0]);
                                Console.Write(riga2[1]);
                                Console.Write(riga2[2]);
                                Console.Write(riga2[3]);
                                Console.Write(riga2[4]);
                                Console.WriteLine(riga2[5]);
                                Console.WriteLine("  -+-+-");

                                Console.Write(riga3[0]);
                                Console.Write(riga3[1]);
                                Console.Write(riga3[2]);
                                Console.Write(riga3[3]);
                                Console.Write(riga3[4]);
                                Console.WriteLine(riga3[5]);
                                Console.WriteLine("  a b c");
                            }
                            else
                            {
                                count--;
                            }
                        }
                        else if (cordinatapc == "b2")
                        {
                            if (riga2[3] == " ")
                            {
                                Console.Clear();
                                Console.WriteLine("Il computer sceglie " + cordinatapc);
                                Console.WriteLine("");
                                riga2[3] = simbolo;
                                Console.Write(riga1[0]);
                                Console.Write(riga1[1]);
                                Console.Write(riga1[2]);
                                Console.Write(riga1[3]);
                                Console.Write(riga1[4]);
                                Console.WriteLine(riga1[5]);
                                Console.WriteLine("  -+-+-");

                                Console.Write(riga2[0]);
                                Console.Write(riga2[1]);
                                Console.Write(riga2[2]);
                                Console.Write(riga2[3]);
                                Console.Write(riga2[4]);
                                Console.WriteLine(riga2[5]);
                                Console.WriteLine("  -+-+-");

                                Console.Write(riga3[0]);
                                Console.Write(riga3[1]);
                                Console.Write(riga3[2]);
                                Console.Write(riga3[3]);
                                Console.Write(riga3[4]);
                                Console.WriteLine(riga3[5]);
                                Console.WriteLine("  a b c");
                            }
                            else
                            {
                                count--;
                            }
                        }
                        else if (cordinatapc == "c2")
                        {
                            if (riga2[5] == " ")
                            {
                                Console.Clear();
                                Console.WriteLine("Il computer sceglie " + cordinatapc);
                                Console.WriteLine("");
                                riga2[5] = simbolo;
                                Console.Write(riga1[0]);
                                Console.Write(riga1[1]);
                                Console.Write(riga1[2]);
                                Console.Write(riga1[3]);
                                Console.Write(riga1[4]);
                                Console.WriteLine(riga1[5]);
                                Console.WriteLine("  -+-+-");

                                Console.Write(riga2[0]);
                                Console.Write(riga2[1]);
                                Console.Write(riga2[2]);
                                Console.Write(riga2[3]);
                                Console.Write(riga2[4]);
                                Console.WriteLine(riga2[5]);
                                Console.WriteLine("  -+-+-");

                                Console.Write(riga3[0]);
                                Console.Write(riga3[1]);
                                Console.Write(riga3[2]);
                                Console.Write(riga3[3]);
                                Console.Write(riga3[4]);
                                Console.WriteLine(riga3[5]);
                                Console.WriteLine("  a b c");
                            }
                            else
                            {
                                count--;
                            }
                        }
                        else if (cordinatapc == "a3")
                        {
                            if (riga3[1] == " ")
                            {
                                Console.Clear();
                                Console.WriteLine("Il computer sceglie " + cordinatapc);
                                Console.WriteLine("");
                                riga3[1] = simbolo;
                                Console.Write(riga1[0]);
                                Console.Write(riga1[1]);
                                Console.Write(riga1[2]);
                                Console.Write(riga1[3]);
                                Console.Write(riga1[4]);
                                Console.WriteLine(riga1[5]);
                                Console.WriteLine("  -+-+-");

                                Console.Write(riga2[0]);
                                Console.Write(riga2[1]);
                                Console.Write(riga2[2]);
                                Console.Write(riga2[3]);
                                Console.Write(riga2[4]);
                                Console.WriteLine(riga2[5]);
                                Console.WriteLine("  -+-+-");

                                Console.Write(riga3[0]);
                                Console.Write(riga3[1]);
                                Console.Write(riga3[2]);
                                Console.Write(riga3[3]);
                                Console.Write(riga3[4]);
                                Console.WriteLine(riga3[5]);
                                Console.WriteLine("  a b c");
                            }
                            else
                            {
                                count--;
                            }
                        }
                        else if (cordinatapc == "b3")
                        {
                            if (riga3[3] == " ")
                            {
                                Console.Clear();
                                Console.WriteLine("Il computer sceglie " + cordinatapc);
                                Console.WriteLine("");
                                riga3[3] = simbolo;
                                Console.Write(riga1[0]);
                                Console.Write(riga1[1]);
                                Console.Write(riga1[2]);
                                Console.Write(riga1[3]);
                                Console.Write(riga1[4]);
                                Console.WriteLine(riga1[5]);
                                Console.WriteLine("  -+-+-");

                                Console.Write(riga2[0]);
                                Console.Write(riga2[1]);
                                Console.Write(riga2[2]);
                                Console.Write(riga2[3]);
                                Console.Write(riga2[4]);
                                Console.WriteLine(riga2[5]);
                                Console.WriteLine("  -+-+-");

                                Console.Write(riga3[0]);
                                Console.Write(riga3[1]);
                                Console.Write(riga3[2]);
                                Console.Write(riga3[3]);
                                Console.Write(riga3[4]);
                                Console.WriteLine(riga3[5]);
                                Console.WriteLine("  a b c");
                            }
                            else
                            {
                                count--;
                            }
                        }
                        else if (cordinatapc == "c3")
                        {
                            if (riga3[5] == " ")
                            {
                                Console.Clear();
                                Console.WriteLine("Il computer sceglie " + cordinatapc);
                                Console.WriteLine("");
                                riga3[5] = simbolo;
                                Console.Write(riga1[0]);
                                Console.Write(riga1[1]);
                                Console.Write(riga1[2]);
                                Console.Write(riga1[3]);
                                Console.Write(riga1[4]);
                                Console.WriteLine(riga1[5]);
                                Console.WriteLine("  -+-+-");

                                Console.Write(riga2[0]);
                                Console.Write(riga2[1]);
                                Console.Write(riga2[2]);
                                Console.Write(riga2[3]);
                                Console.Write(riga2[4]);
                                Console.WriteLine(riga2[5]);
                                Console.WriteLine("  -+-+-");

                                Console.Write(riga3[0]);
                                Console.Write(riga3[1]);
                                Console.Write(riga3[2]);
                                Console.Write(riga3[3]);
                                Console.Write(riga3[4]);
                                Console.WriteLine(riga3[5]);
                                Console.WriteLine("  a b c");
                            }
                            else
                            {
                                count--;
                            }
                        }
                        if (riga1[1] == "O" && riga1[3] == "O" && riga1[5] == "O" ||
                            riga2[1] == "O" && riga2[3] == "O" && riga2[5] == "O" ||
                            riga3[1] == "O" && riga3[3] == "O" && riga3[5] == "O" ||
                            riga1[1] == "O" && riga2[1] == "O" && riga3[1] == "O" ||
                            riga1[3] == "O" && riga2[3] == "O" && riga3[3] == "O" ||
                            riga1[5] == "O" && riga2[5] == "O" && riga3[5] == "O" ||
                            riga1[1] == "O" && riga2[3] == "O" && riga3[5] == "O" ||
                            riga3[5] == "O" && riga2[3] == "O" && riga1[1] == "O" ||
                            riga1[1] == "X" && riga1[3] == "X" && riga1[5] == "X" ||
                            riga2[1] == "X" && riga2[3] == "X" && riga2[5] == "X" ||
                            riga3[1] == "X" && riga3[3] == "X" && riga3[5] == "X" ||
                            riga1[1] == "X" && riga2[1] == "X" && riga3[1] == "X" ||
                            riga1[3] == "X" && riga2[3] == "X" && riga3[3] == "X" ||
                            riga1[5] == "X" && riga2[5] == "X" && riga3[5] == "X" ||
                            riga1[1] == "X" && riga2[3] == "X" && riga3[5] == "X" ||
                            riga3[5] == "X" && riga2[3] == "X" && riga1[1] == "X")
                        {
                            Console.WriteLine("Mi dispiace hai perso");
                            Console.ReadKey();
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Dovevi inserire 1 o 2... riprova!");
                Console.ReadKey();
            }
        }
    }
}