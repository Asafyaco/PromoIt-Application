
namespace PromoIt
{
    partial class NonProfitRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NonProfitRegister));
            this.np_registretion_Enter_Button = new System.Windows.Forms.Button();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.UserNameNP_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // np_registretion_Enter_Button
            // 
            this.np_registretion_Enter_Button.Location = new System.Drawing.Point(435, 198);
            this.np_registretion_Enter_Button.Name = "np_registretion_Enter_Button";
            this.np_registretion_Enter_Button.Size = new System.Drawing.Size(47, 44);
            this.np_registretion_Enter_Button.TabIndex = 30;
            this.np_registretion_Enter_Button.Text = "Enter";
            this.np_registretion_Enter_Button.UseVisualStyleBackColor = true;
            this.np_registretion_Enter_Button.Click += new System.EventHandler(this.np_registretion_Enter_Button_Click);
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(329, 224);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(100, 23);
            this.Password_textBox.TabIndex = 29;
            // 
            // UserNameNP_textBox
            // 
            this.UserNameNP_textBox.Location = new System.Drawing.Point(329, 195);
            this.UserNameNP_textBox.Name = "UserNameNP_textBox";
            this.UserNameNP_textBox.Size = new System.Drawing.Size(100, 23);
            this.UserNameNP_textBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(224, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(224, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(310, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 31;
            this.label1.Text = "Join PromoIt";
            // 
            // NonProfitRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.np_registretion_Enter_Button);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.UserNameNP_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "NonProfitRegister";
            this.Text = "NonProfitRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button np_registretion_Enter_Button;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox UserNameNP_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}