
namespace Client
{
    partial class AddPlayer
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
            this.pn = new System.Windows.Forms.TextBox();
            this.jn = new System.Windows.Forms.TextBox();
            this.cn = new System.Windows.Forms.TextBox();
            this.pt = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "P Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "J No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "P Type";
            // 
            // pn
            // 
            this.pn.Location = new System.Drawing.Point(298, 101);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(148, 22);
            this.pn.TabIndex = 5;
            // 
            // jn
            // 
            this.jn.Location = new System.Drawing.Point(298, 149);
            this.jn.Name = "jn";
            this.jn.Size = new System.Drawing.Size(148, 22);
            this.jn.TabIndex = 6;
            // 
            // cn
            // 
            this.cn.Location = new System.Drawing.Point(298, 194);
            this.cn.Name = "cn";
            this.cn.Size = new System.Drawing.Size(148, 22);
            this.cn.TabIndex = 7;
            // 
            // pt
            // 
            this.pt.Location = new System.Drawing.Point(298, 242);
            this.pt.Name = "pt";
            this.pt.Size = new System.Drawing.Size(148, 22);
            this.pt.TabIndex = 8;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(298, 313);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(92, 23);
            this.add.TabIndex = 9;
            this.add.Text = "submit";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // AddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add);
            this.Controls.Add(this.pt);
            this.Controls.Add(this.cn);
            this.Controls.Add(this.jn);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPlayer";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AddPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pn;
        private System.Windows.Forms.TextBox jn;
        private System.Windows.Forms.TextBox cn;
        private System.Windows.Forms.TextBox pt;
        private System.Windows.Forms.Button add;
    }
}