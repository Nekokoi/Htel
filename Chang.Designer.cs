namespace HOH
{
    partial class Chang
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
            this.OP = new System.Windows.Forms.TextBox();
            this.NP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(450, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(450, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // OP
            // 
            this.OP.Location = new System.Drawing.Point(751, 95);
            this.OP.Name = "OP";
            this.OP.ReadOnly = true;
            this.OP.Size = new System.Drawing.Size(123, 20);
            this.OP.TabIndex = 3;
            this.OP.UseSystemPasswordChar = true;
            this.OP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NP
            // 
            this.NP.Location = new System.Drawing.Point(751, 143);
            this.NP.Name = "NP";
            this.NP.ReadOnly = true;
            this.NP.Size = new System.Drawing.Size(123, 20);
            this.NP.TabIndex = 4;
            this.NP.UseSystemPasswordChar = true;
            this.NP.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20.25F);
            this.label4.Location = new System.Drawing.Point(450, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "User";
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(751, 46);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(123, 20);
            this.User.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Image = global::HOH.Properties.Resources.icon__1_2;
            this.button2.Location = new System.Drawing.Point(817, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 40);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Image = global::HOH.Properties.Resources.exchange;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(690, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Change Password";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.button3.Location = new System.Drawing.Point(891, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 40);
            this.button3.TabIndex = 11;
            this.button3.Text = "Check";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(450, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // CP
            // 
            this.CP.Location = new System.Drawing.Point(751, 184);
            this.CP.Name = "CP";
            this.CP.ReadOnly = true;
            this.CP.Size = new System.Drawing.Size(123, 20);
            this.CP.TabIndex = 6;
            this.CP.UseSystemPasswordChar = true;
            // 
            // Chang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CP);
            this.Controls.Add(this.NP);
            this.Controls.Add(this.OP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chang";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.Chang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OP;
        private System.Windows.Forms.TextBox NP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CP;
    }
}