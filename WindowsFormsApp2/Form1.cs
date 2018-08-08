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
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            labelName.Text = textBox1.Text;
            this.textBox1.Focus();
            this.textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (this.textBoxTask.Text != "")
            {
                listBoxTodo.Items.Add(this.textBoxTask.Text);
                this.textBoxTask.Focus();
                this.textBoxTask.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a todo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxDone.Items.Add(listBoxTodo.SelectedItem);
            listBoxTodo.Items.Remove(listBoxTodo.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxTodo.Items.Add(listBoxDone.SelectedItem);
            listBoxDone.Items.Remove(listBoxDone.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
