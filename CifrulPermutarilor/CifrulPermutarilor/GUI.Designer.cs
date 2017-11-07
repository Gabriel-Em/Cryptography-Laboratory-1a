namespace CifrulPermutarilor
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.DecryptedRT = new System.Windows.Forms.RichTextBox();
            this.EncryptedRT = new System.Windows.Forms.RichTextBox();
            this.CheieRT = new System.Windows.Forms.RichTextBox();
            this.EncryptB = new System.Windows.Forms.Button();
            this.KeyLoadB = new System.Windows.Forms.Button();
            this.DecryptB = new System.Windows.Forms.Button();
            this.FileEncrypt = new System.Windows.Forms.Button();
            this.FileDecrypt = new System.Windows.Forms.Button();
            this.ExitB = new System.Windows.Forms.Button();
            this.SaveB = new System.Windows.Forms.Button();
            this.Titlu = new System.Windows.Forms.PictureBox();
            this.CheieT = new System.Windows.Forms.PictureBox();
            this.DecriptatMargin = new System.Windows.Forms.PictureBox();
            this.CriptatMargin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Titlu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheieT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecriptatMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriptatMargin)).BeginInit();
            this.SuspendLayout();
            // 
            // DecryptedRT
            // 
            this.DecryptedRT.BackColor = System.Drawing.Color.GhostWhite;
            this.DecryptedRT.Location = new System.Drawing.Point(56, 171);
            this.DecryptedRT.Name = "DecryptedRT";
            this.DecryptedRT.Size = new System.Drawing.Size(687, 135);
            this.DecryptedRT.TabIndex = 0;
            this.DecryptedRT.Text = "";
            // 
            // EncryptedRT
            // 
            this.EncryptedRT.BackColor = System.Drawing.Color.GhostWhite;
            this.EncryptedRT.ForeColor = System.Drawing.Color.Black;
            this.EncryptedRT.Location = new System.Drawing.Point(12, 360);
            this.EncryptedRT.Name = "EncryptedRT";
            this.EncryptedRT.Size = new System.Drawing.Size(687, 135);
            this.EncryptedRT.TabIndex = 1;
            this.EncryptedRT.Text = "";
            // 
            // CheieRT
            // 
            this.CheieRT.BackColor = System.Drawing.Color.GhostWhite;
            this.CheieRT.Location = new System.Drawing.Point(514, 39);
            this.CheieRT.Name = "CheieRT";
            this.CheieRT.ReadOnly = true;
            this.CheieRT.Size = new System.Drawing.Size(229, 77);
            this.CheieRT.TabIndex = 2;
            this.CheieRT.Text = "";
            // 
            // EncryptB
            // 
            this.EncryptB.BackColor = System.Drawing.Color.Transparent;
            this.EncryptB.BackgroundImage = global::CifrulPermutarilor.Properties.Resources.Cripteaza;
            this.EncryptB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EncryptB.ForeColor = System.Drawing.Color.GreenYellow;
            this.EncryptB.Location = new System.Drawing.Point(195, 312);
            this.EncryptB.Name = "EncryptB";
            this.EncryptB.Size = new System.Drawing.Size(179, 42);
            this.EncryptB.TabIndex = 3;
            this.EncryptB.UseVisualStyleBackColor = false;
            this.EncryptB.Click += new System.EventHandler(this.EncryptB_Click);
            // 
            // KeyLoadB
            // 
            this.KeyLoadB.BackColor = System.Drawing.Color.Transparent;
            this.KeyLoadB.BackgroundImage = global::CifrulPermutarilor.Properties.Resources.ICheie;
            this.KeyLoadB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.KeyLoadB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyLoadB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyLoadB.ForeColor = System.Drawing.Color.GreenYellow;
            this.KeyLoadB.Location = new System.Drawing.Point(514, 123);
            this.KeyLoadB.Name = "KeyLoadB";
            this.KeyLoadB.Size = new System.Drawing.Size(229, 42);
            this.KeyLoadB.TabIndex = 4;
            this.KeyLoadB.UseVisualStyleBackColor = false;
            this.KeyLoadB.Click += new System.EventHandler(this.KeyLoadB_Click);
            // 
            // DecryptB
            // 
            this.DecryptB.BackColor = System.Drawing.Color.Transparent;
            this.DecryptB.BackgroundImage = global::CifrulPermutarilor.Properties.Resources.Decripteaza;
            this.DecryptB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecryptB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DecryptB.ForeColor = System.Drawing.Color.GreenYellow;
            this.DecryptB.Location = new System.Drawing.Point(379, 312);
            this.DecryptB.Name = "DecryptB";
            this.DecryptB.Size = new System.Drawing.Size(179, 42);
            this.DecryptB.TabIndex = 5;
            this.DecryptB.UseVisualStyleBackColor = false;
            this.DecryptB.Click += new System.EventHandler(this.DecryptB_Click);
            // 
            // FileEncrypt
            // 
            this.FileEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.FileEncrypt.BackgroundImage = global::CifrulPermutarilor.Properties.Resources.FCript;
            this.FileEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FileEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FileEncrypt.ForeColor = System.Drawing.Color.GreenYellow;
            this.FileEncrypt.Location = new System.Drawing.Point(12, 312);
            this.FileEncrypt.Name = "FileEncrypt";
            this.FileEncrypt.Size = new System.Drawing.Size(179, 42);
            this.FileEncrypt.TabIndex = 6;
            this.FileEncrypt.UseVisualStyleBackColor = false;
            this.FileEncrypt.Click += new System.EventHandler(this.FileEncrypt_Click);
            // 
            // FileDecrypt
            // 
            this.FileDecrypt.BackColor = System.Drawing.Color.Transparent;
            this.FileDecrypt.BackgroundImage = global::CifrulPermutarilor.Properties.Resources.FDecript;
            this.FileDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FileDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FileDecrypt.ForeColor = System.Drawing.Color.GreenYellow;
            this.FileDecrypt.Location = new System.Drawing.Point(564, 312);
            this.FileDecrypt.Name = "FileDecrypt";
            this.FileDecrypt.Size = new System.Drawing.Size(179, 42);
            this.FileDecrypt.TabIndex = 7;
            this.FileDecrypt.UseVisualStyleBackColor = false;
            this.FileDecrypt.Click += new System.EventHandler(this.FileDecrypt_Click);
            // 
            // ExitB
            // 
            this.ExitB.BackColor = System.Drawing.Color.Transparent;
            this.ExitB.BackgroundImage = global::CifrulPermutarilor.Properties.Resources.Iesire;
            this.ExitB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitB.ForeColor = System.Drawing.Color.GreenYellow;
            this.ExitB.Location = new System.Drawing.Point(381, 501);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(362, 42);
            this.ExitB.TabIndex = 9;
            this.ExitB.UseVisualStyleBackColor = false;
            this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
            // 
            // SaveB
            // 
            this.SaveB.BackColor = System.Drawing.Color.Transparent;
            this.SaveB.BackgroundImage = global::CifrulPermutarilor.Properties.Resources.Salveaza;
            this.SaveB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveB.ForeColor = System.Drawing.Color.GreenYellow;
            this.SaveB.Location = new System.Drawing.Point(12, 501);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(362, 42);
            this.SaveB.TabIndex = 8;
            this.SaveB.UseVisualStyleBackColor = false;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // Titlu
            // 
            this.Titlu.BackColor = System.Drawing.Color.Transparent;
            this.Titlu.BackgroundImage = global::CifrulPermutarilor.Properties.Resources.Titlu;
            this.Titlu.Location = new System.Drawing.Point(35, 12);
            this.Titlu.Name = "Titlu";
            this.Titlu.Size = new System.Drawing.Size(448, 139);
            this.Titlu.TabIndex = 10;
            this.Titlu.TabStop = false;
            // 
            // CheieT
            // 
            this.CheieT.BackColor = System.Drawing.Color.Transparent;
            this.CheieT.BackgroundImage = global::CifrulPermutarilor.Properties.Resources.Cheie;
            this.CheieT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CheieT.Location = new System.Drawing.Point(569, -3);
            this.CheieT.Name = "CheieT";
            this.CheieT.Size = new System.Drawing.Size(126, 44);
            this.CheieT.TabIndex = 11;
            this.CheieT.TabStop = false;
            // 
            // DecriptatMargin
            // 
            this.DecriptatMargin.BackColor = System.Drawing.Color.Transparent;
            this.DecriptatMargin.BackgroundImage = global::CifrulPermutarilor.Properties.Resources.MarginDecriptat;
            this.DecriptatMargin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DecriptatMargin.Location = new System.Drawing.Point(-3, 171);
            this.DecriptatMargin.Name = "DecriptatMargin";
            this.DecriptatMargin.Size = new System.Drawing.Size(65, 135);
            this.DecriptatMargin.TabIndex = 12;
            this.DecriptatMargin.TabStop = false;
            // 
            // CriptatMargin
            // 
            this.CriptatMargin.BackColor = System.Drawing.Color.Transparent;
            this.CriptatMargin.BackgroundImage = global::CifrulPermutarilor.Properties.Resources.MarginCriptat;
            this.CriptatMargin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CriptatMargin.Location = new System.Drawing.Point(691, 360);
            this.CriptatMargin.Name = "CriptatMargin";
            this.CriptatMargin.Size = new System.Drawing.Size(65, 135);
            this.CriptatMargin.TabIndex = 13;
            this.CriptatMargin.TabStop = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 550);
            this.ControlBox = false;
            this.Controls.Add(this.CheieRT);
            this.Controls.Add(this.CheieT);
            this.Controls.Add(this.Titlu);
            this.Controls.Add(this.ExitB);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.FileDecrypt);
            this.Controls.Add(this.FileEncrypt);
            this.Controls.Add(this.DecryptB);
            this.Controls.Add(this.KeyLoadB);
            this.Controls.Add(this.EncryptB);
            this.Controls.Add(this.EncryptedRT);
            this.Controls.Add(this.DecryptedRT);
            this.Controls.Add(this.DecriptatMargin);
            this.Controls.Add(this.CriptatMargin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.Text = "Cifrul Permutarilor - Copyright © Gaby Em";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Titlu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheieT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecriptatMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriptatMargin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox DecryptedRT;
        private System.Windows.Forms.RichTextBox EncryptedRT;
        private System.Windows.Forms.RichTextBox CheieRT;
        private System.Windows.Forms.Button EncryptB;
        private System.Windows.Forms.Button KeyLoadB;
        private System.Windows.Forms.Button DecryptB;
        private System.Windows.Forms.Button FileEncrypt;
        private System.Windows.Forms.Button FileDecrypt;
        private System.Windows.Forms.Button ExitB;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.PictureBox Titlu;
        private System.Windows.Forms.PictureBox CheieT;
        private System.Windows.Forms.PictureBox DecriptatMargin;
        private System.Windows.Forms.PictureBox CriptatMargin;
    }
}

