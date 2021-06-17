using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Input Output namespace neded for file operations


namespace OleksandrD_Assign2
{
    public partial class Form1 : Form
    {
        List<School> SchoolsList = new List<School>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void LoadAllInformationToListBox() //Addition method to load all information to the list box(SchoolListBox)
        {
            SchoolListBox.Items.Clear(); // to clear listbox before loading info from the list (SchoolsList)
            SchoolListBox.Items.Add("SchoolName\tMexEnrollment\tPrevEnrolment\tFundsPerStudent\t" +
                "NumStudLeaving\tNumStudJoining\tCurrYrEnroll\tTotalFunding"); // it's the first line (header of the list box)
            foreach (School stud in SchoolsList) //using read only foreach loop to add elements to the listbox
            {
                SchoolListBox.Items.Add(stud);
            }
        }
        private void ReadSchoolInfoButton_Click(object sender, EventArgs e) // to read data from the external file that has CSV format
        {
            SchoolsList.Clear(); // clearing before adding info from the file to the list
            try // try-catch method to handle exceptions (instead of program crashing, exception will be catched and displayed)
            {
                using (StreamReader inputStream = new StreamReader("schools_input.csv")) // reading the data from the file
                {
                    string TrackLine;//to keep track of each line that is being read from the stream

                    if (!inputStream.EndOfStream)
                    { // to check if file has a data
                        TrackLine = inputStream.ReadLine(); //to read the first line of the doc that is a header
                        MessageBox.Show(TrackLine);
                    }

                    while (!inputStream.EndOfStream)
                    { // process data line from the line 2 of the text file 
                        TrackLine = inputStream.ReadLine(); //to read one line at time
                        string[] fieldArray = TrackLine.Split(','); // to split each line from the doc based on coma
                        string name = fieldArray[0];//first column element 
                        string maxEnrollment = fieldArray[1];
                        int.TryParse(maxEnrollment, out int maxenroll); // we must tryparse to int, double because all data in the file is a STRING
                        string preverenroll = fieldArray[2];
                        int.TryParse(preverenroll, out int PrevEnrol);
                        string fundsperstud = fieldArray[3];
                        double.TryParse(fundsperstud, out double FundPerStud);
                        string numstudleaving = fieldArray[4];
                        int.TryParse(numstudleaving, out int NumStudLeaving);
                        string numstudjoing = fieldArray[5];
                        int.TryParse(numstudjoing, out int NumStudJoin);
                        School objectOne = new School(name, maxenroll, PrevEnrol,
                            FundPerStud, NumStudLeaving, NumStudJoin); 
                        SchoolsList.Add(objectOne); // Note: I've created ToString method in the class to display all object's elemetns in the particula order, here we add all object's elements to the list and after, we call method to upload all data to the listbox
                        StatusUpdateLabel.Text = "Loaded " + SchoolsList.Count + " schools from the file"; // text label is used to display a message in the form (designer window) when some actions are done (here, after reading the external file, the message is displayed on the status label) 

                    }
                }

                LoadAllInformationToListBox(); // to load the data to the listbox
            }

            catch (Exception msex)
            {
                MessageBox.Show(msex.Message); // to display any errors that can occur
            }
        }
       private void SchoolListBox_SelectedIndexChanged(object sender, EventArgs e) // Additional method that is used to display data from the listbox into textboxes when certain line is selected in the listbox
        {
            
                if (SchoolListBox.SelectedIndex == 0)
                { // when the first line in listbox is selected (the first line is a header)
                   ;
                }
                else if (SchoolListBox.SelectedIndex > 0)
            { // if selected line isn't the header, data from the listbox is loaded to the NumberofStudleaveTextBox, NumStudJoiningBox and SchoolNameTextBox
                StatusUpdateLabel.Text = "Selected item index in list box is " + SchoolListBox.SelectedIndex + "" +
                        ". Selected school is " + SchoolsList[SchoolListBox.SelectedIndex - 1].SchoolName;
                NumberofStudleaveTextBox.Text = SchoolsList[SchoolListBox.SelectedIndex - 1].NumStudsLeaving.ToString();// int data type must be formated into string 
                NumStudJoiningBox.Text = SchoolsList[SchoolListBox.SelectedIndex - 1].NumStudsJoining.ToString();
                SchoolNameTextBox.Text = SchoolsList[SchoolListBox.SelectedIndex - 1].SchoolName;
            }

               
            }
          
        

