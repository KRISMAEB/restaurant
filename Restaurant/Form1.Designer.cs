namespace Restaurant
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.discountedprice = new System.Windows.Forms.TextBox();
            this.btnpay = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.enter);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 116);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(365, 33);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Welcome To Soma\'s Family Restaurant";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(618, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 211);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(629, 337);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(132, 21);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "TOTAL PRICE:";
            this.lbl1.Click += new System.EventHandler(this.price_Click);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(767, 337);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(59, 20);
            this.Price.TabIndex = 3;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(632, 262);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(108, 21);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "QUANTITY:";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(746, 263);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(59, 20);
            this.quantity.TabIndex = 5;
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(619, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "DISCOUNTED PRICE:";
            // 
            // discountedprice
            // 
            this.discountedprice.Location = new System.Drawing.Point(818, 297);
            this.discountedprice.Name = "discountedprice";
            this.discountedprice.Size = new System.Drawing.Size(58, 20);
            this.discountedprice.TabIndex = 7;
            // 
            // btnpay
            // 
            this.btnpay.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpay.Location = new System.Drawing.Point(636, 403);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(82, 35);
            this.btnpay.TabIndex = 8;
            this.btnpay.Text = "Pay";
            this.btnpay.UseVisualStyleBackColor = true;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(746, 403);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(82, 35);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // enter
            // 
            this.enter.AutoSize = true;
            this.enter.Location = new System.Drawing.Point(619, 16);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(121, 21);
            this.enter.TabIndex = 2;
            this.enter.Text = "Enter a day:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(746, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 30);
            this.textBox2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(806, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnpay);
            this.Controls.Add(this.discountedprice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox discountedprice;
        private System.Windows.Forms.Button btnpay;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label enter;
        private System.Windows.Forms.Button button1;
    }
}

