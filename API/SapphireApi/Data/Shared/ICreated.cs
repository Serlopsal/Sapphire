using System;

namespace SapphireApi.Data.Shared{
  public interface ICreated {
    DateTime createdAt { get; set; }
    string createdBy { get; set; } 
  }
}