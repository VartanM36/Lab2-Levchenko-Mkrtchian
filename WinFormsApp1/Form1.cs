
using System;
using System.Globalization;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox6.ReadOnly = true;
            textBox5.ReadOnly = true;

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                textBox1.Text = "50";
            else if (comboBox1.SelectedIndex == 1)
                textBox1.Text = "250";
            else if (comboBox1.SelectedIndex == 2)
                textBox1.Text = "500";
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
                textBox2.Text = "4,5";
            else if (comboBox2.SelectedIndex == 1)
                textBox2.Text = "11,0";
            else if (comboBox2.SelectedIndex == 2)
                textBox2.Text = "40,0";
            else if (comboBox2.SelectedIndex == 3)
                textBox2.Text = "95,0";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double pojemnosc;
            double procent;
            int ilosc;

            if (!double.TryParse(textBox1.Text, NumberStyles.Number,
                CultureInfo.GetCultureInfo("pl-PL"), out pojemnosc) ||
                pojemnosc <= 0)
            {
                MessageBox.Show("Podaj poprawną wielkość naczynia.");
                return;
            }

            if (!double.TryParse(textBox2.Text, NumberStyles.Number,
                CultureInfo.GetCultureInfo("pl-PL"), out procent) ||
                procent < 0 || procent > 100)
            {
                MessageBox.Show("Podaj procent alkoholu od 0 do 100.");
                return;
            }

            if (!int.TryParse(textBox3.Text, out ilosc) || ilosc <= 0)
            {
                MessageBox.Show("Podaj poprawną ilość sztuk.");
                return;
            }

            double objetoscNapoju = pojemnosc * ilosc;
            double objetoscAlkoholu = objetoscNapoju * procent / 100.0;

            textBox6.Text = objetoscNapoju.ToString("F2") + " ml";
            textBox5.Text = objetoscAlkoholu.ToString("F2") + " ml";
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}
