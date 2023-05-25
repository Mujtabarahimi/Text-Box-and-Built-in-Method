namespace text
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
            this.textBox1num1 = new System.Windows.Forms.TextBox();
            this.show = new System.Windows.Forms.Button();
            this.lable1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1num1
            // 
            this.textBox1num1.Location = new System.Drawing.Point(298, 34);
            this.textBox1num1.Multiline = true;
            this.textBox1num1.Name = "textBox1num1";
            this.textBox1num1.Size = new System.Drawing.Size(149, 58);
            this.textBox1num1.TabIndex = 0;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(332, 138);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(66, 52);
            this.show.TabIndex = 1;
            this.show.Text = "show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(313, 252);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(97, 13);
            this.lable1.TabIndex = 2;
            this.lable1.Text = "_______________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.show);
            this.Controls.Add(this.textBox1num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1num1;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Label lable1;
    }
}

