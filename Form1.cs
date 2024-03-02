using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CRM1
{
    public partial class Form1 : Form
    {
        public string getid;
        public Boolean presentaddr = false;
        public Boolean firstname = false;
        public Boolean middlename = false;
        public Boolean lastname = false;
        public Boolean altermobileno = false;
        public Boolean mobileno = false;
        public Boolean email = false;
        public Boolean permanentaddress = false;
        public Boolean pin = false;
        public Boolean other = false;
        public string gender;
        public string EducationStatus;
        public string ProfessionalStatus;
        public string Reference;
        public string CourseInterested1 = "";
       
        //public string GradId { get; set; }
        public string timeprefered;
        public static Form1 instance;
        public ListView ls;
        public Form1()
        {
          
            InitializeComponent();
            instance=this;
            ls = listView1;
        }
        DataTable dt = new DataTable();
        SqlDataReader dr;
        private bool emailexistOk;
        private string Gradid;
        private string PGid;

        private void Form1_Load(object sender, EventArgs e)
        {
            clsConsular cl = new clsConsular();
            dt = cl.GetCountry();
            cmbbxCountry.DisplayMember = "CountryName";
            cmbbxCountry.ValueMember = "CountryId";
            cmbbxCountry.DataSource = dt;


            clsConsular obj = new clsConsular();

             clsConsular obj1 = new clsConsular();
              DataTable dt1 = new DataTable();
            
                  dt1 = obj1.Getgraduation();
                 cmbbxGraduation.DisplayMember = "GradName";
                cmbbxGraduation.ValueMember = "GradId";
                cmbbxGraduation.DataSource = dt1;
                 cmbbxGraduation.Text = Gradid;

            //clsConsular p6 = new clsConsular();
            //dt = p6.GetPG();
            //cmbbxPG.DisplayMember = "PGName";
            //cmbbxPG.ValueMember = "PGId";
            //cmbbxPG.DataSource = dt;



            //clsConsular p5 = new clsConsular();
            //DataTable dt2 = new DataTable();
            //dt2 = p5.GetPG();
            //grdViewPG.DataSource = dt2;
            //grdViewPG.Columns["PGId"].Visible = false;
            //grdViewPG.Rows[0].Cells[0].Value = false;


            clsConsular obj3 = new clsConsular();
            dt = obj3.GetEnquiry();
            cmbbxEnquirySource.DisplayMember = "EnquirySourceName";
            cmbbxEnquirySource.ValueMember = "EnquirySourceId";
            cmbbxEnquirySource.DataSource = dt;

            DataTable dt2= new DataTable();
            dt2= obj3.Course();
            grdCourse.DataSource = dt2;
            grdCourse.Columns["CourseId"].Visible = false;
            grdCourse.Rows[0].Cells[0].Value = false;
        }
            
        

        

    

        private void cmbbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsConsular obj5 = new clsConsular();
            int CountryId = Convert.ToInt32(cmbbxCountry.SelectedValue);
            obj5.CountryId = CountryId;

            dt = obj5.GetState();
            cmbbxstate.DisplayMember = "StateName";
            cmbbxstate.ValueMember = "StateId";
            cmbbxstate.DataSource = dt;
        }

        private void cmbbxstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsConsular obj6 = new clsConsular();
            int StateId = Convert.ToInt32(cmbbxstate.SelectedValue);
            obj6.Stateid = StateId;
            dt = obj6.GetCity();
            cmbbxCity.DisplayMember = "CityName";
            cmbbxCity.ValueMember = "CityId";
            cmbbxCity.DataSource = dt;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            clsConsular copy = new clsConsular();

            clsConsular c4 = new clsConsular();
            DataTable dt1 = new DataTable();
            dt1 = c4.GetStud();
            int count = Convert.ToInt32(dt1.Rows[0][0]);
            count = count + 1;
            string studcode = "St" + String.Format("{0:10000}", count);

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if ( firstname== true &&  middlename==true && lastname==true && altermobileno == true && mobileno == true &&
                    email == true && pin == true 
                    && presentaddr == true
                    && permanentaddress == true) 

                if (string.IsNullOrEmpty(cmbbxCountry.Text))
                {
                    errorprovider.SetError(cmbbxCountry, "Country must  be required");

                }
                else
                {
                    errorprovider.SetError(cmbbxCountry, string.Empty);
                }
                if (string.IsNullOrEmpty(cmbbxstate.Text))
                {
                    errorprovider.SetError(cmbbxstate, "State must  be required");

                }
                else
                {
                    errorprovider.SetError(cmbbxstate, string.Empty);
                }

               if(cmbbxCity!=null)
                {
                    errorprovider.SetError(cmbbxCity, string.Empty);
                }
                else
                {
                    errorprovider.SetError(cmbbxCity, "city must be required");
                }

                string value=txtfirstname.Text;
                string value1=txtmiddlename.Text;
                string value2=txtlastname.Text; 

                string StudFullName=value+value1+value2;    


                string[] CourseInterested = { };
                string education = "";
                foreach (DataGridViewRow dr in grdCourse.Rows)
                {
                    if (dr.Cells[0].Value != null)
                    {
                        if ((bool)dr.Cells[0].Value == true)
                        {
                            int row = dr.Cells[0].RowIndex;
                            CourseInterested = CourseInterested.Append(grdCourse.Rows[row].Cells["CourseId"].Value.ToString()).ToArray();
                        }
                    }
                }
                copy.EnquiryDate = DateTime.UtcNow;
                education = string.Join(",", CourseInterested);
                copy.CourseInterested = education;


                //string[] graduation = { };
                //string UG = "";
                //foreach (DataGridViewRow dr in grdviewGraduation.Rows)
                //{
                //    if (dr.Cells[0].Value != null)
                //    {
                //        if ((bool)dr.Cells[0].Value == true)
                //        {
                //            int row = dr.Cells[0].RowIndex;
                //            graduation = graduation.Append(grdviewGraduation.Rows[row].Cells["GradId"].Value.ToString()).ToArray();
                //        }
                //    }
                //}
                //UG = string.Join(",", graduation);
                //copy.graduation =UG;



                //string[] pg = { };
                //string postgraduate = "";
                //foreach (DataGridViewRow dr in grdviewGraduation.Rows)
                //{
                //    if (dr.Cells[0].Value != null)
                //    {
                //        if ((bool)dr.Cells[0].Value == true)
                //        {
                //            int row = dr.Cells[0].RowIndex;
                //            pg = pg.Append(grdViewPG.Rows[row].Cells["PGId"].Value.ToString()).ToArray();
                //        }
                //    }
                //}
                //postgraduate = string.Join(",", pg);
                //copy.pg = postgraduate;

               





                string gender = "";
                if (rdbtnFemale.Checked)
                {
                    gender = rdbtnFemale.Text;
                }
                else if (rdbtnMale.Checked)
                {
                    gender = rdbtnMale.Text;
                }
                else
                {
                    gender = rdbtnOther.Text;
                }

                if (rdbtnEmployed.Checked)
                {
                    copy.StudProfessionalStatus = rdbtnEmployed.Text;
                }
                else if (rdbtnnonemployed.Checked)
                {
                    copy.StudProfessionalStatus = rdbtnnonemployed.Text;

                }
                else
                {
                    copy.StudProfessionalStatus = rdbtnStudent.Text;

                }

                //frmEdit.instance.ls=listView1;

                copy.StudCode = studcode;
                copy.StudFullName = StudFullName;
                copy.StudContactNo = txtmobileno.Text;
                copy.StudContactNo = txtmobileno.Text;
                copy.StudAlternateNo = txtaltermobileno.Text;



                if (cmbbxCity.Text != "")
                {
                    copy.CityId = Convert.ToInt32(cmbbxCity.SelectedValue.ToString());

                }
                //copy.GradId = Convert.ToInt32(cmbbxGraduation.SelectedValue.ToString());
                //copy.PGId= Convert.ToInt32(cmbbxPG.SelectedValue.ToString());
                copy.enquiryid = Convert.ToInt32(cmbbxEnquirySource.SelectedValue.ToString());
                copy.StudPermanentAddress = rtxtpermanentaddress.Text;
                copy.LocalAddress = rtxtpresentaddress.Text;
                copy.StudPinNo = txtPin.Text;
                copy.StudGender = gender;
                copy.StudEmail = txtemail.Text;



                if (chkbxMorning.Checked)
                {
                    copy.StudTimepreffered = chkbxMorning.Text;

                }
                else if (chkbxEvening.Checked)
                {
                    copy.StudTimepreffered = chkbxEvening.Text;

                }
                else if (chkbxAfternoon.Checked)
                {
                    copy.StudTimepreffered = chkbxAfternoon.Text;

                }

                copy.StudOtherQualification = txtOther.Text;

                if (chkbxFriend.Checked)
                {
                    copy.StudReferences = chkbxFriend.Text;

                }
                else if (chkbxPoster.Checked)
                {
                    copy.StudReferences = chkbxPoster.Text;

                }
                else if (chkbxSeminar.Checked)
                {
                    copy.StudReferences = chkbxSeminar.Text;

                }
                else
                {
                    copy.StudReferences = chkbxOther.Text;

                }
                int Count = listView1.Items.Count;
                string[] Gradid = { };
              
                string[] pgid = { };
                for (int i = 0; i < Count; i++)
                {
                    Gradid = Gradid.Append(listView1.Items[i].SubItems[0].Text).ToArray();
                    pgid = pgid.Append(listView1.Items[i].SubItems[2].Text).ToArray();

                }
                copy.graduation = string.Join(",", Gradid);
                copy.pg = string.Join(",", pgid);
                clsConsular cl = new clsConsular(copy);
                cl.Saved();

                MessageBox.Show("Saved Successfully");

            }
            else
            {
                MessageBox.Show("required all details");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            frmGridBox f1 = new frmGridBox();
            f1.Show();

        }
        private void txtfirstname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtfirstname.Text))
            {
                errorprovider.SetError(txtfirstname, " First name must required");
                firstname = false;
            }
            else
            {
                errorprovider.SetError(txtfirstname, string.Empty);
                firstname = true;

            }
        }
        private void txtmiddlename_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtmiddlename.Text))
            {
                errorprovider.SetError(txtmiddlename, " First name must required");
                middlename = false;
            }
            else
            {
                errorprovider.SetError(txtmiddlename, string.Empty);
                middlename = true;

            }
        }
        private void txtlastname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtlastname.Text))
            {
                errorprovider.SetError(txtlastname, "Present Address must be required");
                lastname = false;
            }
            else
            {
                errorprovider.SetError(txtlastname, string.Empty);
                lastname = true;

            }

        }

        private void rtxtpresentaddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtpresentaddress.Text))
            {
                errorprovider.SetError(rtxtpresentaddress, "Present Address must be required");
                presentaddr = false;
            }
            else
            {
                errorprovider.SetError(rtxtpresentaddress, string.Empty);
                presentaddr = true;

            }
        }

        //private void txtfullname_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtlastname.Text))
        //    {
        //        errorprovider.SetError(txtlastname, "Present Address must be required");
        //        fullname = false;
        //    }
        //    else
        //    {
        //        errorprovider.SetError(txtlastname, string.Empty);
        //        fullname = true;

        //    }
        //}

        private void txtmobileno_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtmobileno.Text))
            {
                errorprovider.SetError(txtmobileno, "Present Address must be required");
                mobileno = false;
            }
            else
            {
                errorprovider.SetError(txtmobileno, string.Empty);
                mobileno = true;

            }
        }

        private void txtaltermobileno_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtaltermobileno.Text))
            {
                errorprovider.SetError(txtaltermobileno, "Present Address must be required");
                altermobileno = false;
            }
            else
            {
                errorprovider.SetError(txtaltermobileno, string.Empty);
                altermobileno = true;

            }
        }

        private void txtemail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtemail.Text))
            {
                errorprovider.SetError(txtemail, "Present Address must be required");
                email = false;
            }
            else
            {
                if (txtemail.Text.Contains("@") && txtemail.Text.Contains("."))
                {
                    email = true;
                }
                else
                {
                    errorprovider.SetError(txtemail, "email is not valid");
                    email = true;
                }
            }

        }

        private void rtxtpresentaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtxtpermanentaddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtpermanentaddress.Text))
            {
                errorprovider.SetError(rtxtpermanentaddress, "Present Address must be required");
                permanentaddress = false;
            }
            else
            {
                errorprovider.SetError(rtxtpermanentaddress, string.Empty);
                permanentaddress = true;

            }
        }

        private void txtPin_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPin.Text))
            {
                errorprovider.SetError(txtPin, "Present Address must be required");
                pin = false;
            }
            else
            {
                errorprovider.SetError(txtPin, string.Empty);
                pin = true;

            }

        }


        private void txtmobileno_KeyPress(object sender, KeyPressEventArgs e)
        {
          
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; 
                }
            

        }

        private void txtaltermobileno_KeyPress(object sender, KeyPressEventArgs e)
        {
          
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; 
                }
            }

        private void txtPin_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; 
                }
            

        }

        private void txtOther_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOther.Text))
            {
                errorprovider.SetError(txtOther, "Present Address must be required");
                other = false;
            }
            else
            {
                errorprovider.SetError(txtOther, string.Empty);
                other = true;

            }
        }

       

        private void txtfirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
           {
               e.Handled = true; 
           }
        }

        private void txtmiddlename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
               e.Handled = true; 
            }
        }

        private void txtlastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }

        private void grdViewPG_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void rtxtpermanentaddress_TextChanged(object sender, EventArgs e)
        {

            if (chkbx1.Checked)
            {
                rtxtpermanentaddress.Text = rtxtpresentaddress.Text;
            }
            else
            {

            }
            //bool delayedConfirmationResult = await DelayedConfirmation();

            //if (string.IsNullOrEmpty(errorprovider.GetError(rtxtpermanentaddress)) && delayedConfirmationResult)
            //{
            //    DialogResult immediateResult = MessageBox.Show("The present address is same as Permenent address?", "Confirmation",
            //        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //    if (immediateResult == DialogResult.OK)
            //    {
            //        rtxtpresentaddress.Text = rtxtpermanentaddress.Text;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Address Should be required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        //private async Task<bool> DelayedConfirmation()
        //{
           
        //    await Task.Delay(100);

            
        //    return true;
        //}

       


        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {

        }

        //private void cmbbxGraduation_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    clsConsular p6 = new clsConsular();
        //    int GradId = Convert.ToInt32(cmbbxGraduation.SelectedValue);
        //    p6.GradId =GradId;
        //    dt = p6.GetPG();
        //   cmbbxPG.DisplayMember = "PGName";
        //    cmbbxPG.ValueMember = "PGId";
        //   cmbbxPG.DataSource = dt;
        //}

        private void btnClick_Click(object sender, EventArgs e)
        {
                String Graduationid = cmbbxGraduation.SelectedValue.ToString();
                String PGid = cmbbxPG.SelectedValue.ToString();
                string grad = cmbbxGraduation.Text;
                string pg=cmbbxPG.Text; 

                ListViewItem newItem = new ListViewItem(grad);
                newItem.SubItems.Add(pg);   
                newItem.SubItems.Add(Graduationid);
                newItem.SubItems.Add(PGid);
                listView1.Items.Add(newItem);

    
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

            clsConsular obj = new clsConsular();
            obj.StudEmail = txtemail.Text;
            SqlDataReader dr;
            dr = obj.Same1();

            while (dr.Read())
            {

            }
            int count = dt.Rows.Count;

            if (count > 0)
            {
                MessageBox.Show("StudEmail " + txtemail.Text + " already exists");

                emailexistOk = false;
            }
            else
            {
                emailexistOk = true;

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chubs1_CheckedChanged(object sender, EventArgs e)
        {
           


        }

        private void cmbbxGraduation_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsConsular copy = new clsConsular();
            copy.GradId = Convert.ToInt32(cmbbxGraduation.SelectedValue);
            clsConsular p5 = new clsConsular(copy);
            DataTable dt2 = new DataTable();
            dt2 = p5.GetPG();
            cmbbxPG.DisplayMember = "PGName";
            cmbbxPG.ValueMember = "PGId";
            cmbbxPG.DataSource = dt2;
            cmbbxPG.Text = PGid;
        }

        private void cmbbxPG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}