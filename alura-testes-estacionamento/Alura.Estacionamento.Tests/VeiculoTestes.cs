using Alura.Estacionamento.Modelos;
using Xunit.Abstractions;

namespace Alura.Estacionamento.Tests;

public class VeiculoTestes : IDisposable
{
    private Veiculo veiculo;
    public ITestOutputHelper SaidaConsoleTeste { get; }

    public VeiculoTestes(ITestOutputHelper _saidaConsoleTeste)
    {
        SaidaConsoleTeste = _saidaConsoleTeste;
        SaidaConsoleTeste.WriteLine("Construtor foi invocado");
        veiculo = new Veiculo();
    }

    [Fact(DisplayName="Teste nº 1")]
    [Trait("Funcionalidade", "Acelerar")]
    public void TestaVeiculoAcelerarComParametro10()
    {
        // Arrange
        // Veiculo veiculo = new Veiculo();

        // Act
        veiculo.Acelerar(10);

        // Assert
        Assert.Equal(100, veiculo.VelocidadeAtual);
    }

    [Fact(DisplayName="Teste nº 2")]
    [Trait("Funcionalidade", "Frear")]
    public void TestaVeiculoFrearComParametro10()
    {
        // Arrange
        // Veiculo veiculo = new Veiculo();

        // Act
        veiculo.Frear(10);

        // Assert
        Assert.Equal(-150, veiculo.VelocidadeAtual);
    }

    [Fact(Skip = "Teste ainda não implementado. Ignorar.")]
    public void ValidaNomeProprietarioDoVeiculo()
    {

    }

    [Fact]
    public void FichaDeInformacaoDoVeiculo()
    {
        // Arrange
        // Veiculo veiculo = new Veiculo();
        veiculo.Proprietario = "Carlos Silva";
        veiculo.Tipo = TipoVeiculo.Automovel;
        veiculo.Placa = "ZAP-7419";
        veiculo.Cor = "Verde";
        veiculo.Modelo = "Variante";

        // Act
        string dados = veiculo.ToString();

        // Assert
        Assert.Contains("Ficha do Veículo:", dados);
    }

    [Fact]
    public void TestaNomeProprietarioVeiculoComMenosDeTresCaracteres()
    {
        // Arrange
        string nomeProprietario = "ab";

        // Assert
        Assert.Throws<FormatException>(
            // Act
            () => new Veiculo(nomeProprietario)
        );
    }

    [Fact]
    public void TestaMensagemDeExcecaoDoQuartoCaracterDaPlaca()
    {
        // Arrange
        string placa = "ASDF8888";

        // Act
        var mensagem = Assert.Throws<FormatException>(
            () => new Veiculo().Placa = placa
        );

        // Assert
        Assert.Equal("O 4° caractere deve ser um hífen", mensagem.Message);
    }

    public void Dispose()
    {
        SaidaConsoleTeste.WriteLine("Dispose foi invocado");
    }
}