using System.Net.NetworkInformation;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment3._3._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Create a list to hold student objects
        List<Student> StudentList = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            //Instantiate a new student object
            var student = new Student();

            if(string.IsNullOrEmpty(this.txtStudentID.Text))
            {
                MessageBox.Show("The student must have a first name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                //Add the student id from the text box to the student object if the text box is not blank
                student.StudentId = this.txtStudentID.Text;
            }

            if(string.IsNullOrEmpty(this.txtFirstName.Text))
            {
                MessageBox.Show("The student must have a first name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                //Add the student's first name from the text box to the student object if the text box is not blank
                student.FirstName = this.txtFirstName.Text;
            }

            if (string.IsNullOrEmpty(this.txtLastName.Text))
            {
                MessageBox.Show("The student must have a first name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                //Add the student's last name from the text box to the student object if the text box is not blank
                student.LastName = this.txtLastName.Text;
            }

            if (string.IsNullOrEmpty(this.txtAddress.Text))
            {
                MessageBox.Show("The student must have a first name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                //Add the student's address from the text box to the student object if the text box is not blank
                student.Address = this.txtAddress.Text;
            }

            if (string.IsNullOrEmpty(this.txtMonthOfAdmission.Text))
            {
                MessageBox.Show("The student must have a first name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                //Add the month the student was admitted from the text box to the student object if the text box is not blank
                student.MonthOfAdmission = this.txtMonthOfAdmission.Text;
            }

            if (string.IsNullOrEmpty(this.txtGPA.Text))
            {
                MessageBox.Show("The student must have a first name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                //Add the student's GPA from the text box to the student object if the text box is not blank
                student.GPA = Convert.ToDouble(this.txtGPA.Text);
            }

            //Add the student object to the student list
            StudentList.Add(student);
            
        }
    }
}