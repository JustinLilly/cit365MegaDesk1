namespace MegaDesk___Lilly
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.exitBtn = new System.Windows.Forms.Button();
            this.searchQuotesBtn = new System.Windows.Forms.Button();
            this.viewQuoteBtn = new System.Windows.Forms.Button();
            this.addNewQuoteBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainMenuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(581, 366);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(175, 50);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // searchQuotesBtn
            // 
            this.searchQuotesBtn.Location = new System.Drawing.Point(400, 366);
            this.searchQuotesBtn.Name = "searchQuotesBtn";
            this.searchQuotesBtn.Size = new System.Drawing.Size(175, 50);
            this.searchQuotesBtn.TabIndex = 6;
            this.searchQuotesBtn.Text = "Search Quotes";
            this.searchQuotesBtn.UseVisualStyleBackColor = true;
            this.searchQuotesBtn.Click += new System.EventHandler(this.searchQuotesBtn_Click);
            // 
            // viewQuoteBtn
            // 
            this.viewQuoteBtn.Location = new System.Drawing.Point(219, 366);
            this.viewQuoteBtn.Name = "viewQuoteBtn";
            this.viewQuoteBtn.Size = new System.Drawing.Size(175, 50);
            this.viewQuoteBtn.TabIndex = 5;
            this.viewQuoteBtn.Text = "View Quotes";
            this.viewQuoteBtn.UseVisualStyleBackColor = true;
            this.viewQuoteBtn.Click += new System.EventHandler(this.viewQuoteBtn_Click);
            // 
            // addNewQuoteBtn
            // 
            this.addNewQuoteBtn.Location = new System.Drawing.Point(38, 366);
            this.addNewQuoteBtn.Name = "addNewQuoteBtn";
            this.addNewQuoteBtn.Size = new System.Drawing.Size(175, 50);
            this.addNewQuoteBtn.TabIndex = 4;
            this.addNewQuoteBtn.Text = "Add New Quote";
            this.addNewQuoteBtn.UseVisualStyleBackColor = true;
            this.addNewQuoteBtn.Click += new System.EventHandler(this.addNewQuoteBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 285);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // mainMenuLabel
            // 
            this.mainMenuLabel.AutoSize = true;
            this.mainMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLabel.Location = new System.Drawing.Point(282, 24);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(211, 24);
            this.mainMenuLabel.TabIndex = 9;
            this.mainMenuLabel.Text = "Welcome to Mega Desk";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenuLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.searchQuotesBtn);
            this.Controls.Add(this.viewQuoteBtn);
            this.Controls.Add(this.addNewQuoteBtn);
            this.Name = "MainMenu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button searchQuotesBtn;
        private System.Windows.Forms.Button viewQuoteBtn;
        private System.Windows.Forms.Button addNewQuoteBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label mainMenuLabel;
    }
}

