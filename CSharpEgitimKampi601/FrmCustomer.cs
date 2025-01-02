using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
  public partial class FrmCustomer : Form
  {

    public FrmCustomer()
    {
      InitializeComponent();
    }

    string connectionString = "Server=localhost;port=5432;Database=CustomerDb;user Id=postgres;Password=123456aA-;";

    void GetAllCustomers()
    {
      var conn = new NpgsqlConnection(connectionString);
      conn.Open();
      string query = "Select * From Customers";
      var command = new NpgsqlCommand(query, conn);
      var adapter = new NpgsqlDataAdapter(command);
      DataTable dataTable = new DataTable();
      adapter.Fill(dataTable);
      dataGridView1.DataSource = dataTable;
      conn.Close();
    }
    private void btnCustomerList_Click(object sender, EventArgs e)
    {
      GetAllCustomers();
    }

    private void btnCustomerCreate_Click(object sender, EventArgs e)
    {
      string customerName = txtCustomerName.Text;
      string customerSurname = txtCustomerSurname.Text;
      string customerCity = txtCustomerCity.Text;

      var conn = new NpgsqlConnection(connectionString);
      conn.Open();
      string query = "insert into Customers (CustomerName,CustomerSurname,CustomerCity) values (@customerName,@customerSurname,@customerCity)";
      var command = new NpgsqlCommand(query, conn);
      command.Parameters.AddWithValue("@customerName", customerName);
      command.Parameters.AddWithValue("@customerSurname", customerSurname);
      command.Parameters.AddWithValue("@customerCity", customerCity);
      command.ExecuteNonQuery();
      conn.Close();
      MessageBox.Show("Ekleme işlemi başarılı");
      GetAllCustomers();
    }

    private void btnCustomerDelete_Click(object sender, EventArgs e)
    {
      int id = int.Parse(txtCustomerID.Text);
      var conn = new NpgsqlConnection(connectionString);
      conn.Open();
      string query = "Delete From Customers where CustomerId =@customerId";
      var command = new NpgsqlCommand(query, conn);
      command.Parameters.AddWithValue("@customerId", id);
      command.ExecuteNonQuery();
      conn.Close();
      MessageBox.Show("Silme işlemi başarılı");
      GetAllCustomers();

    }

    private void btnCustomerUpdate_Click(object sender, EventArgs e)
    {
      string customerName = txtCustomerName.Text;
      string customerCity = txtCustomerCity.Text;
      string customerSurname = txtCustomerSurname.Text;

      var conn = new NpgsqlConnection(connectionString);
      conn.Open();
      string query = "Update Customers Set CustomerName=@customerName,CustomerSurname=@customerSurname,CustomerCity=@customerCity";
      var command = new NpgsqlCommand(query, conn);
      command.Parameters.AddWithValue("customerName", customerName);
      command.Parameters.AddWithValue("customerSurname", customerSurname);
      command.Parameters.AddWithValue("customerCity", customerCity);
      command.ExecuteNonQuery();
      conn.Close();
      MessageBox.Show("Güncelleme Başarılı");
      GetAllCustomers();
    }
  }
}
