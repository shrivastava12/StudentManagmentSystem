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
    public partial class frmAddUniform : Form
    {
        DbContext ObjDb = new DbContext();
        public frmAddUniform()
        {
            InitializeComponent();
        }



        private void frmAddUniform_Load(object sender, EventArgs e)
        {
            GetSize();
            GetUniformType();
            GetColor();
            GetClass();


        }

        private void GetSize()
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

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {

                SqlParameter[] param = new SqlParameter[7];
                param[0] = new SqlParameter("@classid", SqlDbType.Int); param[0].Value = Convert.ToInt32(cmbclass.SelectedValue);
                param[1] = new SqlParameter("@uniformname", SqlDbType.VarChar); param[1].Value = txtuniformname.Text;
                param[2] = new SqlParameter("@typeid", SqlDbType.Int); param[2].Value = Convert.ToInt32(cmbuniformtype.SelectedValue);
                param[3] = new SqlParameter("@sizeid", SqlDbType.Int); param[3].Value = Convert.ToInt32(cmbsize.SelectedValue);
                param[4] = new SqlParameter("@colorid", SqlDbType.Int); param[4].Value = Convert.ToInt32(cmbcolor.SelectedValue);
                param[5] = new SqlParameter("@price", SqlDbType.Int); param[5].Value = Convert.ToInt32(txtprice.Text);
                param[6] = new SqlParameter("@count", SqlDbType.Int); param[6].Value = Convert.ToInt32(txttotalcount.Text);

                int result = ObjDb.ExecuteProc("SP_AddUniform", param);
                if (result > 0)
                {
                    MessageBox.Show("Saved Successfully");
                }
                else
                {
                    MessageBox.Show("Not Saved !!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
