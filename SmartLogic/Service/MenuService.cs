using Microsoft.EntityFrameworkCore;
using SmartDataAccess;
using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SmartLogic
{

    public class MenuService : IMenuService
    {
        private readonly DatabaseContext _context;

        public MenuService(DatabaseContext context)
        {
            _context = context;

        }
        // Parent Menu
        public async Task<MenuGroup> FindMenuGroup(int ParentMenuID)
        {
            return await _context.MenuGroups.Where(x => x.MenuGroupID == ParentMenuID).
                Include(x => x.Menus).OrderBy(m => m.OrderNo).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<List<MenuGroup>> MenuGroups()
        {
            return await _context.MenuGroups.Include(x => x.Menus).OrderBy(m => m.OrderNo).ToListAsync();
        }

        public List<MenuGroup> GetMenuGroups()
        {
            return _context.MenuGroups.Include(x => x.Menus).OrderBy(m => m.OrderNo).ToList();
        }

        public async Task<int> Save(MenuGroup ParentMenu)
        {
            ParentMenu.LastChangedBy = UtilityService.CurrentUserName;
            ParentMenu.LastChangedDate = DateTime.Now;
            _context.Add(ParentMenu);
            return (await _context.SaveChangesAsync());
        }
        public async Task<int> Update(MenuGroup ParentMenu)
        {
                    MenuGroup update = await FindMenuGroup(ParentMenu.MenuGroupID);
            if (ParentMenu.IsActiveMenu)
                // reset others and  activate only this
            await ResetActiveMenuGroup(ParentMenu.MenuGroupID);
            update.IsActiveMenu = ParentMenu.IsActive; // rule must be at least 1 active tab for all
            update.DisplayName = ParentMenu.DisplayName;
            update.CSSClass = UtilityService.HtmlDecode(ParentMenu.CSSClass);
            update.OrderNo = ParentMenu.OrderNo;
            update.IsActive = ParentMenu.IsActive;
            update.LastChangedBy = UtilityService.CurrentUserName;
            update.LastChangedDate = DateTime.Now;
            _context.Update(update);
            return await _context.SaveChangesAsync();
        }


        public async Task<int> ResetActiveMenuGroup(int menugroupID)
        {
            var menugroups = _context.MenuGroups.Where(mng => mng.MenuGroupID != menugroupID).ToList();
            menugroups.ForEach(a => a.IsActiveMenu = false);
            return await _context.SaveChangesAsync();

        }
        public async Task<int> DeleteMenuGroup(int id)
        {
            var parentMenu = await _context.MenuGroups.FindAsync(id);
            _context.MenuGroups.Remove(parentMenu);
            return (await _context.SaveChangesAsync());
        }


        public async Task<int> ActionMenuGroup(int id, DatabaseAction action)
        {
            MenuGroup ParentMenu = await FindMenuGroup(id);
            switch (action)
            {
                case DatabaseAction.Remove:
                    _context.MenuGroups.Remove(ParentMenu);
                    break;
                case DatabaseAction.Deactivate:
                case DatabaseAction.Reactivate:
                    ParentMenu.IsActive = DatabaseAction.Deactivate == action ? false : true;
                    ParentMenu.LastChangedBy = UtilityService.CurrentUserName;
                    ParentMenu.LastChangedDate = DateTime.Now;
                    _context.Update(ParentMenu);
                    break;
                default:
                    break;
            }
            return (await _context.SaveChangesAsync());
        }
        //Menus

        public async Task<Menu> FindMenu(int menuID)
        {
            return await _context.Menus.Where(rp => rp.MenuID == menuID)
         .FirstOrDefaultAsync();
        }

        public async Task<List<Menu>> Menus()
        {
            return await _context.Menus.OrderBy(m => m.OrderNo).ToListAsync();
        }

        public List<Menu> GetMenus()
        {
            return _context.Menus.OrderBy(m => m.OrderNo).ToList();
        }

        public async Task<int> Save(Menu menu)
        {
            menu.IsActive = true;
            menu.LastChangedBy = UtilityService.CurrentUserName;
            menu.LastChangedDate = DateTime.Now;
            _context.Add(menu);
            return (await _context.SaveChangesAsync());
        }

        public async Task<int> Update(Menu menu)
        {
            Menu update = await FindMenu(menu.MenuID);
            update.ControllerName = menu.ControllerName;
            update.ActionName = menu.ActionName;
            update.DisplayName = menu.DisplayName;
            update.CSSClass = UtilityService.HtmlDecode(menu.CSSClass);
            update.OrderNo = menu.OrderNo;
            update.IsActive = menu.IsActive;
            update.LastChangedBy = UtilityService.CurrentUserName;
            update.LastChangedDate = DateTime.Now;
            _context.Update(menu);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteMenu(int id)
        {
            var Menu = await _context.Menus.FindAsync(id);
            _context.Menus.Remove(Menu);
            return (await _context.SaveChangesAsync());
        }

        public async Task<List<Menu>> GetMenusFromParent(int menuGroupID)
        {
            return await _context.Menus.Where(m => m.MenuGroupID == menuGroupID).OrderBy(m => m.OrderNo).ToListAsync();
        }
        public async Task<int> ActionMenu(int menuID, DatabaseAction action)
        {
            Menu Menu = await FindMenu(menuID);
            switch (action)
            {
                case DatabaseAction.Remove:
                    _context.Menus.Remove(Menu);
                    break;
                case DatabaseAction.Deactivate:
                case DatabaseAction.Reactivate:
                    Menu.IsActive = DatabaseAction.Deactivate == action ? false : true;
                    Menu.LastChangedBy = UtilityService.CurrentUserName;
                    Menu.LastChangedDate = DateTime.Now;
                    _context.Update(Menu);
                    break;
                default:
                    break;
            }

            return (await _context.SaveChangesAsync());
        }


    }

}
