using SapphireApi.Data.Adminsitration.Setup.Objects;

namespace SapphireApi.Data.Shared.Models {
  public abstract class IdentificableModel : IIdentificable {
    public int id { get; set; }
    public int objType { get; set; }
    public virtual ObjectModel obj { get; set; }
  }
}