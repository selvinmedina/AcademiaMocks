﻿namespace AcademiaMocks.Features.Facturacion.Dtos
{
    public class PaymentDetails
    {
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string ExpiryDate { get; set; }
        public string CVV { get; set; }
        public decimal Amount { get; set; }
    }
}
