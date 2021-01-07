namespace Aplikacija_za_unosenje_vijesti
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.news_title_text = new System.Windows.Forms.TextBox();
            this.short_des_text = new System.Windows.Forms.TextBox();
            this.long_des_text = new System.Windows.Forms.TextBox();
            this.image_name_text = new System.Windows.Forms.TextBox();
            this.title_label = new System.Windows.Forms.Label();
            this.news_title = new System.Windows.Forms.Label();
            this.image_name_label = new System.Windows.Forms.Label();
            this.short_des_label = new System.Windows.Forms.Label();
            this.long_des_label = new System.Windows.Forms.Label();
            this.process_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // news_title_text
            // 
            this.news_title_text.Location = new System.Drawing.Point(35, 96);
            this.news_title_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.news_title_text.Multiline = true;
            this.news_title_text.Name = "news_title_text";
            this.news_title_text.Size = new System.Drawing.Size(171, 23);
            this.news_title_text.TabIndex = 0;
            // 
            // short_des_text
            // 
            this.short_des_text.Location = new System.Drawing.Point(274, 96);
            this.short_des_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.short_des_text.Multiline = true;
            this.short_des_text.Name = "short_des_text";
            this.short_des_text.Size = new System.Drawing.Size(689, 83);
            this.short_des_text.TabIndex = 0;
            // 
            // long_des_text
            // 
            this.long_des_text.Location = new System.Drawing.Point(35, 224);
            this.long_des_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.long_des_text.Multiline = true;
            this.long_des_text.Name = "long_des_text";
            this.long_des_text.Size = new System.Drawing.Size(929, 284);
            this.long_des_text.TabIndex = 0;
            // 
            // image_name_text
            // 
            this.image_name_text.Location = new System.Drawing.Point(35, 159);
            this.image_name_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.image_name_text.Name = "image_name_text";
            this.image_name_text.Size = new System.Drawing.Size(171, 20);
            this.image_name_text.TabIndex = 0;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title_label.Location = new System.Drawing.Point(266, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(451, 47);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Aplikacija za obradu vijesti";
            // 
            // news_title
            // 
            this.news_title.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.news_title.Location = new System.Drawing.Point(31, 75);
            this.news_title.Name = "news_title";
            this.news_title.Size = new System.Drawing.Size(101, 23);
            this.news_title.TabIndex = 1;
            this.news_title.Text = "Naziv vijesti";
            // 
            // image_name_label
            // 
            this.image_name_label.AutoSize = true;
            this.image_name_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.image_name_label.Location = new System.Drawing.Point(31, 138);
            this.image_name_label.Name = "image_name_label";
            this.image_name_label.Size = new System.Drawing.Size(70, 19);
            this.image_name_label.TabIndex = 1;
            this.image_name_label.Text = "Ime slike:";
            // 
            // short_des_label
            // 
            this.short_des_label.AutoSize = true;
            this.short_des_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.short_des_label.Location = new System.Drawing.Point(270, 75);
            this.short_des_label.Name = "short_des_label";
            this.short_des_label.Size = new System.Drawing.Size(430, 19);
            this.short_des_label.TabIndex = 1;
            this.short_des_label.Text = "Kratki opis vijesti: Ovaj opis treba sadržavati najviše 256 znakova";
            // 
            // long_des_label
            // 
            this.long_des_label.AutoSize = true;
            this.long_des_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.long_des_label.Location = new System.Drawing.Point(31, 203);
            this.long_des_label.Name = "long_des_label";
            this.long_des_label.Size = new System.Drawing.Size(465, 19);
            this.long_des_label.TabIndex = 1;
            this.long_des_label.Text = "Dugački opis vijesti: Ovaj opis treba sadržavati najviše 20 000 znakova";
            // 
            // process_button
            // 
            this.process_button.Location = new System.Drawing.Point(833, 535);
            this.process_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.process_button.Name = "process_button";
            this.process_button.Size = new System.Drawing.Size(130, 39);
            this.process_button.TabIndex = 6;
            this.process_button.Text = "Generiraj stranicu";
            this.process_button.UseVisualStyleBackColor = true;
            this.process_button.Click += new System.EventHandler(this.process_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.news_title_text);
            this.Controls.Add(this.short_des_text);
            this.Controls.Add(this.long_des_text);
            this.Controls.Add(this.image_name_text);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.news_title);
            this.Controls.Add(this.image_name_label);
            this.Controls.Add(this.long_des_label);
            this.Controls.Add(this.short_des_label);
            this.Controls.Add(this.process_button);
            this.Name = "Form1";
            this.Text = "Aplikacija za obradu vijesti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

