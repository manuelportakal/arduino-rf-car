using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace araba_test2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            serialPort1.PortName = "COM7";
            serialPort1.BaudRate = 9600;
        }

        private void verioku()
        {
            string message = "";
            for (int i = 1; i > 0; i--)
            {
                message += serialPort1.ReadExisting();
                System.Threading.Thread.Sleep(1);
                Application.DoEvents();
            }
            serialPort1.Close();
            txt_sicaklik.Text = message + " Derece";
            serialPort1.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("4");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.Write(msk_komut_kuyrugu.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                serialPort1.Write("1");
            }
            else if (e.KeyCode == Keys.S)
            {
                serialPort1.Write("4");
            }
            else if (e.KeyCode == Keys.A)
            {
                serialPort1.Write("3");
            }
            else if (e.KeyCode == Keys.D)
            {
                serialPort1.Write("2");
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btn_komut_gonder.PerformClick();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialPort1.Write("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            serialPort1.Write("8");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            serialPort1.Write("7");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            serialPort1.Write("5");
            txt_sicaklik.Clear();
            verioku();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            serialPort1.Write("9");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");
        }

        private void btn_baglan_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
        }

        private void btn_baglantiyi_kes_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }
    }
}