        private void UpdateNumStudLeavingButton_Click(object sender, EventArgs e)
        { //method to update the number of student who are leaving the school in the listtextbox

           
            if(SchoolListBox.SelectedIndex == -1 || SchoolListBox.SelectedIndex ==0)
            { // if no line is selected or the first line that is header is selected, show the next text
                MessageBox.Show("Please select a school to update number of students leaving");
                StatusUpdateLabel.Text = "Please select a school to update number of students leaving";
            }
            else if (!int.TryParse(NumberofStudleaveTextBox.Text, out int numstudleaving) || numstudleaving <= 0 || numstudleaving > SchoolsList[SchoolListBox.SelectedIndex-1].CurrYrEnroll)
            { // in case if we get an invalid result
                StatusUpdateLabel.Text="Number of student leaving must be intager > 0 and <= current enrolment";
               
            }
            else 
            {
                //to update the NumStudsLeaving in listbox based on the entered value into textbox
                SchoolsList[SchoolListBox.SelectedIndex - 1].NumStudsLeaving = numstudleaving;
                
                SchoolListBox.Items[SchoolListBox.SelectedIndex] = SchoolsList[SchoolListBox.SelectedIndex - 1];
                StatusUpdateLabel.Text = "Number of students leaving has been updated for the " + SchoolsList[SchoolListBox.SelectedIndex - 1].SchoolName;
            }

        }

        private void NumStudsJoiningButton_Click(object sender, EventArgs e)
        {//method to update the number of student who are joaining the school in the listbox (similar logic to the UpdateNumStudLeavingButton_Click)
            if (SchoolListBox.SelectedIndex == -1 || SchoolListBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a school to update number of students joining");
                StatusUpdateLabel.Text = "Please select a school to update number of students joining";
            }
            else if(!int.TryParse(NumStudJoiningBox.Text, out int studjoining) || studjoining <=0)
            {
                StatusUpdateLabel.Text = "Number of student joining must be valid intager and > 0";
            }
            else
            {
                SchoolsList[SchoolListBox.SelectedIndex - 1].NumStudsJoining = studjoining;
                SchoolListBox.Items[SchoolListBox.SelectedIndex] = SchoolsList[SchoolListBox.SelectedIndex - 1];
                StatusUpdateLabel.Text = " Number of students joining has been updated for the " + SchoolsList[SchoolListBox.SelectedIndex - 1].SchoolName;
            }
        }

        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        { // method to delete the selected line from the listbox
            if(SchoolListBox.SelectedIndex==-1 || SchoolListBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a school to delete");
                StatusUpdateLabel.Text = "Please select a school to delete";
            }
            else 
            {

                StatusUpdateLabel.Text = "Deleted " + SchoolsList[SchoolListBox.SelectedIndex - 1].SchoolName + " school that had index " + SchoolListBox.SelectedIndex; // before performing deleting, we should display the status update method, 
                                                                                                                                                                         // if we put statusupdate after deleting, wrong school will be displayed
                SchoolsList.RemoveAt(SchoolListBox.SelectedIndex-1); // remove selected school from the list
                SchoolListBox.Items.RemoveAt(SchoolListBox.SelectedIndex); // remove selected school from the listbox
               
            }
        }

        private void SortDescendOrderTotFundButton_Click(object sender, EventArgs e)
        { // method to sort by descending order based on the total funding
            //NOTE: Here we sort the original list, it will sort the data in file that we can store after sorting 
            SchoolsList = SchoolsList.OrderByDescending(schoolobject => schoolobject.TotalFunding).ToList(); // this OrderByDescending method returns list
            LoadAllInformationToListBox(); // to load sorted data in listbox
            StatusUpdateLabel.Text = "Sorted Schools in Descending order of TotalFinding";
        }

