using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Configuration;

namespace NorthwindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShipperService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ShipperService.svc or ShipperService.svc.cs at the Solution Explorer and start debugging.
    public class ShipperService : IShipperService
    {
        public NORTHWNDEntities context = new NORTHWNDEntities();
        public MyShipper GetShipper(int shipperId)
        {
            try
            {
                var newshipper = context.Shippers.SingleOrDefault(s => s.ShipperID == shipperId);
                MyShipper shipper = new MyShipper();
                if (newshipper != null)
                {
                    shipper.ShipperId = newshipper.ShipperID;
                    shipper.CompanyName = newshipper.CompanyName;
                    shipper.Phone = newshipper.Phone;
                }
                return shipper;
            }
            catch (CommunicationException ex)
            {
                
                throw new Exception(ex.Message);
            }
            
        }

        public void SaveShipper(MyShipper shipper) {
            try
            {
                var nwshipper = context.Shippers.SingleOrDefault(s => s.ShipperID == shipper.ShipperId);
                if (nwshipper != null)
                {
                    nwshipper.Phone = shipper.Phone;
                    nwshipper.CompanyName = shipper.CompanyName;
                }
                context.SaveChanges();
            }
            catch (CommunicationException ex)
            {

                throw new Exception(ex.Message);
            }
           
        }
    }
}
