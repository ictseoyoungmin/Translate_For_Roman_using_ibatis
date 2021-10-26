using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using log4net.Config;
using System.IO;

using System.Collections;
using IBatisNet.Common.Utilities;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using System.Collections.Generic;


namespace WindowsFormsApp4
{

    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void edt_kName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_kName_click(object sender, EventArgs e)
        {
            //edt_kName.Focus();
        }


        private void text_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void converter_Load(object sender, EventArgs e)
        {

        }

        private void btn_tr_Click(object sender, EventArgs e)
        {

        }
        private void conn_conn()
        {

        }
        private void TransKortoRo() // 연결 및 그리드뷰 출력
        {
            var cust_list = Mapper.Instance().QueryForList<Cust_DTO>("ForObject_C.SelectCust", null);
            foreach (var element in cust_list)
            {
                Console.WriteLine(element.Name);
            }

            //string connStr = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};MultipleActiveResultSets=True";
            ////윈도우 인증 계정일 경우엔 : conn = new SqlConnection("Server= localhost; Database= dbName Integrated Security = True;");
            //SqlConnection conn = new SqlConnection(connStr);
            dataGridView1.AllowUserToAddRows = true;
            String customer_name = null;
            //conn.Open();

            try
            {
                //SqlCommand cmd_input = null;
                //SqlDataReader reader_input = null;

                //string sql_input = "select Name from comst_db";
                //cmd_input = new SqlCommand(sql_input, conn);
                //reader_input = cmd_input.ExecuteReader();
                bool insertspace = false;
                int i = 0;

                foreach (var element in cust_list)
                {
                    customer_name = element.Name.ToString();
                    var buff_roman = new StringBuilder();
                    var buff_unicode = new StringBuilder();
                    Console.WriteLine(customer_name);

                    insertspace = false;
                    bool first_eng_check = true;
                    bool first_char_check = true;

                    var new_row = new DataGridViewRow();
                    if (customer_name != null)
                    {
                        dataGridView1.Rows.Add(new_row);
                    }

                    dataGridView1.Rows[i].Cells[0].Value = element.Name.ToString();

                    foreach (var input_data in customer_name)
                    {
                        Console.WriteLine("inputdata : " + input_data);
                        try
                        {
                            //SqlCommand cmd_u = conn.CreateCommand();
                            //cmd.CommandText = $"select Roman from Unicode_Table where Korean = '{input_data}'";
                            //SqlDataReader reader_roman = cmd.ExecuteReader();
                            string Roman_token = Mapper.Instance().QueryForObject<string>("ForObject_U.SelectTest", input_data);
                            Console.WriteLine(Roman_token);
                           
                            //if (input_data >= 0xac00 && input_data <= 0xd7a3)// 가~힣 (ga ~ hih)
                            if (Roman_token != null) //true or false                        
                            {
                                buff_roman.Append($"{(insertspace ? " " : "")}{Roman_token}");
                                insertspace = true;
                                first_char_check = false;
                            }
                            else //ex) asd링컨 -> asd ring keon ;; 규격외 문자
                            {
                                if (first_eng_check == true && first_char_check == true)
                                {
                                    buff_roman.Append($"{input_data}");
                                    first_char_check = false;
                                    first_eng_check = false;
                                }
                                else if (first_eng_check == true && first_char_check == false)
                                {
                                    buff_roman.Append(" " + $"{input_data}");
                                    first_eng_check = false; 
                                }
                                else if (first_eng_check == false)
                                {
                                    buff_roman.Append($"{input_data}");
                                }
                                insertspace = true;
                                //MessageBox.Show("input_data >= 0xac00 && input_data <= 0xd7a3");
                            }
                        }
                        catch (Exception ex)
                        {                     
                            Console.WriteLine("err : " + ex.Message);
                        }

                    }
                    dataGridView1.Rows[i].Cells["Roman"].Value = buff_roman.ToString();
                    i++;
                    Console.WriteLine($"|{buff_roman.ToString()}|");
                }
            }
            catch
            {

            }
        }

        private void SelectAll_U()
        { 
            var list = Mapper.Instance().QueryForList<Unicode_Table_DTO>("ForList_U.SelectAll", null);
            int i = 0;
            foreach (var row in list)
            {
                var new_row = new DataGridViewRow();
                if (row != null)
                {
                    dataGridView2.Rows.Add(new_row);
                }
                dataGridView2.Rows[i].Cells["Number"].Value = row.Number;
                dataGridView2.Rows[i].Cells["Korean"].Value = row.Korean;
                dataGridView2.Rows[i].Cells["Unicode"].Value = row.Unicode;
                dataGridView2.Rows[i].Cells["Roman_"].Value = row.Roman;
                dataGridView2.Rows[i].Cells["Roman_ex"].Value = row.Roman_ex;
                dataGridView2.Rows[i].Cells["Last_name"].Value = row.Last_name;
                i++;
                Console.WriteLine("{0} /{1} /{2} /{3} /{4} /{5}", row.Number, row.Korean, row.Unicode, row.Roman, row.Roman_ex, row.Last_name);
            }
        }

        private void btn_tr_Click_1(object sender, EventArgs e)
        {

            if (dataGridView1.Visible == true && dataGridView2.Visible == false)
            {

                TransKortoRo();
            }
            else if (dataGridView1.Visible == false && dataGridView2.Visible == true)
            {

                SelectAll_U();
            } 
            else
            {
                Console.WriteLine("check : dataGridView1 : {0} , dataGridView {1}", dataGridView1.Visible, dataGridView2.Visible);
            }
;
        }

        private void btn_pathTest_Click(object sender, EventArgs e)
        {
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            string strSettingsXmlFilePath = System.IO.Path.Combine(strWorkPath, "Settings.xml");
            Console.WriteLine("strExeFilePath : " + strExeFilePath + "" + "\nstrWorkPath : " + strWorkPath + "\nstrSettingsXmlFilePath : " + strSettingsXmlFilePath);

        }

        private void btn_trView_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
        }

        private void btn_UnicodeView_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            string list = Mapper.Instance().QueryForObject<string>("ForObject_U.SelectTest", '서');
            Console.WriteLine(list);
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}