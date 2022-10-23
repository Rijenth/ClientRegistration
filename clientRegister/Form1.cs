using System.Net.Mail;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace clientRegister
{
    public partial class Form1 : Form
    {
        string AppName = "MyClients";
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){}

        private void textBox2_TextChanged(object sender, EventArgs e){}

        private void checkBox1_CheckedChanged(object sender, EventArgs e){}

        private void textBox1_TextChanged(object sender, EventArgs e) {}

        private void envoyer_Click(object sender, EventArgs e)
        {
            if (nom.Text == "" | prenom.Text == "" | Email.Text == "")
            {
                MessageBox.Show(
                    "Vous devez remplir tout les champs.",
                    AppName, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                if (checkBox1.Checked | checkBox2.Checked)
                {
                    if(IsValid(Email.Text))
                    {
                        LastName = nom.Text;

                        FirstName = prenom.Text;

                        EmailAddress = Email.Text;

                        StoreInfo();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Votre adresse mail est incorrect.",
                            AppName,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Vous devez préciser une méthode de stockage des informations.",
                        AppName, 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                        );
                }
            }
        }

        public void StoreInfo()
        {
            string data = LastName + "/" + FirstName + "/" + EmailAddress;

            StoreInDatabase();


            StoreInTxtFile(data);

            Clear();
        }


        public bool IsValid(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov|fr|ru|eu)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }

        public void StoreInTxtFile(string data)
        {
            if (checkBox1.Checked)
            {
                bool success = false;
                try
                {
                    using (var file = new StreamWriter("user.txt", true))
                    {
                        file.WriteLine(data);
                    };

                    success = true;

                    checkBox1.Checked = false;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }

                if (success)
                {
                    MessageBox.Show(
                        "Les informations ont été correctement enregistrées dans le fichier texte ! Vous le trouverez à la racine du programme.",
                        AppName,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Une erreur est survenue, les données n'ont pas été enregistrées...",
                        AppName,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        public void StoreInDatabase()
        {
            if (checkBox2.Checked)
            {
                var db = new Database(FirstName, LastName, EmailAddress);
                
                var success = db.SendData();

                if (success)
                {
                    MessageBox.Show(
                        "Les informations ont été correctement enregistrées dans la base de données !",
                        AppName,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Une erreur est survenue, les données n'ont pas pu être enregistrées dans la base de données.",
                        AppName,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }

                checkBox2.Checked = false;

            }
        }

        public void Clear()
        {
            nom.Text = string.Empty;

            prenom.Text = string.Empty; 

            Email.Text = string.Empty;
        }
    }
}