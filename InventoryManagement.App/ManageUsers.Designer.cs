namespace InventoryManagement.App
{
    partial class ManageUsers
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            UnameTb = new TextBox();
            FnameTb = new TextBox();
            UpasswordTb = new TextBox();
            UphoneTb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            UsersGv = new DataGridView();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 122);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(865, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 37);
            label3.TabIndex = 2;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(272, 60);
            label2.Name = "label2";
            label2.Size = new Size(253, 37);
            label2.TabIndex = 1;
            label2.Text = "Benutzer verwalten";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(139, 9);
            label1.Name = "label1";
            label1.Size = new Size(535, 45);
            label1.TabIndex = 0;
            label1.Text = "BESTANDSMANAGEMENTSSYSTEM";
            label1.Click += label1_Click;
            // 
            // UnameTb
            // 
            UnameTb.BorderStyle = BorderStyle.FixedSingle;
            UnameTb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UnameTb.ForeColor = Color.MediumSlateBlue;
            UnameTb.Location = new Point(12, 171);
            UnameTb.Name = "UnameTb";
            UnameTb.PlaceholderText = " Benutzername";
            UnameTb.Size = new Size(248, 29);
            UnameTb.TabIndex = 1;
            // 
            // FnameTb
            // 
            FnameTb.BorderStyle = BorderStyle.FixedSingle;
            FnameTb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FnameTb.ForeColor = Color.MediumSlateBlue;
            FnameTb.Location = new Point(12, 215);
            FnameTb.Name = "FnameTb";
            FnameTb.PlaceholderText = " vollständiger Name";
            FnameTb.Size = new Size(248, 29);
            FnameTb.TabIndex = 2;
            FnameTb.TextChanged += FnameTb_TextChanged;
            // 
            // UpasswordTb
            // 
            UpasswordTb.BorderStyle = BorderStyle.FixedSingle;
            UpasswordTb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpasswordTb.ForeColor = Color.MediumSlateBlue;
            UpasswordTb.Location = new Point(11, 262);
            UpasswordTb.Name = "UpasswordTb";
            UpasswordTb.PlaceholderText = " Kennwort";
            UpasswordTb.Size = new Size(248, 29);
            UpasswordTb.TabIndex = 3;
            // 
            // UphoneTb
            // 
            UphoneTb.BorderStyle = BorderStyle.FixedSingle;
            UphoneTb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UphoneTb.ForeColor = Color.MediumSlateBlue;
            UphoneTb.Location = new Point(12, 307);
            UphoneTb.Name = "UphoneTb";
            UphoneTb.PlaceholderText = "  Telefon";
            UphoneTb.Size = new Size(248, 29);
            UphoneTb.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSlateBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 375);
            button1.Name = "button1";
            button1.Size = new Size(104, 39);
            button1.TabIndex = 5;
            button1.Text = "speichern";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSlateBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(122, 375);
            button2.Name = "button2";
            button2.Size = new Size(102, 39);
            button2.TabIndex = 6;
            button2.Text = "bearbeiten";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSlateBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(230, 375);
            button3.Name = "button3";
            button3.Size = new Size(96, 39);
            button3.TabIndex = 7;
            button3.Text = "löschen";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumSlateBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(122, 439);
            button4.Name = "button4";
            button4.Size = new Size(102, 39);
            button4.TabIndex = 8;
            button4.Text = "Startseite";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // UsersGv
            // 
            UsersGv.BackgroundColor = Color.White;
            UsersGv.BorderStyle = BorderStyle.None;
            UsersGv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersGv.Location = new Point(381, 171);
            UsersGv.Name = "UsersGv";
            UsersGv.Size = new Size(489, 379);
            UsersGv.TabIndex = 9;
            UsersGv.CellContentClick += UsersGv_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSlateBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 577);
            panel2.Name = "panel2";
            panel2.Size = new Size(902, 14);
            panel2.TabIndex = 10;
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(902, 591);
            Controls.Add(panel2);
            Controls.Add(UsersGv);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(UphoneTb);
            Controls.Add(UpasswordTb);
            Controls.Add(FnameTb);
            Controls.Add(UnameTb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUser";
            Load += ManageUsers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox UnameTb;
        private TextBox FnameTb;
        private TextBox UpasswordTb;
        private TextBox UphoneTb;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView UsersGv;
        private Panel panel2;
        private Label label3;
    }
}