
namespace Bestiary
{
    partial class sign_up
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
            this.login_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.create_btn = new System.Windows.Forms.Button();
            this.pass_checkBox = new System.Windows.Forms.CheckBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_box
            // 
            this.login_box.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_box.Location = new System.Drawing.Point(98, 14);
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(148, 21);
            this.login_box.TabIndex = 0;
            // 
            // password_box
            // 
            this.password_box.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_box.Location = new System.Drawing.Point(98, 52);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(148, 21);
            this.password_box.TabIndex = 1;
            this.password_box.UseSystemPasswordChar = true;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.Location = new System.Drawing.Point(24, 20);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(48, 15);
            this.login_label.TabIndex = 2;
            this.login_label.Text = "Логин:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_label.Location = new System.Drawing.Point(24, 58);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(56, 15);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Пароль:";
            // 
            // create_btn
            // 
            this.create_btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_btn.Location = new System.Drawing.Point(19, 83);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(318, 27);
            this.create_btn.TabIndex = 4;
            this.create_btn.Text = "Создать аккаунт";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // pass_checkBox
            // 
            this.pass_checkBox.AutoSize = true;
            this.pass_checkBox.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_checkBox.Location = new System.Drawing.Point(252, 54);
            this.pass_checkBox.Name = "pass_checkBox";
            this.pass_checkBox.Size = new System.Drawing.Size(82, 19);
            this.pass_checkBox.TabIndex = 5;
            this.pass_checkBox.Text = "Показать";
            this.pass_checkBox.UseVisualStyleBackColor = true;
            this.pass_checkBox.CheckedChanged += new System.EventHandler(this.pass_checkBox_CheckedChanged);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_btn.Location = new System.Drawing.Point(19, 124);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(318, 27);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Вернуться к авторизации";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bestiary.Properties.Resources._57lo0xm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(357, 163);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.pass_checkBox);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.login_box);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "sign_up";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.sign_up_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.CheckBox pass_checkBox;
        private System.Windows.Forms.Button back_btn;
    }
}