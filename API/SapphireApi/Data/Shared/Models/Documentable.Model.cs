namespace SapphireApi.Data.Shared.Models {
  public abstract class DocumentableModel: AuditableModel, ICancelable, IPrintable, IClosable, INumerable, ICommentable, IReferenceable {
    public bool isCanceled { get; set; }
    public bool isPrinted { get; set; }
    public bool isClosed { get; set; }
    public int docNum { get; set; }
    public string reference { get; set; }
    public string comment { get; set; }
  } 
}