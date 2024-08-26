namespace InventoryManagement.App
{
    partial class ManageCategories
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            CID = new TextBox();
            Cname = new TextBox();
            CategoriesGV = new DataGridView();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoriesGV).BeginInit();
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
            panel1.Size = new Size(902, 100);
            panel1.TabIndex = 2;
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
            label2.Size = new Size(278, 37);
            label2.TabIndex = 1;
            label2.Text = "Kategorien verwalten";
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
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSlateBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 641);
            panel2.Name = "panel2";
            panel2.Size = new Size(902, 15);
            panel2.TabIndex = 19;
            // 
            // CID
            // 
            CID.BorderStyle = BorderStyle.FixedSingle;
            CID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CID.ForeColor = Color.MediumSlateBlue;
            CID.Location = new Point(28, 218);
            CID.Name = "CID";
            CID.PlaceholderText = " Kategorie ID";
            CID.Size = new Size(291, 29);
            CID.TabIndex = 20;
            // 
            // Cname
            // 
            Cname.BorderStyle = BorderStyle.FixedSingle;
            Cname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cname.ForeColor = Color.MediumSlateBlue;
            Cname.Location = new Point(28, 285);
            Cname.Name = "Cname";
            Cname.PlaceholderText = " Kategorie Name";
            Cname.Size = new Size(291, 29);
            Cname.TabIndex = 21;
            // 
            // CategoriesGV
            // 
            CategoriesGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CategoriesGV.BackgroundColor = Color.White;
            CategoriesGV.BorderStyle = BorderStyle.None;
            CategoriesGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CategoriesGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Crimson;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CategoriesGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CategoriesGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            CategoriesGV.DefaultCellStyle = dataGridViewCellStyle2;
            CategoriesGV.EnableHeadersVisualStyles = false;
            CategoriesGV.GridColor = Color.Gainsboro;
            CategoriesGV.Location = new Point(389, 186);
            CategoriesGV.Name = "CategoriesGV";
            CategoriesGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            CategoriesGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            CategoriesGV.RowHeadersVisible = false;
            CategoriesGV.Size = new Size(489, 422);
            CategoriesGV.TabIndex = 23;
            CategoriesGV.CellContentClick += CategoriesGV_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(506, 137);
            label4.Name = "label4";
            label4.Size = new Size(250, 37);
            label4.TabIndex = 24;
            label4.Text = "KATEGORIEN LISTE";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSlateBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(28, 385);
            button1.Name = "button1";
            button1.Size = new Size(104, 39);
            button1.TabIndex = 25;
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
            button2.Location = new Point(138, 385);
            button2.Name = "button2";
            button2.Size = new Size(102, 39);
            button2.TabIndex = 26;
            button2.Text = "bearbeiten";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSlateBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(246, 385);
            button3.Name = "button3";
            button3.Size = new Size(96, 39);
            button3.TabIndex = 27;
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
            button4.Location = new Point(138, 445);
            button4.Name = "button4";
            button4.Size = new Size(102, 39);
            button4.TabIndex = 28;
            button4.Text = "Startseite";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // ManageCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(902, 656);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(CategoriesGV);
            Controls.Add(Cname);
            Controls.Add(CID);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCategories";
            Load += ManageCategories_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CategoriesGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox CID;
        private TextBox Cname;
        private DataGridView CategoriesGV;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}