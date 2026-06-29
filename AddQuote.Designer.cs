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
            components = new System.ComponentModel.Container();
            titleLabel = new Label();
            todayLabel = new Label();
            DateLabel = new Label();
            nameLabel = new Label();
            NameBox = new TextBox();
            widthLabel = new Label();
            WidthBox = new TextBox();
            depthLabel = new Label();
            DepthBox = new TextBox();
            drawerLabel = new Label();
            DrawerInput = new ComboBox();
            materialLabel = new Label();
            MaterialComboBox = new ComboBox();
            shippingLabel = new Label();
            ShippingComboBox = new ComboBox();
            BackBtn = new Button();
            button2 = new Button();
            WidthErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)WidthErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            titleLabel.Location = new Point(24, 22);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(105, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Add Quote";
            // 
            // todayLabel
            // 
            todayLabel.AutoSize = true;
            todayLabel.Location = new Point(24, 67);
            todayLabel.Name = "todayLabel";
            todayLabel.Size = new Size(74, 15);
            todayLabel.TabIndex = 1;
            todayLabel.Text = "Today's Date";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(183, 67);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(12, 15);
            DateLabel.TabIndex = 2;
            DateLabel.Text = "-";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(24, 109);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(94, 15);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Customer Name";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(183, 106);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(213, 23);
            NameBox.TabIndex = 4;
            NameBox.Validating += NameBox_Validating;
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(24, 150);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(39, 15);
            widthLabel.TabIndex = 5;
            widthLabel.Text = "Width";
            // 
            // WidthBox
            // 
            WidthBox.Location = new Point(183, 147);
            WidthBox.Name = "WidthBox";
            WidthBox.Size = new Size(213, 23);
            WidthBox.TabIndex = 6;
            WidthBox.Validating += WidthBox_Validating;
            // 
            // depthLabel
            // 
            depthLabel.AutoSize = true;
            depthLabel.Location = new Point(24, 191);
            depthLabel.Name = "depthLabel";
            depthLabel.Size = new Size(39, 15);
            depthLabel.TabIndex = 7;
            depthLabel.Text = "Depth";
            // 
            // DepthBox
            // 
            DepthBox.Location = new Point(183, 188);
            DepthBox.Name = "DepthBox";
            DepthBox.Size = new Size(213, 23);
            DepthBox.TabIndex = 8;
            DepthBox.Validating += DepthBox_Validating;
            // 
            // drawerLabel
            // 
            drawerLabel.AutoSize = true;
            drawerLabel.Location = new Point(24, 232);
            drawerLabel.Name = "drawerLabel";
            drawerLabel.Size = new Size(48, 15);
            drawerLabel.TabIndex = 9;
            drawerLabel.Text = "Drawers";
            // 
            // DrawerInput
            // 
            DrawerInput.DropDownStyle = ComboBoxStyle.DropDownList;
            DrawerInput.FormattingEnabled = true;
            DrawerInput.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            DrawerInput.Location = new Point(183, 229);
            DrawerInput.Name = "DrawerInput";
            DrawerInput.Size = new Size(213, 23);
            DrawerInput.TabIndex = 10;
            DrawerInput.Validating += DrawerInput_Validating;
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new Point(24, 273);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new Size(76, 15);
            materialLabel.TabIndex = 11;
            materialLabel.Text = "Material Type";
            // 
            // MaterialComboBox
            // 
            MaterialComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MaterialComboBox.FormattingEnabled = true;
            MaterialComboBox.Items.AddRange(new object[] { "Pine", "Laminate", "Veneer", "Oak", "Rosewood" });
            MaterialComboBox.Location = new Point(183, 270);
            MaterialComboBox.Name = "MaterialComboBox";
            MaterialComboBox.Size = new Size(213, 23);
            MaterialComboBox.TabIndex = 12;
            MaterialComboBox.Validating += MaterialComboBox_Validating;
            // 
            // shippingLabel
            // 
            shippingLabel.AutoSize = true;
            shippingLabel.Location = new Point(24, 314);
            shippingLabel.Name = "shippingLabel";
            shippingLabel.Size = new Size(139, 15);
            shippingLabel.TabIndex = 13;
            shippingLabel.Text = "Order Delivery Time";
            // 
            // ShippingComboBox
            // 
            ShippingComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ShippingComboBox.FormattingEnabled = true;
            ShippingComboBox.Items.AddRange(new object[] { "3", "5", "7" });
            ShippingComboBox.Location = new Point(183, 311);
            ShippingComboBox.Name = "ShippingComboBox";
            ShippingComboBox.Size = new Size(213, 23);
            ShippingComboBox.TabIndex = 14;
            ShippingComboBox.Validating += ShippingComboBox_Validating;
            // 
            // BackBtn
            // 
            BackBtn.CausesValidation = false;
            BackBtn.Location = new Point(183, 384);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(95, 32);
            BackBtn.TabIndex = 15;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(301, 384);
            button2.Name = "button2";
            button2.Size = new Size(95, 32);
            button2.TabIndex = 16;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // WidthErrorProvider
            // 
            WidthErrorProvider.ContainerControl = this;
            // 
            // AddQuote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 481);
            Controls.Add(button2);
            Controls.Add(BackBtn);
            Controls.Add(ShippingComboBox);
            Controls.Add(shippingLabel);
            Controls.Add(MaterialComboBox);
            Controls.Add(materialLabel);
            Controls.Add(DrawerInput);
            Controls.Add(drawerLabel);
            Controls.Add(DepthBox);
            Controls.Add(depthLabel);
            Controls.Add(WidthBox);
            Controls.Add(widthLabel);
            Controls.Add(NameBox);
            Controls.Add(nameLabel);
            Controls.Add(DateLabel);
            Controls.Add(todayLabel);
            Controls.Add(titleLabel);
            Name = "AddQuote";
            Text = "Add Quote";
            Load += AddQuote_Load;
            ((System.ComponentModel.ISupportInitialize)WidthErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label todayLabel;
        private Label DateLabel;
        private Label nameLabel;
        private TextBox NameBox;
        private Label widthLabel;
        private TextBox WidthBox;
        private Label depthLabel;
        private TextBox DepthBox;
        private Label drawerLabel;
        private ComboBox DrawerInput;
        private Label materialLabel;
        private ComboBox MaterialComboBox;
        private Label shippingLabel;
        private ComboBox ShippingComboBox;
        private Button BackBtn;
        private Button button2;
        private ErrorProvider WidthErrorProvider;
    }
}
