namespace CustomerManager.Entities;

public class CustomerType : EntityBase<int>
{
    public static CustomerType Instance(int id, string description) => new(id, description); 
    private  CustomerType(int id, string description) : base(id)
    {
        Description = description;  
    }

    public string Description { get; private set; }
}
