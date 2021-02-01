using System;

namespace SapphireApi.Data.Shared{
  internal interface ICreated {
    DateTime createdAt { get; set; }
  }
}