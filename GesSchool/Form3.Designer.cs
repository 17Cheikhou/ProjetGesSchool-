namespace GesSchool
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.TextBox();
            this.research = new System.Windows.Forms.Button();
            this.suprimer = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.comboClasse = new System.Windows.Forms.ComboBox();
            this.dtgEtudiant = new System.Windows.Forms.DataGridView();
            this.valider = new System.Windows.Forms.Button();
            this.textMontant = new System.Windows.Forms.TextBox();
            this.textAnnesc = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.textCredit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEtudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1130, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(857, 58);
            this.search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(110, 42);
            this.search.TabIndex = 70;
            // 
            // research
            // 
            this.research.Cursor = System.Windows.Forms.Cursors.Hand;
            this.research.Location = new System.Drawing.Point(959, 58);
            this.research.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.research.Name = "research";
            this.research.Size = new System.Drawing.Size(60, 45);
            this.research.TabIndex = 69;
            this.research.Text = "R";
            this.research.UseVisualStyleBackColor = true;
            this.research.Click += new System.EventHandler(this.research_Click);
            // 
            // suprimer
            // 
            this.suprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suprimer.Location = new System.Drawing.Point(626, 352);
            this.suprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.suprimer.Name = "suprimer";
            this.suprimer.Size = new System.Drawing.Size(148, 45);
            this.suprimer.TabIndex = 68;
            this.suprimer.Text = "Suprimer";
            this.suprimer.UseVisualStyleBackColor = true;
            this.suprimer.Click += new System.EventHandler(this.suprimer_Click);
            // 
            // modifier
            // 
            this.modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifier.Location = new System.Drawing.Point(413, 352);
            this.modifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(148, 45);
            this.modifier.TabIndex = 67;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // comboClasse
            // 
            this.comboClasse.FormattingEnabled = true;
            this.comboClasse.Items.AddRange(new object[] {
            "L1",
            "L2",
            "L3",
            "Master 1",
            "Master 2"});
            this.comboClasse.Location = new System.Drawing.Point(785, 289);
            this.comboClasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboClasse.Name = "comboClasse";
            this.comboClasse.Size = new System.Drawing.Size(145, 28);
            this.comboClasse.TabIndex = 66;
            // 
            // dtgEtudiant
            // 
            this.dtgEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEtudiant.Location = new System.Drawing.Point(13, 418);
            this.dtgEtudiant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgEtudiant.Name = "dtgEtudiant";
            this.dtgEtudiant.RowHeadersWidth = 62;
            this.dtgEtudiant.Size = new System.Drawing.Size(1174, 293);
            this.dtgEtudiant.TabIndex = 65;
            // 
            // valider
            // 
            this.valider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.valider.Location = new System.Drawing.Point(179, 352);
            this.valider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(148, 45);
            this.valider.TabIndex = 64;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // textMontant
            // 
            this.textMontant.Location = new System.Drawing.Point(533, 276);
            this.textMontant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textMontant.Multiline = true;
            this.textMontant.Name = "textMontant";
            this.textMontant.Size = new System.Drawing.Size(178, 42);
            this.textMontant.TabIndex = 63;
            // 
            // textAnnesc
            // 
            this.textAnnesc.Location = new System.Drawing.Point(959, 173);
            this.textAnnesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textAnnesc.Multiline = true;
            this.textAnnesc.Name = "textAnnesc";
            this.textAnnesc.Size = new System.Drawing.Size(178, 42);
            this.textAnnesc.TabIndex = 62;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(148, 256);
            this.textNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNom.Multiline = true;
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(178, 42);
            this.textNom.TabIndex = 61;
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(148, 185);
            this.textPrenom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPrenom.Multiline = true;
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(178, 42);
            this.textPrenom.TabIndex = 60;
            // 
            // textCredit
            // 
            this.textCredit.Location = new System.Drawing.Point(533, 176);
            this.textCredit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCredit.Multiline = true;
            this.textCredit.Name = "textCredit";
            this.textCredit.Size = new System.Drawing.Size(168, 42);
            this.textCredit.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 29);
            this.label6.TabIndex = 58;
            this.label6.Text = "Nom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(472, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 29);
            this.label5.TabIndex = 57;
            this.label5.Text = "Ajout Etudiant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 29);
            this.label4.TabIndex = 56;
            this.label4.Text = "Credit :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 58);
            this.label3.TabIndex = 55;
            this.label3.Text = "Montant\r\n  verser :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(755, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 54;
            this.label2.Text = "Annee scolaire :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 53;
            this.label1.Text = "Prenom :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 726);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.research);
            this.Controls.Add(this.suprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.comboClasse);
            this.Controls.Add(this.dtgEtudiant);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.textMontant);
            this.Controls.Add(this.textAnnesc);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.textPrenom);
            this.Controls.Add(this.textCredit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEtudiant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button research;
        private System.Windows.Forms.Button suprimer;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.ComboBox comboClasse;
        private System.Windows.Forms.DataGridView dtgEtudiant;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.TextBox textMontant;
        private System.Windows.Forms.TextBox textAnnesc;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.TextBox textCredit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}