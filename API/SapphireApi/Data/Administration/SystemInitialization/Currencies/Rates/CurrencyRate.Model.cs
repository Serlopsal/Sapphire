using System;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Administration.SystemInitialization.Currencies.Rates {
  public class CurrencyRateModel: AuditableModel {
    public DateTime rateDate { get; set; }
    public string curCode { get; set; }
    public float rate { get; set; }
    public virtual CurrencyModel currency { get; set; }
  }
}
