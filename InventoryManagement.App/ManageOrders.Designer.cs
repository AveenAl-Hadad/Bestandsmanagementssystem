namespace InventoryManagement.App
{
    partial class ManageOrders
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            CGV = new DataGridView();
            OID = new TextBox();
            CID = new TextBox();
            Odate = new DateTimePicker();
            panel2 = new Panel();
            label5 = new Label();
            searchCombo = new ComboBox();
            PGV = new DataGridView();
            label6 = new Label();
            qtyTb = new TextBox();
            button5 = new Button();
            OGV = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Kname = new TextBox();
            labl = new Label();
            TotAmount = new Label();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OGV).BeginInit();
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
            panel1.Size = new Size(961, 109);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(924, 0);
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
            label2.Size = new Size(272, 37);
            label2.TabIndex = 1;
            label2.Text = "Bestellung verwalten";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumSlateBlue;
            label4.Location = new Point(109, 111);
            label4.Name = "label4";
            label4.Size = new Size(161, 30);
            label4.TabIndex = 28;
            label4.Text = "KUNDEN LISTE";
            // 
            // CGV
            // 
            CGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CGV.BackgroundColor = Color.White;
            CGV.BorderStyle = BorderStyle.None;
            CGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Crimson;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            CGV.DefaultCellStyle = dataGridViewCellStyle2;
            CGV.EnableHeadersVisualStyles = false;
            CGV.GridColor = Color.Gainsboro;
            CGV.Location = new Point(13, 145);
            CGV.Name = "CGV";
            CGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            CGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            CGV.RowHeadersVisible = false;
            CGV.Size = new Size(392, 210);
            CGV.TabIndex = 29;
            CGV.CellContentClick += CGV_CellContentClick;
            // 
            // OID
            // 
            OID.BorderStyle = BorderStyle.FixedSingle;
            OID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OID.ForeColor = Color.MediumSlateBlue;
            OID.Location = new Point(10, 368);
            OID.Name = "OID";
            OID.PlaceholderText = " Bestellung ID";
            OID.Size = new Size(248, 29);
            OID.TabIndex = 30;
            // 
            // CID
            // 
            CID.BorderStyle = BorderStyle.FixedSingle;
            CID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CID.ForeColor = Color.MediumSlateBlue;
            CID.Location = new Point(10, 403);
            CID.Name = "CID";
            CID.PlaceholderText = " Kunden ID";
            CID.Size = new Size(248, 29);
            CID.TabIndex = 31;
            // 
            // Odate
            // 
            Odate.CalendarForeColor = SystemColors.WindowFrame;
            Odate.CalendarMonthBackground = Color.White;
            Odate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Odate.Location = new Point(10, 502);
            Odate.Name = "Odate";
            Odate.Size = new Size(248, 25);
            Odate.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSlateBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 650);
            panel2.Name = "panel2";
            panel2.Size = new Size(961, 15);
            panel2.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MediumSlateBlue;
            label5.Location = new Point(10, 476);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 34;
            label5.Text = "Bestelldatum";
            label5.Click += label5_Click;
            // 
            // searchCombo
            // 
            searchCombo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchCombo.ForeColor = SystemColors.WindowFrame;
            searchCombo.FormattingEnabled = true;
            searchCombo.Location = new Point(549, 112);
            searchCombo.Name = "searchCombo";
            searchCombo.Size = new Size(248, 29);
            searchCombo.TabIndex = 35;
            searchCombo.Text = " Kategorien auswählen";
            searchCombo.SelectionChangeCommitted += searchCombo_SelectionChangeCommitted;
            // 
            // PGV
            // 
            PGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PGV.BackgroundColor = Color.White;
            PGV.BorderStyle = BorderStyle.None;
            PGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            PGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Crimson;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            PGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            PGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            PGV.DefaultCellStyle = dataGridViewCellStyle5;
            PGV.EnableHeadersVisualStyles = false;
            PGV.GridColor = Color.Gainsboro;
            PGV.Location = new Point(411, 143);
            PGV.Name = "PGV";
            PGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            PGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            PGV.RowHeadersVisible = false;
            PGV.Size = new Size(538, 212);
            PGV.TabIndex = 36;
            PGV.CellContentClick += PGV_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.MediumSlateBlue;
            label6.Location = new Point(385, 367);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 37;
            label6.Text = "Menge";
            // 
            // qtyTb
            // 
            qtyTb.BorderStyle = BorderStyle.FixedSingle;
            qtyTb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            qtyTb.ForeColor = Color.MediumSlateBlue;
            qtyTb.Location = new Point(463, 365);
            qtyTb.Name = "qtyTb";
            qtyTb.PlaceholderText = " ";
            qtyTb.Size = new Size(192, 29);
            qtyTb.TabIndex = 38;
            // 
            // button5
            // 
            button5.BackColor = Color.MediumSlateBlue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(657, 365);
            button5.Name = "button5";
            button5.Size = new Size(255, 29);
            button5.TabIndex = 39;
            button5.Text = "Zur Bestellungen hinzufügen";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // OGV
            // 
            OGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OGV.BackgroundColor = Color.White;
            OGV.BorderStyle = BorderStyle.None;
            OGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            OGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.Crimson;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            OGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            OGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            OGV.DefaultCellStyle = dataGridViewCellStyle8;
            OGV.EnableHeadersVisualStyles = false;
            OGV.GridColor = Color.Gainsboro;
            OGV.Location = new Point(343, 401);
            OGV.Name = "OGV";
            OGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.White;
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            OGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            OGV.RowHeadersVisible = false;
            OGV.Size = new Size(606, 212);
            OGV.TabIndex = 40;
            // 
            // Product
            // 
            Product.Name = "Product";
            // 
            // Kname
            // 
            Kname.BorderStyle = BorderStyle.FixedSingle;
            Kname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Kname.ForeColor = Color.MediumSlateBlue;
            Kname.Location = new Point(10, 438);
            Kname.Name = "Kname";
            Kname.PlaceholderText = " Kunden Name";
            Kname.Size = new Size(248, 29);
            Kname.TabIndex = 41;
            // 
            // labl
            // 
            labl.AutoSize = true;
            labl.BackColor = Color.Transparent;
            labl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labl.ForeColor = Color.MediumSlateBlue;
            labl.Location = new Point(576, 617);
            labl.Name = "labl";
            labl.Size = new Size(137, 25);
            labl.TabIndex = 42;
            labl.Text = "Gesamtbetrag";
            // 
            // TotAmount
            // 
            TotAmount.AutoSize = true;
            TotAmount.BackColor = Color.Transparent;
            TotAmount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotAmount.ForeColor = Color.Black;
            TotAmount.Location = new Point(716, 617);
            TotAmount.Name = "TotAmount";
            TotAmount.Size = new Size(35, 25);
            TotAmount.TabIndex = 43;
            TotAmount.Text = "RS";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSlateBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(10, 542);
            button1.Name = "button1";
            button1.Size = new Size(149, 50);
            button1.TabIndex = 44;
            button1.Text = "Zur Bestellungen einfügen";
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
            button2.Location = new Point(170, 541);
            button2.Name = "button2";
            button2.Size = new Size(143, 51);
            button2.TabIndex = 45;
            button2.Text = "Bestellungen ansehen";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumSlateBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(109, 603);
            button4.Name = "button4";
            button4.Size = new Size(102, 39);
            button4.TabIndex = 46;
            button4.Text = "Startseite";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // ManageOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(961, 665);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TotAmount);
            Controls.Add(labl);
            Controls.Add(Kname);
            Controls.Add(OGV);
            Controls.Add(button5);
            Controls.Add(qtyTb);
            Controls.Add(label6);
            Controls.Add(PGV);
            Controls.Add(searchCombo);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(Odate);
            Controls.Add(CID);
            Controls.Add(OID);
            Controls.Add(CGV);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageOrders";
            Text = "ManageOrders";
            Load += ManageOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)PGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)OGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private DataGridView CGV;
        private TextBox OID;
        private TextBox CID;
        private DateTimePicker Odate;
        private Panel panel2;
        private Label label5;
        private ComboBox searchCombo;
        private DataGridView PGV;
        private Label label6;
        private TextBox qtyTb;
        private Button button5;
        private DataGridView OGV;
        private DataGridViewTextBoxColumn Nr;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn TotPrice;
        private DataGridViewTextBoxColumn pqty;
        private TextBox Kname;
        private Label labl;
        private Label TotAmount;
        private Button button1;
        private Button button2;
        private Button button4;
    }
}