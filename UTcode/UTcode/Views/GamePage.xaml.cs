using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UTcode.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePage : ContentPage
    {
        int correctNumber;
        int minRange = 1;
        int maxRange = 100;
        int minNumber = 0;
        int maxNumber = 100;
        int guessCount = 0;
        public GamePage()
        {
            InitializeComponent();
            StartNewGame();
        }

        void StartNewGame()
        {
            correctNumber = new Random().Next(minRange, maxRange-1);
            guessCount = 0;
            lblResult.Text = $"猜一個數字，範圍是 {minNumber} 到 {maxNumber} 之間";
            lblAnswar.Text = "答案是:" + correctNumber.ToString();
        }

        private void OnGuessButtonClick(object sender, EventArgs e)
        {
            int playerGuess;

            if (int.TryParse(entryGuess.Text, out playerGuess))
            {
                guessCount++;
                if (playerGuess == correctNumber)
                {
                    lblNumber.Text = "恭喜您猜對了！";
                }
                else if(playerGuess > maxNumber || playerGuess < minNumber)
                {
                    lblNumber.Text = "請輸入有效的數字";
                }
                else
                {
                    if (playerGuess - correctNumber > 0)
                    {
                        maxNumber = playerGuess;
                        lblResult.Text = $"猜一個數字，範圍是 {minNumber} 到 {maxNumber} 之間";
                    }
                    else if (playerGuess - correctNumber< 0)
                    {
                        minNumber = playerGuess;
                        lblResult.Text = $"猜一個數字，範圍是 {minNumber} 到 {maxNumber} 之間";
                    }
                }                
            }
            else
            {
                lblNumber.Text = "請輸入有效的數字";
            }

            entryGuess.Text = "";
        }

        private void OnReturnButtonClick(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}