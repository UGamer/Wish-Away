using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wish_Away
{
    public partial class Form1 : Form
    {
        string path = File.;
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\deboltm\\Documents\\GitHub\\Wish Away\\Wish Away\\Wish Away\\bin\\Debug\\ItemDatabase.mdf\";Integrated Security=True";

        Panel[] itemPanels;

        public Form1()
        {
            InitializeComponent();
            InitializeList();
        }

        public void InitializeList()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Items", con);

            con.Open();
            cmd.CommandType = CommandType.Text;
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable itemTable = new DataTable();
            da.Fill(itemTable);
            con.Close();

            itemPanels = new Panel[itemTable.Rows.Count];

            this.Text = itemPanels.Length.ToString();
        }
    }
}
