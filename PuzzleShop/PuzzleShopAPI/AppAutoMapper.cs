using AutoMapper;
using PuzzleShop.Core;
using PuzzleShop.Repos.Dto;
using System.Drawing;

namespace PuzzleShopAPI
{
    public class AppAutoMapper : Profile
    {
        public AppAutoMapper()
        {
            CreateMap<PuzzleDto, Puzzle>();
            CreateMap<Puzzle, PuzzleDto>();
        }
    }
}
