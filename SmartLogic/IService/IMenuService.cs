using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace SmartLogic
{
    public interface IMenuService
    {
        // Parent Menu
        Task<MenuGroup> FindMenuGroup(int MenuGroupID);
        Task<List<MenuGroup>> MenuGroups();
        List<MenuGroup> GetMenuGroups();
        Task<int> Save(MenuGroup MenuGroup);
        Task<int> Update(MenuGroup MenuGroup);
        Task<int> DeleteMenuGroup(int id);
        Task<int> ActionMenuGroup(int id, DatabaseAction action);

        //Menus

        Task<Menu> FindMenu(int menuID);
        Task<List<Menu>> Menus();
        Task<List<Menu>> GetMenusFromParent(int MenuGroupID);
        List<Menu> GetMenus();
        Task<int> Save(Menu menu);
        Task<int> Update(Menu menu);
        Task<int> DeleteMenu(int id);
        Task<int> ActionMenu(int menuID, DatabaseAction action);

    }
}
