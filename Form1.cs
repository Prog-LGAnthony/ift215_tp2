using System.Text.RegularExpressions;

namespace ift215_lab1
{
    public partial class Form1 : Form
    {
        private List<Compte> comptes;

        public Form1()
        {
            InitializeComponent();
            InitMyComponents();
            CreerCompte();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InitMyComponents()
        {
            comboBox_abonnement.DataSource = new AbonnementItem[]
            {
                 new AbonnementItem{ID = 0, Texte = "Basique" , Valeur = 10.99},
                 new AbonnementItem{ID = 1, Texte = "Premium" , Valeur = 50.99},
                 new AbonnementItem{ID = 2, Texte = "Entraineur" , Valeur = 100.99},
            };
            comboBox_abonnement.DisplayMember = "Texte";
            comboBox_abonnement.ValueMember = "ID";

            textbox_email.TextChanged += CourrielChange;
            textbox_mp.TextChanged += MotPasseChange;

        }

        private void textbox_prenom_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string prenom = textbox_prenom.Text;
        //    string nom = textbox_nom.Text;
        //    string courriel = textbox_email.Text;
        //    /// Le champ de mots de passe sera utile pour le devoir ... mais pas ici
        //    string motDePasse = textbox_mp.Text;
        //    AbonnementItem abonnement = (AbonnementItem)comboBox_abonnement.SelectedItem;
        //    string resume = prenom + " " + nom + " " + courriel + " " +
        //     abonnement.Texte + " � " + abonnement.Valeur + "$.";
        //    MessageBox.Show(resume);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            string prenom = textbox_prenom.Text;
            string nom = textbox_nom.Text;
            string courriel = textbox_email.Text;
            string motDePasse = textbox_mp.Text;
            AbonnementItem abonnement = (AbonnementItem)comboBox_abonnement.SelectedItem;
            string resume = prenom + " " + nom + " " + courriel + " " + abonnement.Texte
           + " � " + abonnement.Valeur + "$.";
            MessageBox.Show(resume);
            Compte nouveau = new Compte
            {
                Prenom = prenom,
                Nom = nom,
                Courriel =
           courriel,
                MotDePasse = motDePasse,
                Abonnement = abonnement.ID
            };
            comptes.Add(nouveau);
        }

        public bool IsEmailAddressValid(string email)
        {
            try
            {
                Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$",
                RegexOptions.IgnoreCase);
                return (reg.IsMatch(email));
            }
            catch
            {
                return false;
            }
        }

        private void CourrielChange(object sender, EventArgs e)
        {
            /// Attention ici nous avons fait une refactorisation des noms des textboxes
            string email = textbox_email.Text;
            if (IsEmailAddressValid(email))
            {
                var compteExistant = comptes.FirstOrDefault(o => o.Courriel == email);
                if (compteExistant != null)
                {
                    /// Idem
                    textbox_email.BackColor = Color.Coral;
                }
                else
                {
                    /// Idem
                    textbox_email.BackColor = Color.Aquamarine;
                }
            }
            else
            {
                /// Idem
                textbox_email.BackColor = Color.Coral;
            }
        }

        public bool IsPassewordValid(string mp)
        {

            if (!Regex.IsMatch(mp, @"^(?=.*[A-Z])"))
            {
                label_mp_maj.ForeColor = Color.DarkRed;
            } else
            {
                label_mp_maj.ForeColor = Color.DarkOliveGreen;
            }

            if (!Regex.IsMatch(mp, @"^(?=.*[a-z])"))
            {
                label_mp_minuscule.ForeColor = Color.DarkRed;
            } else
            {
                label_mp_minuscule.ForeColor = Color.DarkOliveGreen;
            }

            if (!Regex.IsMatch(mp, @"^(?=.*\d)"))
            {
                label_mp_chiffre.ForeColor = Color.DarkRed;
            } else
            {
                label_mp_chiffre.ForeColor = Color.DarkOliveGreen;
            }

            if (!Regex.IsMatch(mp, @"^(?=(?:[^@#$%&*;:~]*[@#$%&*;:~]){2})"))
            {
                label_mp_carac.ForeColor = Color.DarkRed;
            } else
            {
                label_mp_carac.ForeColor = Color.DarkOliveGreen;
            }

            if (!Regex.IsMatch(mp, @"^[A-Za-z\d@#$%&*;:~]{12,}"))
            {
                label_mp_min.ForeColor = Color.DarkRed;
            } else
            {
                label_mp_min.ForeColor = Color.DarkOliveGreen;
            }

            try
            {
                Regex reg = new Regex(@"/^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=(?:[^@#$%&*;:~]*[@#$%&*;:~]){2})[A-Za-z\d@#$%&*;:~]{12,}$/gm",
                RegexOptions.IgnoreCase);
                return (reg.IsMatch(mp));
            }
            catch
            {
                return false;
            }
        }

