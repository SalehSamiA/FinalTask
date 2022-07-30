using Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repoisitory
{
   public interface Icard_apirepoisitory
    {
        public string updateCard(card_Api back);
        public string insertCard(card_Api back);

        public string deleteCard(int id);

        public List<card_Api> getallCard();

        public card_Api getbyidserviceucard(int id);

    }
}
