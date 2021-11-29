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
    public partial class Вихід : Form
    {
        public Вихід()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
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
                            else MessageBox.Show("Не можливо повернутись");

                        }
                    }
                }
            }
        }
    }
}
