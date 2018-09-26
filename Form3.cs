//Student 20140842
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Starcluckslogin : Form                       // Name of this form.
    {
        starclucks firstForm;                                         // Declares name of the linking form.

        public Starcluckslogin()
        {
            InitializeComponent();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            if (loginTXT.Text == "")
            {
                MessageBox.Show("You have not entered your log on details!");
            }

            else
            {
            firstForm.passname = loginTXT.Text;                       // Links the two forms together allowing the ID number to be displayed in form 1.
            firstForm.Show();                                         // This command hides the log in form and transfers the user to the starclucks form.
            this.Hide();
            }                            
        }

        private void Starcluckslogin_Load(object sender, EventArgs e)
        {
            firstForm = new starclucks();                              // Allows the user to access the starclucks form once the log in button has been selected.
        }

             
    }
}
