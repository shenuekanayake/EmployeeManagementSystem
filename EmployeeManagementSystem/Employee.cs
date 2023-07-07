using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Employee : Form
    {
        Functions con;

        public object DepIdVariable { get; private set; }

        public Employee()
        {
            InitializeComponent();
            con = new Functions();
            ShowEmployees();
            GetDepartment();              // call the department function.........line 29  
        }






       private void ShowEmployees()
        {
            try
            {
                string Query = "Select * from EmployeeTbl ";
                EmpListdgv.DataSource = con.GetData(Query);
            }
            catch (Exception){
                throw;
            }
        } 






        private void GetDepartment()                    //Employee department  combox ekata, department table eke details aran combox eka fill kranna me class eka liwwe....
         {
            string Query = "select * from DepartmentTbl";
             EmpDepcom.DisplayMember = con.GetData(Query).Columns["DepName"].ToString();
             EmpDepcom.ValueMember = con.GetData(Query). Columns["DepId"].ToString();
             EmpDepcom.DataSource = con.GetData(Query) ;
         }







        private void EmpAddbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNametxt.Text == "" || EmpGencom.SelectedIndex == -1 || EmpDepcom.SelectedIndex == -1 || EmpSaltxt.Text == "" )
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string emp_Name = EmpNametxt.Text;
                    string emp_Gen = EmpGencom.SelectedItem.ToString();
                    int    emp_Dep = Convert.ToInt32(EmpDepcom.SelectedValue.ToString());
                    string emp_DOB = EmpDOBdt.Value.ToString();
                    string emp_Join = EmpJddt.Value.ToString();
                    int    emp_Sal = Convert.ToInt32( EmpSaltxt.Text);

                    string Query = string.Format("insert into EmployeeTbl values('{0}' , '{1}' , {2} , '{3}' , '{4}' , {5}  )", emp_Name , emp_Gen , emp_Dep , emp_DOB , emp_Join , emp_Sal);
                    con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee's Recorde Added!!!");
                    EmpNametxt.Text = "";
                    EmpSaltxt.Text = "";
                    EmpGencom.SelectedIndex = -1;
                    EmpDepcom.SelectedIndex = -1;



                    /* string Query = "insert into DepartmentTbl values('{0}')";
                    Query = string.Format(Query,txtDepName.Text);*/


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }







        private void EmpDeletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0 )
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                   

                    string Query = "delete from EmployeeTbl where EmpId = {0} ";
                    Query = string.Format(Query, Key);
                    con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee's Recorde deleted!!!");
                    EmpNametxt.Text = "";
                    EmpSaltxt.Text = "";
                    EmpGencom.SelectedIndex = -1;
                    EmpDepcom.SelectedIndex = -1;

                    /* string Query = "insert into DepartmentTbl values('{0}')";
                    Query = string.Format(Query,txtDepName.Text);*/
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }







        private void EmpUpdatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNametxt.Text == "" || EmpGencom.SelectedIndex == -1 || EmpDepcom.SelectedIndex == -1 || EmpSaltxt.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string emp_Name = EmpNametxt.Text;
                    string emp_Gen = EmpGencom.SelectedItem.ToString();
                    int emp_Dep = Convert.ToInt32(EmpDepcom.SelectedValue.ToString());
                    string emp_DOB = EmpDOBdt.Value.ToString();
                    string emp_Join = EmpJddt.Value.ToString();
                    int emp_Sal = Convert.ToInt32(EmpSaltxt.Text);

                    string Query = ("update EmployeeTbl set EmpName = '{0}' , EmpGen = '{1}' , EmpDep =  {2} , EmpDOB = '{3}' , EmpDate = '{4}' , EmpSal = {5} where EmpId = {6} " ) ;
                    Query = string.Format(Query, emp_Name, emp_Gen, emp_Dep, emp_DOB, emp_Join, emp_Sal,Key);
                    con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee's Recorde Added!!!");
                    EmpNametxt.Text = "";
                    EmpSaltxt.Text = "";
                    EmpGencom.SelectedIndex = -1;
                    EmpDepcom.SelectedIndex = -1;

                    /* string Query = "insert into DepartmentTbl values('{0}')";
                    Query = string.Format(Query,txtDepName.Text);*/
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void EmpListdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNametxt.Text = EmpListdgv.SelectedRows[0].Cells[1].Value.ToString();
            EmpGencom.Text = EmpListdgv.SelectedRows[0].Cells[2].Value.ToString();
            EmpDepcom.SelectedValue = EmpListdgv.SelectedRows[0].Cells[3].Value.ToString();
            EmpDOBdt.Text = EmpListdgv.SelectedRows[0].Cells[4].Value.ToString();
            EmpJddt.Text = EmpListdgv.SelectedRows[0].Cells[5].Value.ToString();
            EmpSaltxt.Text = EmpListdgv.SelectedRows[0].Cells[5].Value.ToString();
           
            




            if (EmpNametxt.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EmpListdgv.SelectedRows[0].Cells[0].Value.ToString());

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
