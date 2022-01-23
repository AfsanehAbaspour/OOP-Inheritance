using System;
using System.Collections.Generic;
using OOPExamples.Entities.Personel;
using System.Windows.Forms;
using System.Linq;

namespace OOPExamples.WindowsEndPoint5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Person> people = new();


        private void Form1_Load(object sender, EventArgs e)
        {

            GridPeople.AutoGenerateColumns = false;

            people = new List<Person>
            {
                new Person("aaa1","bbb1","1122334455",new DateTime(2001,1,1),true),
                new Person("aaa2","bbb2","1122334455",new DateTime(2002,1,1),false, EnMaritalStatus.مطلقه),
                new Person("aaa3","bbb3","1122334455",new DateTime(2003,1,1),true),
                new Person("aaa4","bbb4","1122334455",new DateTime(2004,1,1),false, EnMaritalStatus.متاهل),
                new Person("aaa5","bbb5","1122334455",new DateTime(2005,1,1),true),
                new Person("aaa6","bbb6","1122334455",new DateTime(2006,1,1),false, EnMaritalStatus.مجرد),
                new Person("aaa7","bbb7","1122334455",new DateTime(2007,1,1),true),
            };

            GridPeople.DataSource = people;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            var result = (from p in people
                         select p).ToList();
            GridPeople.DataSource = result;
        }

        private void BtnLinq01_Click(object sender, EventArgs e)
        {
            var result = from p in people
                         where p.Age > 18
                         select p;

            // GridPeople.DataSource = result;
            GridPeople.DataSource = result.ToList();

        }

        private void BtnLinq02_Click(object sender, EventArgs e)
        {
            var result = (from p in people
                          where p.MaritalStatus == EnMaritalStatus.نامزد
                          select p).ToArray();

            GridPeople.DataSource = result;
        }

        private void BtnLinq03_Click(object sender, EventArgs e)
        {
            var result = (from p in people
                          where p.MaritalStatus == EnMaritalStatus.نامزد &&
                                p.Age < 18
                          select p).ToList();

            GridPeople.DataSource = result;
        }

        private void BtnLinq04_Click(object sender, EventArgs e)
        {
            var result = (from p in people
                          where p.BirthDate.Year >= 2002 && p.BirthDate.Year <= 2006
                          select p).ToList();

            GridPeople.DataSource = result;
        }

        private void BtnLinq05_Click(object sender, EventArgs e)
        {
            var result = (from p in people
                          where p.BirthDate.Year >= 2002 && 
                                p.BirthDate.Year <= 2006 &&
                                !p.Gender
                          select p).ToList();

            GridPeople.DataSource = result;
        }
    }
}
