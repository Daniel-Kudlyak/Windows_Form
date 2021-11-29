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
    public partial class Головне_меню_середа : Form
    {
        public Головне_меню_середа()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Початок_роботи початок_Роботи = new Початок_роботи();
            початок_Роботи.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            К_сть_відпрацьованих_годин к_Сть_Відпрацьованих = new К_сть_відпрацьованих_годин();
            к_Сть_Відпрацьованих.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Вихід вихід = new Вихід();
            вихід.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baza baza_Mon = new baza();

            DataTable table_Mon = new DataTable();

            MySqlDataAdapter adapter_Mon = new MySqlDataAdapter();

            MySqlCommand command_Mon = new MySqlCommand("SELECT  `Wednesday` FROM `users` WHERE `login` = @loginUser AND `pass` = @passUser ", baza_Mon.GetConnection());
            command_Mon.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
            command_Mon.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
            adapter_Mon.SelectCommand = command_Mon;
            adapter_Mon.Fill(table_Mon);
            String res_Wed = string.Join(Environment.NewLine, table_Mon.Rows.OfType<DataRow>().Select(x => string.Join(";", x.ItemArray)));
            Авторизація.Wed = Convert.ToInt32(res_Wed);

            Авторизація.Wed = Авторизація.Wed - 1;
            String Wed1 = Convert.ToString(Авторизація.Wed);

            MySqlCommand comandMon = new MySqlCommand("UPDATE `users` SET `Wednesday` = @hoursMon WHERE `users` . `login` = @loginUser AND `pass` = @passUser;", baza_Mon.GetConnection());
            comandMon.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = Авторизація.loginUser;
            comandMon.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = Авторизація.passUser;
            comandMon.Parameters.Add("@hoursMon", MySqlDbType.VarChar).Value = Wed1;
            baza_Mon.openConnection();
            if (comandMon.ExecuteNonQuery() == 1)
            {
            }
            else
                MessageBox.Show("NO connection");
            baza_Mon.closeConnection();

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
                            else
                            {
                                MessageBox.Show("Більше не має робочих днів на цьому тижні");
                            }
                        }
                    }


                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Авторизація ls = new Авторизація();
            ls.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Графік_роботи графік_Роботи = new Графік_роботи();
            графік_Роботи.Show();
        }
    }
}
