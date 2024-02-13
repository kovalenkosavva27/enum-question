public class EnumMemberValueConverter<TEnum> : ValueConverter<TEnum, string>
{
    public EnumMemberValueConverter()
        : base(
              value => GetEnumMemberValue(value),
              dbValue => GetEnumValue(dbValue))
    { }

    private static string GetEnumMemberValue(TEnum value)
    {
        var enumMemberAttribute = typeof(TEnum)
            .GetField(value.ToString())
            .GetCustomAttributes(false)
            .OfType<EnumMemberAttribute>()
            .FirstOrDefault();

        return enumMemberAttribute?.Value ?? value.ToString();
    }

    private static TEnum GetEnumValue(string dbValue)
    {
        var enumType = typeof(TEnum);

        foreach (var field in enumType.GetFields())
        {
            var enumMemberAttribute = field.GetCustomAttributes(false)
                .OfType<EnumMemberAttribute>()
                .FirstOrDefault();

            if (enumMemberAttribute != null && enumMemberAttribute.Value == dbValue)
                return (TEnum)Enum.Parse(enumType, field.Name);
        }

        return (TEnum)Enum.Parse(enumType, dbValue);
    }
}