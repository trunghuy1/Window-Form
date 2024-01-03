using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var db = new Lesson9Entities();
			var select = from s in db.Students select s;
			String st = "";
			foreach (var item in select)
			{
				st = st + "ID: " + item.studentID.ToString() + System.Environment.NewLine;
				st = st + "Name: " + item.studentName.ToString() +
				System.Environment.NewLine;
				st = st + "Gender: " + item.studentGender.ToString() +
				System.Environment.NewLine;
				st = st + "Address: " + item.Address_.ToString() + System.Environment.NewLine;
			}
			this.textBox1.Text = st;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var db = new Lesson9Entities();
			Student aStudent;
			if (db.Students.Find(5) == null)
			{
				aStudent = new Student();
				aStudent.studentID = 4;
				aStudent.studentName = "Nguyen Tri Dung";
				aStudent.studentGender = "Male";
				aStudent.Address_ = " 11 Le Lai";
				db.Students.Add(aStudent);
				db.SaveChanges();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var db = new Lesson9Entities();
			Student aStudent = new Student();
			aStudent = db.Students.Where(d => d.studentID == 3).First() as Student;
			aStudent.studentName = "Nguyen Van Linh";
			db.SaveChanges();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			var db = new Lesson9Entities();
			Student aStudent;
			aStudent = db.Students.Where(d => d.studentID == 5).First() as Student;
			db.Students.Remove(aStudent);
			db.SaveChanges();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			using (Lesson9Entities db = new Lesson9Entities())
			{
				Student aStudent;
				// add
				aStudent = new Student();
				aStudent.studentID = 5;
				aStudent.studentName= "Nguyen Tri Dung";
				aStudent.studentGender = "Male";
				aStudent.Address_ = " 11 Le Lai";
				db.Students.Add(aStudent);
				// update
				aStudent = db.Students.Where(d => d.studentID == 5).First() as Student;
				aStudent.studentName = "Nguyen Van Linh";
				//delete
				aStudent = db.Students.Where(d => d.studentID == 5).First() as Student;
				db.Students.Remove(aStudent);
				db.SaveChanges();
			}
		}
	}
}
