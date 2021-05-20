using System.Collections.Generic;
using SapphireApi.Data.Administration.Locations.Country;
using SapphireApi.Data.Administration.SystemInitialization.Currencies;
using SapphireApi.Data.Identity;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Administration.SystemInitialization.Company{
  public class CompanyModel: IdentificableModel {
    public CompanyModel() {
      // Navigation Properties
      users = new HashSet<UserModel>();
    }
    public string companyName { get; set; }
    public string companyAddress { get; set; }
    public string zipCode { get; set; }
    public string city { get; set; }
    public string webPage { get; set; }
    public string phone1 { get; set; }
    public string phone2 { get; set; }
    public string mainCur { get; set; }
    public string sysCur { get; set; }
    public int countryId { get; set; }

    // Navigation Properties
    public virtual CountryModel country { get; set; }
    public virtual CurrencyModel mainCurrency { get; set; }
    public virtual CurrencyModel systemCurrency { get; set; }
    public virtual ICollection<UserModel> users { get; set; }
  }
}