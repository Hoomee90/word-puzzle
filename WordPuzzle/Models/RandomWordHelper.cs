using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WordPuzzle.Models
{
	public class RandomWordHelper
	{
		private static readonly string _url = "https://random-word-api.herokuapp.com/word";
		private static readonly string _parameters = "?length=6";
		private static HttpClient _client = new() { BaseAddress = new Uri(_url) };
		public async static  Task<string> GetWordAsync()
		{
			HttpResponseMessage response = await _client.GetAsync(_parameters);
			
			if (response.IsSuccessStatusCode)
			{
				string jsonString = await response.Content.ReadAsStringAsync();
				return Regex.Match(jsonString, @"\w+").Value;
			}
			return null;
		}
	}
}