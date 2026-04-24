
namespace N_ICP
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.status_comboBox = new System.Windows.Forms.ComboBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.show_password_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 418);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(699, 485);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(829, 414);
            this.username_txt.Margin = new System.Windows.Forms.Padding(5);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(389, 32);
            this.username_txt.TabIndex = 0;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(829, 481);
            this.password_txt.Margin = new System.Windows.Forms.Padding(5);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(389, 32);
            this.password_txt.TabIndex = 1;
            this.password_txt.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(699, 577);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Login as";
            // 
            // status_comboBox
            // 
            this.status_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_comboBox.FormattingEnabled = true;
            this.status_comboBox.Items.AddRange(new object[] {
            "Manager",
            "Employee",
            "Distributor"});
            this.status_comboBox.Location = new System.Drawing.Point(829, 572);
            this.status_comboBox.Margin = new System.Windows.Forms.Padding(5);
            this.status_comboBox.Name = "status_comboBox";
            this.status_comboBox.Size = new System.Drawing.Size(389, 37);
            this.status_comboBox.TabIndex = 3;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(705, 623);
            this.login_btn.Margin = new System.Windows.Forms.Padding(5);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(249, 56);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(972, 623);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(5);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(249, 56);
            this.clear_btn.TabIndex = 5;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // show_password_checkBox
            // 
            this.show_password_checkBox.AutoSize = true;
            this.show_password_checkBox.Location = new System.Drawing.Point(829, 528);
            this.show_password_checkBox.Margin = new System.Windows.Forms.Padding(5);
            this.show_password_checkBox.Name = "show_password_checkBox";
            this.show_password_checkBox.Size = new System.Drawing.Size(197, 33);
            this.show_password_checkBox.TabIndex = 2;
            this.show_password_checkBox.Text = "Show Password";
            this.show_password_checkBox.UseVisualStyleBackColor = true;
            this.show_password_checkBox.CheckedChanged += new System.EventHandler(this.show_password_checkBox_CheckedChanged);
            // 
            // Login
            // 
            this.AcceptButton = this.login_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 1046);
            this.Controls.Add(this.show_password_checkBox);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.status_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Login";
            this.Text = "Login";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.username_txt, 0);
            this.Controls.SetChildIndex(this.password_txt, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.status_comboBox, 0);
            this.Controls.SetChildIndex(this.login_btn, 0);
            this.Controls.SetChildIndex(this.clear_btn, 0);
            this.Controls.SetChildIndex(this.show_password_checkBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox status_comboBox;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.CheckBox show_password_checkBox;
    }
}