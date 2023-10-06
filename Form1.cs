using System.Text.RegularExpressions;

namespace ift215_lab1
{
    public partial class Form1 : Form
    {
        private List<Compte> comptes;
        private int remainingTime = 5; // Temps en secondes
        private bool notification_lock = false;
        private bool emailValid = false;
        private bool mpValid = false;
        private bool codeValid = false;


        public Form1()
        {
            InitializeComponent();
            InitMyComponents();
            CreerCompte();
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

            timer_notification.Tick += timer_notification_Tick;

        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            if (emailValid && mpValid && textbox_nom.Text != "" && textbox_prenom.Text != "" || codeValid && textBox_code.Text != "")
            {
                string prenom = textbox_prenom.Text;
                string nom = textbox_nom.Text;
                string courriel = textbox_email.Text;
                string motDePasse = textbox_mp.Text;
                AbonnementItem abonnement = (AbonnementItem)comboBox_abonnement.SelectedItem;
                string resume = prenom + " " + nom + " " + courriel + " " + abonnement.Texte
               + " à " + abonnement.Valeur + "$.";
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

                remainingTime = 6;
                label_timer.Text = "00:05";
                notification_lock = false;
                timer_notification.Start();
                groupBox_notification.Visible = true;
            }
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
                emailValid = true;
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
                emailValid = false;
                /// Idem
                textbox_email.BackColor = Color.Coral;
            }
        }

        public bool IsPassewordValid(string mp)
        {

            if (!Regex.IsMatch(mp, @"^(?=.*[A-Z])"))
            {
                label_mp_maj.ForeColor = Color.DarkRed;
            }
            else
            {
                label_mp_maj.ForeColor = Color.DarkOliveGreen;
            }

            if (!Regex.IsMatch(mp, @"^(?=.*[a-z])"))
            {
                label_mp_minuscule.ForeColor = Color.DarkRed;
            }
            else
            {
                label_mp_minuscule.ForeColor = Color.DarkOliveGreen;
            }

            if (!Regex.IsMatch(mp, @"^(?=.*\d)"))
            {
                label_mp_chiffre.ForeColor = Color.DarkRed;
            }
            else
            {
                label_mp_chiffre.ForeColor = Color.DarkOliveGreen;
            }

            if (!Regex.IsMatch(mp, @"^(?=(?:[^@#$%&*;:~]*[@#$%&*;:~]){2})"))
            {
                label_mp_carac.ForeColor = Color.DarkRed;
            }
            else
            {
                label_mp_carac.ForeColor = Color.DarkOliveGreen;
            }

            if (!Regex.IsMatch(mp, @"^[A-Za-z\d@#$%&*;:~]{12,}"))
            {
                label_mp_min.ForeColor = Color.DarkRed;
            }
            else
            {
                label_mp_min.ForeColor = Color.DarkOliveGreen;
            }

            try
            {
                Regex reg = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=(?:[^@#$%&*;:~]*[@#$%&*;:~]){2})[A-Za-z\d@#$%&*;:~]{12,}$",
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
                mpValid = true;
                var compteExistant = comptes.FirstOrDefault(o => o.MotDePasse == mp);
                if (compteExistant != null)
                {
                    /// Idem
                    textbox_mp.ForeColor = Color.DarkRed;
                }
                else
                {
                    /// Idem
                    textbox_mp.ForeColor = Color.DarkOliveGreen;
                }
            }
            else
            {
                mpValid = false;
                /// Idem
                textbox_mp.ForeColor = Color.DarkRed;
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
                Prenom = "Frédéric",
                Nom = "Bergeron",
                Courriel =
           "courriel@serveur.domaine",
                MotDePasse = "asdfsdfsdf",
                Abonnement = 0
            });
        }

        private void button_mp_MouseDown(object sender, MouseEventArgs e)
        {
            // Afficher les caractères du mot de passe en définissant PasswordChar sur '\0' (null).
            textbox_mp.PasswordChar = '\0';
        }

        private void button_mp_MouseUp(object sender, MouseEventArgs e)
        {
            // Cacher à nouveau les caractères du mot de passe en rétablissant PasswordChar à '*'.
            textbox_mp.PasswordChar = '*';
        }

        private void timer_notification_Tick(object sender, EventArgs e)
        {
            if (!notification_lock)
            {
                // Mettez à jour le temps restant et affichez-le sur le Label.
                remainingTime--;

                // Vérifiez si le temps est écoulé.
                if (remainingTime <= 0)
                {
                    timer_notification.Stop();
                    label_timer.Text = "Temps écoulé";
                    groupBox_notification.Visible = false;
                }
                else
                {
                    // Affichez le temps restant au format mm:ss (minutes:secondes).
                    TimeSpan timeSpan = TimeSpan.FromSeconds(remainingTime);
                    label_timer.Text = $"{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}";
                }
            }
            else
            {
                timer_notification.Stop();
            }
        }

        private void linkLabel_code_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textBox_code.Visible)
            {
                codeValid = false;
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
            }
            else
            {
                codeValid = true;
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

        private void groupBox_notification_MouseEnter(object sender, EventArgs e)
        {
            timer_notification.Stop();
        }

        private void groupBox_notification_MouseLeave(object sender, EventArgs e)
        {
            timer_notification.Start();
        }

        private void groupBox_notification_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                notification_lock = false;
                label_timer.Visible = true;
                remainingTime = 0;
                groupBox_notification.Visible = false;
            }
        }

        private void button_notification_Click(object sender, EventArgs e)
        {
            notification_lock = false;
            label_timer.Visible = true;
            remainingTime = 0;
            groupBox_notification.Visible = false;
        }

        private void groupBox_notification_Click(object sender, EventArgs e)
        {
            notification_lock = true;
            label_timer.Visible = false;
        }
    }
}
