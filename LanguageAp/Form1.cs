using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageAp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           

        }

        private void Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Language.Text == "MALAYALAM")
            {
                ResourceManager rm = new ResourceManager("LanguageAp.resmal", Assembly.GetExecutingAssembly());
                label4.Text = rm.GetString("Welcome");
                label2.Text = rm.GetString("Address");
                label1.Text = rm.GetString("Name");
                label3.Text = rm.GetString("Language");
              
            }
            else if (Language.Text == "TAMIL")
            {
                ResourceManager rm = new ResourceManager("LanguageAp.restam", Assembly.GetExecutingAssembly());
                label4.Text = rm.GetString("Welcome");
                label2.Text = rm.GetString("Address");
                label1.Text = rm.GetString("Name");
                label3.Text = rm.GetString("Language");
               
            }

            else if (Language.Text == "ENGLISH")
            {
                label1.Text = "NAME";
                label2.Text = "ADDRESS";
                label4.Text = "WELCOME";
                label3.Text = "LANGUAGE";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResourceManager rm = new ResourceManager("LanguageAp.resmal", Assembly.GetExecutingAssembly());
            label4.Text = rm.GetString("Welcome");
            label2.Text = rm.GetString("Address");
            label1.Text = rm.GetString("Name");
            label3.Text = rm.GetString("Language");
        }
    }
}
