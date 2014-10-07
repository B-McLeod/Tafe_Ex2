using System;

namespace TemperatureConversion
{
	public class TempConvert
	{
		public double CelciusToFahrenheit(double celcius)
		{	// C to F
			double convertTempUnit = 1.8;
			double result = celcius * convertTempUnit + 32;
			return result;
		}

		public double CelciusToKelvin(double celcius)
		{	// C to K
			double convertTempUnit = 273.15;
			double result = celcius + convertTempUnit;
			return result;
		}

		public double FahrenheitToCelcius(double fahrenheit)
		{	// F to C
			double convertTempUnit = 1.8;
			double result = (fahrenheit - 32) / convertTempUnit;
			result = Math.Truncate(100 * result) / 100;
			return result;
		}

		public double FahrenheitToKelvin(double fahrenheit)
		{	// F to K
			double convertTempUnit = 1.8;
			double result = (fahrenheit - 32) / convertTempUnit + 273.15;
			result = Math.Truncate(1000 * result) / 1000;
			return result;
		}

		public double KelvinToCelcius(double kelvin)
		{	// K to C
			double convertTempUnit = 273.15;
			double result = kelvin - convertTempUnit;
			return result;
		}

		public double KelvinToFahrenheit(double kelvin)
		{	// K to F
			double convertTempUnit = 1.8;
			double result = (kelvin - 273.15) * convertTempUnit + 32;
			result = Math.Truncate(1000 * result) / 1000;
			return result;
		}
	}
}