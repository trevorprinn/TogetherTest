using System.ComponentModel.DataAnnotations.Schema;

namespace TogetherTest.Database {
    [Table("Address")]
    public class Address {

        public int? Id { get; set; }

        public string? AddressLine1 { get; set; }

        public string? AddressLine2 { get; set; }

        public string? PostCode { get; set; }

        public string? PostCodeIndex { get; set; }

        [Column(TypeName = "decimal(18,0)")]
        public decimal? LastSoldPrice { get; set; }

        public string FormattedAddress => string.Join(Environment.NewLine, new string[] { AddressLine1!, AddressLine2!, PostCode! }.Where(l => !string.IsNullOrWhiteSpace(l)));
    }
}
