using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CifrulPermutarilor
{
    class Validator
    {
        public int KeyValidate(string[] lines)
        {
            int i, j, l = 0, x; // l = lungimea permutarii
            bool valid = true;  // variabila care decide daca cheia e ok sau nu
            int[] v = new int[20];  // stringul temp convertit in intreg
            string[] temp;  // string temporar care primeste permutarea din fisier

            
            
            bool result = Int32.TryParse(lines[0], out x);  // pe prima linie din fisierul key.txt trebuie sa se afle lungimea cheii (de tip intreg)

            if (result != true)
                valid = false;
            else
            {
                l = Int32.Parse(lines[0]);

                temp = lines[1].Split(' ');

                if (l <= 1)
                    valid = false;
                else
                    for (i = 1; i <= l; i++)
                    {
                        result = Int32.TryParse(temp[i - 1], out x);
                        if (result == true)
                        {
                            if (Int32.Parse(temp[i - 1]) > l)
                            {
                                valid = false;
                                break;
                            }
                            else
                            {
                                for (j = 1; j < i; j++)
                                    if (Int32.Parse(temp[j - 1]) == Int32.Parse(temp[i - 1]))
                                    {
                                        valid = false;
                                        break;
                                    }
                            }
                        }
                        else
                        {
                            valid = false;
                            break;
                        }
                    }
            }

            if (valid)
                return 1;
            else
                return 0;
        }
    }
}
