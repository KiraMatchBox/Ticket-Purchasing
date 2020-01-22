namespace FinalProject
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.grpSeatsRemaining = new System.Windows.Forms.GroupBox();
            this.grpGuestLookup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLowerCount = new System.Windows.Forms.Label();
            this.lblClubCount = new System.Windows.Forms.Label();
            this.lblUpperCount = new System.Windows.Forms.Label();
            this.lblConfirmationNumber = new System.Windows.Forms.Label();
            this.txtConfirmationNumber = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowerLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upperDeck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSeatsRemaining.SuspendLayout();
            this.grpGuestLookup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.ForeColor = System.Drawing.Color.Red;
            this.lblTotalSales.Location = new System.Drawing.Point(12, 9);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(169, 33);
            this.lblTotalSales.TabIndex = 0;
            this.lblTotalSales.Text = "Total Sales:";
            // 
            // grpSeatsRemaining
            // 
            this.grpSeatsRemaining.Controls.Add(this.lblUpperCount);
            this.grpSeatsRemaining.Controls.Add(this.lblClubCount);
            this.grpSeatsRemaining.Controls.Add(this.lblLowerCount);
            this.grpSeatsRemaining.Controls.Add(this.label3);
            this.grpSeatsRemaining.Controls.Add(this.label2);
            this.grpSeatsRemaining.Controls.Add(this.label1);
            this.grpSeatsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSeatsRemaining.Location = new System.Drawing.Point(12, 45);
            this.grpSeatsRemaining.Name = "grpSeatsRemaining";
            this.grpSeatsRemaining.Size = new System.Drawing.Size(541, 138);
            this.grpSeatsRemaining.TabIndex = 1;
            this.grpSeatsRemaining.TabStop = false;
            this.grpSeatsRemaining.Text = "Seats Remaining";
            // 
            // grpGuestLookup
            // 
            this.grpGuestLookup.Controls.Add(this.btnFind);
            this.grpGuestLookup.Controls.Add(this.txtConfirmationNumber);
            this.grpGuestLookup.Controls.Add(this.lblConfirmationNumber);
            this.grpGuestLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGuestLookup.Location = new System.Drawing.Point(559, 45);
            this.grpGuestLookup.Name = "grpGuestLookup";
            this.grpGuestLookup.Size = new System.Drawing.Size(412, 138);
            this.grpGuestLookup.TabIndex = 2;
            this.grpGuestLookup.TabStop = false;
            this.grpGuestLookup.Text = "Guest Lookup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lower Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Club Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Upper Deck";
            // 
            // lblLowerCount
            // 
            this.lblLowerCount.AutoSize = true;
            this.lblLowerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowerCount.Location = new System.Drawing.Point(61, 88);
            this.lblLowerCount.Name = "lblLowerCount";
            this.lblLowerCount.Size = new System.Drawing.Size(95, 17);
            this.lblLowerCount.TabIndex = 3;
            this.lblLowerCount.Text = "Lower Level";
            // 
            // lblClubCount
            // 
            this.lblClubCount.AutoSize = true;
            this.lblClubCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubCount.Location = new System.Drawing.Point(219, 88);
            this.lblClubCount.Name = "lblClubCount";
            this.lblClubCount.Size = new System.Drawing.Size(84, 17);
            this.lblClubCount.TabIndex = 4;
            this.lblClubCount.Text = "Club Level";
            // 
            // lblUpperCount
            // 
            this.lblUpperCount.AutoSize = true;
            this.lblUpperCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpperCount.Location = new System.Drawing.Point(392, 88);
            this.lblUpperCount.Name = "lblUpperCount";
            this.lblUpperCount.Size = new System.Drawing.Size(93, 17);
            this.lblUpperCount.TabIndex = 5;
            this.lblUpperCount.Text = "Upper Deck";
            // 
            // lblConfirmationNumber
            // 
            this.lblConfirmationNumber.AutoSize = true;
            this.lblConfirmationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationNumber.Location = new System.Drawing.Point(22, 43);
            this.lblConfirmationNumber.Name = "lblConfirmationNumber";
            this.lblConfirmationNumber.Size = new System.Drawing.Size(165, 17);
            this.lblConfirmationNumber.TabIndex = 6;
            this.lblConfirmationNumber.Text = "Confirmation Number:";
            // 
            // txtConfirmationNumber
            // 
            this.txtConfirmationNumber.Location = new System.Drawing.Point(193, 37);
            this.txtConfirmationNumber.Name = "txtConfirmationNumber";
            this.txtConfirmationNumber.Size = new System.Drawing.Size(184, 27);
            this.txtConfirmationNumber.TabIndex = 7;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Red;
            this.btnFind.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(156, 88);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(98, 40);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerName,
            this.email,
            this.totalCost,
            this.confirmationNumber,
            this.lowerLevel,
            this.clubLevel,
            this.upperDeck});
            this.dataGridView1.Location = new System.Drawing.Point(12, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(959, 291);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(429, 531);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 40);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Customer";
            this.customerName.MinimumWidth = 6;
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // totalCost
            // 
            this.totalCost.HeaderText = "Total Cost";
            this.totalCost.MinimumWidth = 6;
            this.totalCost.Name = "totalCost";
            this.totalCost.ReadOnly = true;
            this.totalCost.Width = 125;
            // 
            // confirmationNumber
            // 
            this.confirmationNumber.HeaderText = "Confirmation Number";
            this.confirmationNumber.MinimumWidth = 6;
            this.confirmationNumber.Name = "confirmationNumber";
            this.confirmationNumber.ReadOnly = true;
            this.confirmationNumber.Width = 125;
            // 
            // lowerLevel
            // 
            this.lowerLevel.HeaderText = "Lower Level Seats";
            this.lowerLevel.MinimumWidth = 6;
            this.lowerLevel.Name = "lowerLevel";
            this.lowerLevel.ReadOnly = true;
            this.lowerLevel.Width = 125;
            // 
            // clubLevel
            // 
            this.clubLevel.HeaderText = "Club Level Seats";
            this.clubLevel.MinimumWidth = 6;
            this.clubLevel.Name = "clubLevel";
            this.clubLevel.ReadOnly = true;
            this.clubLevel.Width = 125;
            // 
            // upperDeck
            // 
            this.upperDeck.HeaderText = "Upper Deck Seats";
            this.upperDeck.MinimumWidth = 6;
            this.upperDeck.Name = "upperDeck";
            this.upperDeck.ReadOnly = true;
            this.upperDeck.Width = 125;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 583);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpGuestLookup);
            this.Controls.Add(this.grpSeatsRemaining);
            this.Controls.Add(this.lblTotalSales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.grpSeatsRemaining.ResumeLayout(false);
            this.grpSeatsRemaining.PerformLayout();
            this.grpGuestLookup.ResumeLayout(false);
            this.grpGuestLookup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.GroupBox grpSeatsRemaining;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpGuestLookup;
        private System.Windows.Forms.Label lblUpperCount;
        private System.Windows.Forms.Label lblClubCount;
        private System.Windows.Forms.Label lblLowerCount;
        private System.Windows.Forms.TextBox txtConfirmationNumber;
        private System.Windows.Forms.Label lblConfirmationNumber;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowerLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn upperDeck;
    }
}