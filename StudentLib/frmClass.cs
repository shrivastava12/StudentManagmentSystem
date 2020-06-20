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
    public partial class frmClass : Form
    {
        DbContext objDc = new DbContext();
        int id = 0;
        public frmClass()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //get the value  from textbox and validate. 
            string classname = txtClassName.Text.ToUpper().ToString();
            if (!string.IsNullOrEmpty(classname))
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@className", SqlDbType.VarChar);
                param[0].Value = classname;
                int result = objDc.ExecuteProc("SP_AddClass", param);
                if (result > 0)
                {
                    MessageBox.Show("Saved");
                    GetClassList(0);
                }
                else
                {
                    MessageBox.Show("Some Error occurd!");
                }
            }

        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            try
            {
                GetClassList(0);
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void GetClassList(int id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DataSet ds = objDc.GetDataProc("sp_GetClass", param);
            if (ds.Tables.Count > 0)
            {
                grdClass.DataSource = ds.Tables[0];
                Reset();
            }
            else
            {
                MessageBox.Show(" Not Record Found");
            }
        }

        private void Reset()
        {
            btnSubmit.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            txtClassName.Text = string.Empty;
        }

        private void grdClass_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(grdClass.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtClassName.Text = grdClass.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnSubmit.Visible = false;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string classname = txtClassName.Text.ToUpper().ToString();
            if (!string.IsNullOrEmpty(classname) && id != 0)
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                param[1] = new SqlParameter("@className", SqlDbType.VarChar);
                param[1].Value = classname;
                int result = objDc.ExecuteProc("SP_UpdateClass", param);
                if (result > 0)
                {
                    MessageBox.Show("Updated");
                    GetClassList(0);
                }
                else
                {
                    MessageBox.Show("Some Error occurd!");
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (id != 0)
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;              
                int result = objDc.ExecuteProc("SP_DeleteClass", param);
                if (result > 0)
                {
                    MessageBox.Show("Deleted");
                    GetClassList(0);
                }
                else
                {
                    MessageBox.Show("Some Error occurd!");
                }
            }
        }

        private void grdClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
