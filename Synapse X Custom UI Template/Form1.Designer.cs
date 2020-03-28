namespace Synapse_X_Custom_UI_Template
{
    partial class Form1
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
            this.statusLabel = new System.Windows.Forms.Label();
            this.executeButton = new System.Windows.Forms.Button();
            this.attachButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.changeSynapseDirButton = new System.Windows.Forms.Button();
            this.scriptHubPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SHtitleLabel = new System.Windows.Forms.Label();
            this.SHdescLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.statusLabel.Location = new System.Drawing.Point(12, 9);
            this.statusLabel.MaximumSize = new System.Drawing.Size(200, 30);
            this.statusLabel.MinimumSize = new System.Drawing.Size(200, 30);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(200, 30);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Status:";
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(12, 305);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(115, 44);
            this.executeButton.TabIndex = 1;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // attachButton
            // 
            this.attachButton.Location = new System.Drawing.Point(257, 305);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(115, 44);
            this.attachButton.TabIndex = 2;
            this.attachButton.Text = "Attach";
            this.attachButton.UseVisualStyleBackColor = true;
            this.attachButton.Click += new System.EventHandler(this.attachButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(360, 257);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // changeSynapseDirButton
            // 
            this.changeSynapseDirButton.Location = new System.Drawing.Point(243, 9);
            this.changeSynapseDirButton.Name = "changeSynapseDirButton";
            this.changeSynapseDirButton.Size = new System.Drawing.Size(129, 28);
            this.changeSynapseDirButton.TabIndex = 4;
            this.changeSynapseDirButton.Text = "Change Synapse Dir";
            this.changeSynapseDirButton.UseVisualStyleBackColor = true;
            this.changeSynapseDirButton.Click += new System.EventHandler(this.changeSynapseDirButton_Click);
            // 
            // scriptHubPanel
            // 
            this.scriptHubPanel.AutoScroll = true;
            this.scriptHubPanel.ColumnCount = 2;
            this.scriptHubPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scriptHubPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scriptHubPanel.Location = new System.Drawing.Point(379, 9);
            this.scriptHubPanel.Name = "scriptHubPanel";
            this.scriptHubPanel.RowCount = 4;
            this.scriptHubPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.scriptHubPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.scriptHubPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.scriptHubPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.scriptHubPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.scriptHubPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.scriptHubPanel.Size = new System.Drawing.Size(143, 243);
            this.scriptHubPanel.TabIndex = 5;
            // 
            // SHtitleLabel
            // 
            this.SHtitleLabel.AutoSize = true;
            this.SHtitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SHtitleLabel.Location = new System.Drawing.Point(379, 259);
            this.SHtitleLabel.MaximumSize = new System.Drawing.Size(143, 13);
            this.SHtitleLabel.MinimumSize = new System.Drawing.Size(143, 13);
            this.SHtitleLabel.Name = "SHtitleLabel";
            this.SHtitleLabel.Size = new System.Drawing.Size(143, 13);
            this.SHtitleLabel.TabIndex = 6;
            // 
            // SHdescLabel
            // 
            this.SHdescLabel.AutoSize = true;
            this.SHdescLabel.Location = new System.Drawing.Point(378, 282);
            this.SHdescLabel.MaximumSize = new System.Drawing.Size(143, 75);
            this.SHdescLabel.MinimumSize = new System.Drawing.Size(143, 75);
            this.SHdescLabel.Name = "SHdescLabel";
            this.SHdescLabel.Size = new System.Drawing.Size(143, 75);
            this.SHdescLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.SHdescLabel);
            this.Controls.Add(this.SHtitleLabel);
            this.Controls.Add(this.scriptHubPanel);
            this.Controls.Add(this.changeSynapseDirButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.attachButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.statusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "Form1";
            this.Text = "Synapse X Custom UI Template";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button attachButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button changeSynapseDirButton;
        private System.Windows.Forms.TableLayoutPanel scriptHubPanel;
        private System.Windows.Forms.Label SHtitleLabel;
        private System.Windows.Forms.Label SHdescLabel;
    }
}

