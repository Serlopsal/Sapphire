using System;

namespace SapphireApi.Data.Shared{
  public interface IClosable {
    bool isClosed { get; set; }
  }
}