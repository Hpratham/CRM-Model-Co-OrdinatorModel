namespace CRM1
{
    partial class frmEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblStudFullName = new System.Windows.Forms.Label();
            this.lblStudMobileNo = new System.Windows.Forms.Label();
            this.lblStudAlternateMobileNo = new System.Windows.Forms.Label();
            this.lblStudEmailId = new System.Windows.Forms.Label();
            this.lblStudGender = new System.Windows.Forms.Label();
            this.lblPermenantAddress = new System.Windows.Forms.Label();
            this.lblPresentAddress = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblGraduation = new System.Windows.Forms.Label();
            this.lblPG = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblTimePrefered = new System.Windows.Forms.Label();
            this.lblEnquirySource = new System.Windows.Forms.Label();
            this.lblfullname = new System.Windows.Forms.Label();
            this.txtmobileno = new System.Windows.Forms.TextBox();
            this.txtAlternateno = new System.Windows.Forms.TextBox();
            this.txtemailid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbtnOther1 = new System.Windows.Forms.RadioButton();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.rtxtpresentaddress = new System.Windows.Forms.RichTextBox();
            this.rtxtpermenantaddress = new System.Windows.Forms.RichTextBox();
            this.cmbbxCountry = new System.Windows.Forms.ComboBox();
            this.cmbbxCity = new System.Windows.Forms.ComboBox();
            this.cmbbxState = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.chkbxSeminar = new System.Windows.Forms.CheckBox();
            this.chkbxfriendreference = new System.Windows.Forms.CheckBox();
            this.chkbxPoster = new System.Windows.Forms.CheckBox();
            this.chkbxOther = new System.Windows.Forms.CheckBox();
            this.rdbtnStudent = new System.Windows.Forms.RadioButton();
            this.rdbtnEmployed = new System.Windows.Forms.RadioButton();
            this.rdbtnnonEmployed = new System.Windows.Forms.RadioButton();
            this.chkbxMorning = new System.Windows.Forms.CheckBox();
            this.chkbxAfternoon = new System.Windows.Forms.CheckBox();
            this.chkbxWeekend = new System.Windows.Forms.CheckBox();
            this.chkbxEvenning = new System.Windows.Forms.CheckBox();
            this.cmbbxEnquirySource = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.grdCourse1 = new System.Windows.Forms.DataGridView();
            this.clmCourse = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbbxgrad = new System.Windows.Forms.ComboBox();
            this.cmbbxpg = new System.Windows.Forms.ComboBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.GraduationName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PGName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GradId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PgId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCourse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudFullName
            // 
            this.lblStudFullName.AutoSize = true;
            this.lblStudFullName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudFullName.Location = new System.Drawing.Point(14, 98);
            this.lblStudFullName.Name = "lblStudFullName";
            this.lblStudFullName.Size = new System.Drawing.Size(109, 25);
            this.lblStudFullName.TabIndex = 1;
            this.lblStudFullName.Text = "FullName";
            this.lblStudFullName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblStudMobileNo
            // 
            this.lblStudMobileNo.AutoSize = true;
            this.lblStudMobileNo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudMobileNo.Location = new System.Drawing.Point(13, 149);
            this.lblStudMobileNo.Name = "lblStudMobileNo";
            this.lblStudMobileNo.Size = new System.Drawing.Size(110, 25);
            this.lblStudMobileNo.TabIndex = 2;
            this.lblStudMobileNo.Text = "MobileNo";
            // 
            // lblStudAlternateMobileNo
            // 
            this.lblStudAlternateMobileNo.AutoSize = true;
            this.lblStudAlternateMobileNo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudAlternateMobileNo.Location = new System.Drawing.Point(13, 219);
            this.lblStudAlternateMobileNo.Name = "lblStudAlternateMobileNo";
            this.lblStudAlternateMobileNo.Size = new System.Drawing.Size(135, 25);
            this.lblStudAlternateMobileNo.TabIndex = 3;
            this.lblStudAlternateMobileNo.Text = "AlternateNo";
            // 
            // lblStudEmailId
            // 
            this.lblStudEmailId.AutoSize = true;
            this.lblStudEmailId.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudEmailId.Location = new System.Drawing.Point(33, 287);
            this.lblStudEmailId.Name = "lblStudEmailId";
            this.lblStudEmailId.Size = new System.Drawing.Size(90, 25);
            this.lblStudEmailId.TabIndex = 4;
            this.lblStudEmailId.Text = "EmailId";
            // 
            // lblStudGender
            // 
            this.lblStudGender.AutoSize = true;
            this.lblStudGender.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudGender.Location = new System.Drawing.Point(33, 379);
            this.lblStudGender.Name = "lblStudGender";
            this.lblStudGender.Size = new System.Drawing.Size(88, 25);
            this.lblStudGender.TabIndex = 5;
            this.lblStudGender.Text = "Gender";
            // 
            // lblPermenantAddress
            // 
            this.lblPermenantAddress.AutoSize = true;
            this.lblPermenantAddress.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermenantAddress.Location = new System.Drawing.Point(0, 495);
            this.lblPermenantAddress.Name = "lblPermenantAddress";
            this.lblPermenantAddress.Size = new System.Drawing.Size(170, 25);
            this.lblPermenantAddress.TabIndex = 6;
            this.lblPermenantAddress.Text = "PresentAddress";
            // 
            // lblPresentAddress
            // 
            this.lblPresentAddress.AutoSize = true;
            this.lblPresentAddress.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentAddress.Location = new System.Drawing.Point(0, 597);
            this.lblPresentAddress.Name = "lblPresentAddress";
            this.lblPresentAddress.Size = new System.Drawing.Size(204, 25);
            this.lblPresentAddress.TabIndex = 7;
            this.lblPresentAddress.Text = "PermenentAddress";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(627, 88);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(96, 25);
            this.lblCountry.TabIndex = 8;
            this.lblCountry.Text = "Country";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(637, 144);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(64, 25);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "State";
            this.lblState.Click += new System.EventHandler(this.lblState_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(640, 210);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(53, 25);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(637, 282);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 25);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Date";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.Location = new System.Drawing.Point(648, 352);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(45, 25);
            this.lblPin.TabIndex = 12;
            this.lblPin.Text = "Pin";
            // 
            // lblGraduation
            // 
            this.lblGraduation.AutoSize = true;
            this.lblGraduation.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraduation.Location = new System.Drawing.Point(627, 434);
            this.lblGraduation.Name = "lblGraduation";
            this.lblGraduation.Size = new System.Drawing.Size(128, 25);
            this.lblGraduation.TabIndex = 13;
            this.lblGraduation.Text = "Graduation";
            // 
            // lblPG
            // 
            this.lblPG.AutoSize = true;
            this.lblPG.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPG.Location = new System.Drawing.Point(637, 495);
            this.lblPG.Name = "lblPG";
            this.lblPG.Size = new System.Drawing.Size(45, 25);
            this.lblPG.TabIndex = 14;
            this.lblPG.Text = "PG";
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOther.Location = new System.Drawing.Point(1268, 81);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(72, 25);
            this.lblOther.TabIndex = 15;
            this.lblOther.Text = "Other";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(1276, 154);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 25);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status";
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReference.Location = new System.Drawing.Point(1268, 232);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(115, 25);
            this.lblReference.TabIndex = 18;
            this.lblReference.Text = "Reference";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(1276, 460);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(84, 25);
            this.lblCourse.TabIndex = 19;
            this.lblCourse.Text = "Course";
            // 
            // lblTimePrefered
            // 
            this.lblTimePrefered.AutoSize = true;
            this.lblTimePrefered.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimePrefered.Location = new System.Drawing.Point(1268, 306);
            this.lblTimePrefered.Name = "lblTimePrefered";
            this.lblTimePrefered.Size = new System.Drawing.Size(151, 25);
            this.lblTimePrefered.TabIndex = 20;
            this.lblTimePrefered.Text = "TimePrefered";
            // 
            // lblEnquirySource
            // 
            this.lblEnquirySource.AutoSize = true;
            this.lblEnquirySource.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnquirySource.Location = new System.Drawing.Point(1268, 383);
            this.lblEnquirySource.Name = "lblEnquirySource";
            this.lblEnquirySource.Size = new System.Drawing.Size(162, 25);
            this.lblEnquirySource.TabIndex = 21;
            this.lblEnquirySource.Text = "EnquirySource";
            // 
            // lblfullname
            // 
            this.lblfullname.AutoSize = true;
            this.lblfullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfullname.Location = new System.Drawing.Point(254, 105);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(61, 18);
            this.lblfullname.TabIndex = 23;
            this.lblfullname.Text = "label24";
            // 
            // txtmobileno
            // 
            this.txtmobileno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmobileno.Location = new System.Drawing.Point(198, 143);
            this.txtmobileno.MaxLength = 14;
            this.txtmobileno.Name = "txtmobileno";
            this.txtmobileno.Size = new System.Drawing.Size(366, 30);
            this.txtmobileno.TabIndex = 83;
            this.txtmobileno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobileno_KeyPress);
            this.txtmobileno.Validating += new System.ComponentModel.CancelEventHandler(this.txtmobileno_Validating);
            // 
            // txtAlternateno
            // 
            this.txtAlternateno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlternateno.Location = new System.Drawing.Point(198, 214);
            this.txtAlternateno.MaxLength = 14;
            this.txtAlternateno.Name = "txtAlternateno";
            this.txtAlternateno.Size = new System.Drawing.Size(366, 30);
            this.txtAlternateno.TabIndex = 84;
            this.txtAlternateno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlternateno_KeyPress);
            this.txtAlternateno.Validating += new System.ComponentModel.CancelEventHandler(this.txtAlternateno_Validating);
            // 
            // txtemailid
            // 
            this.txtemailid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailid.Location = new System.Drawing.Point(198, 286);
            this.txtemailid.Name = "txtemailid";
            this.txtemailid.Size = new System.Drawing.Size(366, 30);
            this.txtemailid.TabIndex = 85;
            this.txtemailid.Validating += new System.ComponentModel.CancelEventHandler(this.txtemailid_Validating);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbtnOther1);
            this.panel1.Controls.Add(this.rdbtnFemale);
            this.panel1.Controls.Add(this.rdbtnMale);
            this.panel1.Location = new System.Drawing.Point(198, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 87);
            this.panel1.TabIndex = 113;
            // 
            // rdbtnOther1
            // 
            this.rdbtnOther1.AutoSize = true;
            this.rdbtnOther1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnOther1.Location = new System.Drawing.Point(244, 39);
            this.rdbtnOther1.Name = "rdbtnOther1";
            this.rdbtnOther1.Size = new System.Drawing.Size(87, 29);
            this.rdbtnOther1.TabIndex = 23;
            this.rdbtnOther1.TabStop = true;
            this.rdbtnOther1.Text = "Other";
            this.rdbtnOther1.UseVisualStyleBackColor = true;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnFemale.Location = new System.Drawing.Point(117, 39);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(104, 29);
            this.rdbtnFemale.TabIndex = 22;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnMale.Location = new System.Drawing.Point(18, 39);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(80, 29);
            this.rdbtnMale.TabIndex = 21;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // rtxtpresentaddress
            // 
            this.rtxtpresentaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtpresentaddress.Location = new System.Drawing.Point(198, 474);
            this.rtxtpresentaddress.Name = "rtxtpresentaddress";
            this.rtxtpresentaddress.Size = new System.Drawing.Size(366, 67);
            this.rtxtpresentaddress.TabIndex = 119;
            this.rtxtpresentaddress.Text = "";
            this.rtxtpresentaddress.Validating += new System.ComponentModel.CancelEventHandler(this.rtxtpresentaddress_Validating);
            // 
            // rtxtpermenantaddress
            // 
            this.rtxtpermenantaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtpermenantaddress.Location = new System.Drawing.Point(198, 581);
            this.rtxtpermenantaddress.Name = "rtxtpermenantaddress";
            this.rtxtpermenantaddress.Size = new System.Drawing.Size(366, 60);
            this.rtxtpermenantaddress.TabIndex = 120;
            this.rtxtpermenantaddress.Text = "";
            this.rtxtpermenantaddress.Validating += new System.ComponentModel.CancelEventHandler(this.rtxtpermenantaddress_Validating);
            // 
            // cmbbxCountry
            // 
            this.cmbbxCountry.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCountry.FormattingEnabled = true;
            this.cmbbxCountry.Location = new System.Drawing.Point(781, 82);
            this.cmbbxCountry.Name = "cmbbxCountry";
            this.cmbbxCountry.Size = new System.Drawing.Size(376, 31);
            this.cmbbxCountry.TabIndex = 121;
            this.cmbbxCountry.SelectedIndexChanged += new System.EventHandler(this.cmbbxCountry_SelectedIndexChanged);
            // 
            // cmbbxCity
            // 
            this.cmbbxCity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCity.FormattingEnabled = true;
            this.cmbbxCity.Location = new System.Drawing.Point(781, 204);
            this.cmbbxCity.Name = "cmbbxCity";
            this.cmbbxCity.Size = new System.Drawing.Size(376, 31);
            this.cmbbxCity.TabIndex = 122;
            // 
            // cmbbxState
            // 
            this.cmbbxState.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxState.FormattingEnabled = true;
            this.cmbbxState.Location = new System.Drawing.Point(781, 143);
            this.cmbbxState.Name = "cmbbxState";
            this.cmbbxState.Size = new System.Drawing.Size(376, 31);
            this.cmbbxState.TabIndex = 122;
            this.cmbbxState.SelectedIndexChanged += new System.EventHandler(this.cmbbxState_SelectedIndexChanged);
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Location = new System.Drawing.Point(781, 277);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(376, 30);
            this.dtp.TabIndex = 123;
            // 
            // txtOther
            // 
            this.txtOther.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOther.Location = new System.Drawing.Point(1417, 76);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(366, 30);
            this.txtOther.TabIndex = 127;
            this.txtOther.Validating += new System.ComponentModel.CancelEventHandler(this.txtOther_Validating);
            // 
            // chkbxSeminar
            // 
            this.chkbxSeminar.AutoSize = true;
            this.chkbxSeminar.Location = new System.Drawing.Point(1417, 238);
            this.chkbxSeminar.Name = "chkbxSeminar";
            this.chkbxSeminar.Size = new System.Drawing.Size(125, 20);
            this.chkbxSeminar.TabIndex = 129;
            this.chkbxSeminar.Text = "SeminarAttende";
            this.chkbxSeminar.UseVisualStyleBackColor = true;
            // 
            // chkbxfriendreference
            // 
            this.chkbxfriendreference.AutoSize = true;
            this.chkbxfriendreference.Location = new System.Drawing.Point(1558, 237);
            this.chkbxfriendreference.Name = "chkbxfriendreference";
            this.chkbxfriendreference.Size = new System.Drawing.Size(130, 20);
            this.chkbxfriendreference.TabIndex = 130;
            this.chkbxfriendreference.Text = "FriendReference";
            this.chkbxfriendreference.UseVisualStyleBackColor = true;
            // 
            // chkbxPoster
            // 
            this.chkbxPoster.AutoSize = true;
            this.chkbxPoster.Location = new System.Drawing.Point(1762, 238);
            this.chkbxPoster.Name = "chkbxPoster";
            this.chkbxPoster.Size = new System.Drawing.Size(68, 20);
            this.chkbxPoster.TabIndex = 131;
            this.chkbxPoster.Text = "Poster";
            this.chkbxPoster.UseVisualStyleBackColor = true;
            // 
            // chkbxOther
            // 
            this.chkbxOther.AutoSize = true;
            this.chkbxOther.Location = new System.Drawing.Point(1695, 238);
            this.chkbxOther.Name = "chkbxOther";
            this.chkbxOther.Size = new System.Drawing.Size(61, 20);
            this.chkbxOther.TabIndex = 132;
            this.chkbxOther.Text = "Other";
            this.chkbxOther.UseVisualStyleBackColor = true;
            // 
            // rdbtnStudent
            // 
            this.rdbtnStudent.AutoSize = true;
            this.rdbtnStudent.Location = new System.Drawing.Point(1426, 154);
            this.rdbtnStudent.Name = "rdbtnStudent";
            this.rdbtnStudent.Size = new System.Drawing.Size(73, 20);
            this.rdbtnStudent.TabIndex = 136;
            this.rdbtnStudent.TabStop = true;
            this.rdbtnStudent.Text = "Student";
            this.rdbtnStudent.UseVisualStyleBackColor = true;
            // 
            // rdbtnEmployed
            // 
            this.rdbtnEmployed.AutoSize = true;
            this.rdbtnEmployed.Location = new System.Drawing.Point(1558, 154);
            this.rdbtnEmployed.Name = "rdbtnEmployed";
            this.rdbtnEmployed.Size = new System.Drawing.Size(90, 20);
            this.rdbtnEmployed.TabIndex = 137;
            this.rdbtnEmployed.TabStop = true;
            this.rdbtnEmployed.Text = "Employed";
            this.rdbtnEmployed.UseVisualStyleBackColor = true;
            // 
            // rdbtnnonEmployed
            // 
            this.rdbtnnonEmployed.AutoSize = true;
            this.rdbtnnonEmployed.Location = new System.Drawing.Point(1695, 154);
            this.rdbtnnonEmployed.Name = "rdbtnnonEmployed";
            this.rdbtnnonEmployed.Size = new System.Drawing.Size(115, 20);
            this.rdbtnnonEmployed.TabIndex = 138;
            this.rdbtnnonEmployed.TabStop = true;
            this.rdbtnnonEmployed.Text = "NonEmployed";
            this.rdbtnnonEmployed.UseVisualStyleBackColor = true;
            // 
            // chkbxMorning
            // 
            this.chkbxMorning.AutoSize = true;
            this.chkbxMorning.Location = new System.Drawing.Point(1456, 306);
            this.chkbxMorning.Name = "chkbxMorning";
            this.chkbxMorning.Size = new System.Drawing.Size(77, 20);
            this.chkbxMorning.TabIndex = 139;
            this.chkbxMorning.Text = "Morning";
            this.chkbxMorning.UseVisualStyleBackColor = true;
            this.chkbxMorning.CheckedChanged += new System.EventHandler(this.chkbxMorning_CheckedChanged);
            // 
            // chkbxAfternoon
            // 
            this.chkbxAfternoon.AutoSize = true;
            this.chkbxAfternoon.Location = new System.Drawing.Point(1549, 306);
            this.chkbxAfternoon.Name = "chkbxAfternoon";
            this.chkbxAfternoon.Size = new System.Drawing.Size(86, 20);
            this.chkbxAfternoon.TabIndex = 140;
            this.chkbxAfternoon.Text = "Afternoon";
            this.chkbxAfternoon.UseVisualStyleBackColor = true;
            // 
            // chkbxWeekend
            // 
            this.chkbxWeekend.AutoSize = true;
            this.chkbxWeekend.Location = new System.Drawing.Point(1735, 306);
            this.chkbxWeekend.Name = "chkbxWeekend";
            this.chkbxWeekend.Size = new System.Drawing.Size(88, 20);
            this.chkbxWeekend.TabIndex = 141;
            this.chkbxWeekend.Text = "Weekend";
            this.chkbxWeekend.UseVisualStyleBackColor = true;
            // 
            // chkbxEvenning
            // 
            this.chkbxEvenning.AutoSize = true;
            this.chkbxEvenning.Location = new System.Drawing.Point(1651, 306);
            this.chkbxEvenning.Name = "chkbxEvenning";
            this.chkbxEvenning.Size = new System.Drawing.Size(78, 20);
            this.chkbxEvenning.TabIndex = 142;
            this.chkbxEvenning.Text = "Evening";
            this.chkbxEvenning.UseVisualStyleBackColor = true;
            // 
            // cmbbxEnquirySource
            // 
            this.cmbbxEnquirySource.FormattingEnabled = true;
            this.cmbbxEnquirySource.Location = new System.Drawing.Point(1456, 383);
            this.cmbbxEnquirySource.Name = "cmbbxEnquirySource";
            this.cmbbxEnquirySource.Size = new System.Drawing.Size(360, 24);
            this.cmbbxEnquirySource.TabIndex = 143;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1306, 639);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 69);
            this.btnUpdate.TabIndex = 144;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1281, 549);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 73);
            this.btnClear.TabIndex = 145;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtPin
            // 
            this.txtPin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPin.Location = new System.Drawing.Point(781, 347);
            this.txtPin.MaxLength = 8;
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(376, 30);
            this.txtPin.TabIndex = 146;
            this.txtPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPin_KeyPress);
            this.txtPin.Validating += new System.ComponentModel.CancelEventHandler(this.txtPin_Validating);
            // 
            // grdCourse1
            // 
            this.grdCourse1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCourse1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdCourse1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCourse1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCourse});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCourse1.DefaultCellStyle = dataGridViewCellStyle6;
            this.grdCourse1.GridColor = System.Drawing.SystemColors.Control;
            this.grdCourse1.Location = new System.Drawing.Point(1456, 445);
            this.grdCourse1.Name = "grdCourse1";
            this.grdCourse1.RowHeadersWidth = 51;
            this.grdCourse1.RowTemplate.Height = 24;
            this.grdCourse1.Size = new System.Drawing.Size(376, 263);
            this.grdCourse1.TabIndex = 147;
            // 
            // clmCourse
            // 
            this.clmCourse.HeaderText = "Select";
            this.clmCourse.MinimumWidth = 6;
            this.clmCourse.Name = "clmCourse";
            this.clmCourse.Width = 125;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 35);
            this.label2.TabIndex = 149;
            this.label2.Text = "Personal Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(713, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 38);
            this.label3.TabIndex = 150;
            this.label3.Text = "Edit Enquiry";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(884, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 35);
            this.label1.TabIndex = 151;
            this.label1.Text = "Qualification Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(1465, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 35);
            this.label4.TabIndex = 152;
            this.label4.Text = "Other Details";
            // 
            // cmbbxgrad
            // 
            this.cmbbxgrad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxgrad.FormattingEnabled = true;
            this.cmbbxgrad.Location = new System.Drawing.Point(781, 428);
            this.cmbbxgrad.Name = "cmbbxgrad";
            this.cmbbxgrad.Size = new System.Drawing.Size(376, 31);
            this.cmbbxgrad.TabIndex = 153;
            // 
            // cmbbxpg
            // 
            this.cmbbxpg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxpg.FormattingEnabled = true;
            this.cmbbxpg.Location = new System.Drawing.Point(781, 499);
            this.cmbbxpg.Name = "cmbbxpg";
            this.cmbbxpg.Size = new System.Drawing.Size(376, 31);
            this.cmbbxpg.TabIndex = 154;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GraduationName,
            this.PGName,
            this.GradId,
            this.PgId});
            this.listView2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(781, 557);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(376, 140);
            this.listView2.TabIndex = 155;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // GraduationName
            // 
            this.GraduationName.Text = "GraduationName";
            this.GraduationName.Width = 150;
            // 
            // PGName
            // 
            this.PGName.Text = "PGName";
            this.PGName.Width = 150;
            // 
            // GradId
            // 
            this.GradId.Text = "GradId";
            this.GradId.Width = 0;
            // 
            // PgId
            // 
            this.PgId.Text = "PgId";
            this.PgId.Width = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(626, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 156;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 1055);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.cmbbxpg);
            this.Controls.Add(this.cmbbxgrad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdCourse1);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbbxEnquirySource);
            this.Controls.Add(this.chkbxEvenning);
            this.Controls.Add(this.chkbxWeekend);
            this.Controls.Add(this.chkbxAfternoon);
            this.Controls.Add(this.chkbxMorning);
            this.Controls.Add(this.rdbtnnonEmployed);
            this.Controls.Add(this.rdbtnEmployed);
            this.Controls.Add(this.rdbtnStudent);
            this.Controls.Add(this.chkbxOther);
            this.Controls.Add(this.chkbxPoster);
            this.Controls.Add(this.chkbxfriendreference);
            this.Controls.Add(this.chkbxSeminar);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.cmbbxState);
            this.Controls.Add(this.cmbbxCity);
            this.Controls.Add(this.cmbbxCountry);
            this.Controls.Add(this.rtxtpermenantaddress);
            this.Controls.Add(this.rtxtpresentaddress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtemailid);
            this.Controls.Add(this.txtAlternateno);
            this.Controls.Add(this.txtmobileno);
            this.Controls.Add(this.lblfullname);
            this.Controls.Add(this.lblEnquirySource);
            this.Controls.Add(this.lblTimePrefered);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblReference);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.lblPG);
            this.Controls.Add(this.lblGraduation);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblPresentAddress);
            this.Controls.Add(this.lblPermenantAddress);
            this.Controls.Add(this.lblStudGender);
            this.Controls.Add(this.lblStudEmailId);
            this.Controls.Add(this.lblStudAlternateMobileNo);
            this.Controls.Add(this.lblStudMobileNo);
            this.Controls.Add(this.lblStudFullName);
            this.Name = "frmEdit";
            this.Text = "frmEdit";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCourse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStudFullName;
        private System.Windows.Forms.Label lblStudMobileNo;
        private System.Windows.Forms.Label lblStudAlternateMobileNo;
        private System.Windows.Forms.Label lblStudEmailId;
        private System.Windows.Forms.Label lblStudGender;
        private System.Windows.Forms.Label lblPermenantAddress;
        private System.Windows.Forms.Label lblPresentAddress;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Label lblGraduation;
        private System.Windows.Forms.Label lblPG;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblTimePrefered;
        private System.Windows.Forms.Label lblEnquirySource;
        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.TextBox txtmobileno;
        private System.Windows.Forms.TextBox txtAlternateno;
        private System.Windows.Forms.TextBox txtemailid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.RichTextBox rtxtpresentaddress;
        private System.Windows.Forms.RichTextBox rtxtpermenantaddress;
        private System.Windows.Forms.ComboBox cmbbxCountry;
        private System.Windows.Forms.ComboBox cmbbxCity;
        private System.Windows.Forms.ComboBox cmbbxState;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.CheckBox chkbxSeminar;
        private System.Windows.Forms.CheckBox chkbxfriendreference;
        private System.Windows.Forms.CheckBox chkbxPoster;
        private System.Windows.Forms.CheckBox chkbxOther;
        private System.Windows.Forms.RadioButton rdbtnStudent;
        private System.Windows.Forms.RadioButton rdbtnEmployed;
        private System.Windows.Forms.RadioButton rdbtnnonEmployed;
        private System.Windows.Forms.CheckBox chkbxMorning;
        private System.Windows.Forms.CheckBox chkbxAfternoon;
        private System.Windows.Forms.CheckBox chkbxWeekend;
        private System.Windows.Forms.CheckBox chkbxEvenning;
        private System.Windows.Forms.ComboBox cmbbxEnquirySource;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.DataGridView grdCourse1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmCourse;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.RadioButton rdbtnOther1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbbxpg;
        private System.Windows.Forms.ComboBox cmbbxgrad;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader GraduationName;
        private System.Windows.Forms.ColumnHeader PGName;
        private System.Windows.Forms.ColumnHeader GradId;
        private System.Windows.Forms.ColumnHeader PgId;
        private System.Windows.Forms.Button button1;
    }
}