using Business.InterfaceGenerics;
using Microsoft.AspNetCore.Mvc;
using Model.Carro;
using Model.RetornoAPI;
using System;
using System.Threading.Tasks;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrosController : Controller
    {
        private readonly ICarro _ICarro;

        public CarrosController(ICarro ICarro)
        {
            _ICarro = ICarro;
        }

        [HttpGet("Listar Carros")]
        public async Task<IActionResult> ListarCarros()
        {
            return Json(await _ICarro.List());
        }

        [HttpHead("Obter Carro Por Id")]
        public async Task<IActionResult> ObterCarroPorId(int Id)
        {
            return Json(await _ICarro.GetEntityById(Id));
        }


        [HttpPost("Adicionar Carro")]
        public async Task<Retorno> AdicionarCarro(CarroViewModel carro)
        {

            var retorno = new Retorno();
            bool error = false;

            try
            {
                await _ICarro.Add(carro);

                // se ouver um erro 
                if (error)
                {
                    retorno.Sucesso = false;
                    retorno.Erros.Add(string.Concat("Email :", "Campo Obrigatório"));
                }
                else
                {
                    retorno.Sucesso = true;
                    retorno.Erros.Add(string.Concat("Tudo certo por aqui!"));
                }


            }
            catch (Exception erro)
            {

                retorno.Sucesso = false;
                retorno.Erros.Add(erro.Message);
            }

            return retorno;
        }

        [HttpPut("Atualizar Carro")]
        public async Task AtualizarCarro(CarroViewModel carro)
        {
            await _ICarro.Update(carro);
        }

        [HttpDelete("Remover Carro")]
        public async Task RemoverCarro(CarroViewModel carro)
        {
            await _ICarro.Delete(carro);
        }


    }
}
