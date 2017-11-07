using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CifrulPermutarilor
{
    class Criptograf
    {
        private int[] cheie = new int[20];
        private int lungime;
        private Validator valid = new Validator();

        public int getLungime()
        {
            return lungime;
        }

        public int getCheie(int i)  // returneaza valoarea de la un indice din cheie
        {
            return cheie[i];
        }

        public int getOrder(int i)  // returneaza indicele unei valori din cheie
        {
            int x = 0;

            for (int j = 1; j <= lungime; j++)
                if (cheie[j] == i)
                    x = j;

            return x;
        }

        public int KeyLoad()
        {
            if (File.Exists(@".\Key.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(@".\Key.txt"); //incarc toate liniile din fisier
                string[] aux;   // string folosit la incarcarea permutarii
                int validate = valid.KeyValidate(lines);    //verific daca cheia e corecta

                if (validate == 1)
                {
                    lungime = Int32.Parse(lines[0]);
                    aux = lines[1].Split(' ');

                    for (int i = 1; i <= lungime; i++)
                    {
                        cheie[i] = Int32.Parse(aux[i - 1]);
                    }
                    return 1;
                }
                else
                    return -1;
            }
            else
                return 0;
        }



        public string encrypt(string sir)
        {
            int x, p, i,l;

            //Verificam daca lungimea sirului e multiplu de lungime (in permutare)
            //In caz contrar adaugam numarul de spatii de care e nevoie
            
            l = sir.Length;

            if (l % lungime!= 0)
                for (i = 1; i <= lungime - (l % lungime); i++)
                    sir = sir + " ";


            string ensir, temp; // sirul encriptat si un sir auxiliar


            temp = "";  // string folosit la criptarea grupurilor
            x = 0;  // ma anunta cand am finalizat de criptat un grup
            p = 0;  // numarul grupului pe care il criptez
            ensir = "";

            for (i = 0; i < sir.Length; i++)
            {
                temp = temp + sir[lungime * p + cheie[i % lungime + 1] - 1];
                //lungime * p = unde incepe al p-lea grup in sir, i % lungime = la al catalea indice din permutare ma aflu
                x++;

                if (x == lungime)   // am finalizat de criptat un grup de caractere
                {
                    p++;    // nr grupului pe care-l il criptez
                    x = 0;
                    ensir = ensir + temp;   // salvez grupul criptat in sirul final
                    temp = "";
                }
            }

            return ensir;
        }

        public string decrypt(string sir)
        {
            //Verificam daca lungimea sirului e multiplu de lungime (a permutarii)
            //In caz contrar adaugam numarul de spatii de care e nevoie

            int i, l = sir.Length;

            if (l % lungime != 0)
                for (i = 1; i <= lungime - (l % lungime); i++)
                    sir = sir + " ";

            string desir, temp; // sirul decriptat si un sir auxiliar
            int x, p;

            temp = ""; // stringul folosit la critparea grupurilor
            x = 0;  // ma anunta cand am finalizat de decriptat un grup
            p = 0;  // numarul grupului pe care il decriptez
            desir = "";

            for (i = 0; i < sir.Length; i++)
            {
                temp = temp + sir[lungime * p + getOrder(i % lungime + 1) - 1];
                //lungime * p = unde incepe al p-lea grup in sir, i % lungime = valoarea careia ii caut indicele din permutare
                x++;

                if (x == lungime)
                {
                    p++;    // nr grupului pe care il decriptez
                    x = 0;
                    desir = desir + temp;   // salvez grupul decriptat in sirul final
                    temp = "";
                }
            }

            return desir;

        }
    }
}
