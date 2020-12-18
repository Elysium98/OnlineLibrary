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

namespace OnlineLibrary.db.daos
{
    class UserDao
    {
        public static void register(User user)
        {
            string role = "student";
            MySqlConnection con = DBConnection.getConnection();

            if (con == null)
            {
                throw new Exception("Conexiunea la baza de date nu s-a realizat.");
            }

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "INSERT INTO users(fullname,email,password,role) VALUES(@fullname,@email,@password,@role)";
            cmd.Parameters.AddWithValue("@fullname", user.FullName);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@role", role);
            try
            {
                if (cmd.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("Email existent", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("V-ati inregistrat cu succes", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GUIController.checkRegisterSucces = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Date deja existente ", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            con.Close();
        }

        public static void login(User user)
        {
            MySqlConnection con = DBConnection.getConnection();
            if (con == null)
            {
                throw new Exception("Nu s-a putut realiza conexiunea la baza de date");
            }

            MySqlCommand com = con.CreateCommand();

            com.CommandText = "SELECT role FROM users WHERE @email=email  AND @password=password";
            com.Parameters.AddWithValue("@email", user.Email);
            com.Parameters.AddWithValue("@password", user.Password);
            MySqlDataReader login = com.ExecuteReader();
            if (login.Read())
            {
                GUIController.checkLoginSucces = true;
                MessageBox.Show("V-ati autentificat cu succes", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                user.Role = login["role"].ToString();
                if (user.Role.Equals("student"))
                {
                    MessageBox.Show("V-ati logat ca student", "Buna ziua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GUIController.roleAccess = "student";
                }
                else
               if (user.Role.Equals("librarian"))
                {
                    MessageBox.Show("V-ati logat ca bibliotecar", "Buna ziua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GUIController.roleAccess = "librarian";
                }
            }
            else
            {
                MessageBox.Show("Nu s-a reusit logarea", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw new Exception("Nu s-a putut face autentificarea");
            }
        }

        public static void insertBook(Book book)
        {
            DateTime today = DateTime.Today;
            book.DateAdded = today;
            MySqlConnection con = DBConnection.getConnection();

            if (con == null)
            {
                throw new Exception("Conexiunea la baza de date nu s-a realizat.");
            }

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "INSERT INTO books(author,bookname,dateadded) VALUES(@author,@bookname,@dateadded)";
            cmd.Parameters.AddWithValue("@author", book.Author);
            cmd.Parameters.AddWithValue("@bookname", book.BookName);
            cmd.Parameters.AddWithValue("@dateadded", book.DateAdded);
            try
            {
                if (cmd.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("Email existent", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Carte inserata cu succes", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                //MessageBox.Show("Nu s-a reusit inserarea", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
    }
