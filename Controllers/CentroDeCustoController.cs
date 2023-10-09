using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceDesk.Data;

namespace ServiceDesk;

[ApiController]
[Route("[controller]")]
    public class CentroDeCustoController : ControllerBase
    {
        private ServiceDeskDbContext? _dbContext;

        public CentroDeCustoController(ServiceDeskDbContext dbContext) 
        { 
            _dbContext = dbContext;
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<ActionResult> Cadastrar(CentroDeCusto centrodecusto)
        {
            if (_dbContext is null) return NotFound();
            if (_dbContext.Dispositivo is null) return NotFound();
            await _dbContext.AddAsync(centrodecusto);
            await _dbContext.SaveChangesAsync();
            return Created("",centrodecusto);
        }
        
        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<IEnumerable<CentroDeCusto>>> Listar()
        {
            if (_dbContext is null) return NotFound();
            if (_dbContext.CentroDeCusto is null) return NotFound();
            return await _dbContext.CentroDeCusto.ToListAsync();
        }

        [HttpGet]
        [Route("buscar/{id}")]
        public async Task<ActionResult<CentroDeCusto>> Buscar(int id)
        {
            if(_dbContext is null) return NotFound();
            if(_dbContext.CentroDeCusto is null) return NotFound();
            var centrodecustoTemp = await _dbContext.CentroDeCusto.FindAsync(id);
            if(centrodecustoTemp is null) return NotFound();
            return centrodecustoTemp;
        }

        [HttpPut]
        [Route("alterar")]
        public async Task<ActionResult> Alterar(CentroDeCusto centroDeCusto){
            
            _dbContext.CentroDeCusto.Update(centroDeCusto);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        [Route("excluir/{id}")]
        public async Task<ActionResult> Excluir(int id)
        {
            if(_dbContext is null) return NotFound();
            if(_dbContext.CentroDeCusto is null) return NotFound();
            var centrodecustoTemp = await _dbContext.CentroDeCusto.FindAsync(id);
            if(centrodecustoTemp is null) return NotFound();
            _dbContext.Remove(centrodecustoTemp);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
        }
