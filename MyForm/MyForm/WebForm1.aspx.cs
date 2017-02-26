using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PodaciODrzavi"] == null)
            {
                Country country1 = new Country() { ID = "AUS", Ime = "AUSTRALIA", GlavniGrad = "Canberra" };
                Country country2 = new Country() { ID = "IND", Ime = "INDIA", GlavniGrad = "New Delhi" };
                Country country3 = new Country() { ID = "USA", Ime = "UNITED STATES", GlavniGrad = "Washington D.C." };
                Country country4 = new Country() { ID = "GBR", Ime = "UNITED KINGDOM", GlavniGrad = "London" };
                Country country5 = new Country() { ID = "CRO", Ime = "CROATIA", GlavniGrad = "Zagreb" };

                Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
                dictionaryCountries.Add(country1.ID, country1);
                dictionaryCountries.Add(country2.ID, country2);
                dictionaryCountries.Add(country3.ID, country3);
                dictionaryCountries.Add(country4.ID, country4);
                dictionaryCountries.Add(country5.ID, country5);

                Session["PodaciODrzavi"] = dictionaryCountries;//spremamo podatke u session jer ne zelimo da se svaki puta kada se stranica load-a kreira dictionary
            }
           
           
        }

        protected void txtID_TextChanged(object sender, EventArgs e)
        {
           Dictionary<string,Country> dictionaryCountries = (Dictionary<string,Country>)Session["PodaciODrzavi"];

            Country result = dictionaryCountries.ContainsKey(txtID.Text.ToUpper()) ? dictionaryCountries[txtID.Text.ToUpper()] : null;

            if (result == null)
            {
                lblMessage.Text = "Country id not valid!";
                txtGlavniGrad.Text = "";
                txtIme.Text = "";
            }
            else
            {
                txtIme.Text = result.Ime;
                txtGlavniGrad.Text = result.GlavniGrad;
                lblMessage.Text = "";
            }
            }
        }
    }
