using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PuzzleShop.Core;
using PuzzleShop.Repos;

namespace PuzzleShop.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly BrandRepository _brandRepository;
        public BrandController(BrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        [HttpGet]
        public List<Brand> Get()
        {
            var brands = _brandRepository.GetList();
            return (brands);
        }
        [HttpGet("{id}")]
        public Brand Get(int id)
        {
            return _brandRepository.GetBrandById(id);
        }
        [HttpPost]
        public async Task<Brand> Create(Brand brand)
        {
            var createdBrand = await _brandRepository.CreateBrandAsync(brand);
            return createdBrand;
        }

        [HttpPut]
        public async Task<ActionResult> Edit(Brand brand)
        {
            await _brandRepository.UpdateBrandAsync(brand);
            return Ok("edited");
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return Ok(_brandRepository.DeleteBrandAsync(id));
        }

    }
}
