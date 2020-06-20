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

namespace StudentLib
{
    public partial class TeacherReport : Form
    {
        DbContext ObjDb = new DbContext();
        public TeacherReport()
        {
            InitializeComponent();
        }

        private void TeacherReport_Load(object sender, EventArgs e)
        {
            GetTeacher();

        }

        private void GetTeacher()
        {
            DataSet ds = ObjDb.GetProc("SP_GetTeacherReport");
            DataTable dt = ds.Tables[0];
            dgvteacher.DataSource = dt;
        }
    }
}
