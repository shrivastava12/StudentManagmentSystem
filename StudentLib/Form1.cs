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
    public partial class Form1 : Form
    {
        DbContext _dbcon = new DbContext();

        public Form1()
        {
            InitializeComponent();
        }

        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    string userid = txtUid.Text.Trim();
        //    string password = txtPwd.Text.Trim();
        //    if (!string.IsNullOrEmpty(userid) && !string.IsNullOrEmpty(password))
        //    {
        //        string Query = "SELECT  UserName,Password  FROM tbl_login Where Username='" + userid + "'";
        //        DataTable dtresult = _dbcon.GetdataTable(Query);

                
        //    }
        //}

        private void btnlogin1_Click(object sender, EventArgs e)
        {
            try
            {
                string userid = txtUid.Text.Trim();
                string password = txtPwd.Text.Trim();
                if (!string.IsNullOrEmpty(userid) && !string.IsNullOrEmpty(password))
                {
                    SqlParameter[] param = new SqlParameter[2];
                    param[0] = new SqlParameter("@USERNAME", SqlDbType.VarChar);
                    param[0].Value = userid;
                    param[1] = new SqlParameter("@Password", SqlDbType.VarChar);
                    param[1].Value = password;

                    DataSet dsresult = _dbcon.GetDataProc("SP_UserLogin", param);

                    if (dsresult.Tables.Count > 0)
                    {
                        Navigation obj = new Navigation();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login Details.");
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
           




        }
    }
}
