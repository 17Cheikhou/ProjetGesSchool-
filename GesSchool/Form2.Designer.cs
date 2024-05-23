namespace GesSchool
{
    partial class Form2
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
            this.dtgClasse = new System.Windows.Forms.DataGridView();
            this.save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboNiv = new System.Windows.Forms.ComboBox();
            this.comboSpec = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgClasse
            // 
            this.dtgClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClasse.Location = new System.Drawing.Point(502, 29);
            this.dtgClasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgClasse.Name = "dtgClasse";
            this.dtgClasse.RowHeadersWidth = 62;
            this.dtgClasse.Size = new System.Drawing.Size(598, 498);
            this.dtgClasse.TabIndex = 30;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(86, 375);
            this.save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(138, 51);
            this.save.TabIndex = 29;
            this.save.Text = "Enregristrer";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "Niveau :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Specialite :";
            // 
            // comboNiv
            // 
            this.comboNiv.FormattingEnabled = true;
            this.comboNiv.Items.AddRange(new object[] {
            "L1",
            "L2",
            "L3",
            "Master 1",
            "Master 2"});
            this.comboNiv.Location = new System.Drawing.Point(206, 232);
            this.comboNiv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboNiv.Name = "comboNiv";
            this.comboNiv.Size = new System.Drawing.Size(145, 28);
            this.comboNiv.TabIndex = 26;
            // 
            // comboSpec
            // 
            this.comboSpec.FormattingEnabled = true;
            this.comboSpec.Items.AddRange(new object[] {
            "Genie Logiciel",
            "Informatique de Gestion",
            "Reseaux",
            "Comptabilite"});
            this.comboSpec.Location = new System.Drawing.Point(206, 132);
            this.comboSpec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboSpec.Name = "comboSpec";
            this.comboSpec.Size = new System.Drawing.Size(145, 28);
            this.comboSpec.TabIndex = 25;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 554);
            this.Controls.Add(this.dtgClasse);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboNiv);
            this.Controls.Add(this.comboSpec);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgClasse;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboNiv;
        private System.Windows.Forms.ComboBox comboSpec;
    }
}