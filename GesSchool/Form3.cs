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
    public partial class Form3 : Form
    {
        Ges_schoolEntities context = new Ges_schoolEntities();

        public void Clear()
        {
            textNom.Text = "";
            textPrenom.Text = "";
            textAnnesc.Text = "";
            textMontant.Text = "";
            textCredit.Text = "";
        }

        public void Loading()
        {
            dtgEtudiant.DataSource = context.Etudiant.ToList();
            comboClasse.DataSource = context.Classe.ToList();
            comboClasse.DisplayMember = "libelle";
            comboClasse.ValueMember = "id";
        }

        private void RechercherEtudiantsParAnneeScolaire(string textAnnesc)
        {
            var etudiants = context.Etudiant.Where(etud => etud.annescolsaire == textAnnesc).ToList();
            dtgEtudiant.DataSource = etudiants;
        }
        public Form3()
        {
            InitializeComponent();
            Loading();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void valider_Click(object sender, EventArgs e)
        {
            Etudiant etud = new Etudiant();

            etud.nom = textNom.Text;
            etud.prenom = textPrenom.Text;
            etud.annescolsaire = textAnnesc.Text;
            etud.reglement = int.Parse(textMontant.Text);
            etud.credit = int.Parse(textCredit.Text);

            etud.idclasse = Convert.ToInt32(comboClasse.SelectedValue);
            context.Etudiant.Add(etud);
            context.SaveChanges();

            Clear();
            dtgEtudiant.DataSource = context.Etudiant.ToList();

            MessageBox.Show("Etudiant enregristree avec Succes");

        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (dtgEtudiant.SelectedRows.Count > 0)
            {
                int idEtMod = (int)dtgEtudiant.SelectedRows[0].Cells["id"].Value;


                Etudiant etud = context.Etudiant.Find(idEtMod);

                if (etud != null)
                {
                    etud.nom = textNom.Text;
                    etud.prenom = textPrenom.Text;
                    etud.annescolsaire = textAnnesc.Text;
                    etud.reglement = int.Parse(textMontant.Text);
                    etud.credit = int.Parse(textCredit.Text);
                    etud.idclasse = Convert.ToInt32(comboClasse.SelectedValue);

                    context.SaveChanges();

                    dtgEtudiant.DataSource = context.Etudiant.ToList();
                    MessageBox.Show("Etudiant modifié avec succès");
                    Clear();

                }
                else
                {
                    MessageBox.Show("Étudiant non trouvé");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à modifier");
            }
        }

        private void suprimer_Click(object sender, EventArgs e)
        {
            if (dtgEtudiant.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voulez-vous supprimer l'étudiant selectionné ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idSup = (int)dtgEtudiant.SelectedRows[0].Cells["id"].Value;
                    Etudiant etud = context.Etudiant.Find(idSup);

                    if (etud != null)
                    {

                        context.Etudiant.Remove(etud);
                        context.SaveChanges();
                        dtgEtudiant.DataSource = context.Etudiant.ToList();
                        MessageBox.Show("Étudiant supprimé !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à supprimer");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void research_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(search.Text))
            {
                int anneeScolaire;

                // tente de convertir le texte contenu dans le champ de recherche (search.Text) en un entier
                if (int.TryParse(search.Text, out anneeScolaire))
                {
                    RechercherEtudiantsParAnneeScolaire(anneeScolaire.ToString());
                }
                else
                {
                    MessageBox.Show("Veuillez entrer une année scolaire valide (nombre entier).");
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer une année scolaire pour effectuer la recherche.");
            }
        }

    }
}
