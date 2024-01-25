using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppQuiz
{
   public class Pytanie
    {
        public string TrescPytania { get; set; }
        /*private string _trescPytania;
        public string TrescPytania
        {
            //get { return _trescPytania;}
            get => _trescPytania;
            //set => _trescPytania = value;
            set
            {
                _trescPytania = value;
            }
        }*/
        public bool PoprawnaOdpowiedz { get; set; }
        public bool UdzielonaOdpowiedz { get; set; }
        public bool CzyUdzielonaOdpowiedz { get; set; }

        public Pytanie(string trescPytania, bool poprawnaOdpowiedz)
        {
            TrescPytania = trescPytania;
            PoprawnaOdpowiedz = poprawnaOdpowiedz;
            UdzielonaOdpowiedz = !PoprawnaOdpowiedz;
            CzyUdzielonaOdpowiedz = false;
        }
    }
}
