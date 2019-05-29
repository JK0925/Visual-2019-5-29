using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace A021_Database
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = null;
        OleDbCommand comm = null;
        OleDbDataReader reader = null;

        string connString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\konynag\Desktop\18615031 우제균\A021_Database\A021_Database\StudentTable.accdb;
Persist Security Info=False;";
        public Form1()
        {
            InitializeComponent();
            DisplayStudent();
        }

        private void DisplayStudent()
        {
            if (conn == null)
            {
                conn = new OleDbConnection(connString);
                conn.Open();
            }
            //명령어: 모든 레코드를 가져와라
            //명령어는 SQL로 만든다
            string sql = "SELECT * FROM StudentTable";
            comm = new OleDbCommand(sql, conn);

            //명령어를 실행
            reader = comm.ExecuteReader();

            // DB에서 읽어오는 여러개의 레코드
            while(reader.Read())
            {
                string x = "";
                x += reader["ID"] + "\t";
                x += reader["SID"] + "\t";
                x += reader["SName"] + "\t";
                x += reader["Phone"];
                listBox1.Items.Add(x);
            }
            reader.Close();
            conn.Close();
            conn = null;
        }
    }
}
