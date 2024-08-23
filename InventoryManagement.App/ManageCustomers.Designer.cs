namespace InventoryManagement.App
{
    partial class ManageCustomers
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
            CustomerID = new TextBox();
            Cname = new TextBox();
            Cphone = new TextBox();
            label4 = new Label();
            CustomersGV = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).BeginInit();
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
            panel1.TabIndex = 1;
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
            label2.Size = new Size(239, 37);
            label2.TabIndex = 1;
            label2.Text = "Kunden verwalten";
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
            // CustomerID
            // 
            CustomerID.BorderStyle = BorderStyle.FixedSingle;
            CustomerID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerID.ForeColor = Color.MediumSlateBlue;
            CustomerID.Location = new Point(12, 244);
            CustomerID.Name = "CustomerID";
            CustomerID.PlaceholderText = "Kunde ID";
            CustomerID.Size = new Size(248, 29);
            CustomerID.TabIndex = 2;
            // 
            // Cname
            // 
            Cname.BorderStyle = BorderStyle.FixedSingle;
            Cname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cname.ForeColor = Color.MediumSlateBlue;
            Cname.Location = new Point(12, 297);
            Cname.Name = "Cname";
            Cname.PlaceholderText = "Kunde Name";
            Cname.Size = new Size(248, 29);
            Cname.TabIndex = 3;
            // 
            // Cphone
            // 
            Cphone.BorderStyle = BorderStyle.FixedSingle;
            Cphone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cphone.ForeColor = Color.MediumSlateBlue;
            Cphone.Location = new Point(12, 356);
            Cphone.Name = "Cphone";
            Cphone.PlaceholderText = "  Kunde Telefon";
            Cphone.Size = new Size(248, 29);
            Cphone.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(503, 136);
            label4.Name = "label4";
            label4.Size = new Size(200, 37);
            label4.TabIndex = 12;
            label4.Text = "KUNDEN LISTE";
            // 
            // CustomersGV
            // 
            CustomersGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomersGV.BackgroundColor = Color.White;
            CustomersGV.BorderStyle = BorderStyle.None;
            CustomersGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CustomersGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Crimson;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CustomersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CustomersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            CustomersGV.DefaultCellStyle = dataGridViewCellStyle2;
            CustomersGV.EnableHeadersVisualStyles = false;
            CustomersGV.GridColor = Color.Gainsboro;
            CustomersGV.Location = new Point(371, 188);
            CustomersGV.Name = "CustomersGV";
            CustomersGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            CustomersGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            CustomersGV.RowHeadersVisible = false;
            CustomersGV.Size = new Size(489, 422);
            CustomersGV.TabIndex = 13;
            CustomersGV.CellContentClick += CustomersGV_CellContentClick_1;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSlateBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 474);
            button1.Name = "button1";
            button1.Size = new Size(104, 39);
            button1.TabIndex = 14;
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
            button2.Location = new Point(122, 474);
            button2.Name = "button2";
            button2.Size = new Size(102, 39);
            button2.TabIndex = 15;
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
            button3.Location = new Point(230, 474);
            button3.Name = "button3";
            button3.Size = new Size(96, 39);
            button3.TabIndex = 16;
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
            button4.Location = new Point(122, 535);
            button4.Name = "button4";
            button4.Size = new Size(102, 39);
            button4.TabIndex = 17;
            button4.Text = "Startseite";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSlateBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 636);
            panel2.Name = "panel2";
            panel2.Size = new Size(902, 20);
            panel2.TabIndex = 18;
            // 
            // ManageeCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(902, 656);
            Controls.Add(panel2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CustomersGV);
            Controls.Add(label4);
            Controls.Add(Cphone);
            Controls.Add(Cname);
            Controls.Add(CustomerID);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageeCustomers";
            Text = "ManageeCustomers";
            Load += ManageeCustomers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox CustomerID;
        private TextBox Cname;
        private TextBox Cphone;
        private Label label4;
        private DataGridView CustomersGV;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel2;
    }
}