        private void MotPasseChange(object sender, EventArgs e)
        {
            /// Attention ici nous avons fait une refactorisation des noms des textboxes
            string mp = textbox_mp.Text;
            if (IsPassewordValid(mp))
            {
                var compteExistant = comptes.FirstOrDefault(o => o.MotDePasse == mp);
                if (compteExistant != null)
                {
                    /// Idem
                    textbox_mp.BackColor = Color.DarkOliveGreen;
                }
                else
                {
                    /// Idem
                    textbox_mp.BackColor = Color.DarkRed;
                }
            }
            else
            {
                /// Idem
                textbox_mp.BackColor = Color.DarkOliveGreen;
            }
        }


        private void CreerCompte()
        {
            comptes = new List<Compte>();
            comptes.Add(new Compte
            {
                Prenom = "John",
                Nom = "Wick",
                Courriel =
           "donotkill@my.dog",
                MotDePasse = "asdfsdfsdf",
                Abonnement = 0
            });
            comptes.Add(new Compte
            {
                Prenom = "John",
                Nom = "Malchovick",
                Courriel =
           "being@him.com",
                MotDePasse = "asdfsdfsdf",
                Abonnement = 1
            });
            comptes.Add(new Compte
            {
                Prenom = "Fr�d�ric",
                Nom = "Bergeron",
                Courriel =
           "courriel@serveur.domaine",
                MotDePasse = "asdfsdfsdf",
                Abonnement = 0
            });
        }

        private void textbox_mp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_mp_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label_mp_chiffre_Click(object sender, EventArgs e)
        {

        }

        private void label_mp_carac_Click(object sender, EventArgs e)
        {

        }

        private void label_mp_min_Click(object sender, EventArgs e)
        {

        }

        private void button_mp_Click(object sender, EventArgs e)
        {

        }

        private void button_mp_MouseDown(object sender, MouseEventArgs e)
        {
            // Afficher les caract�res du mot de passe en d�finissant PasswordChar sur '\0' (null).
            textbox_mp.PasswordChar = '\0';
        }

        private void button_mp_MouseUp(object sender, MouseEventArgs e)
        {
            // Cacher � nouveau les caract�res du mot de passe en r�tablissant PasswordChar � '*'.
            textbox_mp.PasswordChar = '*';
        }

        private void button_submit_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void linkLabel_code_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textBox_code.Visible)
            {
                textBox_code.Visible = false;
                label_code.Visible = false;

                label_email.Visible = true;
                label_mp.Visible = true;
                textbox_email.Visible = true;
                textbox_mp.Visible = true;
                label_mp_carac.Visible = true;
                label_mp_chiffre.Visible = true;
                label_mp_maj.Visible = true;
                label_mp_minuscule.Visible = true;
                label_mp_min.Visible = true;
                button_mp.Visible = true;
            } else
            {
                textBox_code.Visible = true;
                label_code.Visible = true;

                label_email.Visible = false;
                label_mp.Visible = false;
                textbox_email.Visible = false;
                textbox_mp.Visible = false;
                label_mp_carac.Visible = false;
                label_mp_chiffre.Visible = false;
                label_mp_maj.Visible = false;
                label_mp_minuscule.Visible = false;
                label_mp_min.Visible = false;
                button_mp.Visible = false;
            }
            
        }
    }
}
