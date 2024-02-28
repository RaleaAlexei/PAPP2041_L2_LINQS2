using Newtonsoft.Json;
using Problema.Models;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.IO;
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

namespace Problema
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string filePath = "students.json";
        private ObservableCollection<Student> students;
        public MainWindow()
        {
            InitializeComponent();
            students = StudentList.LoadSampleData();
            dgStudents.ItemsSource = students;
        }
        private ObservableCollection<Student>? ReadFromJsonFile()
        {
            if(!File.Exists(filePath))
            {
                return new ObservableCollection<Student>();
            }
            string json = File.ReadAllText(filePath);
            return new ObservableCollection<Student>(JsonConvert.DeserializeObject<ObservableCollection<Student>>(json));
        }
        private void Button_Save(object sneder, RoutedEventArgs e)
        {
            try
            {
                var student = new Student();
                student.Name = txtName.Text;
                student.DateBirth = dpBirth.SelectedDate.Value;
                string[] marks = txtMark.Text.Split(' ');
                foreach(string mark in marks)
                {
                    student.Marks.Add(double.Parse(mark));
                }
                students.Add(student);
                SaveToJsonFile();
                txtMark.Text = string.Empty;
                txtName.Text = string.Empty;
                dpBirth.SelectedDate = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Nu ati introdus toate datele!");
            }
        }
        private void Button_Delete(object sneder, RoutedEventArgs e)
        {
            var selectedStudent = dgStudents.SelectedValue as Student;
            students.Remove(selectedStudent);
            SaveToJsonFile();
        }
        private void Button_NumberOfFailure(object sneder, RoutedEventArgs e)
        {
            var failure = students.Where(x => x.Marks.Any(y => y < 5));
            var failureList = failure.Select(x => new Failure
            {
                Nume = x.Name,
                NumberOfFailure = x.Marks.Count(y => y < 5)
            }).ToList();
            var failuresWindow = new FailureWindow(new ObservableCollection<Failure>(failureList));
            failuresWindow.ShowDialog();
        }
        private void SaveToJsonFile()
        {
            string json = JsonConvert.SerializeObject(students);
            File.WriteAllText(filePath, json);
        }

    }
}