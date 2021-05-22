using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MinimizeBox = false;
            MaximizeBox = false;

        }
        int itag;
        int next_itag;
        bool[] po_pyti=new bool [10];
        //обработка кнопок
        //убрать кнопки, вывод в центре
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cal()
        {
            po_pyti[2] =true;
            po_pyti[6] = true;
            while (itag != next_itag) { 
            if(itag>next_itag){ itag--; 
                    if (itag == next_itag) { listBox1.Items.Add($"Приехали на " + itag + " этаж"); }
                    else listBox1.Items.Add($"Едим вниз на " + itag + " этаж");
                    if (po_pyti[itag] == true) { listBox1.Items.Add($"Взяли попутчиков  на " + itag + " этаже"); }
                }
            if (itag < next_itag) { itag++; 
                if (itag == next_itag) { listBox1.Items.Add($"Приехали на "+ itag + " этаж");}
                else listBox1.Items.Add($"Едим вверх на " + itag + " этаж");
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          /*  //  if (e.KeyCode == Keys.NumPad1) 
            MessageBox.Show($"123"+e.KeyCode);
            MessageBox.Show($"123" + e.KeyValue);
            switch (e.KeyCode){
                case Keys.NumPad1: MessageBox.Show("123"); break;



            }*/
        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show($"123");
            string s = (textBox1.Text);

            try
            {
                next_itag = int.Parse(s);
                cal();

            }
            catch { MessageBox.Show($"Введите цифру"); }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
