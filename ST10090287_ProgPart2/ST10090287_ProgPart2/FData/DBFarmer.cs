using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ST10090287_ProgPart2.Models;
using System.Data.SqlClient;
using System.Data;


using Microsoft.Extensions.Configuration;

namespace ST10090287_ProgPart2.FData
{

    public class DBFarmer
    {
        private string ConString;
        private IConfiguration _config;

        public DBFarmer(IConfiguration configuration)
        {
            _config = configuration;
            ConString = _config.GetConnectionString("azureDBConnect");
        }

        public List<Farmers> AllFarmers()
        {
            List<Farmers> stList = new List<Farmers>();
            SqlConnection myConnection = new SqlConnection(ConString);
            SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT *  FROM FARMER", myConnection);
            DataTable myTable = new DataTable();
            DataRow myRow = myTable.NewRow();
            string Farmer_Name, Farmer_Surname, id, Farmer_Email, Farmer_Password;

            myConnection.Open();
            myAdapter.Fill(myTable);

            if (myTable.Rows.Count > 0)
            {
                for (int i = 0; i < myTable.Rows.Count; i++)
                {
                    myRow = myTable.Rows[i];


                    stList.Add(new Farmers((string)myRow[0], (string)myRow[1], (string)myRow[2], (string)myRow[3], (string)myRow[4]));
                }
            }
            myConnection.Close();
            return stList;
        }



        public Farmers GetFarmers(string id)
        {
            Farmers st = new Farmers();
            SqlConnection myConnection = new SqlConnection(ConString);
            SqlCommand cmdSelect = new SqlCommand($"SELECT * FROM FARMER WHERE FARMER_ID = '{id}'", myConnection);
            myConnection.Open();
            using (SqlDataReader reader = cmdSelect.ExecuteReader())
            {
                while (reader.Read())
                {
                    st = new Farmers((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4]);

                }
            }
            myConnection.Close();
            return st;
        }

        public void AddFarmer(Farmers st)
        {
            using (SqlConnection myConnection = new SqlConnection(ConString))
            {
                SqlCommand cmdInsert = new SqlCommand($"INSERT INTO FARMER VALUES('{st.FARMER_ID}','{st.FARMER_NAME}','{st.FARMER_SURNAME}','{st.FARMER_EMAIL}','{st.FARMER_PASSWORD}')", myConnection);
                myConnection.Open();
                cmdInsert.ExecuteNonQuery();
            }
        }

        public void UpdateFarmer(string id, Farmers st)
        {
            using (SqlConnection myCon = new SqlConnection(ConString))
            {
                SqlCommand CmdUpdate = new SqlCommand($"UPDATE FARMER SET FARMER_ID = '{st.FARMER_ID}'," +
                    $"FARMER_NAME = '{st.FARMER_NAME}'," +
                    $"FARMER_SURNAME= '{st.FARMER_SURNAME}'," +
                    $"FARMER_EMAIL= '{st.FARMER_EMAIL}'," +
                    $"FARMER_PASSWORD= '{st.FARMER_PASSWORD}'" +
                    $"WHERE FARMER_ID = '{id}'", myCon);


                myCon.Open();
                CmdUpdate.ExecuteNonQuery();
            }
        }

        public void DeleteFarmer(string id)
        {
            using (SqlConnection myConn = new SqlConnection(ConString))
            {
                SqlCommand cmdDelete = new SqlCommand($"DELETE FROM FARMER WHERE FARMER_ID ='{id}'", myConn);
                myConn.Open();
                cmdDelete.ExecuteNonQuery();
            }
        }
        public List<Employee> AllEmployees()
        {
            List<Employee> STEList = new List<Employee>();
            SqlConnection myConnection = new SqlConnection(ConString);
            SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT *  FROM EMPLOYEE", myConnection);
            DataTable myTable = new DataTable();
            DataRow myRow = myTable.NewRow();
            string id, EmployeName, Employee_Surname, Employee_Email, Employee_Password;

            myConnection.Open();
            myAdapter.Fill(myTable);

            if (myTable.Rows.Count > 0)
            {
                for (int i = 0; i < myTable.Rows.Count; i++)
                {
                    myRow = myTable.Rows[i];


                    STEList.Add(new Employee((string)myRow[0], (string)myRow[1], (string)myRow[2], (string)myRow[3], (string)myRow[4]));
                }
            }
            myConnection.Close();
            return STEList;
        }

        public Employee GetEmployee(string id)
        {
            Employee stE = new Employee();
            SqlConnection myConnection = new SqlConnection(ConString);
            SqlCommand cmdSelect = new SqlCommand($"SELECT * FROM EMPLOYEE WHERE EMPLOYEE_ID = '{id}'", myConnection);
            myConnection.Open();
            using (SqlDataReader reader = cmdSelect.ExecuteReader())
            {
                while (reader.Read())
                {
                    stE = new Employee((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4]);

                }
            }
            myConnection.Close();
            return stE;
        }

