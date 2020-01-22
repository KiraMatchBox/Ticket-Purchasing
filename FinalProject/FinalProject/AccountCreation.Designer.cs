namespace FinalProject
{
    partial class AccountCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountCreation));
            this.txtAgeCreate = new System.Windows.Forms.TextBox();
            this.txtNameCreate = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPasswordCreate = new System.Windows.Forms.TextBox();
            this.txtEmailCreate = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.lblHide = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAgeCreate
            // 
            this.txtAgeCreate.Location = new System.Drawing.Point(173, 91);
            this.txtAgeCreate.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgeCreate.Name = "txtAgeCreate";
            this.txtAgeCreate.Size = new System.Drawing.Size(193, 22);
            this.txtAgeCreate.TabIndex = 2;
            // 
            // txtNameCreate
            // 
            this.txtNameCreate.Location = new System.Drawing.Point(173, 44);
            this.txtNameCreate.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameCreate.Name = "txtNameCreate";
            this.txtNameCreate.Size = new System.Drawing.Size(193, 22);
            this.txtNameCreate.TabIndex = 1;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(88, 90);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(53, 24);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(72, 43);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 24);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // txtPasswordCreate
            // 
            this.txtPasswordCreate.Location = new System.Drawing.Point(173, 186);
            this.txtPasswordCreate.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordCreate.Name = "txtPasswordCreate";
            this.txtPasswordCreate.Size = new System.Drawing.Size(193, 22);
            this.txtPasswordCreate.TabIndex = 4;
            this.txtPasswordCreate.UseSystemPasswordChar = true;
            // 
            // txtEmailCreate
            // 
            this.txtEmailCreate.Location = new System.Drawing.Point(173, 139);
            this.txtEmailCreate.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailCreate.Name = "txtEmailCreate";
            this.txtEmailCreate.Size = new System.Drawing.Size(193, 22);
            this.txtEmailCreate.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(28, 185);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(110, 24);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(65, 138);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(75, 24);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "E-mail:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(131, 258);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(131, 42);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(320, 212);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(42, 17);
            this.lblShow.TabIndex = 11;
            this.lblShow.Text = "Show";
            this.lblShow.Click += new System.EventHandler(this.lblShow_Click);
            // 
            // lblHide
            // 
            this.lblHide.AutoSize = true;
            this.lblHide.Location = new System.Drawing.Point(277, 212);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(37, 17);
            this.lblHide.TabIndex = 12;
            this.lblHide.Text = "Hide";
            this.lblHide.Click += new System.EventHandler(this.lblHide_Click);
            // 
            // AccountCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 315);
            this.Controls.Add(this.lblHide);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPasswordCreate);
            this.Controls.Add(this.txtEmailCreate);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAgeCreate);
            this.Controls.Add(this.txtNameCreate);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAgeCreate;
        private System.Windows.Forms.TextBox txtNameCreate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPasswordCreate;
        private System.Windows.Forms.TextBox txtEmailCreate;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label lblHide;
    }
}