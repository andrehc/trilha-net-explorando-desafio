using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

// Cria a suíte
Suite suite = new Suite();
Console.WriteLine("Informe a Suite desejada.\n*1 - Master.\n*2 - Premium.\n*3 - Standart.");
int seletorSuite = int.Parse(Console.ReadLine());

switch (seletorSuite)
{
    case 1:
        suite.TipoSuite = "Master";
        suite.ValorDiaria = 360;
        suite.Capacidade = 6;
        break;
    case 2:
        suite.TipoSuite = "Premium";
        suite.ValorDiaria = 320;
        suite.Capacidade = 4;
        break;
    default:
        suite.TipoSuite = "Standart";
        suite.ValorDiaria = 260;
        suite.Capacidade = 2;
        break;
}

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva();
Console.WriteLine("Informe a quantidade de dias a serem reservados.");
reserva.DiasReservados = int.Parse(Console.ReadLine());
reserva.CadastrarSuite(suite);

Console.WriteLine("Informe a quantidade de hóspedes");
int entradaHospedes = int.Parse((Console.ReadLine()));

for (int i = 0; i < entradaHospedes; i++)
{
    Console.WriteLine("Informe o nome do hospede.");
    Pessoa pessoa = new Pessoa();
    pessoa.Nome = Console.ReadLine();
    hospedes.Add(pessoa);
}

reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");