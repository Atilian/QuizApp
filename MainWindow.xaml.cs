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
        private int IAnswer;

        List<int> indexNextQuestion = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
            Question();
        }

        public void Question()
        {

            Random randomId = new Random();

            int Id;
            do
            {
                Id = randomId.Next(0, 2);
            } while (this.indexNextQuestion.Contains(Id));
            this.indexNextQuestion.Add(Id);

            BDDQuestion getQuestions = new BDDQuestion();

            List<string> list = getQuestions.getBDD(Id);

            questionApp.Text = list[0];

            answerApp1.Content = "A) " + list[1] + " ?";
            answerApp2.Content = "B) " + list[2] + " ?";
            answerApp3.Content = "C) " + list[3] + " ?";
            answerApp4.Content = "D) " + list[4] + " ?";

            IAnswer = int.Parse(list[5]);
        }

        public void scoreAdd()
        {
            scoreView.Text = (int.Parse(scoreView.Text) + 1).ToString();
        }

        private void answer1(object sender, RoutedEventArgs e)
        {
            if(this.IAnswer == 1)
            {
                MessageBox.Show("Bravo !");
                scoreAdd();
            }
            else
            {
                MessageBox.Show("Dommage");
            }
            Question();
        }

        private void answer2(object sender, RoutedEventArgs e)
        {
            if (this.IAnswer == 2)
            {
                MessageBox.Show("Bravo !");
                scoreAdd();
            }
            else
            {
                MessageBox.Show("Dommage");
            }
            Question();
        }

        private void answer3(object sender, RoutedEventArgs e)
        {
            if (this.IAnswer == 3)
            {
                MessageBox.Show("Bravo !");
                scoreAdd();

            }
            else
            {
                MessageBox.Show("Dommage");
            }
            Question();
        }

        private void answer4(object sender, RoutedEventArgs e)
        {
            if (this.IAnswer == 4)
            {
                MessageBox.Show("Bravo !");
                scoreAdd();
            }
            else
            {
                MessageBox.Show("Dommage");
            }
            Question();
        }
    }
}
