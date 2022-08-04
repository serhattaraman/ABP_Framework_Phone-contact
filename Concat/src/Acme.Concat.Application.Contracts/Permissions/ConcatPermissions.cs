namespace Acme.Concat.Permissions;

public static class ConcatPermissions
{
    public const string GroupName = "Concat";

    public static class Concats
    {
        public const string Default = GroupName + ".Concats";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
