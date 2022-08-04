using Acme.Concat.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.Concat.Permissions;

public class ConcatPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var concatGroup = context.AddGroup(ConcatPermissions.GroupName, L("Permission:Concat"));

        var concatsPermission = concatGroup.AddPermission(ConcatPermissions.Concats.Default, L("Permission:Concats"));
        concatsPermission.AddChild(ConcatPermissions.Concats.Create, L("Permission:Concats.Create"));
        concatsPermission.AddChild(ConcatPermissions.Concats.Edit, L("Permission:Concats.Edit"));
        concatsPermission.AddChild(ConcatPermissions.Concats.Delete, L("Permission:Concats.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ConcatResource>(name);
    }
}
