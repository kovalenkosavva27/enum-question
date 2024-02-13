/// <summary>
/// Статусы субъекта.
/// </summary>
public enum SubjectStatuses
{
    /// <summary>
    /// Доступен.
    /// </summary>
    [EnumMember(Value = "AVAILABLE")]
    Available = 0,

    /// <summary>
    /// Удален.
    /// </summary>
    [EnumMember(Value = "REMOVED")]
    Removed = 1,

    /// <summary>
    /// Исключен.
    /// </summary>
    [EnumMember(Value = "SCREEN_OUT")]
    ScreenOut = 2,

    /// <summary>
    /// Зачислен в исследование.
    /// </summary>
    [EnumMember(Value = "ENROLL_IN_STUDY")]
    EnrollInStudy = 3,

    /// <summary>
    /// Прекращено.
    /// </summary>
    [EnumMember(Value = "STOPPED")]
    Stopped = 4
}