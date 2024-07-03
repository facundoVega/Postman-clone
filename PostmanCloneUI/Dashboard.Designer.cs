namespace PostmanCloneUI
{
    partial class Dashboard
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
            this.formHeader = new System.Windows.Forms.Label();
            this.apiLabel = new System.Windows.Forms.Label();
            this.apiText = new System.Windows.Forms.TextBox();
            this.callApi = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.systemStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.httpVerbSelection = new System.Windows.Forms.ComboBox();
            this.callData = new System.Windows.Forms.TabControl();
            this.bodyTab = new System.Windows.Forms.TabPage();
            this.bodyText = new System.Windows.Forms.TextBox();
            this.resultsTab = new System.Windows.Forms.TabPage();
            this.resultsText = new System.Windows.Forms.TextBox();
            this.statusStrip.SuspendLayout();
            this.callData.SuspendLayout();
            this.bodyTab.SuspendLayout();
            this.resultsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // formHeader
            // 
            this.formHeader.AutoSize = true;
            this.formHeader.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formHeader.Location = new System.Drawing.Point(11, 9);
            this.formHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.formHeader.Name = "formHeader";
            this.formHeader.Size = new System.Drawing.Size(372, 70);
            this.formHeader.TabIndex = 0;
            this.formHeader.Text = "Postman Clone";
            // 
            // apiLabel
            // 
            this.apiLabel.AutoSize = true;
            this.apiLabel.Location = new System.Drawing.Point(31, 87);
            this.apiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apiLabel.Name = "apiLabel";
            this.apiLabel.Size = new System.Drawing.Size(64, 38);
            this.apiLabel.TabIndex = 1;
            this.apiLabel.Text = "API:";
            // 
            // apiText
            // 
            this.apiText.Location = new System.Drawing.Point(236, 88);
            this.apiText.Margin = new System.Windows.Forms.Padding(2);
            this.apiText.Name = "apiText";
            this.apiText.Size = new System.Drawing.Size(635, 45);
            this.apiText.TabIndex = 2;
            // 
            // callApi
            // 
            this.callApi.Location = new System.Drawing.Point(875, 87);
            this.callApi.Margin = new System.Windows.Forms.Padding(2);
            this.callApi.Name = "callApi";
            this.callApi.Size = new System.Drawing.Size(82, 45);
            this.callApi.TabIndex = 3;
            this.callApi.Text = "Go";
            this.callApi.UseVisualStyleBackColor = true;
            this.callApi.Click += new System.EventHandler(this.callApi_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 553);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip.Size = new System.Drawing.Size(968, 45);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "Ready";
            // 
            // systemStatus
            // 
            this.systemStatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.systemStatus.Name = "systemStatus";
            this.systemStatus.Size = new System.Drawing.Size(92, 38);
            this.systemStatus.Text = "Ready";
            // 
            // httpVerbSelection
            // 
            this.httpVerbSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.httpVerbSelection.FormattingEnabled = true;
            this.httpVerbSelection.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.httpVerbSelection.Location = new System.Drawing.Point(100, 87);
            this.httpVerbSelection.Name = "httpVerbSelection";
            this.httpVerbSelection.Size = new System.Drawing.Size(131, 46);
            this.httpVerbSelection.TabIndex = 7;
            // 
            // callData
            // 
            this.callData.Controls.Add(this.bodyTab);
            this.callData.Controls.Add(this.resultsTab);
            this.callData.Location = new System.Drawing.Point(31, 156);
            this.callData.Name = "callData";
            this.callData.SelectedIndex = 0;
            this.callData.Size = new System.Drawing.Size(925, 366);
            this.callData.TabIndex = 8;
            // 
            // bodyTab
            // 
            this.bodyTab.Controls.Add(this.bodyText);
            this.bodyTab.Location = new System.Drawing.Point(4, 47);
            this.bodyTab.Name = "bodyTab";
            this.bodyTab.Padding = new System.Windows.Forms.Padding(3);
            this.bodyTab.Size = new System.Drawing.Size(917, 315);
            this.bodyTab.TabIndex = 0;
            this.bodyTab.Text = "Body";
            this.bodyTab.UseVisualStyleBackColor = true;
            // 
            // bodyText
            // 
            this.bodyText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyText.Location = new System.Drawing.Point(3, 3);
            this.bodyText.Margin = new System.Windows.Forms.Padding(2);
            this.bodyText.Multiline = true;
            this.bodyText.Name = "bodyText";
            this.bodyText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.bodyText.Size = new System.Drawing.Size(911, 309);
            this.bodyText.TabIndex = 5;
            // 
            // resultsTab
            // 
            this.resultsTab.Controls.Add(this.resultsText);
            this.resultsTab.Location = new System.Drawing.Point(4, 47);
            this.resultsTab.Name = "resultsTab";
            this.resultsTab.Padding = new System.Windows.Forms.Padding(3);
            this.resultsTab.Size = new System.Drawing.Size(917, 315);
            this.resultsTab.TabIndex = 1;
            this.resultsTab.Text = "Results";
            this.resultsTab.UseVisualStyleBackColor = true;
            // 
            // resultsText
            // 
            this.resultsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsText.Location = new System.Drawing.Point(3, 3);
            this.resultsText.Margin = new System.Windows.Forms.Padding(2);
            this.resultsText.Multiline = true;
            this.resultsText.Name = "resultsText";
            this.resultsText.ReadOnly = true;
            this.resultsText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultsText.Size = new System.Drawing.Size(911, 309);
            this.resultsText.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 598);
            this.Controls.Add(this.callData);
            this.Controls.Add(this.httpVerbSelection);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.callApi);
            this.Controls.Add(this.apiText);
            this.Controls.Add(this.apiLabel);
            this.Controls.Add(this.formHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Dashboard";
            this.Text = "Postman Clone";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.callData.ResumeLayout(false);
            this.bodyTab.ResumeLayout(false);
            this.bodyTab.PerformLayout();
            this.resultsTab.ResumeLayout(false);
            this.resultsTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label formHeader;
        private Label apiLabel;
        private TextBox apiText;
        private Button callApi;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel systemStatus;
        private ComboBox httpVerbSelection;
        private TabControl callData;
        private TabPage bodyTab;
        private TabPage resultsTab;
        private TextBox bodyText;
        private TextBox resultsText;
    }
}