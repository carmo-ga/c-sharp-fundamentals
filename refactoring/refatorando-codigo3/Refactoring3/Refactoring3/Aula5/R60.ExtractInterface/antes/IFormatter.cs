namespace refatoracao.R60.ExtractInterface.antes
{
    public interface IFormatter
    {
        string Format(string value);
        string Unformat(string value);
        bool IsFormatted(string value);
        bool CanBeFormatted(string value);
    }
}