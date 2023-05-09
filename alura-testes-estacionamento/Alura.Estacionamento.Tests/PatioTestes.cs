using Alura.Estacionamento.Modelos;
using Xunit.Abstractions;

namespace Alura.Estacionamento.Tests;

public class PatioTestes : IDisposable
{
    private Veiculo veiculo;
    private Patio estacionamento;
    private Operador operador;

    public ITestOutputHelper SaidaConsoleTeste { get; }

    public PatioTestes(ITestOutputHelper _saidaConsoleTeste)
    {
        SaidaConsoleTeste = _saidaConsoleTeste;
        SaidaConsoleTeste.WriteLine("Construtor foi invocado");
        veiculo = new Veiculo();
        estacionamento = new Patio();
        operador = new Operador();
        operador.Nome = "Anderson Oliveira";
        estacionamento.OperadorPatio = operador;
    }

    [Fact]
    public void ValidaFaturamentoDoEstacionamentoComUmVeiculo()
    {
        // Arrange
        // Patio estacionamento = new Patio();
        // Operador operador = new Operador();
        // operador.Nome = "Anderson Oliveira";
        // estacionamento.OperadorPatio = operador;

        // Veiculo veiculo = new Veiculo();
        veiculo.Proprietario = "José Silva";
        veiculo.Tipo = TipoVeiculo.Automovel;
        veiculo.Cor = "Azul";
        veiculo.Modelo = "Fusca";
        veiculo.Placa = "abc-9999";

        estacionamento.RegistrarEntradaVeiculo(veiculo);
        estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);
        
        // Act
        double faturamento = estacionamento.TotalFaturado();

        // Assert
        Assert.Equal(2, faturamento);
    }

    [Theory]
    [InlineData("Alex Silva", "ALS-1498", "Preto", "Gol")]
    [InlineData("José Silva", "JSS-9242", "Cinza", "Fusca")]
    [InlineData("Maria Silva", "MRS-6524", "Marrom", "Opala")]
    [InlineData("Pedro Silva", "PDS-0101", "Branco", "Corsa")]
    public void ValidaFaturamentoDoEstacionamentoComVariosVeiculos(
        string proprietario,
        string placa,
        string cor,
        string modelo
    )
    {
        // Arrange
        // Patio estacionamento = new Patio();
        // Operador operador = new Operador();
        // operador.Nome = "Anderson Oliveira";
        // estacionamento.OperadorPatio = operador;

        // Veiculo veiculo = new Veiculo();
        veiculo.Proprietario = proprietario;
        veiculo.Placa = placa;
        veiculo.Cor = cor;
        veiculo.Modelo = modelo;

        estacionamento.RegistrarEntradaVeiculo(veiculo);
        estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

        // Act
        double faturamento = estacionamento.TotalFaturado();

        // Assert
        Assert.Equal(2, faturamento);
    }

    [Theory]
    [InlineData("Alex Silva", "ALS-1498", "Preto", "Gol")]
    public void LocalizaVeiculoNoPatioComBaseNoIdTicket(
        string proprietario,
        string placa,
        string cor,
        string modelo
    )
    {
        // Arrange
        // Patio estacionamento = new Patio();
        // Operador operador = new Operador();
        // operador.Nome = "Anderson Oliveira";
        // estacionamento.OperadorPatio = operador;

        // Veiculo veiculo = new Veiculo();
        veiculo.Proprietario = proprietario;
        veiculo.Placa = placa;
        veiculo.Cor = cor;
        veiculo.Modelo = modelo;

        estacionamento.RegistrarEntradaVeiculo(veiculo);

        // Act
        Veiculo consultado = estacionamento.PesquisaVeiculo(veiculo.IdTicket);

        // Assert
        Assert.Contains("### Ticket Estacionamento Alura ###", consultado.Ticket);
    }

    [Fact]
    public void AlterarDadosDoProprioVeiculo()
    {
        // Arrange
        // Patio estacionamento = new Patio();
        // Operador operador = new Operador();
        // operador.Nome = "Anderson Oliveira";
        // estacionamento.OperadorPatio = operador;

        // Veiculo veiculo = new Veiculo();
        veiculo.Proprietario = "José Silva";
        veiculo.Placa = "ZXC-8524";
        veiculo.Cor = "Verde";
        veiculo.Modelo = "Opala";
        estacionamento.RegistrarEntradaVeiculo(veiculo);

        Veiculo veiculoAlterado = new Veiculo();
        veiculoAlterado.Proprietario = "José Silva";
        veiculoAlterado.Placa = "ZXC-8524";
        veiculoAlterado.Cor = "Preto"; // Alterada
        veiculoAlterado.Modelo = "Opala";

        // Act
        Veiculo alterado = estacionamento.AlterarDadosVeiculo(veiculoAlterado);

        // Assert
        Assert.Equal(alterado.Cor, veiculoAlterado.Cor);
    }

    public void Dispose()
    {
        SaidaConsoleTeste.WriteLine("Dispose foi invocado");
    }
}