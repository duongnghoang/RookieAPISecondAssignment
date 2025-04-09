namespace PersonAPI.Application.Validators;

public static class ValidationErrorMessage
{
    public static string NullOrEmpty(string propertyName) =>
        $"{propertyName} cannot be null or empty.";
    public static string InvalidEnum<TEnum>() =>
        $"The value of {typeof(TEnum).Name} must be one of the following: {string.Join(", ", Enum.GetNames(typeof(TEnum)))}";
    public static string InvalidDate(string propertyName) => $"{propertyName} must be a valid datetime";
    public static string InvalidDateRange(string propertyName, DateTime startDate, DateTime endDate) =>
        $"{propertyName} must be between {startDate:yyyy-MM-dd} and {endDate:yyyy-MM-dd}";
}