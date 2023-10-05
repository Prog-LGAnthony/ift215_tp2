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
            this.groupBox_abonnement = new System.Windows.Forms.GroupBox();
            this.comboBox_abonnement = new System.Windows.Forms.ComboBox();
            this.label_abonnement = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.textbox_format = new System.Windows.Forms.Label();
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
            this.groupBox_renseignements.Controls.Add(this.textbox_mp);
            this.groupBox_renseignements.Controls.Add(this.label_mp);
            this.groupBox_renseignements.Controls.Add(this.textbox_prenom);
            this.groupBox_renseignements.Controls.Add(this.label_prenom);
            this.groupBox_renseignements.Controls.Add(this.label_email);
            this.groupBox_renseignements.Controls.Add(this.textbox_nom);
            this.groupBox_renseignements.Controls.Add(this.textbox_email);
            this.groupBox_renseignements.Controls.Add(this.label_nom);
            this.groupBox_renseignements.Location = new System.Drawing.Point(228, 141);
            this.groupBox_renseignements.Name = "groupBox_renseignements";
            this.groupBox_renseignements.Size = new System.Drawing.Size(345, 161);
            this.groupBox_renseignements.TabIndex = 9;
            this.groupBox_renseignements.TabStop = false;
            this.groupBox_renseignements.Text = "Renseignements d\'authentification";
            // 
            // groupBox_abonnement
            // 
            this.groupBox_abonnement.Controls.Add(this.comboBox_abonnement);
            this.groupBox_abonnement.Controls.Add(this.label_abonnement);
            this.groupBox_abonnement.Location = new System.Drawing.Point(228, 316);
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
            this.button_submit.Location = new System.Drawing.Point(498, 394);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 11;
            this.button_submit.Text = "Soumettre";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbox_format
            // 
            this.textbox_format.AutoSize = true;
            this.textbox_format.Location = new System.Drawing.Point(653, 222);
            this.textbox_format.Name = "textbox_format";
            this.textbox_format.Size = new System.Drawing.Size(39, 15);
            this.textbox_format.TabIndex = 12;
            this.textbox_format.Text = "a@a.a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textbox_format);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.groupBox_abonnement);
            this.Controls.Add(this.groupBox_renseignements);
            this.Controls.Add(this.label_titre);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private Label textbox_format;
    }
}