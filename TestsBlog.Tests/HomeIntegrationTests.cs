using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace BlogWebApplication.Tests
{
    public class HomeIntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public HomeIntegrationTests(WebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Index_ReturnsSuccess()
        {
            // Act
            var response = await _client.GetAsync("/");

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains("Index", responseString); // Ajuste conforme o conteúdo da view
        }

        [Fact]
        public async Task Sobre_ReturnsSuccess()
        {
            // Act
            var response = await _client.GetAsync("/Home/Sobre");

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains("Sobre", responseString); // Ajuste conforme o conteúdo da view
        }

        [Fact]
        public async Task Destinos_ReturnsSuccess()
        {
            // Act
            var response = await _client.GetAsync("/Home/Destinos");

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains("Destinos", responseString); // Ajuste conforme o conteúdo da view
        }

        [Fact]
        public async Task Contatos_ReturnsSuccess()
        {
            // Act
            var response = await _client.GetAsync("/Home/Contatos");

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains("Contatos", responseString); // Ajuste conforme o conteúdo da view
        }
    }
}
