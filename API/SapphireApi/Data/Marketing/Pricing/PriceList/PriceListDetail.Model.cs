using SapphireApi.Data.Inventory.Items;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Marketing.Pricing.PriceList {
  public class PriceListDetailModel: IdentificableModel {
    public int priceListId { get; set; }
    public string itemCode { get; set; }
    public float price { get; set; }
    public virtual PriceListModel priceList { get; set; }
    public virtual ItemModel item { get; set; }
  }
}