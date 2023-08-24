using ExchangeRateSoap;
using System.Security.Cryptography;

namespace testforbank
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        List<ExchangeRate> x;
       public async Task rates()
        {
          
            ExchangeRates ex = new ExchangeRates();
            GateSoapClient soap = new GateSoapClient(GateSoapClient.EndpointConfiguration.GateSoap);
            await soap.OpenAsync();
            ex = await soap.ExchangeRatesLatestAsync();

            foreach (var item in ex.Rates)
            {
                x.Add(item);
            }
            await soap.CloseAsync();

        }
        public MainPage()
        {
            InitializeComponent();
           x = new List<ExchangeRate>();
            rates();

        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
           

            Label1.Text = $"{Convert.ToString(Convert.ToDouble(x.FirstOrDefault(x => x.ISO.Equals("USD")).Rate))} $";
            Label2.Text = $"{Convert.ToString(Convert.ToDouble(x.FirstOrDefault(x => x.ISO.Equals("RUB")).Rate))} ₽";
            Label3.Text = $"{Convert.ToString(Convert.ToDouble(x.FirstOrDefault(x => x.ISO.Equals("EUR")).Rate))} €";
        }
    }
}