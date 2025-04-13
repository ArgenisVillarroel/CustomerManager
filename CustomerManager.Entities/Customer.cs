namespace CustomerManager.Entities;

public class Customer
{
    public static Customer Instance(int id, string firstName, string lastName, string type, string address, string user) => new(id, firstName, lastName, type, address, user);

    private Customer(int id, string firstName, string lastName, string type, string address, string user)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Type = type;
        Address = address;
        CreatedBy = user;
        CreatedOn = DateTime.Now;
        LastModifiedBy = null;
        LastModifiedOn = null;
        DeletedBy = null;
        DeletedOn = null;
        IsDelete = false;
    }

    public int Id { get; private set; } 
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Type { get; private set; }
    public string Address { get; private set; }

    public string FullName => $"{FirstName}  {LastName}";
    public string AuditInfo => $"Creado: {CreatedBy}/{CreatedOn} -  Modificado {LastModifiedBy}/{LastModifiedOn} - Eliminado {IsDelete} {DeletedBy}/{DeletedOn}";

    public string CreatedBy { get; private set; }
    public DateTime CreatedOn { get; private set; }
    public string? LastModifiedBy { get; private set; }
    public  DateTime? LastModifiedOn { get; private set; }

    public string? DeletedBy {  get; private set; }
    public DateTime? DeletedOn { get; private set; }
    public bool IsDelete { get; private set; }

    public void ChangeName(string fistName, string lastName, string user)
    {
        FirstName = fistName;
        LastName = lastName;
        LastModifiedEntry(user, DateTime.Now);
    }

    public void LastModifiedEntry(string lastModifiedBy, DateTime lastModifiedOn)
    {
        LastModifiedBy = lastModifiedBy;
        LastModifiedOn = lastModifiedOn;
    }

    public void Delete(string user)
    {
        if (IsDelete)
        {
            IsDelete = false;
            DeletedBy = null;
            DeletedOn = null;
        }
        else
        {
            IsDelete = true;
            DeletedBy = user;
            DeletedOn = DateTime.Now;
        }
    }
}
