namespace WindowsFormsApp1
{
    partial class TaxForOrder
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
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txttocountry = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txttozip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttostate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtshippingamount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttocity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FromCountry = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtfromcountry = new System.Windows.Forms.TextBox();
            this.txtfromstate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtfromzip = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtfromcity = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(624, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(325, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tax For Order";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(60, 402);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 23);
            this.label13.TabIndex = 1;
            // 
            // txttocountry
            // 
            this.txttocountry.BackColor = System.Drawing.Color.LemonChiffon;
            this.txttocountry.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txttocountry.ForeColor = System.Drawing.Color.DarkGreen;
            this.txttocountry.Location = new System.Drawing.Point(192, 226);
            this.txttocountry.Name = "txttocountry";
            this.txttocountry.Size = new System.Drawing.Size(151, 26);
            this.txttocountry.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(60, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 23);
            this.label15.TabIndex = 1;
            this.label15.Text = "ToCountry";
            // 
            // txttozip
            // 
            this.txttozip.BackColor = System.Drawing.Color.LemonChiffon;
            this.txttozip.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txttozip.ForeColor = System.Drawing.Color.DarkGreen;
            this.txttozip.Location = new System.Drawing.Point(568, 222);
            this.txttozip.Name = "txttozip";
            this.txttozip.Size = new System.Drawing.Size(151, 26);
            this.txttozip.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(418, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ToZip";
            // 
            // txttostate
            // 
            this.txttostate.BackColor = System.Drawing.Color.LemonChiffon;
            this.txttostate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txttostate.ForeColor = System.Drawing.Color.DarkGreen;
            this.txttostate.Location = new System.Drawing.Point(195, 291);
            this.txttostate.Name = "txttostate";
            this.txttostate.Size = new System.Drawing.Size(151, 26);
            this.txttostate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(60, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "ToState";
            // 
            // txtshippingamount
            // 
            this.txtshippingamount.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtshippingamount.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtshippingamount.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtshippingamount.Location = new System.Drawing.Point(573, 360);
            this.txtshippingamount.Name = "txtshippingamount";
            this.txtshippingamount.Size = new System.Drawing.Size(151, 26);
            this.txtshippingamount.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(412, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Shipping Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(70, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 23);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(255, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 23);
            this.label5.TabIndex = 4;
            // 
            // txtamount
            // 
            this.txtamount.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtamount.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtamount.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtamount.Location = new System.Drawing.Point(192, 357);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(151, 26);
            this.txtamount.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(59, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Order Amount";
            // 
            // txttocity
            // 
            this.txttocity.BackColor = System.Drawing.Color.LemonChiffon;
            this.txttocity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txttocity.ForeColor = System.Drawing.Color.DarkGreen;
            this.txttocity.Location = new System.Drawing.Point(567, 288);
            this.txttocity.Name = "txttocity";
            this.txttocity.Size = new System.Drawing.Size(151, 26);
            this.txttocity.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(413, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "To City";
            // 
            // FromCountry
            // 
            this.FromCountry.AutoSize = true;
            this.FromCountry.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FromCountry.Location = new System.Drawing.Point(62, 90);
            this.FromCountry.Name = "FromCountry";
            this.FromCountry.Size = new System.Drawing.Size(100, 23);
            this.FromCountry.TabIndex = 1;
            this.FromCountry.Text = "FromCountry";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(62, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "FromState";
            // 
            // txtfromcountry
            // 
            this.txtfromcountry.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtfromcountry.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtfromcountry.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtfromcountry.Location = new System.Drawing.Point(194, 90);
            this.txtfromcountry.Name = "txtfromcountry";
            this.txtfromcountry.Size = new System.Drawing.Size(151, 26);
            this.txtfromcountry.TabIndex = 0;
            // 
            // txtfromstate
            // 
            this.txtfromstate.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtfromstate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtfromstate.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtfromstate.Location = new System.Drawing.Point(197, 155);
            this.txtfromstate.Name = "txtfromstate";
            this.txtfromstate.Size = new System.Drawing.Size(151, 26);
            this.txtfromstate.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(420, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "FromZip";
            // 
            // txtfromzip
            // 
            this.txtfromzip.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtfromzip.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtfromzip.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtfromzip.Location = new System.Drawing.Point(570, 86);
            this.txtfromzip.Name = "txtfromzip";
            this.txtfromzip.Size = new System.Drawing.Size(151, 26);
            this.txtfromzip.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(415, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 23);
            this.label12.TabIndex = 1;
            this.label12.Text = "FromCity";
            // 
            // txtfromcity
            // 
            this.txtfromcity.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtfromcity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtfromcity.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtfromcity.Location = new System.Drawing.Point(569, 152);
            this.txtfromcity.Name = "txtfromcity";
            this.txtfromcity.Size = new System.Drawing.Size(151, 26);
            this.txtfromcity.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(512, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TaxForOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 603);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtfromcity);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtfromzip);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtfromstate);
            this.Controls.Add(this.txtfromcountry);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FromCountry);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttocity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtshippingamount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttostate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttozip);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txttocountry);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TaxForOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaxJar";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TaxForOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txttocountry;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txttozip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttostate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtshippingamount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttocity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label FromCountry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtfromcountry;
        private System.Windows.Forms.TextBox txtfromstate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtfromzip;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtfromcity;
        private System.Windows.Forms.Button button2;
    }
}

