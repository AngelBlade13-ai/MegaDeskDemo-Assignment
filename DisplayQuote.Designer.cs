namespace MegaDeskDemo
{
    partial class DisplayQuote
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
            customerNameLabel = new Label();
            customerNameValueLabel = new Label();
            quoteDateLabel = new Label();
            quoteDateValueLabel = new Label();
            widthLabel = new Label();
            widthValueLabel = new Label();
            depthLabel = new Label();
            depthValueLabel = new Label();
            drawersLabel = new Label();
            drawersValueLabel = new Label();
            totalSizeLabel = new Label();
            totalSizeValueLabel = new Label();
            materialLabel = new Label();
            materialValueLabel = new Label();
            deliveryLabel = new Label();
            deliveryValueLabel = new Label();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            titleLabel.Location = new Point(24, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(136, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Display Quote";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new Point(24, 67);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(94, 15);
            customerNameLabel.TabIndex = 1;
            customerNameLabel.Text = "Customer Name";
            // 
            // customerNameValueLabel
            // 
            customerNameValueLabel.AutoSize = true;
            customerNameValueLabel.Location = new Point(180, 67);
            customerNameValueLabel.Name = "customerNameValueLabel";
            customerNameValueLabel.Size = new Size(12, 15);
            customerNameValueLabel.TabIndex = 2;
            customerNameValueLabel.Text = "-";
            // 
            // quoteDateLabel
            // 
            quoteDateLabel.AutoSize = true;
            quoteDateLabel.Location = new Point(24, 97);
            quoteDateLabel.Name = "quoteDateLabel";
            quoteDateLabel.Size = new Size(65, 15);
            quoteDateLabel.TabIndex = 3;
            quoteDateLabel.Text = "Quote Date";
            // 
            // quoteDateValueLabel
            // 
            quoteDateValueLabel.AutoSize = true;
            quoteDateValueLabel.Location = new Point(180, 97);
            quoteDateValueLabel.Name = "quoteDateValueLabel";
            quoteDateValueLabel.Size = new Size(12, 15);
            quoteDateValueLabel.TabIndex = 4;
            quoteDateValueLabel.Text = "-";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(24, 127);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(39, 15);
            widthLabel.TabIndex = 5;
            widthLabel.Text = "Width";
            // 
            // widthValueLabel
            // 
            widthValueLabel.AutoSize = true;
            widthValueLabel.Location = new Point(180, 127);
            widthValueLabel.Name = "widthValueLabel";
            widthValueLabel.Size = new Size(12, 15);
            widthValueLabel.TabIndex = 6;
            widthValueLabel.Text = "-";
            // 
            // depthLabel
            // 
            depthLabel.AutoSize = true;
            depthLabel.Location = new Point(24, 157);
            depthLabel.Name = "depthLabel";
            depthLabel.Size = new Size(39, 15);
            depthLabel.TabIndex = 7;
            depthLabel.Text = "Depth";
            // 
            // depthValueLabel
            // 
            depthValueLabel.AutoSize = true;
            depthValueLabel.Location = new Point(180, 157);
            depthValueLabel.Name = "depthValueLabel";
            depthValueLabel.Size = new Size(12, 15);
            depthValueLabel.TabIndex = 8;
            depthValueLabel.Text = "-";
            // 
            // drawersLabel
            // 
            drawersLabel.AutoSize = true;
            drawersLabel.Location = new Point(24, 187);
            drawersLabel.Name = "drawersLabel";
            drawersLabel.Size = new Size(48, 15);
            drawersLabel.TabIndex = 9;
            drawersLabel.Text = "Drawers";
            // 
            // drawersValueLabel
            // 
            drawersValueLabel.AutoSize = true;
            drawersValueLabel.Location = new Point(180, 187);
            drawersValueLabel.Name = "drawersValueLabel";
            drawersValueLabel.Size = new Size(12, 15);
            drawersValueLabel.TabIndex = 10;
            drawersValueLabel.Text = "-";
            // 
            // totalSizeLabel
            // 
            totalSizeLabel.AutoSize = true;
            totalSizeLabel.Location = new Point(24, 217);
            totalSizeLabel.Name = "totalSizeLabel";
            totalSizeLabel.Size = new Size(76, 15);
            totalSizeLabel.TabIndex = 11;
            totalSizeLabel.Text = "Total Size in^2";
            // 
            // totalSizeValueLabel
            // 
            totalSizeValueLabel.AutoSize = true;
            totalSizeValueLabel.Location = new Point(180, 217);
            totalSizeValueLabel.Name = "totalSizeValueLabel";
            totalSizeValueLabel.Size = new Size(12, 15);
            totalSizeValueLabel.TabIndex = 12;
            totalSizeValueLabel.Text = "-";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new Point(24, 247);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new Size(76, 15);
            materialLabel.TabIndex = 13;
            materialLabel.Text = "Material Type";
            // 
            // materialValueLabel
            // 
            materialValueLabel.AutoSize = true;
            materialValueLabel.Location = new Point(180, 247);
            materialValueLabel.Name = "materialValueLabel";
            materialValueLabel.Size = new Size(12, 15);
            materialValueLabel.TabIndex = 14;
            materialValueLabel.Text = "-";
            // 
            // deliveryLabel
            // 
            deliveryLabel.AutoSize = true;
            deliveryLabel.Location = new Point(24, 277);
            deliveryLabel.Name = "deliveryLabel";
            deliveryLabel.Size = new Size(109, 15);
            deliveryLabel.TabIndex = 15;
            deliveryLabel.Text = "Order Delivery Time";
            // 
            // deliveryValueLabel
            // 
            deliveryValueLabel.AutoSize = true;
            deliveryValueLabel.Location = new Point(180, 277);
            deliveryValueLabel.Name = "deliveryValueLabel";
            deliveryValueLabel.Size = new Size(12, 15);
            deliveryValueLabel.TabIndex = 16;
            deliveryValueLabel.Text = "-";
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(180, 321);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(95, 32);
            closeBtn.TabIndex = 17;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += CloseBtn_Click;
            // 
            // DisplayQuote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 380);
            Controls.Add(closeBtn);
            Controls.Add(deliveryValueLabel);
            Controls.Add(deliveryLabel);
            Controls.Add(materialValueLabel);
            Controls.Add(materialLabel);
            Controls.Add(totalSizeValueLabel);
            Controls.Add(totalSizeLabel);
            Controls.Add(drawersValueLabel);
            Controls.Add(drawersLabel);
            Controls.Add(depthValueLabel);
            Controls.Add(depthLabel);
            Controls.Add(widthValueLabel);
            Controls.Add(widthLabel);
            Controls.Add(quoteDateValueLabel);
            Controls.Add(quoteDateLabel);
            Controls.Add(customerNameValueLabel);
            Controls.Add(customerNameLabel);
            Controls.Add(titleLabel);
            Name = "DisplayQuote";
            Text = "Display Quote";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label customerNameLabel;
        private Label customerNameValueLabel;
        private Label quoteDateLabel;
        private Label quoteDateValueLabel;
        private Label widthLabel;
        private Label widthValueLabel;
        private Label depthLabel;
        private Label depthValueLabel;
        private Label drawersLabel;
        private Label drawersValueLabel;
        private Label totalSizeLabel;
        private Label totalSizeValueLabel;
        private Label materialLabel;
        private Label materialValueLabel;
        private Label deliveryLabel;
        private Label deliveryValueLabel;
        private Button closeBtn;
    }
}
