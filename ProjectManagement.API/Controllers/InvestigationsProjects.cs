using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.API.Data;
using ProjectManagement.Shared.Entities;

namespace ProjectManagement.API.Controllers
{

    [ApiController]
    [Route("api/investigationprojects")]
    public class InvestigationsProjectsController : ControllerBase
    {

        private readonly DataContext _dataContext;
        public InvestigationsProjectsController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _dataContext.InvestigationProjects.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(InvestigationProject investigationProjects)
        {
            _dataContext.Add(investigationProjects);
            await _dataContext.SaveChangesAsync();
            return Ok(investigationProjects);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var investigationProjects = await _dataContext.InvestigationProjects.FirstOrDefaultAsync(X => X.Id == id);
            if (investigationProjects == null)
            {
                return NotFound();
            }
            return Ok(investigationProjects);
        }

    }


}