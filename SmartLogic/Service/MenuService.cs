using Microsoft.EntityFrameworkCore;
using SmartDataAccess;
using SmartDomain;
using SmartHelper;
using SmartLog;
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
            try
            {

                        return await _context.MenuGroups.Where(x => x.MenuGroupID == ParentMenuID).
                Include(x => x.Menus).OrderBy(m => m.OrderNo).AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<MenuGroup>> DisplayMenuGroups()
        {
            try
            {                       return await _context.MenuGroups.Include(x => x.Menus).OrderBy(m => m.OrderNo).ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<List<MenuGroup>> MenuGroups() => await _context.MenuGroups.Include(x => x.Menus).OrderBy(m => m.OrderNo).ToListAsync();

        public List<MenuGroup> GetMenuGroups()
        {
            try
            {

                        return _context.MenuGroups.Include(x => x.Menus).OrderBy(m => m.OrderNo).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Save(MenuGroup ParentMenu)
        {
            try
            {

                       ParentMenu.LastChangedBy = UtilityService.CurrentUserName;
            ParentMenu.LastChangedDate = DateTime.Now;
            _context.Add(ParentMenu);
            return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(MenuGroup ParentMenu)
        {
            try
            {

                        MenuGroup update = await FindMenuGroup(ParentMenu.MenuGroupID);
            if (ParentMenu.IsActiveMenu)
                // reset others and  activate only this
                await ResetActiveMenuGroup(ParentMenu.MenuGroupID);
            update.IsActiveMenu = ParentMenu.IsActive; // rule must be at least 1 active tab for all
            update.DisplayName = ParentMenu.DisplayName;
            update.CSSClass = UtilityService.HtmlDecode(ParentMenu.CSSClass);
            update.ActionName = ParentMenu.ActionName;
            update.DisplayName = ParentMenu.DisplayName;
            update.OrderNo = ParentMenu.OrderNo;
            update.IsActive = ParentMenu.IsActive;
            update.LastChangedBy = UtilityService.CurrentUserName;
            update.LastChangedDate = DateTime.Now;
            _context.Update(update);
            return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public async Task<int> ResetActiveMenuGroup(int menugroupID)
        {
            try
            {

                        var menugroups = _context.MenuGroups.Where(mng => mng.MenuGroupID != menugroupID).ToList();
            menugroups.ForEach(a => a.IsActiveMenu = false);
            return await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> DeleteMenuGroup(int id)
        {
            try
            {

                        var parentMenu = await _context.MenuGroups.FindAsync(id);
            _context.MenuGroups.Remove(parentMenu);
            return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public async Task<int> ActionMenuGroup(int id, DatabaseAction action)
        {
            try
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
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        //Menus

        public async Task<Menu> FindMenu(int menuID)
        {
            try
            {

                        return await _context.Menus.Where(rp => rp.MenuID == menuID)
         .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<Menu>> Menus()
        {
            try
            {

                        return await _context.Menus.OrderBy(m => m.OrderNo).ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<Menu> GetMenus()
        {
            try
            {

                       return _context.Menus.OrderBy(m => m.OrderNo).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Save(Menu menu)
        {
            try
            {

                        menu.LastChangedBy = UtilityService.CurrentUserName;
            menu.LastChangedDate = DateTime.Now;
            _context.Add(menu);
            return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Update(Menu menu)
        {
            try
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
            _context.Update(update);
            return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> DeleteMenu(int id)
        {
            try
            {

                        var Menu = await _context.Menus.FindAsync(id);
            _context.Menus.Remove(Menu);
            return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<Menu>> GetMenusFromParent(int menuGroupID)
        {
            try
            {

                    return await _context.Menus.Where(m => m.MenuGroupID == menuGroupID).OrderBy(m => m.OrderNo).ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> ActionMenu(int menuID, DatabaseAction action)
        {
            try
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
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }



        #region LayOuts
        public async Task<List<Layout>> Layouts() => await _context.Layouts.Include(x => x.Menus).ToListAsync();

        public async Task<List<LayoutMenu>> DisplayLayouts(LayoutComponent layoutGroup)
        {
            try
            {
                return await _context.LayoutMenus.Where(m=>m.LayoutID==(int)layoutGroup).OrderBy(m => m.OrderNo).ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(Layout layout)
        {
            try
            {

                layout.LastChangedBy = UtilityService.CurrentUserName;
                layout.LastChangedDate = DateTime.Now;
                _context.Add(layout);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<List<LayoutMenu>> LayoutMenus(int layoutID)
        {
            try
            {

                return await _context.LayoutMenus.Where(lm => lm.LayoutID == layoutID).OrderBy(m => m.OrderNo).ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<Layout> FindLayoutGroup(int ParentMenuID)
        {
            try
            {

                return await _context.Layouts.Where(x => x.LayoutID == ParentMenuID).
        Include(x => x.Menus).AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<LayoutMenu> FindLayoutMenu(int menuID)
        {
            try
            {

                return await _context.LayoutMenus.Where(rp => rp.LayoutMenuID == menuID)
 .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<LayoutMenu>> LayoutMenus()
        {
            try
            {

                return await _context.LayoutMenus.OrderBy(m => m.OrderNo).ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<LayoutMenu> GetLayoutMenus()
        {
            try
            {

                return _context.LayoutMenus.OrderBy(m => m.OrderNo).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Save(LayoutMenu menu)
        {
            try
            {

                menu.LastChangedBy = UtilityService.CurrentUserName;
                menu.LastChangedDate = DateTime.Now;
                _context.Add(menu);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Update(LayoutMenu menu)
        {
            try
            {

                LayoutMenu update = await FindLayoutMenu(menu.LayoutMenuID);
                update.ControllerName = menu.ControllerName;
                update.ActionName = menu.ActionName;
                update.DisplayName = menu.DisplayName;
                update.CSSClass = UtilityService.HtmlDecode(menu.CSSClass);
                update.OrderNo = menu.OrderNo;
                update.IsActive = menu.IsActive;
                update.LastChangedBy = UtilityService.CurrentUserName;
                update.LastChangedDate = DateTime.Now;
                _context.Update(update);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> DeleteLayoutMenu(int id)
        {
            try
            {

                var Menu = await _context.LayoutMenus.FindAsync(id);
                _context.LayoutMenus.Remove(Menu);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> ActionLayoutMenu(int menuID, DatabaseAction action)
        {
            try
            {

                LayoutMenu Menu = await FindLayoutMenu(menuID);
                switch (action)
                {
                    case DatabaseAction.Remove:
                        _context.LayoutMenus.Remove(Menu);
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
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<Layout> GetLayoutGroups()
        {
            try
            {

                return _context.Layouts.Include(x => x.Menus).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        #endregion LayOuts
    }

}
