using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diacritic_sensitivity
{
    public class ViewModel
    {
        private List<Model> diacriticCollenction;
        public List<Model> DiacriticCollenction
        {
            get { return diacriticCollenction; }

            set { diacriticCollenction = value; }
        }

        public ViewModel()
        {
            DiacriticCollenction = new List<Model>();
            DiacriticCollenction.Add(new Model { Item = "Hów tó gâin wéight?" });
            DiacriticCollenction.Add(new Model { Item = "Hów tó drâw ân éléphânt" });
            DiacriticCollenction.Add(new Model { Item = "Whéré cân I buy â câmérâ?" });
            DiacriticCollenction.Add(new Model { Item = "Guidé mé âll thé wây" });
            DiacriticCollenction.Add(new Model { Item = "Hów tó mâké â câké?" });
            DiacriticCollenction.Add(new Model { Item = "Sây, Hélló Wórld!" });
            DiacriticCollenction.Add(new Model { Item = "Hów tó mâké â róbót?" });
            DiacriticCollenction.Add(new Model { Item = "Whât timé nów in Indiâ?" });
        }
    }
}
