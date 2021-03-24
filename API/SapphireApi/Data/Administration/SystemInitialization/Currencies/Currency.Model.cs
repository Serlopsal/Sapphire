using System.Collections.Generic;
using SapphireApi.Data.Adminsitration.SystemInitialization.Company;
using SapphireApi.Data.Adminsitration.SystemInitialization.Currencies.Rates;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Adminsitration.SystemInitialization.Currencies {
  public class CurrencyModel: AuditableModel {
    public string currCode { get; set; }
    public string currName { get; set; }

    public virtual CompanyModel mainFor { get; set; }
    public virtual CompanyModel sysFor { get; set; }
    public virtual ICollection<CurrencyRateModel> currRates { get; set; }
  }
}