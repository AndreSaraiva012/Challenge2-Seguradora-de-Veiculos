namespace Challenge2
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            char exit = 'a';

            while (exit != 's')
            {
                Menu();

                string porteSelected = Console.ReadLine().ToLower();

                while (porteSelected != Porte.grande.ToString() && porteSelected != Porte.medio.ToString() && porteSelected != Porte.pequeno.ToString())
                {
                    Console.WriteLine("\t\nEssa opção não exite! Espere 2 segundos.....");
                    Thread.Sleep(3000);
                    Console.Clear();
                    
                    Menu();
                    porteSelected = Console.ReadLine().ToLower();
                }

                Console.Write("Introduza o modelo do veículo: ");
                string modelo = Console.ReadLine();

                Veiculo veiculo = ServicosSeguradora.CriarVeiculo(porteSelected, modelo);

                SeguradoraFactory seguradora = new GuinchoFactory(porteSelected);
                ServicosSeguradora servico = new ServicosSeguradora(seguradora, veiculo);
                servico.ServicoReboque();
                Console.Clear();

                Console.WriteLine($"{DateTime.Now} -> \nSocorrendo Carro {veiculo.Porte} - Modelo {modelo}" + 
                                   "\n---------------------------------------------------");

                Console.WriteLine("\nReboque a caminho.....");
                exit = 's';
            }

            void Menu()
            {
                Console.WriteLine("\t------- Menu Seguradora Rio -------\n\n" +
                    "\tGrande -> veículo de Grande porte\n" +
                    "\tMedio -> veículo de Médio porte\n" +
                    "\tPequeno -> veículo de Pequeno porte\n\n" +
                    "\t-----------------------------------\n");
                Console.Write("Insira o porte do Veiculo: ");
            }
        }

       
    }
}
