

using System.Collections.Generic;

namespace GW.Zorg.Web.Business.Models {
    public class ReturnCalculationLine {

        public ReturnCalculationLine(ReturnCalculationKind kind) {
            this.Kind = kind;
            this.PaymentLines = new List<ReturnCalculationPayment>();
        }

        public ReturnCalculationKind Kind { get; set; }
        public List<ReturnCalculationPayment> PaymentLines { get; set; }
    }
}