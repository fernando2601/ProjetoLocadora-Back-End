using Api.Domain.Models;
using Api.Infraestrutura.Interface;
using Api.Service;
using Api.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Api.Teste2.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly IClienteService _iclienteService;
        private readonly IClienteRepositorio _iclienteRepositorio;

        public ClienteController(IClienteService IclienteService, IClienteRepositorio iclienteRepositorio)
        {
            _iclienteService = IclienteService;
            _iclienteRepositorio = iclienteRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_iclienteRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            try
            {
                return Ok(_iclienteRepositorio.ObterPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // POST api/<ClienteController>
        [HttpPost]
        public IActionResult Cadastrar([FromBody] Clientes cliente)
        {
            try
            {

                _iclienteRepositorio.Adicionar(cliente);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]

        public IActionResult Atualizar([FromBody] Clientes cliente)
        {
            _iclienteRepositorio.Atualizar(cliente);

            return Ok();
        }
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {

            _iclienteRepositorio.Remover(id);
            return Ok();
        }
    }
}
