namespace TableEase
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.saveButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.tipLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.tableNumberLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.waiterLabel = new System.Windows.Forms.Label();
            this.nameTextLabel = new System.Windows.Forms.Label();
            this.dateTextLabel = new System.Windows.Forms.Label();
            this.tableTextLabel = new System.Windows.Forms.Label();
            this.taxTextLabel = new System.Windows.Forms.Label();
            this.totalTextLabel = new System.Windows.Forms.Label();
            this.waiterTextBox = new System.Windows.Forms.TextBox();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.tipTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // totalLabel
            // 
            resources.ApplyResources(this.totalLabel, "totalLabel");
            this.totalLabel.Name = "totalLabel";
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // taxLabel
            // 
            resources.ApplyResources(this.taxLabel, "taxLabel");
            this.taxLabel.Name = "taxLabel";
            // 
            // tipLabel
            // 
            resources.ApplyResources(this.tipLabel, "tipLabel");
            this.tipLabel.Name = "tipLabel";
            // 
            // dateLabel
            // 
            resources.ApplyResources(this.dateLabel, "dateLabel");
            this.dateLabel.Name = "dateLabel";
            // 
            // tableNumberLabel
            // 
            resources.ApplyResources(this.tableNumberLabel, "tableNumberLabel");
            this.tableNumberLabel.Name = "tableNumberLabel";
            // 
            // subtotalLabel
            // 
            resources.ApplyResources(this.subtotalLabel, "subtotalLabel");
            this.subtotalLabel.Name = "subtotalLabel";
            // 
            // waiterLabel
            // 
            resources.ApplyResources(this.waiterLabel, "waiterLabel");
            this.waiterLabel.Name = "waiterLabel";
            // 
            // nameTextLabel
            // 
            resources.ApplyResources(this.nameTextLabel, "nameTextLabel");
            this.nameTextLabel.Name = "nameTextLabel";
            // 
            // dateTextLabel
            // 
            resources.ApplyResources(this.dateTextLabel, "dateTextLabel");
            this.dateTextLabel.Name = "dateTextLabel";
            // 
            // tableTextLabel
            // 
            resources.ApplyResources(this.tableTextLabel, "tableTextLabel");
            this.tableTextLabel.Name = "tableTextLabel";
            // 
            // taxTextLabel
            // 
            resources.ApplyResources(this.taxTextLabel, "taxTextLabel");
            this.taxTextLabel.Name = "taxTextLabel";
            // 
            // totalTextLabel
            // 
            resources.ApplyResources(this.totalTextLabel, "totalTextLabel");
            this.totalTextLabel.Name = "totalTextLabel";
            // 
            // waiterTextBox
            // 
            resources.ApplyResources(this.waiterTextBox, "waiterTextBox");
            this.waiterTextBox.Name = "waiterTextBox";
            this.waiterTextBox.TextChanged += new System.EventHandler(this.waiterTextBox_TextChanged);
            // 
            // subTotalTextBox
            // 
            resources.ApplyResources(this.subTotalTextBox, "subTotalTextBox");
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.TextChanged += new System.EventHandler(this.subTotalTextBox_TextChanged);
            // 
            // tipTextBox
            // 
            resources.ApplyResources(this.tipTextBox, "tipTextBox");
            this.tipTextBox.Name = "tipTextBox";
            this.tipTextBox.TextChanged += new System.EventHandler(this.tipTextBox_TextChanged);
            // 
            // backButton
            // 
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Bill
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.tipTextBox);
            this.Controls.Add(this.subTotalTextBox);
            this.Controls.Add(this.waiterTextBox);
            this.Controls.Add(this.totalTextLabel);
            this.Controls.Add(this.taxTextLabel);
            this.Controls.Add(this.tableTextLabel);
            this.Controls.Add(this.dateTextLabel);
            this.Controls.Add(this.nameTextLabel);
            this.Controls.Add(this.waiterLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.tableNumberLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.saveButton);
            this.Name = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label tableNumberLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label waiterLabel;
        private System.Windows.Forms.Label nameTextLabel;
        private System.Windows.Forms.Label dateTextLabel;
        private System.Windows.Forms.Label tableTextLabel;
        private System.Windows.Forms.Label taxTextLabel;
        private System.Windows.Forms.Label totalTextLabel;
        private System.Windows.Forms.TextBox waiterTextBox;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.TextBox tipTextBox;
        private System.Windows.Forms.Button backButton;
    }
}