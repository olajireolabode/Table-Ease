namespace TableEase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.addButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.billingButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clockLabel = new System.Windows.Forms.Label();
            this.viewCommentButton = new System.Windows.Forms.Button();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.darkModeRadioButton = new System.Windows.Forms.RadioButton();
            this.lightModeRaidoButton = new System.Windows.Forms.RadioButton();
            this.closeButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.maxButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            resources.ApplyResources(this.addButton, "addButton");
            this.addButton.Name = "addButton";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // modifyButton
            // 
            resources.ApplyResources(this.modifyButton, "modifyButton");
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // billingButton
            // 
            resources.ApplyResources(this.billingButton, "billingButton");
            this.billingButton.Name = "billingButton";
            this.billingButton.UseVisualStyleBackColor = true;
            this.billingButton.Click += new System.EventHandler(this.billingButton_Click);
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clockLabel
            // 
            resources.ApplyResources(this.clockLabel, "clockLabel");
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Click += new System.EventHandler(this.clockLabel_Click);
            // 
            // viewCommentButton
            // 
            resources.ApplyResources(this.viewCommentButton, "viewCommentButton");
            this.viewCommentButton.Name = "viewCommentButton";
            this.viewCommentButton.UseVisualStyleBackColor = true;
            this.viewCommentButton.Click += new System.EventHandler(this.viewCommentButton_Click);
            // 
            // languageComboBox
            // 
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1"),
            resources.GetString("languageComboBox.Items2")});
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // darkModeRadioButton
            // 
            resources.ApplyResources(this.darkModeRadioButton, "darkModeRadioButton");
            this.darkModeRadioButton.Name = "darkModeRadioButton";
            this.darkModeRadioButton.TabStop = true;
            this.darkModeRadioButton.UseVisualStyleBackColor = true;
            this.darkModeRadioButton.CheckedChanged += new System.EventHandler(this.darkModeRadioButton_CheckedChanged);
            // 
            // lightModeRaidoButton
            // 
            resources.ApplyResources(this.lightModeRaidoButton, "lightModeRaidoButton");
            this.lightModeRaidoButton.Name = "lightModeRaidoButton";
            this.lightModeRaidoButton.TabStop = true;
            this.lightModeRaidoButton.UseVisualStyleBackColor = true;
            this.lightModeRaidoButton.CheckedChanged += new System.EventHandler(this.lightModeRaidoButton_CheckedChanged);
            // 
            // closeButton
            // 
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minButton
            // 
            resources.ApplyResources(this.minButton, "minButton");
            this.minButton.Name = "minButton";
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // maxButton
            // 
            resources.ApplyResources(this.maxButton, "maxButton");
            this.maxButton.Name = "maxButton";
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.maxButton);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.lightModeRaidoButton);
            this.Controls.Add(this.darkModeRadioButton);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.viewCommentButton);
            this.Controls.Add(this.clockLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.billingButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.addButton);
            this.Name = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button billingButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Button viewCommentButton;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.RadioButton darkModeRadioButton;
        private System.Windows.Forms.RadioButton lightModeRaidoButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button maxButton;
    }
}