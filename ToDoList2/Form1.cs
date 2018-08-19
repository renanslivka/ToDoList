using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList2
{
    public partial class Form1 : Form
    {
        //private int poss;
        public Form1()
        {
            InitializeComponent();
        }

        private void AddItem(string Text, bool Checked)
        {
            ToDoITask task = new ToDoITask(Text, Checked);
            task.Top = panel1.Controls.Count * task.Height; //poss;
            panel1.Controls.Add(task);
            //poss = (task.Top + task.Height);
        }

        private void AddNewTaskButton_Click(object sender, EventArgs e)
        {
            AddItem(textBox1.Text, false);
        }
    }
}
