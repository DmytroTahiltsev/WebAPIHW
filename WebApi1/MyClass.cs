using NUnit.Framework;
using System;
using RestSharp;


namespace selenium_test
{

    [TestFixture()]
    public class WebApi
    {
        [Test()]
        public void Upload()
        {
            //string filename = @"/Users/evgenij/Downloads/1.jpg";
            String token = "IYDwfr3oWiAAAAAAAAAAAZwfvOEPuUT-k0VcLd1aigsgD56kXj-IQHN-3NMNdNHM";
            RestClient restClient = new RestClient("https://content.dropboxapi.com/2/files/upload");

            //byte[] image = System.IO.File.ReadAllBytes(filename);

            RestRequest restRequest = new RestRequest(Method.POST);
            restRequest.RequestFormat = DataFormat.Json;

            restRequest.AddHeader("Authorization", "Bearer " + token);
            restRequest.AddHeader("Dropbox-API-Arg", "{\"path\":\"/test/text.txt\"}");
            restRequest.AddParameter("application/octet-stream", "SuchaPrittyGirl", "application/octet-stream", ParameterType.RequestBody);
            restRequest.AddHeader("Content-Type", "application/octet-stream");

            var response = restClient.Execute(restRequest);

            Assert.IsTrue(response.Content != null);
        }

        [Test()]
        public void GetMetaData()
        {
            //string filename = @"/Users/evgenij/Downloads/1.jpg";
            String token = "IYDwfr3oWiAAAAAAAAAAAZwfvOEPuUT-k0VcLd1aigsgD56kXj-IQHN-3NMNdNHM";
            RestClient restClient = new RestClient("https://api.dropboxapi.com/2/files/get_metadata");

            //byte[] image = System.IO.File.ReadAllBytes(filename);

            RestRequest restRequest = new RestRequest(Method.POST);
            restRequest.RequestFormat = DataFormat.Json;

            restRequest.AddHeader("Authorization", "Bearer " + token);
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddJsonBody("{\"path\":\"/test/text.txt\"}");

            var response = restClient.Execute(restRequest);
            Assert.IsTrue(response.Content != null);
        }

        [Test()]
        public void Delete()
        {
            //string filename = @"/Users/evgenij/Downloads/1.jpg";
            String token = "IYDwfr3oWiAAAAAAAAAAAZwfvOEPuUT-k0VcLd1aigsgD56kXj-IQHN-3NMNdNHM";
            RestClient restClient = new RestClient("https://api.dropboxapi.com/2/files/delete_v2\n");

            //byte[] image = System.IO.File.ReadAllBytes(filename);

            RestRequest restRequest = new RestRequest(Method.POST);
            restRequest.RequestFormat = DataFormat.Json;

            restRequest.AddHeader("Authorization", "Bearer " + token);
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddJsonBody("{\"path\":\"/test/text.txt\"}");

            var response = restClient.Execute(restRequest);
            //Console.WriteLine(response.Content);
            Assert.IsTrue(response.Content != null);
        }

    }

}
