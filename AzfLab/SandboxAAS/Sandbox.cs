using System;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace SandboxAAS
{
    public static class Sandbox
    {
        [FunctionName("Sandbox")]
        public static async Task<HttpResponseMessage> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            var ret = String.IsNullOrEmpty(name) ? new Playground() : new Playground(name);
            var json = JsonConvert.SerializeObject(ret, Formatting.Indented);

            return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(json,  Encoding.UTF8) };
        }
    }
}
