namespace mana_un_tava_veseliba
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EdienaIZV = new System.Windows.Forms.ComboBox();
            this.Kalorijas = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UdensD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(104, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ēdienreizes veids";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(68, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Uzņemto kaloriju daudzums";
            // 
            // EdienaIZV
            // 
            this.EdienaIZV.FormattingEnabled = true;
            this.EdienaIZV.Items.AddRange(new object[] {
            "Brokastis",
            "Otrās brokastis",
            "Pusdienas",
            "Launags",
            "Vakariņas",
            "Vēlās vakariņas",
            "Uzkoda",
            "Ūdens"});
            this.EdienaIZV.Location = new System.Drawing.Point(109, 50);
            this.EdienaIZV.Name = "EdienaIZV";
            this.EdienaIZV.Size = new System.Drawing.Size(177, 21);
            this.EdienaIZV.TabIndex = 13;
            // 
            // Kalorijas
            // 
            this.Kalorijas.Location = new System.Drawing.Point(109, 114);
            this.Kalorijas.Name = "Kalorijas";
            this.Kalorijas.Size = new System.Drawing.Size(177, 20);
            this.Kalorijas.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button1.Location = new System.Drawing.Point(82, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ievadīt ēdienreizi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(68, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "Uzņemtais ūdens daudzums";
            // 
            // UdensD
            // 
            this.UdensD.Location = new System.Drawing.Point(109, 190);
            this.UdensD.Name = "UdensD";
            this.UdensD.Size = new System.Drawing.Size(177, 20);
            this.UdensD.TabIndex = 17;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(417, 291);
            this.Controls.Add(this.UdensD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Kalorijas);
            this.Controls.Add(this.EdienaIZV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.Name = "Form4";
            this.Text = "Ēdienreizes ievade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EdienaIZV;
        private System.Windows.Forms.TextBox Kalorijas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UdensD;
    }
}