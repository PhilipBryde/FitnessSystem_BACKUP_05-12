using FitnessProgram;
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

namespace FitnessProgram;
//Philip Kode 
public partial class RegisterWindow : Window
{
    private Fitness fitness;

    public RegisterWindow(Fitness fitness)
    {
        InitializeComponent();
        fitness = fitness;
    }
    
    private void Button_Create_Click(object sender, RoutedEventArgs e)
    {
        string name = NameInput.Text;
        char gender = GenderInput.Text.Length > 0 ? GenderInput.Text[0] : 'M';
        if (!int.TryParse(AgeInput.Text, out int age))
        {
            MessageBox.Show("Alder skal være et tal.");
            return;
        }

        Member newMember = fitness.Register(name, gender, age);
        MessageBox.Show($"Bruger oprettet! ID = {newMember.id}");
        this.Close();
    }
}

