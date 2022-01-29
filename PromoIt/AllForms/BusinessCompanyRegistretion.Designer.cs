
namespace PromoIt
{
    partial class BusinessCompanyRegistretion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessCompanyRegistretion));
            this.BCR_registretion_enter_button = new System.Windows.Forms.Button();
            this.PASS_BC_TEXTBOX = new System.Windows.Forms.TextBox();
            this.UserNameBC_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BCR_registretion_enter_button
            // 
            this.BCR_registretion_enter_button.Location = new System.Drawing.Point(505, 220);
            this.BCR_registretion_enter_button.Name = "BCR_registretion_enter_button";
            this.BCR_registretion_enter_button.Size = new System.Drawing.Size(44, 43);
            this.BCR_registretion_enter_button.TabIndex = 61;
            this.BCR_registretion_enter_button.Text = "Enter";
            this.BCR_registretion_enter_button.UseVisualStyleBackColor = true;
            this.BCR_registretion_enter_button.Click += new System.EventHandler(this.BCR_registretion_enter_button_Click);
            // 
            // PASS_BC_TEXTBOX
            // 
            this.PASS_BC_TEXTBOX.Location = new System.Drawing.Point(399, 246);
            this.PASS_BC_TEXTBOX.Name = "PASS_BC_TEXTBOX";
            this.PASS_BC_TEXTBOX.Size = new System.Drawing.Size(100, 23);
            this.PASS_BC_TEXTBOX.TabIndex = 60;
            // 
            // UserNameBC_textBox
            // 
            this.UserNameBC_textBox.Location = new System.Drawing.Point(399, 217);
            this.UserNameBC_textBox.Name = "UserNameBC_textBox";
            this.UserNameBC_textBox.Size = new System.Drawing.Size(100, 23);
            this.UserNameBC_textBox.TabIndex = 59;
            this.UserNameBC_textBox.TextChanged += new System.EventHandler(this.UserNameBC_textBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(252, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 21);
            this.label10.TabIndex = 58;
            this.label10.Text = "Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(252, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 21);
            this.label9.TabIndex = 57;
            this.label9.Text = "User Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(296, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 32);
            this.label8.TabIndex = 56;
            this.label8.Text = "Join PromoIt";
            // 
            // BusinessCompanyRegistretion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BCR_registretion_enter_button);
            this.Controls.Add(this.PASS_BC_TEXTBOX);
            this.Controls.Add(this.UserNameBC_textBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "BusinessCompanyRegistretion";
            this.Text = "BusinessCompanyRegistretion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BCR_registretion_enter_button;
        private System.Windows.Forms.TextBox PASS_BC_TEXTBOX;
        private System.Windows.Forms.TextBox UserNameBC_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}