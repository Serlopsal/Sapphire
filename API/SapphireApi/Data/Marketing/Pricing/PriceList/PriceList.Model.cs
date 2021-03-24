using System.Collections.Generic;
using SapphireApi.Data.Adminsitration.SystemInitialization.Currencies;
using SapphireApi.Data.Marketing.BusinessPartners.BusinessPartnerGroup;
using SapphireApi.Data.Shared;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Marketing.Pricing.PriceList {
  public class PriceListModel: IdentificableModel, IActivable {
    public string listName { get; set; }
    public string curCode { get; set; }
    public int? baseList { get; set; }
    public float? factor { get; set; }
    public bool isActive { get; set; }
    public virtual CurrencyModel currency { get; set; }
    public virtual ICollection<PriceListDetailModel> details { get; set; }
    public virtual ICollection<BusinessPartnerCardGroupModel> businessPartnerCardGroups { get; set; }
  }
}