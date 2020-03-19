namespace SimplCommerce.Module.Payments.Models
{
    public class ProcessTransactionResponse
    {
        public ProcessTransactionResponse()
        {
            
        }
        public ProcessTransactionResponse(string message,bool status)
        {
            Message = message;   
            Success = status;
        }        
        public long PaymentId { get; set; }
        public bool Success { get; set; }           
        public string Message { get; set; }                
    }   
}