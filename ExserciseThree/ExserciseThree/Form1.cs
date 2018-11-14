using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExserciseThree
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
            
        }
            private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Consts.TEXT;
        }
            private void button2_Click_1(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();

           
            var convertedList = new List<int>();

            convertedList = ConvertToList(richTextBox1.Text, textBox1.Text);

            for (int i = 0; i < convertedList.Count; i++)
            {                
                listBox1.Items.Add(convertedList[i].ToString());
                
            }

            convertedList.Clear();
        }

        private List<int> ConvertToList(string text, string word)
        {
            richTextBox1.BackColor = Color.White;
            int position;
            var posList = new List<int>();
            var convertedList = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < text.Length; i++)
            {
                try
                {
                    if (text.Substring(i, 1) != " " && text.Substring(i, 1) != "(" && text.Substring(i, 1) != ")" && text.Substring(i, 1) != "-" && text.Substring(i, 1) != "/" && text.Substring(i, 1) != ":" && text.Substring(i, 1) != ";" && text.Substring(i, 1) != "," && text.Substring(i, 1) != ".")
                    { 
                        subString += text.Substring(i, 1);
                        
                    }
                    else
                    {
                        position = i;
                        KeyValuePair<string, int> pair;
                        pair = new KeyValuePair<string, int>(subString, position-subString.Length);
                        subString = textBox1.Text;
                        convertedList.Add(pair);
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
            
            foreach (KeyValuePair<string, int> acct in convertedList)
            {
                if (acct.Key.Contains(word))
                {
                    posList.Add(acct.Value);
                    richTextBox1.Select(acct.Value, acct.Key.Length);
                    
                    richTextBox1.SelectionBackColor = Color.Yellow;
                }
            }
            return posList;
        }

    }
}
