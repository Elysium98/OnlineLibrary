using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OnlineLibrary.db.utils;
using OnlineLibrary.db.models;
using System.Windows.Forms;
using OnlineLibrary.controller;
using System.Data;
namespace OnlineLibrary.db.daos
{
    class BooksDao
    {
        public static void insertBook(Book book)
        {
            //DateTime today = DateTime.Today;
            //book.DateAdded = today;
            MySqlConnection con = DBConnection.getConnection();

            if (con == null)
            {
                throw new Exception("Conexiunea la baza de date nu s-a realizat.");
            }

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "INSERT INTO books(Autor,`Titlu Carte`,`Data Publicare`,Limba,`Nr Pagini`) VALUES(@Autor,@TitluCarte,@DataPublicare,@Limba,@NrPagini)";
            cmd.Parameters.AddWithValue("@Autor", book.Author);
            cmd.Parameters.AddWithValue("@TitluCarte", book.BookName);
            cmd.Parameters.AddWithValue("@DataPublicare", book.DateAdded);
            cmd.Parameters.AddWithValue("@Limba", book.Language);
            cmd.Parameters.AddWithValue("@NrPagini", book.NumberOfPages);
            try
            {
                if (cmd.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("Email existent", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Carte inserata cu succes", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GUIController.checkInsertSucces = true;
                }
            }
            catch (Exception e)
            {
               MessageBox.Show("Nu s-a reusit inserarea", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public static DataTable showBooksTable()
        {
            MySqlConnection con = DBConnection.getConnection();
            if(con==null)
            {
                throw new Exception("Conexiunea la baza de date nu s-a realizat");
            }
            string query = "Select * from books";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static void deleteBook(Book book)
        {

            MySqlConnection con = DBConnection.getConnection();
            if (con == null)
            {
                throw new Exception("Conexiunea la baza de date nu s-a realizat.");
            }
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM books WHERE `Titlu Carte`=@TitluCarte AND Autor=@Autor";
            cmd.Parameters.AddWithValue("@TitluCarte", book.BookName);
            cmd.Parameters.AddWithValue("@Autor", book.Author);

            if (cmd.ExecuteNonQuery() != 1)
            {
                throw new Exception("Stergerea nu s-a putut face.");
            }
            else
            {
                GUIController.checkDeleteBookSuccess = true;
            }
            con.Close();
        }

        public static void updateBook(Book book)
        {
            MySqlConnection con = DBConnection.getConnection();
            if(con==null)
            {
                throw new Exception("Conexiunea nu s-a putut realiza");
            }
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE books SET Autor=@Autor , `Titlu Carte`=@TitluCarte , `Data Publicare`=@DataPublicare , Limba=@Limba , `Nr Pagini`=@NrPagini WHERE `ID Carte`=@ID";
            cmd.Parameters.AddWithValue("@Autor", book.Author);
            cmd.Parameters.AddWithValue("@TitluCarte", book.BookName);
            cmd.Parameters.AddWithValue("@DataPublicare", book.DateAdded);
            cmd.Parameters.AddWithValue("@Limba", book.Language);
            cmd.Parameters.AddWithValue("@NrPagini", book.NumberOfPages);
            cmd.Parameters.AddWithValue("@ID", book.BookId);
            if(cmd.ExecuteNonQuery()!=1)
            {
                throw new Exception("Nu s-a putut face actualizarea");
            }
            else
            {
                GUIController.checkUpdateBookSuccess = true;
            }
            con.Close();
        }

        public static void issueBook(BookIssued book)
        {
            MySqlConnection con = DBConnection.getConnection();
            if(con==null)
            {
                throw new Exception("Nu s-a putut realiza conexiunea");
            }
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO booksissued(`Nume Prenume`,Autor,`Titlu Carte`,`Data Publicare`,Limba,`Nr Pagini`,`Data Imprumut`) VALUES(@numeprenume,@autor,@titlucarte,@datapublicare,@limba,@nrpagini,@dataimprumut)";
            cmd.Parameters.AddWithValue("@numeprenume", book.Fullname);
            cmd.Parameters.AddWithValue("@autor", book.Author);
            cmd.Parameters.AddWithValue("@titlucarte", book.BookName);
            cmd.Parameters.AddWithValue("@datapublicare", book.DateAdded);
            cmd.Parameters.AddWithValue("@limba", book.Language);
            cmd.Parameters.AddWithValue("@nrpagini", book.NumberOfPages);
            cmd.Parameters.AddWithValue("dataimprumut", book.DateIssued);
            if(cmd.ExecuteNonQuery()!=1)
            {
                MessageBox.Show("Nu s-a putut imprumuta cartea", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                GUIController.checkBookIssueSuccess = true;
                MessageBox.Show("Cartea a fost imprumutata", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

    }
}
