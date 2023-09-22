using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_EntitiyFramework
{
    public partial class Form1 : Form
    {
        Library_DB2Entities objDB = new Library_DB2Entities();
        EMP E = new EMP();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            E.EMPID = Convert.ToInt32(txtEmpId.Text);
            E.ENAME = txtEname.Text;
            E.DESIGNATION = txtDesignation.Text;
            E.DOJ = Convert.ToDateTime(txtdoj.Text);
            E.SALARY = Convert.ToDecimal(txtSal.Text);
            E.DEPTNO = Convert.ToInt32(txtDeptNo.Text);
            objDB.EMPs.Add(E);
            objDB.SaveChanges();
            MessageBox.Show("Employee Added Successfully");
        }

        private void btnFInd_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtEmpId.Text);
            E = objDB.EMPs.Find(Id);
            if (E != null)
            {
                txtEname.Text = E.ENAME;
                txtDesignation.Text = E.DESIGNATION;
                txtdoj.Text = E.DOJ.ToString();
                txtSal.Text = E.SALARY.ToString();
                txtDeptNo.Text = E.DEPTNO.ToString();
            }
            else
            {
                MessageBox.Show("Record is not found");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtEmpId.Text);
            E = objDB.EMPs.Find(Id);
            if (E != null)
            {
                E.ENAME = txtEname.Text;
                E.DESIGNATION = txtDesignation.Text;
                E.DOJ = Convert.ToDateTime(txtdoj.Text);
                E.SALARY = Convert.ToDecimal(txtSal.Text);
                E.DEPTNO = Convert.ToInt32(txtDeptNo.Text);
                objDB.SaveChanges();
                MessageBox.Show("EMployee Date Updated Succesfully");
            }
            else
            {
                MessageBox.Show("Record not found");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtEmpId.Text);
            E = objDB.EMPs.Find(Id);
            if (E != null)
            {
                objDB.EMPs.Remove(E); objDB.SaveChanges();
                MessageBox.Show("Records are Deleted");

            }
            else
            {
                MessageBox.Show("Employee not Deleted");
            }
        }
    }

}
