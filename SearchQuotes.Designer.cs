namespace MegaDesk___Lilly
{
    partial class SearchQuotes
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
            this.returnToMainBtn = new System.Windows.Forms.Button();
            this.viewAllQuotesLabel = new System.Windows.Forms.Label();
            this.materialListDrop = new System.Windows.Forms.ComboBox();
            this.searchQuotesGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // returnToMainBtn
            // 
            this.returnToMainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMainBtn.Location = new System.Drawing.Point(287, 386);
            this.returnToMainBtn.Name = "returnToMainBtn";
            this.returnToMainBtn.Size = new System.Drawing.Size(176, 52);
            this.returnToMainBtn.TabIndex = 6;
            this.returnToMainBtn.Text = "Main Menu";
            this.returnToMainBtn.UseVisualStyleBackColor = true;
            this.returnToMainBtn.Click += new System.EventHandler(this.returnToMainBtn_Click);
            // 
            // viewAllQuotesLabel
            // 
            this.viewAllQuotesLabel.AutoSize = true;
            this.viewAllQuotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllQuotesLabel.Location = new System.Drawing.Point(26, 31);
            this.viewAllQuotesLabel.Name = "viewAllQuotesLabel";
            this.viewAllQuotesLabel.Size = new System.Drawing.Size(166, 24);
            this.viewAllQuotesLabel.TabIndex = 13;
            this.viewAllQuotesLabel.Text = "Search By Material";
            // 
            // materialListDrop
            // 
            this.materialListDrop.FormattingEnabled = true;
            this.materialListDrop.Items.AddRange(new object[] {
            "Rosewood",
            "Laminate",
            "Veneer",
            "Oak",
            "Pine"});
            this.materialListDrop.Location = new System.Drawing.Point(198, 34);
            this.materialListDrop.Name = "materialListDrop";
            this.materialListDrop.Size = new System.Drawing.Size(136, 21);
            this.materialListDrop.TabIndex = 14;
            this.materialListDrop.SelectedIndexChanged += new System.EventHandler(this.materialListDrop_Select);
            // 
            // searchQuotesGrid
            // 
            this.searchQuotesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchQuotesGrid.Location = new System.Drawing.Point(12, 80);
            this.searchQuotesGrid.Name = "searchQuotesGrid";
            this.searchQuotesGrid.Size = new System.Drawing.Size(776, 291);
            this.searchQuotesGrid.TabIndex = 15;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchQuotesGrid);
            this.Controls.Add(this.materialListDrop);
            this.Controls.Add(this.viewAllQuotesLabel);
            this.Controls.Add(this.returnToMainBtn);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnToMainBtn;
        private System.Windows.Forms.Label viewAllQuotesLabel;
        private System.Windows.Forms.ComboBox materialListDrop;
        private System.Windows.Forms.DataGridView searchQuotesGrid;
    }
}