using System.Collections.Generic;
using SapphireApi.Data.Adminsitration.Setup.Series;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Adminsitration.Setup.Objects {
  public class ObjectModel: IdentificableModel {
    public ObjectModel(){
      series = new HashSet<SerieModel>();
    }
    public string code { get; set; }
    public string description { get; set; }
    public string docPrefix { get; set; }
    public int? defaultSerieId { get; set; }
    public virtual ICollection<SerieModel> series { get; set; }
    public SerieModel deafultSerie { get; set; }
  } 
} 