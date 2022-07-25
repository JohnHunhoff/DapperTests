namespace DapperApi.Model.HumanResources;


public class Employee
{
  public int BusinessEntityId { get; set; }
  public string NationalIDNumber { get; set; }
  public string LoginID { get; set; }
  public int OrganizationLevel { get; set; }
  public string JobTitle { get; set; }
  public DateTime BirthDate { get; set; }
  public char MaritalStatus { get; set; }
  public char Gender { get; set; }
  public DateTime HireDate { get; set; }
  public bool SalariedFlag { get; set; }
  public int VacationHours { get; set; }
  public int SickLeaveHours { get; set; }
  public bool CurrentFlag { get; set; }
  public Guid Rowguid { get; set; }
  public DateTime ModifiedDate { get; set; } 
}
