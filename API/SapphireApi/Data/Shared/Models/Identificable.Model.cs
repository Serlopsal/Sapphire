namespace SapphireApi.Data.Shared.Models {
  public abstract class IdentificableModel : AuditableModel, IIdentificable {
    public int id { get; set; }
  }
}