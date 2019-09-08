using System;

namespace StormyCommerce.Module.PagarMe.Models
{
    public static class TransactionState
    {
        ///<summary>
        /// Transaction is in authorization process
        ///</summary>
        public static const string Processing = "processing"; 
        ///<summary>
        /// Transaction was authorized.
        /// Customer has money on account and that value was stored to future use in captura,
        /// that should happen untill five days for transaction created with api_key. 
        /// If not captured, authorization is automatically cancelled by the bank provider, and the state remains as authorized
        ///</summary>
        public static const string Authorized = "authorized"; 
        ///<summary>
        /// Paid Transaction. Authorized and captured with success. 
        /// For boleto,means that the PagarMe API already identify the payment
        ///</summary>
        public static const string Paid = "paid"; 
        ///<summary>
        /// Transaction totally refunded
        ///</summary>
        public static const string Refunded = "refunded";
        ///<summary>
        /// Transaction waiting payment(valid state for boleto)
        ///</summary>
        public static const string WaitingPayment = "waiting_payment";
        ///<summary>
        /// Transaction of type boleto and that is waiting for confirmation of the refund value
        ///</summary>
        public static const string PendingRefund = "pending_refund";
        ///<summary>
        /// Transaction refused,not authorized
        ///</summary>
        public static const string Refused = "refused";
        // TODO:Need better explanation
        ///<summary>
        /// Transaction was chargebacked.
        ///</summary>
        public static const string Chargeback = "chargeback";
        ///<summary>
        /// Transaction sended to manual review by a specialist
        ///</summary>
        public static const string Analyzing = "analyzing";
        ///<summary>
        /// Transaction with pending review by the vendor. 
        /// stay in this state for 48 hours
        ///</summary>
        public static const string PendingReview = "pending_review";

    }
}
