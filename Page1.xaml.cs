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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void DynamiTextBox(object sender, RoutedEventArgs e)
        {
            //TextBox txtb = new TextBox();

            //txtb.Height = 50;
            //txtb.Width = 200;
            //txtb.Margin = new Thickness(230, 411, 0, 0);

            //txtb.Text = "Text Box content";
            //txtb.Background = new SolidColorBrush(Colors.Orange);
            //txtb.Foreground = new SolidColorBrush(Colors.Black);

            //GridName.Children.Add(txtb);
            //createTxtTeamNames();

            TextBox txtb = new TextBox();

            txtb.Height = 23;

            txtb.Width = 120;

            txtb.Text = "Text Box content";

            txtb.Background = new SolidColorBrush(Colors.Orange);

            txtb.Foreground = new SolidColorBrush(Colors.Black);
           // txtb.Margin = new Thickness(220, 40, 720, 520);
            txtb.Margin = new Thickness(0,40, 640, 520);

            GridName.Children.Add(txtb);


        }

        public void createTxtTeamNames()
        {
            TextBox[] txtTeamNames = new TextBox[2];

            for (int u = 0; u < txtTeamNames.Count(); u++)
            {
                txtTeamNames[u] = new TextBox();
            }
            int i = 0;
            foreach (TextBox txt in txtTeamNames)
            {
                int l = 0;
                l = l + 130;
                int t = 311;
                string name = "TeamNumber" + i.ToString();

                txt.Name = name;
                txt.Text = name;
                txt.Height = 23;
                txt.Width = 120;
                txt.Text = "Text Box content";
                txt.Background = new SolidColorBrush(Colors.Orange);
                txt.Foreground = new SolidColorBrush(Colors.Black);

                txt.Margin = new Thickness(l, t, 0, 0);
                GridName.Children.Add(txt);
                i++;
            }
        }
    }
}
