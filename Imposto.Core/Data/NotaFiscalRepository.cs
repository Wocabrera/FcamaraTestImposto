using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Data {
  public class NotaFiscalRepository {
    public string XmlFileFolder { get; set; }
    public string LoadRepository() {
      var appSettings = ConfigurationManager.AppSettings;
      return ConfigurationManager.AppSettings["XmlFile"];
    }
  }
}
