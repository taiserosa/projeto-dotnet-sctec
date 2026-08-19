using autocheck_dotnet.AutoCheck.ConsoleApp.Models;

namespace autocheck_dotnet.Services
{
    public class MotorVistoria
    {


        public void RealizarVistoria(Veiculo veiculo)
        {
            ObterEntrada obterEntrada = new ObterEntrada();

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("=-=-=-=-=-=-=-=- ITENS A SEREM INSPECIONADOS -=-=-=-=-=-=-=-=");
            Console.WriteLine("- Informe BOM, REGULAR ou RUIM");

            foreach (var item in veiculo.ObterChecklistObrigatorio())
            {
                string status = obterEntrada.ObterString($"- Informe o status do {item}: ");

                veiculo.AdicionarItemVistoriado(item, status);
            }
        }

        public int CalculaPontuacao(Veiculo veiculo)
        {
            int pontuacao = 0;
            foreach (var item in veiculo.VistoriaRealizada)
            {
                if (item.Status.ToUpper() == "BOM")
                {
                    pontuacao += 10;
                }
                else if (item.Status.ToUpper() == "REGULAR")
                {
                    pontuacao += 5;
                }
            }
            return pontuacao;
        }

        public double CalculaPercentual(Veiculo veiculo)
        {
            int totalItens = veiculo.VistoriaRealizada.Count;

            double percentual = (double)CalculaPontuacao(veiculo) / (totalItens * 10) * 100;
            return percentual;
        }

        public string ClassificaVeiculo(Veiculo veiculo)
        {
            double percentual = CalculaPercentual(veiculo);
            if (percentual <= 59)
            {
                return "--- Reprovado na Vistoria! ---";
            }
            else if (percentual >= 60 && percentual <= 89)
            {
                return "--- Aprovado com Apontamentos! ---";
            }
            else
            {
                return "--- Aprovado com Excelência! ---";
            }
        }

        public void AvaliaItens(Veiculo veiculo)
        {
            foreach (var item in veiculo.VistoriaRealizada)
            {
                if (item.Status.ToUpper() == "BOM")
                {
                    Console.WriteLine($"[OK] {item.Nome} ------ Status: {item.Status} (10 pontos)");
                }
                else if (item.Status.ToUpper() == "REGULAR")
                {
                    Console.WriteLine($"[!] {item.Nome} ------- Status: {item.Status} (5 pontos)");
                }
                else
                {
                    Console.WriteLine($"[X] {item.Nome} ------- Status: {item.Status} (0 pontos)");
                }
            }
        }


