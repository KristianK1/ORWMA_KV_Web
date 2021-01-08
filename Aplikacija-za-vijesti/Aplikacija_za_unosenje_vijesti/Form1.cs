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
            String errors = Error_checking(name, short_des, long_des); ;

            if (errors != ""){
                MessageBox.Show(errors, "Upozorenje");
                return;
            }
            if (image_name == "") image_name = "default_image.jpg";

            String timestamp_page = "", timestamp_file_name = "";
            timestamp_get(ref timestamp_page , ref timestamp_file_name);

            //SHORT NEWS
            Short_news(name, short_des, long_des, image_name, timestamp_page);
            
            //LONG NEWS



            //String news_file_name = DateTime.Now.Year.ToString() +"_"+ DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + "_" +DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + name.Replace(" ","_") + ".html";
            //Console.WriteLine(news_file_name);

        }            














        private void Long_news(String timestamp_file_name, String name, String short_des, String long_des, String image_name, String timestamp_page) 
        {
            String header_file = Load_file("..//..//..//..//Skeletons//header_file_folder_version.html");
            
            int number;
            number = header_file.LastIndexOf("<!-- HEADER END -->");
            if (number > 0) header_file = header_file.Substring(0, number);
            header_file = header_file.Replace("<!-- TITLE TAB -->", "Vijest");
            String new_file = header_file;

            String Long_skeleton= Load_file("..//..//..//..//Skeletons//standard_news_long.html");
            number = Long_skeleton.LastIndexOf("<!--KRAJ vijesti-->");
            if (number > 0) Long_skeleton = Long_skeleton.Substring(0, number);
            Long_skeleton = Long_skeleton.Replace("<!-- INSERT NEWS TITLE -->", name);
            Long_skeleton = Long_skeleton.Replace("<!-- INSERT TIME STAMP -->", timestamp_page);
            Long_skeleton = Long_skeleton.Replace("<!-- INSERT SHORT DESCRIPTION -->", short_des);
            Long_skeleton = Long_skeleton.Replace("<!-- INSERT IMAGE NAME -->", image_name);
            Long_skeleton = Long_skeleton.Replace("<!-- INSERT LONG DESCRIPTION -->", long_des);
            new_file += Long_skeleton;

            String footer_file = Load_file("..//..//..//..//Skeletons//footer_file_folder_version.html");
            number = footer_file.LastIndexOf("<!-- FOOTER END -->");
            if (number > 0) footer_file = footer_file.Substring(0, number);
            footer_file = footer_file.Replace("<!-- TITLE TAB -->", "Vijest");
            new_file += footer_file;

            Save_file("..//..//..//..//news//"+ timestamp_file_name, new_file);

        }


        private void Short_news(String name, String short_des, String long_des, String image_name, String timestamp_page)
        {
            String path;
            path = "..//..//..//..//Skeletons//standard_news_short.html";

            String news_short = Load_file(path);

            int number;
            number = news_short.LastIndexOf("<!--KRAJ vijesti-->");
            if (number > 0) news_short = news_short.Substring(0, number);



            news_short = news_short.Replace("<!-- INSERT NEWS TITLE -->", name);
            news_short = news_short.Replace("<!-- INSERT SHORT DESCRIPTION -->", short_des);
            news_short = news_short.Replace("<!-- INSERT TIME STAMP -->", timestamp_page);
            news_short = news_short.Replace("<!-- INSERT IMAGE NAME -->", image_name);


            path = "..//..//..//..//index.html";
            String index = Load_file(path);
            int n = 7 + index.LastIndexOf("</html>");
            if (n > 7) index = index.Substring(0, n);

            news_short = "<!-- INSERT NEW NEWS -->" + news_short;
            index = index.Replace("<!-- INSERT NEW NEWS -->", news_short);
            Save_file(path, index);
        }


        private void timestamp_get(ref String Timestamp_page, ref String Timestamp_file_name)
        {
            int GGGG = DateTime.Now.Year;
            int MM = DateTime.Now.Month;
            int DD = DateTime.Now.Day;
            int sat = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            Timestamp_page = DD.ToString() + "." + MM.ToString() + "." + GGGG.ToString() + ". " + sat.ToString() + ":" + min.ToString();
            
            String MMs = MM.ToString();
            if (MM < 10)
            {
                MMs = " " + MMs;
            }

            String DDs = DD.ToString();
            if (DD < 10)
            {
                DDs = " " + DDs;
            }

            String sats= sat.ToString();
            if (sat < 10)
            {
                sats = " " + sats;
            }

            String mins = min.ToString();
            if (min < 10)
            {
                mins = " " + mins;
            }
            Timestamp_page = GGGG.ToString() + "_" + MMs+ "_" + DDs + "__ " + sats + "_" + mins;
        }


        private String Load_file(String path)
        {
            String String_file = "";

            using (FileStream fs = File.Open(path, FileMode.Open))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);


                while (fs.Read(b, 0, b.Length) > 0)
                {
                    String_file += temp.GetString(b);
                }
            }
            Console.WriteLine(String_file.Length);
            return String_file;
        }

        private void Save_file(String path, String file)
        {
            using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(file);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }


        String Error_checking(String name, String short_des, String long_des)
        {
            String errors="";
            if (name.Length == 0)
            {
                errors += "Naziv vijesti je ostao prazan\n";
            }
            else if (name.Length <= 5)
            {
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
            if (long_des.Length <= 50)
            {
                errors += "Preporučljivo je da puni tekst vijesti ima više od 50 znakova\n";
            }
            return errors;
        }
    }
}
