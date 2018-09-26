using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3I_UP_1
{
    public partial class Form1 : Form
    {

        private string strDefault = "";
        private string[] strArray;
        private int[] numArray;


        public Form1()
        {          
            InitializeComponent();

            listView2.Scrollable = true;
            listView2.View = View.Details;
            listView1.Scrollable = true;
            listView1.View = View.Details;
            strDefault = textBox1.Text;

        }

        public int[] loadArraysToList()
        {
            int[] numArray = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                listView2.Items.Add(strArray[i]);
                numArray[i] = int.Parse(strArray[i]);
            }
            return numArray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strDefault = textBox1.Text;
            strDefault = strDefault.TrimEnd(' ');
            strDefault = strDefault.TrimStart(' ');
            strArray = strDefault.Split(' ');
            listView2.Items.Clear();

            loadArraysToList();
        }

        public int[] sortArray(int[] array)
        {
            int temp = 0;
            for (int write = 0; write < array.Length; write++)
            {
                for (int sort = 0; sort < array.Length - write - 1; sort++)
                {
                    if (array[sort] > array[sort + 1])
                    {
                        temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;
                    }
                }
            }
            return array;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int[] numArray = new int[strArray.Length];

            var watch = System.Diagnostics.Stopwatch.StartNew();
                numArray = sortArray(numArray);
            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            for (int i = 0; i < numArray.Length; i++)
            {             
                listView1.Items.Add(numArray[i].ToString());
            }
            label4.Text = elapsedMs.ToString() + "ms";
        }

        
    }
}
