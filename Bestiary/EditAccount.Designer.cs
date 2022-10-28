
namespace Bestiary
{
    partial class EditAccount
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
            this.login_box = new System.Windows.Forms.ComboBox();
            this.password_box = new System.Windows.Forms.ComboBox();
            this.login_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.chng_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_box
            // 
            this.login_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.login_box.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_box.FormattingEnabled = true;
            this.login_box.Location = new System.Drawing.Point(12, 16);
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(133, 23);
            this.login_box.TabIndex = 0;
            // 
            // password_box
            // 
            this.password_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.password_box.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_box.FormattingEnabled = true;
            this.password_box.Location = new System.Drawing.Point(12, 43);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(133, 23);
            this.password_box.TabIndex = 1;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.Location = new System.Drawing.Point(12, 19);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(42, 15);
            this.login_label.TabIndex = 2;
            this.login_label.Text = "label1";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_label.Location = new System.Drawing.Point(12, 46);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(42, 15);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "label1";
            // 
            // chng_btn
            // 
            this.chng_btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chng_btn.Location = new System.Drawing.Point(12, 82);
            this.chng_btn.Name = "chng_btn";
            this.chng_btn.Size = new System.Drawing.Size(133, 23);
            this.chng_btn.TabIndex = 4;
            this.chng_btn.Text = "Изменить данные";
            this.chng_btn.UseVisualStyleBackColor = true;
            this.chng_btn.Click += new System.EventHandler(this.chng_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_btn.Location = new System.Drawing.Point(12, 111);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(133, 23);
            this.del_btn.TabIndex = 5;
            this.del_btn.Text = "Удалить";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_btn.Location = new System.Drawing.Point(12, 140);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(133, 23);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bestiary.Properties.Resources._57lo0xm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(161, 177);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.chng_btn);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.login_box);
            this.Name = "EditAccount";
            this.Text = "CreateAcc1";
            this.Load += new System.EventHandler(this.EditAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox login_box;
        private System.Windows.Forms.ComboBox password_box;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button chng_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button back_btn;
    }
}