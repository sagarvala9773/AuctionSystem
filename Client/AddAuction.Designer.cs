
namespace Client
{
    partial class AddAuction
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sa = new System.Windows.Forms.TextBox();
            this.sn = new System.Windows.Forms.TextBox();
            this.tp = new System.Windows.Forms.TextBox();
            this.tt = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.fp = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Auction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Season";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "S_Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "T_Player";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "T_Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "I_Player";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "F_Player";
            // 
            // sa
            // 
            this.sa.Location = new System.Drawing.Point(281, 81);
            this.sa.Name = "sa";
            this.sa.Size = new System.Drawing.Size(143, 22);
            this.sa.TabIndex = 7;
            // 
            // sn
            // 
            this.sn.Location = new System.Drawing.Point(281, 121);
            this.sn.Name = "sn";
            this.sn.Size = new System.Drawing.Size(143, 22);
            this.sn.TabIndex = 8;
            // 
            // tp
            // 
            this.tp.Location = new System.Drawing.Point(281, 167);
            this.tp.Name = "tp";
            this.tp.Size = new System.Drawing.Size(143, 22);
            this.tp.TabIndex = 9;
            // 
            // tt
            // 
            this.tt.Location = new System.Drawing.Point(281, 214);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(143, 22);
            this.tt.TabIndex = 10;
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(281, 261);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(143, 22);
            this.ip.TabIndex = 11;
            // 
            // fp
            // 
            this.fp.Location = new System.Drawing.Point(281, 302);
            this.fp.Name = "fp";
            this.fp.Size = new System.Drawing.Size(143, 22);
            this.fp.TabIndex = 12;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(223, 361);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 13;
            this.Add.Text = "Submit";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AddAuction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.fp);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.tt);
            this.Controls.Add(this.tp);
            this.Controls.Add(this.sn);
            this.Controls.Add(this.sa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAuction";
            this.Text = "AddAuction";
            this.Load += new System.EventHandler(this.AddAuction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sa;
        private System.Windows.Forms.TextBox sn;
        private System.Windows.Forms.TextBox tp;
        private System.Windows.Forms.TextBox tt;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.TextBox fp;
        private System.Windows.Forms.Button Add;
    }
}