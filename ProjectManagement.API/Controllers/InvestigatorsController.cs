using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.API.Data;
using ProjectManagement.Shared.Entities;

namespace ProjectManagement.API.Controllers
{

    [ApiController]
    [Route("api/investigator")]
    public class InvestigatorsController: ControllerBase
    {
        private readonly DataContext _dataContext;
        public InvestigatorsController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _dataContext.Investigators.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(Investigator investigator)
        {
            _dataContext.Add(investigator);
            await _dataContext.SaveChangesAsync();
            return Ok(investigator);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var investigator = await _dataContext.Investigators.FirstOrDefaultAsync(X => X.Id == id);
            return investigator == null ? NotFound() : Ok(investigator);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Investigator investigator)
        {
            _dataContext.Update(investigator);
            await _dataContext.SaveChangesAsync();
            return Ok(investigator);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filaafectada=await _dataContext.Investigators
                .Where(x=>x.Id==id).ExecuteDeleteAsync ();
            return filaafectada == 0 ? NotFound() : NoContent();   
        }

    }
}
