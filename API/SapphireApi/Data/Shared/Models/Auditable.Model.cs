using System;

namespace SapphireApi.Data.Shared.Models {
  public abstract class AuditableModel : IdentificableModel, ICreated, IUpdated {
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
  }
}