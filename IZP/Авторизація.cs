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
    public partial class Авторизація : Form
    {
        public static String loginUser;
        public static String passUser;
        public static int Mon;
        public static int Tue;
        public static int Wed;
        public static int Thu;
        public static int Fri;



        public Авторизація()
        {
            InitializeComponent();

            this.textBox2.AutoSize = false;
            this.textBox2.Size = new Size(this.textBox2.Size.Width, 35);

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void buttonLogin_Click_1(object sender, EventArgs e)
        {

            try {
                loginUser = textBox1.Text;
                passUser = textBox2.Text;
                if (loginUser != "")
                {
                    if (passUser != "")
                    {
                        int f = 0, a = 0, cingg = 0;
                        try
                        {
                            f = Convert.ToInt32(loginUser);
                            a = Convert.ToInt32(passUser);
                        }
                        catch (Exception)
                        {
                            cingg = 1;
                        }
                        if (cingg == 0)
                        {

                            baza baza = new baza();

                            DataTable table = new DataTable();

                            MySqlDataAdapter adapter = new MySqlDataAdapter();

                            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @loginUser AND `pass` = @passUser", baza.GetConnection());
                            command.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = loginUser;
                            command.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = passUser;
                            adapter.SelectCommand = command;
                            adapter.Fill(table);

                            int I = 0, Z = 0;
                            I = Convert.ToInt32(loginUser);
                            Z = Convert.ToInt32(passUser);


                            if (I == 1 && Z == 1)
                            {
                                this.Hide();
                                Адмін form2 = new Адмін();
                                form2.Show();
                            }
                            else
                            {

                                baza baza_Mon = new baza();

                                DataTable table_Mon = new DataTable();

                                MySqlDataAdapter adapter_Mon = new MySqlDataAdapter();

                                MySqlCommand command_Mon = new MySqlCommand("SELECT  `Monday` FROM `users` WHERE `login` = @loginUser AND `pass` = @passUser ", baza.GetConnection());
                                command_Mon.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = loginUser;
                                command_Mon.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = passUser;
                                adapter_Mon.SelectCommand = command_Mon;
                                adapter_Mon.Fill(table_Mon);
                                String res_Mon = string.Join(Environment.NewLine, table_Mon.Rows.OfType<DataRow>().Select(x => string.Join(";", x.ItemArray)));
                                Mon = Convert.ToInt32(res_Mon);

                                baza baza_Tue = new baza();

                                DataTable table_Tue = new DataTable();

                                MySqlDataAdapter adapter_Tue = new MySqlDataAdapter();

                                MySqlCommand command_Tue = new MySqlCommand("SELECT `Tuesday` FROM `users` WHERE `login` = @loginUser AND `pass` = @passUser", baza.GetConnection());
                                command_Tue.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = loginUser;
                                command_Tue.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = passUser;
                                adapter_Tue.SelectCommand = command_Tue;
                                adapter_Tue.Fill(table_Tue);
                                String res_Tue = string.Join(Environment.NewLine, table_Tue.Rows.OfType<DataRow>().Select(x => string.Join(";", x.ItemArray)));
                                Tue = Convert.ToInt32(res_Tue);

                                baza baza_Wed = new baza();

                                DataTable table_Wed = new DataTable();

                                MySqlDataAdapter adapter_Wed = new MySqlDataAdapter();

                                MySqlCommand command_Wed = new MySqlCommand("SELECT `Wednesday` FROM `users` WHERE `login` = @loginUser AND `pass` = @passUser", baza.GetConnection());
                                command_Wed.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = loginUser;
                                command_Wed.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = passUser;
                                adapter_Wed.SelectCommand = command_Wed;
                                adapter_Wed.Fill(table_Wed);
                                String res_Wed = string.Join(Environment.NewLine, table_Wed.Rows.OfType<DataRow>().Select(x => string.Join(";", x.ItemArray)));
                                Wed = Convert.ToInt32(res_Wed);

                                baza baza_Thu = new baza();

                                DataTable table_Thu = new DataTable();

                                MySqlDataAdapter adapter_Thu = new MySqlDataAdapter();

                                MySqlCommand command_Thu = new MySqlCommand("SELECT `Thursday` FROM `users` WHERE `login` = @loginUser AND `pass` = @passUser", baza.GetConnection());
                                command_Thu.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = loginUser;
                                command_Thu.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = passUser;
                                adapter_Thu.SelectCommand = command_Thu;
                                adapter_Thu.Fill(table_Thu);
                                String res_Thu = string.Join(Environment.NewLine, table_Thu.Rows.OfType<DataRow>().Select(x => string.Join(";", x.ItemArray)));
                                Thu = Convert.ToInt32(res_Thu);

                                baza baza_Fri = new baza();

                                DataTable table_Fri = new DataTable();

                                MySqlDataAdapter adapter_Fri = new MySqlDataAdapter();

                                MySqlCommand command_Fri = new MySqlCommand("SELECT `Friday` FROM `users` WHERE `login` = @loginUser AND `pass` = @passUser", baza.GetConnection());
                                command_Fri.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = loginUser;
                                command_Fri.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = passUser;
                                adapter_Fri.SelectCommand = command_Fri;
                                adapter_Fri.Fill(table_Fri);
                                String res_Fri = string.Join(Environment.NewLine, table_Fri.Rows.OfType<DataRow>().Select(x => string.Join(";", x.ItemArray)));
                                Fri = Convert.ToInt32(res_Fri);


                                if (table.Rows.Count > 0)
                                {

                                    MessageBox.Show("Авторизація пройшла успішно");

                                    if (Mon > 0)
                                    {
                                        this.Hide();
                                        Головне_меню_понеділок form2 = new Головне_меню_понеділок();
                                        form2.Show();
                                    }
                                    else
                                    {
                                        if (Tue > 0)
                                        {
                                            this.Hide();
                                            Головне_меню_вівторок form2 = new Головне_меню_вівторок();
                                            form2.Show();
                                        }
                                        else
                                        {
                                            if (Wed > 0)
                                            {
                                                this.Hide();
                                                Головне_меню_середа form2 = new Головне_меню_середа();
                                                form2.Show();

                                            }
                                            else
                                            {
                                                if (Thu > 0)
                                                {
                                                    this.Hide();
                                                    Головне_меню_четвер form2 = new Головне_меню_четвер();
                                                    form2.Show();
                                                }
                                                else
                                                {
                                                    if (Fri > 0)
                                                    {
                                                        this.Hide();
                                                        Головне_меню_п_ятниця form2 = new Головне_меню_п_ятниця();
                                                        form2.Show();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("На цьому тижні не має робочих днів");
                                                    }
                                                }
                                            }


                                        }

                                    }

                                }
                                else
                                    MessageBox.Show("Логін або пароль ведено не вірно");



                            }
                        }//
                        else MessageBox.Show("Не вірний ввід");
                    }
                    else MessageBox.Show("Пароль ведений не правильно");
                }
                else MessageBox.Show("Логін ведений не правильно");
            }
            catch (Exception) 
            {
              MessageBox.Show("Не під`єднано до бази даних");
            }
    }
    }
}
