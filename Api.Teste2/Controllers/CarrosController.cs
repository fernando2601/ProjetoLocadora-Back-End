using Api.Domain.Models;
using Api.Infraestrutura.Interface;
using Api.Service;
using Api.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System;


namespace Api.Teste2.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarrosController : ControllerBase
    {

        private readonly ICarrosService _icarrosService;
        private readonly ICarrosRepositorio _icarrosRepositorio;


        public CarrosController(ICarrosService icarrosService , ICarrosRepositorio icarrosRepositorio)
        {
            _icarrosService =  icarrosService;
            _icarrosRepositorio = icarrosRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_icarrosRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        public IActionResult Cadastrar([FromBody] Carros carro)
        {
            try
            {

                _icarrosRepositorio.Adicionar(carro);
                return Ok(carro);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
