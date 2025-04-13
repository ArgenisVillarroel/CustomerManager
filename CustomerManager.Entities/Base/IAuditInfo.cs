namespace CustomerManager.Entities.Base;

public interface IAuditInfo
{
    string CreatedBy { get; }
    DateTime CreatedOn { get;}
    string? LastModifiedBy { get; }
    DateTime? LastModifiedOn { get;}
    void LastModifiedEntry(string lastModifiedBy, DateTime lastModifiedOn);
}
