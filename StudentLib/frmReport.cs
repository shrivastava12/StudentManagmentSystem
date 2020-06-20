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
    public partial class frmReport : Form
    {
        DbContext Objdb = new DbContext();
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            GetReport();
            BindClass();
        }

        private void BindClass()
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = 0;
            DataSet ds = Objdb.GetDataProc("sp_GetClass", param);
            DataTable dt = ds.Tables[0];
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "----Select Class----" };
            dt.Rows.InsertAt(dr, 0);

            cmbclass.ValueMember = "id";
            cmbclass.DisplayMember = "className";
            cmbclass.DataSource = dt;
        }

        private void GetReport()
        {
            try
            {

                DataSet ds = Objdb.GetProc("SP_GetStudentReport");
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    dgvreport.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@classid", SqlDbType.Int);
            param[0].Value = cmbclass.SelectedValue;
            param[1] = new SqlParameter("@name", SqlDbType.VarChar);
            param[1].Value = txtname.Text;
            DataSet ds = Objdb.GetDataProc("SP_GetStudentClass ", param);
            DataTable dt = ds.Tables[0];

            dgvreport.DataSource = dt;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            dgvreport.DataSource = null;
            GetReport();
        }
    }
}
