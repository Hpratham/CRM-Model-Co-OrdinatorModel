using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM1
{
    public partial class frmGridBox : Form
    {
        public frmGridBox()
        {
            InitializeComponent();
        }

        private void frmGridBox_Load(object sender, EventArgs e)
        {
            clsConsular cl= new clsConsular();
            DataTable data1 = new DataTable();
            data1= cl.GridBox();
           
            dataGridView1.DataSource = data1;
            dataGridView1.Columns["StudGender"].Visible = true;
            dataGridView1.Columns["StudLocalAddress"].Visible = true;
            dataGridView1.Columns["StudPermanentAddress"].Visible = true;
            dataGridView1.Columns["StudCityId"].Visible = false;
            dataGridView1.Columns["StudPinNo"].Visible = false;
            dataGridView1.Columns["StudEnquiryDate"].Visible = false;
            dataGridView1.Columns["GradId"].Visible = false;
            dataGridView1.Columns["PGId"].Visible = false;
            dataGridView1.Columns["StudOtherQualification"].Visible = false;
            dataGridView1.Columns["StudReferences"].Visible = false;
            dataGridView1.Columns["EnquirySourceId"].Visible = false;
            dataGridView1.Columns["CourseId"].Visible = false;
            dataGridView1.Columns["CourseTypeId"].Visible = false;
            dataGridView1.Columns["StudTimePreferred"].Visible = false;
            dataGridView1.Columns["StudRegistrationDate"].Visible = false;
            dataGridView1.Columns["StudPreviousExperience"].Visible = false;
            dataGridView1.Columns["StudCompanyName"].Visible = false;
            dataGridView1.Columns["StudDesignation"].Visible = false;
            dataGridView1.Columns["StudPeriod"].Visible = false;
            dataGridView1.Columns["StudDOB"].Visible = false;
            dataGridView1.Columns["StudFatherName"].Visible = false;
            dataGridView1.Columns["StudMotherName"].Visible = false;
            dataGridView1.Columns["StudFatherContactNo"].Visible = false;
            dataGridView1.Columns["StudMotherContactNo"].Visible = false;
            dataGridView1.Columns["StudCollageName"].Visible = false;
            dataGridView1.Columns["StatusId"].Visible = false;
            dataGridView1.Columns["StudRegistrationFees"].Visible = false;
            dataGridView1.Columns["StudNumberOFInstallments"].Visible = false;
            dataGridView1.Columns["StudPaymentMethod"].Visible = false;
            dataGridView1.Columns["StudTransactionId"].Visible = false;
            dataGridView1.Columns["StudRaiseDiscount"].Visible = false;
            dataGridView1.Columns["EnquiryComment"].Visible = false;
            dataGridView1.Columns["StudPhotoFile"].Visible = false;
            dataGridView1.Columns["StudAdharCardFile"].Visible = false;
            dataGridView1.Columns["StudPanCardFile"].Visible = false;
            dataGridView1.Columns["StudUnderGraduationFile"].Visible = false;
            dataGridView1.Columns["StudGraduationFile"].Visible = false;
            dataGridView1.Columns["StudPGFile"].Visible = false;
            dataGridView1.Columns["CenterId"].Visible = false;
            dataGridView1.Columns["EnquiryStaffName"].Visible = false;
            dataGridView1.Columns["IsDelete"].Visible = false;
            dataGridView1.Columns["StudentToalFees"].Visible = false;
            dataGridView1.Columns["EnqueryType"].Visible = false;
            dataGridView1.Columns["CountryId"].Visible = false;
            dataGridView1.Columns["StateId"].Visible = false;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            string StudCode = dataGridView1.Rows[row].Cells["StudCode"].Value.ToString();
            string StudFullName = dataGridView1.Rows[row].Cells["StudFullName"].Value.ToString();
            string StudContactNo = dataGridView1.Rows[row].Cells["StudContactNo"].Value.ToString();
            string StudAlternateNo = dataGridView1.Rows[row].Cells["StudAlternateNo"].Value.ToString();
            string StudEmail = dataGridView1.Rows[row].Cells["StudEmail"].Value.ToString();
            string StudGender = dataGridView1.Rows[row].Cells["StudGender"].Value.ToString();
            string StudLocalAddress = dataGridView1.Rows[row].Cells["StudLocalAddress"].Value.ToString();
            string StudPermanentAddress = dataGridView1.Rows[row].Cells["StudPermanentAddress"].Value.ToString();
            string StudCityId = dataGridView1.Rows[row].Cells["StudCityId"].Value.ToString();
            string StudPinNo= dataGridView1.Rows[row].Cells["StudPinNo"].Value.ToString();
            string StudEnquiryDate = dataGridView1.Rows[row].Cells["StudEnquiryDate"].Value.ToString();
            string GradId = dataGridView1.Rows[row].Cells["GradId"].Value.ToString();
            string PGId = dataGridView1.Rows[row].Cells["PGId"].Value.ToString();
            string StudOtherQualification = dataGridView1.Rows[row].Cells["StudOtherQualification"].Value.ToString();
            string StudProfessionalStatus = dataGridView1.Rows[row].Cells["StudProfessionalStatus"].Value.ToString();
            string StudReferences = dataGridView1.Rows[row].Cells["StudReferences"].Value.ToString();
            string EnquirySourceId = dataGridView1.Rows[row].Cells["EnquirySourceId"].Value.ToString();
            string CourseId = dataGridView1.Rows[row].Cells["CourseId"].Value.ToString();
            string CourseTypeId = dataGridView1.Rows[row].Cells["CourseTypeId"].Value.ToString();
            string StudTimePreferred = dataGridView1.Rows[row].Cells["StudTimePreferred"].Value.ToString();
            string StudRegistrationDate = dataGridView1.Rows[row].Cells["StudRegistrationDate"].Value.ToString();
            string StudPreviousExperience = dataGridView1.Rows[row].Cells["StudPreviousExperience"].Value.ToString();
            string StudCompanyName = dataGridView1.Rows[row].Cells["StudCompanyName"].Value.ToString();
            string StudDesignation = dataGridView1.Rows[row].Cells["StudDesignation"].Value.ToString();
            string StudPeriod = dataGridView1.Rows[row].Cells["StudPeriod"].Value.ToString();
            string StudDOB = dataGridView1.Rows[row].Cells["StudDOB"].Value.ToString();
            string StudFatherName = dataGridView1.Rows[row].Cells["StudFatherName"].Value.ToString();
            string StudMotherName = dataGridView1.Rows[row].Cells["StudMotherName"].Value.ToString();
            string StudFatherContactNo = dataGridView1.Rows[row].Cells["StudFatherContactNo"].Value.ToString();
            string StudMotherContactNo = dataGridView1.Rows[row].Cells["StudMotherContactNo"].Value.ToString();
            string StudCollageName = dataGridView1.Rows[row].Cells["StudCollageName"].Value.ToString();
            string StatusId = dataGridView1.Rows[row].Cells["StatusId"].Value.ToString();
            string StudRegistrationFees= dataGridView1.Rows[row].Cells["StudRegistrationFees"].Value.ToString();
            string StudNumberOfInstallments= dataGridView1.Rows[row].Cells["StudNumberOFInstallments"].Value.ToString();
            string StudPaymetnMethod = dataGridView1.Rows[row].Cells["StudPaymentMethod"].Value.ToString();
            string StudTransactionId = dataGridView1.Rows[row].Cells["StudTransactionId"].Value.ToString();
            string StudRaiseDiscount = dataGridView1.Rows[row].Cells["StudRaiseDiscount"].Value.ToString();
            string EnquiryComment = dataGridView1.Rows[row].Cells["EnquiryComment"].Value.ToString();
            string StudPhotoFile = dataGridView1.Rows[row].Cells["StudPhotoFile"].Value.ToString();
            string StudAdharCardFile = dataGridView1.Rows[row].Cells["StudAdharCardFile"].Value.ToString();
            string StudPanCardFile = dataGridView1.Rows[row].Cells["StudPanCardFile"].Value.ToString();
            string StudUnderGraduationFile = dataGridView1.Rows[row].Cells["StudUnderGraduationFile"].Value.ToString();
            string StudGraduationFile = dataGridView1.Rows[row].Cells["StudGraduationFile"].Value.ToString();
            string StudPGFile = dataGridView1.Rows[row].Cells["StudPGFile"].Value.ToString();
            string CenterId = dataGridView1.Rows[row].Cells["CenterId"].Value.ToString();
            string EnquiryStaffName = dataGridView1.Rows[row].Cells["EnquiryStaffName"].Value.ToString();
            string IsDelete = dataGridView1.Rows[row].Cells["IsDelete"].Value.ToString();
            string StudentToalFees = dataGridView1.Rows[row].Cells["StudentToalFees"].Value.ToString();
            string EnqueryType = dataGridView1.Rows[row].Cells["EnqueryType"].Value.ToString();
            string CountryId = dataGridView1.Rows[row].Cells["CountryId"].Value.ToString();
            string StateId = dataGridView1.Rows[row].Cells["StateId"].Value.ToString();

            if (dataGridView1.CurrentCell.ColumnIndex == btnEdit.Index)
            {


                frmEdit jk = new frmEdit(StudCode);

                jk.Show();
            }
        }
    }
}