        public void ObterRecomendacao(ItemVistoria item)
        {
            switch (item.Nome)
            {
                case "Nível de Óleo do Motor":
                    if (item.Status == "RUIM")
                    {
                        Console.WriteLine($"{item.Nome}: Trocar urgentemente o óleo do motor.");
                    } else if (item.Status == "REGULAR")
                    {
                        Console.WriteLine($"{item.Nome}: Verificar o nível e realizar a troca preventiva do óleo.");
                    }
                    break;
                case "Estado da bateria":
                    if (item.Status == "RUIM")
                    {
                        Console.WriteLine($"{item.Nome}: Substituir a bateria e verificar o sistema elétrico..");
                    } else if (item.Status == "REGULAR")
                    {
                        Console.WriteLine($"{item.Nome}: Verificar a carga e o estado dos terminais da bateria.");
                    }
                    break;
                case "Estado dos pneus":
                    if (item.Status == "RUIM")
                    {
                        Console.WriteLine($"{item.Nome}: Efetuar a troca dos pneus com urgência.");
                    } else if (item.Status == "REGULAR")
                    {
                        Console.WriteLine($"{item.Nome}: Verificar a calibragem, desgaste e alinhamento dos pneus.");
                    }
                    break;
                case "Estado dos freios":
                    if (item.Status == "RUIM")
                    {
                        Console.WriteLine($"{item.Nome}: Realizar revisão imediata do sistema de freios.");
                    } else if (item.Status == "REGULAR")
                    {
                        Console.WriteLine($"{item.Nome}: Realizar revisão preventiva do sistema de freios.");
                    }
                    break;
                case "Documentação Regularizada":
                    if (item.Status == "RUIM")
                    {
                        Console.WriteLine($"{item.Nome}: Regularizar a documentação do veículo antes da circulação.");
                    } else if (item.Status == "REGULAR")
                    {
                        Console.WriteLine($"{item.Nome}: Revisar a documentação e verificar possíveis pendências.");
                    }
                    break;
                case "Funcionamento das luzes":
                    if (item.Status == "RUIM")
                    {
                        Console.WriteLine($"{item.Nome}: Substituir as lâmpadas defeituosas e verificar o sistema elétrico.");
                    } else if (item.Status == "REGULAR")
                    {
                        Console.WriteLine($"{item.Nome}: Realizar revisão preventiva das lâmpadas e conexões elétricas.");
                    }
                    break;
                case "Macaco e Chave de Roda":
                    if (item.Status == "RUIM")
                    {
                        Console.WriteLine($"{item.Nome}: Substituir ou providenciar as ferramentas necessárias para emergência.");
                    } else if (item.Status == "REGULAR")
                    {
                        Console.WriteLine($"{item.Nome}: Verificar as condições e o funcionamento das ferramentas.");
                    }
                    break;
                case "Funcionamento dos Airbags":
                    if (item.Status == "RUIM")
                    {
                        Console.WriteLine($"{item.Nome}: Realizar diagnóstico e reparo imediato do sistema de airbags.");
                    } else if (item.Status == "REGULAR")
                    {
                        Console.WriteLine($"{item.Nome}: Realizar diagnóstico preventivo do sistema de airbags.");
                    }
                    break;
                case "Funcionamento do Ar-condicionado":
                    if (item.Status == "RUIM")
                    {
                        Console.WriteLine($"{item.Nome}: Realizar revisão completa do sistema de ar-condicionado.");
                    } else if (item.Status == "REGULAR")
                    {
                        Console.WriteLine($"{item.Nome}: Realizar higienização e verificar o funcionamento do sistema.");
                    }
                    break;
                case "Estado da Corrente de Transmissão":
                    if (item.Status == "RUIM")
                    {
                        Console.WriteLine($"{item.Nome}: Substituir ou realizar manutenção completa da corrente de transmissão.");
                    } else if (item.Status == "REGULAR")
                    {
                        Console.WriteLine($"{item.Nome}: Lubrificar e verificar a tensão da corrente de transmissão.");
                    }
                    break;
                case "Estado dos Manetes":
                    if (item.Status == "RUIM")
                    {
                        Console.WriteLine($"{item.Nome}: Substituir os manetes danificados e verificar o sistema de acionamento.");
                    } else if (item.Status == "REGULAR")
                    {
                        Console.WriteLine($"{item.Nome}: Realizar ajuste e revisão dos manetes de freio e embreagem.");
                    }
                    break;
                case "Estado do Guidão":
                    if (item.Status == "RUIM")
                    {
                        Console.WriteLine($"{item.Nome}: Realizar reparo ou substituição do guidão imediatamente.");
                    } else if (item.Status == "REGULAR")
                    {
                        Console.WriteLine($"{item.Nome}: Verificar alinhamento, fixação e condições do guidão.");
                    }
                    break;
                case "Estado da Suspensão":
                    if (item.Status == "RUIM")
                    {
                        Console.WriteLine($"{item.Nome}: Realizar revisão imediata e substituir componentes danificados da suspensão.");
                    } else if (item.Status == "REGULAR")
                    {
                        Console.WriteLine($"{item.Nome}: Realizar revisão preventiva dos componentes da suspensão.");
                    }
                    break;
                case "Tacógrafo":
                    if (item.Status == "RUIM")
                    {
                        Console.WriteLine($"{item.Nome}: Realizar manutenção imediata e verificar o funcionamento do tacógrafo.");
                    } else if (item.Status == "REGULAR")
                    {
                        Console.WriteLine($"{item.Nome}: Realizar inspeção e aferição preventiva do tacógrafo.");
                    }
                    break;
                case "Sistema de Freio Pneumático":
                    if (item.Status == "RUIM")
                    {
                        Console.WriteLine($"{item.Nome}: Realizar revisão imediata do sistema de freio pneumático.");
                    } else if (item.Status == "REGULAR")
                    {
                        Console.WriteLine($"{item.Nome}: Realizar revisão preventiva do sistema de freio pneumático.");
                    }
                    break;
            }    
        }

        public void ExibePendencias(Veiculo veiculo)
        {
            int contRuim = 0;
            int contRegular = 0;

            foreach (var item in veiculo.VistoriaRealizada)
            {
                if (item.Status.ToUpper() == "RUIM")
                {
                    contRuim += 1;
                    if (contRuim == 1)
                    {
                        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                        Console.WriteLine("=-=-=-=- ITENS CRÍTICOS / REPROVADOS (AÇÃO IMEDIATA) -=-=-=-=");
                        
                    }
                    ObterRecomendacao(item);
                }
                else if (item.Status.ToUpper() == "REGULAR")
                {
                    contRegular += 1;
                    if (contRegular == 1)
                    {
                        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                        Console.WriteLine("-=-=-=-=-=- ITENS DE ATENÇÃO (REVISÃO PREVENTIVA) -=-=-=-=-=-");

                    }
                    ObterRecomendacao(item);
                }
            }
            if (contRuim == 0 && contRegular == 0)
            {
                Console.WriteLine("--- Nenhuma pendência registrada! Veículo liberado! ---");
            }
        }


        public void ExibeRelatorioFinal(Veiculo veiculo)
        {
            Console.WriteLine();
            
            veiculo.Imprimir();
            
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine($"-=-=-=-= AVALIAÇÃO DOS ITENS INSPECIONADOS ({veiculo.VistoriaRealizada.Count} itens) =-=-=-=-");
            
            AvaliaItens(veiculo);

            Console.WriteLine();
            
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=- RESUMO DA PONTUAÇÃO -=-=-=-=-=-=-=-=-=-");

            Console.WriteLine($"- Pontuação Atingida: {CalculaPontuacao(veiculo)} de {veiculo.VistoriaRealizada.Count * 10} pontos possíveis");
            Console.WriteLine($"- Percentual de Aprovação: {CalculaPercentual(veiculo):F2}%");
            Console.WriteLine($"- Classificação Final: [{ClassificaVeiculo(veiculo)}]");

            Console.WriteLine();

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("-=-=- RELATÓRIO DE MANUTENÇÃO E RECOMENDAÇÕES DA OFICINA -=-=-");

            ExibePendencias(veiculo);
        }
    }
}

