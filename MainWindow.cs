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

namespace MathTootyBoi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        double RandomNumber1 = 0;
        double RandomNumber2 = 0;
        string Operation = "";
        double Counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            NewQuestion();
        }
      private void btnCheckAnswer_Click(object sender, RoutedEventArgs e)
        {
            if (Counter == 0)
            {
                string InputAnswer = UserInput.Text;
                double UserAnswer = 0;
                double.TryParse(InputAnswer, out UserAnswer);

                double ActualAnswer = 0;
                if (Operation == "/")
                {
                    ActualAnswer = RandomNumber1 / RandomNumber2;
                }
                else if (Operation == "*")
                {
                    ActualAnswer = RandomNumber1 * RandomNumber2;
                }
                else if (Operation == "+")
                {
                    ActualAnswer = RandomNumber1 + RandomNumber2;
                }
                else if (Operation == "-")
                {
                    ActualAnswer = RandomNumber1 - RandomNumber2;
                }
                if (UserAnswer == ActualAnswer)
                {
                    lblQuestion.Content = "Good Job! ☺";
                }
                else
                {
                    lblQuestion.Content = "WRONG! YOU FAIL!";
                }
                Counter++;
            }
            else
            {
                NewQuestion();
                Counter = 0;
            }

        }
        public void NewQuestion()
        {
            Operation = ChooseOperator(Operation);
            string Question = "";
            RandomNumber1 = random.Next(1, 11);
            RandomNumber2 = random.Next(1, 11);
            Question = RandomNumber1 + " " + Operation + " " + RandomNumber2;
            lblQuestion.Content = Question;
        }
        public string ChooseOperator(string operation)
        {
            int RandomNumber = random.Next(1, 5);

            if (RandomNumber == 1)
            {
                operation = "+";
                return operation;
            }
            else if (RandomNumber == 2)
            {

                operation = "-";
                return operation;
            }
            else if (RandomNumber == 3)
            {

                operation = "/";
                return operation;
            }
            else 
            {

                operation = "*";
                return operation;
            }
           
        }

    }
}
