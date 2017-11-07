using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CifrulPermutarilor
{
    public partial class GUI : Form
    {
        private Criptograf crp = new Criptograf();
        private int valid;
        
        public GUI()
        {
            InitializeComponent();       
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            KeyLoad();
        }

        private void KeyLoad()
        {
            valid = crp.KeyLoad();
            if (valid == 1)
            {
                int[] cheie = new int[20];
                int lungime;

                lungime = crp.getLungime();
                for (int i = 1; i <= lungime; i++)
                    cheie[i] = crp.getCheie(i);

                CheieRT.Text = "Permutarea: \n\n( ";
                for (int i = 1; i <= lungime; i++)
                    CheieRT.Text = CheieRT.Text + i.ToString() + " ";
                CheieRT.Text = CheieRT.Text + ")\n( ";
                for (int i = 1; i <= lungime; i++)
                    CheieRT.Text = CheieRT.Text + cheie[i].ToString() + " ";
                CheieRT.Text = CheieRT.Text + ")";

            }
            else
                if (valid == 0)
                {
                    CheieRT.Text = "Error: Fisierul 'Key.txt' nu exista sau nu poate fii accesat!";
                }
            if (valid == -1)
                CheieRT.Text = "Error: Cheia de criptare e gresita!";
        }

        private void EncryptB_Click(object sender, EventArgs e)
        {
            if (valid != 1)
                MessageBox.Show("Nu exista nicio cheie de criptare!");
            else
            {
                string init, final;
                init = "";
                final = "";

                init = DecryptedRT.Text;
                final = crp.encrypt(init);
                EncryptedRT.Text = final;
            }
            
        }

        private void DecryptB_Click(object sender, EventArgs e)
        {
            if (valid != 1)
                MessageBox.Show("Nu exista nicio cheie de criptare!");
            else
            {
                string init, final;
                init = "";
                final = "";

                init = EncryptedRT.Text;
                final = crp.decrypt(init);
                DecryptedRT.Text = final;
            }
        }

        private void FileEncrypt_Click(object sender, EventArgs e)
        {
            if (valid != 1)
                MessageBox.Show("Nu exista nicio cheie de criptare!");
            else
                if (File.Exists(@".\Decrypted.txt"))
                {
                    string init = System.IO.File.ReadAllText(@".\Decrypted.txt");
                    string final;

                    final = "";

                    DecryptedRT.Text = init;
                    final = crp.encrypt(init);
                    EncryptedRT.Text = final;
                }
                else
                {
                    DecryptedRT.Text = "Error: Fisierul 'Decrypted.txt' nu exista sau nu poate fii accesat!";
                    EncryptedRT.Text = "Error: Fisierul 'Decrypted.txt' nu exista sau nu poate fii accesat!";
                }
                
        }

        private void FileDecrypt_Click(object sender, EventArgs e)
        {
            if (valid != 1)
                MessageBox.Show("Nu exista nicio cheie de criptare!");
            else
                if (File.Exists(@".\Encrypted.txt"))
                {
                    string init = System.IO.File.ReadAllText(@".\Encrypted.txt");
                    string final;

                    final = "";

                    EncryptedRT.Text = init;
                    final = crp.decrypt(init);
                    DecryptedRT.Text = final;
                }
                else
                {
                    DecryptedRT.Text = "Error: Fisierul 'Decrypted.txt' nu exista sau nu poate fii accesat!";
                    EncryptedRT.Text = "Error: Fisierul 'Decrypted.txt' nu exista sau nu poate fii accesat!";
                }
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            string text;

            if (DecryptedRT.Text == "" && EncryptedRT.Text != "")
                MessageBox.Show("Campul 'Decriptat' e gol!");
            else
                if (DecryptedRT.Text != "" && EncryptedRT.Text == "")
                    MessageBox.Show("Campul 'Criptat' e gol!");
                else
                    if (DecryptedRT.Text == "" && EncryptedRT.Text == "")
                        MessageBox.Show("Campurile 'Decriptat' si 'Criptat' sunt goale!");
                    else
                    {

                        text = DecryptedRT.Text;
                        System.IO.File.WriteAllText(@"Decrypted.txt", text);
                        text = EncryptedRT.Text;
                        System.IO.File.WriteAllText(@"Encrypted.txt", text);

                        MessageBox.Show("Textul din campurile 'Decriptat' si 'Criptat' a fost salvat cu succes in fisierele 'Decrypted.txt' si 'Encrypted.txt'!");
                    }
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa inchideti aplicatia?", "ATENTIONARE", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void KeyLoadB_Click(object sender, EventArgs e)
        {
            KeyLoad();
        }


       
    }
}
