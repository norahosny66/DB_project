using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace DB_project
{
    public partial class Form1 : Form
    {
        int check = 0;
        string ordb = "Data source=orcl;User Id=hr;Password=hr;";
        OracleConnection conn;
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//check_btn
        {
            //proc change check
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "check_admin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", txt_admin_id.Text);
            cmd.Parameters.Add("name", txt_admin_name.Text);
            cmd.Parameters.Add("r",OracleDbType.Int32 ,ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            int cnt =Convert.ToInt32(cmd.Parameters["r"].Value.ToString());    //Convert.ToString(cmd.Parameters["role"].Value.ToString());
            //check = 1; //
            if(cnt == 1  )  
            {
                meal_name_cmb.Enabled = true;
                meal_price.Enabled = true;
                meal_name_label.Enabled = true;
                price_label.Enabled = true;
                insert_btn.Enabled = true;
                show_price.Enabled = true;
                meal_type.Enabled = true;
                type_txt.Enabled = true;

                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "select meal_name from meal";
                cmd2.CommandType = CommandType.Text;
                OracleDataReader dr = cmd2.ExecuteReader();
                while(dr.Read())
                {
                    meal_name_cmb.Items.Add(dr[0]);
                }
            }
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txt_admin_name.Text = check.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            meal_name_cmb.Enabled = false;
            meal_price.Enabled = false;
            meal_name_label.Enabled = false;
            price_label.Enabled = false;
            insert_btn.Enabled = false;
            show_price.Enabled = false;
            meal_type.Enabled = false;
            type_txt.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            //generate new id       cmd.txt
            int max_id, new_id;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetMealID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            try
            {
                max_id = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                new_id = max_id + 1;
            }
            catch
            {
                new_id = 1;
            }

            //call insert       proc
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn; ; ;
            cmd2.CommandText = "insert into meal (meal_id, meal_name, meal_price,  meal_type)   values(:new_id , :name , :price,:type)";
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.Add("id", new_id);
            cmd2.Parameters.Add("name", meal_name_cmb.Text);
            cmd2.Parameters.Add("price", meal_price.Text);
            cmd2.Parameters.Add("type", type_txt.Text);

            int r = cmd2.ExecuteNonQuery();
            if(r != -1)
            {
                meal_name_cmb.Items.Add(meal_name_cmb.Text);
                MessageBox.Show("meal added");
                meal_name_cmb.Text = "";
                meal_price.Text = "";
                type_txt.Text = "";
            }

        }

        private void show_price_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "show_meal_price";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("name", meal_name_cmb.SelectedItem.ToString());
            cmd.Parameters.Add("price", OracleDbType.Int32, ParameterDirection.Output);
            int r = cmd.ExecuteNonQuery();

            /*
             OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "show_meal_type";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("name", meal_name_cmb.SelectedItem.ToString());
            cmd2.Parameters.Add("type", OracleDbType.Varchar2, ParameterDirection.Output);
            int r2 = 1; //cmd2.ExecuteNonQuery();
            */
            //meal_price.Text = "zz";
            meal_price.Text = (cmd.Parameters["price"].Value.ToString());
            
            cmd.ExecuteNonQuery();

            /*if (r!= -1 )
            {
                //type_txt.Text = (cmd2.Parameters["type"].Value.ToString());
            }*/
            /*
             if (r2 != -1)
            {
               // meal_price.Text = (cmd.Parameters["price"].Value.ToString());
                type_txt.Text = (cmd2.Parameters["type"].Value.ToString());
            }*/
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void form_closing(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
        }

        private void meal_name_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
