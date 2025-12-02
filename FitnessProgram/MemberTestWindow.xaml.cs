using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
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
    /// Interaction logic for MemberTestWindow.xaml
    /// </summary>
    public partial class ActivityWindow : Window
    {
        Fitness fitness = new Fitness();
        public ObservableCollection<string> Activities { get; set; } = new ObservableCollection<string>();
        public ActivityWindow()
        {
            InitializeComponent();
            DataContext = this;
            ShowActivity();
        }


        private void ShowActivity()
        {
            string filePath = @"ActivityList.txt";
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                Activities.Add(line);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var activity = button.DataContext as string;
            ActivityOptionsWindow options = new ActivityOptionsWindow(activity); //Opretter et objekt 
            options.Show();

        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NextWindow next = new NextWindow();
            next.Show();
            this.Close();
        }
    }
}
