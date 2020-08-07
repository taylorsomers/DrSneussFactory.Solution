using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.Engineers = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }

    [DisplayName("Machine Name")]
    public string MachineName { get; set; }

    [DisplayName("Machine Description")]
    public string MachineDescription { get; set; }
    public ICollection<EngineerMachine> Engineers { get; }
  }
}