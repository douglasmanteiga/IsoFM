using System.Web.Mvc;

namespace IsoFM.WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //string baseurl = "https://iws-recruiting-bands.herokuapp.com/";
        // GET: Home
        //public async Task<ActionResult> Index()
        //{
        //    List<Artist> artists = new List<Artist>();

        //    using (var client = new HttpClient())
        //    {
        //        //Passing service base url  
        //        client.BaseAddress = new Uri(baseurl);

        //        client.DefaultRequestHeaders.Clear();

        //        //Define request data format  
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
        //        HttpResponseMessage Res = await client.GetAsync("api/full");

        //        if (Res.IsSuccessStatusCode)
        //        {
        //            //Storing the response details recieved from web api   
        //            var EmpResponse = Res.Content.ReadAsStringAsync().Result;

        //            //Deserializing the response recieved from web api and storing into the Employee list  
        //            artists = JsonConvert.DeserializeObject<List<Artist>>(EmpResponse);

        //        }

        //    }

        //        return View(artists);
        //}
    }
}