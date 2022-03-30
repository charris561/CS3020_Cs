namespace EventsMyDude
{
    /// <summary>
    /// Used as an example for events!
    /// </summary>
    public class Kitchen
    {

        public delegate void OrderReceivedEventHandler(object sender, KitchenEventArgs e);
        public OrderReceivedEventHandler? OrderReceived;

        List<string> orderItems = new List<string>() { "Soup", "Cheeseburger Soup", "Null Soup", "Void Soup" };

        /// <summary>
        /// An order has been received!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void OnOrderReceived(object sender, KitchenEventArgs e) 
        {

            OrderReceived?.Invoke(sender, e);

        }

        public void OrderHasBeenPlaced()
        { 

            KitchenEventArgs e = new KitchenEventArgs(orderItems);
            OnOrderReceived(this, e);

        }

    }
}
