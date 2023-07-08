using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmployeeManagementSystem
{
    public partial class Salaries : Form
    {

        Functions con;
        public Salaries()
        {
            InitializeComponent();
            con = new Functions();
            ShowSalaries();
            GetEmployees();
        }

        private void GetEmployees()                   
        {
            string Query = "select * from EmployeeTbl";
            SalEmpNamecom.DisplayMember = con.GetData(Query).Columns["EmpName"].ToString();
            SalEmpNamecom.ValueMember = con.GetData(Query).Columns["EmpId"].ToString();
            SalEmpNamecom.DataSource = con.GetData(Query);
        }

        int DSal = 0;
        string Period = "";
        private void GetSalary()                    
        {
            string Query = "select EmpSal from EmployeeTbl where EmpId = {0} " ;
            Query = string.Format(Query, SalEmpNamecom.SelectedValue.ToString());


            foreach (DataRow dr in con.GetData(Query).Rows)
            {
                DSal = Convert.ToInt32(dr  ["EmpSal"].ToString());

            }


            // MessageBox.Show("" + DSal);

            if (SalDaystxt.Text == "")
            {
                SalAmounttxt.Text = " Rs " + (d * DSal);
            }
            else if (Convert.ToInt32(SalDaystxt.Text) > 31 )
            {
                MessageBox.Show("Days can not be Greater than 31 ");
            }
            else
            {
                d = Convert.ToInt32(SalDaystxt.Text);
                SalAmounttxt.Text = " Rs " + (d * DSal); 
            }

        }

        private void ShowSalaries()
        {
            try
            {
                string Query = "Select * from SalaryTbl ";
                SalListdgv.DataSource = con.GetData(Query);
            }
            catch (Exception){
                throw;
            }
        }
        private void dgvDepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SalAddbtn_Click(object sender, EventArgs e)
        {
            GetSalary();
        }



        int d = 1;
        private void SalAddbtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                /* if (SalEmpNamecom.SelectedIndex == -1 || SalDaystxt.Text == "" || SalPeriodtime.Text == "")
                 {
                    // MessageBox.Show("Missing data !!!!");


                 }
                 else
                 {*/
                Period = SalPeriodtime.Value.Date.Month.ToString() + " - " + SalPeriodtime.Value.Date.Year.ToString();
                int Amount = DSal * Convert.ToInt32(SalDaystxt.Text);
                int sal_days = Convert.ToInt32(SalDaystxt.Text);

                string Query = "insert into SalaryTbl values(2 , 5 , '02/03/2023' , 5000 , '05/05/2023' )";
                // Query = string.Format(Query, SalEmpNamecom.ToString(), sal_days, Period, Amount, DateTime.Today.Date );
                con.SetData(Query);
                ShowSalaries();

                MessageBox.Show("Salary Paid !!!");
                SalDaystxt.Text = "";

                // }

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }

        }

        private void Logoutlbl_Click(object sender, EventArgs e)
        {
            Login objlog = new Login();
            objlog.Show();
            this.Hide();
        }
    }
}