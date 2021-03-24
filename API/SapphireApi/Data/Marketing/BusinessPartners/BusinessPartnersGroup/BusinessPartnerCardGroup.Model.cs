using SapphireApi.Data.Marketing.Pricing.PriceList;
using SapphireApi.Data.Shared;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Marketing.BusinessPartners.BusinessPartnerGroup {
  public class BusinessPartnerCardGroupModel: IdentificableModel, ILockeable {
    public string groupName { get; set; }
    public bool isLocked { get; set; }
    public int defaultPriceListId { get; set; }
    public virtual PriceListModel defaultPriceList { get; set; }
  }
}