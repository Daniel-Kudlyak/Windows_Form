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
    public partial class Початок_роботи : Form
    {
        public static String hours_Mon;
        public static String minutes_Mon;
        public static String hours_Tue;
        public static String minutes_Tue;
        public static String hours_Wed;
        public static String minutes_Wed;
        public static String hours_Thu;
        public static String minutes_Thu;
        public static String hours_Fri;
        public static String minutes_Fri;
        int m = 0;
        int h = 0;
        public Початок_роботи()
        {
            InitializeComponent();

            timer1.Interval = 500;
            m = 0;
            h = 0;

            textBox1.Text = "00";
            textBox2.Text = "00";
            label4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button1.Text = "Включити таймер";
            }
            else
            {
                timer1.Enabled = true;
                button1.Text = "Виключити таймер";

            }

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label4.Visible)
            {
                if (m < 59)
                {
                    m++;
                    if (m < 10)
                        textBox2.Text = "0" + m.ToString();
                    else
                        textBox2.Text = m.ToString();
                }
                else
                {
                    if (h < 59)
                    {
                        h++;
                        if (h < 10)
                            textBox1.Text = "0" + h.ToString();
                        else
                            textBox1.Text = h.ToString();
                        m = 0;
                        textBox2.Text = "00";
                    }
                    else
                    {
                        h = 0;
                        textBox1.Text = "00";
                    }
                }
                label4.Visible = false;
            }
            else
            {
                label4.Visible = true;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            hours_Mon = textBox1.Text;
            minutes_Mon = textBox2.Text;
            if (Авторизація.Mon > 0)
            {
                baza baza_Mon = new baza();

                DataTable table_Mon = new DataTable();

                MySqlDataAdapter adapter_Mon = new MySqlDataAdapter();

                MySqlCommand comand_Mon = new MySqlCommand("UPDATE `users` SET `hours_Mon` = @hours_Mon WHERE `users` . `login` = @loginUser AND `pass` = @passUser;", baza_Mon.GetConnection());
                comand_Mon.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
                comand_Mon.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
                comand_Mon.Parameters.Add("@hours_Mon", MySqlDbType.VarChar).Value = hours_Mon;
                baza_Mon.openConnection();
                if (comand_Mon.ExecuteNonQuery() == 1)
                {
                }
                else
                    MessageBox.Show("NO connection");
                baza_Mon.closeConnection();

                MySqlCommand command_Mon = new MySqlCommand("UPDATE `users` SET `minutes_Mon` = @minutes_Mon WHERE `users` . `login` = @loginUser AND `pass` = @passUser;", baza_Mon.GetConnection());
                command_Mon.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
                command_Mon.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
                command_Mon.Parameters.Add("@minutes_Mon", MySqlDbType.VarChar).Value = minutes_Mon;
                baza_Mon.openConnection();
                if (command_Mon.ExecuteNonQuery() == 1)
                {
                }
                else
                    MessageBox.Show("NO connection");
                baza_Mon.closeConnection();
                this.Hide();

                Головне_меню_понеділок головне_Меню_понеділок = new Головне_меню_понеділок();
                головне_Меню_понеділок.Show();
            }
            else
            {
                if (Авторизація.Tue > 0)
                {
                    baza baza_Mon = new baza();

                    DataTable table_Mon = new DataTable();

                    MySqlDataAdapter adapter_Mon = new MySqlDataAdapter();

                    MySqlCommand comand_Mon = new MySqlCommand("UPDATE `users` SET `hours_Tue` = @hours_Mon WHERE `users` . `login` = @loginUser AND `pass` = @passUser;", baza_Mon.GetConnection());
                    comand_Mon.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
                    comand_Mon.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
                    comand_Mon.Parameters.Add("@hours_Mon", MySqlDbType.VarChar).Value = hours_Mon;
                    baza_Mon.openConnection();
                    if (comand_Mon.ExecuteNonQuery() == 1)
                    {
                    }
                    else
                        MessageBox.Show("NO connection");
                    baza_Mon.closeConnection();

                    MySqlCommand command_Mon = new MySqlCommand("UPDATE `users` SET `minutes__Tue` = @minutes_Mon WHERE `users` . `login` = @loginUser AND `pass` = @passUser;", baza_Mon.GetConnection());
                    command_Mon.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
                    command_Mon.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
                    command_Mon.Parameters.Add("@minutes_Mon", MySqlDbType.VarChar).Value = minutes_Mon;
                    baza_Mon.openConnection();
                    if (command_Mon.ExecuteNonQuery() == 1)
                    {
                    }
                    else
                        MessageBox.Show("NO connection");
                    baza_Mon.closeConnection();
                    this.Hide();

                    Головне_меню_вівторок головне_Меню_вівторок = new Головне_меню_вівторок();
                    головне_Меню_вівторок.Show();
                }
                else
                {
                    if (Авторизація.Wed > 0)
                    {
                        baza baza_Mon = new baza();

                        DataTable table_Mon = new DataTable();

                        MySqlDataAdapter adapter_Mon = new MySqlDataAdapter();

                        MySqlCommand comand_Mon = new MySqlCommand("UPDATE `users` SET `hours_Wed` = @hours_Mon WHERE `users` . `login` = @loginUser AND `pass` = @passUser;", baza_Mon.GetConnection());
                        comand_Mon.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
                        comand_Mon.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
                        comand_Mon.Parameters.Add("@hours_Mon", MySqlDbType.VarChar).Value = hours_Mon;
                        baza_Mon.openConnection();
                        if (comand_Mon.ExecuteNonQuery() == 1)
                        {
                        }
                        else
                            MessageBox.Show("NO connection");
                        baza_Mon.closeConnection();

                        MySqlCommand command_Mon = new MySqlCommand("UPDATE `users` SET `minutes_Wed` = @minutes_Mon WHERE `users` . `login` = @loginUser AND `pass` = @passUser;", baza_Mon.GetConnection());
                        command_Mon.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
                        command_Mon.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
                        command_Mon.Parameters.Add("@minutes_Mon", MySqlDbType.VarChar).Value = minutes_Mon;
                        baza_Mon.openConnection();
                        if (command_Mon.ExecuteNonQuery() == 1)
                        {
                        }
                        else
                            MessageBox.Show("NO connection");
                        baza_Mon.closeConnection();
                        this.Hide();

                        Головне_меню_середа головне_Меню_середа = new Головне_меню_середа();
                        головне_Меню_середа.Show();
                    }
                    else
                    {
                        if (Авторизація.Thu > 0)
                        {
                            baza baza_Mon = new baza();

                            DataTable table_Mon = new DataTable();

                            MySqlDataAdapter adapter_Mon = new MySqlDataAdapter();

                            MySqlCommand comand_Mon = new MySqlCommand("UPDATE `users` SET `hours_Thu` = @hours_Mon WHERE `users` . `login` = @loginUser AND `pass` = @passUser;", baza_Mon.GetConnection());
                            comand_Mon.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
                            comand_Mon.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
                            comand_Mon.Parameters.Add("@hours_Mon", MySqlDbType.VarChar).Value = hours_Mon;
                            baza_Mon.openConnection();
                            if (comand_Mon.ExecuteNonQuery() == 1)
                            {
                            }
                            else
                                MessageBox.Show("NO connection");
                            baza_Mon.closeConnection();

                            MySqlCommand command_Mon = new MySqlCommand("UPDATE `users` SET `minutes_Thu` = @minutes_Mon WHERE `users` . `login` = @loginUser AND `pass` = @passUser;", baza_Mon.GetConnection());
                            command_Mon.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
                            command_Mon.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
                            command_Mon.Parameters.Add("@minutes_Mon", MySqlDbType.VarChar).Value = minutes_Mon;
                            baza_Mon.openConnection();
                            if (command_Mon.ExecuteNonQuery() == 1)
                            {
                            }
                            else
                                MessageBox.Show("NO connection");
                            baza_Mon.closeConnection();
                            this.Hide();

                            Головне_меню_четвер головне_Меню_четвер = new Головне_меню_четвер();
                            головне_Меню_четвер.Show();
                        }
                        else
                        {
                            if (Авторизація.Fri > 0)
                            {
                                baza baza_Mon = new baza();

                                DataTable table_Mon = new DataTable();

                                MySqlDataAdapter adapter_Mon = new MySqlDataAdapter();

                                MySqlCommand comand_Mon = new MySqlCommand("UPDATE `users` SET `hours_Fri` = @hours_Mon WHERE `users` . `login` = @loginUser AND `pass` = @passUser;", baza_Mon.GetConnection());
                                comand_Mon.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
                                comand_Mon.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
                                comand_Mon.Parameters.Add("@hours_Mon", MySqlDbType.VarChar).Value = hours_Mon;
                                baza_Mon.openConnection();
                                if (comand_Mon.ExecuteNonQuery() == 1)
                                {
                                }
                                else
                                    MessageBox.Show("NO connection");
                                baza_Mon.closeConnection();

                                MySqlCommand command_Mon = new MySqlCommand("UPDATE `users` SET `minutes_Fri` = @minutes_Mon WHERE `users` . `login` = @loginUser AND `pass` = @passUser;", baza_Mon.GetConnection());
                                command_Mon.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
                                command_Mon.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
                                command_Mon.Parameters.Add("@minutes_Mon", MySqlDbType.VarChar).Value = minutes_Mon;
                                baza_Mon.openConnection();
                                if (command_Mon.ExecuteNonQuery() == 1)
                                {
                                }
                                else
                                    MessageBox.Show("NO connection");
                                baza_Mon.closeConnection();
                                this.Hide();

                                Головне_меню_п_ятниця головне_Меню_п_ятниця = new Головне_меню_п_ятниця();
                                головне_Меню_п_ятниця.Show();
                            }
                            else  MessageBox.Show("На цьому тижні не має робочих днів");
                        }
                    }
                }
            }
        }
    }
}
    

