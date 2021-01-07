using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija_za_unosenje_vijesti
{
    public partial class Form1 : Form
    {

        private System.Windows.Forms.Label news_title;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label image_name_label;
        private System.Windows.Forms.Label short_des_label;
        private System.Windows.Forms.Label long_des_label;

        private System.Windows.Forms.Button process_button;

        private System.Windows.Forms.TextBox short_des_text;
        private System.Windows.Forms.TextBox long_des_text;
        private System.Windows.Forms.TextBox image_name_text;
        private System.Windows.Forms.TextBox news_title_text;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void process_button_Click(object sender, EventArgs e)
        {

        }
    }
}
