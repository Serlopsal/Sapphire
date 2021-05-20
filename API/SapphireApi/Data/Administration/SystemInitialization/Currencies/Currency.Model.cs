using System.Collections.Generic;
using SapphireApi.Data.Administration.SystemInitialization.Company;
using SapphireApi.Data.Administration.SystemInitialization.Currencies.Rates;
using SapphireApi.Data.Marketing.BusinessPartners.BusinessPartnerCards;
using SapphireApi.Data.Marketing.Pricing.PriceList;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Administration.SystemInitialization.Currencies {
  public class CurrencyModel: AuditableModel {
    public string currCode { get; set; }
    public string currName { get; set; }
    public virtual CompanyModel mainFor { get; set; }
    public virtual CompanyModel sysFor { get; set; }
    public virtual ICollection<CurrencyRateModel> currRates { get; set; }
    public virtual ICollection<PriceListModel> priceLists { get; set; }
    public virtual ICollection<BusinessPartnerCardModel> cards { get; set; }
  }
}
