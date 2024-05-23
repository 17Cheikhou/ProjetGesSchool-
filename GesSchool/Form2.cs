using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesSchool
{
    public partial class Form2 : Form
    {
       Ges_schoolEntities context = new Ges_schoolEntities();

        public Form2()
        {
            InitializeComponent();
            dtgClasse.DataSource = context.Classe.ToList();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

            Classe classe = new Classe();
            classe.libelle = comboSpec.Text + comboNiv.Text;
            classe.specialite = comboSpec.Text;
            classe.niveau = comboNiv.Text;

            context.Classe.Add(classe);
            context.SaveChanges();

            dtgClasse.DataSource = context.Classe.ToList();
            MessageBox.Show("La classe est enregristree avec Succes");

        }
    }
}
