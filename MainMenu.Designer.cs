namespace MegaDeskDemo
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            addQuoteBtn = new Button();
            viewQuotesBtn = new Button();
            searchQuotesBtn = new Button();
            exitBtn = new Button();
            deskPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)deskPictureBox).BeginInit();
            SuspendLayout();
            // 
            // addQuoteBtn
            // 
            addQuoteBtn.Location = new Point(12, 12);
            addQuoteBtn.Name = "addQuoteBtn";
            addQuoteBtn.Size = new Size(198, 52);
            addQuoteBtn.TabIndex = 0;
            addQuoteBtn.Text = "Add New Quote";
            addQuoteBtn.UseVisualStyleBackColor = true;
            addQuoteBtn.Click += AddQuoteBtn_Click;
            // 
            // viewQuotesBtn
            // 
            viewQuotesBtn.Location = new Point(12, 70);
            viewQuotesBtn.Name = "viewQuotesBtn";
            viewQuotesBtn.Size = new Size(198, 52);
            viewQuotesBtn.TabIndex = 1;
            viewQuotesBtn.Text = "View Quotes";
            viewQuotesBtn.UseVisualStyleBackColor = true;
            viewQuotesBtn.Click += ViewQuotesBtn_Click;
            // 
            // searchQuotesBtn
            // 
            searchQuotesBtn.Location = new Point(12, 128);
            searchQuotesBtn.Name = "searchQuotesBtn";
            searchQuotesBtn.Size = new Size(198, 52);
            searchQuotesBtn.TabIndex = 2;
            searchQuotesBtn.Text = "Search Quotes";
            searchQuotesBtn.UseVisualStyleBackColor = true;
            searchQuotesBtn.Click += SearchQuotesBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(12, 186);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(198, 52);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += ExitBtn_Click;
            // 
            // deskPictureBox
            // 
            deskPictureBox.BackColor = Color.White;
            deskPictureBox.Image = (Image)resources.GetObject("deskPictureBox.Image");
            deskPictureBox.Location = new Point(216, 33);
            deskPictureBox.Name = "deskPictureBox";
            deskPictureBox.Size = new Size(217, 190);
            deskPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            deskPictureBox.TabIndex = 4;
            deskPictureBox.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 247);
            Controls.Add(deskPictureBox);
            Controls.Add(exitBtn);
            Controls.Add(searchQuotesBtn);
            Controls.Add(viewQuotesBtn);
            Controls.Add(addQuoteBtn);
            Name = "MainMenu";
            Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)deskPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button addQuoteBtn;
        private Button viewQuotesBtn;
        private Button searchQuotesBtn;
        private Button exitBtn;
        private PictureBox deskPictureBox;
    }
}
