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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 WinFormClasse = new Form2();
            WinFormClasse.Show();
        }

        private void etudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 WinFormEtudiant = new Form3();
            WinFormEtudiant.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void diagrammeEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm1 reportForm1 = new ReportForm1();
            reportForm1.Show();
        }

        private void diagrammeEtudiantAnneeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportDiagEtAn reportDiagEtAn = new ReportDiagEtAn();
            reportDiagEtAn.Show();
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportFormlisteEt reportFormlisteEt = new ReportFormlisteEt();
            reportFormlisteEt.Show();   
        }

        private void listeClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClasse formClasse = new FormClasse();  
            formClasse.Show();
        }
    }
}
