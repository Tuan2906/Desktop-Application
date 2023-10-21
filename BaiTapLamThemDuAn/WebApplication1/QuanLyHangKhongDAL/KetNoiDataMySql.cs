using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using QuanLyHangKhongEntity;

namespace QuanLyHangKhongDAL
{
    public class KetNoiDataMySql
    {
        public static MySqlConnection connection;
        public static int dem = 0;
        public static int demSua = 0;
        public void Ket_Noisql()
        {
            string s1 = "server = localhost; user id = root; password = 29062003t@; database = quanlyhangkhong";
            if (KetNoiDataMySql.connection == null)

            {
                connection = new MySqlConnection();
                connection.ConnectionString = s1;// gan chuoi ket noi server cho connection
            }
            if (KetNoiDataMySql.connection.State != System.Data.ConnectionState.Open)
            {
                KetNoiDataMySql.connection.Open();
            }
            //connection = new MySqlConnection(ketNoiSql);
            // connection.Open();
            // string q = "USE QuanLyHangKhong";

        }
        public void dongKetNoi()
        {
            if (KetNoiDataMySql.connection != null)
            {
                if (KetNoiDataMySql.connection.State == System.Data.ConnectionState.Open)
                    KetNoiDataMySql.connection.Close();
            }
        }
        public MySqlCommand cmd;

        //     string t1, t2,
        public void ThucThiCauLenhSQL(string query)
        {

            try {
                Ket_Noisql();

                //MySqlCommand command = new MySqlCommand(q, connection);
                cmd = new MySqlCommand(query, connection);
                if (demSua >= 1)
                {
                    cmd.ExecuteNonQuery();
                    demSua = 0;
                }
                // cmd.ExecuteNonQuery();
                //dongKetNoi();

            }
            catch (SqlException ex)
            {

            }

        }

        public void ganCauLenhSQL(string thuoctinhSQL, string giatri)
        {
            try
            {


                cmd.Parameters.AddWithValue(thuoctinhSQL, giatri);
                if (dem >= 1)
                {

                    cmd.ExecuteNonQuery();
                    dongKetNoi();
                }
            }
            catch (SqlException ex)
            {
                
            }

    
    
            //  cmd.Parameters.AddWithValue(t3, t4);
            //  cmd.Parameters.AddWithValue(t5, t6);
        }
        public DataTable GetDataTable(string strSQL)
        {
            try {
                Ket_Noisql();
                DataTable mytable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(strSQL, connection);
               
                dataAdapter.Fill(mytable);
               
                return mytable;
                connection.Close();

            }
            catch (SqlException ex) {
                return null;
                    
            }
        }
        public string Getvalue(string strSQL)
        {
            string tam = null;
            Ket_Noisql();
            MySqlCommand sqlcmd = new MySqlCommand(strSQL, connection);
            MySqlDataReader sqlDataReader = sqlcmd.ExecuteReader();
            while (sqlDataReader.Read())    
            {
                tam = sqlDataReader[0].ToString();
            }
            dongKetNoi();
            return tam;
        }
    }

}
