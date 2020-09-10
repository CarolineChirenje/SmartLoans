using Microsoft.EntityFrameworkCore;
using SmartDataAccess;
using SmartDomain;
using SmartHelper;
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
            NoticeBoard NoticeBoard = await FindNotice(id);

            if (DatabaseAction.Remove == action)
                _context.NoticeBoard.Remove(NoticeBoard);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                NoticeBoard.IsActive = DatabaseAction.Deactivate == action ? false : true;
                NoticeBoard.LastChangedBy = UtilityService.CurrentUserName;
                NoticeBoard.LastChangedDate = DateTime.Now;
                _context.Update(NoticeBoard);
            }

            return (await _context.SaveChangesAsync());
        }

        public async Task<List<NoticeBoard>> Notices()
        {
            return await _context.NoticeBoard.
                  Include(x => x.PriorityRank)
                        .AsNoTracking()
            .ToListAsync();
        }
        public async Task<List<NoticeBoard>> ActiveNotices()
        {
            return await _context.NoticeBoard
            .Include(x => x.PriorityRank)
            .Where(n=>n.IsActive && n.EndDate.Date < DateTime.Now.AddDays(8).Date)
            .AsNoTracking()
            .ToListAsync();
        }

        public async Task<int> Delete(int id)
        {
            var course = await _context.NoticeBoard.FindAsync(id);
            _context.NoticeBoard.Remove(course);
            return (await _context.SaveChangesAsync());
        }

        public async Task<NoticeBoard> FindNotice(int id)
        {
            return await _context.NoticeBoard.
                Include(x=>x.PriorityRank)
                .Where(r => r.NoticeID == id)
               .AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<int> Save(NoticeBoard NoticeBoard)
        {
            NoticeBoard.LastChangedBy = UtilityService.CurrentUserName;
            NoticeBoard.LastChangedDate = DateTime.Now;
            _context.Add(NoticeBoard);
            return (await _context.SaveChangesAsync());
        }
        public async Task<int> Update(NoticeBoard NoticeBoard)
        {           
            NoticeBoard.LastChangedBy = UtilityService.CurrentUserName;
            NoticeBoard.LastChangedDate = DateTime.Now;
            _context.Update(NoticeBoard);
            return await _context.SaveChangesAsync();
        }
    }
}
