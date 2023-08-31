using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

// Site para conversão de JSON -> C#
// https://json2csharp.com/
//
// RETIRE: "ObjectId{ ... } (MAS DEIXE O VALOR)

namespace SerializacaoNoSQL.Domain.Entities;

public sealed class ClsFuncionarioModel
{
    #region Construtores

    public ClsFuncionarioModel()
    {

    }

    #endregion

    #region Atributos

    //NÃO USE:
    //[BsonRepresentation(BsonType.ObjectId)]
    //USE:
    [BsonId]
    private string? _cpf;
    private string? _nome;
    private string? _endereco;
    private byte _id_departamento;
    private string? _nome_departamento;
    private DateTime _nascimento;
    private char _sexo;
    private double _salario;
    private string? _telefone;
    private string? _cpf_supervisor;
    //private List<ClsDependenteModel>? _dependentes;
    private ICollection<ClsDependenteModel>? _dependentes;

    #endregion

    #region Propriedades

    [Required]
    public string? CPF
    {
        get { return _cpf; }
        private set { _cpf = value; }
    }

    [Required]
    public string? Nome
    {
        get { return _nome; }
        private set { _nome = value; }
    }

    public string? Endereco
    {
        get { return _endereco; }
        private set { _endereco = value; }
    }

    public byte Id_Departamento
    {
        get { return _id_departamento; }
        private set { _id_departamento = value; }
    }

    public string? Nome_Departamento
    {
        get { return _nome_departamento; }
        private set { _nome_departamento = value; }
    }

    public DateTime Nascimento
    {
        get { return _nascimento; }
        private set { _nascimento = value; }
    }

    public char Sexo
    {
        get { return _sexo; }
        private set { _sexo = value; }
    }

    public double Salario
    {
        get { return _salario; }
        private set { _salario = value; }
    }

    public string? Telefone
    {
        get { return _telefone; }
        private set { _telefone = value; }
    }

    public string? CPF_Supervisor
    {
        get { return _cpf_supervisor; }
        private set { _cpf_supervisor = value; }
    }

    //public List<ClsDependenteModel>? Dependentes
    //{
    //    get { return _dependentes; }
    //    set { _dependentes = value; }
    //}

    public ICollection<ClsDependenteModel>? Dependentes
    {
        get { return _dependentes; }
        set { _dependentes = value; }
    }

    #endregion
}
