﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public  bool CheckInt()
        {
            bool check = true;
           
            if (!int.TryParse(x1.Text, out int value)) {
                x1. = Color.Red;
                check = false;
            }
            if (!int.TryParse(x2.Text, out int value1))
            {
                x2.BackColor = Color.Red;
                check = false;
            }
            if (!int.TryParse(y1.Text, out int value2))
            {
                y1.BackColor = Color.Red;
                check = false;
            }
            if (!int.TryParse(y2.Text, out int value3))
            {
                y2.BackColor = Color.Red;
                check = false;
            }
            return check;
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            if (CheckInt())
            {
                x1.Text = "";
             //save the form

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
        protected void x1_Validate(object source, ServerValidateEventArgs e)
        {
            if (true)
            {
                e.IsValid = false;
            }
            else
            {
                e.IsValid = true;
            }
        }
    }
}
