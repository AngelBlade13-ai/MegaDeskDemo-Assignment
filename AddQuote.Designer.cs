namespace MegaDeskDemo
{
    partial class AddQuote
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
            customerNameLabel = new Label();
            customerNameTextBox = new TextBox();
            quoteDateLabel = new Label();
            quoteDatePicker = new DateTimePicker();
            widthLabel = new Label();
            widthNumericUpDown = new NumericUpDown();
            depthLabel = new Label();
            depthNumericUpDown = new NumericUpDown();
            drawersLabel = new Label();
            drawersNumericUpDown = new NumericUpDown();
            materialLabel = new Label();
            materialComboBox = new ComboBox();
            deliveryLabel = new Label();
            deliveryComboBox = new ComboBox();
            submitQuoteBtn = new Button();
            cancelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)widthNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)depthNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)drawersNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new Point(24, 24);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(94, 15);
            customerNameLabel.TabIndex = 0;
            customerNameLabel.Text = "Customer Name";
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Location = new Point(158, 21);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.Size = new Size(200, 23);
            customerNameTextBox.TabIndex = 1;
            // 
            // quoteDateLabel
            // 
            quoteDateLabel.AutoSize = true;
            quoteDateLabel.Location = new Point(24, 62);
            quoteDateLabel.Name = "quoteDateLabel";
            quoteDateLabel.Size = new Size(65, 15);
            quoteDateLabel.TabIndex = 2;
            quoteDateLabel.Text = "Quote Date";
            // 
            // quoteDatePicker
            // 
            quoteDatePicker.Format = DateTimePickerFormat.Short;
            quoteDatePicker.Location = new Point(158, 56);
            quoteDatePicker.Name = "quoteDatePicker";
            quoteDatePicker.Size = new Size(200, 23);
            quoteDatePicker.TabIndex = 3;
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(24, 101);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(39, 15);
            widthLabel.TabIndex = 4;
            widthLabel.Text = "Width";
            // 
            // widthNumericUpDown
            // 
            widthNumericUpDown.Location = new Point(158, 99);
            widthNumericUpDown.Maximum = new decimal(new int[] { 96, 0, 0, 0 });
            widthNumericUpDown.Minimum = new decimal(new int[] { 24, 0, 0, 0 });
            widthNumericUpDown.Name = "widthNumericUpDown";
            widthNumericUpDown.Size = new Size(200, 23);
            widthNumericUpDown.TabIndex = 5;
            widthNumericUpDown.Value = new decimal(new int[] { 24, 0, 0, 0 });
            // 
            // depthLabel
            // 
            depthLabel.AutoSize = true;
            depthLabel.Location = new Point(24, 139);
            depthLabel.Name = "depthLabel";
            depthLabel.Size = new Size(39, 15);
            depthLabel.TabIndex = 6;
            depthLabel.Text = "Depth";
            // 
            // depthNumericUpDown
            // 
            depthNumericUpDown.Location = new Point(158, 137);
            depthNumericUpDown.Maximum = new decimal(new int[] { 48, 0, 0, 0 });
            depthNumericUpDown.Minimum = new decimal(new int[] { 12, 0, 0, 0 });
            depthNumericUpDown.Name = "depthNumericUpDown";
            depthNumericUpDown.Size = new Size(200, 23);
            depthNumericUpDown.TabIndex = 7;
            depthNumericUpDown.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // drawersLabel
            // 
            drawersLabel.AutoSize = true;
            drawersLabel.Location = new Point(24, 177);
            drawersLabel.Name = "drawersLabel";
            drawersLabel.Size = new Size(48, 15);
            drawersLabel.TabIndex = 8;
            drawersLabel.Text = "Drawers";
            // 
            // drawersNumericUpDown
            // 
            drawersNumericUpDown.Location = new Point(158, 175);
            drawersNumericUpDown.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            drawersNumericUpDown.Name = "drawersNumericUpDown";
            drawersNumericUpDown.Size = new Size(200, 23);
            drawersNumericUpDown.TabIndex = 9;
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new Point(24, 215);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new Size(76, 15);
            materialLabel.TabIndex = 10;
            materialLabel.Text = "Material Type";
            // 
            // materialComboBox
            // 
            materialComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox.FormattingEnabled = true;
            materialComboBox.Items.AddRange(new object[] { "Laminate", "Oak", "Rosewood", "Veneer", "Pine" });
            materialComboBox.Location = new Point(158, 212);
            materialComboBox.Name = "materialComboBox";
            materialComboBox.Size = new Size(200, 23);
            materialComboBox.TabIndex = 11;
            // 
            // deliveryLabel
            // 
            deliveryLabel.AutoSize = true;
            deliveryLabel.Location = new Point(24, 253);
            deliveryLabel.Name = "deliveryLabel";
            deliveryLabel.Size = new Size(109, 15);
            deliveryLabel.TabIndex = 12;
            deliveryLabel.Text = "Order Delivery Time";
            // 
            // deliveryComboBox
            // 
            deliveryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            deliveryComboBox.FormattingEnabled = true;
            deliveryComboBox.Items.AddRange(new object[] { "3 Days", "5 Days", "7 Days", "14 Days" });
            deliveryComboBox.Location = new Point(158, 250);
            deliveryComboBox.Name = "deliveryComboBox";
            deliveryComboBox.Size = new Size(200, 23);
            deliveryComboBox.TabIndex = 13;
            // 
            // submitQuoteBtn
            // 
            submitQuoteBtn.Location = new Point(158, 297);
            submitQuoteBtn.Name = "submitQuoteBtn";
            submitQuoteBtn.Size = new Size(95, 32);
            submitQuoteBtn.TabIndex = 14;
            submitQuoteBtn.Text = "Submit";
            submitQuoteBtn.UseVisualStyleBackColor = true;
            submitQuoteBtn.Click += SubmitQuoteBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(263, 297);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(95, 32);
            cancelBtn.TabIndex = 15;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += CancelBtn_Click;
            // 
            // AddQuote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 356);
            Controls.Add(cancelBtn);
            Controls.Add(submitQuoteBtn);
            Controls.Add(deliveryComboBox);
            Controls.Add(deliveryLabel);
            Controls.Add(materialComboBox);
            Controls.Add(materialLabel);
            Controls.Add(drawersNumericUpDown);
            Controls.Add(drawersLabel);
            Controls.Add(depthNumericUpDown);
            Controls.Add(depthLabel);
            Controls.Add(widthNumericUpDown);
            Controls.Add(widthLabel);
            Controls.Add(quoteDatePicker);
            Controls.Add(quoteDateLabel);
            Controls.Add(customerNameTextBox);
            Controls.Add(customerNameLabel);
            Name = "AddQuote";
            Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)widthNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)depthNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)drawersNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label customerNameLabel;
        private TextBox customerNameTextBox;
        private Label quoteDateLabel;
        private DateTimePicker quoteDatePicker;
        private Label widthLabel;
        private NumericUpDown widthNumericUpDown;
        private Label depthLabel;
        private NumericUpDown depthNumericUpDown;
        private Label drawersLabel;
        private NumericUpDown drawersNumericUpDown;
        private Label materialLabel;
        private ComboBox materialComboBox;
        private Label deliveryLabel;
        private ComboBox deliveryComboBox;
        private Button submitQuoteBtn;
        private Button cancelBtn;
    }
}
