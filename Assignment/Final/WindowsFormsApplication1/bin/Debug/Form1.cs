using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        int stepHeight;
        int maxHeartRate;
        int eightyFivePercentHR;
        int fiftyPercentHR;
        string ImportName;
        string ImportSurname;
        string ImportAge;
        string ListBoxRecord;
        string sex;
        int stepHeightFlag = 0;
        int sexFlag = 0;

        public Form1()
        {
            InitializeComponent();
            Form1_Load();


        }
        private void Form1_Load()
        {
            DbEntities db = new DbEntities();
            populateGrid(db.Participants.ToList());
            cmbStepHeight.DropDownStyle = ComboBoxStyle.DropDownList; ;
            btnAdd.Enabled = false;
            btnSearchCancel.Enabled = false;
            txtMaxHR.Enabled = false;
            txtEightyFiveOfMaxHR.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        

        private void populateGrid(List<Participant> list)
        {
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
        }

        private void addToDB(List<string> cList)
        {

            DbEntities db = new DbEntities();

            foreach (var str in cList)
            {
                string[] wordArray = str.Split(',');
                Participant tested = new Participant();
                tested.Name = wordArray[0];
                tested.Surname = wordArray[1];
                tested.Age = wordArray[2];
                tested.Capacity = "23";
                tested.Date = DateTime.Now;
                tested.Rating = "28";
                db.Participants.Add(tested);

            }

            db.SaveChanges();

        }

        private List<string> GetInputFromFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            List<string> memberList = new List<string>();
            while (sr.Peek() != -1)
            {
                memberList.Add(sr.ReadLine());

            }
            sr.Close();
            return memberList;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            DbEntities db = new DbEntities();
            if (txtSearch.Text != "")
            {
                string str = txtSearch.Text;
                List<Participant> conList = db.Participants.Where(c => c.Surname.ToUpper().Contains(str.ToUpper())).ToList();
                populateGrid(conList);
                btnSearchCancel.Enabled = true;
            }
            else
            {
                MessageBox.Show("The input box is empty");
            }
        }

        

        

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var s = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            DbEntities db = new DbEntities();
            List<Participant> testedList;
            switch (e.ColumnIndex)
            {
                case 0:
                    testedList = db.Participants.OrderBy(c => c.Id).ToList();
                    break;
                case 1:
                    testedList = db.Participants.OrderBy(c => c.Name).ToList();
                    break;
                case 2:
                    testedList = db.Participants.OrderBy(c => c.Surname).ToList();
                    break;
                case 3:
                    testedList = db.Participants.OrderBy(c => c.Age).ToList();
                    break;
                case 4:
                    testedList = db.Participants.OrderBy(c => c.Date).ToList();
                    break;
                case 5:
                    testedList = db.Participants.OrderBy(c => c.Capacity).ToList();
                    break;
                default:
                    testedList = db.Participants.ToList();
                    break;


            }
            populateGrid(testedList);
        }



        public void btnImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialog1.FileName;
                    StreamReader sR = new StreamReader(path);
                    while (sR.Peek() != -1)
                    {

                        string s = sR.ReadLine();
                        string[] lineSplitArray = s.Split(',');
                        ImportName = lineSplitArray[0];
                        ImportSurname = lineSplitArray[1];
                        ImportAge = lineSplitArray[2];
                        ListBoxRecord = ImportName + ' ' + ImportSurname + ' ' + ImportAge;
                        listBoxNames.Items.Add(ListBoxRecord);
                    }

                    sR.Close();
                }
                catch
                {
                    MessageBox.Show("Something went wrong");
                }
            }

            else
            {
                return;
            }

        }

        private void ListBoxNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            string listBoxRecord = listBoxNames.Text;
            string[] recordSplitArray = listBoxRecord.Split(' ');
            ImportName = recordSplitArray[0];
            ImportSurname = recordSplitArray[1];
            ImportAge = recordSplitArray[2];
            txtInputName.Text = ImportName;
            txtInputSurname.Text = ImportSurname;
            txtInputAge.Text = ImportAge;
            TabSelection.SelectedTab = tabAdd;
        }

        private void txtInputAge_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txtInputAge.Text, out parsedValue) && txtInputAge.Text != "")
            {
                MessageBox.Show("This is a number only field");
                txtInputAge.Text = "";
                return;
            }

            if (txtInputAge.Text != "")
            {
                maxHeartRate = 220 - int.Parse(txtInputAge.Text);
                txtMaxHR.Text = maxHeartRate.ToString();
                eightyFivePercentHR = (int)(0.85 * maxHeartRate);
                txtEightyFiveOfMaxHR.Text = eightyFivePercentHR.ToString();
                fiftyPercentHR = (int)(0.5 * maxHeartRate);
            }

            else
            {
                txtMaxHR.Text = "";
                txtEightyFiveOfMaxHR.Text = "";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            
            int isAgeValidation = 0;
            int isChecked = 0;
            int HRValidation = 0;
            int isNameSurname = 0;

            if (txtInputAge.Text != "")
            {
                if (int.Parse(txtInputAge.Text) >= 0 && int.Parse(txtInputAge.Text) <= 110)
                {
                    isAgeValidation = 1;
                }
            }

            if (txtInputName.Text != "" && txtInputSurname.Text != "")
            {
                isNameSurname = 1;
            }



            if (ValidateHR())
            {
                HRValidation = 1;
            }

            if (ValidateCheckBoxes())
            {
                isChecked = 1;
            }





            if (stepHeightFlag == 1 && sexFlag == 1 && isAgeValidation == 1 && HRValidation == 1 && isChecked == 1 && isNameSurname == 1)
            {
                List<double> HRMeasurements = new List<double>();
                HRMeasurements.Clear();
                List<double> XValues = new List<double>();
                XValues.Clear();

                if (int.Parse(txtHR1.Text) >= fiftyPercentHR && int.Parse(txtHR1.Text) <= eightyFivePercentHR)
                {
                    HRMeasurements.Add(double.Parse(txtHR1.Text));
                    AddXValue(ref XValues, stepHeight, 1); // first element on the list

                }

                if (int.Parse(txtHR2.Text) >= fiftyPercentHR && int.Parse(txtHR2.Text) <= eightyFivePercentHR)
                {
                    HRMeasurements.Add(double.Parse(txtHR2.Text));
                    AddXValue(ref XValues, stepHeight, 2);

                }
                if (int.Parse(txtHR3.Text) >= fiftyPercentHR && int.Parse(txtHR3.Text) <= eightyFivePercentHR)
                {
                    HRMeasurements.Add(double.Parse(txtHR3.Text));
                    AddXValue(ref XValues, stepHeight, 3);
                }
                if (int.Parse(txtHR4.Text) >= fiftyPercentHR && int.Parse(txtHR4.Text) <= eightyFivePercentHR)
                {
                    HRMeasurements.Add(double.Parse(txtHR4.Text));
                    AddXValue(ref XValues, stepHeight, 4);
                }
                if (int.Parse(txtHR5.Text) >= fiftyPercentHR && int.Parse(txtHR5.Text) <= eightyFivePercentHR)
                {
                    HRMeasurements.Add(double.Parse(txtHR5.Text));
                    AddXValue(ref XValues, stepHeight, 5);
                }

                double m = M(XValues, HRMeasurements);
                double b = B(XValues, HRMeasurements, m);

                double Capacity = (maxHeartRate - b) / m;
                lblCapacityValue.Text = ((int)Capacity).ToString();
                lblNormValue.Text = WhatNorm((int)Capacity, sex, int.Parse(txtInputAge.Text));

                btnAdd.Enabled = true;

            }
            else if (stepHeight == 0)
            {
                MessageBox.Show("You haven't set step height");
            }
            else if (isNameSurname == 0)
            {
                MessageBox.Show("You haven't entered name or surname");
            }
            else if (isAgeValidation == 0)
            {
                MessageBox.Show("Age value is invalid");
            }
            else if (sexFlag == 0)
            {
                MessageBox.Show("You haven't set sex");
            }
            else if (isChecked == 0)
            {
                MessageBox.Show("You haven't checked checkboxes");
            }


            else
            {
                MessageBox.Show("Your measurements are invalid");
            }

           
            
            


        }

        private bool ValidateCheckBoxes()
        {
            if (chkContraIndications.Checked == true && chkLifestyle.Checked == true && chkReadinessCheck.Checked == true)
            {
                return true;

            }
            else return false;
        }

        private bool ValidateHR()
        {
            int parsedValue;
            if (txtHR1.Text == "" || txtHR2.Text == "" || txtHR3.Text == "" || txtHR4.Text == "" || txtHR5.Text == "")
            {
                return false;
            }
            else if ((!int.TryParse(txtHR1.Text, out parsedValue)) || (!int.TryParse(txtHR2.Text, out parsedValue)) ||
                (!int.TryParse(txtHR3.Text, out parsedValue)) || (!int.TryParse(txtHR4.Text, out parsedValue)) || (!int.TryParse(txtHR5.Text, out parsedValue)))
                {
                return false;
            }
            else return true;
        }

        private void AddXValue(ref List<double> xValues, int stepHeight, int v)
        {
            if (stepHeight == 15)
            {
                if (v == 1) xValues.Add(11);
                if (v == 2) xValues.Add(14);
                if (v == 3) xValues.Add(18);
                if (v == 4) xValues.Add(21);
                if (v == 5) xValues.Add(25);
              
                
            }
            if (stepHeight == 20)
            {
                if (v == 1) xValues.Add(12);
                if (v == 2) xValues.Add(17);
                if (v == 3) xValues.Add(21);
                if (v == 4) xValues.Add(25);
                if (v == 5) xValues.Add(29);
            }
            if (stepHeight == 25)
            {
                if (v == 1) xValues.Add(14);
                if (v == 2) xValues.Add(19);
                if (v == 3) xValues.Add(24);
                if (v == 4) xValues.Add(28);
                if (v == 5) xValues.Add(33);
                

            }
            if (stepHeight == 30)
            {
                if (v == 1) xValues.Add(16);
                if (v == 2) xValues.Add(21);
                if (v == 3) xValues.Add(27);
                if (v == 4) xValues.Add(32);
                if (v == 5) xValues.Add(37);
              
            }

        }

        
        private string WhatNorm(int capacity, string sex, int age)
        {
            
            if (sex == "M")
            {
                if (age >= 15 && age <= 19) 
                {
                    if (capacity >= 60) return "Excellent";
                    else if (capacity >= 48 && capacity <= 59) return "Good";
                    else if (capacity >= 39 && capacity <= 47) return "Average";
                    else if (capacity >= 30 && capacity <= 38) return "Below Average";
                    else return "Poor";

                }
                else if (age >= 20 && age <= 29)
                {
                    if (capacity >= 55) return "Excellent";
                    else if (capacity >= 44 && capacity <= 54) return "Good";
                    else if (capacity >= 35 && capacity <= 43) return "Average";
                    else if (capacity >= 28 && capacity <= 34) return "Below Average";
                    else return "Poor";

                }
                else if (age >= 30 && age <= 39)
                {
                    if (capacity >= 50) return "Excellent";
                    else if (capacity >= 40 && capacity <= 49) return "Good";
                    else if (capacity >= 34 && capacity <= 39) return "Average";
                    else if (capacity >= 26 && capacity <= 33) return "Below Average";
                    else return "Poor";

                }
                else if (age >= 40 && age <= 49)
                {
                    if (capacity >= 46) return "Excellent";
                    else if (capacity >= 37 && capacity <= 45) return "Good";
                    else if (capacity >= 32 && capacity <= 36) return "Average";
                    else if (capacity >= 25 && capacity <= 31) return "Below Average";
                    else return "Poor";

                }
                else if (age >= 50 && age <= 59)
                {
                    if (capacity >= 44) return "Excellent";
                    else if (capacity >= 35 && capacity <= 43) return "Good";
                    else if (capacity >= 29 && capacity <= 34) return "Average";
                    else if (capacity >= 23 && capacity <= 28) return "Below Average";
                    else return "Poor";

                }
                else 
                {
                    if (capacity >= 40) return "Excellent";
                    else if (capacity >= 33 && capacity <= 39) return "Good";
                    else if (capacity >= 25 && capacity <= 32) return "Average";
                    else if (capacity >= 20 && capacity <= 24) return "Below Average";
                    else return "Poor";

                }
            }
            else
            {
               
                    if (age >= 15 && age <= 19)
                    {
                        if (capacity >= 55) return "Excellent";
                        else if (capacity >= 44 && capacity <= 54) return "Good";
                        else if (capacity >= 39 && capacity <= 47) return "Average";
                        else if (capacity >= 30 && capacity <= 38) return "Below Average";
                        else return "Poor";

                    }
                    else if (age >= 20 && age <= 29)
                    {
                        if (capacity >= 50) return "Excellent";
                        else if (capacity >= 40 && capacity <= 49) return "Good";
                        else if (capacity >= 32 && capacity <= 39) return "Average";
                        else if (capacity >= 27 && capacity <= 31) return "Below Average";
                        else return "Poor";

                    }
                    else if (age >= 30 && age <= 39)
                    {
                        if (capacity >= 45) return "Excellent";
                        else if (capacity >= 36 && capacity <= 45) return "Good";
                        else if (capacity >= 30 && capacity <= 35) return "Average";
                        else if (capacity >= 25 && capacity <= 29) return "Below Average";
                        else return "Poor";

                    }
                    else if (age >= 40 && age <= 49)
                    {
                        if (capacity >= 43) return "Excellent";
                        else if (capacity >= 34 && capacity <= 42) return "Good";
                        else if (capacity >= 28 && capacity <= 33) return "Average";
                        else if (capacity >= 22 && capacity <= 27) return "Below Average";
                        else return "Poor";

                    }
                    else if (age >= 50 && age <= 59)
                    {
                        if (capacity >= 41) return "Excellent";
                        else if (capacity >= 33 && capacity <= 40) return "Good";
                        else if (capacity >= 26 && capacity <= 32) return "Average";
                        else if (capacity >= 21 && capacity <= 25) return "Below Average";
                        else return "Poor";

                    }
                    else 
                    {
                        if (capacity >= 39) return "Excellent";
                        else if (capacity >= 31 && capacity <= 38) return "Good";
                        else if (capacity >= 24 && capacity <= 30) return "Average";
                        else if (capacity >= 18 && capacity <= 23) return "Below Average";
                        else return "Poor";

                    }
                
            }

            
        }

       

        private double M(List<double> X, List<double> Y)
        {
            double numerator = 0;
            double denominator = 0;
            double avgX = X.Average();
            double avgY = Y.Average();
            
            for (int i = 0; i < X.Count; i++)
            {
                numerator = numerator + (X[i] - avgX) * (Y[i] - avgY);
            }
            for (int i = 0; i < X.Count; i++)
            {
                denominator = denominator + (X[i] - avgX) * (X[i] - avgX);
            }
            return numerator / denominator;
        }

        private double B(List<double> X, List<double> Y, double m)
        {
            double avgX = X.Average();
            double avgY = Y.Average();
            return avgY - (m * avgX);
        }

        private void cmbStepHeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            stepHeight =  int.Parse(cmbStepHeight.Text);
            stepHeightFlag = 1;
        }

        private void cmbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            sex = cmbSex.Text;
            sexFlag = 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DbEntities db = new DbEntities();
            Participant Person = new Participant();
            Person.Name = txtInputName.Text;
            Person.Surname = txtInputSurname.Text;
            Person.Age = txtInputAge.Text;
            Person.Capacity = lblCapacityValue.Text;
            Person.Date = DateTime.Now;
            Person.Rating = lblNormValue.Text;
            db.Participants.Add(Person);
            db.SaveChanges();

            DialogResult result = MessageBox.Show("Participant added successfully, do you want to add another person and clear the form?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                txtInputName.Text = "";
                txtInputSurname.Text = "";
                txtInputAge.Text = "";
                txtHR1.Text = "";
                txtHR2.Text = "";
                txtHR3.Text = "";
                txtHR4.Text = "";
                txtHR5.Text = "";
                lblCapacityValue.Text = "";
                lblNormValue.Text = "";
                sexFlag = 0;
                cmbSex.Text = "";
                chkContraIndications.Checked = false;
                chkLifestyle.Checked = false;
                chkReadinessCheck.Checked = false;
                btnAdd.Enabled = false;

            }
            else if (result == DialogResult.No)
            {
                
            }
            
        }

        private void TabSelection_Selecting(object sender, TabControlCancelEventArgs e)
        {
            DbEntities db = new DbEntities();
            populateGrid(db.Participants.ToList());
        }

        private void btnSearchCancel_Click(object sender, EventArgs e)
        {
            DbEntities db = new DbEntities();
            populateGrid(db.Participants.ToList());
            btnSearchCancel.Enabled = false;
            txtSearch.Text = "";

        }
    }
}
