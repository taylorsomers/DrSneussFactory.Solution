using System.Collections.Generic;
using System.ComponentModel;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.Machines = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }

    [DisplayName("Engineer Name")]
    public string EngineerName { get; set; }

    public virtual ICollection<EngineerMachine> Machines { get; set; }
  }
}