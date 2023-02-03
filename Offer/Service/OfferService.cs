using OfferMicroService.Model;

namespace OfferMicroService.Service
{
    public class OfferService
    {
        public static List<Offers> OfferDataList { get; }
        static OfferService()
        {
            OfferDataList = new List<Offers>
            {
                new Offers()
                {
                    Id = 1,
                    Discount = 25,
                    Title = "diwali dhamaka"
                },
                new Offers()
                {
                    Id = 1,
                    Discount = 15,
                    Title = "christmas sale"
                },
                new Offers()
                {
                    Id = 3,
                    Discount = 5,
                    Title = "august special"
                },
                new Offers()
                {
                    Id = 4,
                    Discount = 40,
                    Title = "crazy shopping sale"
                },
                new Offers()
                {
                    Id = 5,
                    Discount = 10,
                    Title = "holi sale"
                },
            };

        }
        static int nextofferId = 6;
        public static List<Offers> Get()
        {
            return OfferDataList;
        }
        public static Offers GetByID(int id)
        {
            return OfferDataList.FirstOrDefault(Offers=>Offers.Id==id);
        }
        public static Offers Post(Offers offer)
        {
            offer.Id = nextofferId++;
            OfferDataList.Add(offer);
            return offer;
        }
       public static void  DeleteById(int id)
        {

            var Offer = OfferDataList.FirstOrDefault(o => o.Id == id);
          
            OfferDataList.Remove(Offer);
            Offer.Id = nextofferId--;


        }

        public static Offers Update(int id, Offers offer)
        {
            var existingOffer = OfferDataList.FirstOrDefault(p => p.Id == id);
            if (existingOffer == null)
            {
                return null ;
            }
            existingOffer.Discount = offer.Discount;
            existingOffer.Title = offer.Title;
            return existingOffer;
        }

    
        public static Offers GetByOfferID(int id)
        {
            return OfferDataList.FirstOrDefault(Offers=>Offers.Id==id);
        }

    }
}
