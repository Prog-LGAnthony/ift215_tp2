namespace ift215_lab1
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
            components = new System.ComponentModel.Container();
            label_titre = new Label();
            textbox_prenom = new TextBox();
            label_prenom = new Label();
            label_nom = new Label();
            textbox_nom = new TextBox();
            label_email = new Label();
            textbox_email = new TextBox();
            label_mp = new Label();
            textbox_mp = new TextBox();
            groupBox_renseignements = new GroupBox();
            linkLabel_code = new LinkLabel();
            label_code = new Label();
            textBox_code = new TextBox();
            button_mp = new Button();
            label_mp_min = new Label();
            label_mp_maj = new Label();
            label_mp_carac = new Label();
            label_mp_minuscule = new Label();
            label_mp_chiffre = new Label();
            groupBox_abonnement = new GroupBox();
            comboBox_abonnement = new ComboBox();
            label_abonnement = new Label();
            button_submit = new Button();
            timer_notification = new System.Windows.Forms.Timer(components);
            label_timer = new Label();
            groupBox_notification = new GroupBox();
            label_notification_text = new Label();
            button_notification = new Button();
            groupBox_renseignements.SuspendLayout();
            groupBox_abonnement.SuspendLayout();
            groupBox_notification.SuspendLayout();
            SuspendLayout();
            // 
            // label_titre
            // 
            label_titre.AutoSize = true;
            label_titre.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_titre.Location = new Point(261, 100);
            label_titre.Name = "label_titre";
            label_titre.Size = new Size(437, 41);
            label_titre.TabIndex = 0;
            label_titre.Text = "Création d’un nouveau compte ";
            // 
            // textbox_prenom
            // 
            textbox_prenom.Location = new Point(195, 36);
            textbox_prenom.Margin = new Padding(3, 4, 3, 4);
            textbox_prenom.Name = "textbox_prenom";
            textbox_prenom.Size = new Size(114, 27);
            textbox_prenom.TabIndex = 1;
            // 
            // label_prenom
            // 
            label_prenom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_prenom.AutoSize = true;
            label_prenom.Location = new Point(123, 40);
            label_prenom.Name = "label_prenom";
            label_prenom.Size = new Size(60, 20);
            label_prenom.TabIndex = 2;
            label_prenom.Text = "Prénom";
            // 
            // label_nom
            // 
            label_nom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_nom.AutoSize = true;
            label_nom.Location = new Point(141, 79);
            label_nom.Name = "label_nom";
            label_nom.Size = new Size(42, 20);
            label_nom.TabIndex = 4;
            label_nom.Text = "Nom";
            // 
            // textbox_nom
            // 
            textbox_nom.Location = new Point(195, 75);
            textbox_nom.Margin = new Padding(3, 4, 3, 4);
            textbox_nom.Name = "textbox_nom";
            textbox_nom.Size = new Size(114, 27);
            textbox_nom.TabIndex = 3;
            // 
            // label_email
            // 
            label_email.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_email.AutoSize = true;
            label_email.Location = new Point(75, 117);
            label_email.Name = "label_email";
            label_email.Size = new Size(115, 20);
            label_email.TabIndex = 6;
            label_email.Text = "Adresse courriel";
            // 
            // textbox_email
            // 
            textbox_email.Location = new Point(195, 113);
            textbox_email.Margin = new Padding(3, 4, 3, 4);
            textbox_email.Name = "textbox_email";
            textbox_email.Size = new Size(114, 27);
            textbox_email.TabIndex = 5;
            // 
            // label_mp
            // 
            label_mp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_mp.AutoSize = true;
            label_mp.Location = new Point(91, 156);
            label_mp.Name = "label_mp";
            label_mp.Size = new Size(98, 20);
            label_mp.TabIndex = 8;
            label_mp.Text = "Mot de passe";
            // 
            // textbox_mp
            // 
            textbox_mp.Location = new Point(195, 152);
            textbox_mp.Margin = new Padding(3, 4, 3, 4);
            textbox_mp.Name = "textbox_mp";
            textbox_mp.PasswordChar = '*';
            textbox_mp.Size = new Size(114, 27);
            textbox_mp.TabIndex = 7;
            // 
            // groupBox_renseignements
            // 
            groupBox_renseignements.Controls.Add(linkLabel_code);
            groupBox_renseignements.Controls.Add(label_code);
            groupBox_renseignements.Controls.Add(textBox_code);
            groupBox_renseignements.Controls.Add(button_mp);
            groupBox_renseignements.Controls.Add(label_mp_min);
            groupBox_renseignements.Controls.Add(label_mp_maj);
            groupBox_renseignements.Controls.Add(textbox_mp);
            groupBox_renseignements.Controls.Add(label_mp_carac);
            groupBox_renseignements.Controls.Add(label_mp_minuscule);
            groupBox_renseignements.Controls.Add(label_mp_chiffre);
            groupBox_renseignements.Controls.Add(label_mp);
            groupBox_renseignements.Controls.Add(textbox_prenom);
            groupBox_renseignements.Controls.Add(label_prenom);
            groupBox_renseignements.Controls.Add(label_email);
            groupBox_renseignements.Controls.Add(textbox_nom);
            groupBox_renseignements.Controls.Add(textbox_email);
            groupBox_renseignements.Controls.Add(label_nom);
            groupBox_renseignements.Location = new Point(261, 159);
            groupBox_renseignements.Margin = new Padding(3, 4, 3, 4);
            groupBox_renseignements.Name = "groupBox_renseignements";
            groupBox_renseignements.Padding = new Padding(3, 4, 3, 4);
            groupBox_renseignements.Size = new Size(394, 225);
            groupBox_renseignements.TabIndex = 9;
            groupBox_renseignements.TabStop = false;
            groupBox_renseignements.Text = "Renseignements d'authentification";
            // 
            // linkLabel_code
            // 
            linkLabel_code.AutoSize = true;
            linkLabel_code.Location = new Point(254, 0);
            linkLabel_code.Name = "linkLabel_code";
            linkLabel_code.Size = new Size(146, 20);
            linkLabel_code.TabIndex = 12;
            linkLabel_code.TabStop = true;
            linkLabel_code.Text = "Code de validation ?";
            linkLabel_code.LinkClicked += linkLabel_code_LinkClicked;
            // 
            // label_code
            // 
            label_code.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_code.AutoSize = true;
            label_code.Location = new Point(58, 117);
            label_code.Name = "label_code";
            label_code.Size = new Size(135, 20);
            label_code.TabIndex = 18;
            label_code.Text = "Code de validation";
            label_code.Visible = false;
            // 
            // textBox_code
            // 
            textBox_code.Location = new Point(195, 113);
            textBox_code.Margin = new Padding(3, 4, 3, 4);
            textBox_code.Name = "textBox_code";
            textBox_code.Size = new Size(114, 27);
            textBox_code.TabIndex = 13;
            textBox_code.Visible = false;
            // 
            // button_mp
            // 
            button_mp.Location = new Point(310, 152);
            button_mp.Margin = new Padding(3, 4, 3, 4);
            button_mp.Name = "button_mp";
            button_mp.Size = new Size(43, 31);
            button_mp.TabIndex = 13;
            button_mp.Text = "Voir";
            button_mp.UseVisualStyleBackColor = true;
            button_mp.MouseDown += button_mp_MouseDown;
            button_mp.MouseUp += button_mp_MouseUp;
            // 
            // label_mp_min
            // 
            label_mp_min.AutoSize = true;
            label_mp_min.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label_mp_min.Location = new Point(264, 199);
            label_mp_min.Name = "label_mp_min";
            label_mp_min.Size = new Size(108, 19);
            label_mp_min.TabIndex = 17;
            label_mp_min.Text = "minimum de 12";
            // 
            // label_mp_maj
            // 
            label_mp_maj.AutoSize = true;
            label_mp_maj.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label_mp_maj.ForeColor = SystemColors.ControlText;
            label_mp_maj.Location = new Point(52, 183);
            label_mp_maj.Name = "label_mp_maj";
            label_mp_maj.Size = new Size(73, 19);
            label_mp_maj.TabIndex = 13;
            label_mp_maj.Text = "Majuscule,";
            // 
            // label_mp_carac
            // 
            label_mp_carac.AutoSize = true;
            label_mp_carac.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label_mp_carac.Location = new Point(51, 199);
            label_mp_carac.Name = "label_mp_carac";
            label_mp_carac.Size = new Size(239, 19);
            label_mp_carac.TabIndex = 16;
            label_mp_carac.Text = "deux caractères (@, #, $, %, &, *, ;, :, ~),";
            // 
            // label_mp_minuscule
            // 
            label_mp_minuscule.AutoSize = true;
            label_mp_minuscule.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label_mp_minuscule.Location = new Point(120, 183);
            label_mp_minuscule.Name = "label_mp_minuscule";
            label_mp_minuscule.Size = new Size(75, 19);
            label_mp_minuscule.TabIndex = 14;
            label_mp_minuscule.Text = "minuscule,";
            // 
            // label_mp_chiffre
            // 
            label_mp_chiffre.AutoSize = true;
            label_mp_chiffre.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label_mp_chiffre.Location = new Point(191, 183);
            label_mp_chiffre.Name = "label_mp_chiffre";
            label_mp_chiffre.Size = new Size(50, 19);
            label_mp_chiffre.TabIndex = 15;
            label_mp_chiffre.Text = "chiffre,";
            // 
            // groupBox_abonnement
            // 
            groupBox_abonnement.Controls.Add(comboBox_abonnement);
            groupBox_abonnement.Controls.Add(label_abonnement);
            groupBox_abonnement.Location = new Point(261, 392);
            groupBox_abonnement.Margin = new Padding(3, 4, 3, 4);
            groupBox_abonnement.Name = "groupBox_abonnement";
            groupBox_abonnement.Padding = new Padding(3, 4, 3, 4);
            groupBox_abonnement.Size = new Size(394, 84);
            groupBox_abonnement.TabIndex = 10;
            groupBox_abonnement.TabStop = false;
            groupBox_abonnement.Text = "Abonnement";
            // 
            // comboBox_abonnement
            // 
            comboBox_abonnement.FormattingEnabled = true;
            comboBox_abonnement.Location = new Point(195, 29);
            comboBox_abonnement.Margin = new Padding(3, 4, 3, 4);
            comboBox_abonnement.Name = "comboBox_abonnement";
            comboBox_abonnement.Size = new Size(114, 28);
            comboBox_abonnement.TabIndex = 11;
            // 
            // label_abonnement
            // 
            label_abonnement.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_abonnement.AutoSize = true;
            label_abonnement.Location = new Point(63, 33);
            label_abonnement.Name = "label_abonnement";
            label_abonnement.Size = new Size(128, 20);
            label_abonnement.TabIndex = 10;
            label_abonnement.Text = "Type abonnement";
            // 
            // button_submit
            // 
            button_submit.Location = new Point(569, 484);
            button_submit.Margin = new Padding(3, 4, 3, 4);
            button_submit.Name = "button_submit";
            button_submit.Size = new Size(86, 31);
            button_submit.TabIndex = 11;
            button_submit.Text = "Soumettre";
            button_submit.UseVisualStyleBackColor = true;
            button_submit.Click += button_submit_Click;
            // 
            // timer_notification
            // 
            timer_notification.Interval = 1000;
            // 
            // label_timer
            // 
            label_timer.AutoSize = true;
            label_timer.Location = new Point(96, 117);
            label_timer.Name = "label_timer";
            label_timer.Size = new Size(44, 20);
            label_timer.TabIndex = 12;
            label_timer.Text = "00:05";
            // 
            // groupBox_notification
            // 
            groupBox_notification.Controls.Add(label_notification_text);
            groupBox_notification.Controls.Add(button_notification);
            groupBox_notification.Controls.Add(label_timer);
            groupBox_notification.Location = new Point(732, 35);
            groupBox_notification.Margin = new Padding(3, 4, 3, 4);
            groupBox_notification.Name = "groupBox_notification";
            groupBox_notification.Padding = new Padding(3, 4, 3, 4);
            groupBox_notification.Size = new Size(229, 133);
            groupBox_notification.TabIndex = 13;
            groupBox_notification.TabStop = false;
            groupBox_notification.Text = "Notification";
            groupBox_notification.Visible = false;
            groupBox_notification.Click += groupBox_notification_Click;
            groupBox_notification.MouseDoubleClick += groupBox_notification_MouseDoubleClick;
            groupBox_notification.MouseEnter += groupBox_notification_MouseEnter;
            groupBox_notification.MouseLeave += groupBox_notification_MouseLeave;
            // 
            // label_notification_text
            // 
            label_notification_text.AutoSize = true;
            label_notification_text.Location = new Point(38, 59);
            label_notification_text.Name = "label_notification_text";
            label_notification_text.Size = new Size(168, 20);
            label_notification_text.TabIndex = 14;
            label_notification_text.Text = "Votre compte a été créé";
            // 
            // button_notification
            // 
            button_notification.Location = new Point(194, 0);
            button_notification.Margin = new Padding(3, 4, 3, 4);
            button_notification.Name = "button_notification";
            button_notification.Size = new Size(35, 31);
            button_notification.TabIndex = 13;
            button_notification.Text = "X";
            button_notification.UseVisualStyleBackColor = true;
            button_notification.Click += button_notification_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 600);
            Controls.Add(groupBox_notification);
            Controls.Add(button_submit);
            Controls.Add(groupBox_abonnement);
            Controls.Add(groupBox_renseignements);
            Controls.Add(label_titre);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox_renseignements.ResumeLayout(false);
            groupBox_renseignements.PerformLayout();
            groupBox_abonnement.ResumeLayout(false);
            groupBox_abonnement.PerformLayout();
            groupBox_notification.ResumeLayout(false);
            groupBox_notification.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_titre;
        private TextBox textbox_prenom;
        private Label label_prenom;
        private Label label_nom;
        private TextBox textbox_nom;
        private Label label_email;
        private TextBox textbox_email;
        private Label label_mp;
        private TextBox textbox_mp;
        private GroupBox groupBox_renseignements;
        private GroupBox groupBox_abonnement;
        private Label label_abonnement;
        private ComboBox comboBox_abonnement;
        private Button button_submit;
        private Label label_mp_maj;
        private Label label_mp_minuscule;
        private Label label_mp_chiffre;
        private Label label_mp_carac;
        private Label label_mp_min;
        private Button button_mp;
        private LinkLabel linkLabel_code;
        private TextBox textBox_code;
        private Label label_code;
        private System.Windows.Forms.Timer timer_notification;
        private Label label_timer;
        private GroupBox groupBox_notification;
        private Button button_notification;
        private Label label_notification_text;
    }
}