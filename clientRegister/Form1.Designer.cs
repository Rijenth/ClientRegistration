namespace clientRegister
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.envoyer = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(102, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENT - Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(38, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prenom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(58, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email :";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(131, 228);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(233, 23);
            this.Email.TabIndex = 2;
            this.Email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(131, 189);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(233, 23);
            this.prenom.TabIndex = 2;
            this.prenom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(131, 151);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(233, 23);
            this.nom.TabIndex = 2;
            // 
            // envoyer
            // 
            this.envoyer.Location = new System.Drawing.Point(144, 354);
            this.envoyer.Name = "envoyer";
            this.envoyer.Size = new System.Drawing.Size(101, 41);
            this.envoyer.TabIndex = 3;
            this.envoyer.Text = "Envoyer";
            this.envoyer.UseVisualStyleBackColor = true;
            this.envoyer.Click += new System.EventHandler(this.envoyer_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(38, 283);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(183, 19);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Enregistrer dans un fichier .txt";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(38, 308);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(184, 19);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Enregistrer en base de donnée";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.envoyer);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "MyClients";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Email;
        private TextBox prenom;
        private TextBox nom;
        private Button envoyer;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}