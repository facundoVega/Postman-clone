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
            this.resultsText = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.systemStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
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
            this.apiLabel.Location = new System.Drawing.Point(28, 91);
            this.apiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apiLabel.Name = "apiLabel";
            this.apiLabel.Size = new System.Drawing.Size(64, 38);
            this.apiLabel.TabIndex = 1;
            this.apiLabel.Text = "API:";
            // 
            // apiText
            // 
            this.apiText.Location = new System.Drawing.Point(96, 88);
            this.apiText.Margin = new System.Windows.Forms.Padding(2);
            this.apiText.Name = "apiText";
            this.apiText.Size = new System.Drawing.Size(718, 45);
            this.apiText.TabIndex = 2;
            // 
            // callApi
            // 
            this.callApi.Location = new System.Drawing.Point(818, 88);
            this.callApi.Margin = new System.Windows.Forms.Padding(2);
            this.callApi.Name = "callApi";
            this.callApi.Size = new System.Drawing.Size(82, 45);
            this.callApi.TabIndex = 3;
            this.callApi.Text = "Go";
            this.callApi.UseVisualStyleBackColor = true;
            this.callApi.Click += new System.EventHandler(this.callApi_Click);
            // 
            // resultsText
            // 
            this.resultsText.Location = new System.Drawing.Point(28, 190);
            this.resultsText.Margin = new System.Windows.Forms.Padding(2);
            this.resultsText.Multiline = true;
            this.resultsText.Name = "resultsText";
            this.resultsText.ReadOnly = true;
            this.resultsText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultsText.Size = new System.Drawing.Size(872, 346);
            this.resultsText.TabIndex = 4;
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
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(12, 150);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(112, 38);
            this.resultsLabel.TabIndex = 6;
            this.resultsLabel.Text = " Results";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 598);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.resultsText);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label formHeader;
        private Label apiLabel;
        private TextBox apiText;
        private Button callApi;
        private TextBox resultsText;
        private StatusStrip statusStrip;
        private Label resultsLabel;
        private ToolStripStatusLabel systemStatus;
    }
}