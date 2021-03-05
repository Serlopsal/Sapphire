using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Adminsitration.Setup.UOM.Converter {
  public class UOMConverterModel: IdentificableModel {
    public int fromOneId { get; set; }
    public int toManyId { get; set; }
    public float rate { get; set; }
    public virtual UOMModel fromOne { get; set; }
    public virtual UOMModel toMany { get; set; }
  }
}