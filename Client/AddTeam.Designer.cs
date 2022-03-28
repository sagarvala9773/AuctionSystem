
namespace Client
{
    partial class AddTeam
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
            this.Add = new System.Windows.Forms.Button();
            this.tn = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.tb = new System.Windows.Forms.TextBox();
            this.tc = new System.Windows.Forms.TextBox();
            this.th = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "T_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "T_Owner";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "T_BValue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "T_Captain";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "T_HCoach";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(187, 350);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 6;
            this.Add.Text = "submit";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // tn
            // 
            this.tn.Location = new System.Drawing.Point(272, 99);
            this.tn.Name = "tn";
            this.tn.Size = new System.Drawing.Size(100, 22);
            this.tn.TabIndex = 7;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(272, 142);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(100, 22);
            this.to.TabIndex = 8;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(272, 180);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(100, 22);
            this.tb.TabIndex = 9;
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(272, 222);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(100, 22);
            this.tc.TabIndex = 10;
            // 
            // th
            // 
            this.th.Location = new System.Drawing.Point(272, 270);
            this.th.Name = "th";
            this.th.Size = new System.Drawing.Size(100, 22);
            this.th.TabIndex = 11;
            // 
            // AddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.th);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.to);
            this.Controls.Add(this.tn);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTeam";
            this.Text = "AddTeam";
            this.Load += new System.EventHandler(this.AddTeam_Load);
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
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox tn;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.TextBox tc;
        private System.Windows.Forms.TextBox th;
    }
}