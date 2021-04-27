using System.Collections.Generic;
using SapphireApi.Data.Marketing.Pricing.PriceList;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Wallet.PaymentMethod {
  public class PaymentMethodModel: AuditableModel {
    public string pymntCode { get; set; }
    public string pymntName { get; set; }
    public int extraMonths { get; set; }
    public int extraDays { get; set; }
    public int qtyOfDues { get; set; }
    public int enablePriceList { get; set; }
    public int priceListId { get; set; }
    public virtual PriceListModel priceListModel { get; set; }
    public virtual ICollection<PaymentMethodDetailModel> dueDetails { get; set; }
  }
}