namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        { 
            //implementado
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string veiculosAdicionado = Console.ReadLine();
            veiculos.Add(veiculosAdicionado);
            Console.WriteLine($"Veiculo com a placa {veiculosAdicionado} Adicionado com sucesso");
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

               // Implementado 
                int quantidadeHoras = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = 0; 
                valorTotal = precoInicial + precoPorHora * quantidadeHoras;

                // Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);
                

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                 
                 for (int contador = 0; contador < veiculos.Count; contador++)
            {
                 Console.WriteLine($"Veículo N° {contador} - {veiculos[contador]}");

            }
          
            }
    
            else 
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        
    }
}

}