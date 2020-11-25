using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp2.Model;

namespace WpfApp2.Views
{
    /// <summary>
    /// Interaction logic for StudentGrid.xaml
    /// </summary>
    public partial class StudentGrid : Page
    {
        Student valueFromPage1;
        List<Student> lstStud = new List<Student>();
        public StudentGrid( )
        {
            InitializeComponent();
            // NavigationService.LoadCompleted += NavigationService_LoadCompleted;
            // McDataGrid.ItemsSource = Repo.Display();
        }

        public StudentGrid(Student val):this()
        {
            valueFromPage1 = val;
            this.Loaded += new RoutedEventHandler(StudentGrid_Loaded);

        }
        void StudentGrid_Loaded(object sender, RoutedEventArgs e)
        {
           // Student valueFromPage2 =  valueFromPage1;
            McDataGrid.ItemsSource = lstStud;
        }

        public StudentGrid(List<Student> Students) :this()
        {
            lstStud = Students;
            McDataGrid.ItemsSource = lstStud;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void NavigationService_LoadCompleted(object sender, NavigationEventArgs e)
        {
            Student str = (Student)e.ExtraData;
            McDataGrid.ItemsSource = lstStud;

            // do whatever with str, like assign to a view model field, etc.
        }

        private void test(object sender, RoutedEventArgs e)
        {
          //  var txt = Page4.SnTxt2.Text;
        }
    }
}
