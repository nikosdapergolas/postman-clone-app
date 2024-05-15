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
            formHeader = new Label();
            apiLabel = new Label();
            callApi = new Button();
            apiText = new TextBox();
            resultsText = new TextBox();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            resultsLabel = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formHeader.Location = new Point(53, 26);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(254, 47);
            formHeader.TabIndex = 0;
            formHeader.Text = "Postman Clone";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Location = new Point(53, 124);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(44, 25);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API:";
            // 
            // callApi
            // 
            callApi.Location = new Point(823, 120);
            callApi.Margin = new Padding(3, 2, 3, 2);
            callApi.Name = "callApi";
            callApi.Size = new Size(50, 33);
            callApi.TabIndex = 2;
            callApi.Text = "Go";
            callApi.UseVisualStyleBackColor = true;
            callApi.Click += callApi_Click;
            // 
            // apiText
            // 
            apiText.BackColor = Color.White;
            apiText.BorderStyle = BorderStyle.FixedSingle;
            apiText.Location = new Point(103, 120);
            apiText.Margin = new Padding(3, 2, 3, 2);
            apiText.Name = "apiText";
            apiText.Size = new Size(706, 33);
            apiText.TabIndex = 3;
            // 
            // resultsText
            // 
            resultsText.BackColor = Color.White;
            resultsText.BorderStyle = BorderStyle.FixedSingle;
            resultsText.Location = new Point(53, 225);
            resultsText.Margin = new Padding(3, 2, 3, 2);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(820, 327);
            resultsText.TabIndex = 4;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.BackColor = Color.White;
            statusStrip.Location = new Point(0, 564);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 12, 0);
            statusStrip.Size = new Size(923, 30);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "System Status";
            // 
            // systemStatus
            // 
            systemStatus.BackColor = Color.Transparent;
            systemStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(62, 25);
            systemStatus.Text = "Ready";
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(53, 182);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(74, 25);
            resultsLabel.TabIndex = 6;
            resultsLabel.Text = "Results:";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(923, 594);
            Controls.Add(resultsLabel);
            Controls.Add(statusStrip);
            Controls.Add(resultsText);
            Controls.Add(apiText);
            Controls.Add(callApi);
            Controls.Add(apiLabel);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Postman Clone By Nikos Dapergolas";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label apiLabel;
        private Button callApi;
        private TextBox apiText;
        private TextBox resultsText;
        private StatusStrip statusStrip;
        private Label resultsLabel;
        private ToolStripStatusLabel systemStatus;
    }
}
