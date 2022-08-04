using System.Threading.Tasks;
using Acme.Concat.Localization;
using Acme.Concat.MultiTenancy;
using Acme.Concat.Permissions;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.Modularity.PlugIns;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Acme.Concat.Web.Menus;

public class ConcatMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<ConcatResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                ConcatMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0

            )
        );
      

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

        var concatMenu = new ApplicationMenuItem(
            "Concat",
            l["Menu:Concat"],
            icon: "fa fa-user"
        );

        context.Menu.AddItem(concatMenu);

        //CHECK the PERMISSION
        if (await context.IsGrantedAsync(ConcatPermissions.Concats.Default))
        {
            concatMenu.AddItem(new ApplicationMenuItem(
                "Concat.Concats",
                l["Menu:Concats"],
                icon:"plus",
                url: "/Concats"
            ));
        }
    }
}
