
namespace Client
{
    partial class UpdatePlayer
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
            this.pi = new System.Windows.Forms.TextBox();
            this.pn = new System.Windows.Forms.TextBox();
            this.pj = new System.Windows.Forms.TextBox();
            this.pc = new System.Windows.Forms.TextBox();
            this.pt = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "UpdatePlayer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "P_Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "P_Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "J_No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "P_Type";
            // 
            // pi
            // 
            this.pi.Location = new System.Drawing.Point(181, 91);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(146, 22);
            this.pi.TabIndex = 6;
            // 
            // pn
            // 
            this.pn.Location = new System.Drawing.Point(181, 139);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(146, 22);
            this.pn.TabIndex = 7;
            // 
            // pj
            // 
            this.pj.Location = new System.Drawing.Point(181, 190);
            this.pj.Name = "pj";
            this.pj.Size = new System.Drawing.Size(146, 22);
            this.pj.TabIndex = 8;
            // 
            // pc
            // 
            this.pc.Location = new System.Drawing.Point(181, 237);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(146, 22);
            this.pc.TabIndex = 9;
            // 
            // pt
            // 
            this.pt.Location = new System.Drawing.Point(181, 289);
            this.pt.Name = "pt";
            this.pt.Size = new System.Drawing.Size(146, 22);
            this.pt.TabIndex = 10;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(311, 397);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 12;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(333, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(470, 251);
            this.dataGridView1.TabIndex = 13;
            // 
            // UpdatePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.pt);
            this.Controls.Add(this.pc);
            this.Controls.Add(this.pj);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.pi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePlayer";
            this.Text = "UpdatePlayer";
            this.Load += new System.EventHandler(this.UpdatePlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox pi;
        private System.Windows.Forms.TextBox pn;
        private System.Windows.Forms.TextBox pj;
        private System.Windows.Forms.TextBox pc;
        private System.Windows.Forms.TextBox pt;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}