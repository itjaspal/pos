using api.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.Interfaces
{
    interface IDropdownlistService
    {
        List<Dropdownlist<string>> GetDdlBranchStatus();
        List<Dropdownlist> GetDdlBranchGroup();
        List<Dropdownlist> GetDdlBranch();   
        List<Dropdownlist> GetDdlBranchInGroup(int branchGroupId);    
        List<Dropdownlist> GetDdlDepartment();
        List<Dropdownlist> GetDdlUserRole(OwnerRole ownerRole);
        List<Dropdownlist<string>> GetDdlProductAttributeType();
      
        List<Dropdownlist> GetDdlFileUploadType();
        List<Dropdownlist> GetDdlYear();
        List<Dropdownlist> GetDdlMonth();
      

        
        List<Dropdownlists> GetDdlProductBrand();
        List<Dropdownlists> GetDdlProductColor();
        List<Dropdownlists> GetDdlProductType();
        List<Dropdownlists> GetDdlProductDesign();
       
        List<Dropdownlists> GetDdlProductSize();

        List<Dropdownlists> GetDdlUserBranch(string user);
        List<Dropdownlists> GetDdlDocStatus();

    }
}
