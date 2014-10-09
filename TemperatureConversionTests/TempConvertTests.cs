using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TemperatureConversion.Tests
{
	[TestClass()]
	public class TempConvertTests
	{
		/* Boiling @ Sea Level Tests */

		[TestMethod()] // C to F
		public void Boiling_CelciusToFahrenheitTest()
		{
			float celcius = 100.00f;
			float expected = 212.00f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.CelciusToFahrenheit(celcius).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // C to K
		public void Boiling_CelciusToKelvinTest()
		{
			float celcius = 100.00f;
			float expected = 373.15f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.CelciusToKelvin(celcius).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // F to C
		public void Boiling_FahrenheitToCelciusTest()
		{
			float fahrenheit = 212.00f;
			float expected = 100.00f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.FahrenheitToCelcius(fahrenheit).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // F to K
		public void Boiling_FahrenheitToKelvinTest()
		{
			float fahrenheit = 212.00f;
			float expected = 373.15f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.FahrenheitToKelvin(fahrenheit).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // K to C
		public void Boiling_KelvinToCelciusTest()
		{
			float kelvin = 373.15f;
			float expected = 100.00f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.KelvinToCelcius(kelvin).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // K to F
		public void Boiling_KelvinToFahrenheitTest()
		{
			float kelvin = 373.15f;
			float expected = 212.00f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.KelvinToFahrenheit(kelvin).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		/* Freezing at Sea Level */

		[TestMethod()] // C to F
		public void Freezing_CelciusToFahrenheitTest()
		{
			float celcius = 0.00f;
			float expected = 32.00f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.CelciusToFahrenheit(celcius).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // C to K
		public void Freezing_CelciusToKelvinTest()
		{
			float celcius = 0.00f;
			float expected = 273.15f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.CelciusToKelvin(celcius).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // F to C
		public void Freezing_FahrenheitToCelciusTest()
		{
			float fahrenheit = 32.00f;
			float expected = 0.00f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.FahrenheitToCelcius(fahrenheit).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // F to K
		public void Freezing_FahrenheitToKelvinTest()
		{
			float fahrenheit = 32.00f;
			float expected = 273.15f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.FahrenheitToKelvin(fahrenheit).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // K to C
		public void Freezing_KelvinToCelciusTest()
		{
			float kelvin = 273.15f;
			float expected = 0.00f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.KelvinToCelcius(kelvin).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // K to F
		public void Freezing_KelvinToFahrenheitTest()
		{
			float kelvin = 273.15f;
			float expected = 32.00f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.KelvinToFahrenheit(kelvin).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		/* Where Fahrenheit and Celcius are equal */

		[TestMethod()] // C to F
		public void Equal_CelciusToFahrenheitTest()
		{
			float celcius = -40.00f;
			float expected = -40.00f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.CelciusToFahrenheit(celcius).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // C to K
		public void Equal_CelciusToKelvinTest()
		{
			float celcius = -40.00f;
			float expected = 233.15f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.CelciusToKelvin(celcius).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // F to C
		public void Equal_FahrenheitToCelciusTest()
		{
			float fahrenheit = -40.00f;
			float expected = -40.00f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.FahrenheitToCelcius(fahrenheit).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // F to K
		public void Equal_FahrenheitToKelvinTest()
		{
			float fahrenheit = -40.00f;
			float expected = 233.15f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.FahrenheitToKelvin(fahrenheit).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // K to C
		public void Equal_KelvinToCelciusTest()
		{
			float kelvin = 233.15f;
			float expected = -40.00f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.KelvinToCelcius(kelvin).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // K to F
		public void Equal_KelvinToFahrenheitTest()
		{
			float kelvin = 233.15f;
			float expected = -40.00f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.KelvinToFahrenheit(kelvin).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		/* Absolute Zero */

		[TestMethod()] // C to F
		public void Zero_CelciusToFahrenheitTest()
		{
			float celcius = 0.00f;
			float expected = 32.00f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.CelciusToFahrenheit(celcius).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // C to K
		public void Zero_CelciusToKelvinTest()
		{
			float celcius = -273.15f;
			float expected = 0.00f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.CelciusToKelvin(celcius).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // F to C
		public void Zero_FahrenheitToCelciusTest()
		{
			float fahrenheit = -459.67f;
			float expected = -273.15f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.FahrenheitToCelcius(fahrenheit).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // F to K
		public void Zero_FahrenheitToKelvinTest()
		{
			float fahrenheit = -459.67f;
			float expected = 0.00f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.FahrenheitToKelvin(fahrenheit).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // K to C
		public void Zero_KelvinToCelciusTest()
		{
			float kelvin = 0.00f;
			float expected = -273.15f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.KelvinToCelcius(kelvin).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // K to F
		public void Zero_KelvinToFahrenheitTest()
		{
			float kelvin = 0.00f;
			float expected = -459.67f;
			TempConvert convert = new TempConvert();
			float actual = float.Parse(convert.KelvinToFahrenheit(kelvin).ToString("n2"));
			Assert.AreEqual(expected, actual);
		}
	}
}