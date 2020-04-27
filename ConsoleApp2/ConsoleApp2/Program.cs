using System;
using System.Net.Http;

namespace ConsoleApp2
{
	class Program
	{
		static  void Main(string[] args)
		{
			test();

		}

		static async  void test()
		{
			using (var httpClient = new HttpClient())
			{
				using (var request = new HttpRequestMessage(new HttpMethod("GET"), "https://google.com"))
				{
					//request.Headers.TryAddWithoutValidation("Authorization", "Bearer YOUR_ACCESS_TOKEN");

					var response = await httpClient.SendAsync(request);
				}
			}
		}
	}
}
