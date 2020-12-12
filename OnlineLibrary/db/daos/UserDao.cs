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
        UserRegister test = new UserRegister();
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
            cmd.Parameters.AddWithValue("@password",user.Password);
            cmd.Parameters.AddWithValue("@role",role);
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
                    UserLogin login = new UserLogin();
                    login.Dock = DockStyle.Fill;
                    Form1.Instance.PnlContainer.Controls.Add(login);
                    Form1.Instance.PnlContainer.Controls["UserLogin"].BringToFront();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Date deja existente ", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            con.Close();
        }
    }
}
