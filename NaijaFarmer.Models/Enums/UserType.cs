namespace NaijaFarmer.Models.Enums
{
    public enum UserType
    {
        Customer = 1,
        Farmer,
        Admin
    }
    public static class UserTypeExtension
    {
        public static string? ToStringValue(this UserType userType)
        {
            return userType switch
            {
                UserType.Customer => "user",
                UserType.Farmer => "farmer",
                UserType.Admin => "admin",
                _ => null
            };
        }
    }
}
