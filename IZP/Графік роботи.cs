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
    public partial class Графік_роботи : Form
    {
        public Графік_роботи()
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

        private void Графік_роботи_Load(object sender, EventArgs e)
        {
            if (Авторизація.Mon > 0)
            {
                label2.Text = "Понеділок";
            }
            else
            {
                label2.Text = "         ";
            }
            if (Авторизація.Tue > 0)
            {
                label3.Text = "Вівторок";
            }
            else
            {
                label3.Text = "         ";
            }
            if (Авторизація.Wed > 0)
            {
                label4.Text = "Середа";
            }
            else
            {
                label4.Text = "         ";
            }
            if (Авторизація.Thu > 0)
            {
                label5.Text = "Четвер";
            }
            else
            {
                label5.Text = "         ";
            }
            if (Авторизація.Fri > 0)
            {
                label6.Text = "П`ятниця";
            }
            else
            {
                label6.Text = "         ";
            }
        }

       
    }
}
