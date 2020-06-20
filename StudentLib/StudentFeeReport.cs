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
    public partial class StudentFeeReport : Form
    {
        DbContext ObjDb = new DbContext();
        public StudentFeeReport()
        {
            InitializeComponent();
        }

        private void StudentFeeReport_Load(object sender, EventArgs e)
        {
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

        private void btnsearchbyname_Click(object sender, EventArgs e)
        {
            string studentName = txtname.Text;
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@studentname", SqlDbType.VarChar);
            param[0].Value = studentName;
            DataSet ds = ObjDb.GetDataProc("SP_GetStudentFeeReportByname ", param);
            DataTable dt = ds.Tables[0];
            grdstudentfee.DataSource = dt;

        }

        private void reset_Click(object sender, EventArgs e)
        {
            grdstudentfee.DataSource = null;
        }

        private void cmbclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            int classid = Convert.ToInt32(cmbclass.SelectedValue);
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@classid", SqlDbType.Int);
            param[0].Value = classid;
            DataSet ds = ObjDb.GetDataProc("SP_GetStudentFeeReportByClass ", param);
            DataTable dt = ds.Tables[0];
            grdstudentfee.DataSource = dt;
        }
    }
}
