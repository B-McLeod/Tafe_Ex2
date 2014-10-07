using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureConversion;
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
			double celcius = 100.00;
			double expected = 212.00;
			TempConvert convert = new TempConvert();
			double actual = convert.CelciusToFahrenheit(celcius);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // C to K
		public void Boiling_CelciusToKelvinTest()
		{
			double celcius = 100.00;
			double expected = 373.15;
			TempConvert convert = new TempConvert();
			double actual = convert.CelciusToKelvin(celcius);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // F to C
		public void Boiling_FahrenheitToCelciusTest()
		{
			double fahrenheit = 212.00;
			double expected = 100.00;
			TempConvert convert = new TempConvert();
			double actual = convert.FahrenheitToCelcius(fahrenheit);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // F to K
		public void Boiling_FahrenheitToKelvinTest()
		{
			double fahrenheit = 212.00;
			double expected = 373.15;
			TempConvert convert = new TempConvert();
			double actual = convert.FahrenheitToKelvin(fahrenheit);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // K to C
		public void Boiling_KelvinToCelciusTest()
		{
			double kelvin = 373.15;
			double expected = 100.00;
			TempConvert convert = new TempConvert();
			double actual = convert.KelvinToCelcius(kelvin);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // K to F
		public void Boiling_KelvinToFahrenheitTest()
		{
			double kelvin = 373.15;
			double expected = 212.00;
			TempConvert convert = new TempConvert();
			double actual = convert.KelvinToFahrenheit(kelvin);
			Assert.AreEqual(expected, actual);
		}

		/* Freezing at Sea Level */

		[TestMethod()] // C to F
		public void Freezing_CelciusToFahrenheitTest()
		{
			double celcius = 0.00;
			double expected = 32.00;
			TempConvert convert = new TempConvert();
			double actual = convert.CelciusToFahrenheit(celcius);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // C to K
		public void Freezing_CelciusToKelvinTest()
		{
			double celcius = 0.00;
			double expected = 273.15;
			TempConvert convert = new TempConvert();
			double actual = convert.CelciusToKelvin(celcius);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // F to C
		public void Freezing_FahrenheitToCelciusTest()
		{
			double fahrenheit = 32.00;
			double expected = 0.00;
			TempConvert convert = new TempConvert();
			double actual = convert.FahrenheitToCelcius(fahrenheit);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // F to K
		public void Freezing_FahrenheitToKelvinTest()
		{
			double fahrenheit = 32.00;
			double expected = 273.15;
			TempConvert convert = new TempConvert();
			double actual = convert.FahrenheitToKelvin(fahrenheit);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // K to C
		public void Freezing_KelvinToCelciusTest()
		{
			double kelvin = 273.15;
			double expected = 0.00;
			TempConvert convert = new TempConvert();
			double actual = convert.KelvinToCelcius(kelvin);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // K to F
		public void Freezing_KelvinToFahrenheitTest()
		{
			double kelvin = 273.15;
			double expected = 32.00;
			TempConvert convert = new TempConvert();
			double actual = convert.KelvinToFahrenheit(kelvin);
			Assert.AreEqual(expected, actual);
		}

		/* Where Fahrenheit and Celcius are equal */

		[TestMethod()] // C to F
		public void Equal_CelciusToFahrenheitTest()
		{
			double celcius = -40.00;
			double expected = -40.00;
			TempConvert convert = new TempConvert();
			double actual = convert.CelciusToFahrenheit(celcius);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // C to K
		public void Equal_CelciusToKelvinTest()
		{
			double celcius = -40.00;
			double expected = 233.14999999999998;
			TempConvert convert = new TempConvert();
			double actual = convert.CelciusToKelvin(celcius);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // F to C
		public void Equal_FahrenheitToCelciusTest()
		{
			double fahrenheit = -40.00;
			double expected = -40.00;
			TempConvert convert = new TempConvert();
			double actual = convert.FahrenheitToCelcius(fahrenheit);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // F to K
		public void Equal_FahrenheitToKelvinTest()
		{
			double fahrenheit = -40.00;
			double expected = 233.149;
			TempConvert convert = new TempConvert();
			double actual = convert.FahrenheitToKelvin(fahrenheit);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // K to C
		public void Equal_KelvinToCelciusTest()
		{
			double kelvin = 233.150;
			double expected = -39.999999999999972;
			TempConvert convert = new TempConvert();
			double actual = convert.KelvinToCelcius(kelvin);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // K to F
		public void Equal_KelvinToFahrenheitTest()
		{
			double kelvin = 233.15;
			double expected = -39.999;
			TempConvert convert = new TempConvert();
			double actual = convert.KelvinToFahrenheit(kelvin);
			Assert.AreEqual(expected, actual);
		}

		/* Absolute Zero */

		[TestMethod()] // C to F
		public void Zero_CelciusToFahrenheitTest()
		{
			double celcius = 0.00;
			double expected = 32.00;
			TempConvert convert = new TempConvert();
			double actual = convert.CelciusToFahrenheit(celcius);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // C to K
		public void Zero_CelciusToKelvinTest()
		{
			double celcius = -273.15;
			double expected = 0.00;
			TempConvert convert = new TempConvert();
			double actual = convert.CelciusToKelvin(celcius);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // F to C
		public void Zero_FahrenheitToCelciusTest()
		{
			double fahrenheit = -459.67;
			double expected = -273.14;
			TempConvert convert = new TempConvert();
			double actual = convert.FahrenheitToCelcius(fahrenheit);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // F to K
		public void Zero_FahrenheitToKelvinTest()
		{
			double fahrenheit = -459.67;
			double expected = 0.00;
			TempConvert convert = new TempConvert();
			double actual = convert.FahrenheitToKelvin(fahrenheit);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // K to C
		public void Zero_KelvinToCelciusTest()
		{
			double kelvin = 0.00;
			double expected = -273.15;
			TempConvert convert = new TempConvert();
			double actual = convert.KelvinToCelcius(kelvin);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()] // K to F
		public void Zero_KelvinToFahrenheitTest()
		{
			double kelvin = 0.00;
			double expected = -459.669;
			TempConvert convert = new TempConvert();
			double actual = convert.KelvinToFahrenheit(kelvin);
			Assert.AreEqual(expected, actual);
		}
	}
}
