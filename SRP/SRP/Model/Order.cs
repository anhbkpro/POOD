namespace SRP.Model
{
    public abstract class Order
    {
        protected readonly Cart _cart;

        protected Order(Cart cart)
        {
            _cart = cart;
        }

        public virtual void Checkout()
        {
            // log the order to the database
        }
    }
}
