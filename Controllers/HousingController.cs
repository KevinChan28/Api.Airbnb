using Api.Airbnb.DTO;
using Api.Airbnb.Models;
using Api.Airbnb.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Api.Airbnb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HousingController : ControllerBase
    {
        private readonly IHousing _housing;

        public HousingController(IHousing housing)
        {
            _housing = housing;
        }

        /// <summary>
        /// Obtener catálogo de productos
        /// </summary>
        /// <param name=""></param>
        /// <returns>Arreglo de objetos con las propiedades Id y ProductName</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [AllowAnonymous]
        public async Task<IActionResult> GetCatalogHousing()
        {
            try
            {
                List<CatalogHousing> catalogHousings = await _housing.GetCatalogHousings();

                if (catalogHousings != null)
                {
                    return Ok(catalogHousings);
                   
                }
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
