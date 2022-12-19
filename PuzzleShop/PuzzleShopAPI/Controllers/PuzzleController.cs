using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PuzzleShop.Core;
using PuzzleShop.Repos;
using PuzzleShop.Repos.Dto;

namespace PuzzleShop.UI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PuzzleController : ControllerBase
    {
        private readonly PuzzleRepository _puzzleRepository;
        private readonly BrandRepository _brandRepository;
        private readonly CountryRepository _countryRepository;

        public PuzzleController(PuzzleRepository puzzleRepository, BrandRepository brandRepository, CountryRepository countryRepository)
        {
            _puzzleRepository = puzzleRepository;
            _brandRepository = brandRepository;
            _countryRepository = countryRepository;
        }

        [HttpGet]
        public List<Puzzle> GetList()
        {
            var puzzles = _puzzleRepository.GetList();
            return puzzles;
        }
        [HttpGet, Route("{id}")]
        public Puzzle GetPuzzle(int id)
        {
            var puzzle = _puzzleRepository.GetPuzzleById(id);
            return puzzle;
        }

        [HttpPost]
        public async Task<Puzzle> Create(PuzzleDto puzzleDto)
        {
            var puzzle = await _puzzleRepository.CreatePuzzleFromDto(puzzleDto);
            return puzzle;
        }

        [HttpPut, Route("{id}")]
        public async Task<Puzzle> Edit(PuzzleDto puzzleDto)
        {
            var puzzle = await _puzzleRepository.UpdatePuzzleAsync(puzzleDto);
            return puzzle;
        }

        [HttpDelete, Route("{id}")]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            await _puzzleRepository.DeletePuzzleAsync(id);
            return Ok("deleted");
        }
    }
}