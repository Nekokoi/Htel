namespace HOH
{
    partial class Admin
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PsA2 = new System.Windows.Forms.TextBox();
            this.PsA = new System.Windows.Forms.TextBox();
            this.IDA = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Password2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID";
            // 
            // PsA2
            // 
            this.PsA2.Location = new System.Drawing.Point(67, 63);
            this.PsA2.Name = "PsA2";
            this.PsA2.Size = new System.Drawing.Size(100, 20);
            this.PsA2.TabIndex = 10;
            this.PsA2.UseSystemPasswordChar = true;
            // 
            // PsA
            // 
            this.PsA.Location = new System.Drawing.Point(67, 37);
            this.PsA.Name = "PsA";
            this.PsA.Size = new System.Drawing.Size(100, 20);
            this.PsA.TabIndex = 9;
            this.PsA.UseSystemPasswordChar = true;
            // 
            // IDA
            // 
            this.IDA.Location = new System.Drawing.Point(67, 11);
            this.IDA.Name = "IDA";
            this.IDA.Size = new System.Drawing.Size(100, 20);
            this.IDA.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(173, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 693);
            this.panel1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Image = global::HOH.Properties.Resources.logout1;
            this.button1.Location = new System.Drawing.Point(67, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 44);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button22
            // 
            this.button22.Cursor = System.Windows.Forms.Cursors.Default;
            this.button22.Image = global::HOH.Properties.Resources.login;
            this.button22.Location = new System.Drawing.Point(67, 89);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(100, 44);
            this.button22.TabIndex = 15;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // Admin
            // 
            this.AcceptButton = this.button22;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PsA2);
            this.Controls.Add(this.PsA);
            this.Controls.Add(this.IDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PsA2;
        private System.Windows.Forms.TextBox PsA;
        private System.Windows.Forms.TextBox IDA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button22;
    }
}