using CartMicroservice.Model;
using CartMicroService.Model;

namespace CartMicroservice.Service
{
    public class CartService
    {
        private  List<CartItem> cartItem = new List<CartItem>() {
            new CartItem()
            {

            }
        
        
        };
        private List<Cart> cart = new List<Cart>();

        
       public List<Cart> GetAllCartItems()
        {
            return cart;    
        }
        


        /*public List<CartItem> GetAll()
        {
            return cartItem;
        }*/

        public void Add(CartItem item)
        {
            cartItem.Add(item);
        }

        public void Update(CartItem item)
        {
            var cartItems = cartItem.FirstOrDefault(x => x.Id ==item.Id );
            if (cartItems!= null)
            {
                cartItems.Product.Quantity = item.Product.Quantity;
            }
        }
       
        public void Delete(CartItem item)
        {
            cartItem.Remove(item);
        }
    }
}

