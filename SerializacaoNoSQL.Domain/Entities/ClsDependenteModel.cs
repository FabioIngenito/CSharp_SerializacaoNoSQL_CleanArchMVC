using SerializacaoNoSQL.Domain.Validation;

namespace SerializacaoNoSQL.Domain.Entities;

public sealed class ClsDependenteModel
{
    #region Construtores

    public ClsDependenteModel(string nome)
    {
        ValidacaoDomain(nome);
    }

    public ClsDependenteModel(string nome, char sexo, DateTime nascimento, string parantesco)
    {
        ValidacaoDomain(nome);
        Sexo = sexo;
        Nascimento = nascimento;
        Parentesco = parantesco;
    }

    #endregion

    #region Atributos

    private string? _nome;
    private char _sexo;
    private DateTime _nascimento;
    private string? _parentesco;
    private string _funcionarioCPF;
    private ClsFuncionarioModel _funcionario;

    #endregion

    #region Propriedades

    public string? Nome
    {
        get { return _nome; }
        private set { _nome = value; }
    }

    public char Sexo
    {
        get { return _sexo; }
        private set { _sexo = value; }
    }

    public DateTime Nascimento
    {
        get { return _nascimento; }
        private set { _nascimento = value; }
    }

    public string? Parentesco
    {
        get { return _parentesco; }
        private set { _parentesco = value; }
    }

    public string FuncionarioCPF
    {
        get { return _funcionarioCPF; }
        private set { _funcionarioCPF = value; }
    }

    public ClsFuncionarioModel Funcionario
    {
        get { return _funcionario; }
        private set { _funcionario = value; }
    }

    #endregion

    #region Comportamento
    
    private void ValidacaoDomain(string nome)
    {
        ValidacaoExcecaoDomain.Quando(string.IsNullOrEmpty(nome), 
            "Nome Inválido, nome é requerido.");

        ValidacaoExcecaoDomain.Quando(nome.Length < 3,
            "Nome Inválido, muito pequeno, precisa ter pelo menos 3 caracteres.");

        Nome = nome;
    }

    #endregion

}
