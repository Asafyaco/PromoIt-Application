
namespace PromoIt
{
    partial class SocialActivistRegistretion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocialActivistRegistretion));
            this.SA_Enter_Reg_button = new System.Windows.Forms.Button();
            this.SA_Password_textBox = new System.Windows.Forms.TextBox();
            this.SA_UserName_textBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SA_Enter_Reg_button
            // 
            this.SA_Enter_Reg_button.Location = new System.Drawing.Point(499, 202);
            this.SA_Enter_Reg_button.Name = "SA_Enter_Reg_button";
            this.SA_Enter_Reg_button.Size = new System.Drawing.Size(49, 46);
            this.SA_Enter_Reg_button.TabIndex = 51;
            this.SA_Enter_Reg_button.Text = "Enter";
            this.SA_Enter_Reg_button.UseVisualStyleBackColor = true;
            this.SA_Enter_Reg_button.Click += new System.EventHandler(this.SA_Enter_Reg_button_Click);
            // 
            // SA_Password_textBox
            // 
            this.SA_Password_textBox.Location = new System.Drawing.Point(362, 232);
            this.SA_Password_textBox.Name = "SA_Password_textBox";
            this.SA_Password_textBox.Size = new System.Drawing.Size(100, 23);
            this.SA_Password_textBox.TabIndex = 50;
            // 
            // SA_UserName_textBox
            // 
            this.SA_UserName_textBox.Location = new System.Drawing.Point(362, 202);
            this.SA_UserName_textBox.Name = "SA_UserName_textBox";
            this.SA_UserName_textBox.Size = new System.Drawing.Size(100, 23);
            this.SA_UserName_textBox.TabIndex = 49;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(222, 231);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 25);
            this.label18.TabIndex = 48;
            this.label18.Text = "Password:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(222, 202);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 25);
            this.label17.TabIndex = 47;
            this.label17.Text = "User Name:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(222, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(326, 32);
            this.label16.TabIndex = 46;
            this.label16.Text = "Social Activist Registration:";
            // 
            // SocialActivistRegistretion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SA_Enter_Reg_button);
            this.Controls.Add(this.SA_Password_textBox);
            this.Controls.Add(this.SA_UserName_textBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Name = "SocialActivistRegistretion";
            this.Text = "SocialActivist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SA_Enter_Reg_button;
        private System.Windows.Forms.TextBox SA_Password_textBox;
        private System.Windows.Forms.TextBox SA_UserName_textBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}