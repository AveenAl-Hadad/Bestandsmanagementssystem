namespace InventoryManagement.App
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
            Panel1 = new Panel();
            ClearLb = new Label();
            pictureBox = new PictureBox();
            PasswordChb = new CheckBox();
            LoginBtn = new Button();
            PasswordTb = new TextBox();
            UnameTb = new TextBox();
            LoginLB = new Label();
            label2 = new Label();
            label3 = new Label();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.DodgerBlue;
            Panel1.Controls.Add(ClearLb);
            Panel1.Controls.Add(pictureBox);
            Panel1.Controls.Add(PasswordChb);
            Panel1.Controls.Add(LoginBtn);
            Panel1.Controls.Add(PasswordTb);
            Panel1.Controls.Add(UnameTb);
            Panel1.Controls.Add(LoginLB);
            Panel1.ForeColor = Color.White;
            Panel1.Location = new Point(218, 119);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(274, 392);
            Panel1.TabIndex = 0;
            // 
            // ClearLb
            // 
            ClearLb.AutoSize = true;
            ClearLb.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearLb.ForeColor = Color.Yellow;
            ClearLb.Location = new Point(187, 263);
            ClearLb.Name = "ClearLb";
            ClearLb.Size = new Size(41, 17);
            ClearLb.TabIndex = 7;
            ClearLb.Text = "Reset";
            ClearLb.Click += ClearLb_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackgroundImage = Properties.Resources.unternehmenskultur;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox.Location = new Point(89, 69);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(84, 61);
            pictureBox.TabIndex = 6;
            pictureBox.TabStop = false;
            // 
            // PasswordChb
            // 
            PasswordChb.AutoSize = true;
            PasswordChb.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordChb.ForeColor = Color.Yellow;
            PasswordChb.Location = new Point(20, 262);
            PasswordChb.Name = "PasswordChb";
            PasswordChb.Size = new Size(144, 21);
            PasswordChb.TabIndex = 5;
            PasswordChb.Text = "Kennwort anzeigen";
            PasswordChb.UseVisualStyleBackColor = true;
            PasswordChb.CheckedChanged += PasswordChb_CheckedChanged;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.White;
            LoginBtn.FlatAppearance.BorderSize = 0;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.DodgerBlue;
            LoginBtn.Location = new Point(65, 321);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(130, 30);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "ANMELDEN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // PasswordTb
            // 
            PasswordTb.BackColor = Color.DodgerBlue;
            PasswordTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTb.ForeColor = Color.White;
            PasswordTb.Location = new Point(20, 221);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(223, 29);
            PasswordTb.TabIndex = 2;
            PasswordTb.Text = "Kennwort";
            PasswordTb.UseSystemPasswordChar = true;
            // 
            // UnameTb
            // 
            UnameTb.BackColor = Color.DodgerBlue;
            UnameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnameTb.ForeColor = Color.White;
            UnameTb.Location = new Point(20, 170);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(223, 29);
            UnameTb.TabIndex = 1;
            UnameTb.Text = "Benutz Name";
            UnameTb.TextChanged += textBox1_TextChanged;
            // 
            // LoginLB
            // 
            LoginLB.AutoSize = true;
            LoginLB.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLB.ForeColor = Color.White;
            LoginLB.Location = new Point(77, 22);
            LoginLB.Name = "LoginLB";
            LoginLB.Size = new Size(114, 30);
            LoginLB.TabIndex = 0;
            LoginLB.Text = "Anmelden";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(118, 26);
            label2.Name = "label2";
            label2.Size = new Size(464, 37);
            label2.TabIndex = 1;
            label2.Text = "BESTANDSMANAGEMENTSSYSTEM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(677, 9);
            label3.Name = "label3";
            label3.Size = new Size(34, 37);
            label3.TabIndex = 3;
            label3.Text = "X";
            label3.Click += label3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pexels_tima_miroshnichenko_7567443;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(723, 599);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Panel1;
        private Label LoginLB;
        private Label label2;
        private TextBox UnameTb;
        private Button LoginBtn;
        private CheckBox PasswordChb;
        private PictureBox pictureBox;
        private TextBox PasswordTb;
        private Label ClearLb;
        private Label label3;
    }
}
