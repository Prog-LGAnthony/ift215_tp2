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
            this.label_titre = new System.Windows.Forms.Label();
            this.textbox_prenom = new System.Windows.Forms.TextBox();
            this.label_prenom = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.textbox_nom = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textbox_email = new System.Windows.Forms.TextBox();
            this.label_mp = new System.Windows.Forms.Label();
            this.textbox_mp = new System.Windows.Forms.TextBox();
            this.groupBox_renseignements = new System.Windows.Forms.GroupBox();
            this.label_code = new System.Windows.Forms.Label();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.button_mp = new System.Windows.Forms.Button();
            this.label_mp_min = new System.Windows.Forms.Label();
            this.label_mp_maj = new System.Windows.Forms.Label();
            this.label_mp_carac = new System.Windows.Forms.Label();
            this.label_mp_minuscule = new System.Windows.Forms.Label();
            this.label_mp_chiffre = new System.Windows.Forms.Label();
            this.groupBox_abonnement = new System.Windows.Forms.GroupBox();
            this.comboBox_abonnement = new System.Windows.Forms.ComboBox();
            this.label_abonnement = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.linkLabel_code = new System.Windows.Forms.LinkLabel();
            this.groupBox_renseignements.SuspendLayout();
            this.groupBox_abonnement.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_titre
            // 
            this.label_titre.AutoSize = true;
            this.label_titre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_titre.Location = new System.Drawing.Point(228, 75);
            this.label_titre.Name = "label_titre";
            this.label_titre.Size = new System.Drawing.Size(354, 32);
            this.label_titre.TabIndex = 0;
            this.label_titre.Text = "Création d’un nouveau compte ";
            // 
            // textbox_prenom
            // 
            this.textbox_prenom.Location = new System.Drawing.Point(171, 27);
            this.textbox_prenom.Name = "textbox_prenom";
            this.textbox_prenom.Size = new System.Drawing.Size(100, 23);
            this.textbox_prenom.TabIndex = 1;
            // 
            // label_prenom
            // 
            this.label_prenom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_prenom.AutoSize = true;
            this.label_prenom.Location = new System.Drawing.Point(108, 30);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(49, 15);
            this.label_prenom.TabIndex = 2;
            this.label_prenom.Text = "Prénom";
            // 
            // label_nom
            // 
            this.label_nom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(123, 59);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(34, 15);
            this.label_nom.TabIndex = 4;
            this.label_nom.Text = "Nom";
            // 
            // textbox_nom
            // 
            this.textbox_nom.Location = new System.Drawing.Point(171, 56);
            this.textbox_nom.Name = "textbox_nom";
            this.textbox_nom.Size = new System.Drawing.Size(100, 23);
            this.textbox_nom.TabIndex = 3;
            // 
            // label_email
            // 
            this.label_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(66, 88);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(91, 15);
            this.label_email.TabIndex = 6;
            this.label_email.Text = "Adresse courriel";
            // 
            // textbox_email
            // 
            this.textbox_email.Location = new System.Drawing.Point(171, 85);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(100, 23);
            this.textbox_email.TabIndex = 5;
            // 
            // label_mp
            // 
            this.label_mp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_mp.AutoSize = true;
            this.label_mp.Location = new System.Drawing.Point(80, 117);
            this.label_mp.Name = "label_mp";
            this.label_mp.Size = new System.Drawing.Size(77, 15);
            this.label_mp.TabIndex = 8;
            this.label_mp.Text = "Mot de passe";
            // 
            // textbox_mp
            // 
            this.textbox_mp.Location = new System.Drawing.Point(171, 114);
            this.textbox_mp.Name = "textbox_mp";
            this.textbox_mp.PasswordChar = '*';
            this.textbox_mp.Size = new System.Drawing.Size(100, 23);
            this.textbox_mp.TabIndex = 7;
            // 
            // groupBox_renseignements
            // 
            this.groupBox_renseignements.Controls.Add(this.linkLabel_code);
            this.groupBox_renseignements.Controls.Add(this.label_code);
            this.groupBox_renseignements.Controls.Add(this.textBox_code);
            this.groupBox_renseignements.Controls.Add(this.button_mp);
            this.groupBox_renseignements.Controls.Add(this.label_mp_min);
            this.groupBox_renseignements.Controls.Add(this.label_mp_maj);
            this.groupBox_renseignements.Controls.Add(this.textbox_mp);
            this.groupBox_renseignements.Controls.Add(this.label_mp_carac);
            this.groupBox_renseignements.Controls.Add(this.label_mp_minuscule);
            this.groupBox_renseignements.Controls.Add(this.label_mp_chiffre);
            this.groupBox_renseignements.Controls.Add(this.label_mp);
            this.groupBox_renseignements.Controls.Add(this.textbox_prenom);
            this.groupBox_renseignements.Controls.Add(this.label_prenom);
            this.groupBox_renseignements.Controls.Add(this.label_email);
            this.groupBox_renseignements.Controls.Add(this.textbox_nom);
            this.groupBox_renseignements.Controls.Add(this.textbox_email);
            this.groupBox_renseignements.Controls.Add(this.label_nom);
            this.groupBox_renseignements.Location = new System.Drawing.Point(228, 119);
            this.groupBox_renseignements.Name = "groupBox_renseignements";
            this.groupBox_renseignements.Size = new System.Drawing.Size(345, 169);
            this.groupBox_renseignements.TabIndex = 9;
            this.groupBox_renseignements.TabStop = false;
            this.groupBox_renseignements.Text = "Renseignements d\'authentification";
            // 
            // label_code
            // 
            this.label_code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_code.AutoSize = true;
            this.label_code.Location = new System.Drawing.Point(51, 88);
            this.label_code.Name = "label_code";
            this.label_code.Size = new System.Drawing.Size(106, 15);
            this.label_code.TabIndex = 18;
            this.label_code.Text = "Code de validation";
            this.label_code.Visible = false;
            // 
            // textBox_code
            // 
            this.textBox_code.Location = new System.Drawing.Point(171, 85);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(100, 23);
            this.textBox_code.TabIndex = 13;
            this.textBox_code.Visible = false;
            // 
            // button_mp
            // 
            this.button_mp.Location = new System.Drawing.Point(271, 114);
            this.button_mp.Name = "button_mp";
            this.button_mp.Size = new System.Drawing.Size(38, 23);
            this.button_mp.TabIndex = 13;
            this.button_mp.Text = "Voir";
            this.button_mp.UseVisualStyleBackColor = true;
            this.button_mp.Click += new System.EventHandler(this.button_mp_Click);
            this.button_mp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_mp_MouseDown);
            this.button_mp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_mp_MouseUp);
            // 
            // label_mp_min
            // 
            this.label_mp_min.AutoSize = true;
            this.label_mp_min.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_mp_min.Location = new System.Drawing.Point(233, 149);
            this.label_mp_min.Name = "label_mp_min";
            this.label_mp_min.Size = new System.Drawing.Size(81, 13);
            this.label_mp_min.TabIndex = 17;
            this.label_mp_min.Text = "minimum de 12";
            this.label_mp_min.Click += new System.EventHandler(this.label_mp_min_Click);
            // 
            // label_mp_maj
            // 
            this.label_mp_maj.AutoSize = true;
            this.label_mp_maj.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_mp_maj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_mp_maj.Location = new System.Drawing.Point(55, 137);
            this.label_mp_maj.Name = "label_mp_maj";
            this.label_mp_maj.Size = new System.Drawing.Size(56, 13);
            this.label_mp_maj.TabIndex = 13;
            this.label_mp_maj.Text = "Majuscule,";
            this.label_mp_maj.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label_mp_carac
            // 
            this.label_mp_carac.AutoSize = true;
            this.label_mp_carac.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_mp_carac.Location = new System.Drawing.Point(55, 149);
            this.label_mp_carac.Name = "label_mp_carac";
            this.label_mp_carac.Size = new System.Drawing.Size(181, 13);
            this.label_mp_carac.TabIndex = 16;
            this.label_mp_carac.Text = "deux caractères (@, #, $, %, &, *, ;, :, ~),";
            this.label_mp_carac.Click += new System.EventHandler(this.label_mp_carac_Click);
            // 
            // label_mp_minuscule
            // 
            this.label_mp_minuscule.AutoSize = true;
            this.label_mp_minuscule.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_mp_minuscule.Location = new System.Drawing.Point(108, 137);
            this.label_mp_minuscule.Name = "label_mp_minuscule";
            this.label_mp_minuscule.Size = new System.Drawing.Size(56, 13);
            this.label_mp_minuscule.TabIndex = 14;
            this.label_mp_minuscule.Text = "minuscule,";
            this.label_mp_minuscule.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // label_mp_chiffre
            // 
            this.label_mp_chiffre.AutoSize = true;
            this.label_mp_chiffre.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_mp_chiffre.Location = new System.Drawing.Point(161, 137);
            this.label_mp_chiffre.Name = "label_mp_chiffre";
            this.label_mp_chiffre.Size = new System.Drawing.Size(38, 13);
            this.label_mp_chiffre.TabIndex = 15;
            this.label_mp_chiffre.Text = "chiffre,";
            this.label_mp_chiffre.Click += new System.EventHandler(this.label_mp_chiffre_Click);
            // 
            // groupBox_abonnement
            // 
            this.groupBox_abonnement.Controls.Add(this.comboBox_abonnement);
            this.groupBox_abonnement.Controls.Add(this.label_abonnement);
            this.groupBox_abonnement.Location = new System.Drawing.Point(228, 294);
            this.groupBox_abonnement.Name = "groupBox_abonnement";
            this.groupBox_abonnement.Size = new System.Drawing.Size(345, 63);
            this.groupBox_abonnement.TabIndex = 10;
            this.groupBox_abonnement.TabStop = false;
            this.groupBox_abonnement.Text = "Abonnement";
            // 
            // comboBox_abonnement
            // 
            this.comboBox_abonnement.FormattingEnabled = true;
            this.comboBox_abonnement.Location = new System.Drawing.Point(171, 22);
            this.comboBox_abonnement.Name = "comboBox_abonnement";
            this.comboBox_abonnement.Size = new System.Drawing.Size(100, 23);
            this.comboBox_abonnement.TabIndex = 11;
            // 
            // label_abonnement
            // 
            this.label_abonnement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_abonnement.AutoSize = true;
            this.label_abonnement.Location = new System.Drawing.Point(55, 25);
            this.label_abonnement.Name = "label_abonnement";
            this.label_abonnement.Size = new System.Drawing.Size(102, 15);
            this.label_abonnement.TabIndex = 10;
            this.label_abonnement.Text = "Type abonnement";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(498, 363);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 11;
            this.button_submit.Text = "Soumettre";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // linkLabel_code
            // 
            this.linkLabel_code.AutoSize = true;
            this.linkLabel_code.Location = new System.Drawing.Point(224, 0);
            this.linkLabel_code.Name = "linkLabel_code";
            this.linkLabel_code.Size = new System.Drawing.Size(114, 15);
            this.linkLabel_code.TabIndex = 12;
            this.linkLabel_code.TabStop = true;
            this.linkLabel_code.Text = "Code de validation ?";
            this.linkLabel_code.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_code_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.groupBox_abonnement);
            this.Controls.Add(this.groupBox_renseignements);
            this.Controls.Add(this.label_titre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox_renseignements.ResumeLayout(false);
            this.groupBox_renseignements.PerformLayout();
            this.groupBox_abonnement.ResumeLayout(false);
            this.groupBox_abonnement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}