using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PuzzleShop.Core;
using PuzzleShop.Repos.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleShop.Repos
{
    public class PuzzleRepository
    {
        private readonly PuzzleShopContext ctx;
        private readonly BrandRepository _brandRepository;
        private readonly CountryRepository _countryRepository;

        public PuzzleRepository(PuzzleShopContext ctx, BrandRepository _brandRepository, CountryRepository _countryRepository)
        {
            this.ctx = ctx;
            this._brandRepository = _brandRepository;
            this._countryRepository = _countryRepository;
        }
        public Puzzle GetPuzzleById(int id)
        {
            return ctx.Puzzles.Include(x => x.Brand).Include(x => x.Country).FirstOrDefault(x => x.Id == id);
        }
        public Puzzle GetPuzzleByName(string name)
        {
            return ctx.Puzzles.Include(x => x.Brand).Include(x => x.Country).FirstOrDefault(x => x.Name == name);
        }
        public List<Puzzle> GetList()
        {
            return ctx.Puzzles.Include(x => x.Brand).Include(x => x.Country).ToList();
        }
        public async Task<Puzzle> CreatePuzzleAsync(Puzzle puzzle)
        {
            ctx.Puzzles.Add(puzzle);
            await ctx.SaveChangesAsync();
            return GetPuzzleByName(puzzle.Name);
        }
        public async Task<Puzzle> CreatePuzzleFromDto(PuzzleDto dto)
        {
            var brandFromDb = _brandRepository.GetBrandByName(dto.Brand);
            var countryFromDb = _countryRepository.GetCountryByName(dto.Country);
            var puzzle = new Puzzle()
            {
                Name = dto.Name,
                Description = dto.Description,
                Articul = dto.Articul,
                Price = dto.Price,
                Count = dto.Count,
                VideoURL = dto.VideoURL,
                ImgPath = dto.ImgPath,
                Brand = brandFromDb,
                Country = countryFromDb
            };
            return await CreatePuzzleAsync(puzzle);
        }
        public PuzzleDto CreateDtoFromPuzzle(int id)
        {
            var puzzle = GetPuzzleById(id);
            var puzzleDto = new PuzzleDto()
            {
                Id = id,
                Name = puzzle.Name,
                Description = puzzle.Description,
                Articul = puzzle.Articul,
                Price = puzzle.Price,
                Count = puzzle.Count,
                VideoURL = puzzle.VideoURL,
                ImgPath = puzzle.ImgPath,
                Country = puzzle.Country.Name,
                Brand = puzzle.Brand.Name
            };
            return puzzleDto;
        }
        public async Task<Puzzle> UpdatePuzzleAsync(PuzzleDto model)
        {
            var puzzle = ctx.Puzzles.Include(x => x.Brand).Include(x => x.Country).FirstOrDefault(x => x.Id == model.Id);
            if (puzzle.Name != model.Name)
                puzzle.Name = model.Name;
            if (puzzle.Description != model.Description)
                puzzle.Description = model.Description;
            if (puzzle.Articul != model.Articul)
                puzzle.Articul = model.Articul;
            if (puzzle.Price != model.Price)
                puzzle.Price = model.Price;
            if (puzzle.Count != model.Count)
                puzzle.Count = model.Count;
            if (puzzle.VideoURL != model.VideoURL)
                puzzle.VideoURL = model.VideoURL;
            if (puzzle.ImgPath != model.ImgPath)
                puzzle.ImgPath = model.ImgPath;
            if (puzzle.Brand.Name != model.Brand)
                puzzle.Brand = _brandRepository.GetBrandByName(model.Brand);
            if (puzzle.Country.Name != model.Country)
                puzzle.Country = _countryRepository.GetCountryByName(model.Country);
            await ctx.SaveChangesAsync();
            return GetPuzzleById(puzzle.Id);
        }
        public async Task DeletePuzzleAsync(int id)
        {
            ctx.Remove(GetPuzzleById(id));
            await ctx.SaveChangesAsync();
        }
    }
}