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
namespace InventoryManagement.App
{
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InventoryDB;Integrated Security=True;Connect Timeout=30");
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                ccombo.ValueMember = "Kategorien_Name";
                ccombo.DataSource = dataTbl;
                searchCombo.ValueMember = "Kategorien_Name";
                searchCombo.DataSource = dataTbl;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Laden der Kategorien: " + ex.Message);
            }
        }
        void populate()
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
        void filterByCategoriy()
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


        private void ManageProducts_Load(object sender, EventArgs e)
        {
            fillcategory();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProdukteTbl values (" + PID.Text + ",'" + pname.Text + "'," + pqty.Text + "," + pprice.Text + ",'" + pdes.Text + "','" + ccombo.SelectedValue.ToString() + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Das Produkt wurde erfolgreich hinzufügt");
                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Hinzufügen des Produkts: " + ex.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PID.Text == "")
            {
                MessageBox.Show("Geben Sie die Id da Produkt ein");
            }
            else
            {
                con.Open();
                string myquery = " delete from ProdukteTbl where Id ='" + PID.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Das Produkt wurde erfolgreich gelöscht");
                con.Close();
                populate();
            }
        }

        private void PGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = PGV.Rows[e.RowIndex];
                PID.Text = row.Cells[0].Value.ToString();
                pname.Text = row.Cells[1].Value.ToString();
                pqty.Text = row.Cells[2].Value.ToString();
                pprice.Text = row.Cells[3].Value.ToString();
                pdes.Text = row.Cells[4].Value.ToString();
                ccombo.SelectedValue = row.Cells[5].Value.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update ProdukteTbl set Id=" + PID.Text + ",Name='" + pname.Text + "',Menge=" + pqty.Text + ",Preise=" + pprice.Text + ",Beschreibung='" + pdes.Text + "',KName='" + ccombo.SelectedValue.ToString() + "' where Id=" + PID.Text + "", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Das Produkt wurde erfolgreich Aktualisiert");
                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Aktualisieren des Produkts: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            filterByCategoriy();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
