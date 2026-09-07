using System.Collections.Generic;
using System.Linq;

namespace tech_titans
{
    // One line item in the cart: an event plus ticket quantities.
    public class CartItem
    {
        public Event Event { get; set; }
        public int AdultQty { get; set; }
        public int StudentQty { get; set; }
        public int FamilyQty { get; set; }
    }

    // Stores cart items while the application is running.
    public static class Cart
    {
        public static List<CartItem> Items { get; } = new List<CartItem>();

        public static CartItem FindByEventId(string eventId)
        {
            return Items.FirstOrDefault(i => i.Event.EventID == eventId);
        }

        public static void AddOrUpdate(
            Event evt,
            int adultQty,
            int studentQty,
            int familyQty)
        {
            CartItem existing = FindByEventId(evt.EventID);

            // If all quantities are zero, remove the event from the cart.
            if (adultQty == 0 &&
                studentQty == 0 &&
                familyQty == 0)
            {
                if (existing != null)
                {
                    Items.Remove(existing);
                }

                return;
            }

            if (existing != null)
            {
                existing.AdultQty = adultQty;
                existing.StudentQty = studentQty;
                existing.FamilyQty = familyQty;
            }
            else
            {
                Items.Add(new CartItem
                {
                    Event = evt,
                    AdultQty = adultQty,
                    StudentQty = studentQty,
                    FamilyQty = familyQty
                });
            }
        }

        public static void Remove(string eventId)
        {
            CartItem existing = FindByEventId(eventId);

            if (existing != null)
            {
                Items.Remove(existing);
            }
        }
    }
}