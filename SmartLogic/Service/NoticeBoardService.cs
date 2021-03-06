using Microsoft.EntityFrameworkCore;
using SmartDataAccess;
using SmartDomain;
using SmartExtensions;
using SmartHelper;
using SmartLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLogic
{
    public class NoticeBoardService : INoticeBoardService
    {
        private readonly DatabaseContext _context;
        public NoticeBoardService(DatabaseContext context) => _context = context;
        public async Task<int> ActionNoticeBoard(int id, DatabaseAction action)
        {
            try
            {
                NoticeBoard NoticeBoard = await FindNotice(id);
                if (DatabaseAction.Remove == action)
                    _context.NoticeBoard.Remove(NoticeBoard);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    NoticeBoard.IsActive = DatabaseAction.Deactivate == action ? false : true;
                    NoticeBoard.LastChangedBy = UserAppData.CurrentUserName;
                    NoticeBoard.LastChangedDate = DateTime.Now;
                    _context.Update(NoticeBoard);
                }

                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<NoticeBoard>> Notices()
        {
            try
            {
                return await _context.NoticeBoard.
                Include(x => x.PriorityRank)
                 .AsNoTracking()
                .ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<List<NoticeBoard>> ActiveNotices()
        {
            try
            {

                return await _context.NoticeBoard
            .Include(x => x.PriorityRank)
            .Where(n => n.IsActive && n.EndDate>=DateTime.Now)
            .AsNoTracking()
            .ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Delete(int id)
        {
            try
            {

                var course = await _context.NoticeBoard.FindAsync(id);
                _context.NoticeBoard.Remove(course);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<NoticeBoard> FindNotice(int id)
        {
            try
            {

                return await _context.NoticeBoard.
                 Include(x => x.PriorityRank)
                 .Where(r => r.NoticeID == id)
                .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Save(NoticeBoard NoticeBoard)
        {
            try
            {

                NoticeBoard.LastChangedBy = UserAppData.CurrentUserName;
                NoticeBoard.LastChangedDate = DateTime.Now;
                _context.Add(NoticeBoard);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(NoticeBoard NoticeBoard)
        {
            try
            {
                var nb = _context.NoticeBoard.Find(NoticeBoard.NoticeID);
                if (nb.IsNotNull())
                    return 0;
                nb.Title = NoticeBoard.Title;
                nb.Details = NoticeBoard.Details;
                nb.PriorityRankID = NoticeBoard.PriorityRankID;
                nb.StartDate = NoticeBoard.StartDate;
                nb.EndDate = NoticeBoard.EndDate;
                nb.IsActive = NoticeBoard.IsActive;
                nb.LastChangedBy = UserAppData.CurrentUserName;
                nb.LastChangedDate = DateTime.Now;
                _context.Update(nb);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
    }
}
