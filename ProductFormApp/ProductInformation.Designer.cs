namespace ProductFormApp
{
    partial class ProductInformation
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nameTextBox = new TextBox();
            priceTextBox = new TextBox();
            IdTextBox = new TextBox();
            addProductButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 11);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 48);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 90);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 2;
            label3.Text = "Id";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(131, 8);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(220, 27);
            nameTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(131, 45);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(220, 27);
            priceTextBox.TabIndex = 4;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(131, 87);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(220, 27);
            IdTextBox.TabIndex = 5;
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(25, 120);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(326, 38);
            addProductButton.TabIndex = 6;
            addProductButton.Text = "Add Product";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click;
            // 
            // ProductInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(addProductButton);
            Controls.Add(IdTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductInformation";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nameTextBox;
        private TextBox priceTextBox;
        private TextBox IdTextBox;
        private Button addProductButton;
    }
}
