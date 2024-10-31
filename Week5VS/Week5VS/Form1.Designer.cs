namespace Week5VS
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
            bookTitle = new Label();
            datePublished = new Label();
            price = new Label();
            txtTitle = new TextBox();
            txtPrice = new TextBox();
            dtpDatePublished = new DateTimePicker();
            lblFeedback = new Label();
            btnAdd = new Button();
            clear = new Button();
            SuspendLayout();
            // 
            // bookTitle
            // 
            bookTitle.AutoSize = true;
            bookTitle.Location = new Point(207, 15);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(65, 15);
            bookTitle.TabIndex = 0;
            bookTitle.Text = "Book Title: ";
            // 
            // datePublished
            // 
            datePublished.AutoSize = true;
            datePublished.Location = new Point(180, 81);
            datePublished.Name = "datePublished";
            datePublished.Size = new Size(92, 15);
            datePublished.TabIndex = 1;
            datePublished.Text = "Date Published: ";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(233, 50);
            price.Name = "price";
            price.Size = new Size(39, 15);
            price.TabIndex = 2;
            price.Text = "Price: ";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(278, 12);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(248, 23);
            txtTitle.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(278, 47);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(248, 23);
            txtPrice.TabIndex = 4;
            // 
            // dtpDatePublished
            // 
            dtpDatePublished.Checked = false;
            dtpDatePublished.Format = DateTimePickerFormat.Short;
            dtpDatePublished.Location = new Point(278, 76);
            dtpDatePublished.Name = "dtpDatePublished";
            dtpDatePublished.Size = new Size(248, 23);
            dtpDatePublished.TabIndex = 5;
            // 
            // lblFeedback
            // 
            lblFeedback.Location = new Point(110, 365);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(558, 15);
            lblFeedback.TabIndex = 6;
            lblFeedback.Text = "Feedback goes here";
            lblFeedback.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(352, 339);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add book";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // clear
            // 
            clear.Location = new Point(352, 415);
            clear.Name = "clear";
            clear.Size = new Size(75, 23);
            clear.TabIndex = 8;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clear);
            Controls.Add(btnAdd);
            Controls.Add(lblFeedback);
            Controls.Add(dtpDatePublished);
            Controls.Add(txtPrice);
            Controls.Add(txtTitle);
            Controls.Add(price);
            Controls.Add(datePublished);
            Controls.Add(bookTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bookTitle;
        private Label datePublished;
        private Label price;
        private TextBox txtTitle;
        private TextBox txtPrice;
        private DateTimePicker dtpDatePublished;
        private Label lblFeedback;
        private Button btnAdd;
        private Button clear;
    }
}
