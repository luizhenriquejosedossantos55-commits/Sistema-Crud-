namespace Meu_primeiro_projeto_com_API.Models
{
    public class Carro : Veiculo
    {
        public Carro()
        {
            quantidadeRodas = 4;
        }
        public int? quantidadeRodas { get; set; }

        public override void Acelerar()
        {
            injetarCombustivel(4);
        }

        private void injetarCombustivel(int quantidadeCombustivel)
        {
            base.TanqueCombustivel = base.TanqueCombustivel - quantidadeCombustivel;
        }
    }
}
