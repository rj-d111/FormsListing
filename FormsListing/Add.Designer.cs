using System;
using System.Windows.Forms;

namespace FormsListing
{
    partial class Add
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
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_submit = new DelosSantos_Project.CustomControls.RoundButton();
            this.roundButton1 = new DelosSantos_Project.CustomControls.RoundButton();
            this.SuspendLayout();
            // 
            // txt_fname
            // 
            this.txt_fname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_fname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_fname.Location = new System.Drawing.Point(129, 69);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(270, 29);
            this.txt_fname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(21, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // txt_lname
            // 
            this.txt_lname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_lname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_lname.Location = new System.Drawing.Point(129, 114);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(270, 29);
            this.txt_lname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(21, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // txt_age
            // 
            this.txt_age.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_age.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_age.Location = new System.Drawing.Point(129, 161);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(89, 29);
            this.txt_age.TabIndex = 3;
            this.txt_age.KeyPress += Add_Form_KeyPressed;

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(21, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(153, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Add Members";
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_submit.BorderColor = System.Drawing.Color.Transparent;
            this.btn_submit.BorderRadius = 20;
            this.btn_submit.BorderSize = 0;
            this.btn_submit.FlatAppearance.BorderSize = 0;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Location = new System.Drawing.Point(234, 229);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(150, 40);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Red;
            this.roundButton1.BorderColor = System.Drawing.Color.Transparent;
            this.roundButton1.BorderRadius = 20;
            this.roundButton1.BorderSize = 0;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(78, 229);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(150, 40);
            this.roundButton1.TabIndex = 5;
            this.roundButton1.Text = "Clear";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 293);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_fname);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    



        #endregion

        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DelosSantos_Project.CustomControls.RoundButton btn_submit;
        private DelosSantos_Project.CustomControls.RoundButton roundButton1;
    }
}