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

        string startKey = string.Empty;
        string endKey = string.Empty;
        string key = string.Empty;

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
                    if (textBoxStartkey.Text.Length == 6 & textBoxEndKey.Text.Length == 6)
                    {
                        Console.WriteLine("OK");
                        endKey = textBoxEndKey.Text;
                        key = textBoxStartkey.Text;

                        //KeyGenerator key = new KeyGenerator("abcdefghijklmnopqrstuvwxyz", 6, textBoxStartkey.Text, textBoxEndKey.Text);
                        //key.GenerateKeys();


                        decrypt = new Thread(Start);
                        decrypt.Start();

                        //Start();
                    }
                }
            }
        }

        private void Start()
        {
            LoadFiles();
            double scoreKey = 0;
            string textBin;
            string textChar;

            KeyGenerator keyGen = new KeyGenerator("abcdefghijklmnopqrstuvwxyz", 6, textBoxStartkey.Text, textBoxEndKey.Text);
            Dictionary dictionary = new Dictionary(dictionnairePath);
            long i = 0;

            while (!key.SequenceEqual(endKey))
            {
                key = keyGen.GenerateKey();
                i++;
                List<string> write = new List<string>();

                foreach (Tuple<string, List<string>> doc in document)
                {
                    foreach (string line in doc.Item2)
                    {
                        textBin = XOR.Decode(line, key);
                        //textChar = XOR.BinaryToString(textBin);
                        //scoreKey += dictionary.CheckString(textChar);
                    }
                    if (scoreKey > 50) using (StreamWriter sw = File.AppendText("d:\\test.txt")) {sw.WriteLine("File:[" + doc.Item1 + "] - Key:[" + key + "] - Score:[" + scoreKey + "]");}
                    //Console.WriteLine("File:[" + doc.Item1 + "] - Key:[" + key + "] - Score:[" + scoreKey + "]");
                    
                    scoreKey = 0;
                }
                Console.WriteLine(key);
            }
            
            Console.WriteLine("EOF");
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
            string textChar;

            key = tryKey.Text;

            textBoxResult.Text += key + Environment.NewLine;

            foreach (Tuple<string, List<string>> doc in document)
            {
                foreach (string line in doc.Item2)
                {
                    textBin = XOR.Decode(line, key);
                    textChar = XOR.BinaryToString(textBin);
                    textBoxResult.Text += textChar;
                }
                textBoxResult.Text += Environment.NewLine;
                textBoxResult.Text += Environment.NewLine;
            }
        }
    }
}
