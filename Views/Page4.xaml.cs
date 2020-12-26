using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        Repo ObjRepo = new Repo();
        public Page4()
        {
            InitializeComponent();
        }


        private void Save_Click(object sender, RoutedEventArgs e)
        {


        

            List<Student> Students = new List<Student>();
            Student St1 = new Student()
            {
                Name = txtName1.Text,
                Age = Convert.ToInt32(txtAge1.Text),
                Gender = txtGen1.Text

            };
            Student St2 = new Student()
            {
                Name = txtName2.Text,
                Age = Convert.ToInt32(txtAge2.Text),
                Gender = txtGen2.Text

            };




            int p1=ddlCount.SelectedIndex;

            if (p1 == 0)
            {              
                Students.Add(St1);
                Students.Add(St2);
            }


            if (p1 == 1)
            {
                Student St3 = new Student()
                {
                    Name = txtName3.Text,
                    Age = Convert.ToInt32(txtAge3.Text),
                    Gender = txtGen3.Text

                };
                Students.Add(St1);
                Students.Add(St2);
                Students.Add(St3);
            }

            if (p1 == 2)
            {
                Student St3 = new Student()
                {
                    Name = txtName3.Text,
                    Age = Convert.ToInt32(txtAge3.Text),
                    Gender = txtGen3.Text

                };
                Student St4 = new Student()
                {
                    Name = txtName4.Text,
                    Age = Convert.ToInt32(txtAge4.Text),
                    Gender = txtGen4.Text

                };
                Students.Add(St1);
                Students.Add(St2);
                Students.Add(St3);
                Students.Add(St4);
            }



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

        private void DdlCount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ObjRepo.ddlIndex = ddlCount.SelectedIndex;
            if(ObjRepo.ddlIndex==1)
            {
                //TextBox txtName3= new TextBox();
                //TextBox txtAge3= new TextBox();
                //TextBox txtGen3 = new TextBox();
                //TextBox txtName4 = new TextBox();
                //TextBox txtAge4 = new TextBox();
                //TextBox txtGen4 = new TextBox();

                txtName3.Text= string.Empty;
                txtName3.Visibility = Visibility.Visible;
                txtAge3.Clear();
                txtAge3.Visibility = Visibility.Visible;
                txtGen3.Clear();
                txtGen3.Visibility = Visibility.Visible;

                txtName4.Text = string.Empty;
                txtName4.Visibility = Visibility.Hidden;
                txtAge4.Clear();
                txtAge4.Visibility = Visibility.Hidden;
                txtGen4.Clear();
                txtGen4.Visibility = Visibility.Hidden;
            }

            if (ObjRepo.ddlIndex == 2)
            {
                //if(txtName3.Visibility=true)
                //{

                //}



                txtName3.Text = string.Empty;
                txtName3.Visibility = Visibility.Visible;
                txtAge3.Clear();
                txtAge3.Visibility = Visibility.Visible;
                txtGen3.Clear();
                txtGen3.Visibility = Visibility.Visible;

                txtName4.Text = string.Empty;
                txtName4.Visibility = Visibility.Visible;
                txtAge4.Clear();
                txtAge4.Visibility = Visibility.Visible;
                txtGen4.Clear();
                txtGen4.Visibility = Visibility.Visible;
            }

            if ((ObjRepo.ddlIndex == 0 ) )

            {
                var textBox = sender as TextBox;
                if (textBox != null && textBox.Text != null)
                {
                    if (txtName3.Text != null)
                    {
                        txtName3.Text = string.Empty;
                        txtName3.Visibility = Visibility.Hidden;
                        txtAge3.Clear();
                        txtAge3.Visibility = Visibility.Hidden;
                        txtGen3.Clear();
                        txtGen3.Visibility = Visibility.Hidden;
                    }

                }

                
            }

            string ankur = ddlCount.SelectedItem.ToString();
            string Value = "";
             if (ddlCount.SelectedIndex >= 1)
                Value = ((ComboBoxItem)ddlCount.SelectedItem).Content.ToString();
            var selectedValue = ddlCount.SelectedValue;
        }



        private void Cancel_Click(object sender, RoutedEventArgs e)
        {

        }


        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }


    }
