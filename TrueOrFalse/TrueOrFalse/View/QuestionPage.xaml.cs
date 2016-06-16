using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TrueOrFalse
{
    public partial class QuestionPage : ContentPage
    {
        private int _num = 0;
        private int _index = 0;
        private int _right = 0;
        private bool _isTrue;
        private List<Phrases> list;
        private Random random;

        public QuestionPage(int num)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            random = new Random();
            _num = num;

            using (DataAccess data = new DataAccess())
            {
                list = data.GetListPhrases(num);
            }
            if (list != null)
            {
                LoadPhrase();
            }
            else
            {
                throw new Exception("Error to load phrases from database");
            }
        }


        void LoadPhrase()
        {

            int i = random.Next(list.Count);
            if (list.Count > 0 && _index >= 0 && _index < _num)
            {
                Question.Text = list[i].Phrase;
                _isTrue = list[i].IsTrue;
                list.RemoveAt(i);
                CountPhrases.Text = $"{_index + 1}/{_num}";
            }

        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if ((button.Text == "True" && _isTrue == true) || (button.Text == "False" && _isTrue == false))
            {
                await DisplayAlert(AppResources.Strings.RightTittle, AppResources.Strings.RightMessage,
                        AppResources.Strings.Okay);
                _right++;
            }
            else
            {
                await DisplayAlert(AppResources.Strings.WrongTiitle,
                        String.Format(AppResources.Strings.WrongMessage, _isTrue), AppResources.Strings.Okay);
            }
            if (list.Count <= 0)
            {
                await
                    DisplayAlert(AppResources.Strings.Tittle,
                        String.Format(AppResources.Strings.FinishMessage, _right, _right > 1 ? "s" : ""),
                        AppResources.Strings.Okay);

                await Navigation.PopAsync();

            }
            else
            {
                _index++;
                LoadPhrase();
            }

        }

        private void OnPageSizeChanged(object sender, EventArgs e)
        {
            TrueButton.HeightRequest = FalseButton.HeightRequest = Height/3;
            TrueButton.WidthRequest = FalseButton.WidthRequest = (Width - (Padding.Left + Padding.Right))/2 - 9;

            QuestionScrollView.HeightRequest = Height > Width ? 150 : 100;
        }
    }
}
