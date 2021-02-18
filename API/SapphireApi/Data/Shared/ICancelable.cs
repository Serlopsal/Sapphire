using System;

namespace SapphireApi.Data.Shared{
  public interface ICancelable {
    bool isCanceled { get; set; }
  }
}