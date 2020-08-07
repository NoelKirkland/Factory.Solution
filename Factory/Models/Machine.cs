using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.Engineer = new HashSet<EngineerMachine>();
    }
    public int MachineId { get; set; }
    [DisplayName("Name of Machine")]
    public string MachineName { get; set; }
    [DisplayName("Machine Status")]
    public int Status { get; set; }
    [DisplayName("Date of last inspection")]
    [DataType(DataType.Date)]
    public DateTime LastInspected { get; set; }
    public ICollection<EngineerMachine> Engineer { get; set; }
  }
}