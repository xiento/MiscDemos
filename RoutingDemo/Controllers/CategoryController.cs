using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RoutingDemo.Models;
using RoutingDemo.Models.ViewModels;

namespace RoutingDemo.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IGenericRepository<Category> repo;
        private readonly IMapper mapper;
        public CategoryController(IGenericRepository<Category> repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var data = repo.GetAll();
            var vm = mapper.Map<IEnumerable<CategoryViewModel>>(data);
            
            return Json(vm);
        }
    }
}