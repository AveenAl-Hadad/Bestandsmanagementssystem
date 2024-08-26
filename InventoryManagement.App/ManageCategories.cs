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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InventoryDB;Integrated Security=True;Connect Timeout=30");

        /// <summary>
        /// Get Data vom DB Categorie
        /// </summary>
        void populate()
        {
            try
            {
                con.Open();
                string Myquery = "select * from KategorienTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CategoriesGV.DataSource = ds.Tables[0];
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Laden der Daten: " + ex.Message);
            }
        }
       /// <summary>
       /// Add
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into KategorienTbl values('" + CID.Text + "','" + Cname.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Die Kategorie wurde erfolgreich hinzufügt");
                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Hinzufügen der Kategorie: " + ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoriesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CategoriesGV.Rows[e.RowIndex];
                CID.Text = row.Cells[0].Value.ToString();
                Cname.Text = row.Cells[1].Value.ToString();
            }
        }
        // bearbeiten
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE KategorienTbl SET [Kategorien_ID] = @id, [Kategorien_Name] = @Cname WHERE [Kategorien_ID] = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", CID.Text);
                cmd.Parameters.AddWithValue("@Cname", Cname.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Die Kategorie wurde erfolgreich aktualisiert");
                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Aktualisieren der Kategorie: " + ex.Message);
            }
        }
        // Löschen
        private void button3_Click(object sender, EventArgs e)
        {
            if (CID.Text == "")
            {
                MessageBox.Show("Geben Sie die Id der Kategorie ein");
            }
            else
            {
                con.Open();
                string myquery = " delete from KategorienTbl where Kategorien_ID ='" + CID.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Die Kategorie wurde erfolgreich gelöscht");
                con.Close();
                populate();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
