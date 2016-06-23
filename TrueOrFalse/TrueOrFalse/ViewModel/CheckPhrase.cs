using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading.Tasks;
using TrueOrFalse.Model;
using Xamarin.Forms;

namespace TrueOrFalse.ViewModel
{

    public class CheckPhrase
    {
        private int _index = 0;
        public static int Right = 0;
        private IList<Phrases> list;
        private Random random;
        public PhraseViewModel PhraseViewModel;
        
        public int Num { get; set; }
        public async void Initialize()
        {
            
            PhraseViewModel.ButtonCommand = new Command(ProcessCommand);
            
            random = new Random();

            if (CultureInfo.CurrentCulture.Name == "pt-BR")
            {
                var data = new DataAccess<PhrasesPtBr>();

                list = await data.GetPhrases(Num);

            }
            else
            {
                var data = new DataAccess<Phrases>();

                list = await data.GetPhrases(Num);
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
        public void LoadPhrase()
        {

            int i = random.Next(list.Count);

            if (_index >= Num)
            {
                PhraseViewModel.FinishCommand.Execute(null);
            }
            else if (list.Count > 0 && _index >= 0 && _index < Num)
            {
                PhraseViewModel.Phrase = list[i].Phrase;
                PhraseViewModel.IsTrue = list[i].IsTrue;
                PhraseViewModel.QuestionsCount = $"{_index + 1}/{Num}";
                list.RemoveAt(i);
            }
            
            

        }
        private void ProcessCommand(object obj)
        {
            CheckAsnwer((string)obj == "true");
            
        }

        public void CheckAsnwer(bool asnwer)
        {
            try
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
            catch (Exception ex)
            {
                Debug.WriteLine($"Erro ao exibir display alert, mensagem: {ex}");
            }
        }
        
    }
}
