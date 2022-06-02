using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GörselProgramlamaEtkinlikÖdevi2
{
    public partial class Form1 : Form
    {
        int xKonumu = 0;
        int yKonumu = 0;      
        int hareketler = 0;
        string komutlar;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             //Konumlandır
             xKonumu = Convert.ToInt32(textBox2.Text);
             yKonumu = Convert.ToInt32(textBox3.Text);
             komutlar = textBox4.Text;
             listView1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Hareket Ettir
            string komutlar = textBox4.Text;
            int komutlarUzunlugu = textBox4.Text.Length; 

            for (int i = 0; i < komutlarUzunlugu; i++) //Uzunluğa göre döngü içinde her harfi arıyoruz.
            {
                switch(komutlar[i]) 
                {
                case 'R': 
                    {
                        if (comboBox1.Text == "K") 
                        {
                            comboBox1.Text = "D";
                        }
                        else if (comboBox1.Text == "D") 
                        {
                            comboBox1.Text = "G";
                        }
                        else if (comboBox1.Text == "G") 
                        {
                            comboBox1.Text = "B";
                        }
                        else if (comboBox1.Text == "B") 
                        {
                            comboBox1.Text = "K";
                        }
                    }
                    break;
                case 'L': 
                    {
                        if (comboBox1.Text == "K")
                        {
                            comboBox1.Text = "B";
                        }
                        else if (comboBox1.Text == "B") 
                        {
                            comboBox1.Text = "G";
                        }
                        else if (comboBox1.Text == "G") 
                        {
                            comboBox1.Text = "D";
                        }
                        else if (comboBox1.Text == "D") 
                        {
                            comboBox1.Text = "K";
                        }
                    }
                    break;
                case 'M': 
                    {
                        if (comboBox1.Text == "K")
                        {
                            yKonumu++;
                        }
                        else if (comboBox1.Text == "D")
                        {
                            xKonumu++;
                        }
                        else if (comboBox1.Text == "G")
                        {
                            yKonumu--;
                        }
                        else if (comboBox1.Text == "B")
                        {
                            xKonumu--;
                        }
                
                        int yeniHareketler = hareketler;
                        int yeniXKonumu = xKonumu;
                        int yeniYKonumu = yKonumu;

                        listView1.Items.Add((hareketler + 1).ToString());
                        listView1.Items[yeniHareketler].SubItems.Add(yeniXKonumu.ToString()); //ListView'e X konumunu yazdırıyoruz.
                        listView1.Items[yeniHareketler].SubItems.Add(yeniYKonumu.ToString()); //ListView'e Y konumunu yazdırıyoruz.

                        label6.Text = yeniXKonumu.ToString() + " " + yeniYKonumu.ToString();
                        hareketler++;
                    } 
                    break;
                }
            }  
        }
    }
}