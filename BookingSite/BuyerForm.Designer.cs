namespace BookingSite
{
    partial class BuyerForm
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
            this.TypesOfBuildings = new System.Windows.Forms.ListBox();
            this.ShowAvailableBuildings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TypesOfBuildings
            // 
            this.TypesOfBuildings.FormattingEnabled = true;
            this.TypesOfBuildings.ItemHeight = 15;
            this.TypesOfBuildings.Location = new System.Drawing.Point(131, 125);
            this.TypesOfBuildings.Name = "TypesOfBuildings";
            this.TypesOfBuildings.Size = new System.Drawing.Size(144, 94);
            this.TypesOfBuildings.TabIndex = 0;
            this.TypesOfBuildings.SelectedIndexChanged += new System.EventHandler(this.TypesOfBuildings_SelectedIndexChanged);
            // 
            // ShowAvailableBuildings
            // 
            this.ShowAvailableBuildings.Location = new System.Drawing.Point(131, 225);
            this.ShowAvailableBuildings.Name = "ShowAvailableBuildings";
            this.ShowAvailableBuildings.Size = new System.Drawing.Size(144, 40);
            this.ShowAvailableBuildings.TabIndex = 1;
            this.ShowAvailableBuildings.Text = "ShowAvailableBuildings";
            this.ShowAvailableBuildings.UseVisualStyleBackColor = true;
            this.ShowAvailableBuildings.Click += new System.EventHandler(this.ShowAvailableBuildings_Click);
            // 
            // BuyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowAvailableBuildings);
            this.Controls.Add(this.TypesOfBuildings);
            this.Name = "BuyerForm";
            this.Text = "BuyerForm";
            this.Load += new System.EventHandler(this.BuyerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox TypesOfBuildings;
        private Button ShowAvailableBuildings;
    }
}