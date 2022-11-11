using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EquationSolver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public ClasseForValues CheckInt()
        {
            // VARIABLES 
            bool check = true;
            string message = "Veuillez entrer des chiffres dans les champs !";
            string title = "Erreur !";
            var result = new ClasseForValues();

            // ON CHECK SI LE TEXTE EST UN NOMBRE, SI NON, ON MET UN EFFET ROUGE ET ON OUVRE LA MESSAGEBOX
            if (!int.TryParse(x1.Text, out int value1))
            {
                result.Value1 = value1;
                x1.BackColor = Color.Red;
                check = false;
                MessageBox.Show(message, title);
            }

            else if (!int.TryParse(x2.Text, out int value2))
            {
                result.Value2 = value2;
                x2.BackColor = Color.Red;
                check = false;
                MessageBox.Show(message, title);
            }

            else if(!int.TryParse(y1.Text, out int value3))
            {
                result.Value3 = value3;
                y1.BackColor = Color.Red;
                check = false;
                MessageBox.Show(message, title);
            }

            else if(!int.TryParse(y2.Text, out int value4))
            {
                result.Value4 = value4;
                y2.BackColor = Color.Red;
                check = false;
                MessageBox.Show(message, title);
            }

            else if (!int.TryParse(a1.Text, out int value5))
            {
                result.Value5 = value5;
                a1.BackColor = Color.Red;
                check = false;
                MessageBox.Show(message, title);
            }

            else if (!int.TryParse(a2.Text, out int value6))
            {
                result.Value6 = value6;
                a2.BackColor = Color.Red;
                check = false;
                MessageBox.Show(message, title);
            }
            return result;
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            var monCheck = CheckInt();

                int xcalc1 = monCheck.Value1;
                int xcalc2 = monCheck.Value2;
                int ycalc1 = monCheck.Value3;
                int ycalc2 = monCheck.Value4;
                int ans1 = monCheck.Value5;
                int ans2 = monCheck.Value6;

                int calculX = (ans1 * ycalc2 - ans2 * ycalc1) / (xcalc1 * ycalc2 - xcalc2 * ycalc1);
                int calculY = (xcalc1 * xcalc2 - xcalc2 * ans1) / (xcalc1 * ycalc2 - xcalc2 * ycalc1);

                answer.Text = "X =" + calculX + "\n  Y=" + calculY ;
            
        }

        private void nsGroupBox3_Click(object sender, EventArgs e)
        {

        }

        private void nsTheme1_Click(object sender, EventArgs e)
        {

        }

        private void nsGroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void x1_TextChanged(object sender, EventArgs e)
        {
      

        }

        private void y1_TextChanged(object sender, EventArgs e)
        {

        }

        private void a1_TextChanged(object sender, EventArgs e)
        {

        }

        private void x2_TextChanged(object sender, EventArgs e)
        {

        }

        private void y2_TextChanged(object sender, EventArgs e)
        {

        }

        private void a2_TextChanged(object sender, EventArgs e)
        {

        }

        private void answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void github_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/SeenKid/EquationSolver");
        }
    }
}
