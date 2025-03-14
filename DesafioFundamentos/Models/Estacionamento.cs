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
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"           
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            // Implementado
            string placa = Console.ReadLine();

            // Verificando se a placa é valida
            if(placa.Length == 8 && placa != null){
            veiculos.Add(placa);
            }else{
                Console.WriteLine("Placa inválida: Utilize o formato: ABC-1234");
                return;
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa

            // Implementado
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                
                // Implementado
                int horas = Convert.ToInt32(Console.ReadLine());

                // Implementação sugerida para solução do desafio
                //decimal valorTotal = (precoInicial + precoPorHora) * horas; 

                // Minha solução, considerando que na implementação do instrutor, 
                // na primeira hora seria cobrado a hora inicial  + a hora adicional, cobrando uma hora adicional a mais
                decimal valorTotal = precoInicial + (precoPorHora * (horas - 1));

                // TODO: Remover a placa digitada da lista de veículos
                 
                // Implementado
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal.ToString("F2")}");
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
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
        
                foreach (var veiculos in veiculos){
                    Console.WriteLine(veiculos);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}