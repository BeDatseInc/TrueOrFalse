using System;
using TrueOrFalse.ViewModel;
using Xamarin.Forms;

namespace TrueOrFalse.View
{
    public partial class QuestionPage : ContentPage
    {
        private CheckPhrase _checkPhrase;
        public QuestionPage(int num)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            _checkPhrase = new CheckPhrase {Num = num};
            this.BindingContext = _checkPhrase.PhraseViewModel = new PhraseViewModel();
            _checkPhrase.Initialize();
            _checkPhrase.PhraseViewModel.RightCommand = new Command(RightAnswer);
            _checkPhrase.PhraseViewModel.WrongCommand = new Command(WrongAnswer);
            _checkPhrase.PhraseViewModel.FinishCommand = new Command(FinishGame);
            InitializeComponent();
        }

        private async void RightAnswer()
        {
            await DisplayAlert(AppResources.Strings.RightTittle, AppResources.Strings.RightMessage,
                AppResources.Strings.Okay);
            _checkPhrase.LoadPhrase();
        }
        private async void WrongAnswer()
        {
            await DisplayAlert(AppResources.Strings.WrongTiitle, string.Format(
                AppResources.Strings.WrongMessage, _checkPhrase.PhraseViewModel.IsTrue ? 
                AppResources.Strings.True : AppResources.Strings.False), AppResources.Strings.Okay);
            _checkPhrase.LoadPhrase();
        }

        private async void FinishGame()
        {
            await DisplayAlert(AppResources.Strings.Tittle, string.Format(
                AppResources.Strings.FinishMessage, CheckPhrase.Right, CheckPhrase.Right > 1 ? "s" : ""), AppResources.Strings.Okay);

            await Navigation.PopAsync();
        }

       

        private void OnPageSizeChanged(object sender, EventArgs e)
        {
            TrueButton.HeightRequest = FalseButton.HeightRequest = Height/3;
            TrueButton.WidthRequest = FalseButton.WidthRequest = (Width - (Padding.Left + Padding.Right))/2 - 9;

            QuestionScrollView.HeightRequest = Height > Width ? 150 : 100;
        }

        
    }
}
