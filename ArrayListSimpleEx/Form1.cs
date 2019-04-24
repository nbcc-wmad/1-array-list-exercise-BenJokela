using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        ArrayList words = new ArrayList();
        bool reversed = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateArrayList();
        }
        private void PopulateArrayList()
        {
            words.Clear();
            words.Add("I");
            words.Add("love");
            words.Add("programming");
            words.Add("so");
            words.Add("much");

        }
        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            if (!reversed)
            {
                DisplayMessage();
            }
            else if(reversed)
            {
                words.Reverse();
                reversed = false;
                DisplayMessage();
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (!reversed)
            {
                words.Reverse();
                reversed = true;
                DisplayMessage();

            }
        }
        private void DisplayMessage()
        {
            string message = string.Empty;
            for (int i = 0; i < words.Count; i++)
            {
                message += words[i].ToString() + " ";
            }
            lblMessage.Text = message;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!reversed)
            {
                words.Insert(1, txtSecondPos.Text.Trim());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!reversed)
            {
                words.RemoveAt(1);

            }
        }
    }
}
