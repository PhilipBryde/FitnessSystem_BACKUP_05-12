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
using System.Windows.Shapes;

namespace FitnessProgram
{
    /// <summary>
    /// Interaction logic for ActivityOptionsWindow.xaml
    /// </summary>
    public partial class ActivityOptionsWindow : Window
    {
        public ActivityOptionsWindow(string activityName)
        {
            InitializeComponent();
            ActivityName.Content = activityName; //Texten bliver laver om til det valge aktivitets navn
        }
    }
}
