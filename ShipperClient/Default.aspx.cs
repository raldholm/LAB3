using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using ShipperClient.NwService;


namespace ShipperClient
{
    public partial class Default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetShipper_Button_Click(object sender, EventArgs e)
        {
            NwService.ShipperServiceClient client = new NwService.ShipperServiceClient();
            var shipper = client.GetShipper(int.Parse(EnterShipperID_TextBox.Text));
            DisplayShipperID_TextBox.Text = shipper.ShipperId.ToString();
            CompanyName_TextBox.Text = shipper.CompanyName.Trim();
            Phone_TextBox.Text = shipper.Phone.Trim();

        }

        protected void SaveShipper_Button_Click(object sender, EventArgs e)
        {
            NwService.ShipperServiceClient client = new NwService.ShipperServiceClient();
            MyShipper shippe = new MyShipper();
            shippe.ShipperId = Convert.ToInt32(DisplayShipperID_TextBox.Text.Trim());
            shippe.CompanyName = CompanyName_TextBox.Text.Trim();
            shippe.Phone = Phone_TextBox.Text.Trim();
            client.SaveShipper(shippe);
        }
    }
}