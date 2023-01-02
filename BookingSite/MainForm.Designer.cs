namespace BookingSite
{
    partial class MainForm
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
            this.Naming = new System.Windows.Forms.Label();
            this.AdminFromBtn = new System.Windows.Forms.Label();
            this.AdminBtn = new System.Windows.Forms.Button();
            this.BuyerFormBtn = new System.Windows.Forms.Label();
            this.SellerFormBtn = new System.Windows.Forms.Label();
            this.BuyerBtn = new System.Windows.Forms.Button();
            this.SellerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Naming
            // 
            this.Naming.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Naming.Location = new System.Drawing.Point(251, 154);
            this.Naming.Name = "Naming";
            this.Naming.Size = new System.Drawing.Size(274, 58);
            this.Naming.TabIndex = 0;
            this.Naming.Text = "BookingSite";
            // 
            // AdminFromBtn
            // 
            this.AdminFromBtn.AutoSize = true;
            this.AdminFromBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminFromBtn.Location = new System.Drawing.Point(49, 400);
            this.AdminFromBtn.Name = "AdminFromBtn";
            this.AdminFromBtn.Size = new System.Drawing.Size(116, 22);
            this.AdminFromBtn.TabIndex = 1;
            this.AdminFromBtn.Text = "AdminPanel";
            // 
            // AdminBtn
            // 
            this.AdminBtn.Location = new System.Drawing.Point(49, 349);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(115, 50);
            this.AdminBtn.TabIndex = 2;
            this.AdminBtn.Text = "Admin Panel";
            this.AdminBtn.UseVisualStyleBackColor = true;
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            // 
            // BuyerFormBtn
            // 
            this.BuyerFormBtn.AutoSize = true;
            this.BuyerFormBtn.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BuyerFormBtn.Location = new System.Drawing.Point(331, 397);
            this.BuyerFormBtn.Name = "BuyerFormBtn";
            this.BuyerFormBtn.Size = new System.Drawing.Size(133, 25);
            this.BuyerFormBtn.TabIndex = 3;
            this.BuyerFormBtn.Text = "Log as buyer";
            // 
            // SellerFormBtn
            // 
            this.SellerFormBtn.AutoSize = true;
            this.SellerFormBtn.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SellerFormBtn.Location = new System.Drawing.Point(598, 397);
            this.SellerFormBtn.Name = "SellerFormBtn";
            this.SellerFormBtn.Size = new System.Drawing.Size(132, 25);
            this.SellerFormBtn.TabIndex = 4;
            this.SellerFormBtn.Text = "Log as seller";
            // 
            // BuyerBtn
            // 
            this.BuyerBtn.Location = new System.Drawing.Point(331, 344);
            this.BuyerBtn.Name = "BuyerBtn";
            this.BuyerBtn.Size = new System.Drawing.Size(133, 50);
            this.BuyerBtn.TabIndex = 5;
            this.BuyerBtn.Text = "Buyer Form";
            this.BuyerBtn.UseVisualStyleBackColor = true;
            this.BuyerBtn.Click += new System.EventHandler(this.BuyerBtn_Click);
            // 
            // SellerBtn
            // 
            this.SellerBtn.Location = new System.Drawing.Point(598, 344);
            this.SellerBtn.Name = "SellerBtn";
            this.SellerBtn.Size = new System.Drawing.Size(133, 50);
            this.SellerBtn.TabIndex = 6;
            this.SellerBtn.Text = "Seller Form";
            this.SellerBtn.UseVisualStyleBackColor = true;
            this.SellerBtn.Click += new System.EventHandler(this.SellerBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SellerBtn);
            this.Controls.Add(this.BuyerBtn);
            this.Controls.Add(this.SellerFormBtn);
            this.Controls.Add(this.BuyerFormBtn);
            this.Controls.Add(this.AdminBtn);
            this.Controls.Add(this.AdminFromBtn);
            this.Controls.Add(this.Naming);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Naming;
        private Label AdminFromBtn;
        private Button AdminBtn;
        private Label BuyerFormBtn;
        private Label SellerFormBtn;
        private Button BuyerBtn;
        private Button SellerBtn;
    }
}