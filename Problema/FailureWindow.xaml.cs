using Problema.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Problema
{
    /// <summary>
    /// Interaction logic for FailureWindow.xaml
    /// </summary>
    public partial class FailureWindow : Window
    {
        private ObservableCollection<Failure> Failures { get; set; }
        public FailureWindow(ObservableCollection<Failure> failures)
        {
            InitializeComponent();
            Failures = failures;
            DataContext = this;
        }
    }
}
