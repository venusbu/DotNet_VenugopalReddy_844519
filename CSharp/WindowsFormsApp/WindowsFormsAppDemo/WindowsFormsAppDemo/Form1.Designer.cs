namespace WindowsFormsAppDemo
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
            this.label2 = new System.Windows.Forms.Label();
            this.textFirst = new System.Windows.Forms.TextBox();
            this.textSecond = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.rdbsub = new System.Windows.Forms.RadioButton();
            this.rdbmul = new System.Windows.Forms.RadioButton();
            this.rdbdiv = new System.Windows.Forms.RadioButton();
            this.lblSolution = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter First Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Second Number";
            // 
            // textFirst
            // 
            this.textFirst.Location = new System.Drawing.Point(232, 81);
            this.textFirst.Name = "textFirst";
            this.textFirst.Size = new System.Drawing.Size(100, 20);
            this.textFirst.TabIndex = 2;
            this.textFirst.Text = "44";
            // 
            // textSecond
            // 
            this.textSecond.Location = new System.Drawing.Point(232, 120);
            this.textSecond.Name = "textSecond";
            this.textSecond.Size = new System.Drawing.Size(100, 20);
            this.textSecond.TabIndex = 3;
            this.textSecond.Text = "77";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get Solution";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbdiv);
            this.groupBox1.Controls.Add(this.rdbmul);
            this.groupBox1.Controls.Add(this.rdbsub);
            this.groupBox1.Controls.Add(this.rdbAdd);
            this.groupBox1.Location = new System.Drawing.Point(126, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 134);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Your Choice";
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(28, 19);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(63, 17);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Addition";
            this.rdbAdd.UseVisualStyleBackColor = true;
            // 
            // rdbsub
            // 
            this.rdbsub.AutoSize = true;
            this.rdbsub.Location = new System.Drawing.Point(28, 39);
            this.rdbsub.Name = "rdbsub";
            this.rdbsub.Size = new System.Drawing.Size(70, 17);
            this.rdbsub.TabIndex = 1;
            this.rdbsub.TabStop = true;
            this.rdbsub.Text = "Substract";
            this.rdbsub.UseVisualStyleBackColor = true;
            // 
            // rdbmul
            // 
            this.rdbmul.AutoSize = true;
            this.rdbmul.Location = new System.Drawing.Point(28, 62);
            this.rdbmul.Name = "rdbmul";
            this.rdbmul.Size = new System.Drawing.Size(60, 17);
            this.rdbmul.TabIndex = 2;
            this.rdbmul.TabStop = true;
            this.rdbmul.Text = "Multiply";
            this.rdbmul.UseVisualStyleBackColor = true;
            // 
            // rdbdiv
            // 
            this.rdbdiv.AutoSize = true;
            this.rdbdiv.Location = new System.Drawing.Point(28, 85);
            this.rdbdiv.Name = "rdbdiv";
            this.rdbdiv.Size = new System.Drawing.Size(62, 17);
            this.rdbdiv.TabIndex = 3;
            this.rdbdiv.TabStop = true;
            this.rdbdiv.Text = "Division";
            this.rdbdiv.UseVisualStyleBackColor = true;
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Location = new System.Drawing.Point(229, 160);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(37, 13);
            this.lblSolution.TabIndex = 6;
            this.lblSolution.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 409);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textSecond);
            this.Controls.Add(this.textFirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textFirst;
        private System.Windows.Forms.TextBox textSecond;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbdiv;
        private System.Windows.Forms.RadioButton rdbmul;
        private System.Windows.Forms.RadioButton rdbsub;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.Label lblSolution;
    }
}

