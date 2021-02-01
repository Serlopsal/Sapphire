namespace SapphireApi.Data.Shared.Models {
  internal abstract class IdentificableModel : IIdentificable {
    public int id { get; set; }
  }
}