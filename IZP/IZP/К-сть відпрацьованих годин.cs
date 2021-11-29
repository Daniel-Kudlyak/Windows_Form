using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IZP
{
    public partial class К_сть_відпрацьованих_годин : Form
    {
        public К_сть_відпрацьованих_годин()
        {
            InitializeComponent();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (Авторизація.Mon > 0)
            {
                this.Hide();
                Головне_меню_понеділок form2 = new Головне_меню_понеділок();
                form2.Show();
            }
            else
            {
                if (Авторизація.Tue > 0)
                {
                    this.Hide();
                    Головне_меню_вівторок form2 = new Головне_меню_вівторок();
                    form2.Show();
                }
                else
                {
                    if (Авторизація.Wed > 0)
                    {
                        this.Hide();
                        Головне_меню_середа form2 = new Головне_меню_середа();
                        form2.Show();

                    }
                    else
                    {
                        if (Авторизація.Thu > 0)
                        {
                            this.Hide();
                            Головне_меню_четвер form2 = new Головне_меню_четвер();
                            form2.Show();
                        }
                        else
                        {
                            if (Авторизація.Fri > 0)
                            {
                                this.Hide();
                                Головне_меню_п_ятниця form2 = new Головне_меню_п_ятниця();
                                form2.Show();
                            }
                        }
                    }
                }
            }
        }

        private void К_сть_відпрацьованих_годин_Load(object sender, EventArgs e)
        {
            
                baza baza_Mon = new baza();

                DataTable table_Mon = new DataTable();

                MySqlDataAdapter adapter_Mon = new MySqlDataAdapter();

                MySqlCommand command_Mon = new MySqlCommand("SELECT  `hours_Mon` FROM `users` WHERE `login` = @loginUser AND `pass` = @passUser ", baza_Mon.GetConnection());
                command_Mon.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
                command_Mon.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
                adapter_Mon.SelectCommand = command_Mon;
                adapter_Mon.Fill(table_Mon);
                String res_Mon = string.Join(Environment.NewLine, table_Mon.Rows.OfType<DataRow>().Select(x => string.Join(";", x.ItemArray)));
           

            int res_Mon_hou1 = Convert.ToInt32(res_Mon);
            
                DataTable table1_Mon = new DataTable();

                MySqlDataAdapter adapter1_Mon = new MySqlDataAdapter();

                MySqlCommand comand_Mon = new MySqlCommand("SELECT  `minutes_Mon` FROM `users` WHERE `login` = @loginUser AND `pass` = @passUser ", baza_Mon.GetConnection());
                comand_Mon.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
                comand_Mon.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
                adapter1_Mon.SelectCommand = comand_Mon;
                adapter1_Mon.Fill(table1_Mon);
                String res1_Mon = string.Join(Environment.NewLine, table1_Mon.Rows.OfType<DataRow>().Select(x => string.Join(";", x.ItemArray)));
            
            int res_Mon_min1 = Convert.ToInt32(res1_Mon);

            baza baza_Mon2 = new baza();

                    DataTable table_Mon2 = new DataTable();

                    MySqlDataAdapter adapter_Mon2 = new MySqlDataAdapter();

                    MySqlCommand command_Mon2 = new MySqlCommand("SELECT  `hours_Tue` FROM `users` WHERE `login` = @loginUser AND `pass` = @passUser ", baza_Mon2.GetConnection());
                    command_Mon2.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
                    command_Mon2.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
                    adapter_Mon2.SelectCommand = command_Mon2;
                    adapter_Mon2.Fill(table_Mon2);
                    String res_Mon2 = string.Join(Environment.NewLine, table_Mon2.Rows.OfType<DataRow>().Select(x => string.Join(";", x.ItemArray)));
           
            int res_Mon_hou2 = Convert.ToInt32(res_Mon2);
            baza baza1_Mon2 = new baza();

                    DataTable table1_Mon2 = new DataTable();

                    MySqlDataAdapter adapter1_Mon2 = new MySqlDataAdapter();

                    MySqlCommand comand_Mon2 = new MySqlCommand("SELECT  `minutes__Tue` FROM `users` WHERE `login` = @loginUser AND `pass` = @passUser ", baza1_Mon2.GetConnection());
                    comand_Mon2.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
                    comand_Mon2.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
                    adapter1_Mon2.SelectCommand = comand_Mon2;
                    adapter1_Mon2.Fill(table1_Mon2);
                    String res1_Mon2 = string.Join(Environment.NewLine, table1_Mon2.Rows.OfType<DataRow>().Select(x => string.Join(";", x.ItemArray)));
            
            int res_Mon_min2 = Convert.ToInt32(res1_Mon2);

            baza baza_Mon3 = new baza();

                        DataTable table_Mon3 = new DataTable();

                        MySqlDataAdapter adapter_Mon3 = new MySqlDataAdapter();

                        MySqlCommand command_Mon3 = new MySqlCommand("SELECT  `hours_Wed` FROM `users` WHERE `login` = @loginUser AND `pass` = @passUser ", baza_Mon3.GetConnection());
                        command_Mon3.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
                        command_Mon3.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
                        adapter_Mon3.SelectCommand = command_Mon3;
                        adapter_Mon3.Fill(table_Mon3);
                        String res_Mon3 = string.Join(Environment.NewLine, table_Mon3.Rows.OfType<DataRow>().Select(x => string.Join(";", x.ItemArray)));
            
            int res_Mon_hou3 = Convert.ToInt32(res_Mon3);
            baza baza1_Mon3 = new baza();

                        DataTable table1_Mon3 = new DataTable();

                        MySqlDataAdapter adapter1_Mon3 = new MySqlDataAdapter();

                        MySqlCommand comand_Mon3 = new MySqlCommand("SELECT  `minutes_Wed` FROM `users` WHERE `login` = @loginUser AND `pass` = @passUser ", baza1_Mon3.GetConnection());
                        comand_Mon3.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
                        comand_Mon3.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
                        adapter1_Mon3.SelectCommand = comand_Mon3;
                        adapter1_Mon3.Fill(table1_Mon3);
                        String res1_Mon3 = string.Join(Environment.NewLine, table1_Mon3.Rows.OfType<DataRow>().Select(x => string.Join(";", x.ItemArray)));
            
            int res_Mon_min3 = Convert.ToInt32(res1_Mon3);


            baza baza_Mon4 = new baza();

                            DataTable table_Mon4 = new DataTable();

                            MySqlDataAdapter adapter_Mon4 = new MySqlDataAdapter();

                            MySqlCommand command_Mon4 = new MySqlCommand("SELECT  `hours_Thu` FROM `users` WHERE `login` = @loginUser AND `pass` = @passUser ", baza_Mon4.GetConnection());
                            command_Mon4.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
                            command_Mon4.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
                            adapter_Mon4.SelectCommand = command_Mon4;
                            adapter_Mon4.Fill(table_Mon4);
                            String res_Mon4 = string.Join(Environment.NewLine, table_Mon4.Rows.OfType<DataRow>().Select(x => string.Join(";", x.ItemArray)));
            
            int res_Mon_hou4 = Convert.ToInt32(res_Mon4);
            baza baza1_Mon4 = new baza();

                            DataTable table1_Mon4 = new DataTable();

                            MySqlDataAdapter adapter1_Mon4 = new MySqlDataAdapter();

                            MySqlCommand comand_Mon4 = new MySqlCommand("SELECT  `minutes_Thu` FROM `users` WHERE `login` = @loginUser AND `pass` = @passUser ", baza1_Mon4.GetConnection());
                            comand_Mon4.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
                            comand_Mon4.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
                            adapter1_Mon4.SelectCommand = comand_Mon4;
                            adapter1_Mon4.Fill(table1_Mon4);
                            String res1_Mon4 = string.Join(Environment.NewLine, table1_Mon4.Rows.OfType<DataRow>().Select(x => string.Join(";", x.ItemArray)));
            
            int res_Mon_min4 = Convert.ToInt32(res1_Mon4);


           

                                DataTable table_Mon5 = new DataTable();

                                MySqlDataAdapter adapter_Mon5 = new MySqlDataAdapter();

                                MySqlCommand command_Mon5 = new MySqlCommand("SELECT  `hours_Fri` FROM `users` WHERE `login` = @loginUser AND `pass` = @passUser ", baza1_Mon4.GetConnection());
                                command_Mon5.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
                                command_Mon5.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
                                adapter_Mon5.SelectCommand = command_Mon5;
                                adapter_Mon5.Fill(table_Mon5);
                                String res_Mon5 = string.Join(Environment.NewLine, table_Mon5.Rows.OfType<DataRow>().Select(x => string.Join(";", x.ItemArray)));
            
            int res_Mon_hou5 = Convert.ToInt32(res_Mon5);
            baza baza1_Mon5 = new baza();

                                DataTable table1_Mon5 = new DataTable();

                                MySqlDataAdapter adapter1_Mon5 = new MySqlDataAdapter();

                                MySqlCommand comand_Mon5 = new MySqlCommand("SELECT  `minutes_Fri` FROM `users` WHERE `login` = @loginUser AND `pass` = @passUser ", baza1_Mon5.GetConnection());
                                comand_Mon5.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
                                comand_Mon5.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
                                adapter1_Mon5.SelectCommand = comand_Mon5;
                                adapter1_Mon5.Fill(table1_Mon5);
                                String res1_Mon5 = string.Join(Environment.NewLine, table1_Mon5.Rows.OfType<DataRow>().Select(x => string.Join(";", x.ItemArray)));
            
            int res_Mon_min5 = Convert.ToInt32(res1_Mon5);
            int res_Minyt = res_Mon_min1 + res_Mon_min2 + res_Mon_min3 + res_Mon_min4 + res_Mon_min5;
            int ost = 0;
            if (res_Minyt > 59)
            {
                 ost = res_Minyt / 60;
                res_Minyt = res_Minyt - ost * 60;
            }
            int sum_hou = res_Mon_hou1 + res_Mon_hou2 + res_Mon_hou3 + res_Mon_hou4 + res_Mon_hou5 + ost;
            string Vuv = Convert.ToString(res_Minyt);
            string Vuv1 = Convert.ToString(sum_hou);
            label2.Text = Vuv1;
            label3.Text = Vuv;
                            }
                        }
                    }
                
