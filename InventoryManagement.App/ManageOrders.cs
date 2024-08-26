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
                Kname.Text = row.Cells[1].Value.ToString();
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
                int newQty = stock - Convert.ToInt32(qtyTb.Text);
                if (newQty < 0)
                {
                    MessageBox.Show("Vorgang ist fehlgeschlagen");
                }
                else
                {
                    con.Open();
                    string query = "UPDATE ProdukteTbl SET Menge = @newQty WHERE Id = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@newQty", newQty);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    populateProducts();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Aktualisieren der Produkte: " + ex.Message);
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OID.Text) || string.IsNullOrWhiteSpace(CID.Text) || string.IsNullOrWhiteSpace(Kname.Text) || string.IsNullOrWhiteSpace(TotAmount.Text))
            {
                MessageBox.Show("Füllen Sie die Daten korrekt aus.");
                return;
            }

            try
            {
                con.Open();

                // SQL-Abfrage mit Parametern
                string query = "INSERT INTO BestellungenTbl (Bestell_Id, Kunden_Id, Kunden_Name, Bestelldatum, Gesamtbetrag) VALUES (@OID, @CID, @Kname, @Odate, @TotAmount)";
                SqlCommand cmd = new SqlCommand(query, con);

                // Parameter hinzufügen und sicherstellen, dass sie die richtigen Datentypen haben
                cmd.Parameters.AddWithValue("@OID", Convert.ToInt32(OID.Text)); // OID ist int
                cmd.Parameters.AddWithValue("@CID", Convert.ToInt32(CID.Text)); // CID ist int
                cmd.Parameters.AddWithValue("@Kname", Kname.Text); // Kname ist varchar(50)

                // Odate ist DateTime, daher versuchen wir, es zu konvertieren
                DateTime orderDate;
                if (DateTime.TryParse(Odate.Text, out orderDate))
                {
                    cmd.Parameters.AddWithValue("@Odate", orderDate); // Datum korrekt als Parameter hinzufügen
                }
                else
                {
                    MessageBox.Show("Ungültiges Datum.");
                    return;
                }

                // TotAmount ist int, daher konvertieren wir den Text in eine Ganzzahl
                int totalAmount;
                if (int.TryParse(TotAmount.Text.Replace("Rs ", ""), out totalAmount))
                {
                    cmd.Parameters.AddWithValue("@TotAmount", totalAmount);
                }
                else
                {
                    MessageBox.Show("Ungültiger Gesamtbetrag.");
                    return;
                }

                // Ausführen der SQL-Abfrage
                cmd.ExecuteNonQuery();
                MessageBox.Show("Die Bestellung wurde erfolgreich hinzugefügt.");
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL-Fehler: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Allgemeiner Fehler: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
