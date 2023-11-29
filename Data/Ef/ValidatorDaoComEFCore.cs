using AutenticacaoDeDoisFatores.Models;
using Google.Authenticator;
using Microsoft.AspNetCore.Identity;

namespace AutenticacaoDeDoisFatores.Data.Ef
{
    public class ValidatorDaoComEFCore:IValidatorDao
    {
        readonly TwoFactorAuthenticator _twoFactorAuthenticator;
        AuthContext _context;
        UserManager<User> _userManager;

        public ValidatorDaoComEFCore(AuthContext context, UserManager<User> userManager)
        {
            _twoFactorAuthenticator = new TwoFactorAuthenticator();
            _context = context;
            _userManager = userManager;
        }
        public string GenerateQrCode(string email)
        {
            string key = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10);
            SetupCode setupInfo = _twoFactorAuthenticator.GenerateSetupCode("Api De João Victor Fernandes Martins (2FA)", email, key, false, 3);

            ValidatorModel validator = new ValidatorModel(setupInfo.QrCodeSetupImageUrl,key,email);
            _context.ValidatorModels.Add(validator);
            _context.SaveChanges();

            return setupInfo.QrCodeSetupImageUrl;
        }
        public string ValidateCode(string code, string email)
        {
            var validator = _context.ValidatorModels.FirstOrDefault(e=>e.Email==email);

            var user =  _context.Users.FirstOrDefault(u => u.NormalizedEmail==email.ToUpper());  
            
            user.Validator= _twoFactorAuthenticator.ValidateTwoFactorPIN(validator.Key, code);

            _context.Users.Update(user);
            _context.SaveChanges();

            if (user.Validator)
            {
                var validatorRemove = _context.ValidatorModels.FirstOrDefault(e=>e.Email.ToUpper()==email.ToUpper());
                _context.ValidatorModels.Remove(validatorRemove);
                _context.SaveChanges();
                return "Usuario autenticado";
            }

            return "Usuario nao autenticado";

            
        }
    }
}
