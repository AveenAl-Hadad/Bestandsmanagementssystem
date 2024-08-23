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
namespace InventoryManagement.App;

public partial class ManageeCustomers : Form
{
    public ManageeCustomers()
    {
        InitializeComponent();
        populate();
    }
    SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InventoryDB;Integrated Security=True;Connect Timeout=30");
    private void label3_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }


    // Speichern Btn
    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into KundenTbl values('" + CustomerID.Text + "','" + Cname.Text + "','" + Cphone.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Die Kunde wurde erfolgreich hinzufügt");
            con.Close();
            populate();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Fehler beim Hinzufügen der Kunde: " + ex.Message);
        }
    }
    // die Kunden Tabelle Daten vomm Datenbank aufrufen GET
    void populate()
    {
        try
        {
            con.Open();
            string Myquery = "select * from KundenTbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CustomersGV.DataSource = ds.Tables[0];
            con.Close();

        }
        catch (Exception ex)
        {
            MessageBox.Show("Fehler beim Laden der Daten: " + ex.Message);
        }
    }

    private void ManageeCustomers_Load(object sender, EventArgs e)
    {
        populate();
    }
    // bearbeiten 
    private void button2_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            string query = "UPDATE KundenTbl SET [Kunden_ID] = @id, [Kunden_Name] = @Cname, [Kunden_Telefon] = @CPhone  WHERE [Kunden_ID] = @id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", CustomerID.Text);
            cmd.Parameters.AddWithValue("@Cname", Cname.Text);
            cmd.Parameters.AddWithValue("@CPhone", Cphone.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Die Kunde wurde erfolgreich aktualisiert");
            con.Close();
            populate();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Fehler beim Aktualisieren der Kunden: " + ex.Message);
        }
    }
    // Löschen
    private void button3_Click(object sender, EventArgs e)
    {
        if (CustomerID.Text == "")
        {
            MessageBox.Show("Geben Sie die Id der Kunde ein");
        }
        else
        {
            con.Open();
            string myquery = " delete from KundenTbl where Kunden_ID ='" + CustomerID.Text + "';";
            SqlCommand cmd = new SqlCommand(myquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Die Kunde wurde erfolgreich gelöscht");
            con.Close();
            populate();
        }
    }

    private void CustomersGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = CustomersGV.Rows[e.RowIndex];
            CustomerID.Text = row.Cells[0].Value.ToString();
            Cname.Text = row.Cells[1].Value.ToString();
            Cphone.Text = row.Cells[2].Value.ToString();

        }
    }
}


