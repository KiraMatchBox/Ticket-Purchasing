namespace FinalProject
{
    partial class Tickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tickets));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.numClubLevel = new System.Windows.Forms.NumericUpDown();
            this.lblClubLevel = new System.Windows.Forms.Label();
            this.numUpperDeck = new System.Windows.Forms.NumericUpDown();
            this.lblUpperDeck = new System.Windows.Forms.Label();
            this.numLowerLevel = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblLowerLevel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClubLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpperDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLowerLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuy);
            this.groupBox1.Controls.Add(this.numClubLevel);
            this.groupBox1.Controls.Add(this.lblClubLevel);
            this.groupBox1.Controls.Add(this.numUpperDeck);
            this.groupBox1.Controls.Add(this.lblUpperDeck);
            this.groupBox1.Controls.Add(this.numLowerLevel);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.lblLowerLevel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(544, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets";
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.MediumPurple;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(202, 255);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(131, 42);
            this.btnBuy.TabIndex = 7;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // numClubLevel
            // 
            this.numClubLevel.Location = new System.Drawing.Point(300, 132);
            this.numClubLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numClubLevel.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numClubLevel.Name = "numClubLevel";
            this.numClubLevel.Size = new System.Drawing.Size(163, 22);
            this.numClubLevel.TabIndex = 6;
            // 
            // lblClubLevel
            // 
            this.lblClubLevel.AutoSize = true;
            this.lblClubLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubLevel.Location = new System.Drawing.Point(32, 130);
            this.lblClubLevel.Name = "lblClubLevel";
            this.lblClubLevel.Size = new System.Drawing.Size(183, 24);
            this.lblClubLevel.TabIndex = 5;
            this.lblClubLevel.Text = "Club Level: $75.00";
            // 
            // numUpperDeck
            // 
            this.numUpperDeck.Location = new System.Drawing.Point(300, 201);
            this.numUpperDeck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUpperDeck.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numUpperDeck.Name = "numUpperDeck";
            this.numUpperDeck.Size = new System.Drawing.Size(163, 22);
            this.numUpperDeck.TabIndex = 4;
            // 
            // lblUpperDeck
            // 
            this.lblUpperDeck.AutoSize = true;
            this.lblUpperDeck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpperDeck.Location = new System.Drawing.Point(32, 197);
            this.lblUpperDeck.Name = "lblUpperDeck";
            this.lblUpperDeck.Size = new System.Drawing.Size(194, 24);
            this.lblUpperDeck.TabIndex = 3;
            this.lblUpperDeck.Text = "Upper Deck: $50.00";
            // 
            // numLowerLevel
            // 
            this.numLowerLevel.Location = new System.Drawing.Point(300, 71);
            this.numLowerLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numLowerLevel.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numLowerLevel.Name = "numLowerLevel";
            this.numLowerLevel.Size = new System.Drawing.Size(163, 22);
            this.numLowerLevel.TabIndex = 2;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(340, 27);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(98, 24);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLowerLevel
            // 
            this.lblLowerLevel.AutoSize = true;
            this.lblLowerLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowerLevel.Location = new System.Drawing.Point(32, 69);
            this.lblLowerLevel.Name = "lblLowerLevel";
            this.lblLowerLevel.Size = new System.Drawing.Size(209, 24);
            this.lblLowerLevel.TabIndex = 0;
            this.lblLowerLevel.Text = "Lower Level: $125.00";
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 363);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClubLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpperDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLowerLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblLowerLevel;
        private System.Windows.Forms.NumericUpDown numClubLevel;
        private System.Windows.Forms.Label lblClubLevel;
        private System.Windows.Forms.NumericUpDown numUpperDeck;
        private System.Windows.Forms.Label lblUpperDeck;
        private System.Windows.Forms.NumericUpDown numLowerLevel;
        private System.Windows.Forms.Button btnBuy;
    }
}