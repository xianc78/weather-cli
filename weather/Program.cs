using System;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Xml;

namespace weather
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string station;
			try
			{
				station = args[0];
				// Connect to weather.gov
				WebClient client = new WebClient();
				client.Headers["User-Agent"] = "weatherClient";
				client.Headers["accept"] = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8\";";
				string data = client.DownloadString("https://w1.weather.gov/xml/current_obs/display.php?stid=" + station);

				// Parse XML
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.LoadXml(data);
				string credit = xmlDoc.GetElementsByTagName("credit")[0].InnerText;
				string location = xmlDoc.GetElementsByTagName("location")[0].InnerText;
				string temperature = xmlDoc.GetElementsByTagName("temperature_string")[0].InnerText;
				string overallWeather = xmlDoc.GetElementsByTagName("weather")[0].InnerText;
				string observationTime = xmlDoc.GetElementsByTagName("observation_time")[0].InnerText;
				string wind = xmlDoc.GetElementsByTagName("wind_string")[0].InnerText;
				string windChill = xmlDoc.GetElementsByTagName("windchill_string")[0].InnerText;
				string dewPoint = xmlDoc.GetElementsByTagName("dewpoint_string")[0].InnerText;
				string visibility = xmlDoc.GetElementsByTagName("visibility_mi")[0].InnerText;


				// Print results
				Console.WriteLine("Data provided by: " + credit);
				Console.WriteLine("Getting results from " + location);
				Console.WriteLine(observationTime);
				Console.WriteLine("----------------------------------------------");
				Console.WriteLine("Weather: " + overallWeather);
				Console.WriteLine("Temperature: " + temperature);
				Console.WriteLine("Wind: " + wind);
				Console.WriteLine("Wind chill: " + windChill);
				Console.WriteLine("Dew point: " + dewPoint);
				Console.WriteLine("Visibility: " + visibility);
			}
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine("You must enter a valid station id.");
				Environment.Exit(1);
			}


		}

		public void fetchData()
		{

		}
	}
}
