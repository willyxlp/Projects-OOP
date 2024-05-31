namespace profit_calculator
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
            System.Windows.Forms.Button button_exit;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtprofit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelpft = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.panel_ID = new System.Windows.Forms.Panel();
            this.Panel_sum = new System.Windows.Forms.Panel();
            this.label_SUM = new System.Windows.Forms.Label();
            this.panel_profit = new System.Windows.Forms.Panel();
            this.lbl_profit = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            button_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_ID.SuspendLayout();
            this.Panel_sum.SuspendLayout();
            this.panel_profit.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            button_exit.BackColor = System.Drawing.Color.Transparent;
            button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button_exit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button_exit.ForeColor = System.Drawing.Color.White;
            button_exit.Location = new System.Drawing.Point(716, 10);
            button_exit.Margin = new System.Windows.Forms.Padding(0);
            button_exit.Name = "button_exit";
            button_exit.Size = new System.Drawing.Size(36, 41);
            button_exit.TabIndex = 1;
            button_exit.Text = "X";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(button_exit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-14, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 149);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(13, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Developed by 69994\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(201, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Profit Calculator\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(497, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "pro\r\n\r\n";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(161, 185);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(424, 34);
            this.txtname.TabIndex = 4;
            this.txtname.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.White;
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(161, 315);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(424, 34);
            this.txtprice.TabIndex = 5;
            // 
            // txtquantity
            // 
            this.txtquantity.BackColor = System.Drawing.Color.White;
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(161, 252);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(424, 34);
            this.txtquantity.TabIndex = 6;
            this.txtquantity.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtprofit
            // 
            this.txtprofit.BackColor = System.Drawing.Color.White;
            this.txtprofit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprofit.Location = new System.Drawing.Point(161, 380);
            this.txtprofit.Name = "txtprofit";
            this.txtprofit.Size = new System.Drawing.Size(424, 34);
            this.txtprofit.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(213, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add product and calculate profit\r\n\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(104, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID:";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(311, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sum of All:";
            this.label5.Visible = false;
            // 
            // labelpft
            // 
            this.labelpft.AutoSize = true;
            this.labelpft.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelpft.Location = new System.Drawing.Point(570, 564);
            this.labelpft.Name = "labelpft";
            this.labelpft.Size = new System.Drawing.Size(85, 22);
            this.labelpft.TabIndex = 11;
            this.labelpft.Text = "All profit:";
            this.labelpft.Visible = false;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.ForeColor = System.Drawing.Color.Orange;
            this.label_ID.Location = new System.Drawing.Point(3, 10);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(33, 22);
            this.label_ID.TabIndex = 12;
            this.label_ID.Text = "ID:";
            this.label_ID.Visible = false;
            this.label_ID.Click += new System.EventHandler(this.label_ID_Click);
            // 
            // panel_ID
            // 
            this.panel_ID.BackColor = System.Drawing.Color.White;
            this.panel_ID.Controls.Add(this.label_ID);
            this.panel_ID.ForeColor = System.Drawing.Color.Gold;
            this.panel_ID.Location = new System.Drawing.Point(46, 602);
            this.panel_ID.Name = "panel_ID";
            this.panel_ID.Size = new System.Drawing.Size(166, 42);
            this.panel_ID.TabIndex = 15;
            this.panel_ID.Visible = false;
            // 
            // Panel_sum
            // 
            this.Panel_sum.BackColor = System.Drawing.Color.White;
            this.Panel_sum.Controls.Add(this.label_SUM);
            this.Panel_sum.ForeColor = System.Drawing.Color.Gold;
            this.Panel_sum.Location = new System.Drawing.Point(293, 602);
            this.Panel_sum.Name = "Panel_sum";
            this.Panel_sum.Size = new System.Drawing.Size(164, 42);
            this.Panel_sum.TabIndex = 16;
            this.Panel_sum.Visible = false;
            // 
            // label_SUM
            // 
            this.label_SUM.AutoSize = true;
            this.label_SUM.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SUM.ForeColor = System.Drawing.Color.Orange;
            this.label_SUM.Location = new System.Drawing.Point(3, 10);
            this.label_SUM.Name = "label_SUM";
            this.label_SUM.Size = new System.Drawing.Size(33, 22);
            this.label_SUM.TabIndex = 13;
            this.label_SUM.Text = "ID:";
            this.label_SUM.Visible = false;
            this.label_SUM.Click += new System.EventHandler(this.label_SUM_Click);
            // 
            // panel_profit
            // 
            this.panel_profit.BackColor = System.Drawing.Color.White;
            this.panel_profit.Controls.Add(this.lbl_profit);
            this.panel_profit.ForeColor = System.Drawing.Color.Gold;
            this.panel_profit.Location = new System.Drawing.Point(546, 602);
            this.panel_profit.Name = "panel_profit";
            this.panel_profit.Size = new System.Drawing.Size(167, 42);
            this.panel_profit.TabIndex = 16;
            this.panel_profit.Visible = false;
            // 
            // lbl_profit
            // 
            this.lbl_profit.AutoSize = true;
            this.lbl_profit.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profit.ForeColor = System.Drawing.Color.Orange;
            this.lbl_profit.Location = new System.Drawing.Point(3, 10);
            this.lbl_profit.Name = "lbl_profit";
            this.lbl_profit.Size = new System.Drawing.Size(33, 22);
            this.lbl_profit.TabIndex = 14;
            this.lbl_profit.Text = "ID:";
            this.lbl_profit.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "profit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(747, 739);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel_profit);
            this.Controls.Add(this.Panel_sum);
            this.Controls.Add(this.panel_ID);
            this.Controls.Add(this.labelpft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtprofit);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profit Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_ID.ResumeLayout(false);
            this.panel_ID.PerformLayout();
            this.Panel_sum.ResumeLayout(false);
            this.Panel_sum.PerformLayout();
            this.panel_profit.ResumeLayout(false);
            this.panel_profit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtprofit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelpft;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Panel panel_ID;
        private System.Windows.Forms.Panel Panel_sum;
        private System.Windows.Forms.Label label_SUM;
        private System.Windows.Forms.Panel panel_profit;
        private System.Windows.Forms.Label lbl_profit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

