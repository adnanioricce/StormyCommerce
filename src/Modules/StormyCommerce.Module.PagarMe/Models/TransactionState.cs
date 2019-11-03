namespace StormyCommerce.Module.PagarMe.Models
{
    public static class TransactionState
    {
        ///<summary>
        /// Transaction is in authorization process
        ///</summary>
        public static readonly string Processing = "processing";

        ///<summary>
        /// Transaction was authorized.
        /// Customer has money on account and that value was stored to future use in captura,
        /// that should happen untill five days for transaction created with api_key.
        /// If not captured, authorization is automatically cancelled by the bank provider, and the state remains as authorized
        ///</summary>
        public static readonly string Authorized = "authorized";

        ///<summary>
        /// Paid Transaction. Authorized and captured with success.
        /// For boleto,means that the PagarMe API already identify the payment
        ///</summary>
        public static readonly string Paid = "paid";

        ///<summary>
        /// Transaction totally refunded
        ///</summary>
        public static readonly string Refunded = "refunded";

        ///<summary>
        /// Transaction waiting payment(valid state for boleto)
        ///</summary>
        public static readonly string WaitingPayment = "waiting_payment";

        ///<summary>
        /// Transaction of type boleto and that is waiting for confirmation of the refund value
        ///</summary>
        public static readonly string PendingRefund = "pending_refund";

        ///<summary>
        /// Transaction refused,not authorized
        ///</summary>
        public static readonly string Refused = "refused";

        // TODO:Need better explanation
        ///<summary>
        /// Transaction was chargebacked.
        ///</summary>
        public static readonly string Chargeback = "chargeback";

        ///<summary>
        /// Transaction sended to manual review by a specialist
        ///</summary>
        public static readonly string Analyzing = "analyzing";

        ///<summary>
        /// Transaction with pending review by the vendor.
        /// stay in this state for 48 hours
        ///</summary>
        public static readonly string PendingReview = "pending_review";
    }
}
