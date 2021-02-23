using System;

namespace SapphireApi.Data.Shared{
  public interface IExpirable {
    DateTime docDueDate { get; set; }
  }
}