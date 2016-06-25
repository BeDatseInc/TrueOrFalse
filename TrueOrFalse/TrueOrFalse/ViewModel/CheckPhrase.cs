using System;
using System.Collections.Generic;
using System.Globalization;
using TrueOrFalse.Services;
using Xamarin.Forms;

namespace TrueOrFalse.ViewModel
{

    public class CheckPhrase
    {
        private int _index = 0;
        public static int Right = 0;
        private IList<Phrases> _list;
        private Random _random;
        public PhraseViewModel PhraseViewModel;
        
        public int Num { get; set; }
        public async void Initialize()
        {
            
            PhraseViewModel.ButtonCommand = new Command(ProcessCommand);
            
            _random = new Random();

            if (CultureInfo.CurrentCulture.Name == "pt-BR")
            {
                var data = new DataAccess<PhrasesPtBr>();

                _list = await data.GetPhrases(Num);

            }
            else
            {
                var data = new DataAccess<Phrases>();

                _list = await data.GetPhrases(Num);
            }


            if (_list != null)
            {
                LoadPhrase();
            }
            else
            {
                throw new Exception("Error to load phrases from database");
            }
        }
        public void LoadPhrase()
        {

            int i = _random.Next(_list.Count);

            if (_index >= Num)
            {
                PhraseViewModel.FinishCommand.Execute(null);
            }
            else if (_list.Count > 0 && _index >= 0 && _index < Num)
            {
                PhraseViewModel.Phrase = _list[i].Phrase;
                PhraseViewModel.IsTrue = _list[i].IsTrue;
                PhraseViewModel.QuestionsCount = $"{_index + 1}/{Num}";
                _list.RemoveAt(i);
            }
            
            

        }
        private void ProcessCommand(object obj)
        {
            CheckAsnwer((string)obj == "true");
            
        }

        public void CheckAsnwer(bool asnwer)
        {

            if (asnwer == PhraseViewModel.IsTrue)
            {
                Right++;
                PhraseViewModel.RightCommand.Execute(null);

            }
            else
            {
                PhraseViewModel.WrongCommand.Execute(null);
            }
            _index++;

        }
    }
}
