
namespace PDFDecompiler
{
    partial class MainForm
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
            this.BrowseSourceBtn = new System.Windows.Forms.Button();
            this.SourceTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DestinationTB = new System.Windows.Forms.TextBox();
            this.BrowseDestinationBtn = new System.Windows.Forms.Button();
            this.ExtractBtn = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.flipTextCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BrowseSourceBtn
            // 
            this.BrowseSourceBtn.Location = new System.Drawing.Point(359, 12);
            this.BrowseSourceBtn.Name = "BrowseSourceBtn";
            this.BrowseSourceBtn.Size = new System.Drawing.Size(75, 23);
            this.BrowseSourceBtn.TabIndex = 0;
            this.BrowseSourceBtn.Text = "Browse";
            this.BrowseSourceBtn.UseVisualStyleBackColor = true;
            this.BrowseSourceBtn.Click += new System.EventHandler(this.BrowseSourceBtn_Click);
            // 
            // SourceTB
            // 
            this.SourceTB.Location = new System.Drawing.Point(131, 12);
            this.SourceTB.Name = "SourceTB";
            this.SourceTB.Size = new System.Drawing.Size(222, 23);
            this.SourceTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source (PDF)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination (folder)";
            // 
            // DestinationTB
            // 
            this.DestinationTB.Location = new System.Drawing.Point(131, 45);
            this.DestinationTB.Name = "DestinationTB";
            this.DestinationTB.Size = new System.Drawing.Size(222, 23);
            this.DestinationTB.TabIndex = 4;
            // 
            // BrowseDestinationBtn
            // 
            this.BrowseDestinationBtn.Location = new System.Drawing.Point(359, 45);
            this.BrowseDestinationBtn.Name = "BrowseDestinationBtn";
            this.BrowseDestinationBtn.Size = new System.Drawing.Size(75, 23);
            this.BrowseDestinationBtn.TabIndex = 5;
            this.BrowseDestinationBtn.Text = "Browse";
            this.BrowseDestinationBtn.UseVisualStyleBackColor = true;
            this.BrowseDestinationBtn.Click += new System.EventHandler(this.BrowseDestinationBtn_Click);
            // 
            // ExtractBtn
            // 
            this.ExtractBtn.Location = new System.Drawing.Point(12, 115);
            this.ExtractBtn.Name = "ExtractBtn";
            this.ExtractBtn.Size = new System.Drawing.Size(75, 23);
            this.ExtractBtn.TabIndex = 6;
            this.ExtractBtn.Text = "Do it!";
            this.ExtractBtn.UseVisualStyleBackColor = true;
            this.ExtractBtn.Click += new System.EventHandler(this.ExtractBtn_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(93, 119);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(0, 15);
            this.OutputLabel.TabIndex = 7;
            // 
            // flipTextCheckBox
            // 
            this.flipTextCheckBox.AutoSize = true;
            this.flipTextCheckBox.Location = new System.Drawing.Point(12, 79);
            this.flipTextCheckBox.Name = "flipTextCheckBox";
            this.flipTextCheckBox.Size = new System.Drawing.Size(136, 19);
            this.flipTextCheckBox.TabIndex = 8;
            this.flipTextCheckBox.Text = "Flip text (for hebrew)";
            this.flipTextCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 150);
            this.Controls.Add(this.flipTextCheckBox);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.ExtractBtn);
            this.Controls.Add(this.BrowseDestinationBtn);
            this.Controls.Add(this.DestinationTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SourceTB);
            this.Controls.Add(this.BrowseSourceBtn);
            this.Name = "MainForm";
            this.Text = "PDF Decompiler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseSourceBtn;
        private System.Windows.Forms.TextBox SourceTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DestinationTB;
        private System.Windows.Forms.Button BrowseDestinationBtn;
        private System.Windows.Forms.Button ExtractBtn;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.CheckBox flipTextCheckBox;
    }
}