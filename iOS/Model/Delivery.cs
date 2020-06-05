using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starbox.iOS;

namespace Starbox.Model
{
    public class Delivery
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public int Status { get; set; }
        public string Size { get; set; }
        public string Extras { get; set; }
        public string Username { get; set; }

        public static async Task<bool> MarkAsDelivered(Delivery delivery)
        {
            try
            {
                delivery.Status = 2;
                await AppDelegate.MobileService.GetTable<Delivery>().UpdateAsync(delivery);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static async Task<bool> MarkAsDelivered(string deliveryId)
        {
            try
            {
                var delivery = (await AppDelegate.MobileService.GetTable<Delivery>().Where(d => d.Id == deliveryId).ToListAsync()).FirstOrDefault(); ;
                delivery.Status = 2;
                await AppDelegate.MobileService.GetTable<Delivery>().UpdateAsync(delivery);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static async Task<List<Delivery>> GetDeliveries()
        {
            List<Delivery> deliveries = new List<Delivery>();

            if(AppDelegate.user.Id == "4788eabf-0fe0-4cf4-b12a-b1272063a55e")
            {
                deliveries = await AppDelegate.MobileService.GetTable<Delivery>().Where(d => d.Status == 0).ToListAsync();

            }
            else
            {
               deliveries = await AppDelegate.MobileService.GetTable<Delivery>().Where(d => d.UserId == AppDelegate.user.Id && d.Status == 0).ToListAsync();
            }

            return deliveries;
        }

        public static async Task<List<Delivery>> GetDelivered()
        {
            List<Delivery> deliveries = new List<Delivery>();

            if (AppDelegate.user.Id == "4788eabf-0fe0-4cf4-b12a-b1272063a55e")
            {
                deliveries = await AppDelegate.MobileService.GetTable<Delivery>().Where(d => d.Status == 2).ToListAsync();

            }

            else
            {
                deliveries = await AppDelegate.MobileService.GetTable<Delivery>().Where(d => d.UserId == AppDelegate.user.Id && d.Status == 2).ToListAsync();
            }

            return deliveries;
        }

        public static async Task<List<Delivery>> GetWaiting()
        {
            List<Delivery> deliveries = new List<Delivery>();

            deliveries = await AppDelegate.MobileService.GetTable<Delivery>().Where(d => d.Status == 0).ToListAsync();

            return deliveries;
        }

        public static async Task<bool> InsertDelivery(Delivery delivery)
        {
            return await AppDelegate.Insert<Delivery>(delivery);
        }

        public override string ToString()
        {
            return $"{Name} - {Status}";
        }
    }
}

