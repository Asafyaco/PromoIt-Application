
namespace PromoIt
{
    partial class SocialActivistInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocialActivistInfo));
            this.SA_Enter_Info_button = new System.Windows.Forms.Button();
            this.SA_PhoneNumber_textBox = new System.Windows.Forms.TextBox();
            this.SA_Address_textBox = new System.Windows.Forms.TextBox();
            this.SA_Email_textBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SA_Enter_Info_button
            // 
            this.SA_Enter_Info_button.Location = new System.Drawing.Point(538, 214);
            this.SA_Enter_Info_button.Name = "SA_Enter_Info_button";
            this.SA_Enter_Info_button.Size = new System.Drawing.Size(49, 44);
            this.SA_Enter_Info_button.TabIndex = 54;
            this.SA_Enter_Info_button.Text = "Enter";
            this.SA_Enter_Info_button.UseVisualStyleBackColor = true;
            this.SA_Enter_Info_button.Click += new System.EventHandler(this.SA_Enter_Info_button_Click);
            // 
            // SA_PhoneNumber_textBox
            // 
            this.SA_PhoneNumber_textBox.Location = new System.Drawing.Point(363, 256);
            this.SA_PhoneNumber_textBox.Name = "SA_PhoneNumber_textBox";
            this.SA_PhoneNumber_textBox.Size = new System.Drawing.Size(156, 23);
            this.SA_PhoneNumber_textBox.TabIndex = 53;
            // 
            // SA_Address_textBox
            // 
            this.SA_Address_textBox.Location = new System.Drawing.Point(363, 227);
            this.SA_Address_textBox.Name = "SA_Address_textBox";
            this.SA_Address_textBox.Size = new System.Drawing.Size(156, 23);
            this.SA_Address_textBox.TabIndex = 52;
            // 
            // SA_Email_textBox
            // 
            this.SA_Email_textBox.Location = new System.Drawing.Point(363, 198);
            this.SA_Email_textBox.Name = "SA_Email_textBox";
            this.SA_Email_textBox.Size = new System.Drawing.Size(156, 23);
            this.SA_Email_textBox.TabIndex = 51;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(202, 254);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(144, 25);
            this.label22.TabIndex = 50;
            this.label22.Text = "Phone Number:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(202, 225);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 25);
            this.label21.TabIndex = 49;
            this.label21.Text = "Address:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(202, 196);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 25);
            this.label20.TabIndex = 48;
            this.label20.Text = "Email:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(238, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(325, 32);
            this.label19.TabIndex = 47;
            this.label19.Text = "Social Activist Information:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(324, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 51);
            this.button1.TabIndex = 55;
            this.button1.Text = "Redeem your tweets here!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SocialActivistInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SA_Enter_Info_button);
            this.Controls.Add(this.SA_PhoneNumber_textBox);
            this.Controls.Add(this.SA_Address_textBox);
            this.Controls.Add(this.SA_Email_textBox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Name = "SocialActivistInfo";
            this.Text = "SocialActivistInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SA_Enter_Info_button;
        private System.Windows.Forms.TextBox SA_PhoneNumber_textBox;
        private System.Windows.Forms.TextBox SA_Address_textBox;
        private System.Windows.Forms.TextBox SA_Email_textBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
    }
}