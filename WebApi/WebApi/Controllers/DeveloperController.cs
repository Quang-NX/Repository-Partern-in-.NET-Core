using DataAccess.EFCore.UnitOfWork;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeveloperController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult GetPopularDevelopers([FromQuery] int count)
        {
            var popular = _unitOfWork.Developer.GetPopularDevelopers(count);
            return Ok(popular);
        }
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddDeveloperAndProject()
        {
            var developer = new Developer
            {
                Followers = 35,
                Name = "Mukesh Murugan"
            };
            var project = new Project
            {
                Name = "codewithmukesh"
            };
            _unitOfWork.Developer.Add(developer);
            _unitOfWork.Project.Add(project);
            _unitOfWork.Complete();
            return Ok();

        }
    }
}
