using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WordPuzzle.Models
{
	public class RandomWordHelper
	{
		static internal HttpClient _client = new();

		public RandomWordHelper()
		{
			_client.BaseAddress = new Uri("https://random-word-api.herokuapp.com/word");
			_client.DefaultRequestHeaders.Accept.Clear();
			_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		}
		async public Task<string> GetWordAsync()
		{
			string parameters = "";
			
			HttpResponseMessage response = await _client.GetAsync(parameters);
			
			if (response.IsSuccessStatusCode)
			{
				string jsonString = await response.Content.ReadAsStringAsync();
				return Regex.Match(jsonString, "\"[^\"]*\"").Value;
			}
			return "";
		}
	}
}