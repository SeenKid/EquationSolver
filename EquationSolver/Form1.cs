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
        public string ErrorMessage { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        public ClasseForValues CheckInt()
        {
            // VARIABLES 
            bool check = true;
            string message = "\n Veuillez entrer des chiffres dans les champs:";
            string title = "Erreur !";
            var result = new ClasseForValues();
            int i = 0;

            // ON CHECK SI LE TEXTE EST UN NOMBRE, SI NON, ON MET UN EFFET ROUGE ET ON OUVRE LA MESSAGEBOX
            if (!int.TryParse(x1.Text, out int value1))
            {
                x1.BackColor = Color.Red;
                i = 1;
                result.ErrorMessage += $"{message} {nameof(x1)}";
            }

            if (!int.TryParse(x2.Text, out int value2))
            {
                result.ErrorMessage += $"{message} {nameof(x2)}";
                i = 1;
                x2.BackColor = Color.Red;
            }

            if (!int.TryParse(y1.Text, out int value3))
            {
                result.ErrorMessage += $"{message} {nameof(y1)}";
                i = 1;
                y1.BackColor = Color.Red;
            }

            if (!int.TryParse(y2.Text, out int value4))
            {
                result.ErrorMessage += $"{message} {nameof(y2)}";
                i = 1;
                y2.BackColor = Color.Red;
            }

            if (!int.TryParse(a1.Text, out int value5))
            {
                result.ErrorMessage += $"{message} {nameof(a1)}";
                i = 1;
                a1.BackColor = Color.Red;
            }

            if (!int.TryParse(a2.Text, out int value6))
            {
                result.ErrorMessage += $"{message} {nameof(a2)}";
                i = 1;
                a2.BackColor = Color.Red;
            }
            result.Value1 = value1;
            result.Value2 = value2;
            result.Value3 = value3;
            result.Value4 = value4;
            result.Value5 = value5;
            result.Value6 = value6;

            if (i == 1)
            {
                MessageBox.Show(result.ErrorMessage, title);
            }

            return result;
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            var monCheck = CheckInt();
            if (monCheck.Check)
            {
                int x1a = monCheck.Value1; // X1 
                int x2a = monCheck.Value2; // X2 
                int y1a = monCheck.Value3; // Y1 
                int y2a = monCheck.Value4; // Y2 
                int ans1 = monCheck.Value5; // Ans1 
                int ans2 = monCheck.Value6; // Ans2 

                var Checker1 = (x1a * y2a - x2a * y1a);
                var Checker2 = (x1a * y2a - x2a * y1a);
                if (Checker1 == 0)
                {
                    string message = "Le calcul pour la valeur de X est impossible !";
                    string title = "Erreur !";
                    MessageBox.Show(message, title);
                    answer.Text = "Calcul impossible";

                    return;
                }

                if (Checker2 == 0)
                {
                    string message = "Le calcul pour la valeur de Y est impossible !";
                    string title = "Erreur !";
                    MessageBox.Show(message, title);
                    answer.Text = "Calcul impossible";

                    return;
                }

                int calculX = (ans1 * y2a - ans2 * y1a) / (x1a * y2a - x2a * y1a);
                int calculY = (x1a * ans2 - x2a * ans1) / (x1a * y2a - x2a * y1a);

                answer.Text = "X= " + calculX + " Y= " + calculY;
            }
            else
            {
                var message = "Une erreur imprévue à été détectée. Veuillez redémarrer l'application.";
                var title = "Erreur !";
                MessageBox.Show(message, title);
            }
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
