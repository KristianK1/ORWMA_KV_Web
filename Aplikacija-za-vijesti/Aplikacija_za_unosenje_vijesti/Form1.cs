using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            String name = news_title_text.Text;
            String short_des = short_des_text.Text;
            String long_des = long_des_text.Text;
            String image_name = image_name_text.Text;
            String errors = "";


            if (name.Length == 0) {
                errors += "Naziv vijesti je ostao prazan\n";
            }
            else if (name.Length <= 5) {
                errors += "Preporučljivo je da naslov vijesti ima više od 5 znakova\n";
            }

            if (short_des.Length > 256)
            {
                errors += "Kratki opis ima previše znakova.\n";
            }
            if (long_des.Length <= 20)
            {
                errors += "Preporučljivo je da kratki tekst vijesti ima više od 20 znakova\n";
            }
            if (long_des.Length > 20000)
            {
                errors += "Puni opis ima previše znakova.\n";
            }
            if (long_des.Length <= 50) {
                errors += "Preporučljivo je da puni tekst vijesti ima više od 50 znakova\n";
            }

            if (image_name == "")
            {
                image_name = "default_image.jpg";
            }

            if (errors != "")
            {
                MessageBox.Show(errors, "Upozorenje");
                return;
            }
            //vrijeme


            String path;
            path = "..//..//..//..//Skeletons//standard_news_short.html";
            String news_short = Load_file(path);

            String timestamp = timestamp_get();
            news_short=news_short.Replace("<!-- INSERT NEWS TITLE -->", name);
            news_short = news_short.Replace("<!-- INSERT SHORT DESCRIPTION -->", short_des);
            news_short = news_short.Replace("<!-- INSERT TIME STAMP -->", timestamp);
            news_short = news_short.Replace("<!-- INSERT IMAGE NAME -->", image_name);
            Console.WriteLine(news_short);
            path = "..//..//..//..//index.html";
            String index = Load_file(path);
            news_short = "< !--INSERT NEW NEWS -->" + news_short;
            index=index.Replace("<!-- INSERT NEW NEWS -->", news_short);

            Console.WriteLine(index);
        }

        String timestamp_get()
        {
            int GGGG = DateTime.Now.Year;
            int MM = DateTime.Now.Month;
            int DD = DateTime.Now.Day;
            int sat = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            String timestamp = DD.ToString() + "." + MM.ToString() + "." + GGGG.ToString() + ". " + sat.ToString() + ":" + min.ToString();
            return timestamp;
        }


        private String Load_file(String path)
        {
            String String_file = "";
            //MessageBox.Show(path, "Upozorenje");
            /*using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }*/

            // Open the stream and read it back.
            using (FileStream fs = File.Open(path, FileMode.Open))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);


                while (fs.Read(b, 0, b.Length) > 0)
                {
                    String_file += temp.GetString(b);
                }
                //MessageBox.Show(String_file, "Upozorenje");
            }
            return String_file;
        }

        private String Save_file(String path, String file)
        {
            MessageBox.Show(path, "Upozorenje");
            using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(file);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }

            // Open the stream and read it back.
            /*using (FileStream fs = File.Open(path, FileMode.Open))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);


                while (fs.Read(b, 0, b.Length) > 0)
                {
                    String_file += temp.GetString(b);
                }
                //MessageBox.Show(String_file, "Upozorenje");
            }
            return String_file;*/
        }
    }
}
