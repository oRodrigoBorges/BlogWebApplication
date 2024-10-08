using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace BlogWebApplication.Tests
{
    public class DestinosIntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public DestinosIntegrationTests(WebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Index_ReturnsSuccess()
        {
            // Act
            var response = await _client.GetAsync("/Destinos");

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains("Index", responseString); // Verifica se a view contém "Index"
        }

        [Fact]
        public async Task PraiaDoUna_ReturnsSuccess()
        {
            // Act
            var response = await _client.GetAsync("/Destinos/PraiaDoUna");

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains("Praia do Una", responseString); // Ajuste conforme o conteúdo da view
        }

        [Fact]
        public async Task CamposDoJordao_ReturnsSuccess()
        {
            // Act
            var response = await _client.GetAsync("/Destinos/CamposDoJordao");

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains("Campos do Jordão", responseString); // Ajuste conforme o conteúdo da view
        }
    }
}
