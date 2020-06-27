namespace WSBank
{
    partial class MainForm
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
            this.loginGroup = new System.Windows.Forms.GroupBox();
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.loginLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.signinBtn = new System.Windows.Forms.Button();
            this.userpanelGroup = new System.Windows.Forms.GroupBox();
            this.fullnameLbl = new System.Windows.Forms.Label();
            this.signoutButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.registerGroup = new System.Windows.Forms.GroupBox();
            this.rLnameLbl = new System.Windows.Forms.Label();
            this.rFnameLbl = new System.Windows.Forms.Label();
            this.rLnameTxt = new System.Windows.Forms.TextBox();
            this.rFnameTxt = new System.Windows.Forms.TextBox();
            this.rPassword1Lbl = new System.Windows.Forms.Label();
            this.rLoginLbl = new System.Windows.Forms.Label();
            this.rPassword1Txt = new System.Windows.Forms.TextBox();
            this.rLoginTxt = new System.Windows.Forms.TextBox();
            this.rPassword2Lbl = new System.Windows.Forms.Label();
            this.rPassword2Txt = new System.Windows.Forms.TextBox();
            this.rBalanceLbl = new System.Windows.Forms.Label();
            this.rBalanceTxt = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.balanceLabelLbl = new System.Windows.Forms.Label();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.amountLbl = new System.Windows.Forms.Label();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.recLbl = new System.Windows.Forms.Label();
            this.recTxt = new System.Windows.Forms.TextBox();
            this.transferBtn = new System.Windows.Forms.Button();
            this.loginGroup.SuspendLayout();
            this.userpanelGroup.SuspendLayout();
            this.registerGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginGroup
            // 
            this.loginGroup.Controls.Add(this.signinBtn);
            this.loginGroup.Controls.Add(this.passwordLbl);
            this.loginGroup.Controls.Add(this.loginLbl);
            this.loginGroup.Controls.Add(this.passwordTxt);
            this.loginGroup.Controls.Add(this.loginTxt);
            this.loginGroup.Location = new System.Drawing.Point(12, 12);
            this.loginGroup.Name = "loginGroup";
            this.loginGroup.Size = new System.Drawing.Size(184, 142);
            this.loginGroup.TabIndex = 0;
            this.loginGroup.TabStop = false;
            this.loginGroup.Text = "Zaloguj";
            // 
            // loginTxt
            // 
            this.loginTxt.Location = new System.Drawing.Point(6, 38);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(172, 20);
            this.loginTxt.TabIndex = 0;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(6, 77);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(172, 20);
            this.passwordTxt.TabIndex = 1;
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Location = new System.Drawing.Point(6, 22);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(33, 13);
            this.loginLbl.TabIndex = 2;
            this.loginLbl.Text = "Login";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(6, 61);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(36, 13);
            this.passwordLbl.TabIndex = 3;
            this.passwordLbl.Text = "Hasło";
            // 
            // signinBtn
            // 
            this.signinBtn.Location = new System.Drawing.Point(103, 103);
            this.signinBtn.Name = "signinBtn";
            this.signinBtn.Size = new System.Drawing.Size(75, 23);
            this.signinBtn.TabIndex = 4;
            this.signinBtn.Text = "Zaloguj";
            this.signinBtn.UseVisualStyleBackColor = true;
            this.signinBtn.Click += new System.EventHandler(this.SigninBtn_Click);
            // 
            // userpanelGroup
            // 
            this.userpanelGroup.Controls.Add(this.groupBox1);
            this.userpanelGroup.Controls.Add(this.balanceLbl);
            this.userpanelGroup.Controls.Add(this.balanceLabelLbl);
            this.userpanelGroup.Controls.Add(this.deleteButton);
            this.userpanelGroup.Controls.Add(this.signoutButton);
            this.userpanelGroup.Controls.Add(this.fullnameLbl);
            this.userpanelGroup.Location = new System.Drawing.Point(236, 12);
            this.userpanelGroup.Name = "userpanelGroup";
            this.userpanelGroup.Size = new System.Drawing.Size(672, 536);
            this.userpanelGroup.TabIndex = 1;
            this.userpanelGroup.TabStop = false;
            this.userpanelGroup.Text = "Panel Użytkownika";
            this.userpanelGroup.Visible = false;
            this.userpanelGroup.Enter += new System.EventHandler(this.UserpanelGroup_Enter);
            // 
            // fullnameLbl
            // 
            this.fullnameLbl.AutoSize = true;
            this.fullnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameLbl.Location = new System.Drawing.Point(216, 33);
            this.fullnameLbl.Name = "fullnameLbl";
            this.fullnameLbl.Size = new System.Drawing.Size(229, 25);
            this.fullnameLbl.TabIndex = 0;
            this.fullnameLbl.Text = "Witaj Imię Nazwisko!";
            // 
            // signoutButton
            // 
            this.signoutButton.Location = new System.Drawing.Point(591, 12);
            this.signoutButton.Name = "signoutButton";
            this.signoutButton.Size = new System.Drawing.Size(75, 23);
            this.signoutButton.TabIndex = 1;
            this.signoutButton.Text = "Wyloguj";
            this.signoutButton.UseVisualStyleBackColor = true;
            this.signoutButton.Click += new System.EventHandler(this.SignoutButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(567, 481);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 49);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Usuń Konto";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // registerGroup
            // 
            this.registerGroup.Controls.Add(this.registerBtn);
            this.registerGroup.Controls.Add(this.rBalanceLbl);
            this.registerGroup.Controls.Add(this.rBalanceTxt);
            this.registerGroup.Controls.Add(this.rPassword2Lbl);
            this.registerGroup.Controls.Add(this.rPassword2Txt);
            this.registerGroup.Controls.Add(this.rPassword1Lbl);
            this.registerGroup.Controls.Add(this.rLoginLbl);
            this.registerGroup.Controls.Add(this.rPassword1Txt);
            this.registerGroup.Controls.Add(this.rLoginTxt);
            this.registerGroup.Controls.Add(this.rLnameLbl);
            this.registerGroup.Controls.Add(this.rFnameLbl);
            this.registerGroup.Controls.Add(this.rLnameTxt);
            this.registerGroup.Controls.Add(this.rFnameTxt);
            this.registerGroup.Location = new System.Drawing.Point(12, 171);
            this.registerGroup.Name = "registerGroup";
            this.registerGroup.Size = new System.Drawing.Size(184, 314);
            this.registerGroup.TabIndex = 2;
            this.registerGroup.TabStop = false;
            this.registerGroup.Text = "Zarejestruj";
            // 
            // rLnameLbl
            // 
            this.rLnameLbl.AutoSize = true;
            this.rLnameLbl.Location = new System.Drawing.Point(6, 60);
            this.rLnameLbl.Name = "rLnameLbl";
            this.rLnameLbl.Size = new System.Drawing.Size(53, 13);
            this.rLnameLbl.TabIndex = 7;
            this.rLnameLbl.Text = "Nazwisko";
            // 
            // rFnameLbl
            // 
            this.rFnameLbl.AutoSize = true;
            this.rFnameLbl.Location = new System.Drawing.Point(6, 21);
            this.rFnameLbl.Name = "rFnameLbl";
            this.rFnameLbl.Size = new System.Drawing.Size(26, 13);
            this.rFnameLbl.TabIndex = 6;
            this.rFnameLbl.Text = "Imię";
            // 
            // rLnameTxt
            // 
            this.rLnameTxt.Location = new System.Drawing.Point(6, 76);
            this.rLnameTxt.Name = "rLnameTxt";
            this.rLnameTxt.Size = new System.Drawing.Size(172, 20);
            this.rLnameTxt.TabIndex = 5;
            // 
            // rFnameTxt
            // 
            this.rFnameTxt.Location = new System.Drawing.Point(6, 37);
            this.rFnameTxt.Name = "rFnameTxt";
            this.rFnameTxt.Size = new System.Drawing.Size(172, 20);
            this.rFnameTxt.TabIndex = 4;
            // 
            // rPassword1Lbl
            // 
            this.rPassword1Lbl.AutoSize = true;
            this.rPassword1Lbl.Location = new System.Drawing.Point(6, 140);
            this.rPassword1Lbl.Name = "rPassword1Lbl";
            this.rPassword1Lbl.Size = new System.Drawing.Size(36, 13);
            this.rPassword1Lbl.TabIndex = 11;
            this.rPassword1Lbl.Text = "Hasło";
            // 
            // rLoginLbl
            // 
            this.rLoginLbl.AutoSize = true;
            this.rLoginLbl.Location = new System.Drawing.Point(6, 101);
            this.rLoginLbl.Name = "rLoginLbl";
            this.rLoginLbl.Size = new System.Drawing.Size(33, 13);
            this.rLoginLbl.TabIndex = 10;
            this.rLoginLbl.Text = "Login";
            // 
            // rPassword1Txt
            // 
            this.rPassword1Txt.Location = new System.Drawing.Point(6, 156);
            this.rPassword1Txt.Name = "rPassword1Txt";
            this.rPassword1Txt.PasswordChar = '*';
            this.rPassword1Txt.Size = new System.Drawing.Size(172, 20);
            this.rPassword1Txt.TabIndex = 9;
            // 
            // rLoginTxt
            // 
            this.rLoginTxt.Location = new System.Drawing.Point(6, 117);
            this.rLoginTxt.Name = "rLoginTxt";
            this.rLoginTxt.Size = new System.Drawing.Size(172, 20);
            this.rLoginTxt.TabIndex = 8;
            // 
            // rPassword2Lbl
            // 
            this.rPassword2Lbl.AutoSize = true;
            this.rPassword2Lbl.Location = new System.Drawing.Point(6, 183);
            this.rPassword2Lbl.Name = "rPassword2Lbl";
            this.rPassword2Lbl.Size = new System.Drawing.Size(77, 13);
            this.rPassword2Lbl.TabIndex = 13;
            this.rPassword2Lbl.Text = "Powtórz Hasło";
            // 
            // rPassword2Txt
            // 
            this.rPassword2Txt.Location = new System.Drawing.Point(6, 199);
            this.rPassword2Txt.Name = "rPassword2Txt";
            this.rPassword2Txt.PasswordChar = '*';
            this.rPassword2Txt.Size = new System.Drawing.Size(172, 20);
            this.rPassword2Txt.TabIndex = 12;
            // 
            // rBalanceLbl
            // 
            this.rBalanceLbl.AutoSize = true;
            this.rBalanceLbl.Location = new System.Drawing.Point(6, 224);
            this.rBalanceLbl.Name = "rBalanceLbl";
            this.rBalanceLbl.Size = new System.Drawing.Size(104, 13);
            this.rBalanceLbl.TabIndex = 15;
            this.rBalanceLbl.Text = "Wpłata początkowa";
            // 
            // rBalanceTxt
            // 
            this.rBalanceTxt.Location = new System.Drawing.Point(6, 240);
            this.rBalanceTxt.Name = "rBalanceTxt";
            this.rBalanceTxt.Size = new System.Drawing.Size(172, 20);
            this.rBalanceTxt.TabIndex = 14;
            this.rBalanceTxt.Text = "0";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(103, 266);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 16;
            this.registerBtn.Text = "Zarejestruj";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // balanceLabelLbl
            // 
            this.balanceLabelLbl.AutoSize = true;
            this.balanceLabelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabelLbl.Location = new System.Drawing.Point(218, 61);
            this.balanceLabelLbl.Name = "balanceLabelLbl";
            this.balanceLabelLbl.Size = new System.Drawing.Size(126, 16);
            this.balanceLabelLbl.TabIndex = 3;
            this.balanceLabelLbl.Text = "Dostepne środki:";
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.balanceLbl.Location = new System.Drawing.Point(345, 61);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(24, 16);
            this.balanceLbl.TabIndex = 4;
            this.balanceLbl.Text = "0$";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.transferBtn);
            this.groupBox1.Controls.Add(this.amountLbl);
            this.groupBox1.Controls.Add(this.amountTxt);
            this.groupBox1.Controls.Add(this.recLbl);
            this.groupBox1.Controls.Add(this.recTxt);
            this.groupBox1.Location = new System.Drawing.Point(221, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 139);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Przelew";
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Location = new System.Drawing.Point(14, 62);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(83, 13);
            this.amountLbl.TabIndex = 19;
            this.amountLbl.Text = "Kwota Przelewu";
            // 
            // amountTxt
            // 
            this.amountTxt.Location = new System.Drawing.Point(14, 78);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(204, 20);
            this.amountTxt.TabIndex = 18;
            this.amountTxt.Text = "0";
            // 
            // recLbl
            // 
            this.recLbl.AutoSize = true;
            this.recLbl.Location = new System.Drawing.Point(14, 21);
            this.recLbl.Name = "recLbl";
            this.recLbl.Size = new System.Drawing.Size(78, 13);
            this.recLbl.TabIndex = 17;
            this.recLbl.Text = "Login Odbiorcy";
            // 
            // recTxt
            // 
            this.recTxt.Location = new System.Drawing.Point(14, 37);
            this.recTxt.Name = "recTxt";
            this.recTxt.Size = new System.Drawing.Size(204, 20);
            this.recTxt.TabIndex = 16;
            // 
            // transferBtn
            // 
            this.transferBtn.Location = new System.Drawing.Point(143, 104);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(75, 23);
            this.transferBtn.TabIndex = 20;
            this.transferBtn.Text = "Wyślij";
            this.transferBtn.UseVisualStyleBackColor = true;
            this.transferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 560);
            this.Controls.Add(this.registerGroup);
            this.Controls.Add(this.userpanelGroup);
            this.Controls.Add(this.loginGroup);
            this.Name = "MainForm";
            this.Text = "WSBank";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.loginGroup.ResumeLayout(false);
            this.loginGroup.PerformLayout();
            this.userpanelGroup.ResumeLayout(false);
            this.userpanelGroup.PerformLayout();
            this.registerGroup.ResumeLayout(false);
            this.registerGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loginGroup;
        private System.Windows.Forms.Button signinBtn;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox loginTxt;
        private System.Windows.Forms.GroupBox userpanelGroup;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button signoutButton;
        private System.Windows.Forms.Label fullnameLbl;
        private System.Windows.Forms.GroupBox registerGroup;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label rBalanceLbl;
        private System.Windows.Forms.TextBox rBalanceTxt;
        private System.Windows.Forms.Label rPassword2Lbl;
        private System.Windows.Forms.TextBox rPassword2Txt;
        private System.Windows.Forms.Label rPassword1Lbl;
        private System.Windows.Forms.Label rLoginLbl;
        private System.Windows.Forms.TextBox rPassword1Txt;
        private System.Windows.Forms.TextBox rLoginTxt;
        private System.Windows.Forms.Label rLnameLbl;
        private System.Windows.Forms.Label rFnameLbl;
        private System.Windows.Forms.TextBox rLnameTxt;
        private System.Windows.Forms.TextBox rFnameTxt;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Label balanceLabelLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.Label recLbl;
        private System.Windows.Forms.TextBox recTxt;
    }
}