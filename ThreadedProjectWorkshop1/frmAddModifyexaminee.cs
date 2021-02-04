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
{
    /*
     * Author : Andries Joubert
     */
    public partial class frmAddModifyexaminee : Form
    {
        public bool isAdd;              // main form sets it
        public Examinee currentExaminee;  // main form sets it
        ExamineeDataContext db2 = new ExamineeDataContext();
        public frmAddModifyexaminee()
        {
            InitializeComponent();
        }

        private void frmAddModifyexaminee_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                examineeIDTextBox.Enabled = true;
                examineeIDTextBox.Focus();

                var ex = db2.Examinees.OrderBy(i => i.ExamineeID).ToList(); //Get Examinee IDs in a List
                var last = ex.Last();                                       //Get Last Examinee
                var exid = last.ExamineeID;                                 //Get value of Last ID in List
                Console.WriteLine(exid.ToString());                         //Check if Examinee ID is correct
                var newid = exid += 1;
                examineeIDTextBox.Text = newid.ToString();

            }
            else
            {
                DisplayCurrentExaminee();
                examineeIDTextBox.Enabled = false;
                examineeFirstnameTextBox.Focus();
            }
        }

        private void DisplayCurrentExaminee()
        {
            examineeIDTextBox.Text = currentExaminee.ExamineeID.ToString();
            examineeFirstnameTextBox.Text = currentExaminee.ExamineeFirstname;
            examineeLastnameTextBox.Text = currentExaminee.ExamineeLastname;
            examineeEmailTextBox.Text = currentExaminee.ExamineeEmail;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                if (Validator.IsPresent(examineeIDTextBox) &&
                    Validator.IsPresent(examineeFirstnameTextBox) &&
                    Validator.IsPresent(examineeLastnameTextBox) &&
                    Validator.IsPresent(examineeEmailTextBox))
                {

                    Examinee newExaminee = new Examinee // create product using provided data
                    {
                        ExamineeID = Convert.ToInt32(examineeIDTextBox.Text),
                        ExamineeFirstname = examineeFirstnameTextBox.Text,
                        ExamineeLastname = examineeLastnameTextBox.Text,
                        ExamineeEmail = examineeEmailTextBox.Text
                    };
                    using (ExamineeDataContext dbContext = new ExamineeDataContext())
                    {
                        dbContext.Examinees.InsertOnSubmit(newExaminee);
                        dbContext.SubmitChanges();
                    }
                    DialogResult = DialogResult.OK;

                }
                //else // validation  failed
                //{
                //    DialogResult = DialogResult.Cancel;
                //}
            }

            else // it is Modify
            {
                if (Validator.IsPresent(examineeIDTextBox) &&
                      Validator.IsPresent(examineeFirstnameTextBox) &&
                      Validator.IsPresent(examineeLastnameTextBox) &&
                      Validator.IsPresent(examineeEmailTextBox))
                {

                    try
                    {
                        int examinID = Convert.ToInt32(examineeIDTextBox.Text);
                        // ExamineeDataContext db2 = new ExamineeDataContext();
                        Examinee examin2 = new Examinee();
                        examin2 = db2.Examinees.Single(x => x.ExamineeID == examinID);
                        examin2.ExamineeFirstname = examineeFirstnameTextBox.Text;
                        examin2.ExamineeLastname = examineeLastnameTextBox.Text;
                        examin2.ExamineeID = Convert.ToInt32(examineeIDTextBox.Text);
                        examin2.ExamineeEmail = examineeEmailTextBox.Text;
                        db2.SubmitChanges();
                        DialogResult = DialogResult.OK;
                    }
                    catch (DBConcurrencyException)
                    {
                        MessageBox.Show("Other user changed or deleted data. Try Again", "Concurrency Error");
                    }
                    //Handling for general exception
                    catch (Exception ex)
                    {
                        MessageBox.Show("Other error while saving changes: " + ex.Message,
                            ex.GetType().ToString());
                    }

                }
                //else // validation failed
                //{
                //    DialogResult = DialogResult.Cancel;
                //}
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //MessageBox.Show("Changes have been canceled by user");
        }
    }
}