        public void AddEmployee(Employee st)
        {
            using (SqlConnection myConnection = new SqlConnection(ConString))
            {
                SqlCommand cmdInsert = new SqlCommand($"INSERT INTO EMPLOYEE VALUES('{st.EMPLOYEE_ID}','{st.EMPLOYEE_NAME}','{st.EMPLOYEE_SURNAME}','{st.EMPLOYEE_EMAIL}','{st.EMPLOYEE_PASSWORD})", myConnection);
                myConnection.Open();
                cmdInsert.ExecuteNonQuery();
            }
        }


        public List<Product> AllProducts(string farmerID)
        {
            List<Product> productList = new List<Product>();
            SqlConnection myConnection = new SqlConnection(ConString);
            SqlDataAdapter myAdapter = new SqlDataAdapter($"SELECT * FROM PRODUCTS WHERE FARMER_ID = '{farmerID}'", myConnection);
            DataTable myTable = new DataTable();
            DataRow myRow = myTable.NewRow();

            string ID, Name, Price, Quantity, FarID;

            myConnection.Open();
            myAdapter.Fill(myTable);

            if (myTable.Rows.Count > 0)
            {
                for (int i = 0; i < myTable.Rows.Count; i++)
                {
                    myRow = myTable.Rows[i];
                    productList.Add(new Product((string)myRow[0], (string)myRow[1], (string)myRow[2], (string)myRow[3], (string)myRow[4]));
                }
            }

            myConnection.Close();
            return productList;
        }

        public Product GetProduct(string id)
        {
            Product stP = new Product();
            SqlConnection myConnection = new SqlConnection(ConString);
            SqlCommand cmdSelect = new SqlCommand($"SELECT * FROM PRODUCTS WHERE PRODUCT_ID = '{id}'", myConnection);
            myConnection.Open();
            using (SqlDataReader reader = cmdSelect.ExecuteReader())
            {
                while (reader.Read())
                {
                    stP = new Product((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4]);

                }
            }
            myConnection.Close();
            return stP;
        }

        public void AddProduct(Product st)
        {
            using (SqlConnection myConnection = new SqlConnection(ConString))
            {
                SqlCommand cmdInsert = new SqlCommand($"INSERT INTO PRODUCTS VALUES" +
                    $"('{st.PRODUCT_ID}'," +
                    $"'{st.PRODUCT_TYPE}'," +
                    $"'{st.PRODUCT_PRICE}'," +
                    $"'{st.PRODUCT_QTY}'," +
                    $"'{st.FARMER_ID}')", myConnection);

                myConnection.Open();
                cmdInsert.ExecuteNonQuery();
            }
        }

        public void updateProduct(string id, Product pro)
        {
            using (SqlConnection myCon = new SqlConnection(ConString))
            {
                SqlCommand CmdUpdate = new SqlCommand($"UPDATE PRODUCTS SET PRODUCT_ID = '{pro.PRODUCT_ID}'," +
                         $"PRODUCT_TYPE = '{pro.PRODUCT_TYPE}'," +
                         $"PRODUCT_PRICE= '{pro.PRODUCT_PRICE}'," +
                         $"PRODUCT_QTY= '{pro.PRODUCT_QTY}'," +
                         $"FARMER_ID= '{pro.FARMER_ID}'" +
                         $"WHERE PRODUCT_ID = '{id}'", myCon);


                myCon.Open();
                CmdUpdate.ExecuteNonQuery();

            }
        }
        public void deleteProduct(string id)
        {
            using (SqlConnection myConn = new SqlConnection(ConString))
            {
                SqlCommand cmdDelete = new SqlCommand($"DELETE FROM PRODUCTS WHERE PRODUCT_ID ='{id}'", myConn);
                myConn.Open();
                cmdDelete.ExecuteNonQuery();
            }
        }

        public List<Product> FAllProducts()
        {
            List<Product> STPList = new List<Product>();
            SqlConnection myConnection = new SqlConnection(ConString);
            SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT *  FROM PRODUCTS", myConnection);
            DataTable myTable = new DataTable();
            DataRow myRow = myTable.NewRow();
            string id, ProductType, ProductPrice, ProductQty, FarmerID;

            myConnection.Open();
            myAdapter.Fill(myTable);

            if (myTable.Rows.Count > 0)
            {
                for (int i = 0; i < myTable.Rows.Count; i++)
                {
                    myRow = myTable.Rows[i];


                    STPList.Add(new Product((string)myRow[0], (string)myRow[1], (string)myRow[2], (string)myRow[3], (string)myRow[4]));
                }
            }
            myConnection.Close();
            return STPList;
        }
    }
}


