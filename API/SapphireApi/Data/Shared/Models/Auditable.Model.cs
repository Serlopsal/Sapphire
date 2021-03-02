using System;
using SapphireApi.Data.Adminsitration.Setup.Objects;
using SapphireApi.Data.Identity;

namespace SapphireApi.Data.Shared.Models {
  public abstract class AuditableModel: ICreated, IUpdated, ITypable {
    public int objType { get; set; }
    public virtual ObjectModel obj { get; set; }
    public DateTime createdAt { get; set; }
    public string createdBy { get; set; }
    public DateTime updatedAt { get; set; }
    public string updatedBy { get; set; }
    public virtual UserModel creatorUsr { get; set; }
    public virtual UserModel updaterUsr { get; set; }
  }
}