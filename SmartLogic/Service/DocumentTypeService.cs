using SmartLogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartDomain;
using SmartHelper;
using SmartDataAccess;
using SmartLog;

namespace SmartLogic
{
    public class DocumentTypeService : IDocumentTypeService
    {
        private readonly DatabaseContext _context;

        public DocumentTypeService(DatabaseContext context) => _context = context;
        public async Task<int> ActionDocumentType(int id, DatabaseAction action)
        {
            try
            {

                        DocumentType DocumentType = await FindDocumentType(id);

            if (DatabaseAction.Remove == action)
                _context.DocumentTypes.Remove(DocumentType);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                DocumentType.IsActive = DatabaseAction.Deactivate == action ? false : true;
                DocumentType.LastChangedBy = UtilityService.CurrentUserName;
                DocumentType.LastChangedDate = DateTime.Now;
                _context.Update(DocumentType);
            }

            return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<DocumentType>> DocumentTypes()
        {
            try
            {

                        return await _context.DocumentTypes
            .Include(d=>d.DocumentFormat)
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

                       var DocumentType = await _context.DocumentTypes.FindAsync(id);
            _context.DocumentTypes.Remove(DocumentType);
            return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<DocumentType> FindDocumentType(int id)
        {
            try
            {

                       return await _context.DocumentTypes.Where(r => r.DocumentTypeID == id)
            .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Save(DocumentType DocumentType)
        {
            try
            {

                        DocumentType.LastChangedBy = UtilityService.CurrentUserName;
            DocumentType.LastChangedDate = DateTime.Now;
            _context.Add(DocumentType);
            return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<bool> IsDuplicate(DocumentType DocumentType)
        {
            try
            {

                        DocumentType documentType = await _context.DocumentTypes.Where(b => b.Name.Equals(DocumentType.Name)).FirstOrDefaultAsync();
            return UtilityService.IsNotNull(documentType);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(DocumentType DocumentType)
        {
            try
            {

                        DocumentType.LastChangedBy = UtilityService.CurrentUserName;
            DocumentType.LastChangedDate = DateTime.Now;
            _context.Update(DocumentType);
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
