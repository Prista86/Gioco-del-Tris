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
            /*
            string nome = "Francesco";  //Crea var.nome
            Console.WriteLine(nome);   //Stampa var.nome
            Console.ReadKey();   //Leggi input
            
            int numero = 12;
            int numero2 = 1;
            int somma = numero + numero2;
            Console.WriteLine(somma);
            Console.ReadKey();
                       
            string parola1 = "Mi piace ";
            string parola2 = "programmare!";
            //string frase = parola1 + parola2;
            Console.WriteLine(parola1 + "molto " + parola2);
            Console.ReadKey();
            */

            /*
            // Esercizio : dati due numeri calcola la somma e la differenza
            int numero1 = 100;
            int numero2 = 10;
            //int somma = numero1 + numero2;
            //int sottrazione = numero - numero2; 
            //Console.WriteLine(numero1+numero2);
            //Console.WriteLine(numero1-numero2);
            Console.WriteLine("la somma è: " + (numero1 + numero2));
            Console.WriteLine("la differenza è: " + (numero1 - numero2));
            Console.ReadKey();
            */


            /*
            Console.WriteLine("int");
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.ReadKey();

            Console.WriteLine("double");
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.ReadKey();

            Console.WriteLine("float");
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.ReadKey();

            Console.WriteLine("UInt16");
            Console.WriteLine(UInt16.MinValue);
            Console.WriteLine(UInt16.MaxValue);
            Console.ReadKey();
            

            bool valore1 = true;
            bool valore2 = false;
            Console.WriteLine(valore1);
            Console.WriteLine(valore2);
            Console.ReadKey();
            
            char carattere = 'a';   //char car2 = "a"; sbagliato!
            Console.WriteLine(carattere);
            Console.ReadKey();
            */


            /*
            string inputDellUtente = Console.ReadLine();   //input solo stringa, restituisce una stringa
            Console.WriteLine(inputDellUtente);
            Console.ReadKey();
            

            Console.WriteLine("Come ti chiami ?");
            string nome = Console.ReadLine();
            Console.WriteLine("il tuo nome è " + nome);
            Console.ReadKey();
            */

            /*
            string numeroString = "10";
            int numeroInt = int.Parse(numeroString);
            Console.WriteLine(numeroString);
            Console.WriteLine(numeroInt);
            Console.ReadKey();
            */


            /*
            //Esercizio:  Fai inserire due numeri, somma 1 al primo numero poi calcola la somma e la differenza.
            Console.WriteLine("Inserisci il primo numero");
            string numero1String = Console.ReadLine();
            int numero1 = int.Parse(numero1String);
            Console.WriteLine("Inserisci il secondo numero");
            string numero2String = Console.ReadLine();
            int numero2 = int.Parse(numero2String);
            Console.WriteLine("Il primo numero sommato a 1 è : " + (numero1+1));
            Console.WriteLine("La somma dei due numeri è " + (numero1 + numero2));
            Console.WriteLine("La differenza dei due numeri è" + (numero1 - numero2));
            Console.ReadKey();
            */


            /*
            Console.WriteLine("Inserisci una stringa");    // IF ... ELSE IF
            string variabile = Console.ReadLine();
            if (variabile == "ciao")                     //no punto e virgola
            {
                Console.WriteLine("Ciao anche a te!");
            }
            else if (variabile == "addio")            //no punto e virgola
            {
                Console.WriteLine("Addio mio caro");
            }
            else if (variabile == "goodbye")             //no punto e virgola
            {
                Console.WriteLine("Goodbye my friend");
            }
            else                                             //no punto e virgola
            {
                Console.WriteLine("Non mi saluti ?");
            }
            Console.ReadKey();
            */


            /*
            bool exitLoop = false;   // Ciclo While
            while (!exitLoop)
            {
                Console.WriteLine("inserisci una stringa (se scrivi asd esci)");
                string stringa = Console.ReadLine();
                if (stringa == "asd")
                {
                    exitLoop = true;
                    Console.WriteLine("le stringhe sono uguali");
                    Console.ReadKey();
                }
                else
                    Console.WriteLine("le stringhe non sono uguali");
            }
            */

            /*          ESERCIZIO MACCHINETTA
              
              
            Simulazione di una macchinetta delle merendine
	
	            - la macchinetta deve;
	
        		-avere un numero intero che indichi i soldi dell'utente

        		-avere una scelta di N prodotti

		        - permetere all'utente di scegliere un prodotto alla volta , sottraendo ogni volta l'importo dai suoi soldi

		        - smettere di accettare ordini quando l'utente non ha più abbastanza soldi.
              
             

             */

            /*
            Console.WriteLine("Inserisci quanti euro vuoi inserire");
            string eurostring = Console.ReadLine();
            int euro = 0;
            int manca = 0;
            int.TryParse(eurostring, out euro);
            int costo = 0;
            Console.WriteLine("Hai inserito " + euro + " Euro!");
            Console.WriteLine("Premi invio per continuare!");
            Console.ReadKey();
            bool exitLoop = false;
            while (!exitLoop)
            {
                if (euro <= 0)
                {
                    Console.WriteLine("Mi dispiace non puoi acquistare nulla, vai a lavorare");
                    exitLoop = true;
                }
                else if (euro > 0)
                {
                    Console.WriteLine("Quale prodotto vorresti scegliere tra acqua,biscotto,bibita ?");
                    Console.WriteLine(" 1) acqua     - Costo:    1 euro");
                    Console.WriteLine(" 2) biscotto  - Costo:    2 euro");
                    Console.WriteLine(" 3) bibita    - Costo:    3 euro");
                    string prodotto = Console.ReadLine();
                    if (prodotto == "acqua")
                    {
                        costo = 1;
                    }
                    else if (prodotto == "biscotto")
                    {
                        costo = 2;
                    }
                    else if (prodotto == "bibita")
                    {
                        costo = 3;
                    }
                    //else
                    //{
                    //    Console.WriteLine("Inserisci una delle tre scelte, non fare il furbo"); // da sistemare bene l'ultimo WriteLine
                    //    exitLoop = true;
                    //}
                        

                    if (costo > euro)
                    {
                        exitLoop = true;
                    }
                    else
                    {
                        euro = euro - costo;
                        Console.WriteLine(" Ottima scelta! ( "+ prodotto +" ) Ti restano " + euro + " euro");
                    }

                }
            }
            if (euro > 0)
            {
                manca = euro - costo;
                Console.WriteLine("Mi dispiace ma non te la puoi permettere ti manca " + Math.Abs(manca) + " euro");
            }
            Console.ReadKey(); 
            */


            /*
            //20.01.22
            //Esercizio
            //Scrivere un programma che simuli un lancio di una moneta:   //random num c#
            //-permettere all'utente di scommettere testa o croce.
            //- stampare all'utente se ha vinto o meno.

            int risultatoM = 0;
            int RisNum = 0;
            Console.WriteLine("Scegli testa o croce");
            string scelta = Console.ReadLine();
            if (scelta == "testa")
                RisNum = 1;
            else
                RisNum = 2;


            //Console.WriteLine("Hai scelto " + scelta);
            Console.WriteLine("Ora tiro la moneta, vediamo cosa esce fuori ");
            Console.ReadKey();
            //Console.WriteLine("Ora Tiro la moneta, vediamo cosa esce fuori");
            Random rnd = new Random();
            risultatoM = (rnd.Next(1, 3));
            if (risultatoM == 1)
            {
                Console.WriteLine("E' uscito Testa");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("E' uscita Croce");
                Console.ReadKey();
            }

            if (risultatoM == RisNum)
            {
                Console.WriteLine("Ottimo hai vinto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Mi dispace hai perso");
                Console.ReadKey();
            }
            */

            /*
            int numtiri;  // PROVO A FAR SCEGLIERE QUANTI TIRI EFFETTUARE e CONTARE QUANTE VOLTE HAI VINTO E PERSO.
            int countwin=0;
            int countlose=0;
            Console.WriteLine("Quanti tiri vuoi tentare?");
            string numtiristring = Console.ReadLine();
            int.TryParse(numtiristring, out numtiri);                       
            int risultatoM = 0;
            int RisNum = 0;
            Console.WriteLine("Scegli testa o croce");
            string scelta = Console.ReadLine();
            if (scelta == "testa")
                RisNum = 1;
            else
                RisNum = 2;
            Console.WriteLine("Hai scelto " + scelta);
            Console.ReadKey();
            Console.WriteLine("Ora Tiro la moneta, vediamo cosa esce fuori");
            Random rnd = new Random();
            for (int j = 0; j < numtiri; j++)
            {
                risultatoM = (rnd.Next(1, 3));
                if (risultatoM == 1)
                    Console.WriteLine("Al tiro numero " + (j+1)+ " e'  uscito Testa");
                else
                    Console.WriteLine("Al tiro numero " + (j+1) + " e' uscita Croce");
                if (risultatoM == RisNum)
                {
                    countwin++;
                    Console.WriteLine("Ottimo hai vinto");
                }
                else
                {
                    countlose++;
                    Console.WriteLine("Mi dispace hai perso");
                }
            }
            Console.WriteLine("Hai vinto " + countwin);
            Console.WriteLine("Hai perso " + countlose);
            */

            /*
            Console.WriteLine("Scegli testa o croce");   //ESERCIZIO DEL PROFESSORE
            Console.WriteLine("1) testa");
            Console.WriteLine("2) croce");
            string scelta = Console.ReadLine();

            Random r = new Random();
            int randomNumber = r.Next(1, 3);
            if (scelta == randomNumber.ToString())
                Console.WriteLine("Hai Vinto");
            else
                Console.WriteLine("Hai Perso");
            Console.ReadKey();
            */

            /*
            Scrivere un programma che ;
                -Chieda all'utente il nome
                -Stampi sullo schermo il nome
                -Stampi sullo schermo la lunghezza del nome dell'utente.
            

            Console.WriteLine("Inserisci il nome di cui vuoi sapere di quanti caratteri è composto");
            string nome = Console.ReadLine();    
            Console.WriteLine("Il nome inserito (" + nome + ") e' composto da ben "+ nome.Length +" caratteri !");
            Console.ReadKey();
            */

            //21.01.2022
            // Operazioni con le stringhe 1/2
            // Inizio spiegazione Array

            /*
            string stringa = "amico";
            char secondocarattere = stringa[1];
            Console.WriteLine(stringa);
            Console.WriteLine(secondocarattere);

            Console.ReadKey();
            */

            /*
            //Esercizio 1
            // - Chiedere all'utente il suo nome
            // - Stampare su schermo il nome dell'utente e il primo carattere del nome

            Console.WriteLine("Inserisci un nome.");
            string nome = Console.ReadLine();
            Console.WriteLine("Ti chiami "+nome);
            char primocarattere = nome[0];
            Console.WriteLine("Il primo carattere e' : " + primocarattere);
            Console.ReadKey();
            */

            /*
            // Ampliamento Esercizio 1
            // - Chiedere all'utente il suo nome
            // - Stampare su schermo il nome dell'utente e il primo carattere del nome
            // - Stampare l'ultimo carattere del nome
            
            Console.WriteLine("Inserisci un nome.");
            string nome = Console.ReadLine();
            Console.WriteLine("Il nome inserito è' " + nome);
            Console.WriteLine("Il primo carattere e' : " + nome[0]);
            Console.WriteLine("L'ultimo carattere e' : " + nome[(nome.Length - 1)]);
            Console.ReadKey();
            */


            /*
            string stringa = ("Ciao Sono Una Stringa Molto Lunga"); //Sostituzione caratteri in un stringa
            string stringareplace = stringa.Replace("i", "");
            Console.WriteLine(stringa);
            Console.WriteLine(stringareplace);
            // oppure Console.WriteLine(stringa.Replace("i", ""));
            
            string stringaLowerInvariant = stringa.ToLowerInvariant();  //tutto minuscolo
            string stringaUpperInvariant = stringa.ToUpperInvariant();  //tutto maiuscolo
            Console.WriteLine("Tutto minuscolo : "+stringaLowerInvariant);
            Console.WriteLine("Tutto maiuscolo : "+stringaUpperInvariant);
            Console.ReadKey();
            
            bool stringaStartsWich = stringa.StartsWith("Cia");         //Comincia con questa stringa ?
            bool stringaEndWich = stringa.EndsWith("nga");               //Finisce con questa stringa ?
            Console.WriteLine("Comincia con una determinata stringa ? " + stringaStartsWich);
            Console.WriteLine("Finisce con una determinata stringa ? "+ stringaEndWich);
            Console.ReadKey();

            bool stringaContains = stringa.Contains(" Una St");         //contiene questa stringa?
            Console.WriteLine("Contiene una determinata stringa ? "+stringaContains);
            Console.ReadKey();
            */

            //Esercizio 2
            //Chiedere all'utente una stringa qualsiasi
            //sostituire nella stringa tutte le occorrenze di "o" con "Y"
            //stampare il risultato
            //sostiutuire nella stringa risultato tutte le occorenze di "la" con "io" e stampare il risultato

            /*
            Console.WriteLine("Scrivi una frase con delle 'o' ");
            string frase1 = Console.ReadLine();
            string frase2 = frase1.Replace("o", "y");
            Console.WriteLine(frase2);
            Console.WriteLine(frase2.Replace("la", "IO"));
            Console.ReadKey();
            */


            /*
            //ESERCIZIO PER FAR GIRARE GLI ESERCIZI FINCHE NON DIGITI "esc" .  
            int i = 0;
            do
            {

                
                
                Console.WriteLine("Scrivi una frase con delle 'o' ");            Qua 
                string frase1 = Console.ReadLine();                              puoi  
                string frase2 = frase1.Replace("o", "y");                        mettere 
                Console.WriteLine(frase2);                                       qualsiasi   
                Console.WriteLine(frase2.Replace("la", "IO"));                   programmino    ^_^ ! 
                



                Console.ReadKey();
                Console.WriteLine("Digita esc per uscire, invio per continuare");
                string parola = Console.ReadLine();
                if (parola == "esc")
                    break;
            } while (i < 1);
            */







            /*
            // Esercizio 3 
            // Chidere all'utente una stringa
            // Chiedere all'utente il suo nome
            // sostituire all'interno della stringa il nome dell'utente con "***"
            // stampare il risultato

            Console.WriteLine("Inserisci una frase a piacimento");
            string frase = Console.ReadLine();
            Console.WriteLine("Inserisci una nome a piacimento");
            string nome = Console.ReadLine();
            Console.WriteLine(frase.Replace(nome, "***"));
            Console.ReadKey();
            */

            /*
            //Esercizio a casa
            //-chiedere all'utente 4 numeri interi
            //- stampare sullo schermo somma e differenza dei numeri
            //- stampare sullo schermo il prodotto del primo con l'ultimo

            int intA = 0;
            Console.WriteLine("Inserisci il primo di 4 numeri");
            string a = Console.ReadLine();
            int.TryParse(a, out intA);
            Console.WriteLine(intA);
            int intB = 0;
            Console.WriteLine("Inserisci il secondo di 4 numeri");
            string b = Console.ReadLine();
            int.TryParse(b, out intB);
            Console.WriteLine(intB);
            int intC = 0;
            Console.WriteLine("Inserisci il terzo di 4 numeri");
            string c = Console.ReadLine();
            int.TryParse(c, out intC);
            Console.WriteLine(intC);
            int intD = 0;
            Console.WriteLine("Inserisci il quarto di 4 numeri");
            string d = Console.ReadLine();
            int.TryParse(d, out intD);
            Console.WriteLine(intD);
            Console.WriteLine("La somma totale e' : " + (intA + intB + intC + intD));
            Console.WriteLine("Il prodotto del primo e dell'ultimo valore e' : " + (intA * intD));
            Console.ReadKey();
            */


            /*
            //Esercizio 2 a casa
            //- chiedere all'utente 3 stringhe
            //- stampare sullo schermo le seguenti condizioni (true o false):
            //- la prima stringa contiene la seconda . richiesta 1
            //- la seconda stringa comincia con la prima . richiesta 2 
            //- la terza stringa è più lunga della prima . richiesta 3

            Console.WriteLine("Inserisci la prima frase");
            string frase1 = Console.ReadLine();
            Console.WriteLine("Inserisci la seconda frase");
            string frase2 = Console.ReadLine();
            Console.WriteLine("Inserisci la terza frase");
            string frase3 = Console.ReadLine();

            bool contiene = frase1.Contains(frase2);         //richiesta 1
            Console.WriteLine("La prima stringa ( " + frase1 + " ) contiene la seconda stringa ? ( " + frase2 + " ) : " + contiene);
            Console.ReadKey();

            bool inizia = frase2.StartsWith(frase1); // richiesta 2
            Console.WriteLine("La seconda frase ( " + frase2 + " ) inizia con la prima frase ( " + frase1 + " ) : " + inizia);
            Console.ReadKey();

            //Console.WriteLine(frase1.Length);
            //Console.WriteLine(frase3.Length);
            //Console.ReadKey();
            if (frase3.Length > frase1.Length)
            {
                Console.WriteLine("La terza frase ( " + frase3 + " ) e' più lunga della prima ( " + frase1 + " ) : true");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("La terza frase ( " + frase3 + " ) e' più lunga della prima ( " + frase1 + " ) : false");
                Console.ReadKey();
            }
            */


            // Esercizi per casa !!!
            //- scrivere un programma che simuli il gioco del tris:
            //- 2 giocatori
            //- box di 3x3, simboli O, X
            //- vince il giocatore che fa tris+



            /*
            string simbolo = "";
            int count = 0;
            string[] riga1 = new string[] { "1", " ", "|", " ", "|", " " };
            string[] riga2 = new string[] { "2", " ", "|", " ", "|", " " };
            string[] riga3 = new string[] { "3", " ", "|", " ", "|", " " };

            Console.WriteLine("Ciao! Benvenuto nel fantastico gioco del tris!!! ");
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
                //Console.WriteLine(count);
                if (count % 2 == 0)
                {
                    Console.WriteLine("SECONDO GIOCATORE ! ");
                    simbolo = "O";
                }
                else
                {
                    Console.WriteLine("PRIMO GIOCATORE !");
                    simbolo = "X";
                }

                Console.WriteLine("Inserisci le cordinate ( per esempio a1 ) ");
                String cordinate = Console.ReadLine();
                if (cordinate == "a1")
                {
                    if (riga1[1] == " ")
                    {
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
                    else Console.WriteLine("Mi dispiace non puoi inserlo li");
                }
                else if (cordinate == "b1")
                {
                    if (riga1[3] == " ")
                    {
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
                    else Console.WriteLine("Mi dispiace non puoi inserlo li");
                }
                else if (cordinate == "c1")
                {
                    if (riga1[5] == " ")
                    {
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
                    else Console.WriteLine("Mi dispiace non puoi inserlo li");
                }
                else if (cordinate == "a2")
                {
                    if (riga2[1] == " ")
                    {
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
                    else Console.WriteLine("Mi dispiace non puoi inserlo li");
                }
                else if (cordinate == "b2")
                {
                    if (riga2[3] == " ")
                    {
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
                    else Console.WriteLine("Mi dispiace non puoi inserlo li");
                }
                else if (cordinate == "c2")
                {
                    if (riga2[5] == " ")
                    {
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
                    else Console.WriteLine("Mi dispiace non puoi inserlo li");
                }
                else if (cordinate == "a3")
                {
                    if (riga3[1] == " ")
                    {
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
                    else Console.WriteLine("Mi dispiace non puoi inserlo li");
                }
                else if (cordinate == "b3")
                {
                    if (riga3[3] == " ")
                    {
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
                    else Console.WriteLine("Mi dispiace non puoi inserlo li");
                }
                else if (cordinate == "c3")
                {
                    if (riga3[5] == " ")
                    {
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
                    else Console.WriteLine("Mi dispiace non puoi inserlo li");
                }
                if (riga1[1] == "O" && riga1[3] == "O" && riga1[5] == "O" ||
                    riga2[1] == "O" && riga2[3] == "O" && riga2[5] == "O" ||
                    riga3[1] == "O" && riga3[3] == "O" && riga3[5] == "O" ||
                    riga1[1] == "O" && riga2[1] == "O" && riga3[1] == "O" ||
                    riga1[3] == "O" && riga2[3] == "O" && riga3[3] == "O" ||
                    riga1[5] == "O" && riga1[5] == "O" && riga1[5] == "O" ||
                    riga1[1] == "O" && riga2[3] == "O" && riga3[5] == "O" ||
                    riga3[5] == "O" && riga2[3] == "O" && riga1[1] == "O" ||
                    riga1[1] == "X" && riga1[3] == "X" && riga1[5] == "X" ||
                    riga2[1] == "X" && riga2[3] == "X" && riga2[5] == "X" ||
                    riga3[1] == "X" && riga3[3] == "X" && riga3[5] == "X" ||
                    riga1[1] == "X" && riga2[1] == "X" && riga3[1] == "X" ||
                    riga1[3] == "X" && riga2[3] == "X" && riga3[3] == "X" ||
                    riga1[5] == "X" && riga1[5] == "X" && riga1[5] == "X" ||
                    riga1[1] == "X" && riga2[3] == "X" && riga3[5] == "X" ||
                    riga3[5] == "X" && riga2[3] == "X" && riga1[1] == "X")
                {
                    Console.WriteLine("bravo hai vinto!");
                    Console.ReadKey();
                    break;
                }
            }
            */



            //PROVA CON RANDOM 
            string simbolo = "";
            int count = 1;
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
                    Console.WriteLine("PRIMO GIOCATORE ! ( che gioca con la 'O' ) ");
                    Console.WriteLine();
                    simbolo = "O";
                    Console.WriteLine("Inserisci le cordinate ( per esempio a1 ) ");
                    String cordinate = Console.ReadLine();
                    if (cordinate == "a1")
                    {
                        if (riga1[1] == " ")
                        {
                            riga1[1] = simbolo;
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
                        }
                        else
                        {
                            Console.WriteLine("Mi dispiace non puoi inserlo li");
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
                        Console.WriteLine("bravo hai vinto!");
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
                    Console.WriteLine("SECONDO GIOCATORE COMPUTER ! ( che gioca con la 'X' ) sceglie : " + cordinatapc);
                    Console.WriteLine();

                    if (cordinatapc == "a1")
                    {
                        if (riga1[1] == " ")
                        {
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
                            Console.WriteLine("Mi dispiace non puoi inserlo li");
                            count--;
                        }
                    }
                    else if (cordinatapc == "b1")
                    {
                        if (riga1[3] == " ")
                        {
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
                            Console.WriteLine("Mi dispiace non puoi inserlo li");
                            count--;
                        }
                    }
                    else if (cordinatapc == "c1")
                    {
                        if (riga1[5] == " ")
                        {
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
                            Console.WriteLine("Mi dispiace non puoi inserlo li");
                            count--;
                        }
                    }
                    else if (cordinatapc == "a2")
                    {
                        if (riga2[1] == " ")
                        {
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
                            Console.WriteLine("Mi dispiace non puoi inserlo li");
                            count--;
                        }
                    }
                    else if (cordinatapc == "b2")
                    {
                        if (riga2[3] == " ")
                        {
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
                            Console.WriteLine("Mi dispiace non puoi inserlo li");
                            count--;
                        }
                    }
                    else if (cordinatapc == "c2")
                    {
                        if (riga2[5] == " ")
                        {
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
                            Console.WriteLine("Mi dispiace non puoi inserlo li");
                            count--;
                        }
                    }
                    else if (cordinatapc == "a3")
                    {
                        if (riga3[1] == " ")
                        {
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
                            Console.WriteLine("Mi dispiace non puoi inserlo li");
                            count--;
                        }
                    }
                    else if (cordinatapc == "b3")
                    {
                        if (riga3[3] == " ")
                        {
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
                            Console.WriteLine("Mi dispiace non puoi inserlo li");
                            count--;
                        }
                    }
                    else if (cordinatapc == "c3")
                    {
                        if (riga3[5] == " ")
                        {
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
                            Console.WriteLine("Mi dispiace non puoi inserlo li");
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
    }
}