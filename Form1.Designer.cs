using System;

namespace tooted
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KategooriaBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lisa_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Kogus_txt = new System.Windows.Forms.TextBox();
            this.Toode_txt = new System.Windows.Forms.TextBox();
            this.Hind_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Pilt_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Kusta_but = new System.Windows.Forms.Button();
            this.Toode_pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toode_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 244);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // KategooriaBox1
            // 
            this.KategooriaBox1.FormattingEnabled = true;
            this.KategooriaBox1.Location = new System.Drawing.Point(135, 208);
            this.KategooriaBox1.Name = "KategooriaBox1";
            this.KategooriaBox1.Size = new System.Drawing.Size(121, 21);
            this.KategooriaBox1.TabIndex = 1;
            this.KategooriaBox1.SelectedIndexChanged += new System.EventHandler(this.KategooriaBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(0, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategooria: ";
            // 
            // Lisa_btn
            // 
            this.Lisa_btn.Location = new System.Drawing.Point(302, 61);
            this.Lisa_btn.Name = "Lisa_btn";
            this.Lisa_btn.Size = new System.Drawing.Size(75, 23);
            this.Lisa_btn.TabIndex = 3;
            this.Lisa_btn.Text = "Lisa";
            this.Lisa_btn.UseVisualStyleBackColor = true;
            this.Lisa_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(55, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hind:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(38, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Toode:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label4.Location = new System.Drawing.Point(38, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kogus:";
            // 
            // Kogus_txt
            // 
            this.Kogus_txt.Location = new System.Drawing.Point(135, 98);
            this.Kogus_txt.Name = "Kogus_txt";
            this.Kogus_txt.Size = new System.Drawing.Size(121, 20);
            this.Kogus_txt.TabIndex = 10;
            // 
            // Toode_txt
            // 
            this.Toode_txt.Location = new System.Drawing.Point(135, 132);
            this.Toode_txt.Name = "Toode_txt";
            this.Toode_txt.Size = new System.Drawing.Size(121, 20);
            this.Toode_txt.TabIndex = 11;
            // 
            // Hind_txt
            // 
            this.Hind_txt.Location = new System.Drawing.Point(135, 170);
            this.Hind_txt.Name = "Hind_txt";
            this.Hind_txt.Size = new System.Drawing.Size(121, 20);
            this.Hind_txt.TabIndex = 12;
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(135, 24);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(121, 20);
            this.id_txt.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label5.Location = new System.Drawing.Point(38, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID:";
            // 
            // Pilt_txt
            // 
            this.Pilt_txt.Location = new System.Drawing.Point(135, 61);
            this.Pilt_txt.Name = "Pilt_txt";
            this.Pilt_txt.Size = new System.Drawing.Size(121, 20);
            this.Pilt_txt.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label6.Location = new System.Drawing.Point(38, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pilt:";
            // 
            // Kusta_but
            // 
            this.Kusta_but.Location = new System.Drawing.Point(302, 21);
            this.Kusta_but.Name = "Kusta_but";
            this.Kusta_but.Size = new System.Drawing.Size(75, 23);
            this.Kusta_but.TabIndex = 17;
            this.Kusta_but.Text = "Kusta";
            this.Kusta_but.UseVisualStyleBackColor = true;
            this.Kusta_but.Click += new System.EventHandler(this.Kusta_but_Click);
            // 
            // Toode_pictureBox
            // 
            this.Toode_pictureBox.Location = new System.Drawing.Point(519, 24);
            this.Toode_pictureBox.Name = "Toode_pictureBox";
            this.Toode_pictureBox.Size = new System.Drawing.Size(240, 192);
            this.Toode_pictureBox.TabIndex = 18;
            this.Toode_pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Toode_pictureBox);
            this.Controls.Add(this.Kusta_but);
            this.Controls.Add(this.Pilt_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Hind_txt);
            this.Controls.Add(this.Toode_txt);
            this.Controls.Add(this.Kogus_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lisa_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KategooriaBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toode_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        


        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox KategooriaBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Lisa_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Kogus_txt;
        private System.Windows.Forms.TextBox Toode_txt;
        private System.Windows.Forms.TextBox Hind_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Pilt_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Kusta_but;
        private System.Windows.Forms.PictureBox Toode_pictureBox;
        private System.Windows.Forms.Button button1;
    }
}

