using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class OfficialReceipt
    {
        [Key]
        public int Id { get; set; }
        public int ORNo { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Amount { get; set; }
        public string Char { get; set; } = string.Empty;
        public string Payor { get; set; } = string.Empty;

    }
}
