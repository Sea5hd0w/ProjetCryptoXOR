namespace XORProjetCrypto
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDictionnaire = new System.Windows.Forms.Button();
            this.buttonDirectory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEndKey = new System.Windows.Forms.TextBox();
            this.textBoxStartkey = new System.Windows.Forms.TextBox();
            this.textBoxDictionnaire = new System.Windows.Forms.TextBox();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tryKey = new System.Windows.Forms.TextBox();
            this.buttonTryKey = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDictionnaire);
            this.groupBox1.Controls.Add(this.buttonDirectory);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxEndKey);
            this.groupBox1.Controls.Add(this.textBoxStartkey);
            this.groupBox1.Controls.Add(this.textBoxDictionnaire);
            this.groupBox1.Controls.Add(this.textBoxDirectory);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intialisation";
            // 
            // buttonDictionnaire
            // 
            this.buttonDictionnaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDictionnaire.Location = new System.Drawing.Point(433, 45);
            this.buttonDictionnaire.Name = "buttonDictionnaire";
            this.buttonDictionnaire.Size = new System.Drawing.Size(75, 20);
            this.buttonDictionnaire.TabIndex = 8;
            this.buttonDictionnaire.Text = "Dictionnaire";
            this.buttonDictionnaire.UseVisualStyleBackColor = true;
            this.buttonDictionnaire.Click += new System.EventHandler(this.buttonDictionnaire_Click);
            // 
            // buttonDirectory
            // 
            this.buttonDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDirectory.Location = new System.Drawing.Point(433, 21);
            this.buttonDirectory.Name = "buttonDirectory";
            this.buttonDirectory.Size = new System.Drawing.Size(75, 20);
            this.buttonDirectory.TabIndex = 0;
            this.buttonDirectory.Text = "Dossier";
            this.buttonDirectory.UseVisualStyleBackColor = true;
            this.buttonDirectory.Click += new System.EventHandler(this.buttonDirectory_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "End key :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start key :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Base de données dictionnaire :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dossier fichier(s) chiffé(s) :";
            // 
            // textBoxEndKey
            // 
            this.textBoxEndKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEndKey.Location = new System.Drawing.Point(70, 112);
            this.textBoxEndKey.MaxLength = 6;
            this.textBoxEndKey.Name = "textBoxEndKey";
            this.textBoxEndKey.Size = new System.Drawing.Size(438, 20);
            this.textBoxEndKey.TabIndex = 3;
            // 
            // textBoxStartkey
            // 
            this.textBoxStartkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStartkey.Location = new System.Drawing.Point(70, 86);
            this.textBoxStartkey.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.textBoxStartkey.MaxLength = 6;
            this.textBoxStartkey.Name = "textBoxStartkey";
            this.textBoxStartkey.Size = new System.Drawing.Size(438, 20);
            this.textBoxStartkey.TabIndex = 2;
            // 
            // textBoxDictionnaire
            // 
            this.textBoxDictionnaire.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDictionnaire.Location = new System.Drawing.Point(165, 45);
            this.textBoxDictionnaire.Name = "textBoxDictionnaire";
            this.textBoxDictionnaire.ReadOnly = true;
            this.textBoxDictionnaire.Size = new System.Drawing.Size(262, 20);
            this.textBoxDictionnaire.TabIndex = 1;
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDirectory.Location = new System.Drawing.Point(142, 21);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.ReadOnly = true;
            this.textBoxDirectory.Size = new System.Drawing.Size(285, 20);
            this.textBoxDirectory.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tryKey);
            this.groupBox2.Controls.Add(this.buttonTryKey);
            this.groupBox2.Controls.Add(this.buttonPause);
            this.groupBox2.Controls.Add(this.buttonStart);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(523, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 138);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decrypter";
            // 
            // tryKey
            // 
            this.tryKey.Location = new System.Drawing.Point(6, 112);
            this.tryKey.MaxLength = 6;
            this.tryKey.Name = "tryKey";
            this.tryKey.Size = new System.Drawing.Size(102, 20);
            this.tryKey.TabIndex = 0;
            // 
            // buttonTryKey
            // 
            this.buttonTryKey.Location = new System.Drawing.Point(6, 86);
            this.buttonTryKey.Name = "buttonTryKey";
            this.buttonTryKey.Size = new System.Drawing.Size(102, 23);
            this.buttonTryKey.TabIndex = 2;
            this.buttonTryKey.Text = "Try key :";
            this.buttonTryKey.UseVisualStyleBackColor = true;
            this.buttonTryKey.Click += new System.EventHandler(this.buttonTryKey_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(6, 48);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(102, 23);
            this.buttonPause.TabIndex = 1;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(6, 19);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(102, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxResult);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 213);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Résultat";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(646, 369);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(640, 144);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(634, 194);
            this.textBoxResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 369);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.TextBox textBoxEndKey;
        private System.Windows.Forms.TextBox textBoxStartkey;
        private System.Windows.Forms.TextBox textBoxDictionnaire;
        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDictionnaire;
        private System.Windows.Forms.Button buttonDirectory;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox tryKey;
        private System.Windows.Forms.Button buttonTryKey;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

