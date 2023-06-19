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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool turnX = true;
        private int moveCount = 0;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Content = turnX ? "X" : "0";
            button.IsEnabled = false;
            turnX = !turnX;
            moveCount++;
            CheckForWinner();
        }
        private void CheckForWinner()
        {
            // Проверяем строки
            for (int i = 0; i < 3; i++)
            {
                if (CheckRow(i))
                {
                    ShowWinMessage();
                    return;
                }
            }

            // Проверяем столбцы
            for (int i = 0; i < 3; i++)
            {
                if (CheckColumn(i))
                {
                    ShowWinMessage();
                    return;
                }
            }

            // Проверяем диагонали
            if (CheckDiagonals())
            {
                ShowWinMessage();
                return;
            }
        }
        private bool CheckRow(int row)
        {
            string firstButton = ((Button)FindName("btn" + row + "0")).Content?.ToString();
            string secondButton = ((Button)FindName("btn" + row + "1")).Content?.ToString();
            string thirdButton = ((Button)FindName("btn" + row + "2")).Content?.ToString();

            return !string.IsNullOrEmpty(firstButton) &&
            firstButton == secondButton &&
            firstButton == thirdButton;
        }
        private bool CheckColumn(int column)
        {
            string firstButton = ((Button)FindName("btn0" + column)).Content?.ToString();
            string secondButton = ((Button)FindName("btn1" + column)).Content?.ToString();
            string thirdButton = ((Button)FindName("btn2" + column)).Content?.ToString();

            return !string.IsNullOrEmpty(firstButton) &&
            firstButton == secondButton &&
            firstButton == thirdButton;
        }

        private bool CheckDiagonals()
        {
            string topLeftButton = ((Button)FindName("btn00")).Content?.ToString();
            string middleButton = ((Button)FindName("btn11")).Content?.ToString();
            string bottomRightButton = ((Button)FindName("btn22")).Content?.ToString();

            if (!string.IsNullOrEmpty(topLeftButton) &&
            topLeftButton == middleButton &&
            topLeftButton == bottomRightButton)
            {
                return true;
            }
            string topRightButton = ((Button)FindName("btn02")).Content?.ToString();
            string bottomLeftButton = ((Button)FindName("btn20")).Content?.ToString();

            if (!string.IsNullOrEmpty(topRightButton) &&
            topRightButton == middleButton &&
            topRightButton == bottomLeftButton)
            {
                return true;
            }

            return false;
        }


        private void ShowWinMessage()
        {
            MessageBox.Show((turnX ? "O" : "X") + " победил!");
            ResetGame();
        }

        private void ResetGame()
        {
            foreach (UIElement element in grid.Children)
            {
                if (element is Button)
                {
                    ((Button)element).Content = "";
                    ((Button)element).IsEnabled = true;
                }
            }

            turnX = true;
            moveCount = 0;
        }
    


        private void button4_Click(object sender, RoutedEventArgs e)
        {

            Button button = (Button)sender;
            button.Content = turnX ? "X" : "0";
            button.IsEnabled = false;
            turnX = !turnX;
            moveCount++;
            CheckForWinner();

        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void buttton11_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Content = turnX ? "X" : "0";
            button.IsEnabled = false;
            turnX = !turnX;
            moveCount++;
            CheckForWinner();
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Content = turnX ? "X" : "0";
            button.IsEnabled = false;
            turnX = !turnX;
            moveCount++;
            CheckForWinner();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Content = turnX ? "X" : "0";
            button.IsEnabled = false;
            turnX = !turnX;
            moveCount++;
            CheckForWinner();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Content = turnX ? "X" : "0";
            button.IsEnabled = false;
            turnX = !turnX;
            moveCount++;
            CheckForWinner();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Content = turnX ? "X" : "0";
            button.IsEnabled = false;
            turnX = !turnX;
            moveCount++;
            CheckForWinner();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Content = turnX ? "X" : "0";
            button.IsEnabled = false;
            turnX = !turnX;
            moveCount++;
            CheckForWinner();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Content = turnX ? "X" : "0";
            button.IsEnabled = false;
            turnX = !turnX;
            moveCount++;
            CheckForWinner();
        }

        private void reset_Click_1(object sender, RoutedEventArgs e)
        {
            ResetGame();
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            Button move = null;

            foreach (var child in grid.Children)
            {
                var button = child as Button;
                if (button != null && button.IsEnabled)
                {
                    move = button;
                    break;
                }
            }

            if (move != null)
            {
                move.Content = "O";
                move.IsEnabled = false;
                moveCount++;
                CheckForWinner();
                turnX = !turnX;
            }
        }
        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            ResetGame();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewComlieterPlay_Click(object sender, RoutedEventArgs e)
        {
            Button move = null;

            foreach (var child in grid.Children)
            {
                var button = child as Button;
                if (button != null && button.IsEnabled)
                {
                    move = button;
                    break;
                }
            }

            if (move != null)
            {
                move.Content = "O";
                move.IsEnabled = false;
                moveCount++;
                CheckForWinner();
                turnX = !turnX;
            }
        }
    }
}
