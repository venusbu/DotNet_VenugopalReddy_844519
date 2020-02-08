namespace DataAccessWithDataAdapter
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
            this.gvProducts = new System.Windows.Forms.DataGridView();
            this.btnCategories = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gvProducts
            // 
            this.gvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProducts.Location = new System.Drawing.Point(37, 69);
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.Size = new System.Drawing.Size(526, 403);
            this.gvProducts.TabIndex = 1;
            // 
            // btnCategories
            // 
            this.btnCategories.Location = new System.Drawing.Point(619, 27);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(266, 23);
            this.btnCategories.TabIndex = 2;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 508);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.gvProducts);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Data Access Using Data Adapter and DataSet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gvProducts;
        private System.Windows.Forms.Button btnCategories;
    }
}

