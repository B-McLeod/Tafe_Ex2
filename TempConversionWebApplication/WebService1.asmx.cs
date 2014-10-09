using System.Web.Services;
using TemperatureConversion;

namespace TempConversionWebApplication
{
	/// <summary>
	/// Summary description for WebService1
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
	// [System.Web.Script.Services.ScriptService]
	public class WebService1 : System.Web.Services.WebService
	{
		[WebMethod]
		public float CelciusToFahrenheit(float temp)
		{
			return TempConvert.CelciusToFahrenheit(temp);
		}

		[WebMethod]
		public float CelciusToKelvin(float temp)
		{
			return TempConvert.CelciusToKelvin(temp);
		}

		[WebMethod]
		public float FahrenheitToCelcius(float temp)
		{
			return TempConvert.FahrenheitToCelcius(temp);
		}

		[WebMethod]
		public float FahrenheitToKelvin(float temp)
		{
			return TempConvert.FahrenheitToKelvin(temp);
		}

		[WebMethod]
		public float KelvintoCelcius(float temp)
		{
			return TempConvert.KelvinToCelcius(temp);
		}

		[WebMethod]
		public float KelvinToFahrenheit(float temp)
		{
			return TempConvert.KelvinToFahrenheit(temp);
		}
	}
}