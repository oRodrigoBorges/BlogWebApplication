using Microsoft.AspNetCore.Mvc;
using Xunit;
using BlogWebApplication.Controllers;

namespace BlogWebApplication.Tests
{
    public class DestinosControllerTests
    {
        private readonly DestinosController _controller;

        public DestinosControllerTests()
        {
            _controller = new DestinosController();
        }

        [Fact]
        public void Index_ReturnsViewResult()
        {
            // Act
            var result = _controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.Model); // Se você não tiver um modelo para passar
        }

        [Fact]
        public void PraiaDoUna_ReturnsViewResult()
        {
            // Act
            var result = _controller.PraiaDoUna();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.Model);
        }

        [Fact]
        public void CamposDoJordao_ReturnsViewResult()
        {
            // Act
            var result = _controller.CamposDoJordao();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.Model);
        }
    }
}
