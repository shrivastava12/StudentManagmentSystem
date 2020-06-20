using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentLib.DataAccess;
using System.Data.SqlClient;

namespace StudentLib
{
    public partial class frmAddFee : Form
    {
        DbContext ObjDb = new DbContext();
        int dueamount;
        
        
        public frmAddFee()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmAddFee_Load(object sender, EventArgs e)
        {

            GetMonth();
            GetClass();

        }

        private void GetClass()
        {

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = 0;
            DataSet ds = ObjDb.GetDataProc("sp_GetClass", param);
            DataTable dt = ds.Tables[0];
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "----Select Class----" };
            dt.Rows.InsertAt(dr, 0);

            cmbclass.ValueMember = "id";
            cmbclass.DisplayMember = "className";
            cmbclass.DataSource = dt;
        }

        private void GetMonth()
        {
            DataSet ds = ObjDb.GetProc("SP_GetMonth");
            DataTable dt = ds.Tables[0];
            

            cmbmonth.ValueMember = "id";
            cmbmonth.DisplayMember = "monthName";
            cmbmonth.DataSource = dt;
        }

 
        private void cmbclass_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int classid = Convert.ToInt32(cmbclass.SelectedValue);
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@classid", SqlDbType.Int);
            param[0].Value = classid;
            DataSet ds = ObjDb.GetDataProc("SP_GetStudentByClass", param);
            DataTable dt = ds.Tables[0];
            DataTable dt1 = ds.Tables[1];
            
            
            cmbstudent.ValueMember = "studentid";
            cmbstudent.DisplayMember = "name";
            cmbstudent.DataSource = dt;
            if (dt1.Rows.Count > 0)
            {
                txttotalfee.Text= dt1.Rows[0]["fee"].ToString();
            }
           

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            int classid = Convert.ToInt32(cmbclass.SelectedValue);
            int studentid = Convert.ToInt32(cmbstudent.SelectedValue);
            int monthid = Convert.ToInt32(cmbmonth.SelectedValue);
            int totalfee = Convert.ToInt32(txttotalfee.Text);
            int paidamount = Convert.ToInt32(txtpaidamount.Text);
            if (totalfee > paidamount)
            {
                dueamount = totalfee - paidamount;
            }
            DateTime date = Convert.ToDateTime(dtppayment.Text);

            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@classid", SqlDbType.Int); param[0].Value = classid ;
            param[1] = new SqlParameter("@studentid", SqlDbType.Int); param[1].Value = studentid;
            param[2] = new SqlParameter("@monthid", SqlDbType.Int); param[2].Value = monthid;
            param[3] = new SqlParameter("@totalfee", SqlDbType.Int); param[3].Value = totalfee;
            param[4] = new SqlParameter("@paidamount", SqlDbType.Int); param[4].Value = paidamount;
            param[5] = new SqlParameter("@dueamount", SqlDbType.Int); param[5].Value = dueamount;
            param[6] = new SqlParameter("@date", SqlDbType.DateTime); param[6].Value =date;



            int result = ObjDb.ExecuteProc("SP_AddFee", param);
            if (result > 0)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Please fill up all fields");
            }
        }

        private void txtpaidamount_TextChanged(object sender, EventArgs e)
        {
            int totalfee = Convert.ToInt32(txttotalfee.Text);
            int paidamount = Convert.ToInt32(txtpaidamount.Text);
            if (totalfee > paidamount)
            {
                dueamount = totalfee - paidamount;

            }
            txtdueamount.Text = Convert.ToString(dueamount);
        }
    }
}
