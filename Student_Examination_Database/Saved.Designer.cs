namespace Student_Examination_Database
{
    partial class Saved
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saved));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.msg_lb = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-5, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 24);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(-5, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 21);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(255, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(41, 220);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(-2, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(27, 220);
            this.panel4.TabIndex = 3;
            // 
            // msg_lb
            // 
            this.msg_lb.AutoSize = true;
            this.msg_lb.BackColor = System.Drawing.Color.Transparent;
            this.msg_lb.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_lb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.msg_lb.Location = new System.Drawing.Point(102, 86);
            this.msg_lb.Name = "msg_lb";
            this.msg_lb.Size = new System.Drawing.Size(81, 24);
            this.msg_lb.TabIndex = 21;
            this.msg_lb.Text = "Saved!";
            // 
            // ok_btn
            // 
            this.ok_btn.BackgroundImage = global::Student_Examination_Database.Properties.Resources._1482715868_Ok;
            this.ok_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ok_btn.FlatAppearance.BorderSize = 0;
            this.ok_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.ok_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_btn.Location = new System.Drawing.Point(106, 128);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(66, 61);
            this.ok_btn.TabIndex = 23;
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackgroundImage = global::Student_Examination_Database.Properties.Resources._1480913524_Close_Icon_Dark;
            this.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Location = new System.Drawing.Point(194, 26);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(51, 61);
            this.close_btn.TabIndex = 22;
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // Saved
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(281, 230);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.msg_lb);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Saved";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label msg_lb;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button ok_btn;
    }
}