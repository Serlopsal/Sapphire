using System;
using SapphireApi.Data.Identity;

namespace SapphireApi.Data.Shared.Models {
  public abstract class AuditableModel : IdentificableModel, ICreated, IUpdated {
    public DateTime createdAt { get; set; }
    public string createdBy { get; set; }
    public DateTime updatedAt { get; set; }
    public string updatedBy { get; set; }
    public virtual UserModel creatorUsr { get; set; }
    public virtual UserModel updaterUsr { get; set; }
  }
}