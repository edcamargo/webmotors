using Newtonsoft.Json;
using RestSharp;
using WebMotors.Domain.Core.Shared;
using WebMotors.InfraStructure.AntiCorruption.WebMotors.Entities;

namespace WebMotors.InfraStructure.AntiCorruption.WebMotors
{
    public class WebMotorsFacade : IWebMotorsFacade
    {
        private const string WebMotorsUrl = "https://desafioonline.webmotors.com.br/api/OnlineChallenge/";

        public object? GetMake()
        {
            var client = new RestClient(WebMotorsUrl);
            var request = new RestRequest("/Make", Method.GET);

            // Header
            request.AddHeader("content-type", "application/json");

            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<List<Make?>>(response.Content);

            return result;
        }

        public object? GetModel(int makeId)
        {
            var client = new RestClient(WebMotorsUrl);
            var request = new RestRequest("/Model", Method.GET);

            // Header
            request.AddHeader("content-type", "application/json");

            // Parameter
            request.AddParameter("MakeID", makeId);

            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<List<Model?>>(response.Content);

            return result;
        } 

        public object? GetVersion(int modelId)
        {
            var client = new RestClient(WebMotorsUrl);
            var request = new RestRequest("/Version", Method.GET);

            // Header
            request.AddHeader("content-type", "application/json");

            // Parameter
            request.AddParameter("ModelID", modelId);

            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<List<Versions?>>(response.Content);

            return result;
        }

        public object? GetVehicles(int page)
        {
            var client = new RestClient(WebMotorsUrl);
            var request = new RestRequest("/Vehicles", Method.GET);

            // Header
            request.AddHeader("content-type", "application/json");

            // Parameter
            request.AddParameter("Page", page);

            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<List<Vehicles?>>(response.Content);

            return result;
        }
    }
}
