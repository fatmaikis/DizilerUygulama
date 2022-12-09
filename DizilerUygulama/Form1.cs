using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DizilerUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int girilenSayi = 0;
        int[] sayilar = new int[10];

        private void button1_Click(object sender, EventArgs e)
        {

            if (girilenSayi < 10)
            {

                sayilar[girilenSayi] = Convert.ToInt32(sayigirtxt.Text);
                girilenSayi++;
                label5.Text = "Girilen sayı : " + girilenSayi.ToString();
            }
            else
            {
                MessageBox.Show("10 adet sayı girdiniz.Daha fazla giremezsiniz !");
            }
            sayigirtxt.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in sayilar)
            {
                if (item % 2 == 0)
                {
                    listBox1.Items.Add(item);
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in sayilar)
            {
                if (item %3==0)
                {
                    listBox1.Items.Add(item);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in sayilar)
            {
                if (item % 5 == 0)
                {
                    listBox1.Items.Add(item);
                }

            }
        }
    }
    }


