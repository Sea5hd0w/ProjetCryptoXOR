using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XORProjetCrypto
{
    class KeyGenerator
    {
        char[] charUsed;
        int lenghtKey = 0;
        string startKey = string.Empty;
        char[] key;
        char[] endKey;

        //Generate key
        int[] currentCharPosition;
        int loop;

        public KeyGenerator(string charUsed, int lenghtKey, string startKey, string endKey)
        {
            this.charUsed = charUsed.ToArray();
            this.lenghtKey = lenghtKey;
            this.startKey = startKey;
            this.key = startKey.ToArray();
            this.endKey = endKey.ToArray();

            LoadRessources();

            /*while (!key.SequenceEqual(endKey))
            {
                GenerateKey();
            }*/
        }

        private void LoadRessources()
        {
            currentCharPosition = new int[key.Length];
            // Load curent char position
            for (int i = key.Length - 1; i >= 0; i--)
            {
                for (int x = 0; x < charUsed.Length; x++) if (key[i] == charUsed[x]) currentCharPosition[i] = x;
            }
            loop = 0;
        }

        public string GenerateKeys()
        {
            char[] charUsed_local = charUsed;
            string startKey_local = startKey;
            char[] key_local = key;
            char[] endKey_local = endKey;

            int[] currentCharPosition_local = new int[key_local.Length];

            // Load curent char position
            for (int i = key_local.Length - 1; i >= 0; i--)
            {
                for (int x = 0; x < charUsed_local.Length; x++) if (key_local[i] == charUsed_local[x]) currentCharPosition_local[i] = x;
            }

            int t = 0;
            while (!key_local.SequenceEqual(endKey_local))
            {
                bool incrementNext_local = false;
                for (int i = key_local.Length - 1; i >= 0; i--)
                {
                    if (i == key_local.Length - 1) //Increment first char
                    {
                        if (((currentCharPosition_local[i] + 1) / charUsed_local.Length) == 1) incrementNext_local = true;
                        else incrementNext_local = false;
                        currentCharPosition_local[i] = (currentCharPosition_local[i] + 1) % charUsed_local.Length;
                        key_local[i] = charUsed_local[currentCharPosition_local[i]];
                    }
                    else if (incrementNext_local) //increment next char if previous is 'z'
                    {
                        if (((currentCharPosition_local[i] + 1) / charUsed_local.Length) == 1) incrementNext_local = true;
                        else incrementNext_local = false;
                        currentCharPosition_local[i] = (currentCharPosition_local[i] + 1) % charUsed_local.Length;
                        key_local[i] = charUsed_local[currentCharPosition_local[i]];
                    }

                    //Case "zzzzzz"
                    if (i == 0 && incrementNext_local == true) incrementNext_local = false;
                    //Console.WriteLine(i + " " + startKey[i] + " " + key_local[i] + " " + currentCharPosition[i]);
                }

                t++;
                Console.WriteLine(new string(key_local) + " " + new string(endKey_local) + " " + t);

            }

            return "";
        }

        public string GenerateKey()
        {
            bool incrementNext = false;
            for (int i = key.Length - 1; i >= 0; i--)
            {
                if (i == key.Length - 1) //Increment first char
                {
                    if (((currentCharPosition[i] + 1) / charUsed.Length) == 1) incrementNext = true;
                    else incrementNext = false;
                    currentCharPosition[i] = (currentCharPosition[i] + 1) % charUsed.Length;
                    key[i] = charUsed[currentCharPosition[i]];
                }
                else if (incrementNext) //increment next char if previous is 'z'
                {
                    if (((currentCharPosition[i] + 1) / charUsed.Length) == 1) incrementNext = true;
                    else incrementNext = false;
                    currentCharPosition[i] = (currentCharPosition[i] + 1) % charUsed.Length;
                    key[i] = charUsed[currentCharPosition[i]];
                }
    
                //Case "zzzzzz"
                if (i == 0 && incrementNext == true) incrementNext = false;

                //Console.WriteLine(i + " " + startKey[i] + " " + key[i] + " " + currentCharPosition[i]);

            }
            loop++;
            return new string(key);
        }

    }
}
