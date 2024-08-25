using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace InventoryManagement.App
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InventoryDB;Integrated Security=True;Connect Timeout=30");
        void populateOrders()
        {
            try
            {
                con.Open();
                string Myquery = "select * from BestellungenTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OGV.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populateOrders();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        int idC;
        int idO;
        string Cname;
        int TotAmount;
        DateTime orderDate;
        private void OGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = OGV.Rows[e.RowIndex];
                 idC =Convert.ToInt32(row.Cells[0].Value.ToString());
                idO = Convert.ToInt32(row.Cells[1].Value.ToString());
                Cname =row.Cells[2].Value.ToString();
                orderDate =DateTime.Parse(row.Cells[3].Value.ToString());
                TotAmount = Convert.ToInt32(row.Cells[4].Value.ToString());
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Bestellübersicht", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bestell Id:" +idC, new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80,100));
            e.Graphics.DrawString("Kunden Id:" + idO, new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 130));
            e.Graphics.DrawString("Kunden Name:" + Cname, new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 160));
            e.Graphics.DrawString("Bestelldatum:" + orderDate.ToShortDateString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 190));
            e.Graphics.DrawString("Gesamtbetrag:" + TotAmount, new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 230));

        }
    }
}
