namespace haye
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
            this.txtfood = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtprice2 = new System.Windows.Forms.Label();
            this.txtfoood2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtfood
            // 
            this.txtfood.AutoSize = true;
            this.txtfood.Location = new System.Drawing.Point(54, 52);
            this.txtfood.Name = "txtfood";
            this.txtfood.Size = new System.Drawing.Size(86, 20);
            this.txtfood.TabIndex = 0;
            this.txtfood.Text = " enter food";
            // 
            // txtprice
            // 
            this.txtprice.AutoSize = true;
            this.txtprice.Location = new System.Drawing.Point(54, 112);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(84, 20);
            this.txtprice.TabIndex = 3;
            this.txtprice.Text = "enter price";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(303, 26);
            this.textBox2.TabIndex = 5;
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbloutput.Location = new System.Drawing.Point(158, 264);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(363, 48);
            this.lbloutput.TabIndex = 7;
            // 
            // txtprice2
            // 
            this.txtprice2.AutoSize = true;
            this.txtprice2.Location = new System.Drawing.Point(56, 207);
            this.txtprice2.Name = "txtprice2";
            this.txtprice2.Size = new System.Drawing.Size(93, 20);
            this.txtprice2.TabIndex = 9;
            this.txtprice2.Text = "enter price2";
            // 
            // txtfoood2
            // 
            this.txtfoood2.AutoSize = true;
            this.txtfoood2.Location = new System.Drawing.Point(56, 161);
            this.txtfoood2.Name = "txtfoood2";
            this.txtfoood2.Size = new System.Drawing.Size(95, 20);
            this.txtfoood2.TabIndex = 8;
            this.txtfoood2.Text = " enter food2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(251, 207);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(303, 26);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(251, 155);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(303, 26);
            this.textBox4.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 60);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtprice2);
            this.Controls.Add(this.txtfoood2);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtfood);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtfood;
        private System.Windows.Forms.Label txtprice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Label txtprice2;
        private System.Windows.Forms.Label txtfoood2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
    }
}

