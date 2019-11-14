using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

using Newtonsoft.Json;

namespace SandboxAAS
{
    public static class Cats
    {
        [FunctionName("Cats")]
        public static async Task<HttpResponseMessage> GetCats(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string name = req.Query["name"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            var scs = new SubjectCategorySet();
            var cats = scs.GetCategories(name);

            var retObj = new
            {
                SubjectName = name,
                Categories = cats
            };
            var json = JsonConvert.SerializeObject(retObj, Formatting.Indented);
            return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(json, Encoding.UTF8) };
        }
    }
}
