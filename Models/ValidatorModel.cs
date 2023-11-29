using System.ComponentModel.DataAnnotations;

namespace AutenticacaoDeDoisFatores.Models
{
    public class ValidatorModel
    {
        public ValidatorModel(string qrCode, string key, string email)
        {
            QrCode = qrCode;
            Key = key;
            Email = email;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string QrCode { get; set; }
        [Required]
        public string Key { get; set; }
        [Required]
        public string Email { get; set; }
        
    }
}
