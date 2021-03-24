using System;

namespace SapphireApi.Data.Shared{
  public interface IActivable {
    bool isActive { get; set; }
  }
}