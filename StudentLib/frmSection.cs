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
    public partial class frmSection : Form
    {
        DbContext objDc = new DbContext();
        int id = 0;
        public frmSection()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string sectionName = txtsection.Text.ToUpper().ToString();

            if (!string.IsNullOrEmpty(sectionName))
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@sectioName", SqlDbType.VarChar);
                param[0].Value = sectionName;
                int result = objDc.ExecuteProc("SP_AddSection", param);
                if (result > 0)
                {
                    MessageBox.Show("saved");
                }
                else
                {
                    MessageBox.Show("Some Error Occured");
                }
            }
        }

        private void frmSection_Load(object sender, EventArgs e)
        {
            try
            {
                getSection(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getSection(int id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DataSet ds = objDc.GetDataProc("sp_GetSection", param);
            if (ds.Tables.Count > 0)
            {
                grdsection.DataSource = ds.Tables[0];
                Reset();
            }
            else
            {
                MessageBox.Show(" Not Record Found");
            }
        }

        private void Reset()
        {
            btnsubmit.Visible = true;
            btnupdate.Visible = false;
            btndelete.Visible = false;
            txtsection.Text = string.Empty;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string sectionname = txtsection.Text.ToUpper().ToString();
            if (!string.IsNullOrEmpty(sectionname) && id != 0)
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                param[1] = new SqlParameter("@sectionName", SqlDbType.VarChar);
                param[1].Value = sectionname;
                int result = objDc.ExecuteProc("SP_UpdateSection", param);
                if (result > 0)
                {
                    MessageBox.Show("Updated");
                    getSection(0);
                }
                else
                {
                    MessageBox.Show("Some Error occurd!");
                }
            }

        }

        private void grdsection_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(grdsection.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtsection.Text = grdsection.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnsubmit.Visible = false;
            btnupdate.Visible = true;
            btndelete.Visible = true;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@Id", SqlDbType.Int);
                param[0].Value = id;
                int result = objDc.ExecuteProc("SP_DeleteSection", param);
                if (result > 0)
                {
                    MessageBox.Show("Deleted");
                    getSection(0);
                }
                else
                {
                    MessageBox.Show("Some Error occurd!");
                }
            }
        }
    }
}