        private void SaveSchookOutputButton_Click(object sender, EventArgs e)
        {//method to write the data to the file 
            try
            {
                using (StreamWriter myOutPutInfo = new StreamWriter("schooloutputinfo.txt")) //Stream allows to hold and store info into file 
                {
                    //file header
                    string header = "SchoolName" + "\t" + "MaxEnroll" + "\t" + "PrevYrEnroll" + "\t" + "NumStudsLeaving" +"\t"+ "NumStudsJoining" +
                        "\t"+"FundsPerStud"+"\t"+ "CurrYrEnroll"+"\t"+"TotalFindong";
                    myOutPutInfo.WriteLine(header);

                    foreach(School schoolname in SchoolsList) //foreach is used to write all data from the list into the file 
                    {
                        myOutPutInfo.WriteLine(schoolname.SchoolName + "\t" + schoolname.MaxEnroll + "\t\t" + schoolname.PrevYrEnroll +
                            "\t\t" + schoolname.NumStudsLeaving + "\t\t" + schoolname.NumStudsJoining + "\t\t" + schoolname.FundsPerStud +
                            "\t\t" + schoolname.CurrYrEnroll + "\t\t" + schoolname.TotalFunding);
                    }
                    //StatusUpdateLabel.Text = "Written " + SchoolsList.Count + " schools to the file (schooloutputinfo.txt)"; 
                    Form2 formtwoobject = new Form2();
                    this.Hide();
                    formtwoobject.LabelFormTwo.Text = "Written " + SchoolsList.Count + " schools to the file";
                    formtwoobject.ShowDialog();
                    this.Show();
                    SchoolListBox.Items.Clear();// to clear the lisbox after writing the data into the file 
                    SchoolsList.Clear(); // to clear the list 
                }

            }


            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveSchoolExceedMaxEnrolBut_Click(object sender, EventArgs e) // when the "SaveSchoolExceedMaxEnrolBut" button is clicked we get this method
        { // this method is used to save only those schools that exceeded max enrolment 
            try // using try catch in case if some exception arises
            {
                using(StreamWriter saveoEnrollmentExceededReport = new StreamWriter("schools_enrollexceeded.txt"))
                {
                    string headerLine = "SchoolName,MaxEnroll,PrevYrEnroll,NumStudsLeaving,NumStudsJoining,CurrYrEnroll";
                    saveoEnrollmentExceededReport.WriteLine(headerLine);
                    int keeptrackschools=0; // variable to keep track of how many schools are written to the file 

                    foreach (School stud in SchoolsList)
                    {
                        if (stud.CurrYrEnroll > stud.MaxEnroll)
                        {
                            //if school current enrollment exceeded max enrollment, data about that school is written into the file
                            saveoEnrollmentExceededReport.WriteLine(stud.SchoolName + "," + stud.MaxEnroll + "," + stud.PrevYrEnroll + "," + stud.NumStudsLeaving +
                                "," + stud.NumStudsLeaving + "," + stud.CurrYrEnroll);
                            keeptrackschools++; // increment the variable every time when school is written to the file
                            
                        }
                       
                    }
                    StatusUpdateLabel.Text = "Written " + keeptrackschools + " Schools to the schools_enrollexceeded.txt file"; // to display how many school was saved to the file, I am using 
                                                                                                                                // keeptrackschools variable here instead SchoolList. Count because I didn't update the number
                                                                                                                           // of school that exceeded maxenrol in the listbox



                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SavingSchoolFundInfButton_Click(object sender, EventArgs e)
        { // method to write out the data into a file for the schools which total funding is more than 0
            //the logic of this method is similar to the SaveSchoolExceedMaxEnrolBut_Click method
            try
            {
                using (StreamWriter saveSchoolFunding = new StreamWriter("school_funds.txt"))
                {
                    string headerLine = "SchoolName\tFundsPerStud\tCurrYrEnroll\tTotalFunding";
                    saveSchoolFunding.WriteLine(headerLine);
                    int keeptrackschools = 0;

                    foreach (School stud in SchoolsList)
                    {
                        if (stud.TotalFunding > 0)
                        {
                            saveSchoolFunding.WriteLine(stud.SchoolName + "\t" + stud.FundsPerStud + "\t\t" + stud.CurrYrEnroll + "\t\t" + stud.TotalFunding);
                            keeptrackschools++;

                        }

                    }
                    StatusUpdateLabel.Text = "Written " + keeptrackschools + " schools to the school_funds.txt file ";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
