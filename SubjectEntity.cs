/// <summary>
/// Сущность субъекта.
/// </summary>
public sealed class SubjectEntity
{
    /// <summary>
    /// Уникальный идентификатор субъекта.
    /// </summary>
    public long Id { get; set; }
    
    /// <summary>
    /// Статус субъекта.
    /// </summary>
    public SubjectStatuses? Status { get; set; }
}