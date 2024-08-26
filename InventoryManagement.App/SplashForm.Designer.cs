namespace InventoryManagement.App
{
    partial class SplashForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            progress = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            Prozent = new Label();
            Lodinglbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(82, 9);
            label1.Name = "label1";
            label1.Size = new Size(535, 45);
            label1.TabIndex = 1;
            label1.Text = "BESTANDSMANAGEMENTSSYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(171, 71);
            label2.Name = "label2";
            label2.Size = new Size(295, 25);
            label2.TabIndex = 2;
            label2.Text = "Entwickeld vom Aveen Al-Hadad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(579, 71);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 3;
            label3.Text = "Version 1.0";
            // 
            // progress
            // 
            progress.ForeColor = Color.White;
            progress.Location = new Point(12, 228);
            progress.Name = "progress";
            progress.Size = new Size(687, 22);
            progress.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(206, 338);
            label4.Name = "label4";
            label4.Size = new Size(242, 20);
            label4.TabIndex = 6;
            label4.Text = "Entwickeld vom Aveen Al-Hadad";
            // 
            // Prozent
            // 
            Prozent.AutoSize = true;
            Prozent.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Prozent.ForeColor = Color.White;
            Prozent.Location = new Point(517, 205);
            Prozent.Name = "Prozent";
            Prozent.Size = new Size(0, 20);
            Prozent.TabIndex = 7;
            // 
            // Lodinglbl
            // 
            Lodinglbl.AutoSize = true;
            Lodinglbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lodinglbl.ForeColor = Color.White;
            Lodinglbl.Location = new Point(69, 200);
            Lodinglbl.Name = "Lodinglbl";
            Lodinglbl.Size = new Size(0, 21);
            Lodinglbl.TabIndex = 8;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(711, 360);
            Controls.Add(Lodinglbl);
            Controls.Add(Prozent);
            Controls.Add(label4);
            Controls.Add(progress);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashForm";
            Load += SplashForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ProgressBar progress;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private Label Prozent;
        private Label Lodinglbl;
    }
}