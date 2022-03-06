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
    public partial class Form1 : Form
    {
        CRUD crud = new CRUD();
        public Form1()
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
            crud.Read_data();
            dataGridView1.DataSource = crud.dt;
        }
        //create
        public void CREATE()
        {
            crud.name = nametxt.Text;
            crud.number = mobiletxt.Text;
            crud.address = addressetxt.Text;
            crud.mobilef = mobilefixetxt.Text;
            crud.email = emailtxt.Text;
            crud.Create_data();


        }
        public void UPDATE()
        {
            crud.name = u_nametxt.Text;
            crud.number = u_mobiletxt.Text;
            crud.address = u_addressetxt.Text;
            crud.email = u_email.Text;
            crud.mobilef = u_mobilef.Text;
            crud.id = IDTXT.Text;
            crud.ville = villetxt.Text;
            crud.service = servicetxt.Text;
            crud.Update_data();
        }
        public void DELETE()
        {
            crud.id = IDTXT.Text;
            crud.Delete_data();
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
                    u_nametxt.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    u_addressetxt.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    u_mobiletxt.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    u_mobilef.Text = (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                    u_email.Text = (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                    villetxt.Text = (dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
                    servicetxt.Text = (dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
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
            crud.Select_data(searchBx.Text);
            dataGridView1.DataSource = crud.dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void u_mobilef_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
