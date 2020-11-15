using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// Product Data Access Layer
namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection("server=localhost; initial catalog=BtkAkademi; Uid=sa; pwd=1324");
        /*
         Veritabanından verileri DataTable'a aktarma
         Artık Kullanımı çok az
             */
        public DataTable GetAll2()//List<Product> GetAll()
        {
            if (_connection.State == ConnectionState.Closed) _connection.Open();

            SqlCommand command = new SqlCommand("select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            reader.Close();
            _connection.Close();

            return dataTable;
        }
        /*
         Veritabanından verileri List<> e aktarma
             */
        public List<Product> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    CategoryId = Convert.ToInt32(reader["CategoryId"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    Status = Convert.ToBoolean(reader["Status"]),
                    RegisterDate = Convert.ToDateTime(reader["RegisterDate"])
                };
                products.Add(product);
            }

            reader.Close();
            _connection.Close();

            return products;
        }
        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into Products values(@Name,@CategoryId,@UnitPrice,@StockAmount,@Status,@RegisterDate)", _connection);
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@CategoryId", product.CategoryId);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@Status", product.Status);
            command.Parameters.AddWithValue("@RegisterDate", product.RegisterDate);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                @"update Products set Name = @Name, CategoryId = @CategoryId, UnitPrice = @UnitPrice, 
                    StockAmount = @StockAmount,Status = @Status, RegisterDate = @RegisterDate where Id = @Id", _connection);
            command.Parameters.AddWithValue("Id", product.Id);
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@CategoryId", product.CategoryId);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@Status", product.Status);
            command.Parameters.AddWithValue("@RegisterDate", product.RegisterDate);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand
            (
                @"delete from Products where Id = @Id",
                _connection
            );
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed) _connection.Open();
        }


    }
}
