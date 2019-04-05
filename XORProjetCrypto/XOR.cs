using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XORProjetCrypto
{
    public static class XOR
    {
        public static string Encode(string text, string key)
        {
            string cipher = string.Empty;
            string binaryText = StringToBinary(text);
            string binaryKey = StringToBinary(key);

            for (int i = 0; i < binaryText.Length; i++)
            {
                if (binaryKey[i % binaryKey.Length] == binaryText[i]) cipher += "0";
                else cipher += "1";
            }
            return cipher;
        }

        public static string Decode(string cipher, string key)
        {
            string text = string.Empty;
            string binaryCipher = StringToBinary(cipher);
            string binaryKey = StringToBinary(key);

            for (int i = 0; i < binaryCipher.Length; i++)
            {
                if (binaryKey[i % binaryKey.Length] == binaryCipher[i]) text += "0";
                else text += "1";
            }
            return text;
        }

        public static string EncryptOrDecrypt(string cipher, string key)
        {
            var result = new StringBuilder();
            for (int c = 0; c < cipher.Length; c++)
                    result.Append((char)((uint)cipher[c] ^ (uint)key[c % key.Length]));
            return result.ToString();
        }

        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        public static string BinaryToString(string data)
        {
            List<Byte> byteList = new List<Byte>();
            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }
    }
}
