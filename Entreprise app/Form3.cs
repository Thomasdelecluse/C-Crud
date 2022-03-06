using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entreprise_app.myclass;
using MySql.Data.MySqlClient;


namespace Entreprise_app
{
    public partial class Form3 : Form
    {
        CRUD crud = new CRUD();
        public Form3()
        {
            InitializeComponent();
            READ();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //create
            CREATE();
            READ();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update
            UPDATE();
            READ();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delete
            DELETE();
            READ();

        }

        // read 
        public void READ()
        {
            dataGridView1.DataSource = null;
            crud.Read_data3();
            dataGridView1.DataSource = crud.dt;
        }
        //create
        public void CREATE()
        {
            crud.service = servicetxt.Text;
            crud.Create_data3();


        }
        public void UPDATE()
        {
            crud.service = u_servicetxt.Text;
            crud.id = IDTXT.Text;
            crud.Update_data3();
        }
        public void DELETE()
        {
            crud.id = IDTXT.Text;
            crud.Delete_data3();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GET Data
            DataGridView senderGrid = (DataGridView)sender;
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    IDTXT.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    u_servicetxt.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Dont click the header!");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            crud.Select_data3(searchBx.Text);
            dataGridView1.DataSource = crud.dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
