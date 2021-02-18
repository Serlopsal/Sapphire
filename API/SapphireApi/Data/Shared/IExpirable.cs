using System;

namespace SapphireApi.Data.Shared{
  public interface IExpitable {
    DateTime docDate { get; set; }
    DateTime docDueDate { get; set; }
  }
}