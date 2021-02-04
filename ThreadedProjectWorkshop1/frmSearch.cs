using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadedProjectWorkshop1
{/*
  * Author: Edvin Lin
  */
    public partial class frmSearch : Form
    {
        ExamineeDataContext dbContext = new ExamineeDataContext();
        private int searchby;
        public frmSearch()
        {
            InitializeComponent();
        }


        private void frmSearch_Load(object sender, EventArgs e)
        {
            Reset();
            RefreshGridView();
        }

        //Button Click Functions

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // On press, opens second form, and opens blank new examinee
            frmAddModifyexaminee secondForm = new frmAddModifyexaminee();
            secondForm.isAdd = true;
            secondForm.currentExaminee = null;
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                RefreshGridView();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            // On press, checks selected cell, and search database for examinee id
            int rowNum = examineeDataGridView.CurrentCell.RowIndex;
            string examinID = examineeDataGridView[0, rowNum].Value.ToString();

            Examinee currentExaminee;
            using (ExamineeDataContext dbContext = new ExamineeDataContext())
            {
                currentExaminee = (from exe in dbContext.Examinees
                                   where Convert.ToString(exe.ExamineeID) == examinID
                                   select exe).SingleOrDefault();
            }
            //Display examinee data in form

            frmAddModifyexaminee secondForm = new frmAddModifyexaminee();
            secondForm.isAdd = false;
            secondForm.currentExaminee = currentExaminee;
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Retry)
            {
                RefreshGridView();
            }
        }
        
        private void btnDeleterecord_Click(object sender, EventArgs e)
        {
            //Checks ID and deletes ID
            int rowNum = examineeDataGridView.CurrentCell.RowIndex;
            string examinID = examineeDataGridView[0, rowNum].Value.ToString();

            DialogResult answer = MessageBox.Show("Are you sure you want to delete " + examinID + "?", "Confirm", MessageBoxButtons.OKCancel);
            if (answer == DialogResult.OK)
            {
                using (ExamineeDataContext dbContext = new ExamineeDataContext())
                {
                    try
                    {
                        Examinee currentExaminee = (from exe in dbContext.Examinees
                                                    where exe.ExamineeID == Convert.ToInt32(examinID)
                                                    select exe).SingleOrDefault();

                        dbContext.Examinees.DeleteOnSubmit(currentExaminee);
                        dbContext.SubmitChanges();
                        RefreshGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void btnSearchBy_Click(object sender, EventArgs e)
        {
            SearchRequest();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
            DisplayAllSessions();
            DisplayAllStudents();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Methods

        private void RefreshGridView()
        {
            DisplayAllSessions();
            DisplayAllStudents();
        }

        private void DisplayAllStudents()
        {
            examineeDataGridView.DataSource = from s in dbContext.Examinees
                                              select new
                                              {
                                                  ID = s.ExamineeID,
                                                  Name = s.ExamineeFirstname + " " + s.ExamineeLastname,
                                                  Email = s.ExamineeEmail
                                              };
        }


        private void DisplayAllSessions()
        {

            searchDataGridView.DataSource = (from s in dbContext.UserSessions
                                             join e in dbContext.Exams on s.ExamID equals e.ExamID
                                             join ex in dbContext.Examinees on s.ExamineeID equals ex.ExamineeID
                                             select new
                                             {
                                                 SessionID = s.SessionID,
                                                 ExamineeID = s.ExamineeID,
                                                 ExamineeName = ex.ExamineeFirstname + " " + ex.ExamineeLastname,
                                                 ExamID = s.ExamID,
                                                 ExamName = e.ExamName,
                                                 Date_time = s.Date_time

                                             });
        }

        private void Reset()
        {
            cbSearchBy.SelectedIndex = 0;
            txtSearchBy.Text = "";
            txtSearchBy.Focus();
        }

        private void SearchRequest()
        {
            searchby = Convert.ToInt32(txtSearchBy.Text);
            if (cbSearchBy.SelectedIndex == 0) // Examinee ID
            {
                var search = dbContext.Examinees.Where(x => x.ExamineeID == searchby).FirstOrDefault();
                if (search != null)
                {
                    searchDataGridView.DataSource = (from s in dbContext.UserSessions
                                                     join e in dbContext.Exams on s.ExamID equals e.ExamID
                                                     join ex in dbContext.Examinees on s.ExamineeID equals ex.ExamineeID
                                                     where s.ExamineeID == searchby
                                                     select new
                                                     {
                                                         SessionID = s.SessionID,
                                                         ExamID = s.ExamID,
                                                         ExamineeID = s.ExamineeID,
                                                         Date_time = s.Date_time,
                                                         ProctorID = s.ProctorID,
                                                         ExamName = e.ExamName,
                                                         ExamineeName = ex.ExamineeFirstname + " " + ex.ExamineeLastname
                                                     });


                }
                else
                {
                    MessageBox.Show("The requested entry does not exist");
                }
            }
            else if (cbSearchBy.SelectedIndex == 1) // Exam ID
            {
                var search = dbContext.Exams.Where(x => x.ExamID == searchby).FirstOrDefault();
                if (search != null)
                {
                    searchDataGridView.DataSource = (from s in dbContext.UserSessions
                                                     join e in dbContext.Exams on s.ExamID equals e.ExamID
                                                     join ex in dbContext.Examinees on s.ExamineeID equals ex.ExamineeID
                                                     where s.ExamID == searchby
                                                     select new
                                                     {
                                                         SessionID = s.SessionID,
                                                         ExamID = s.ExamID,
                                                         ExamineeID = s.ExamineeID,
                                                         Date_time = s.Date_time,
                                                         ProctorID = s.ProctorID,
                                                         ExamName = e.ExamName,
                                                         ExamineeName = ex.ExamineeFirstname + " " + ex.ExamineeLastname
                                                     });
                }
                else
                {
                    MessageBox.Show("The requested entry does not exist");
                }
            }
            else if (cbSearchBy.SelectedIndex == 2) //SessionID
            {
                var search = dbContext.UserSessions.Where(x => x.SessionID == searchby).FirstOrDefault();
                if (search != null)
                {
                    searchDataGridView.DataSource = (from s in dbContext.UserSessions
                                                     join e in dbContext.Exams on s.ExamID equals e.ExamID
                                                     join ex in dbContext.Examinees on s.ExamineeID equals ex.ExamineeID
                                                     where s.SessionID == searchby
                                                     select new
                                                     {
                                                         SessionID = s.SessionID,
                                                         ExamID = s.ExamID,
                                                         ExamineeID = s.ExamineeID,
                                                         Date_time = s.Date_time,
                                                         ProctorID = s.ProctorID,
                                                         ExamName = e.ExamName,
                                                         ExamineeName = ex.ExamineeFirstname + " " + ex.ExamineeLastname
                                                     });
                }
                else
                {
                    MessageBox.Show("The requested entry does not exist");
                }
            }
        }

        private void examineeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //On cell click, get examinee ID and display all data pertaining to examinee
            int rowIndex = examineeDataGridView.CurrentCell.RowIndex;
            string examineeID = examineeDataGridView[0, rowIndex].Value.ToString();

                                searchDataGridView.DataSource = (from a in dbContext.UserSessions
                                                     join b in dbContext.Exams on a.ExamID equals b.ExamID
                                                     join c in dbContext.Examinees on a.ExamineeID equals c.ExamineeID
                                                     where Convert.ToString(a.ExamineeID) == examineeID
                                                     select new
                                                     {
                                                         SessionID = a.SessionID,                                                       
                                                         ExamineeID = a.ExamineeID,
                                                         ExamineeName = c.ExamineeFirstname + " " + c.ExamineeLastname,                                                       
                                                         ExamID = a.ExamID,
                                                         ExamName = b.ExamName,
                                                         Date_time = a.Date_time

                                                     });

        }
    }
}
