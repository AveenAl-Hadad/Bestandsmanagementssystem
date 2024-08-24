namespace InventoryManagement.App
{
    partial class ManageProducts
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
            PGV = new DataGridView();
            PID = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pname = new TextBox();
            label4 = new Label();
            pqty = new TextBox();
            pprice = new TextBox();
            pdes = new TextBox();
            ccombo = new ComboBox();
            searchCombo = new ComboBox();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PGV).BeginInit();
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
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(848, 2);
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
            label2.Size = new Size(256, 37);
            label2.TabIndex = 1;
            label2.Text = "Produkte verwalten";
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
            panel2.Location = new Point(0, 661);
            panel2.Name = "panel2";
            panel2.Size = new Size(902, 20);
            panel2.TabIndex = 19;
            // 
            // PGV
            // 
            PGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PGV.BackgroundColor = Color.White;
            PGV.BorderStyle = BorderStyle.None;
            PGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            PGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Crimson;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            PGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            PGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            PGV.DefaultCellStyle = dataGridViewCellStyle2;
            PGV.EnableHeadersVisualStyles = false;
            PGV.GridColor = Color.Gainsboro;
            PGV.Location = new Point(332, 224);
            PGV.Name = "PGV";
            PGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            PGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            PGV.RowHeadersVisible = false;
            PGV.Size = new Size(550, 417);
            PGV.TabIndex = 20;
            PGV.CellContentClick += PGV_CellContentClick;
            // 
            // PID
            // 
            PID.BorderStyle = BorderStyle.FixedSingle;
            PID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PID.ForeColor = Color.MediumSlateBlue;
            PID.Location = new Point(12, 230);
            PID.Name = "PID";
            PID.PlaceholderText = " Produkte ID";
            PID.Size = new Size(248, 29);
            PID.TabIndex = 21;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumSlateBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(113, 576);
            button4.Name = "button4";
            button4.Size = new Size(102, 39);
            button4.TabIndex = 26;
            button4.Text = "Startseite";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSlateBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(221, 515);
            button3.Name = "button3";
            button3.Size = new Size(96, 39);
            button3.TabIndex = 25;
            button3.Text = "löschen";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSlateBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(113, 515);
            button2.Name = "button2";
            button2.Size = new Size(102, 39);
            button2.TabIndex = 24;
            button2.Text = "bearbeiten";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSlateBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 515);
            button1.Name = "button1";
            button1.Size = new Size(104, 39);
            button1.TabIndex = 23;
            button1.Text = "speichern";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pname
            // 
            pname.BorderStyle = BorderStyle.FixedSingle;
            pname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pname.ForeColor = Color.MediumSlateBlue;
            pname.Location = new Point(12, 274);
            pname.Name = "pname";
            pname.PlaceholderText = "Produkte Name";
            pname.Size = new Size(248, 29);
            pname.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Crimson;
            label4.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(470, 125);
            label4.Name = "label4";
            label4.Size = new Size(256, 37);
            label4.TabIndex = 27;
            label4.Text = "Produkte verwalten";
            // 
            // pqty
            // 
            pqty.BorderStyle = BorderStyle.FixedSingle;
            pqty.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pqty.ForeColor = Color.MediumSlateBlue;
            pqty.Location = new Point(12, 318);
            pqty.Name = "pqty";
            pqty.PlaceholderText = "Produkte Menge";
            pqty.Size = new Size(248, 29);
            pqty.TabIndex = 28;
            // 
            // pprice
            // 
            pprice.BorderStyle = BorderStyle.FixedSingle;
            pprice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pprice.ForeColor = Color.MediumSlateBlue;
            pprice.Location = new Point(12, 364);
            pprice.Name = "pprice";
            pprice.PlaceholderText = "Produkte Preise";
            pprice.Size = new Size(248, 29);
            pprice.TabIndex = 29;
            // 
            // pdes
            // 
            pdes.BorderStyle = BorderStyle.FixedSingle;
            pdes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pdes.ForeColor = Color.MediumSlateBlue;
            pdes.Location = new Point(12, 410);
            pdes.Name = "pdes";
            pdes.PlaceholderText = "Produkt Beschreibung";
            pdes.Size = new Size(248, 29);
            pdes.TabIndex = 30;
            // 
            // ccombo
            // 
            ccombo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ccombo.ForeColor = SystemColors.WindowFrame;
            ccombo.FormattingEnabled = true;
            ccombo.Location = new Point(12, 456);
            ccombo.Name = "ccombo";
            ccombo.Size = new Size(248, 29);
            ccombo.TabIndex = 31;
            ccombo.Text = "Produkt Kategorien";
            // 
            // searchCombo
            // 
            searchCombo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchCombo.ForeColor = SystemColors.WindowFrame;
            searchCombo.FormattingEnabled = true;
            searchCombo.Location = new Point(400, 176);
            searchCombo.Name = "searchCombo";
            searchCombo.Size = new Size(248, 29);
            searchCombo.TabIndex = 32;
            searchCombo.Text = " Kategorien auswählen";
            // 
            // button5
            // 
            button5.BackColor = Color.MediumSlateBlue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(649, 176);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 33;
            button5.Text = "Suche";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.MediumSlateBlue;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(746, 175);
            button6.Name = "button6";
            button6.Size = new Size(111, 29);
            button6.TabIndex = 34;
            button6.Text = "Aktualisiern";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 681);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(searchCombo);
            Controls.Add(ccombo);
            Controls.Add(pdes);
            Controls.Add(pprice);
            Controls.Add(pqty);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pname);
            Controls.Add(PID);
            Controls.Add(PGV);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageProducts";
            Load += ManageProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private DataGridView PGV;
        private TextBox PID;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox pname;
        private Label label4;
        private TextBox pqty;
        private TextBox pprice;
        private TextBox pdes;
        private ComboBox ccombo;
        private ComboBox searchCombo;
        private Button button5;
        private Button button6;
    }
}