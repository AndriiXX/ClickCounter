namespace ClickCounter
{
    partial class Form1
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
            clickCountLabel = new Label();
            SuspendLayout();
            // 
            // clickCountLabel
            // 
            clickCountLabel.AutoSize = true;
            clickCountLabel.BorderStyle = BorderStyle.FixedSingle;
            clickCountLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clickCountLabel.Location = new Point(314, 192);
            clickCountLabel.Name = "clickCountLabel";
            clickCountLabel.Size = new Size(150, 27);
            clickCountLabel.TabIndex = 0;
            clickCountLabel.Text = "Mouse Clicks: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clickCountLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label clickCountLabel;
    }
}
