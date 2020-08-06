using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GPA_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String grade;
        double value;
        
        public double gradeTovalue(String grade){
            if(grade=="A+")
               value = 4.0;
            if(grade=="A")
               value = 4.0;
            if(grade=="A-")
               value = 3.7;
            if(grade=="B+")
               value = 3.3;
            if(grade=="B")
               value = 3.0;
            if(grade=="B-")
               value = 2.7;
            if(grade=="C+")
               value = 2.3;
            if(grade=="C")
               value = 2;
            if(grade=="C-")
               value = 1.7;
            if(grade=="E")
               value = 0.0;
            return value;
        }
        public double value1() {
           double mul1= 3*gradeTovalue(comboBox1.Text);
           return mul1;
        }
        public double value2()
        {
            double mul2 = 3 * gradeTovalue(comboBox2.Text);
            return mul2;
        }
        public double value3()
        {
            double mul3 = 2 * gradeTovalue(comboBox3.Text);
            return mul3;
        }
        public double value4()
        {
            double mul4 = 3 * gradeTovalue(comboBox4.Text);
            return mul4;
        }
        public double value5()
        {
            double mul5 = 3 * gradeTovalue(comboBox5.Text);
            return mul5;
        }
        public double value6()
        {
            double mul6 = 3 * gradeTovalue(comboBox6.Text);
            return mul6;
        }
        public double value7()
        {
            double mul7 = 3 * gradeTovalue(comboBox7.Text);
            return mul7;
        }
        public double value8()
        {
            double mul8 = 3 * gradeTovalue(comboBox8.Text);
            return mul8;
        }
        int n;
        public int isGpa() {
            if (cmb9.Text == "NON-GPA" && comboBox15.Text == "NON-GPA")
            {
                n = 17;
            }
            if ((cmb9.Text == "NON-GPA" && comboBox15.Text == "GPA") || (cmb9.Text == "GPA" && comboBox15.Text == "NON-GPA"))
            {
                n = 20;
            }
            if (cmb9.Text == "GPA" && comboBox15.Text == "GPA")
            {
                n = 23;
            }
            return n;
        }
        public double gpa()
        {
            double sumCore = value1() + value2() + value3() + value4() + value5() + value7();
            
            if(comboBox15.Text =="GPA"){
                sumCore += value6();
                if (cmb9.Text == "GPA")
                    sumCore += value8();
            }
            return sumCore;
        }
        String clz;
        public String classType()
        {
            if (double.Parse(txtSgpa.Text) >= 3.7)
            {
                clz = "First Class Honours";
            }
            if (double.Parse(txtSgpa.Text) < 3.7 && double.Parse(txtSgpa.Text) >= 3.3)
            {
                clz = "Second Class Honours Upper Division";
            }
            if (double.Parse(txtSgpa.Text) >= 3.0 && double.Parse(txtSgpa.Text) < 3.3)
            {
                clz = "Second Class Honours Lower Division";
            }
            return clz;
        }

        private void btncal_MouseHover(object sender, EventArgs e)
        {
            btncal.BackColor = Color.LimeGreen;
        }


        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Red;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            comboBox3.Text = " ";
            comboBox4.Text = " ";
            comboBox5.Text = " ";
            comboBox6.Text = " ";
            comboBox7.Text = " ";
            comboBox8.Text = " ";
            cmb9.Text = "";
            comboBox10.Text = " ";
            comboBox11.Text = " ";
            comboBox12.Text = " ";
            comboBox13.Text = " ";
            comboBox14.Text = " ";
            comboBox15.Text = " ";
            comboBox16.Text = " ";
        }
       
        private void btncal_Click(object sender, EventArgs e)
        {
            double sgpa = gpa() / isGpa();
            txtSgpa.Text = sgpa.ToString();
            txtClass.Text = classType();
           
         }


        }

      

        
    
}
