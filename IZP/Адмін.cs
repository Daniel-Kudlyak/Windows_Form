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
    public partial class Адмін : Form
    {
        public Адмін()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Авторизація ls = new Авторизація();
            ls.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                String Mon1 = Convert.ToString(Авторизація.Mon);
                String Tue1 = Convert.ToString(Авторизація.Tue);
                String Wed1 = Convert.ToString(Авторизація.Wed);
                String Thu1 = Convert.ToString(Авторизація.Thu);
                String Fri1 = Convert.ToString(Авторизація.Fri);
                String ID = textBox6.Text;
                Mon1 = textBox1.Text;
                Tue1 = textBox2.Text;
                Wed1 = textBox3.Text;
                Thu1 = textBox4.Text;
                Fri1 = textBox5.Text;

                if (ID != "")
                {
                    if (Mon1 != "")
                    {
                        if (Tue1 != "")
                        {
                            if (Wed1 != "")
                            {
                                if (Thu1 != "")
                                {
                                    if (Fri1 != "")
                                    {
                                        int f = 0, a = 0, r = 0, q = 0, p = 0, l = 0, cingg = 0;
                                        try
                                        {
                                            f = Convert.ToInt32(ID);
                                            a = Convert.ToInt32(Mon1);
                                            r = Convert.ToInt32(Tue1);
                                            q = Convert.ToInt32(Wed1);
                                            p = Convert.ToInt32(Thu1);
                                            l = Convert.ToInt32(Fri1);
                                        }
                                        catch (Exception)
                                        {
                                            cingg = 1;
                                        }
                                        if (cingg == 0)
                                        {

                                            baza baza_Mon = new baza();

                                            DataTable table_Mon = new DataTable();

                                            MySqlDataAdapter adapter_Mon = new MySqlDataAdapter();

                                            MySqlCommand comand_Mon = new MySqlCommand("UPDATE `users` SET `Monday` = @hoursMon WHERE `users` . `login` = @loginUserMon;", baza_Mon.GetConnection());
                                            comand_Mon.Parameters.Add("@loginUserMon", MySqlDbType.VarChar).Value = ID;

                                            comand_Mon.Parameters.Add("@hoursMon", MySqlDbType.VarChar).Value = Mon1;
                                            baza_Mon.openConnection();
                                            if (comand_Mon.ExecuteNonQuery() == 1)
                                            {
                                            }
                                            else
                                                MessageBox.Show("NO connection");
                                            baza_Mon.closeConnection();

                                            MySqlCommand comand_Tue = new MySqlCommand("UPDATE `users` SET `Tuesday` = @hoursTue WHERE `users` . `login` = @loginUserTue;", baza_Mon.GetConnection());
                                            comand_Tue.Parameters.Add("@loginUserTue", MySqlDbType.VarChar).Value = ID;

                                            comand_Tue.Parameters.Add("@hoursTue", MySqlDbType.VarChar).Value = Tue1;
                                            baza_Mon.openConnection();
                                            if (comand_Tue.ExecuteNonQuery() == 1)
                                            {
                                            }
                                            else
                                                MessageBox.Show("NO connection");
                                            baza_Mon.closeConnection();

                                            MySqlCommand comand_Wed = new MySqlCommand("UPDATE `users` SET `Wednesday` = @hoursWed WHERE `users` . `login` = @loginUserWed;", baza_Mon.GetConnection());
                                            comand_Wed.Parameters.Add("@loginUserWed", MySqlDbType.VarChar).Value = ID;

                                            comand_Wed.Parameters.Add("@hoursWed", MySqlDbType.VarChar).Value = Wed1;
                                            baza_Mon.openConnection();
                                            if (comand_Wed.ExecuteNonQuery() == 1)
                                            {
                                            }
                                            else
                                                MessageBox.Show("NO connection");
                                            baza_Mon.closeConnection();

                                            MySqlCommand comand_Thu = new MySqlCommand("UPDATE `users` SET `Thursday` = @hoursThu WHERE `users` . `login` = @loginUserThu;", baza_Mon.GetConnection());
                                            comand_Thu.Parameters.Add("@loginUserThu", MySqlDbType.VarChar).Value = ID;

                                            comand_Thu.Parameters.Add("@hoursThu", MySqlDbType.VarChar).Value = Thu1;
                                            baza_Mon.openConnection();
                                            if (comand_Thu.ExecuteNonQuery() == 1)
                                            {
                                            }
                                            else
                                                MessageBox.Show("NO connection");
                                            baza_Mon.closeConnection();

                                            MySqlCommand comand_Fri = new MySqlCommand("UPDATE `users` SET `Friday` = @hoursFri WHERE `users` . `login` = @loginUserFri;", baza_Mon.GetConnection());
                                            comand_Fri.Parameters.Add("@loginUserFri", MySqlDbType.VarChar).Value = ID;

                                            comand_Fri.Parameters.Add("@hoursFri", MySqlDbType.VarChar).Value = Fri1;
                                            baza_Mon.openConnection();
                                            if (comand_Fri.ExecuteNonQuery() == 1)
                                            {
                                            }
                                            else
                                                MessageBox.Show("NO connection");
                                            baza_Mon.closeConnection();

                                           
                                        }
                                        else MessageBox.Show("Не вірний ввід");
                                    }
                                    else MessageBox.Show("Заповніть всі поля");
                                }
                                else MessageBox.Show("Заповніть всі поля");
                            }
                            else MessageBox.Show("Заповніть всі поля");
                        }
                        else MessageBox.Show("Заповніть всі поля");
                    }
                    else MessageBox.Show("Заповніть всі поля");
                }
                else MessageBox.Show("Заповніть всі поля");
            }
            catch (Exception)
            {
                MessageBox.Show("Не під`єднано до бази даних");
            }
           // this.Hide();
           // Авторизація ls = new Авторизація();
           // ls.Show();
        }
    }
}
