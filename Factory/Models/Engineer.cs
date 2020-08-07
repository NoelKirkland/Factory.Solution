using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.Machines = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    [DisplayName("Name of Imagineer")]
    public string EngineerName { get; set; }
    [DisplayName("Is Imagineer currently repairing a Thing-a-Machine")]
    public bool ActiveIdle { get; set; }
    [DisplayName("Date of last licence renewal")]
    [DataType(DataType.Date)]
    public DateTime LastLicensed { get; set; }
    public ICollection<EngineerMachine> Machines { get; set; }
  }
}