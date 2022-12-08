using OOP_4th_Study_Lists.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_4th_Study_Lists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Lab l;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = textBox1.Text;
            s.LastName = textBox2.Text;

            s.Laboratory = l;
            l.Students.Add(s);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            l = new Lab();
            l.Numb = "101";
            l.Students=new List<Student>();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            foreach(Student item in l.Students)
            {
                MessageBox.Show(item.ReflectInfo());
            }
        }
    }
}
