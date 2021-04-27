using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Wallet.PaymentMethod {
  public class PaymentMethodDetailModel: IdentificableModel {
    public int paymentMethodId { get; set; }
    public int extraMonths { get; set; }
    public int extraDays { get; set; }
    public float minPrcnt { get; set; }
    public virtual PaymentMethodModel paymentMethod { get; set; }
  }
}