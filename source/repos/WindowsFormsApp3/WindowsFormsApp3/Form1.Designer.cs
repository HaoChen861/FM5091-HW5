namespace WindowsFormsApp3
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
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Rho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Joint_checkBox = new System.Windows.Forms.CheckBox();
            this.Polar_Rejection = new System.Windows.Forms.RadioButton();
            this.Box_Muller = new System.Windows.Forms.RadioButton();
            this.Add_Twelve = new System.Windows.Forms.RadioButton();
            this.Mean = new System.Windows.Forms.Label();
            this.Mean_var = new System.Windows.Forms.Label();
            this.Variance = new System.Windows.Forms.Label();
            this.Variance_var = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "Normal Random Number";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Compute_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(12, 12);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(424, 120);
            this.result.TabIndex = 4;
            this.result.Text = "";
            this.result.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Rho
            // 
            this.Rho.Location = new System.Drawing.Point(131, 107);
            this.Rho.Name = "Rho";
            this.Rho.Size = new System.Drawing.Size(63, 20);
            this.Rho.TabIndex = 6;
            this.Rho.Text = "0";
            this.Rho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Rho.TextChanged += new System.EventHandler(this.rho_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Correlation [-1,1]:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Joint_checkBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Polar_Rejection);
            this.groupBox1.Controls.Add(this.Rho);
            this.groupBox1.Controls.Add(this.Box_Muller);
            this.groupBox1.Controls.Add(this.Add_Twelve);
            this.groupBox1.Location = new System.Drawing.Point(12, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 145);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Method";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Joint_checkBox
            // 
            this.Joint_checkBox.AutoSize = true;
            this.Joint_checkBox.Location = new System.Drawing.Point(22, 89);
            this.Joint_checkBox.Name = "Joint_checkBox";
            this.Joint_checkBox.Size = new System.Drawing.Size(103, 17);
            this.Joint_checkBox.TabIndex = 9;
            this.Joint_checkBox.Text = "Joint Distribution";
            this.Joint_checkBox.UseVisualStyleBackColor = true;
            this.Joint_checkBox.CheckedChanged += new System.EventHandler(this.Joint_checkBox_CheckedChanged);
            // 
            // Polar_Rejection
            // 
            this.Polar_Rejection.AutoSize = true;
            this.Polar_Rejection.Location = new System.Drawing.Point(22, 65);
            this.Polar_Rejection.Name = "Polar_Rejection";
            this.Polar_Rejection.Size = new System.Drawing.Size(97, 17);
            this.Polar_Rejection.TabIndex = 5;
            this.Polar_Rejection.TabStop = true;
            this.Polar_Rejection.Text = "Polar Rejection";
            this.Polar_Rejection.UseVisualStyleBackColor = true;
            this.Polar_Rejection.CheckedChanged += new System.EventHandler(this.PR_CheckedChanged);
            // 
            // Box_Muller
            // 
            this.Box_Muller.AutoSize = true;
            this.Box_Muller.Location = new System.Drawing.Point(22, 42);
            this.Box_Muller.Name = "Box_Muller";
            this.Box_Muller.Size = new System.Drawing.Size(74, 17);
            this.Box_Muller.TabIndex = 4;
            this.Box_Muller.TabStop = true;
            this.Box_Muller.Text = "Box-Muller";
            this.Box_Muller.UseVisualStyleBackColor = true;
            this.Box_Muller.CheckedChanged += new System.EventHandler(this.BM_CheckedChanged);
            // 
            // Add_Twelve
            // 
            this.Add_Twelve.AutoSize = true;
            this.Add_Twelve.Location = new System.Drawing.Point(22, 19);
            this.Add_Twelve.Name = "Add_Twelve";
            this.Add_Twelve.Size = new System.Drawing.Size(156, 17);
            this.Add_Twelve.TabIndex = 3;
            this.Add_Twelve.TabStop = true;
            this.Add_Twelve.Text = "Add Twelve Uniform Values";
            this.Add_Twelve.UseVisualStyleBackColor = true;
            this.Add_Twelve.CheckedChanged += new System.EventHandler(this.ATU_CheckedChanged);
            // 
            // Mean
            // 
            this.Mean.AutoSize = true;
            this.Mean.Location = new System.Drawing.Point(230, 170);
            this.Mean.Name = "Mean";
            this.Mean.Size = new System.Drawing.Size(40, 13);
            this.Mean.TabIndex = 12;
            this.Mean.Text = "Mean: ";
            this.Mean.Click += new System.EventHandler(this.label3_Click);
            // 
            // Mean_var
            // 
            this.Mean_var.AutoSize = true;
            this.Mean_var.Location = new System.Drawing.Point(262, 170);
            this.Mean_var.Name = "Mean_var";
            this.Mean_var.Size = new System.Drawing.Size(13, 13);
            this.Mean_var.TabIndex = 13;
            this.Mean_var.Text = "0";
            this.Mean_var.Click += new System.EventHandler(this.Mean_var_Click);
            // 
            // Variance
            // 
            this.Variance.AutoSize = true;
            this.Variance.Location = new System.Drawing.Point(316, 169);
            this.Variance.Name = "Variance";
            this.Variance.Size = new System.Drawing.Size(52, 13);
            this.Variance.TabIndex = 14;
            this.Variance.Text = "Variance:";
            // 
            // Variance_var
            // 
            this.Variance_var.AutoSize = true;
            this.Variance_var.Location = new System.Drawing.Point(363, 169);
            this.Variance_var.Name = "Variance_var";
            this.Variance_var.Size = new System.Drawing.Size(13, 13);
            this.Variance_var.TabIndex = 15;
            this.Variance_var.Text = "0";
            this.Variance_var.Click += new System.EventHandler(this.Variance_var_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 305);
            this.Controls.Add(this.Variance_var);
            this.Controls.Add(this.Variance);
            this.Controls.Add(this.Mean_var);
            this.Controls.Add(this.Mean);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Normal Number Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Rho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Polar_Rejection;
        private System.Windows.Forms.RadioButton Box_Muller;
        private System.Windows.Forms.RadioButton Add_Twelve;
        private System.Windows.Forms.CheckBox Joint_checkBox;
        private System.Windows.Forms.Label Mean;
        private System.Windows.Forms.Label Mean_var;
        private System.Windows.Forms.Label Variance;
        private System.Windows.Forms.Label Variance_var;
    }
}

