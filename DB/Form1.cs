using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            // 오라클 연결
            string strConnInfo = "Data Source=112.148.46.134:51521; User Id=scott4_4; Password=tiger;";
            OracleConnection con = new OracleConnection(strConnInfo);
            con.Open();

            // SQL 실행 준비
            // string sql = "SELECT * FROM emp4 WHERE empno = :eno";
            string sql = "SELECT * FROM emp4";

            // OracleCommand cmd = new OracleCommand(sql, con);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            // cmd.Parameters.Add( new OracleParameter("eno", 7800) );

            // SQL 실행
            // select 가 아닌경우
            // int result = cmd.ExecuteNonQuery();

            // select 인 경우
            OracleDataReader odr = cmd.ExecuteReader();

            // 한줄 가져오기
            while ( odr.Read())
            {
                // 컴럼 하나 읽기
                Object empno = odr["empno"] + " " + odr["ename"];
                //Object ename = odr["ename"];

                // 화면 listbox 에 표시
                listView.Items.Add(empno);
                //listView.Items.Add(ename);
            }

            odr.Close();
        }

        private void gridBtn_Click(object sender, EventArgs e)
        {
            // 오라클 연결
            string strConnInfo = "Data Source=112.148.46.134:51521; User Id=scott4_4; Password=tiger;";
            OracleConnection con = new OracleConnection(strConnInfo);
            con.Open();

            // SQL 실행 준비
            // string sql = "SELECT * FROM emp4 WHERE empno = :eno";
            string sql = "SELECT * FROM emp4";

            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand(sql, con);

            // DataSet : 일종의 테이블
            DataSet ds = new DataSet();
            // emp4 테이블을 ds 에 채운다
            oda.Fill(ds, "emp4");

            // 화면 gridView 에 표시
            gridView.DataSource = ds.Tables[0];

            con.Close();
        }
    }
}
