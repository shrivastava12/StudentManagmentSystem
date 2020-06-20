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
    public partial class frmissue : Form
    {
        DbContext ObjDb = new DbContext();

        public frmissue()
        {
            InitializeComponent();
        }

        private void frmissue_Load(object sender, EventArgs e)
        {
            BindClass();
            GetSize1();
            GetUniformType();
            GetColor();
        }

        private void GetColor()
        {
            DataSet ds = ObjDb.GetProc("SP_GetColor");
            DataTable dt = ds.Tables[0];
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "----Select Color -----" };
            dt.Rows.InsertAt(dr, 0);

            cmbcolor.ValueMember = "id";
            cmbcolor.DisplayMember = "colorname";
            cmbcolor.DataSource = dt;
        }

        private void GetUniformType()
        {
            DataSet ds = ObjDb.GetProc("sp_GetUniformType");
            DataTable dt = ds.Tables[0];
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "----Selec Uniform Type -----" };
            dt.Rows.InsertAt(dr, 0);

            cmbuniformtype.ValueMember = "id";
            cmbuniformtype.DisplayMember = "typename";
            cmbuniformtype.DataSource = dt;
        }

        private void GetSize1()
        {

            DataSet ds = ObjDb.GetProc("SP_GetSize");
            DataTable dt = ds.Tables[0];
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "----Select size----" };
            dt.Rows.InsertAt(dr, 0);

            cmbsize.ValueMember = "id";
            cmbsize.DisplayMember = "sizename";
            cmbsize.DataSource = dt;

        }
        
        private void BindClass()
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
       

        
       
        
     


        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@classid", SqlDbType.Int);
            param[0].Value = Convert.ToInt32(cmbclass.SelectedValue);
            param[1] = new SqlParameter("@typeid", SqlDbType.Int);
            param[1].Value = Convert.ToInt32(cmbuniformtype.SelectedValue);
            param[2] = new SqlParameter("@sizeid", SqlDbType.Int);
            param[2].Value = Convert.ToInt32(cmbsize.SelectedValue);
            DataSet ds = ObjDb.GetDataProc("sp_GetClass", param);
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
            {
                txtprice.Text = dt.Rows[0]["price"].ToString();
            }

        }

        private void cmbclass_SelectedIndexChanged(object sender, EventArgs e)
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




        }
    }
}
