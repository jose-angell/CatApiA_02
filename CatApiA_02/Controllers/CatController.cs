using CatApiA_02.Application;
using CatApiA_02.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CatApiA_02.Controllers
{
    [ApiController]
    [Route("api/cats")]
    public class CatController : ControllerBase
    {
        private readonly CatUseCase _useCase;
        public CatController(CatUseCase useCase)
        {
            _useCase = useCase;
        }
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest("El id es obligatorio");
            }
            var cat = await _useCase.GetById(id);
            if (cat == null)
            {
                return NotFound();
            }
            return Ok(cat);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var cats = await _useCase.GetAll();
            return Ok(cats);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCatRequest request)
        {
            var cat = await _useCase.Create(request);
            return CreatedAtAction(nameof(GetById), new { id = cat.Id }, cat);
        }
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateCatRequest request)
        {
            if (id == Guid.Empty)
            {
                return BadRequest("El id es obligatorio");
            }
            var result = await _useCase.Update(id, request);
            if (result != null)
            {
                return BadRequest(result);
            }
            return NoContent();
        }
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest("El id es obligatorio");
            }
            var result = await _useCase.Delete(id);
            if (result != null)
            {
                return BadRequest(result);
            }
            return NoContent();
        }
    }
}
