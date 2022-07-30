using Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Service
{
   public interface Icardservice
    {
        public string updateCard(card_Api back);
        public string insertCard(card_Api back);

        public string deleteCard(int id);

        public List<card_Api> getallCard();

        public card_Api getbyidserviceucard(int id);

    }
}
