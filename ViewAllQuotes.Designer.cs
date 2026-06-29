namespace MegaDeskDemo
{
    partial class ViewAllQuotes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            titleLabel = new Label();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            titleLabel.Location = new Point(24, 24);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(152, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "View All Quotes";
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(24, 76);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(95, 32);
            closeBtn.TabIndex = 1;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += CloseBtn_Click;
            // 
            // ViewAllQuotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 137);
            Controls.Add(closeBtn);
            Controls.Add(titleLabel);
            Name = "ViewAllQuotes";
            Text = "View All Quotes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Button closeBtn;
    }
}
