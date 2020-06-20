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
    public partial class frmTeacherSubjectAssignment : Form
    {

        DbContext ObjDb = new DbContext();
        public frmTeacherSubjectAssignment()
        {
            InitializeComponent();
        }

        private void TeacherSubjectAssignment_Load(object sender, EventArgs e)
        {
          
            GetTeacher();

        }

        



        private void GetTeacher()
        {
            DataSet ds = ObjDb.GetProc("SP_GetTeacher");
            DataTable dt = ds.Tables[0];
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "----Select Teacher----" };
            dt.Rows.InsertAt(dr, 0);
            cmbteacher.DisplayMember = "name";
            cmbteacher.ValueMember = "id";
            cmbteacher.DataSource = dt;
        }

        private void cmbteacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            int teacherid = Convert.ToInt32(cmbteacher.SelectedValue);
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@teacherid", SqlDbType.Int);
            param[0].Value = teacherid;
            DataSet ds = ObjDb.GetDataProc("SP_GetTeacherClassAssign", param);
            DataTable dt = ds.Tables[0];
            //DataRow dr;
            //dr = dt.NewRow();
            //dr.ItemArray = new object[] { 0, "----Select Teacher----" };
            //dt.Rows.InsertAt(dr, 0);
            cmbclass.DisplayMember = "ClassName";
            cmbclass.ValueMember = "Classid";
            cmbclass.DataSource = dt;
            //}
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    //grdClass.Rows.Add();
            //    //grdClass.Rows[i].Cells[1].Value = dt.Rows[i]["ClassName"];
            //    //grdClass.Rows[i].Cells[2].Value = dt.Rows[i]["Classid"];

            //}

        }

        

       

        private void cmbclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            int classid = Convert.ToInt32(cmbclass.SelectedValue);
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@classid", SqlDbType.Int);
            param[0].Value = classid;
            DataSet ds = ObjDb.GetDataProc("SP_GetSubject", param);
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                grdsubject.Rows.Add();
                grdsubject.Rows[i].Cells[1].Value = dt.Rows[i]["id"];
                grdsubject.Rows[i].Cells[2].Value = dt.Rows[i]["SubjectName"];
            }

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdsubject.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["CheckBox1"].Value);

                if (isSelected)
                {
                    int classid =Convert.ToInt32(cmbclass.SelectedValue);
                    int teacherid = Convert.ToInt32(cmbteacher.SelectedValue);
                    int subjectid = Convert.ToInt32(row.Cells["ID"].Value);

                    SqlParameter[] param = new SqlParameter[3];
                    param[0] = new SqlParameter("@teacherid", SqlDbType.Int); param[0].Value = teacherid;
                    param[1] = new SqlParameter("@classid", SqlDbType.Int); param[1].Value = classid;
                    param[2] = new SqlParameter("@subjectid", SqlDbType.Int); param[2].Value = subjectid;

                    int result = ObjDb.ExecuteProc("SP_AddTeacherSubjectAssign", param);

                    if (result > 0)
                    {
                        MessageBox.Show("Saved");
                    }
                }
            }
            
        }
    }
}
