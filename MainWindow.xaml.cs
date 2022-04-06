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

namespace QuizApp
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Random randomId = new Random();

            int Id = randomId.Next(0, 2);

            BDDQuestion getQuestions = new BDDQuestion();

            List<string> list = getQuestions.getBDD(Id);

            questionApp.Text = list[0];
            answerApp1.Content = "A) "+list[1]+" ?";
            answerApp2.Content = "B) "+list[2]+" ?";
            answerApp3.Content = "C) "+list[3]+" ?";
            answerApp4.Content = "D) "+list[4]+" ?";

        }
    }
}
