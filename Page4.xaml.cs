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
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Student St1 = new Student()
            {
                Name = SnTxt1.Text,
                Age= SATxt1.Text

            };
            Student St2 = new Student()
            {
                Name = SnTxt2.Text,
                Age = SATxt2.Text

            };

            List<Student> Students = new List<Student>();
            Students.Add(St1);
            Students.Add(St2);

            StudentGrid p = new StudentGrid(Students);
           // NavigationService.Navigate(p, Students);
            this.NavigationService.Navigate(p);


            //   StudentGrid p = new StudentGrid(2);
            //  this.NavigationService.Navigate(p);

            //   Repo.Record(St1);
            //   Repo.Record(St2);




            //   StudentGrid p2 = new StudentGrid();
            // NavigationService.Navigate(p2, Students);
        }
    }


    }
