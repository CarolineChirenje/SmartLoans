using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace SmartLogic
{
  public  interface IDocumentTypeService
    {
        Task<int> Delete(int id);
        Task<int> Save(DocumentType DocumentType);
        Task<int> Update(DocumentType DocumentType);
        Task<int> ActionDocumentType(int id, DatabaseAction action);
        Task<DocumentType> FindDocumentType(int id);
        Task<List<DocumentType>> DocumentTypes();
     
    }
}
