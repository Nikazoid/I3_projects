using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace III_upr6
{
    public partial class Form1 : Form
    {
        private string currentText;
        private ParagraphParser myParagraphParser;
        private Benchmarker myBenchmarker;

        public Form1()
        {
            InitializeComponent();
        }

        private void parseParagraph()
        {
            myParagraphParser = new ParagraphParser(currentText);
        }

        private void pushTextInMainTextView()
        {

            textBox1.Text = currentText;

        }

        private void printParsedResult()
        {
            textBox2.Clear();
            myParagraphParser.printCurrentParagraphToTextBoxWithType(textBox2);
        }

        private void clearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void setCurrentText() {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            currentText = textBox5.Text;
            pushTextInMainTextView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            currentText = textBox6.Text;
            pushTextInMainTextView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            currentText = textBox7.Text;
            pushTextInMainTextView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            currentText = textBox8.Text;
            pushTextInMainTextView();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            currentText = textBox9.Text;
            pushTextInMainTextView();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            currentText = textBox10.Text;
            pushTextInMainTextView();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            parseParagraph();
            printParsedResult();
        }
    }
}
