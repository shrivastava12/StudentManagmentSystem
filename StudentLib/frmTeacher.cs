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
    
    public partial class frmTeacher : Form
    {
        DbContext Objdb = new DbContext();
        public frmTeacher()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmTeacher_Load(object sender, EventArgs e)
        { 
            BindSex();
            BindClass();
           
            

        }

        private void BindSex()
        {
            DataSet ds = Objdb.GetProc("sp_GetGender");
            DataTable dt = ds.Tables[0];
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "----Select Gender----" };
            dt.Rows.InsertAt(dr, 0);

            cmbsex.ValueMember = "id";
            cmbsex.DisplayMember = "genderName";
            cmbsex.DataSource = dt;
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

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            TeacherOL _ObjOl = new TeacherOL();

            if (!string.IsNullOrEmpty(txtname.Text) && !string.IsNullOrEmpty(txtfathername.Text) && !string.IsNullOrEmpty(txtqualification.Text) && !string.IsNullOrEmpty(txtspecialization.Text) && !string.IsNullOrEmpty(txtemail.Text) && !string.IsNullOrEmpty(txtexperience.Text)
                && cmbclass.Text != "" && cmbsex.Text != "")
            {
                _ObjOl.name = txtname.Text;
                _ObjOl.father = txtfathername.Text;
                _ObjOl.dob = Convert.ToDateTime(dtpdateofbirth.Text);
                _ObjOl.sex = Convert.ToInt32(cmbsex.SelectedValue);
                _ObjOl.qualification = txtqualification.Text;
                _ObjOl.specialization = txtspecialization.Text;
                _ObjOl.experience = txtexperience.Text;
                _ObjOl.classid = Convert.ToInt32(cmbclass.SelectedValue);
                _ObjOl.emailid = txtemail.Text;
                _ObjOl.address = txtaddress.Text;
                _ObjOl.contactno = txtcontactno.Text;
                _ObjOl.joindate = Convert.ToDateTime(dtpdateodjoin.Text);
                _ObjOl.whatsappno = txtcontactno.Text;
                _ObjOl.maritialstatus = cmbmaritalstatus.SelectedItem.ToString();
                _ObjOl.designation = txtdesignation.Text;




                SqlParameter[] param = new SqlParameter[15];


                param[0] = new SqlParameter("@name", SqlDbType.VarChar); param[0].Value = _ObjOl.name;
                param[1] = new SqlParameter("@father", SqlDbType.VarChar); param[1].Value = _ObjOl.father;
                param[2] = new SqlParameter("@DOB", SqlDbType.DateTime); param[2].Value = _ObjOl.dob;


                param[3] = new SqlParameter("@Sex", SqlDbType.Int); param[3].Value = _ObjOl.sex;

                param[4] = new SqlParameter("@Qualification", SqlDbType.VarChar); param[4].Value =_ObjOl.qualification;
                param[5] = new SqlParameter("@Specialization", SqlDbType.VarChar); param[5].Value = _ObjOl.specialization;
                param[6] = new SqlParameter("@Experience", SqlDbType.VarChar); param[6].Value = _ObjOl.experience;

                param[7] = new SqlParameter("@Classid", SqlDbType.Int); param[7].Value = _ObjOl.classid;
                param[8] = new SqlParameter("@EmailId", SqlDbType.VarChar); param[8].Value = _ObjOl.emailid;
                param[9] = new SqlParameter("@Address", SqlDbType.VarChar); param[9].Value = _ObjOl.address;
                param[10] = new SqlParameter("@ContactNo", SqlDbType.VarChar); param[10].Value = _ObjOl.contactno;
                param[11] = new SqlParameter("@joindate", SqlDbType.DateTime); param[11].Value = _ObjOl.joindate;
                param[12] = new SqlParameter("@Whatsappno", SqlDbType.VarChar); param[12].Value = _ObjOl.whatsappno;
                param[13] = new SqlParameter("@maritalstatus", SqlDbType.VarChar); param[13].Value = _ObjOl.maritialstatus;
                param[14] = new SqlParameter("@Designation", SqlDbType.VarChar); param[14].Value = _ObjOl.designation;
     
                
                int result = Objdb.ExecuteProc("SP_AddTeacher", param);
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


            
        }
    }

