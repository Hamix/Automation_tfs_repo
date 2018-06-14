namespace ExtCore.Data.Entities.Abstractions
{
    public interface IAuditableEntity
    {
        int? ModifierUserID { get; set; }
        int? ModifierPredicateID { get; set; }
        int? ModifierSessionID { get; set; }
    }
}
