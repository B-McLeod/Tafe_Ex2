using System;

namespace TemperatureConversion
{
	public class TempConvert
	{
		public static float CelciusToFahrenheit(float celcius)
		{	// C to F
			float convertTempUnit = 1.8f;
			float result = celcius * convertTempUnit + 32f;
			return result;
		}

		public static float CelciusToKelvin(float celcius)
		{	// C to K
			float convertTempUnit = 273.15f;
			float result = celcius + convertTempUnit;
			return result;
		}

		public static float FahrenheitToCelcius(float fahrenheit)
		{	// F to C
			float convertTempUnit = 1.8f;
			float result = (fahrenheit - 32f) / convertTempUnit;
			return result;
		}

		public static float FahrenheitToKelvin(float fahrenheit)
		{	// F to K
			float convertTempUnit = 1.8f;
			float result = (fahrenheit - 32f) / convertTempUnit + 273.15f;
			return result;
		}

		public static float KelvinToCelcius(float kelvin)
		{	// K to C
			float convertTempUnit = 273.15f;
			float result = kelvin - convertTempUnit;
			return result;
		}

		public static float KelvinToFahrenheit(float kelvin)
		{	// K to F
			float convertTempUnit = 1.8f;
			float result = (kelvin - 273.15f) * convertTempUnit + 32f;
			return result;
		}
	}
}