using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Calcul_Moyenne
{

    public partial class CalculMoyenne : Form
    {

        public CalculMoyenne()
        {
            InitializeComponent();




        }

       

            private void txt_Moyenne_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void txt_NomPrenom_TextChanged(object sender, EventArgs e)
        {
            if (txt_NomPrenom.Text.Trim() == "" || string.IsNullOrEmpty(txt_NoteDS.Text) || string.IsNullOrEmpty(txt_NoteTP.Text) || string.IsNullOrEmpty(txt_NoteExamen.Text) || string.IsNullOrEmpty(txt_Coef.Text))

                btn_Calculer.Enabled = false;

            else

                btn_Calculer.Enabled = true;
        }

        private void txt_NoteDS_TextChanged(object sender, EventArgs e)
        {
            if (txt_NomPrenom.Text.Trim() == "" || string.IsNullOrEmpty(txt_NoteDS.Text) || string.IsNullOrEmpty(txt_NoteTP.Text) || string.IsNullOrEmpty(txt_NoteExamen.Text) || string.IsNullOrEmpty(txt_Coef.Text))

                btn_Calculer.Enabled = false;

            else

                btn_Calculer.Enabled = true;
        }

        private void txt_NoteTP_TextChanged(object sender, EventArgs e)
        {
            if (txt_NomPrenom.Text.Trim() == "" || string.IsNullOrEmpty(txt_NoteDS.Text) || string.IsNullOrEmpty(txt_NoteTP.Text) || string.IsNullOrEmpty(txt_NoteExamen.Text) || string.IsNullOrEmpty(txt_Coef.Text))

                btn_Calculer.Enabled = false;

            else

                btn_Calculer.Enabled = true;
        }

        private void txt_NoteExamen_TextChanged(object sender, EventArgs e)
        {
            if (txt_NomPrenom.Text.Trim() == "" || string.IsNullOrEmpty(txt_NoteDS.Text) || string.IsNullOrEmpty(txt_NoteTP.Text) || string.IsNullOrEmpty(txt_NoteExamen.Text) || string.IsNullOrEmpty(txt_Coef.Text))

                btn_Calculer.Enabled = false;

            else

                btn_Calculer.Enabled = true;
        }

        private void txt_Coef_TextChanged(object sender, EventArgs e)
        {
            
            if (txt_NomPrenom.Text.Trim()=="" || string.IsNullOrEmpty(txt_NoteDS.Text) || string.IsNullOrEmpty(txt_NoteTP.Text) || string.IsNullOrEmpty(txt_NoteExamen.Text) || string.IsNullOrEmpty(txt_Coef.Text))

                btn_Calculer.Enabled = false;

            else

                btn_Calculer.Enabled = true;

        }


        private void btn_Calculer_Click(object sender, EventArgs e)
        {
           
            
            double noteDs;
            double noteTP;
            double noteExamen;

            noteDs = double.Parse(txt_NoteDS.Text);
            noteTP = double.Parse(txt_NoteTP.Text);
            noteExamen = double.Parse(txt_NoteExamen.Text);

            double moyenne = ((noteDs * 0.3) + (noteTP * 0.2) + (noteExamen * 0.5));
            txt_Moyenne.Enabled = true;
            txt_Moyenne.Text = moyenne.ToString();
            btn_Ajouter.Enabled = true;
            btn_Calculer.Enabled = false;


        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            
            lst_Moyenne.MultiColumn = true;
            lst_Moyenne.Items.Add( txt_NomPrenom.Text.Trim()+"         |          "+ txt_Moyenne.Text.Trim());
            txt_NomPrenom.Text = null;
            txt_NoteDS.Text = null;
            txt_NoteTP.Text = null;
            txt_NoteExamen.Text = null;
            txt_Moyenne.Text = null;
            txt_Coef.Text = null;
            txt_Moyenne.Enabled = false;
            btn_Ajouter.Enabled = false;
            btn_Calculer.Enabled = false;


        }

        private void lst_Moyenne_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Supprimer.Enabled = true;
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            lst_Moyenne.Items.Remove(lst_Moyenne.SelectedItem);
            btn_Supprimer.Enabled = false;

        }

        private void txt_NoteDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_NoteTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_NoteExamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_Coef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
