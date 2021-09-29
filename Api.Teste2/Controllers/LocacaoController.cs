using Api.Domain.Models;
using Api.Infraestrutura.Interface;
using Api.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System;


namespace Api.Teste2.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LocacaoController : ControllerBase
    {
        private readonly ILocacaoService _ilocacaoService;
        private readonly ILocacaoRepositorio _ilocacaoRepositorio;


        public LocacaoController(ILocacaoService ilocacaoService, ILocacaoRepositorio ilocacaoRepositorio)
        {
            _ilocacaoService = ilocacaoService;
            _ilocacaoRepositorio = ilocacaoRepositorio;
        }


        // GET api/<LocacaoController>/5
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_ilocacaoRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // PUT api/<LocacaoController>/5
        [HttpPost]
        public IActionResult Post([FromBody] Locacao locacao)
        {
            try
            {

                _ilocacaoRepositorio.Adicionar(locacao);
                return Ok(locacao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }
    }
}

