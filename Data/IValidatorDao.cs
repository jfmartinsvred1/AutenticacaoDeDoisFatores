namespace AutenticacaoDeDoisFatores.Data
{
    public interface IValidatorDao
    {
        public string GenerateQrCode(string email);
        public string ValidateCode(string code, string key);
    }
}
