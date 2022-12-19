using Microsoft.AspNetCore.Mvc;
using PuzzleShop.Core;
using PuzzleShop.Repos;

namespace PuzzleShop.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly CountryRepository _countryRepository;
        public CountryController(CountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        [HttpGet]
        public List<Country> Get()
        {
            var countries = _countryRepository.GetList();
            return countries;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Country country)
        {
            var createdCountry = await _countryRepository.CreateCountryAsync(country);
            return Ok(createdCountry);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(Country country)
        {
         
                await _countryRepository.UpdateCountryAsync(country);
                return Ok("Edited");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _countryRepository.DeleteCountryAsync(id);
            return Ok("deleted");
        }
    }
}
