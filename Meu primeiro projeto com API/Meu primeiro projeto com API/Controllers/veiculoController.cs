using Meu_primeiro_projeto_com_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Meu_primeiro_projeto_com_API.Controllers
{
    [Route("api/veiculo")]
    [ApiController]
    public class veiculoController : ControllerBase
    {
        [Route("obterVeiculo")]
        [HttpGet]
        public Veiculo obterVeiculo()
        {
            var meuVeiculo = new Veiculo();

            meuVeiculo.cor = "Prata";
            meuVeiculo.marca = "Chevrolet";
            meuVeiculo.placa = "ATM7E87";
            meuVeiculo.modelo = "Astra";

            meuVeiculo.Acelerar();
            meuVeiculo.Acelerar();
            


            return meuVeiculo;
        }

        [Route("obterCarro")]
        [HttpGet]
        public Carro obterCarro()
        {
            var meuCarro = new Carro();

            meuCarro.cor = "Vermelho";
            meuCarro.marca = "Fiat";
            meuCarro.placa = "ATA-4567";
            meuCarro.modelo = "Palio";
            meuCarro.Acelerar();

            return meuCarro;

        }

        [Route("obterMoto")]
        public Moto obterMoto()
        {
            var minhaMoto = new Moto();

            minhaMoto.cor = "Preta";
            minhaMoto.marca = "Honda";
            minhaMoto.placa = "HFG-3589";
            minhaMoto.modelo = "XRE";
            minhaMoto.Acelerar();

            return minhaMoto;

        }
       
    }
}
