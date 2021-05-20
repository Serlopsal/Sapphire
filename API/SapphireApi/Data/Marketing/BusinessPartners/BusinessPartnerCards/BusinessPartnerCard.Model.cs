using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Marketing.BusinessPartners.BusinessPartnerGroup;
using SapphireApi.Data.Administration.SystemInitialization.Currencies;
using SapphireApi.Data.Shared;

namespace SapphireApi.Data.Marketing.BusinessPartners.BusinessPartnerCards {
  public class BusinessPartnerCardModel: AuditableModel, ILockeable {
    public string cardCode { get; set; }
    public string cardName { get; set; }
    public CardType cardType { get; set; }
    public int cardGroupId { get; set; }
    public string identifier { get; set; }
    public string currCode { get; set; }
    public string email { get; set; }
    public string website { get; set; }
    public bool isLocked { get; set; }
    public virtual BusinessPartnerCardGroupModel cardGroup { get; set; }
    public virtual CurrencyModel currency { get; set; }
  }
}