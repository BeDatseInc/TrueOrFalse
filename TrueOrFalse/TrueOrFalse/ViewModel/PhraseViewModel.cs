using System.Windows.Input;

namespace TrueOrFalse.ViewModel
{
    public class PhraseViewModel : ViewModelBase
    {
        private string _phrase;
        private bool _isTrue;
        private string _questionsCount;

        public string Phrase
        {
            get { return _phrase; }
            set { SetProperty(ref _phrase, value); }
        }

        public bool IsTrue
        {
            get { return _isTrue; }
            set { SetProperty(ref _isTrue, value); }
        }
        public string QuestionsCount
        {
            get { return _questionsCount; }
            set { SetProperty(ref _questionsCount, value); }
        }

        public ICommand ButtonCommand { get; set; }
        public ICommand RightCommand { get; set; }
        public ICommand WrongCommand { get; set; }
        public ICommand FinishCommand { get; set; }
    }
}
