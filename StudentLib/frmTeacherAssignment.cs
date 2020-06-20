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
    public partial class frmTeacherAssignment : Form
    {
        DbContext objDb = new DbContext();
        public frmTeacherAssignment()
        {
            InitializeComponent();
        }

        private void frmTeacherAssignment_Load(object sender, EventArgs e)
        {
            BindTeacher();
            BindClass();

        }

        private void BindTeacher()
        {
            DataSet ds = objDb.GetProc("SP_GetTeacher");
            DataTable dt = ds.Tables[0];
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "----Select Teacher----" };
            dt.Rows.InsertAt(dr, 0);
            cmbteacher.DisplayMember = "name";
            cmbteacher.ValueMember = "id";
            cmbteacher.DataSource = dt;
        }

        private void BindClass()
        {

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = 0;
            DataSet ds = objDb.GetDataProc("sp_GetClass", param);
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                grdClasses.Rows.Add();
                grdClasses.Rows[i].Cells[1].Value = dt.Rows[i]["id"];
                grdClasses.Rows[i].Cells[2].Value = dt.Rows[i]["ClassName"];

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in grdClasses.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);


                if (isSelected)
                {
                    int classid = Convert.ToInt32(row.Cells["id"].Value);
                    int teacherid = Convert.ToInt32(cmbteacher.SelectedValue);

                    SqlParameter[] param = new SqlParameter[2];
                    param[0] = new SqlParameter("@teacherid", SqlDbType.Int); param[0].Value = teacherid;
                    param[1] = new SqlParameter("@classid", SqlDbType.Int); param[1].Value = classid;

                    int result = objDb.ExecuteProc("SP_AddTeacherClassAssign", param);


                }
            }
            BindClass();
            //if (result > 0)
            //{
            //    MessageBox.Show("Saved");

            //}
            //else
            //{
            //    MessageBox.Show("Some Error occurd!");
            //}
        }

        private void cmbteacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            int teacherid = Convert.ToInt32(cmbteacher.SelectedValue);
            if (teacherid > 0)
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@teacherid", SqlDbType.Int);
                param[0].Value = teacherid;
                DataSet ds = objDb.GetDataProc("SP_GetTeacherClassAssign", param);
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        foreach (DataGridViewRow row in grdClasses.Rows)
                        {
                            int classid = Convert.ToInt32(row.Cells["id"].Value);
                            if (classid.Equals(dt.Rows[i]["Classid"]))
                            {
                                row.Cells["checkBoxColumn"].Value = true;
                            }
                        }
                    }
                }
                //else
                //{
                //    btnSubmit.Visible = true;
                //    BtnUpdate.Visible = false;
                //}
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
