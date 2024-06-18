namespace AirProject
{
    partial class RegForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxlogin = new System.Windows.Forms.TextBox();
            this.textBoxPassw = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LastNameLable = new System.Windows.Forms.Label();
            this.LoginLable = new System.Windows.Forms.Label();
            this.PaswLabel = new System.Windows.Forms.Label();
            this.RegAcceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(315, 126);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(183, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(569, 126);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(172, 22);
            this.textBoxLastName.TabIndex = 2;
            // 
            // textBoxlogin
            // 
            this.textBoxlogin.Location = new System.Drawing.Point(315, 193);
            this.textBoxlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxlogin.Name = "textBoxlogin";
            this.textBoxlogin.Size = new System.Drawing.Size(183, 22);
            this.textBoxlogin.TabIndex = 3;
            // 
            // textBoxPassw
            // 
            this.textBoxPassw.Location = new System.Drawing.Point(569, 193);
            this.textBoxPassw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassw.Name = "textBoxPassw";
            this.textBoxPassw.Size = new System.Drawing.Size(172, 22);
            this.textBoxPassw.TabIndex = 4;
            this.textBoxPassw.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(375, 102);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(33, 16);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Имя";
            this.NameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LastNameLable
            // 
            this.LastNameLable.AutoSize = true;
            this.LastNameLable.Location = new System.Drawing.Point(617, 102);
            this.LastNameLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLable.Name = "LastNameLable";
            this.LastNameLable.Size = new System.Drawing.Size(66, 16);
            this.LastNameLable.TabIndex = 6;
            this.LastNameLable.Text = "Фамилия";
            this.LastNameLable.Click += new System.EventHandler(this.LastNameLable_Click);
            // 
            // LoginLable
            // 
            this.LoginLable.AutoSize = true;
            this.LoginLable.Location = new System.Drawing.Point(375, 174);
            this.LoginLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLable.Name = "LoginLable";
            this.LoginLable.Size = new System.Drawing.Size(46, 16);
            this.LoginLable.TabIndex = 7;
            this.LoginLable.Text = "Логин";
            // 
            // PaswLabel
            // 
            this.PaswLabel.AutoSize = true;
            this.PaswLabel.Location = new System.Drawing.Point(617, 174);
            this.PaswLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PaswLabel.Name = "PaswLabel";
            this.PaswLabel.Size = new System.Drawing.Size(62, 16);
            this.PaswLabel.TabIndex = 8;
            this.PaswLabel.Text = "  Пароль";
            this.PaswLabel.Click += new System.EventHandler(this.PaswLabel_Click);
            // 
            // RegAcceptButton
            // 
            this.RegAcceptButton.Location = new System.Drawing.Point(393, 263);
            this.RegAcceptButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegAcceptButton.Name = "RegAcceptButton";
            this.RegAcceptButton.Size = new System.Drawing.Size(265, 28);
            this.RegAcceptButton.TabIndex = 9;
            this.RegAcceptButton.Text = "Зарегистрироваться";
            this.RegAcceptButton.UseVisualStyleBackColor = true;
            this.RegAcceptButton.Click += new System.EventHandler(this.RegAcceptButton_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.RegAcceptButton);
            this.Controls.Add(this.PaswLabel);
            this.Controls.Add(this.LoginLable);
            this.Controls.Add(this.LastNameLable);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.textBoxPassw);
            this.Controls.Add(this.textBoxlogin);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegForm";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.RegForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxlogin;
        private System.Windows.Forms.TextBox textBoxPassw;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LastNameLable;
        private System.Windows.Forms.Label LoginLable;
        private System.Windows.Forms.Label PaswLabel;
        private System.Windows.Forms.Button RegAcceptButton;
    }
}