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
            groupBox_abonnement = new GroupBox();
            comboBox_abonnement = new ComboBox();
            label_abonnement = new Label();
            button_submit = new Button();
            textbox_format = new Label();
            groupBox_renseignements.SuspendLayout();
            groupBox_abonnement.SuspendLayout();
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
            label_mp.Click += label_mp_Click;
            // 
            // textbox_mp
            // 
            textbox_mp.Location = new Point(195, 152);
            textbox_mp.Margin = new Padding(3, 4, 3, 4);
            textbox_mp.Name = "textbox_mp";
            textbox_mp.PasswordChar = '*';
            textbox_mp.Size = new Size(114, 27);
            textbox_mp.TabIndex = 7;
            textbox_mp.TextChanged += textbox_mp_TextChanged;
            // 
            // groupBox_renseignements
            // 
            groupBox_renseignements.Controls.Add(textbox_mp);
            groupBox_renseignements.Controls.Add(label_mp);
            groupBox_renseignements.Controls.Add(textbox_prenom);
            groupBox_renseignements.Controls.Add(label_prenom);
            groupBox_renseignements.Controls.Add(label_email);
            groupBox_renseignements.Controls.Add(textbox_nom);
            groupBox_renseignements.Controls.Add(textbox_email);
            groupBox_renseignements.Controls.Add(label_nom);
            groupBox_renseignements.Location = new Point(261, 188);
            groupBox_renseignements.Margin = new Padding(3, 4, 3, 4);
            groupBox_renseignements.Name = "groupBox_renseignements";
            groupBox_renseignements.Padding = new Padding(3, 4, 3, 4);
            groupBox_renseignements.Size = new Size(394, 215);
            groupBox_renseignements.TabIndex = 9;
            groupBox_renseignements.TabStop = false;
            groupBox_renseignements.Text = "Renseignements d'authentification";
            // 
            // groupBox_abonnement
            // 
            groupBox_abonnement.Controls.Add(comboBox_abonnement);
            groupBox_abonnement.Controls.Add(label_abonnement);
            groupBox_abonnement.Location = new Point(261, 421);
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
            button_submit.Location = new Point(569, 525);
            button_submit.Margin = new Padding(3, 4, 3, 4);
            button_submit.Name = "button_submit";
            button_submit.Size = new Size(86, 31);
            button_submit.TabIndex = 11;
            button_submit.Text = "Soumettre";
            button_submit.UseVisualStyleBackColor = true;
            button_submit.Click += button1_Click;
            // 
            // textbox_format
            // 
            textbox_format.AutoSize = true;
            textbox_format.Location = new Point(746, 296);
            textbox_format.Name = "textbox_format";
            textbox_format.Size = new Size(50, 20);
            textbox_format.TabIndex = 12;
            textbox_format.Text = "a@a.a";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(textbox_format);
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
        private Label textbox_format;
    }
}