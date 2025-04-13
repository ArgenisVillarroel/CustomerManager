namespace CustomerManager.Entities.Base;

public abstract class EntityBase<TId>(TId id) : IAuditInfo, ISoftDelete
{
    public TId Id { get; protected set; } = id;
    public string CreatedBy { get; protected set; } = "";
    public DateTime CreatedOn { get; protected set; }
    public string? LastModifiedBy { get; protected set; }
    public DateTime? LastModifiedOn { get; protected set; }

    public string? DeletedBy { get; protected set; }
    public DateTime? DeletedOn { get; protected set; }
    public bool IsDelete { get; protected set; }

    public virtual string AuditInfo => $"Creado: {CreatedBy}/{CreatedOn} -  Modificado {LastModifiedBy}/{LastModifiedOn} - Eliminado {IsDelete} {DeletedBy}/{DeletedOn}";

    public virtual void LastModifiedEntry(string lastModifiedBy, DateTime lastModifiedOn)
    {
        LastModifiedBy = lastModifiedBy;
        LastModifiedOn = lastModifiedOn;
    }

    public virtual void Delete(string user)
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
