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
            this.date = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Label();
            this.tbt2 = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(58, 153);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(0, 13);
            this.date.TabIndex = 12;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(58, 140);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(0, 13);
            this.lbl3.TabIndex = 12;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(293, 132);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(0, 13);
            this.lbl4.TabIndex = 13;
            this.lbl4.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // enter
            // 
            this.enter.AutoSize = true;
            this.enter.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(173, 155);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(152, 24);
            this.enter.TabIndex = 2;
            this.enter.Text = "Enter a day:";
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // tbt2
            // 
            this.tbt2.Location = new System.Drawing.Point(331, 153);
            this.tbt2.Name = "tbt2";
            this.tbt2.Size = new System.Drawing.Size(176, 30);
            this.tbt2.TabIndex = 10;
            this.tbt2.TextChanged += new System.EventHandler(this.tbt2_TextChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Lime;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(378, 189);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(80, 34);
            this.btnEnter.TabIndex = 11;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(132, 81);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(511, 27);
            this.welcome.TabIndex = 12;
            this.welcome.Text = "Welcome To Soma\'s Family Restaurant!";
            this.welcome.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.welcome);
            this.panel1.Controls.Add(this.btnEnter);
            this.panel1.Controls.Add(this.tbt2);
            this.panel1.Controls.Add(this.enter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 383);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label enter;
        private System.Windows.Forms.TextBox tbt2;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Panel panel1;
    }
}

