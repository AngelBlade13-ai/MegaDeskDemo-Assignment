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
            quotesGrid = new DataGridView();
            customerColumn = new DataGridViewTextBoxColumn();
            dateColumn = new DataGridViewTextBoxColumn();
            widthColumn = new DataGridViewTextBoxColumn();
            depthColumn = new DataGridViewTextBoxColumn();
            drawersColumn = new DataGridViewTextBoxColumn();
            sizeColumn = new DataGridViewTextBoxColumn();
            materialColumn = new DataGridViewTextBoxColumn();
            shippingColumn = new DataGridViewTextBoxColumn();
            emptyLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)quotesGrid).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            titleLabel.Location = new Point(16, 16);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(152, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "View All Quotes";
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(650, 407);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(95, 32);
            closeBtn.TabIndex = 1;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += CloseBtn_Click;
            // 
            // quotesGrid
            // 
            quotesGrid.AllowUserToAddRows = false;
            quotesGrid.AllowUserToDeleteRows = false;
            quotesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            quotesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            quotesGrid.Columns.AddRange(new DataGridViewColumn[] { customerColumn, dateColumn, widthColumn, depthColumn, drawersColumn, sizeColumn, materialColumn, shippingColumn });
            quotesGrid.Location = new Point(16, 55);
            quotesGrid.Name = "quotesGrid";
            quotesGrid.ReadOnly = true;
            quotesGrid.RowHeadersVisible = false;
            quotesGrid.Size = new Size(729, 334);
            quotesGrid.TabIndex = 2;
            // 
            // customerColumn
            // 
            customerColumn.HeaderText = "Customer";
            customerColumn.Name = "customerColumn";
            customerColumn.ReadOnly = true;
            // 
            // dateColumn
            // 
            dateColumn.HeaderText = "Date";
            dateColumn.Name = "dateColumn";
            dateColumn.ReadOnly = true;
            // 
            // widthColumn
            // 
            widthColumn.HeaderText = "Width";
            widthColumn.Name = "widthColumn";
            widthColumn.ReadOnly = true;
            // 
            // depthColumn
            // 
            depthColumn.HeaderText = "Depth";
            depthColumn.Name = "depthColumn";
            depthColumn.ReadOnly = true;
            // 
            // drawersColumn
            // 
            drawersColumn.HeaderText = "Drawers";
            drawersColumn.Name = "drawersColumn";
            drawersColumn.ReadOnly = true;
            // 
            // sizeColumn
            // 
            sizeColumn.HeaderText = "Total Size in^2";
            sizeColumn.Name = "sizeColumn";
            sizeColumn.ReadOnly = true;
            // 
            // materialColumn
            // 
            materialColumn.HeaderText = "Material";
            materialColumn.Name = "materialColumn";
            materialColumn.ReadOnly = true;
            // 
            // shippingColumn
            // 
            shippingColumn.HeaderText = "Shipping";
            shippingColumn.Name = "shippingColumn";
            shippingColumn.ReadOnly = true;
            // 
            // emptyLabel
            // 
            emptyLabel.AutoSize = true;
            emptyLabel.Location = new Point(16, 407);
            emptyLabel.Name = "emptyLabel";
            emptyLabel.Size = new Size(166, 15);
            emptyLabel.TabIndex = 3;
            emptyLabel.Text = "No quotes have been added.";
            // 
            // ViewAllQuotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 457);
            Controls.Add(emptyLabel);
            Controls.Add(quotesGrid);
            Controls.Add(closeBtn);
            Controls.Add(titleLabel);
            Name = "ViewAllQuotes";
            Text = "View All Quotes";
            Load += ViewAllQuotes_Load;
            ((System.ComponentModel.ISupportInitialize)quotesGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Button closeBtn;
        private DataGridView quotesGrid;
        private DataGridViewTextBoxColumn customerColumn;
        private DataGridViewTextBoxColumn dateColumn;
        private DataGridViewTextBoxColumn widthColumn;
        private DataGridViewTextBoxColumn depthColumn;
        private DataGridViewTextBoxColumn drawersColumn;
        private DataGridViewTextBoxColumn sizeColumn;
        private DataGridViewTextBoxColumn materialColumn;
        private DataGridViewTextBoxColumn shippingColumn;
        private Label emptyLabel;
    }
}
