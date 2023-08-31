namespace SerializacaoNoSQL.Domain.Validation;

public class ValidacaoExcecaoDomain : Exception
{
    public ValidacaoExcecaoDomain(string error) :base(error)
    {
        
    }

    public static void Quando(bool hasError, string error)
    {
        if (hasError)
            throw new ValidacaoExcecaoDomain(error);
    }
}
