
using PaymentMicroService.Models;

namespace PaymentMicroService.Service
{
    public class PaymentService
    {
        public static List<PaymentMethod> PaymentMethodDataList { get; }
        static PaymentService()
        {
            PaymentMethodDataList = new List<PaymentMethod>
            {
                new PaymentMethod
                {
                   Id= 1,
                   Type="Cash",
                    Provider="Self",
                   Available= true,
                    Reason="",
                    },
                 new PaymentMethod
                {
                   Id= 2,
                   Type="Card Payment",
                    Provider="Bank",
                   Available= true,
                    Reason="",
                    },
                  new PaymentMethod
                {
                   Id= 3,
                   Type="Net Banking",
                    Provider="SBI",
                   Available= true,
                    Reason="",
                    },
                   new PaymentMethod
                {
                   Id= 4,
                   Type="Net Banking",
                    Provider="ICICI",
                   Available= true,
                    Reason="",
                    },
                    new PaymentMethod
                {
                   Id= 5,
                   Type="Net Bankin",
                    Provider="Bank of Maharashtra",
                   Available= false,
                    Reason="server down",
                    },
                   new PaymentMethod
                {
                   Id= 6,
                   Type="UPI",
                    Provider="Google Pay",
                   Available= true,
                    Reason="",
                    },


};



    }

        public static List<PaymentMethod> Get()
        {
            return PaymentMethodDataList;
        }
        public static PaymentMethod GetByID(int id)
        {
            return PaymentMethodDataList.FirstOrDefault(PaymentMethod=>PaymentMethod.Id==id);
        }

    }
}
