using System;

namespace SapphireApi.Data.Shared{
  public interface ILockeable {
    bool isLocked { get; set; }
  }
}