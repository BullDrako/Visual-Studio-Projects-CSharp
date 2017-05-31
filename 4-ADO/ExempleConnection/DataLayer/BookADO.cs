using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
//using MySql.Data.MySqlClient;
namespace DataLayer
{
    public class BookADO
    {
        private static DBConnection dataSource;
        public BookADO() {
            dataSource = DBConnection.getInstance();
        }
        public DataSet getAll() {
            DataSet dataBooks = new DataSet();
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataAdapter mysqlAdapter = null;
            String sql;
            sql = "SELECT * from books;";
            try
            {
                connection = dataSource.getConnection();
                connection.Open();
                mysqlCmd = new MySqlCommand(sql, connection);
                mysqlAdapter = new MySqlDataAdapter(mysqlCmd);
                mysqlAdapter.Fill(dataBooks);
            }
            catch (Exception e) {
                dataBooks = new DataSet();
            } finally {
                if(mysqlCmd != null) mysqlCmd.Dispose();
                if(mysqlAdapter != null) mysqlAdapter.Dispose();
                if(connection != null) connection.Close();
            }
            return dataBooks;
        }

        public int insertBook(Book book)
        {
            int result = -1;
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            String sql;
            sql = "INSERT INTO books(title,author,publishing,isbn,genre,price,qty) values('" + book.Title + "','" + book.Author + "','" + book.Publishing + "'," + book.Isbn + ",'" + book.Gender + "'," + book.Price + "," + book.Quantity + ");";
            try
            {
                connection = dataSource.getConnection();
                connection.Open();
                mysqlCmd = new MySqlCommand(sql, connection);

                result = mysqlCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                result = -1;
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (connection != null) connection.Close();
            }
            return result;
        }
        /**
         * @return 1 if book delete successfully, 0 if not deleted, -1 if lost connection with database.
         */
        public int deleteByIsbn(long isbn)
        {
            int result = 0;
            MySqlConnection connection = null;
            MySqlCommand mysqlCommand = null;
            String sql = "DELETE FROM books WHERE isbn=" + isbn + ";";
            try
            {
                connection = dataSource.getConnection();
                connection.Open();
                mysqlCommand = new MySqlCommand(sql, connection);

                result = mysqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                result = -1;
            }
            finally
            {
                if (mysqlCommand != null) mysqlCommand.Dispose();
                if (connection != null) connection.Close();
            }
            return result;
        }

        public DataSet getFromISBN(long isbn)
        {
            DataSet dataBooks = new DataSet();
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataAdapter mysqlAdapter = null;
            String sql;
            sql = "SELECT * from books where isbn=" + isbn + ";";
            try
            {
                connection = dataSource.getConnection();
                connection.Open();
                mysqlCmd = new MySqlCommand(sql, connection);
                mysqlAdapter = new MySqlDataAdapter(mysqlCmd);
                mysqlAdapter.Fill(dataBooks);
            }
            catch (Exception e)
            {
                dataBooks = new DataSet();
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (mysqlAdapter != null) mysqlAdapter.Dispose();
                if (connection != null) connection.Close();
            }
            return dataBooks;
        }

        public int updateBook(Book book)
        {
            int result = -1;
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            String sql;
            sql = "UPDATE books SET title='" + book.Title + "',author='" + book.Author + "',publishing='" + book.Publishing + "',genre='" + book.Gender + "',price=" + book.Price.ToString() + ",qty=" + book.Quantity.ToString() + " WHERE isbn=" + book.Isbn.ToString() + ";";
            try
            {
                connection = dataSource.getConnection();
                connection.Open();
                mysqlCmd = new MySqlCommand(sql, connection);

                result = mysqlCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                result = -1;
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (connection != null) connection.Close();
            }
            return result;
        }
    }
}
