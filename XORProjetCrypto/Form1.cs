using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XORProjetCrypto
{
    public partial class Form1 : Form
    {
        string directoryPath = string.Empty;
        string dictionnairePath = string.Empty;

        string startKey1 = string.Empty;
        string endKey1 = string.Empty;
        string key1 = string.Empty;

        string startKey2 = string.Empty;
        string endKey2 = string.Empty;
        string key2 = string.Empty;

        string startKey3 = string.Empty;
        string endKey3 = string.Empty;
        string key3 = string.Empty;

        List<string> pathDocuments = new List<string>();
        List<Tuple<string, List<string>>> document = new List<Tuple<string, List<string>>>();

        //Tuple<string, int>
        List<string> results = new List<string>();

        Thread decrypt;

        public Form1()
        {
            InitializeComponent();

        }

        private void test()
        {

            /* ============= UTILISATION DIC ============= *\
            Dictionary test = new Dictionary(dictionnairePath);
            Console.WriteLine(test.CheckString("couecou et de cette zz aerf azer zqbduq qzd"));
            \* ============= =============== ============= */


            /* ============= UTILISATION KEY ============= *\
            KeyGenerator key = new KeyGenerator("abcdefghijklmnopqrstuvwxyz", 6, textBoxStartkey.Text, textBoxEndKey.Text);
            key.GenerateKey();
            \* ============= =============== ============= */


            /* ============= UTILISATION XOR ============= *\
            string cipherBin = XOR.Encode("test du code XOR pour voir", "azesgrhdtjy");
            Console.WriteLine(cipherBin);

            string cipherChar = XOR.BinaryToString(cipherBin);
            Console.WriteLine(cipherChar);

            string textBin = XOR.Decode(cipherChar, "azesgrhdtjy");
            Console.WriteLine(textBin);

            string textChar = XOR.BinaryToString(textBin);
            Console.WriteLine(textChar);
            \* ============= =============== ============= */
        }

        private void buttonDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                textBoxDirectory.Text = folderBrowserDialog.SelectedPath;
                directoryPath = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonDictionnaire_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "d:\\";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dictionnairePath = openFileDialog.FileName;
                this.textBoxDictionnaire.Text = dictionnairePath;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            test();

            
            if (Directory.Exists(directoryPath))
            {
                if (File.Exists(dictionnairePath))
                {
                    LoadFiles();

                    if (textBoxStartkey1.Text.Length == 6 & textBoxEndKey1.Text.Length == 6)
                    {
                        Console.WriteLine("Task 1 - Start");
                        endKey1 = textBoxEndKey1.Text;
                        key1 = textBoxStartkey1.Text;

                        var t1 = Task.Factory.StartNew(() => Start1());
                    }
                    if (textBoxStartkey2.Text.Length == 6 & textBoxEndKey2.Text.Length == 6)
                    {
                        Console.WriteLine("Task 2 - Start");
                        endKey2 = textBoxEndKey2.Text;
                        key2 = textBoxStartkey2.Text;

                        var t2 = Task.Factory.StartNew(() => Start2());
                    }
                    if (textBoxStartkey3.Text.Length == 6 & textBoxEndKey3.Text.Length == 6)
                    {
                        Console.WriteLine("Task 3 - Start");
                        endKey3 = textBoxEndKey3.Text;
                        key3 = textBoxStartkey3.Text;

                        var t3 = Task.Factory.StartNew(() => Start3());
                    }

                    /*
                    if (textBoxStartkey1.Text.Length == 6 & textBoxEndKey1.Text.Length == 6)
                    {
                        Console.WriteLine("OK");
                        endKey1 = textBoxEndKey1.Text;
                        key1 = textBoxStartkey1.Text;

                        //KeyGenerator key = new KeyGenerator("abcdefghijklmnopqrstuvwxyz", 6, textBoxStartkey.Text, textBoxEndKey.Text);
                        //key.GenerateKeys();


                        decrypt = new Thread(Start1);
                        decrypt.Start();

                        //Start();
                    }*/
                }
            }
        }

        private void Start1()
        {
            double scoreKey = 0;
            string textBin;
            string textChar = "";
            

            KeyGenerator keyGen = new KeyGenerator("abcdefghijklmnopqrstuvwxyz", 6, textBoxStartkey1.Text, textBoxEndKey1.Text);
            Dictionary dictionary = new Dictionary(dictionnairePath);
            long i = 0;

            while (!key1.SequenceEqual(endKey1))
            {
                key1 = keyGen.GenerateKey();
                i++;
                List<string> write = new List<string>();

                foreach (Tuple<string, List<string>> doc in document)
                {
                    foreach (string line in doc.Item2)
                    {
                        /*
                        textBin = XOR.Decode(line, key);
                        textChar = XOR.BinaryToString(textBin);
                        scoreKey += dictionary.CheckString(textChar);
                        */
                        string t = XOR.EncryptOrDecrypt(line, key1);
                        textChar += t;
                        scoreKey += dictionary.CheckString(t);

                    }
                    if (scoreKey > 100) using (StreamWriter sw = File.AppendText("d:\\test.txt")) {sw.WriteLine("Task 1 - File:[" + doc.Item1 + "] - Key:[" + key1 + "] - Score:[" + scoreKey + "]");}
                    //Console.WriteLine("File:[" + doc.Item1 + "] - Key:[" + key1 + "] - Score:[" + scoreKey + "]" + textChar);
                    
                    scoreKey = 0;
                }
                //Console.WriteLine(key);
                textChar = "";
            }
            Console.WriteLine("Task 1 - End");
        }

        private void Start2()
        {
            double scoreKey = 0;
            string textBin;
            string textChar = "";


            KeyGenerator keyGen = new KeyGenerator("abcdefghijklmnopqrstuvwxyz", 6, textBoxStartkey2.Text, textBoxEndKey2.Text);
            Dictionary dictionary = new Dictionary(dictionnairePath);
            long i = 0;

            while (!key2.SequenceEqual(endKey2))
            {
                key2 = keyGen.GenerateKey();
                i++;
                List<string> write = new List<string>();

                foreach (Tuple<string, List<string>> doc in document)
                {
                    foreach (string line in doc.Item2)
                    {
                        /*
                        textBin = XOR.Decode(line, key);
                        textChar = XOR.BinaryToString(textBin);
                        scoreKey += dictionary.CheckString(textChar);
                        */
                        string t = XOR.EncryptOrDecrypt(line, key2);
                        textChar += t;
                        scoreKey += dictionary.CheckString(t);

                    }
                    if (scoreKey > 100) using (StreamWriter sw = File.AppendText("d:\\test.txt")) { sw.WriteLine("Task 2 - File:[" + doc.Item1 + "] - Key:[" + key2 + "] - Score:[" + scoreKey + "]"); }
                    //Console.WriteLine("File:[" + doc.Item1 + "] - Key:[" + key + "] - Score:[" + scoreKey + "]" + textChar);

                    scoreKey = 0;
                }
                //Console.WriteLine(key);
                textChar = "";
            }
            Console.WriteLine("Task 2 - End");
        }

        private void Start3()
        {
            double scoreKey = 0;
            string textBin;
            string textChar = "";


            KeyGenerator keyGen = new KeyGenerator("abcdefghijklmnopqrstuvwxyz", 6, textBoxStartkey3.Text, textBoxEndKey3.Text);
            Dictionary dictionary = new Dictionary(dictionnairePath);
            long i = 0;

            while (!key3.SequenceEqual(endKey3))
            {
                key3= keyGen.GenerateKey();
                i++;
                List<string> write = new List<string>();

                foreach (Tuple<string, List<string>> doc in document)
                {
                    foreach (string line in doc.Item2)
                    {
                        /*
                        textBin = XOR.Decode(line, key);
                        textChar = XOR.BinaryToString(textBin);
                        scoreKey += dictionary.CheckString(textChar);
                        */
                        string t = XOR.EncryptOrDecrypt(line, key3);
                        textChar += t;
                        scoreKey += dictionary.CheckString(t);
                    }
                    if (scoreKey > 100) using (StreamWriter sw = File.AppendText("d:\\test.txt")) { sw.WriteLine("Task 3 - File:[" + doc.Item1 + "] - Key:[" + key3 + "] - Score:[" + scoreKey + "]"); }
                    //Console.WriteLine("File:[" + doc.Item1 + "] - Key:[" + key + "] - Score:[" + scoreKey + "]" + textChar);

                    scoreKey = 0;
                }
                //Console.WriteLine(key);
                textChar = "";
            }
            Console.WriteLine("Task 3 - End");
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
        }

        public void LoadFiles()
        {
            string[] files = Directory.GetFiles(directoryPath);

            foreach(string path in files)
            {
                string[] logFile = File.ReadAllLines(path);
                document.Add(new Tuple<string, List<string>>(path, new List<string>(logFile)));
            }
        }

        private void buttonTryKey_Click(object sender, EventArgs e)
        {
            LoadFiles();
            string textBin;
            string textChar ="";

            key1 = tryKey.Text;

            textBoxResult.Text += key1 + Environment.NewLine;

            foreach (Tuple<string, List<string>> doc in document)
            {
                foreach (string line in doc.Item2)
                {
                    /*
                    textBin = XOR.Decode(line, key);
                    textChar += XOR.BinaryToString(textBin);
                    */
                    textChar += XOR.EncryptOrDecrypt(line, key1);

                    textBoxResult.Text += textChar;
                }
                textBoxResult.Text += Environment.NewLine;
                textBoxResult.Text += Environment.NewLine;
            }
        }
    }
}
