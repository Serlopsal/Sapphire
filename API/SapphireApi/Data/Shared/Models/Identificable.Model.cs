namespace SapphireApi.Data.Shared.Models {
  public abstract class IdentificableModel : IIdentificable {
    public int id { get; set; }
  }
}