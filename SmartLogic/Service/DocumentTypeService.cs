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

namespace SmartLogic
{
    public class DocumentTypeService : IDocumentTypeService
    {
        private readonly DatabaseContext _context;

        public DocumentTypeService(DatabaseContext context) => _context = context;
        public async Task<int> ActionDocumentType(int id, DatabaseAction action)
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

        public async Task<List<DocumentType>> DocumentTypes()
        {
            return await _context.DocumentTypes
            .Include(d=>d.DocumentFormat)
            .AsNoTracking()
            .ToListAsync();
        }

        public async Task<int> Delete(int id)
        {
            var DocumentType = await _context.DocumentTypes.FindAsync(id);
            _context.DocumentTypes.Remove(DocumentType);
            return (await _context.SaveChangesAsync());
        }

        public async Task<DocumentType> FindDocumentType(int id)
        {
            return await _context.DocumentTypes.Where(r => r.DocumentTypeID == id)
            .AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<int> Save(DocumentType DocumentType)
        {
            DocumentType.LastChangedBy = UtilityService.CurrentUserName;
            DocumentType.LastChangedDate = DateTime.Now;
            _context.Add(DocumentType);
            return (await _context.SaveChangesAsync());
        }
        public async Task<bool> IsDuplicate(DocumentType DocumentType)
        {
            DocumentType documentType = await _context.DocumentTypes.Where(b => b.Name.Equals(DocumentType.Name)).FirstOrDefaultAsync();
            return UtilityService.IsNotNull(documentType);
        }
        public async Task<int> Update(DocumentType DocumentType)
        {
            DocumentType.LastChangedBy = UtilityService.CurrentUserName;
            DocumentType.LastChangedDate = DateTime.Now;
            _context.Update(DocumentType);
            return await _context.SaveChangesAsync();
        }
    }
}
