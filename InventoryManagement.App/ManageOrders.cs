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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InventoryDB;Integrated Security=True;Connect Timeout=30");
        int num = 0;
        int oprice;
        int ototprice;
        int oqty;
        string oproduct;
        DataTable table = new DataTable();
        void populateCustomers()
        {
            try
            {
                con.Open();
                string Myquery = "select * from KundenTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CGV.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }
        void populateProducts()
        {
            try
            {
                con.Open();
                string Myquery = "select * from ProdukteTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                PGV.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }
        void fillcategory()
        {
            string query = "select * from KategorienTbl";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dataTbl = new DataTable();
                rdr = cmd.ExecuteReader();
                dataTbl.Load(rdr);

                searchCombo.ValueMember = "Kategorien_Name";
                searchCombo.DataSource = dataTbl;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Laden der Kategorien: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populateCustomers();
            populateProducts();
            fillcategory();
            table.Columns.Add("Nummer", typeof(int));
            table.Columns.Add("Produkt", typeof(string));
            table.Columns.Add("Menge", typeof(int));
            table.Columns.Add("Preis", typeof(int));
            table.Columns.Add("Gesamtpreis", typeof(int));

            OGV.DataSource = table;
            
        }
                private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CGV.Rows[e.RowIndex];
                CID.Text = row.Cells[0].Value.ToString();
            }
        }

        private void searchCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
          try
            {
                con.Open();
                string Myquery = "select * from ProdukteTbl where KName ='" + searchCombo.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                PGV.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }
        int flag = 0;
        int stock;
        int id;
        private void PGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = PGV.Rows[e.RowIndex];
                oproduct = row.Cells[1].Value.ToString();
                //oqty = Convert.ToInt32(qtyTb.Text);
                stock = Convert.ToInt32(row.Cells[2].Value.ToString());
                id = Convert.ToInt32(row.Cells[0].Value.ToString());
                oprice = Convert.ToInt32(row.Cells[3].Value.ToString());
                //ototprice = oqty * oprice;
                flag = 1;
            }
        }
        int sum = 0;      
        private void button5_Click(object sender, EventArgs e)
        {
            if (qtyTb.Text == "")
                MessageBox.Show("Geben Sie die Menge der Produkte ein");
            else if (flag == 0)
                MessageBox.Show("Wählen Sie die Produkte");
            else if (Convert.ToInt32(qtyTb.Text) > stock)
               MessageBox.Show("nicht genügend Lagerbestand vorhanden");
            else
            {
                num = num + 1;
                oqty = Convert.ToInt32(qtyTb.Text);
                ototprice = oqty * oprice;
                table.Rows.Add(num, oproduct, oqty, oprice, ototprice);
                OGV.DataSource = table;
                flag = 0;

                // Aktualisieren des Lagerbestands nach dem Hinzufügen der Bestellung
                updateproducts();
            }
            sum = sum + ototprice;
            TotAmount.Text = "Rs " + sum.ToString();

        }
        void updateproducts()
        {
            try
            {
                    //int id = Convert.ToInt32(PGV.SelectedRows[0].Cells[0].Value.ToString());
                    con.Open();
                    int newQty = stock - Convert.ToInt32(qtyTb.Text);
                    string query = "UPDATE ProdukteTbl SET Menge = @newQty WHERE Id = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@newQty", newQty);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    populateProducts();
            }
                
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Aktualisieren der Produkte: " + ex.Message);
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
       
    }
}
