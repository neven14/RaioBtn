namespace RadioBtn
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbtnAvion = new System.Windows.Forms.GroupBox();
            this.rbtnAutobus = new System.Windows.Forms.RadioButton();
            this.radioVlastiti = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbtnAvion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(166, 313);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(110, 59);
            this.btnRezerviraj.TabIndex = 4;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(432, 256);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 152);
            this.textBox1.TabIndex = 5;
            // 
            // rbtnAvion
            // 
            this.rbtnAvion.Controls.Add(this.radioButton1);
            this.rbtnAvion.Controls.Add(this.radioVlastiti);
            this.rbtnAvion.Controls.Add(this.rbtnAutobus);
            this.rbtnAvion.Location = new System.Drawing.Point(86, 120);
            this.rbtnAvion.Name = "rbtnAvion";
            this.rbtnAvion.Size = new System.Drawing.Size(261, 136);
            this.rbtnAvion.TabIndex = 6;
            this.rbtnAvion.TabStop = false;
            this.rbtnAvion.Text = "groupBox1";
            // 
            // rbtnAutobus
            // 
            this.rbtnAutobus.AutoSize = true;
            this.rbtnAutobus.Location = new System.Drawing.Point(7, 59);
            this.rbtnAutobus.Name = "rbtnAutobus";
            this.rbtnAutobus.Size = new System.Drawing.Size(82, 21);
            this.rbtnAutobus.TabIndex = 1;
            this.rbtnAutobus.TabStop = true;
            this.rbtnAutobus.Text = "Autobud";
            this.rbtnAutobus.UseVisualStyleBackColor = true;
            // 
            // radioVlastiti
            // 
            this.radioVlastiti.AutoSize = true;
            this.radioVlastiti.Location = new System.Drawing.Point(7, 98);
            this.radioVlastiti.Name = "radioVlastiti";
            this.radioVlastiti.Size = new System.Drawing.Size(123, 21);
            this.radioVlastiti.TabIndex = 2;
            this.radioVlastiti.TabStop = true;
            this.radioVlastiti.Text = "Vlastiti prijevoz";
            this.radioVlastiti.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Avion";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtnAvion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.rbtnAvion.ResumeLayout(false);
            this.rbtnAvion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox rbtnAvion;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioVlastiti;
        private System.Windows.Forms.RadioButton rbtnAutobus;
    }
}

