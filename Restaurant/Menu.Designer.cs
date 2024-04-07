namespace Restaurant
{
    partial class Menu
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
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.txtCalculateyourorder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtorderyouchoose = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.space = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(100, 294);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(75, 21);
            this.price.TabIndex = 3;
            this.price.Text = "PRICE:";
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(505, 171);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(117, 21);
            this.quantity.TabIndex = 4;
            this.quantity.Text = "QUANTITY:";
            this.quantity.Click += new System.EventHandler(this.quantity_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(498, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 5;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(202, 292);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(69, 26);
            this.txtprice.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "TOTAL PRICE:";
            // 
            // txttotalprice
            // 
            this.txttotalprice.Location = new System.Drawing.Point(654, 218);
            this.txttotalprice.Multiline = true;
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.Size = new System.Drawing.Size(59, 27);
            this.txttotalprice.TabIndex = 12;
            // 
            // txtCalculateyourorder
            // 
            this.txtCalculateyourorder.BackColor = System.Drawing.Color.Lime;
            this.txtCalculateyourorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCalculateyourorder.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalculateyourorder.Location = new System.Drawing.Point(683, 292);
            this.txtCalculateyourorder.Name = "txtCalculateyourorder";
            this.txtCalculateyourorder.Size = new System.Drawing.Size(81, 29);
            this.txtCalculateyourorder.TabIndex = 13;
            this.txtCalculateyourorder.Text = "Done";
            this.txtCalculateyourorder.UseVisualStyleBackColor = false;
            this.txtCalculateyourorder.Click += new System.EventHandler(this.txtCalculateyourorder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(574, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 27);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(628, 168);
            this.txtquantity.Multiline = true;
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(59, 26);
            this.txtquantity.TabIndex = 9;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(18, 244);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(273, 21);
            this.lbl4.TabIndex = 16;
            this.lbl4.Text = "ORDER THAT YOU CHOOSE:";
            // 
            // txtorderyouchoose
            // 
            this.txtorderyouchoose.Location = new System.Drawing.Point(297, 242);
            this.txtorderyouchoose.Multiline = true;
            this.txtorderyouchoose.Name = "txtorderyouchoose";
            this.txtorderyouchoose.Size = new System.Drawing.Size(100, 25);
            this.txtorderyouchoose.TabIndex = 17;
            this.txtorderyouchoose.TextChanged += new System.EventHandler(this.txtorderyouchoose_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soma\'s Family Restaurant";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(266, 326);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 27);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(170, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 27);
            this.button2.TabIndex = 19;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 20;
            // 
            // space
            // 
            this.space.AutoSize = true;
            this.space.Location = new System.Drawing.Point(71, 71);
            this.space.Name = "space";
            this.space.Size = new System.Drawing.Size(10, 13);
            this.space.TabIndex = 21;
            this.space.Text = " ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(812, 368);
            this.Controls.Add(this.space);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtorderyouchoose);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtCalculateyourorder);
            this.Controls.Add(this.txttotalprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.price);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttotalprice;
        private System.Windows.Forms.Button txtCalculateyourorder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtorderyouchoose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label space;
    }
}