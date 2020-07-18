namespace MegaDesk___Lilly
{
    partial class ViewAllQuotes
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
            this.viewAllQuotesGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllQuotesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // returnToMainBtn
            // 
            this.returnToMainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMainBtn.Location = new System.Drawing.Point(291, 386);
            this.returnToMainBtn.Name = "returnToMainBtn";
            this.returnToMainBtn.Size = new System.Drawing.Size(176, 52);
            this.returnToMainBtn.TabIndex = 2;
            this.returnToMainBtn.Text = "Main Menu";
            this.returnToMainBtn.UseVisualStyleBackColor = true;
            this.returnToMainBtn.Click += new System.EventHandler(this.returnToMainBtn_Click);
            // 
            // viewAllQuotesLabel
            // 
            this.viewAllQuotesLabel.AutoSize = true;
            this.viewAllQuotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllQuotesLabel.Location = new System.Drawing.Point(303, 25);
            this.viewAllQuotesLabel.Name = "viewAllQuotesLabel";
            this.viewAllQuotesLabel.Size = new System.Drawing.Size(124, 24);
            this.viewAllQuotesLabel.TabIndex = 10;
            this.viewAllQuotesLabel.Text = "Quote History";
            // 
            // viewAllQuotesGrid
            // 
            this.viewAllQuotesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAllQuotesGrid.Location = new System.Drawing.Point(12, 73);
            this.viewAllQuotesGrid.Name = "viewAllQuotesGrid";
            this.viewAllQuotesGrid.Size = new System.Drawing.Size(776, 291);
            this.viewAllQuotesGrid.TabIndex = 9;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewAllQuotesLabel);
            this.Controls.Add(this.viewAllQuotesGrid);
            this.Controls.Add(this.returnToMainBtn);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewAllQuotesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnToMainBtn;
        private System.Windows.Forms.Label viewAllQuotesLabel;
        private System.Windows.Forms.DataGridView viewAllQuotesGrid;
    }
}