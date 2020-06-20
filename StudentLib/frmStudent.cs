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
using StudentLib.ObjetsLayer;

namespace StudentLib
{
    public partial class frmStudent : Form
    {

        DbContext Objdb = new DbContext();
        public frmStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            BindGender();
            BindSection();
            BindClass();

        }

        private void BindGender()
        {

            DataSet ds = Objdb.GetProc("sp_GetGender");
            DataTable dt = ds.Tables[0];
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "----Select Gender----" };
            dt.Rows.InsertAt(dr, 0);

            cmbgender.ValueMember = "id";
            cmbgender.DisplayMember = "genderName";
            cmbgender.DataSource = dt;

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

            cmbclassid.ValueMember = "id";
            cmbclassid.DisplayMember = "className";
            cmbclassid.DataSource = dt;
        }

        private void BindSection()
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = 0;
            DataSet ds = Objdb.GetDataProc("sp_GetSection", param);
            DataTable dt = ds.Tables[0];
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "----Select Section----" };
            dt.Rows.InsertAt(dr, 0);

            cmbsectionid.ValueMember = "id";
            cmbsectionid.DisplayMember = "SectionName";
            cmbsectionid.DataSource = dt;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {


            StudentOL _objSOL = new StudentOL();

            if (!string.IsNullOrEmpty(txtname.Text) && !string.IsNullOrEmpty(txtmothersname.Text) && !string.IsNullOrEmpty(txtfathersname.Text) && !string.IsNullOrEmpty(txtaddress.Text) && !string.IsNullOrEmpty(txtage.Text)
                && !string.IsNullOrEmpty(txtage.Text) && !string.IsNullOrEmpty(txtphoneno.Text) && cmbsectionid.Text != "" && cmbgender.Text != "" && cmbclassid.Text != "" && dtpadmissiondate.Text != "" && dtpdateofbirth.Text != "")
            {
                _objSOL.Name = txtname.Text;
                _objSOL.Classid = Convert.ToInt32(cmbclassid.SelectedValue);
                _objSOL.Fathersname = txtfathersname.Text;
                _objSOL.Mothersname = txtmothersname.Text;
                _objSOL.address = txtaddress.Text;
                _objSOL.age = Convert.ToDouble(txtage.Text);
                _objSOL.phoneno = txtphoneno.Text;
                _objSOL.email = txtemail.Text;
                _objSOL.genderId = Convert.ToInt32(cmbgender.SelectedValue);
                _objSOL.SectionID = Convert.ToInt32(cmbsectionid.SelectedValue);
                _objSOL.dateofbirth = Convert.ToDateTime(dtpdateofbirth.Text);
                _objSOL.admitiondate = Convert.ToDateTime(dtpadmissiondate.Text);

                SqlParameter[] param = new SqlParameter[12];
                param[0] = new SqlParameter("@name", SqlDbType.VarChar); param[0].Value = _objSOL.Name;
                param[1] = new SqlParameter("@fathersname", SqlDbType.VarChar); param[1].Value = _objSOL.Fathersname;
                param[2] = new SqlParameter("@mothersname", SqlDbType.VarChar); param[2].Value =_objSOL.Mothersname;
                param[3] = new SqlParameter("@address", SqlDbType.VarChar); param[3].Value = _objSOL.address;
                param[4] = new SqlParameter("@age", SqlDbType.Float); param[4].Value = _objSOL.age;
                param[5] = new SqlParameter("@phoneno", SqlDbType.VarChar); param[5].Value = _objSOL.phoneno;
                param[6] = new SqlParameter("@email", SqlDbType.VarChar); param[6].Value = _objSOL.email;
                param[7] = new SqlParameter("@dateofbirth", SqlDbType.DateTime); param[7].Value = _objSOL.dateofbirth;
                param[8] = new SqlParameter("@admitiondate", SqlDbType.DateTime); param[8].Value = _objSOL.admitiondate;
                param[9] = new SqlParameter("@sectionid", SqlDbType.Int); param[9].Value = _objSOL.SectionID;
                param[10] = new SqlParameter("@classid", SqlDbType.Int); param[10].Value = _objSOL.Classid;
                param[11] = new SqlParameter("@genderid", SqlDbType.Int); param[11].Value = _objSOL.genderId;
      
                int result = Objdb.ExecuteProc("SP_AddStudent", param);
                if (result > 0)
                {
                    MessageBox.Show("Saved");
                    
                }
                else
                {
                    MessageBox.Show("Some Error occurd!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Entry");
            }





        }

        private void dtpdateofbirth_ValueChanged(object sender, EventArgs e)
        {

           // DateTime dt = Convert.ToDateTime(dtpdateofbirth.Text);
           // TimeSpan ageTimeSpan = DateTime.UtcNow.Subtract(dt);
           // int age = new DateTime(ageTimeSpan.Ticks).Month;
            // txtage.Text = Convert.ToString(age);

            // var today = DateTime.Today;
            //  DateTime dt = Convert.ToDateTime(dtpdateofbirth.Text);
            //  var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            //  var b = (dt.Year * 100 + dt.Month) * 100 + dt.Day;
            // var age = (a - b) / 10000 ;
            // age = age * 12;
           DateTime Dob = Convert.ToDateTime(dtpdateofbirth.Text);
           DateTime Now = DateTime.Now;    
           int _Years = new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1;    
           DateTime _DOBDateNow = Dob.AddYears(_Years);    
           int _Months = 0;    
           for (int i = 1; i <= 12; i++)    
           {    
               if (_DOBDateNow.AddMonths(i) == Now)    
               {    
                   _Months = i;    
                   break;    
               }    
               else if (_DOBDateNow.AddMonths(i) >= Now)    
               {    
                   _Months = i - 1;    
                   break;    
               }    
           }    
           int Days = Now.Subtract(_DOBDateNow.AddMonths(_Months)).Days;

           int age = _Years * 12 + _Months;
           txtage.Text = Convert.ToString(age);
            
           //return $"Age is {_Years} Years {_Months} Months {Days} Days";     
        }

        private void cmbsectionid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
