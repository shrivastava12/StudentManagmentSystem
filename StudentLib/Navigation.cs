using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentLib
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void addClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            frmClass objcls = new frmClass();
            objcls.MdiParent = this;
            objcls.Show();
            
        }

        private void addSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSection objsec = new frmSection();
            objsec.MdiParent = this;
            objsec.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent objstu = new frmStudent();
            objstu.MdiParent = this;
            objstu.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport abc = new frmReport();
            abc.MdiParent = this;
            abc.Show();
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacher abc = new frmTeacher();
            abc.MdiParent = this;
            abc.Show();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherReport abc = new TeacherReport();
            abc.MdiParent = this;
            abc.Show();

        }

        private void teacherClassAssignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherAssignment abc = new frmTeacherAssignment();
            abc.MdiParent = this;
            abc.Show();
        }

        private void teacherSubjecrtAssignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherSubjectAssignment abc = new frmTeacherSubjectAssignment();
            abc.MdiParent = this;
            abc.Show();
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddFee abc = new frmAddFee();
            abc.MdiParent = this;
            abc.Show();
        }

        private void addFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentFeeReport abc = new StudentFeeReport();
            abc.MdiParent = this;
            abc.Show();
        }

        private void addUniformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUniform abc = new frmAddUniform();
            abc.MdiParent = this;
            abc.Show();
        }

        private void uniformIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmissue abc = new frmissue();
            abc.MdiParent = this;
            abc.Show();
        }

    }
}

