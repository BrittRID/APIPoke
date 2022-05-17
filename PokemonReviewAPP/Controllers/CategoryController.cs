using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewAPP.Interface;

namespace PokemonReviewAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller 
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
    }
}
