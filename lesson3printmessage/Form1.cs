﻿using System;
using System.Windows.Forms;

namespace lesson3printmessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //msgLabel is the name of our label
            //msgLabel.Text will allow us to set the text property
            //= is the assignment operator
            //"Hello, World" is a string
            //; terminates the statement
            msgLabel.Text = "Hello, World!";

        }
    }
}
