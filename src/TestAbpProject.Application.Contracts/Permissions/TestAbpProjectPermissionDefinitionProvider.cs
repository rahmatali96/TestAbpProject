using TestAbpProject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TestAbpProject.Permissions;

public class TestAbpProjectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TestAbpProjectPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TestAbpProjectPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TestAbpProjectResource>(name);
    }
}
