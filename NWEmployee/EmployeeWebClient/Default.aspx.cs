using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Common;
using System.Web.Services.Description;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NWEmployee;

namespace EmployeeWebClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetEmployee_Button_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeServiceClient client = new EmployeeServiceClient();
                if (client.State == CommunicationState.Faulted)
                    client = new EmployeeServiceClient();

                var employee = client.GetEmployee(int.Parse(EnterEmployeeID_TextBox.Text));
                DisplayEmployee_TextBox.Text = employee.EmployeeId.ToString();
                LastName_TextBox.Text = employee.LastName.Trim();
                FirstName_TextBox.Text = employee.LastName.Trim();
                Title_TextBox.Text = employee.Title.Trim();
                TitleOfCourtesy_TextBox.Text = employee.TitleOfCourtesy;
                BirthDate_TextBox.Text = (employee.BirthDate.ToString());
                HireDate_TextBox.Text = (employee.HireDate.ToString());
                Adress_TextBox.Text = employee.Address;
                City_TextBox.Text = employee.City;
                Region_TextBox.Text = employee.Region;
                PostalCode_TextBox.Text = employee.PostalCode;
                Country_TextBox.Text = employee.Country;
                HomePhone_TextBox.Text = employee.HomePhone;
                Extension_TextBox.Text = employee.Extension;
                Notes_TextBox.Text = employee.Notes;
                ReportsTo_TextBox.Text = employee.ReportsTo.ToString();
            }
            catch (FormatException ex)
            {
                Response.Write("Opps! Employeen finns inte! / felaktig data inmatad - ");
                Response.Write("Felmeddelande: ");
                Response.Write(ex.Message);
                Response.Write(" Börja om genom att klicka <a href='Default.aspx'>" +
                               "här.");
            }
            catch (NullReferenceException ex)
            {
                Response.Write("Opps! Employeen finns inte! - ");
                Response.Write("Felmeddelande: ");
                Response.Write(ex.Message);
                Response.Write(" Börja om genom att klicka <a href='Default.aspx'>" +
                               "här.");
            }
            catch (FaultException ex)
            {
                Response.Write("Opps! något gick fel! - ");
                Response.Write("Felmeddelande: ");
                Response.Write(ex.Message);
                Response.Write(" Börja om genom att klicka <a href='Default.aspx'>" +
                    "här.");
            }
           
        }

        protected void SaveEmployee_Button_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeServiceClient client = new EmployeeServiceClient();
                if (client.State == CommunicationState.Faulted)
                    client = new EmployeeServiceClient();

                MyEmployee employee = new MyEmployee();
                employee.EmployeeId = Convert.ToInt32(DisplayEmployee_TextBox.Text.Trim());
                employee.LastName = LastName_TextBox.Text.Trim();
                employee.FirstName = FirstName_TextBox.Text.Trim();
                employee.Title = Title_TextBox.Text.Trim();
                employee.TitleOfCourtesy = TitleOfCourtesy_TextBox.Text.Trim();
                employee.BirthDate = Convert.ToDateTime(BirthDate_TextBox.Text.Trim());
                employee.HireDate = Convert.ToDateTime(HireDate_TextBox.Text.Trim());
                employee.Address = Adress_TextBox.Text.Trim();
                employee.City = City_TextBox.Text.Trim();
                employee.Region = Region_TextBox.Text.Trim();
                employee.PostalCode = PostalCode_TextBox.Text.Trim();
                employee.Country = Country_TextBox.Text.Trim();
                employee.HomePhone = HomePhone_TextBox.Text.Trim();
                employee.Extension = Extension_TextBox.Text.Trim();
                employee.Notes = Notes_TextBox.Text.Trim();
                employee.ReportsTo = Convert.ToInt32(ReportsTo_TextBox.Text.Trim());

                client.SaveEmployee(employee);
                Response.Write("SPARAT!");
            }
            catch (FormatException ex)
            {
                Response.Write("Opps! Felaktig data inmatad - ");
                Response.Write("Felmeddelande: ");
                Response.Write(ex.Message);
                Response.Write(" Börja om genom att klicka <a href='Default.aspx'>" +
                    "här.");
            }
            catch (NullReferenceException ex)
            {
                Response.Write("Opps! Du måste sätta ett värde! - ");
                Response.Write("Felmeddelande: ");
                Response.Write(ex.Message);
                Response.Write(" Börja om genom att klicka <a href='Default.aspx'>" +
                    "här.");
            }

        }
    }
}