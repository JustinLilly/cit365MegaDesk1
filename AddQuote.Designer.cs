namespace MegaDesk___Lilly
{
    partial class AddQuote
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
            this.quoteDateLabel = new System.Windows.Forms.Label();
            this.numDrawRestrictLabel = new System.Windows.Forms.Label();
            this.depthRestrictionLabel = new System.Windows.Forms.Label();
            this.widthRestricionLabel = new System.Windows.Forms.Label();
            this.addQuoteCancelBtn = new System.Windows.Forms.Button();
            this.addQuoteBtn = new System.Windows.Forms.Button();
            this.depthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthBox = new System.Windows.Forms.NumericUpDown();
            this.widthBox = new System.Windows.Forms.NumericUpDown();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.rushBox = new System.Windows.Forms.ComboBox();
            this.rushLabel = new System.Windows.Forms.Label();
            this.deskMatLabel = new System.Windows.Forms.Label();
            this.numDrawLabel = new System.Windows.Forms.Label();
            this.numDrawBox = new System.Windows.Forms.NumericUpDown();
            this.addNewLabel = new System.Windows.Forms.Label();
            this.WidthWarning = new System.Windows.Forms.Label();
            this.DepthWarning = new System.Windows.Forms.Label();
            this.NumDrawersWarning = new System.Windows.Forms.Label();
            this.deskMatBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.depthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawBox)).BeginInit();
            this.SuspendLayout();
            // 
            // quoteDateLabel
            // 
            this.quoteDateLabel.AutoSize = true;
            this.quoteDateLabel.Location = new System.Drawing.Point(40, 411);
            this.quoteDateLabel.Name = "quoteDateLabel";
            this.quoteDateLabel.Size = new System.Drawing.Size(57, 13);
            this.quoteDateLabel.TabIndex = 40;
            this.quoteDateLabel.Text = "quoteDate";
            // 
            // numDrawRestrictLabel
            // 
            this.numDrawRestrictLabel.AutoSize = true;
            this.numDrawRestrictLabel.ForeColor = System.Drawing.Color.Blue;
            this.numDrawRestrictLabel.Location = new System.Drawing.Point(233, 266);
            this.numDrawRestrictLabel.Name = "numDrawRestrictLabel";
            this.numDrawRestrictLabel.Size = new System.Drawing.Size(79, 13);
            this.numDrawRestrictLabel.TabIndex = 39;
            this.numDrawRestrictLabel.Text = "Max: 7 drawers";
            this.numDrawRestrictLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depthRestrictionLabel
            // 
            this.depthRestrictionLabel.AutoSize = true;
            this.depthRestrictionLabel.ForeColor = System.Drawing.Color.Blue;
            this.depthRestrictionLabel.Location = new System.Drawing.Point(201, 214);
            this.depthRestrictionLabel.Name = "depthRestrictionLabel";
            this.depthRestrictionLabel.Size = new System.Drawing.Size(111, 13);
            this.depthRestrictionLabel.TabIndex = 38;
            this.depthRestrictionLabel.Text = "Min: 12\" and Max 48\"";
            this.depthRestrictionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // widthRestricionLabel
            // 
            this.widthRestricionLabel.AutoSize = true;
            this.widthRestricionLabel.ForeColor = System.Drawing.Color.Blue;
            this.widthRestricionLabel.Location = new System.Drawing.Point(201, 160);
            this.widthRestricionLabel.Name = "widthRestricionLabel";
            this.widthRestricionLabel.Size = new System.Drawing.Size(111, 13);
            this.widthRestricionLabel.TabIndex = 36;
            this.widthRestricionLabel.Text = "Min: 24\" and Max 96\"";
            this.widthRestricionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addQuoteCancelBtn
            // 
            this.addQuoteCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteCancelBtn.Location = new System.Drawing.Point(468, 333);
            this.addQuoteCancelBtn.Name = "addQuoteCancelBtn";
            this.addQuoteCancelBtn.Size = new System.Drawing.Size(175, 50);
            this.addQuoteCancelBtn.TabIndex = 30;
            this.addQuoteCancelBtn.Text = "Cancel";
            this.addQuoteCancelBtn.UseVisualStyleBackColor = true;
            this.addQuoteCancelBtn.Click += new System.EventHandler(this.addQuoteCancelBtn_Click);
            // 
            // addQuoteBtn
            // 
            this.addQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteBtn.Location = new System.Drawing.Point(218, 333);
            this.addQuoteBtn.Name = "addQuoteBtn";
            this.addQuoteBtn.Size = new System.Drawing.Size(175, 50);
            this.addQuoteBtn.TabIndex = 28;
            this.addQuoteBtn.Text = "Submit";
            this.addQuoteBtn.UseVisualStyleBackColor = true;
            this.addQuoteBtn.Click += new System.EventHandler(this.addQuoteBtn_Click);
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(130, 191);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(53, 20);
            this.depthLabel.TabIndex = 33;
            this.depthLabel.Text = "Depth";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(133, 137);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(50, 20);
            this.widthLabel.TabIndex = 32;
            this.widthLabel.Text = "Width";
            // 
            // depthBox
            // 
            this.depthBox.Location = new System.Drawing.Point(192, 191);
            this.depthBox.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthBox.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(120, 20);
            this.depthBox.TabIndex = 24;
            this.depthBox.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthBox.ValueChanged += new System.EventHandler(this.depthBox_ValueChanged);
            this.depthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthBox_KeyPress);
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(192, 137);
            this.widthBox.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthBox.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(120, 20);
            this.widthBox.TabIndex = 23;
            this.widthBox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthBox.ValueChanged += new System.EventHandler(this.widthBox_ValueChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(288, 78);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(276, 20);
            this.nameBox.TabIndex = 22;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(226, 78);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 29;
            this.nameLabel.Text = "Name";
            // 
            // rushBox
            // 
            this.rushBox.DisplayMember = "3";
            this.rushBox.FormattingEnabled = true;
            this.rushBox.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "14"});
            this.rushBox.Location = new System.Drawing.Point(578, 193);
            this.rushBox.Name = "rushBox";
            this.rushBox.Size = new System.Drawing.Size(121, 21);
            this.rushBox.TabIndex = 27;
            // 
            // rushLabel
            // 
            this.rushLabel.AutoSize = true;
            this.rushLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushLabel.Location = new System.Drawing.Point(485, 194);
            this.rushLabel.Name = "rushLabel";
            this.rushLabel.Size = new System.Drawing.Size(87, 20);
            this.rushLabel.TabIndex = 34;
            this.rushLabel.Text = "Rush Days";
            // 
            // deskMatLabel
            // 
            this.deskMatLabel.AutoSize = true;
            this.deskMatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskMatLabel.Location = new System.Drawing.Point(443, 140);
            this.deskMatLabel.Name = "deskMatLabel";
            this.deskMatLabel.Size = new System.Drawing.Size(129, 20);
            this.deskMatLabel.TabIndex = 31;
            this.deskMatLabel.Text = "Desktop Material";
            // 
            // numDrawLabel
            // 
            this.numDrawLabel.AutoSize = true;
            this.numDrawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawLabel.Location = new System.Drawing.Point(37, 243);
            this.numDrawLabel.Name = "numDrawLabel";
            this.numDrawLabel.Size = new System.Drawing.Size(146, 20);
            this.numDrawLabel.TabIndex = 37;
            this.numDrawLabel.Text = "Number of Drawers";
            // 
            // numDrawBox
            // 
            this.numDrawBox.Location = new System.Drawing.Point(192, 243);
            this.numDrawBox.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numDrawBox.Name = "numDrawBox";
            this.numDrawBox.Size = new System.Drawing.Size(120, 20);
            this.numDrawBox.TabIndex = 25;
            this.numDrawBox.ValueChanged += new System.EventHandler(this.numDrawBox_ValueChanged);
            // 
            // addNewLabel
            // 
            this.addNewLabel.AutoSize = true;
            this.addNewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewLabel.Location = new System.Drawing.Point(330, 9);
            this.addNewLabel.Name = "addNewLabel";
            this.addNewLabel.Size = new System.Drawing.Size(143, 31);
            this.addNewLabel.TabIndex = 35;
            this.addNewLabel.Text = "Add Quote";
            // 
            // WidthWarning
            // 
            this.WidthWarning.AutoSize = true;
            this.WidthWarning.Location = new System.Drawing.Point(318, 142);
            this.WidthWarning.Name = "WidthWarning";
            this.WidthWarning.Size = new System.Drawing.Size(0, 13);
            this.WidthWarning.TabIndex = 41;
            // 
            // DepthWarning
            // 
            this.DepthWarning.AutoSize = true;
            this.DepthWarning.Location = new System.Drawing.Point(318, 194);
            this.DepthWarning.Name = "DepthWarning";
            this.DepthWarning.Size = new System.Drawing.Size(0, 13);
            this.DepthWarning.TabIndex = 42;
            // 
            // NumDrawersWarning
            // 
            this.NumDrawersWarning.AutoSize = true;
            this.NumDrawersWarning.Location = new System.Drawing.Point(318, 250);
            this.NumDrawersWarning.Name = "NumDrawersWarning";
            this.NumDrawersWarning.Size = new System.Drawing.Size(0, 13);
            this.NumDrawersWarning.TabIndex = 43;
            // 
            // deskMatBox
            // 
            this.deskMatBox.FormattingEnabled = true;
            this.deskMatBox.Location = new System.Drawing.Point(578, 139);
            this.deskMatBox.Name = "deskMatBox";
            this.deskMatBox.Size = new System.Drawing.Size(121, 21);
            this.deskMatBox.TabIndex = 26;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumDrawersWarning);
            this.Controls.Add(this.DepthWarning);
            this.Controls.Add(this.WidthWarning);
            this.Controls.Add(this.quoteDateLabel);
            this.Controls.Add(this.numDrawRestrictLabel);
            this.Controls.Add(this.depthRestrictionLabel);
            this.Controls.Add(this.widthRestricionLabel);
            this.Controls.Add(this.addQuoteCancelBtn);
            this.Controls.Add(this.addQuoteBtn);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.depthBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.rushBox);
            this.Controls.Add(this.rushLabel);
            this.Controls.Add(this.deskMatLabel);
            this.Controls.Add(this.numDrawLabel);
            this.Controls.Add(this.numDrawBox);
            this.Controls.Add(this.addNewLabel);
            this.Controls.Add(this.deskMatBox);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quoteDateLabel;
        private System.Windows.Forms.Label numDrawRestrictLabel;
        private System.Windows.Forms.Label depthRestrictionLabel;
        private System.Windows.Forms.Label widthRestricionLabel;
        private System.Windows.Forms.Button addQuoteCancelBtn;
        private System.Windows.Forms.Button addQuoteBtn;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.NumericUpDown depthBox;
        private System.Windows.Forms.NumericUpDown widthBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox rushBox;
        private System.Windows.Forms.Label rushLabel;
        private System.Windows.Forms.Label deskMatLabel;
        private System.Windows.Forms.Label numDrawLabel;
        private System.Windows.Forms.NumericUpDown numDrawBox;
        private System.Windows.Forms.Label addNewLabel;
        private System.Windows.Forms.Label WidthWarning;
        private System.Windows.Forms.Label DepthWarning;
        private System.Windows.Forms.Label NumDrawersWarning;
        private System.Windows.Forms.ComboBox deskMatBox;
    }
}