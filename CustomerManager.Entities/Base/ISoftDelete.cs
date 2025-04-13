namespace CustomerManager.Entities.Base;

public  interface ISoftDelete
{
    string? DeletedBy { get;}
    DateTime? DeletedOn { get;}
    bool IsDelete { get; }
    void Delete(string user);
}
