using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // button convert
        {
            double i = double.Parse(textBox1.Text);
            double converter;

            if(comboBox1.SelectedItem == "Dollar" && comboBox3.SelectedItem == "Rupiah")
            {
                converter = i * 14929;
                label4.Text = converter.ToString() + " Rupiah";
            }
            if(comboBox1.SelectedItem == "Rupiah" && comboBox3.SelectedItem == "Dollar")
            {
                converter = i / 14929;
                label4.Text = converter.ToString() + " Dollar";
            }
            if(comboBox1.SelectedItem == "Euro" && comboBox3.SelectedItem == "Rupiah")
            {
                converter = i * 16358;
                label4.Text = converter.ToString() + " Rupiah";
            }
            if (comboBox1.SelectedItem == "Rupiah" && comboBox3.SelectedItem == "Euro")
            {
                converter = i / 16358;
                label4.Text = converter.ToString() + " Euro";
            }
            if (comboBox1.SelectedItem == "Euro" && comboBox3.SelectedItem == "Dollar")
            {
                converter = i * 1.10;
                label4.Text = converter.ToString() + " Dollar";
            }
            if (comboBox1.SelectedItem == "Dollar" && comboBox3.SelectedItem == "Euro")
            {
                converter = i / 1.10;
                label4.Text = converter.ToString() + " Euro";
            }
            if ((comboBox1.SelectedItem == "Euro" && comboBox3.SelectedItem == "Euro") || (comboBox1.SelectedItem == "Dollar" && comboBox3.SelectedItem == "Dollar") || (comboBox1.SelectedItem == "Rupiah" && comboBox3.SelectedItem == "Rupiah"))
            {
                converter = i;
                label4.Text = converter.ToString() + " " + comboBox3.SelectedItem ;    
            }
        }

        private void button2_Click(object sender, EventArgs e) // button clear
        {
            textBox1.Text = "";
            label4.Text = "";
            comboBox1.SelectedItem = null;
            comboBox3.SelectedItem = null;
        }
    }
}
