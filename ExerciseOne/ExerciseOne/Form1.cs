using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseOne
{
    public partial class Form1 : Form
    {
        string subString = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_scanTime.Text = Constants.TIME.ToString();
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            string data = tb_data.Text;
            data = Regex.Replace(data, @"\s+", " ");
            lv_raw.Items.Clear();
            List<int> convertedList = convert(data);
            for(int i = 0; i< convertedList.Count; i++)
            {
                lv_raw.Items.Add(convertedList[i].ToString());
            }
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            string data = tb_data.Text;
            data.TrimStart(' ');
            data.TrimEnd(' ');
            lv_sort.Items.Clear();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            List<int> sortedList = sortList(convert(data));
            watch.Stop();
            var timeMs = watch.ElapsedMilliseconds;
            for (int i = 0; i < sortedList.Count; i++)
            {
                lv_sort.Items.Add(sortedList[i].ToString());
            }
            time.Text = timeMs.ToString() + " ms.";
        }



        private List<int> convert(string strDefault , string word)
        {
            var convertedList = new List<int>();
            for (int i = 0; i < strDefault.Length; i++)
            {
                try
                {
                    if (strDefault.Substring(i, 1) != " ")
                    {
                        subString += strDefault.Substring(i, 1);
                    }
                    else
                    {
                        convertedList.Add(Convert.ToInt32(subString));
                        subString = "";
                    }
                }
                catch (System.FormatException)
                {
                    System.Diagnostics.Debug.WriteLine(" \nThe list is not in the correct format");
                    DialogResult res = MessageBox.Show("Please make sure the data is in the correct format!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        break;
                    }

                }
            }
            return convertedList;
        } 

        private List<int> sortList(List<int> listData)
        {
            var sortedDataList = new List<int>();
            int temp = 0;
            for (int write = 0; write < listData.Count; write++)
            {
                for (int sort = 0; sort < listData.Count - write - 1; sort++)
                {
                    if (listData[sort] > listData[sort + 1])
                    {
                        temp = listData[sort + 1];
                        listData[sort + 1] = listData[sort];
                        listData[sort] = temp;
                    }
                }
            }
            for(int i = 0; i < listData.Count; i++)
            {
                sortedDataList.Add(listData[i]);
            }
            return sortedDataList;
        }
    }
}
