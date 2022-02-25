
namespace Form1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmpTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hello_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EmpTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NameTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Hello_btn);
            this.panel1.Location = new System.Drawing.Point(108, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 281);
            this.panel1.TabIndex = 0;
            // 
            // EmpTxt
            // 
            this.EmpTxt.Location = new System.Drawing.Point(209, 101);
            this.EmpTxt.Name = "EmpTxt";
            this.EmpTxt.Size = new System.Drawing.Size(244, 27);
            this.EmpTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Emp ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(209, 52);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(244, 27);
            this.NameTxt.TabIndex = 2;
            this.NameTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Name:";
            // 
            // Hello_btn
            // 
            this.Hello_btn.Location = new System.Drawing.Point(52, 211);
            this.Hello_btn.Name = "Hello_btn";
            this.Hello_btn.Size = new System.Drawing.Size(94, 29);
            this.Hello_btn.TabIndex = 0;
            this.Hello_btn.Text = "Hello";
            this.Hello_btn.UseVisualStyleBackColor = true;
            this.Hello_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Hello_btn;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmpTxt;
    }
}

