using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Diagnostics;

namespace SessionWebSite.Pages
{
    public class IndexModel : PageModel
    {
        public List<Smeshariki> smesharikis { get; set; } = new List<Smeshariki>();
        public async Task<IActionResult> OnGetAsync()
        {
            smesharikis = await GetDataApi();
            Debug.Write(smesharikis.Count);
            return Page();
        }
        public async Task<List<Smeshariki>> GetDataApi()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(@"https://localhost:7241/getSmeshariki");
            var json = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<List<Smeshariki>>(json);

        }
    }
}
