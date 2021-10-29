namespace SampleAPI.Models
{
    public class Request
    {
        public string OrderId { get; set; }
        public DateTime CreatedOn { get; set; }
        public BookingInfo Info { get; set; }
        public List<FormOfPayment> PaymentMethods { get; set; }
        public OccupantType Type { get; set; }
    }    
}
