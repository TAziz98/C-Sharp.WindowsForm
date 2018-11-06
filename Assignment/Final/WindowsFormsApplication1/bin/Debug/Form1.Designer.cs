namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblStepHeight = new System.Windows.Forms.Label();
            this.lblStepHeightDisplayValue = new System.Windows.Forms.Label();
            this.TabSelection = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.lblNormValue = new System.Windows.Forms.Label();
            this.lblNorm = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.lblCapacityValue = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.cmbStepHeight = new System.Windows.Forms.ComboBox();
            this.txtEightyFiveOfMaxHR = new System.Windows.Forms.TextBox();
            this.txtMaxHR = new System.Windows.Forms.TextBox();
            this.lblEightyFiveOfMaxHR = new System.Windows.Forms.Label();
            this.lblMaxHR = new System.Windows.Forms.Label();
            this.lblCM = new System.Windows.Forms.Label();
            this.chkLifestyle = new System.Windows.Forms.CheckBox();
            this.chkContraIndications = new System.Windows.Forms.CheckBox();
            this.chkReadinessCheck = new System.Windows.Forms.CheckBox();
            this.lblHR5 = new System.Windows.Forms.Label();
            this.txtHR5 = new System.Windows.Forms.TextBox();
            this.txtHR4 = new System.Windows.Forms.TextBox();
            this.lblHR4 = new System.Windows.Forms.Label();
            this.lblHR3 = new System.Windows.Forms.Label();
            this.lblHR2 = new System.Windows.Forms.Label();
            this.txtHR3 = new System.Windows.Forms.TextBox();
            this.txtHR2 = new System.Windows.Forms.TextBox();
            this.lblHR1 = new System.Windows.Forms.Label();
            this.txtHR1 = new System.Windows.Forms.TextBox();
            this.lblInputAge = new System.Windows.Forms.Label();
            this.txtInputAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInputName = new System.Windows.Forms.Label();
            this.txtInputSurname = new System.Windows.Forms.TextBox();
            this.txtInputName = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabImport = new System.Windows.Forms.TabPage();
            this.lblImportInfo = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.tabBrowse = new System.Windows.Forms.TabPage();
            this.btnSearchCancel = new System.Windows.Forms.Button();
            this.lblSearchSurname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TabSelection.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabImport.SuspendLayout();
            this.tabBrowse.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 151);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1490, 505);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(570, 84);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 44);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(519, 25);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(443, 31);
            this.txtSearch.TabIndex = 3;
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(225, 46);
            this.lblEdit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(0, 25);
            this.lblEdit.TabIndex = 8;
            // 
            // lblStepHeight
            // 
            this.lblStepHeight.AutoSize = true;
            this.lblStepHeight.Location = new System.Drawing.Point(1198, 27);
            this.lblStepHeight.Name = "lblStepHeight";
            this.lblStepHeight.Size = new System.Drawing.Size(124, 25);
            this.lblStepHeight.TabIndex = 9;
            this.lblStepHeight.Text = "Step Height";
            // 
            // lblStepHeightDisplayValue
            // 
            this.lblStepHeightDisplayValue.AutoSize = true;
            this.lblStepHeightDisplayValue.Location = new System.Drawing.Point(229, 21);
            this.lblStepHeightDisplayValue.Name = "lblStepHeightDisplayValue";
            this.lblStepHeightDisplayValue.Size = new System.Drawing.Size(0, 25);
            this.lblStepHeightDisplayValue.TabIndex = 10;
            // 
            // TabSelection
            // 
            this.TabSelection.Controls.Add(this.tabAdd);
            this.TabSelection.Controls.Add(this.tabImport);
            this.TabSelection.Controls.Add(this.tabBrowse);
            this.TabSelection.Location = new System.Drawing.Point(0, 1);
            this.TabSelection.Name = "TabSelection";
            this.TabSelection.SelectedIndex = 0;
            this.TabSelection.Size = new System.Drawing.Size(1506, 749);
            this.TabSelection.TabIndex = 14;
            this.TabSelection.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabSelection_Selecting);
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.SystemColors.Control;
            this.tabAdd.Controls.Add(this.lblNormValue);
            this.tabAdd.Controls.Add(this.lblNorm);
            this.tabAdd.Controls.Add(this.lblSex);
            this.tabAdd.Controls.Add(this.cmbSex);
            this.tabAdd.Controls.Add(this.lblCapacityValue);
            this.tabAdd.Controls.Add(this.lblCapacity);
            this.tabAdd.Controls.Add(this.cmbStepHeight);
            this.tabAdd.Controls.Add(this.txtEightyFiveOfMaxHR);
            this.tabAdd.Controls.Add(this.txtMaxHR);
            this.tabAdd.Controls.Add(this.lblEightyFiveOfMaxHR);
            this.tabAdd.Controls.Add(this.lblMaxHR);
            this.tabAdd.Controls.Add(this.lblCM);
            this.tabAdd.Controls.Add(this.chkLifestyle);
            this.tabAdd.Controls.Add(this.chkContraIndications);
            this.tabAdd.Controls.Add(this.chkReadinessCheck);
            this.tabAdd.Controls.Add(this.lblHR5);
            this.tabAdd.Controls.Add(this.txtHR5);
            this.tabAdd.Controls.Add(this.txtHR4);
            this.tabAdd.Controls.Add(this.lblHR4);
            this.tabAdd.Controls.Add(this.lblHR3);
            this.tabAdd.Controls.Add(this.lblHR2);
            this.tabAdd.Controls.Add(this.txtHR3);
            this.tabAdd.Controls.Add(this.txtHR2);
            this.tabAdd.Controls.Add(this.lblHR1);
            this.tabAdd.Controls.Add(this.txtHR1);
            this.tabAdd.Controls.Add(this.lblInputAge);
            this.tabAdd.Controls.Add(this.txtInputAge);
            this.tabAdd.Controls.Add(this.label1);
            this.tabAdd.Controls.Add(this.lblInputName);
            this.tabAdd.Controls.Add(this.txtInputSurname);
            this.tabAdd.Controls.Add(this.txtInputName);
            this.tabAdd.Controls.Add(this.btnCalculate);
            this.tabAdd.Controls.Add(this.btnAdd);
            this.tabAdd.Controls.Add(this.lblStepHeight);
            this.tabAdd.Controls.Add(this.lblStepHeightDisplayValue);
            this.tabAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabAdd.Location = new System.Drawing.Point(8, 39);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(1490, 702);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Add";
            // 
            // lblNormValue
            // 
            this.lblNormValue.AutoSize = true;
            this.lblNormValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNormValue.Location = new System.Drawing.Point(659, 407);
            this.lblNormValue.Name = "lblNormValue";
            this.lblNormValue.Size = new System.Drawing.Size(0, 31);
            this.lblNormValue.TabIndex = 44;
            // 
            // lblNorm
            // 
            this.lblNorm.AutoSize = true;
            this.lblNorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNorm.Location = new System.Drawing.Point(573, 407);
            this.lblNorm.Name = "lblNorm";
            this.lblNorm.Size = new System.Drawing.Size(80, 31);
            this.lblNorm.TabIndex = 43;
            this.lblNorm.Text = "Norm";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(224, 117);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(49, 25);
            this.lblSex.TabIndex = 42;
            this.lblSex.Text = "Sex";
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSex.Location = new System.Drawing.Point(306, 114);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(62, 33);
            this.cmbSex.TabIndex = 41;
            this.cmbSex.SelectedIndexChanged += new System.EventHandler(this.cmbSex_SelectedIndexChanged);
            // 
            // lblCapacityValue
            // 
            this.lblCapacityValue.AutoSize = true;
            this.lblCapacityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCapacityValue.Location = new System.Drawing.Point(799, 362);
            this.lblCapacityValue.Name = "lblCapacityValue";
            this.lblCapacityValue.Size = new System.Drawing.Size(0, 31);
            this.lblCapacityValue.TabIndex = 40;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCapacity.Location = new System.Drawing.Point(573, 362);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(220, 31);
            this.lblCapacity.TabIndex = 39;
            this.lblCapacity.Text = "Aerobic Capacity";
            // 
            // cmbStepHeight
            // 
            this.cmbStepHeight.FormattingEnabled = true;
            this.cmbStepHeight.Items.AddRange(new object[] {
            "15",
            "20",
            "25",
            "30"});
            this.cmbStepHeight.Location = new System.Drawing.Point(1328, 24);
            this.cmbStepHeight.Name = "cmbStepHeight";
            this.cmbStepHeight.Size = new System.Drawing.Size(86, 33);
            this.cmbStepHeight.TabIndex = 38;
            this.cmbStepHeight.SelectedIndexChanged += new System.EventHandler(this.cmbStepHeight_SelectedIndexChanged);
            // 
            // txtEightyFiveOfMaxHR
            // 
            this.txtEightyFiveOfMaxHR.BackColor = System.Drawing.Color.Silver;
            this.txtEightyFiveOfMaxHR.Location = new System.Drawing.Point(1015, 89);
            this.txtEightyFiveOfMaxHR.Name = "txtEightyFiveOfMaxHR";
            this.txtEightyFiveOfMaxHR.Size = new System.Drawing.Size(100, 31);
            this.txtEightyFiveOfMaxHR.TabIndex = 37;
            // 
            // txtMaxHR
            // 
            this.txtMaxHR.BackColor = System.Drawing.Color.Silver;
            this.txtMaxHR.Location = new System.Drawing.Point(1015, 49);
            this.txtMaxHR.Name = "txtMaxHR";
            this.txtMaxHR.Size = new System.Drawing.Size(100, 31);
            this.txtMaxHR.TabIndex = 36;
            // 
            // lblEightyFiveOfMaxHR
            // 
            this.lblEightyFiveOfMaxHR.AutoSize = true;
            this.lblEightyFiveOfMaxHR.Location = new System.Drawing.Point(877, 92);
            this.lblEightyFiveOfMaxHR.Name = "lblEightyFiveOfMaxHR";
            this.lblEightyFiveOfMaxHR.Size = new System.Drawing.Size(132, 25);
            this.lblEightyFiveOfMaxHR.TabIndex = 35;
            this.lblEightyFiveOfMaxHR.Text = "85% MaxHR";
            // 
            // lblMaxHR
            // 
            this.lblMaxHR.AutoSize = true;
            this.lblMaxHR.Location = new System.Drawing.Point(877, 52);
            this.lblMaxHR.Name = "lblMaxHR";
            this.lblMaxHR.Size = new System.Drawing.Size(83, 25);
            this.lblMaxHR.TabIndex = 34;
            this.lblMaxHR.Text = "MaxHR";
            // 
            // lblCM
            // 
            this.lblCM.AutoSize = true;
            this.lblCM.Location = new System.Drawing.Point(1420, 27);
            this.lblCM.Name = "lblCM";
            this.lblCM.Size = new System.Drawing.Size(52, 25);
            this.lblCM.TabIndex = 33;
            this.lblCM.Text = "[cm]";
            // 
            // chkLifestyle
            // 
            this.chkLifestyle.AutoSize = true;
            this.chkLifestyle.Location = new System.Drawing.Point(458, 116);
            this.chkLifestyle.Name = "chkLifestyle";
            this.chkLifestyle.Size = new System.Drawing.Size(324, 29);
            this.chkLifestyle.TabIndex = 32;
            this.chkLifestyle.Text = "Lifestyle Activity Level Check";
            this.chkLifestyle.UseVisualStyleBackColor = true;
            // 
            // chkContraIndications
            // 
            this.chkContraIndications.AutoSize = true;
            this.chkContraIndications.Location = new System.Drawing.Point(458, 68);
            this.chkContraIndications.Name = "chkContraIndications";
            this.chkContraIndications.Size = new System.Drawing.Size(331, 29);
            this.chkContraIndications.TabIndex = 31;
            this.chkContraIndications.Text = "Contra-Indications to Exercise";
            this.chkContraIndications.UseVisualStyleBackColor = true;
            // 
            // chkReadinessCheck
            // 
            this.chkReadinessCheck.AutoSize = true;
            this.chkReadinessCheck.Location = new System.Drawing.Point(458, 20);
            this.chkReadinessCheck.Name = "chkReadinessCheck";
            this.chkReadinessCheck.Size = new System.Drawing.Size(326, 29);
            this.chkReadinessCheck.TabIndex = 30;
            this.chkReadinessCheck.Text = "Readiness to Exercise Check";
            this.chkReadinessCheck.UseVisualStyleBackColor = true;
            // 
            // lblHR5
            // 
            this.lblHR5.AutoSize = true;
            this.lblHR5.Location = new System.Drawing.Point(1238, 199);
            this.lblHR5.Name = "lblHR5";
            this.lblHR5.Size = new System.Drawing.Size(26, 25);
            this.lblHR5.TabIndex = 29;
            this.lblHR5.Text = "V";
            // 
            // txtHR5
            // 
            this.txtHR5.Location = new System.Drawing.Point(1203, 243);
            this.txtHR5.Name = "txtHR5";
            this.txtHR5.Size = new System.Drawing.Size(100, 31);
            this.txtHR5.TabIndex = 28;
            this.txtHR5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHR4
            // 
            this.txtHR4.Location = new System.Drawing.Point(950, 243);
            this.txtHR4.Name = "txtHR4";
            this.txtHR4.Size = new System.Drawing.Size(100, 31);
            this.txtHR4.TabIndex = 27;
            this.txtHR4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHR4
            // 
            this.lblHR4.AutoSize = true;
            this.lblHR4.Location = new System.Drawing.Point(986, 199);
            this.lblHR4.Name = "lblHR4";
            this.lblHR4.Size = new System.Drawing.Size(31, 25);
            this.lblHR4.TabIndex = 26;
            this.lblHR4.Text = "IV";
            // 
            // lblHR3
            // 
            this.lblHR3.AutoSize = true;
            this.lblHR3.Location = new System.Drawing.Point(734, 199);
            this.lblHR3.Name = "lblHR3";
            this.lblHR3.Size = new System.Drawing.Size(27, 25);
            this.lblHR3.TabIndex = 25;
            this.lblHR3.Text = "III";
            // 
            // lblHR2
            // 
            this.lblHR2.AutoSize = true;
            this.lblHR2.Location = new System.Drawing.Point(473, 199);
            this.lblHR2.Name = "lblHR2";
            this.lblHR2.Size = new System.Drawing.Size(22, 25);
            this.lblHR2.TabIndex = 24;
            this.lblHR2.Text = "II";
            // 
            // txtHR3
            // 
            this.txtHR3.Location = new System.Drawing.Point(693, 243);
            this.txtHR3.Name = "txtHR3";
            this.txtHR3.Size = new System.Drawing.Size(100, 31);
            this.txtHR3.TabIndex = 23;
            this.txtHR3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHR2
            // 
            this.txtHR2.Location = new System.Drawing.Point(434, 243);
            this.txtHR2.Name = "txtHR2";
            this.txtHR2.Size = new System.Drawing.Size(100, 31);
            this.txtHR2.TabIndex = 22;
            this.txtHR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHR1
            // 
            this.lblHR1.AutoSize = true;
            this.lblHR1.Location = new System.Drawing.Point(212, 199);
            this.lblHR1.Name = "lblHR1";
            this.lblHR1.Size = new System.Drawing.Size(17, 25);
            this.lblHR1.TabIndex = 21;
            this.lblHR1.Text = "I";
            // 
            // txtHR1
            // 
            this.txtHR1.Location = new System.Drawing.Point(173, 243);
            this.txtHR1.Name = "txtHR1";
            this.txtHR1.Size = new System.Drawing.Size(100, 31);
            this.txtHR1.TabIndex = 20;
            this.txtHR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInputAge
            // 
            this.lblInputAge.AutoSize = true;
            this.lblInputAge.Location = new System.Drawing.Point(18, 117);
            this.lblInputAge.Name = "lblInputAge";
            this.lblInputAge.Size = new System.Drawing.Size(50, 25);
            this.lblInputAge.TabIndex = 19;
            this.lblInputAge.Text = "Age";
            // 
            // txtInputAge
            // 
            this.txtInputAge.Location = new System.Drawing.Point(122, 114);
            this.txtInputAge.Name = "txtInputAge";
            this.txtInputAge.Size = new System.Drawing.Size(60, 31);
            this.txtInputAge.TabIndex = 18;
            this.txtInputAge.TextChanged += new System.EventHandler(this.txtInputAge_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Surname";
            // 
            // lblInputName
            // 
            this.lblInputName.AutoSize = true;
            this.lblInputName.Location = new System.Drawing.Point(18, 21);
            this.lblInputName.Name = "lblInputName";
            this.lblInputName.Size = new System.Drawing.Size(68, 25);
            this.lblInputName.TabIndex = 16;
            this.lblInputName.Text = "Name";
            // 
            // txtInputSurname
            // 
            this.txtInputSurname.Location = new System.Drawing.Point(122, 66);
            this.txtInputSurname.Name = "txtInputSurname";
            this.txtInputSurname.Size = new System.Drawing.Size(246, 31);
            this.txtInputSurname.TabIndex = 15;
            // 
            // txtInputName
            // 
            this.txtInputName.Location = new System.Drawing.Point(122, 18);
            this.txtInputName.Name = "txtInputName";
            this.txtInputName.Size = new System.Drawing.Size(246, 31);
            this.txtInputName.TabIndex = 14;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(518, 524);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(215, 79);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(739, 524);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(215, 79);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add To Database";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabImport
            // 
            this.tabImport.BackColor = System.Drawing.SystemColors.Control;
            this.tabImport.Controls.Add(this.lblImportInfo);
            this.tabImport.Controls.Add(this.btnImport);
            this.tabImport.Controls.Add(this.listBoxNames);
            this.tabImport.Location = new System.Drawing.Point(8, 39);
            this.tabImport.Name = "tabImport";
            this.tabImport.Padding = new System.Windows.Forms.Padding(3);
            this.tabImport.Size = new System.Drawing.Size(1490, 702);
            this.tabImport.TabIndex = 2;
            this.tabImport.Text = "Import";
            // 
            // lblImportInfo
            // 
            this.lblImportInfo.AutoSize = true;
            this.lblImportInfo.Location = new System.Drawing.Point(103, 25);
            this.lblImportInfo.Name = "lblImportInfo";
            this.lblImportInfo.Size = new System.Drawing.Size(422, 25);
            this.lblImportInfo.TabIndex = 24;
            this.lblImportInfo.Text = "Click on a participant to proceed to the test";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(964, 269);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(215, 79);
            this.btnImport.TabIndex = 23;
            this.btnImport.Text = "Import File";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // listBoxNames
            // 
            this.listBoxNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.ItemHeight = 37;
            this.listBoxNames.Location = new System.Drawing.Point(31, 64);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(573, 559);
            this.listBoxNames.TabIndex = 21;
            this.listBoxNames.SelectedIndexChanged += new System.EventHandler(this.ListBoxNames_SelectedIndexChanged);
            // 
            // tabBrowse
            // 
            this.tabBrowse.BackColor = System.Drawing.SystemColors.Control;
            this.tabBrowse.Controls.Add(this.btnSearchCancel);
            this.tabBrowse.Controls.Add(this.lblSearchSurname);
            this.tabBrowse.Controls.Add(this.btnSearch);
            this.tabBrowse.Controls.Add(this.dataGridView1);
            this.tabBrowse.Controls.Add(this.txtSearch);
            this.tabBrowse.Controls.Add(this.lblEdit);
            this.tabBrowse.Location = new System.Drawing.Point(8, 39);
            this.tabBrowse.Name = "tabBrowse";
            this.tabBrowse.Padding = new System.Windows.Forms.Padding(3);
            this.tabBrowse.Size = new System.Drawing.Size(1490, 702);
            this.tabBrowse.TabIndex = 1;
            this.tabBrowse.Text = "Browse";
            // 
            // btnSearchCancel
            // 
            this.btnSearchCancel.Location = new System.Drawing.Point(750, 84);
            this.btnSearchCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearchCancel.Name = "btnSearchCancel";
            this.btnSearchCancel.Size = new System.Drawing.Size(150, 44);
            this.btnSearchCancel.TabIndex = 10;
            this.btnSearchCancel.Text = "Cancel";
            this.btnSearchCancel.UseVisualStyleBackColor = true;
            this.btnSearchCancel.Click += new System.EventHandler(this.btnSearchCancel_Click);
            // 
            // lblSearchSurname
            // 
            this.lblSearchSurname.AutoSize = true;
            this.lblSearchSurname.Location = new System.Drawing.Point(412, 28);
            this.lblSearchSurname.Name = "lblSearchSurname";
            this.lblSearchSurname.Size = new System.Drawing.Size(98, 25);
            this.lblSearchSurname.TabIndex = 9;
            this.lblSearchSurname.Text = "Surname";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 744);
            this.Controls.Add(this.TabSelection);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TabSelection.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabImport.ResumeLayout(false);
            this.tabImport.PerformLayout();
            this.tabBrowse.ResumeLayout(false);
            this.tabBrowse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblStepHeight;
        private System.Windows.Forms.Label lblStepHeightDisplayValue;
        private System.Windows.Forms.TabControl TabSelection;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabBrowse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblInputName;
        private System.Windows.Forms.TextBox txtInputSurname;
        private System.Windows.Forms.TextBox txtInputName;
        private System.Windows.Forms.Label lblInputAge;
        private System.Windows.Forms.TextBox txtInputAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabImport;
        private System.Windows.Forms.ListBox listBoxNames;
        private System.Windows.Forms.TextBox txtHR4;
        private System.Windows.Forms.Label lblHR4;
        private System.Windows.Forms.Label lblHR3;
        private System.Windows.Forms.Label lblHR2;
        private System.Windows.Forms.TextBox txtHR3;
        private System.Windows.Forms.TextBox txtHR2;
        private System.Windows.Forms.Label lblHR1;
        private System.Windows.Forms.TextBox txtHR1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblHR5;
        private System.Windows.Forms.TextBox txtHR5;
        private System.Windows.Forms.Label lblImportInfo;
        private System.Windows.Forms.Label lblCM;
        private System.Windows.Forms.CheckBox chkLifestyle;
        private System.Windows.Forms.CheckBox chkContraIndications;
        private System.Windows.Forms.CheckBox chkReadinessCheck;
        private System.Windows.Forms.TextBox txtEightyFiveOfMaxHR;
        private System.Windows.Forms.TextBox txtMaxHR;
        private System.Windows.Forms.Label lblEightyFiveOfMaxHR;
        private System.Windows.Forms.Label lblMaxHR;
        private System.Windows.Forms.ComboBox cmbStepHeight;
        private System.Windows.Forms.Label lblCapacityValue;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.Label lblNormValue;
        private System.Windows.Forms.Label lblNorm;
        private System.Windows.Forms.Label lblSearchSurname;
        private System.Windows.Forms.Button btnSearchCancel;
    }
}

