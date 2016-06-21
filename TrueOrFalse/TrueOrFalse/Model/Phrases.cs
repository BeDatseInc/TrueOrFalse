

namespace TrueOrFalse
{
    public class Phrases
    {
        [Newtonsoft.Json.JsonProperty("Id")]
        public string Id
        {
            get;
            set;
        }

        [Microsoft.WindowsAzure.MobileServices.Version]
        public string AzureVersion { get; set; }

        public string Phrase
        {
            get;
            set;
        }

        

        public bool IsTrue
        {
            get;
            set;
        }

        public bool IsCustom
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"{Phrase}";
            //string.Format("Phrase = {0}, Is True = {1}, Is Custom = {2}", Phrase, IsTrue, IsCustom);
        }

    }

    public class PhrasesPtBr : Phrases {}
}
