using System.Collections.Generic;
using SapphireApi.Data.Marketing.BusinessPartners.BusinessPartnerCards;
using SapphireApi.Data.Marketing.Pricing.PriceList;
using SapphireApi.Data.Shared;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Marketing.BusinessPartners.BusinessPartnerGroup {
  public class BusinessPartnerCardGroupModel: IdentificableModel, ILockeable {
    public BusinessPartnerCardGroupModel() {
        cards = new HashSet<BusinessPartnerCardModel>();
    }
    public string groupName { get; set; }
    public CardType onlyCardType { get; set; }
    public bool isLocked { get; set; }
    public int defaultPriceListId { get; set; }
    public virtual PriceListModel defaultPriceList { get; set; }
    public virtual ICollection<BusinessPartnerCardModel> cards { get; set; }
  }
}