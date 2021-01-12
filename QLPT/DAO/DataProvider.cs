using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set => instance = value;
        }

        private DataProvider() { }

        private string connectionSTR = @"Data Source=DESKTOP-BG2HQQV\SQLEXPRESS;Initial Catalog=QLPT;Integrated Security=True";

        // Trả về bảng dữ liệu
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            // Khởi tạo 1 cái datatable
            DataTable data = new DataTable();

            // Khi thực thi nếu có sai sót gì trong đây thì nó vẫn thoát ra ngoài được
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                // Command sẽ thực thi query dựa trên kết nối vs connection
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    // listPar dùng để tách và lấy các câu truy vấn
                    string[] listPar = query.Split(' ');
                    int i = 0;

                    foreach (string item in listPar)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                // adapter là trung gian lấy dữ liệu từ câu truy vấn
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Đổ dữ liệu lấy ra vào data
                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        // Trả về số dòng thành công vd: thêm xóa sửa
        public int ExecuteNonQuery(string query, object[] par = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                // Command sẽ thật thi query dựa trên kết nối vs connection
                SqlCommand command = new SqlCommand(query, connection);

                if (par != null)
                {
                    string[] listPar = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPar)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, par[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        // Số lượng thành công vd: selcet count() gì gì đó
        public object ExecuteScalar(string query, object[] par = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                // Command sẽ thật thi query dựa trên kết nối vs connection
                SqlCommand command = new SqlCommand(query, connection);

                if (par != null)
                {
                    string[] listPar = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPar)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, par[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
}
