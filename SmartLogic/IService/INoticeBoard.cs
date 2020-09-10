using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace SmartLogic
{
    public interface INoticeBoardService
    {
        Task<int> Delete(int id);
        Task<int> Save(NoticeBoard Event);
        Task<int> Update(NoticeBoard Event);
        Task<int> ActionNoticeBoard(int id, DatabaseAction action);
        Task<NoticeBoard> FindNotice(int id);
        Task<List<NoticeBoard>> Notices();

        Task<List<NoticeBoard>> ActiveNotices();

    }
}
