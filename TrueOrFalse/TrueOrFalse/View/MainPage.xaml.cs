using System;
using TrueOrFalse.Model;
using Xamarin.Forms;

namespace TrueOrFalse
{
    public partial class MainPage : ContentPage
    {
        private DataAccess<Phrases> _data;
        private DataAccess<PhrasesPtBr> _dataPtBr;
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            VerifyUpdade();
        }

        private async void VerifyUpdade()
        {
            _data = new DataAccess<Phrases>();
            _dataPtBr = new DataAccess<PhrasesPtBr>();
            ActivityIndicator.IsVisible = true;
            await _data.Initialize();
            await _data.Sync();
            await _dataPtBr.Initialize();
            await _dataPtBr.Sync();
            ActivityIndicator.IsVisible = false;
        }
        private async void Button_OnClicked(object sender, EventArgs e)
        {
            ActivityIndicator.IsVisible = true;
            Button button = (Button)sender;

            try
            {
                int qtd = Int32.Parse(button.Text);
                await Navigation.PushAsync(new QuestionPage(qtd));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, AppResources.Strings.Cancel);
            }
            finally
            {
                QtdFrame.IsVisible = false;
                ActivityIndicator.IsVisible = false;
            }

        }

        private async void OnPlusButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestionCreatePage(), false);
        }

        private void FirstPage_OnSizeChanged(object sender, EventArgs e)
        {
            if (Height > Width)
            {
                AbsoluteLayout.SetLayoutBounds(TrueOrFalseImage, new Rectangle(0.5, 0.15, 1, 0.3));
            }
            else
            {
                AbsoluteLayout.SetLayoutBounds(TrueOrFalseImage, new Rectangle(0.5, -0.1, 0.5, 0.5));
            }
        }

        private void ButtonStart_OnClicked(object sender, EventArgs e)
        {
            QtdFrame.IsVisible = true;
        }
        

        private void OnFrameTapped(object sender, EventArgs e)
        {
            QtdFrame.IsVisible = false;
        }
    }
}
