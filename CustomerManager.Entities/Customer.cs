namespace CustomerManager.Entities;

public class Customer : EntityBase<int>
{
    public static Customer Instance(int id, string firstName, string lastName, CustomerType type, string address, string user) => new(id, firstName, lastName, type, address, user);

    private Customer(int id, string firstName, string lastName, CustomerType type, string address, string user) : base(id)
    {
        if (type.IsDelete) throw new ArgumentException($"El tipo {type.Description} esta marcado como eliminado");

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

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public CustomerType Type { get; private set; }
    public string Address { get; private set; }

    public string FullName => $"{FirstName}  {LastName}";


    public void ChangeName(string fistName, string lastName, string user)
    {
        FirstName = fistName;
        LastName = lastName;
        LastModifiedEntry(user, DateTime.Now);
    }
}
