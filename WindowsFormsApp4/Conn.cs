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


namespace Conn
{
    class Conn
    {
        public void Show()
        {
            //    //IList Test = Mapper.Instance().QueryForList("WindowsFormsApp4.Test", null, 0, 10);
            //    //foreach (string element in Test)
            //    //{
            //    //    Console.WriteLine(element);
            //    //}
            //    //return;
            //    //string test = Mapper.Instance().QueryForObject<string>("WindowsFormsApp4.SelectRoman", "서");
            //    //Console.WriteLine(test);
            //    //return;
            //    IList cust_list = Mapper.Instance().QueryForList("WindowsFormsApp4.SelectCust", null);
            //    foreach (string element in cust_list)
            //    {
            //        Console.WriteLine(element[0]);
            //    }

            //    //string connStr = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};MultipleActiveResultSets=True";
            //    ////윈도우 인증 계정일 경우엔 : conn = new SqlConnection("Server= localhost; Database= dbName Integrated Security = True;");
            //    //SqlConnection conn = new SqlConnection(connStr);
            //    dataGridView1.AllowUserToAddRows = true;
            //    String customer_name = null;
            //    //conn.Open();

            //    try
            //    {
            //        //SqlCommand cmd_input = null;
            //        //SqlDataReader reader_input = null;

            //        //string sql_input = "select Name from comst_db";
            //        //cmd_input = new SqlCommand(sql_input, conn);
            //        //reader_input = cmd_input.ExecuteReader();
            //        bool insertspace = false;
            //        int i = 0;

            //        foreach (string element in cust_list)
            //        {
            //            customer_name = element;
            //            var buff_roman = new StringBuilder();
            //            var buff_unicode = new StringBuilder();
            //            Console.WriteLine(customer_name);

            //            insertspace = false;
            //            bool first_eng_check = true;
            //            bool first_char_check = true;

            //            var new_row = new DataGridViewRow();
            //            if (customer_name != null)
            //            {
            //                dataGridView1.Rows.Add(new_row);
            //            }

            //            dataGridView1.Rows[i].Cells[0].Value = element.ToString();

            //            foreach (var input_data in customer_name)
            //            {
            //                Console.WriteLine(input_data);


            //                try
            //                {
            //                    //SqlCommand cmd_u = conn.CreateCommand();
            //                    //cmd.CommandText = $"select Roman from Unicode_Table where Korean = '{input_data}'";
            //                    //SqlDataReader reader_roman = cmd.ExecuteReader();
            //                    var Roman_token = Mapper.Instance().QueryForObject("WindowsFormsApp4.SelectRoman", input_data);
            //                    Console.WriteLine(Roman_token);
            //                    //if (input_data >= 0xac00 && input_data <= 0xd7a3)// 가~힣 (ga ~ hih)
            //                    if (Roman_token != null) //true or false                        
            //                    {
            //                        buff_roman.Append($"{(insertspace ? " " : "")}{Roman_token}");
            //                        insertspace = true;
            //                        first_char_check = false;
            //                    }
            //                    else //ex) asd링컨 -> asd ring keon ;; 규격외 문자
            //                    {
            //                        if (first_eng_check == true && first_char_check == true)
            //                        {
            //                            buff_roman.Append($"{input_data}");
            //                            first_char_check = false;
            //                            first_eng_check = false;
            //                        }
            //                        else if (first_eng_check == true && first_char_check == false)
            //                        {
            //                            buff_roman.Append(" " + $"{input_data}");
            //                            first_eng_check = false;
            //                        }
            //                        else if (first_eng_check == false)
            //                        {
            //                            buff_roman.Append($"{input_data}");
            //                        }
            //                        insertspace = true;
            //                        //MessageBox.Show("input_data >= 0xac00 && input_data <= 0xd7a3");
            //                    }

            //                }
            //                catch (Exception ex)
            //                {
            //                    //MessageBox.Show("catch.");
            //                    //if (!(input_data > 0x5a && input_data < 0x61) && (input_data >= 0x41 && input_data <= 0x5a) && (input_data >= 0x61 && input_data <= 0x7a)) //a~z
            //                    //else // ㄱ~ㅎ, ㄵ~ㅀ, ㅏ~ㅣ                         
            //                    Console.WriteLine(ex.Message);
            //                }

            //            }
            //            dataGridView1.Rows[i].Cells[1].Value = buff_roman.ToString();

            //            i++;
            //            Console.WriteLine($"|{buff_roman.ToString()}|");
            //            //buff.Append("\n");

            //        }

            //    }
            //    catch
            //    {

            //    }
            //    //text_result.Text = buff.ToString(); 
            //}
        }
    }
}
