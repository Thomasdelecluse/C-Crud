using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Entreprise_app.myclass
{
    class DB
    {
        public MySqlConnection con;

        public DB()
        {
            string host = "localhost";
            string db = "student";
            string port = "3306";
            string user = "root";
            string pass = "";
            string constring = "datasource ="+host+"; database ="+db+"; port ="+port+"; username ="+user+"; password =" + pass + "; SslMode=none";
            con = new MySqlConnection(constring);
        }
    }

    class CRUD:DB
    {
        //propriété

        public string name { set; get; }
        public string number { set; get; }

        public string address { set; get; }
        public string mobilef { set; get; }
        public string email { set; get; }


        public string ville { set; get; }

        public string service { set; get; }

        //for id 
        public string id { set; get; }

        //read properties

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        //create function 
        public void Create_data()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO `student_table`(`nom`, `prenom`, `Numero_portable`, `Numero_fixe`, `email`) VALUES(@name, @add, @num, @numf, @email)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@add", MySqlDbType.VarChar).Value = address;
                cmd.Parameters.Add("@num", MySqlDbType.VarChar).Value = number;
                cmd.Parameters.Add("@numf", MySqlDbType.VarChar).Value = mobilef;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
        //create function form2
        public void Create_data2()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO `site_table`(`Ville`) VALUES(@ville)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@ville", MySqlDbType.VarChar).Value = ville;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        //create function form3
        public void Create_data3()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO `service_table`(`service`) VALUES(@service)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@service", MySqlDbType.VarChar).Value = service;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
        //UPDATE Function

        public void Update_data()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            String cityId = null;
            if (ville != null && ville != "")
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT ID FROM site_table WHERE Ville=@ville";
                    cmd.Parameters.Add("@ville", MySqlDbType.VarChar).Value = ville;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    MySqlDataReader mdr = cmd.ExecuteReader();

                    while (mdr.Read())
                    {
                        cityId = mdr.GetValue(0).ToString();
                        break;
                    }

                    mdr.Close();

                }
                if (cityId == null)
                {
                    string message = "Pas de site dans cette ville !";
                    MessageBox.Show(message);
                    return;
                }
            }

            String serviceId = null;
            if (service != null && service != "")
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT ID FROM service_table WHERE service=@service";
                    cmd.Parameters.Add("@service", MySqlDbType.VarChar).Value = service;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    MySqlDataReader mdr = cmd.ExecuteReader();

                    while (mdr.Read())
                    {
                        serviceId = mdr.GetValue(0).ToString();
                        break;
                    }

                    mdr.Close();

                }
                if (serviceId == null)
                {
                    string message = "Ce service existe pas !";
                    MessageBox.Show(message);
                    return;
                }
            }
            

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE student_table SET nom=@name, prenom =@add, Numero_portable =@num, Numero_fixe =@numfixe, email =@email, id_site=@ville, id_service=@service  WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@add", MySqlDbType.VarChar).Value = address;
                cmd.Parameters.Add("@num", MySqlDbType.VarChar).Value = number;
                cmd.Parameters.Add("@numfixe", MySqlDbType.VarChar).Value = mobilef;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@ville", MySqlDbType.VarChar).Value = cityId;
                cmd.Parameters.Add("@service", MySqlDbType.VarChar).Value = serviceId;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            service = null;
            ville = null;
           
        }

        //UPDATE Function form2

        public void Update_data2()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE site_table SET ville=@ville WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@ville", MySqlDbType.VarChar).Value = ville;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        //UPDATE Function form3

        public void Update_data3()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE service_table SET service=@service WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@service", MySqlDbType.VarChar).Value = service;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
        //DELETE

        public void Delete_data()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM student_table WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        //DELETE

        public void Delete_data2()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM site_table WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        //DELETE

        public void Delete_data3()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM service_table WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        //Read 

        public void Read_data()
        {
            dt.Clear();
            string query = "SELECT student_table.ID, student_table.nom, student_table.prenom, student_table.Numero_portable, student_table.CreateAt, student_table.email, student_table.Numero_fixe, site_table.Ville, service_table.service FROM `student_table` LEFT JOIN `site_table` ON `student_table`.`id_site`=`site_table`.`ID` LEFT JOIN `service_table` ON `student_table`.`id_service`=`service_table`.`ID`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }
        //Read form 2

        public void Read_data2()
        {
            dt.Clear();
            string query = "SELECT * FROM `site_table`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }

        //Read form 2

        public void Read_data3()
        {
            dt.Clear();
            string query = "SELECT * FROM `service_table`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }

        public void Select_data(string text)
        {
            dt.Clear();
            string query = "SELECT * FROM `student_table` WHERE nom LIKE '%"+text+"%'";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }
        public void Select_data2(string text)
        {
            dt.Clear();
            string query = "SELECT * FROM `site_table` WHERE ville LIKE '%" + text + "%'";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }

        public void Select_data3(string text)
        {
            dt.Clear();
            string query = "SELECT * FROM `service_table` WHERE service LIKE '%" + text + "%'";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }

    }
}
