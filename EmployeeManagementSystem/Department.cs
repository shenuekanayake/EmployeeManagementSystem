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
    public partial class Department : Form
    {
        Functions con;
        public Department()
        {
            InitializeComponent();

            con = new Functions();

            ShowDepartments();
        }






        private void ShowDepartments()
        {
            string Query = "Select * from DepartmentTbl ";
            dgvDepList.DataSource = con.GetData( Query );
        }








        private void btnDepAdd_Click(object sender, EventArgs e)
        {
            try{
                if (txtDepName.Text == ""){
                    MessageBox.Show("Missing Data!!!");
                }
                else{
                    string Dep = txtDepName.Text;
                    string Query = string.Format("insert into DepartmentTbl values('{0}')", txtDepName.Text);
                    con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department's Recorde Added!!!");
                    txtDepName.Text = "";

                    /* string Query = "insert into DepartmentTbl values('{0}')";
                    Query = string.Format(Query,txtDepName.Text);*/  


                }
            }
            catch (Exception Ex){
                MessageBox.Show(Ex.Message);
            }
        }






        int Key = 0;
        private void dgvDepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDepName.Text = dgvDepList.SelectedRows[0].Cells[1].Value.ToString();
            if (txtDepName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(dgvDepList.SelectedRows[0].Cells[0].Value.ToString());

            }
        }









        private void btnDepUpdate_Click(object sender, EventArgs e)
        {
            try{
                if (txtDepName.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Name = txtDepName.Text;
                    string Query = "Update  DepartmentTbl set DepName = '{0}' where DepId = {1}";
                    Query = string.Format(Query, txtDepName.Text,Key);
                    con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department's Recorde Updated!!!");
                    txtDepName.Text = "";
                }
            }
            catch (Exception Ex){
                MessageBox.Show(Ex.Message);
            }
        }








        private void btnDelete_Click(object sender, EventArgs e)
        {
            try{
                if (txtDepName.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = txtDepName.Text;
                    string Query = "Delete from  DepartmentTbl  where DepId = {0}";
                    Query = string.Format(Query, Key);
                    con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department's Recorde Deleted!!!");
                    txtDepName.Text = "";
                }
            }
            catch (Exception Ex){
                MessageBox.Show(Ex.Message);
            }
        }








        private void Emplbl_Click(object sender, EventArgs e)
        {
            Employee objemp = new Employee();               //Employee form ekata object ekak create kara eke thiyenwa classes call krnna one nisa....
            objemp.Show();
            this.Hide();    
        }

        private void Sallbl_Click(object sender, EventArgs e)
        {
            Salaries objsal = new Salaries();
            objsal.Show();
            this.Hide();
        }

        private void Logoutlbl_Click(object sender, EventArgs e)
        {
            Login objlog = new Login();
            objlog.Show();
            this.Hide();
        }
    }
}
