namespace FileServerProject
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gotoRecoverAccButton = new System.Windows.Forms.Button();
            this.gotoRegistrationButton = new System.Windows.Forms.Button();
            this.gotoAutorizationButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(657, 450);
            this.mainPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gotoRecoverAccButton);
            this.panel2.Controls.Add(this.gotoRegistrationButton);
            this.panel2.Controls.Add(this.gotoAutorizationButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 448);
            this.panel2.TabIndex = 1;
            // 
            // gotoRecoverAccButton
            // 
            this.gotoRecoverAccButton.Location = new System.Drawing.Point(23, 155);
            this.gotoRecoverAccButton.Name = "gotoRecoverAccButton";
            this.gotoRecoverAccButton.Size = new System.Drawing.Size(157, 64);
            this.gotoRecoverAccButton.TabIndex = 2;
            this.gotoRecoverAccButton.Text = "Восстановление пароля";
            this.gotoRecoverAccButton.UseVisualStyleBackColor = true;
            this.gotoRecoverAccButton.Click += new System.EventHandler(this.gotoRecoverAccButton_Click);
            // 
            // gotoRegistrationButton
            // 
            this.gotoRegistrationButton.Location = new System.Drawing.Point(23, 101);
            this.gotoRegistrationButton.Name = "gotoRegistrationButton";
            this.gotoRegistrationButton.Size = new System.Drawing.Size(157, 34);
            this.gotoRegistrationButton.TabIndex = 1;
            this.gotoRegistrationButton.Text = "Регистрация";
            this.gotoRegistrationButton.UseVisualStyleBackColor = true;
            this.gotoRegistrationButton.Click += new System.EventHandler(this.gotoRegistrationButton_Click);
            // 
            // gotoAutorizationButton
            // 
            this.gotoAutorizationButton.Location = new System.Drawing.Point(23, 42);
            this.gotoAutorizationButton.Name = "gotoAutorizationButton";
            this.gotoAutorizationButton.Size = new System.Drawing.Size(157, 34);
            this.gotoAutorizationButton.TabIndex = 0;
            this.gotoAutorizationButton.Text = "Авторизация";
            this.gotoAutorizationButton.UseVisualStyleBackColor = true;
            this.gotoAutorizationButton.Click += new System.EventHandler(this.gotoAutorizationButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 448);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mainPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button gotoRecoverAccButton;
        private System.Windows.Forms.Button gotoRegistrationButton;
        private System.Windows.Forms.Button gotoAutorizationButton;
    }
}