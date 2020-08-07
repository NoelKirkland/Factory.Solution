using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.Machine = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set; }
    public bool ActiveIdle { get; set; }
    [DataType(DataType.Date)]
    public DateTime LastLicensed { get; set; }
    public ICollection<EngineerMachine> Machines { get; set; }
  }
}