using System;
using SapphireApi.Data.Adminsitration.Setup.Series;

namespace SapphireApi.Data.Shared.Models {
  public abstract class DocumentableModel: IdentificableModel, ICalendarizable, ICancelable, IPrintable, IClosable, INumerable, ICommentable, IReferenceable {
    public DateTime docDate { get; set; }
    public bool isCanceled { get; set; }
    public bool isPrinted { get; set; }
    public bool isClosed { get; set; }
    public int docNum { get; set; }
    public string reference { get; set; }
    public string comment { get; set; }
    public int serieId { get; set; }
    public virtual SerieModel serie { get; set; }
  } 
}