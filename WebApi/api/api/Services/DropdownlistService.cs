﻿using api.DataAccess;
using api.Interfaces;
using api.Models;
using api.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.Services
{
    public class DropdownlistService : IDropdownlistService
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(DropdownlistService));

        public DropdownlistService()
        {

        }

        public List<Dropdownlist<string>> GetDdlBranchStatus()
        {
            //log.Info("Test Info Log");
            List<Dropdownlist<string>> ddl = new List<ModelViews.Dropdownlist<string>>();
            ddl.Add(new ModelViews.Dropdownlist<string>()
            {
                key = "A",
                value = "ใช้งาน"
            });
            ddl.Add(new ModelViews.Dropdownlist<string>()
            {
                key = "I",
                value = "ไม่ใช้งาน"
            });
            return ddl;
        }

        public List<Dropdownlist> GetDdlBranchGroup()
        {
            using (var ctx = new ConXContext())
            {
                List<Dropdownlist> ddl = ctx.BranchGroups
                    .OrderBy(o => o.branchGroupCode)
                    .Select(x => new Dropdownlist()
                    {
                        key = x.branchGroupId,
                        value = x.branchGroupCode + " " + x.branchGroupName
                    })
                    .ToList();
                return ddl;
            }
        }

        //public List<Dropdownlist> GetDdlBranch(long branchId)
        //{
        //    using (var ctx = new ConXContext())
        //    {
        //        List<Dropdownlist> ddl = ctx.Branchs
        //            .Include("branchGroup")
        //            .Where(z => z.status == "A" && (z.branchId != branchId || branchId == 0))
        //            .OrderBy(o => o.branchGroup.branchGroupCode).ThenBy(o => o.branchCode)
        //            .Select(x => new Dropdownlist()
        //            {
        //                key = x.branchId,
        //                value = x.branchGroup.branchGroupCode + " " + x.branchGroup.branchGroupName + " : " + x.branchCode + "-" + x.entityCode + " " + x.branchNameThai
        //            })
        //            .ToList();
        //        return ddl;
        //    }
        //}

        public List<Dropdownlist> GetDdlBranch()
        {
            using (var ctx = new ConXContext())
            {
                List<Dropdownlist> ddl = ctx.Branchs
                    .Include("branchGroup")
                    .Where(z => z.status == "A")
                    .OrderBy(o => o.branchGroup.branchGroupCode).ThenBy(o => o.branchCode)
                    .Select(x => new Dropdownlist()
                    {
                        key = x.branchId,
                        value = x.branchCode + " " + x.branchNameThai
                    })
                    .ToList();
                return ddl;
            }
        }

        public List<Dropdownlist> GetDdlTransferBranch(long branchId)
        {
            using (var ctx = new ConXContext())
            {
                Branch fromBranch = ctx.Branchs.Where(x => x.branchId == branchId).SingleOrDefault();
                string entityPrefix = fromBranch.entityCode.Substring(0, 1);

                List<Dropdownlist> ddl = ctx.Branchs
                    .Include("branchGroup")
                    .Where(z => z.status == "A" && (z.branchId != branchId || branchId == 0) && z.entityCode.StartsWith(entityPrefix))
                    .OrderBy(o => o.branchGroup.branchGroupCode).ThenBy(o => o.branchCode)
                    .Select(x => new Dropdownlist()
                    {
                        key = x.branchId,
                        value = x.branchGroup.branchGroupCode + " " + x.branchGroup.branchGroupName + " : " + x.branchCode + "-" + x.entityCode + " " + x.branchNameThai
                    })
                    .ToList();
                return ddl;
            }
        }

        public List<Dropdownlist> GetDdlBranchInGroup(int branchGroupId)
        {
            using (var ctx = new ConXContext())
            {
                List<Dropdownlist> ddl = ctx.Branchs
                    .Where(z => z.status == "A" && z.branchGroupId == branchGroupId)
                    .OrderBy(o => o.branchGroup.branchGroupCode).ThenBy(o => o.branchCode)
                    .Select(x => new Dropdownlist()
                    {
                        key = x.branchId,
                        value = x.branchCode + "-" + x.entityCode + " " + x.branchNameThai
                    })
                    .ToList();
                return ddl;
            }
        }

        

        public List<Dropdownlist> GetDdlDepartment()
        {
            using (var ctx = new ConXContext())
            {
                List<Dropdownlist> ddl = ctx.Departments
                    .Where(z => z.status == "A")
                    .OrderBy(o => o.departmentCode)
                    .Select(x => new Dropdownlist()
                    {
                        key = x.departmentId,
                        value = x.departmentCode + " " + x.departmentName
                    })
                    .ToList();
                return ddl;
            }
        }

        public List<Dropdownlist> GetDdlUserRole(OwnerRole ownerRole)
        {
            using (var ctx = new ConXContext())
            {
                List<Dropdownlist> ddl = ctx.UserRoles
                    .Where(
                    z =>
                    z.isPC == ownerRole.isPc
                    && (z.createUser == ownerRole.createUser || ownerRole.createUser.ToLower() == "admin")
                    && z.status == "A"
                    )
                    .OrderBy(o => o.userRoleId)
                    .Select(x => new Dropdownlist()
                    {
                        key = x.userRoleId,
                        value = x.roleName
                    })
                    .ToList();
                return ddl;
            }
        }

        

        public List<Dropdownlist> GetDdlFileUploadType()
        {
            using (var ctx = new ConXContext())
            {

                List<Dropdownlist> ddl = ctx.AttachFileTypes
                    .Select(x => new Dropdownlist()
                    {
                        key = x.attachFileTypeId,
                        value = x.fileTypeNmae
                    })
                    .ToList();

                return ddl;
            }
        }

        public List<Dropdownlist> GetDdlYear()
        {
            using (var ctx = new ConXContext())
            {

                List<Dropdownlist> ddl = new List<Dropdownlist>();
                int year = DateTime.Today.Year + 1;
                for (int i = 0; i < 6; i++)
                {
                    Dropdownlist d = new Dropdownlist()
                    {
                        key = year - i,
                        value = (year - i).ToString()
                    };
                    ddl.Add(d);
                }

                return ddl;
            }
        }

        public List<Dropdownlist> GetDdlMonth()
        {
            using (var ctx = new ConXContext())
            {

                List<Dropdownlist> ddl = new List<Dropdownlist>();


                for (int i = 1; i <= 12; i++)
                {
                    Dropdownlist d = new Dropdownlist()
                    {
                        key = i,
                        value = Util.Util.GetMonthNameThai(i)
                    };
                    ddl.Add(d);
                }

                return ddl;
            }
        }


       

        public List<Dropdownlists> GetDdlProductBrand()
        {
            using (var ctx = new ConXContext())
            {
                List<Dropdownlists> ddl = ctx.BrandMasts
                    .Where(z => z.status == "A")
                    .OrderBy(o => o.pdbrnd_code)
                    .Select(x => new Dropdownlists()
                    {
                        key = x.pdbrnd_code,
                        value = x.pdbrnd_code + " - " + x.pdbrnd_tname
                    })
                    .ToList();
                return ddl;
            }


        }

        public List<Dropdownlists> GetDdlProductColor()
        {
            using (var ctx = new ConXContext())
            {
                List<Dropdownlists> ddl = ctx.ColorMasts
                    .Where(z => z.status == "A")
                    .OrderBy(o => o.pdcolor_code)
                    .Select(x => new Dropdownlists()
                    {
                        key = x.pdcolor_code,
                        value = x.pdcolor_code + " - " + x.pdcolor_tname
                    })
                    .ToList();
                return ddl;
            }


        }

        public List<Dropdownlists> GetDdlProductType()
        {
            using (var ctx = new ConXContext())
            {
                List<Dropdownlists> ddl = ctx.TypeMasts
                    .Where(z => z.status == "A")
                    .OrderBy(o => o.pdtype_code)
                    .Select(x => new Dropdownlists()
                    {
                        key = x.pdtype_code,
                        value = x.pdtype_code + " - " + x.pdtype_tname
                    })
                    .ToList();
                return ddl;
            }


        }

        

        public List<Dropdownlists> GetDdlProductSize()
        {
            using (var ctx = new ConXContext())
            {
                List<Dropdownlists> ddl = ctx.SizeMasts
                    .Where(z => z.status == "A")
                    .OrderBy(o => o.pdsize_code)
                    .Select(x => new Dropdownlists()
                    {
                        key = x.pdsize_code,
                        value = x.pdsize_code + " - " + x.pdsize_tname
                    })
                    .ToList();
                return ddl;
            }
        }

        public List<Dropdownlist<string>> GetDdlProductAttributeType()
        {
            using (var ctx = new ConXContext())
            {
                List<Dropdownlist<string>> ddl = new List<Dropdownlist<string>>();
                ddl = ctx.ProductAttributeTypes
                        .OrderBy(o => o.productAttributeTypeCode)
                        .Select(x => new ModelViews.Dropdownlist<string>()
                        {
                            key = x.productAttributeTypeCode,
                            value = x.attributeName
                        })
                        .ToList();
                return ddl;
            }

        }

        public List<Dropdownlists> GetDdlProductDesign()
        {
            using (var ctx = new ConXContext())
            {
                List<Dropdownlists> ddl = ctx.DesignMasts
                    .Where(z => z.status == "A")
                    .OrderBy(o => o.pddsgn_code)
                    .Select(x => new Dropdownlists()
                    {
                        key = x.pddsgn_code,
                        value = x.pddsgn_code + " - " + x.pddsgn_tname
                    })
                    .ToList();
                return ddl;
            }
        }

        public List<Dropdownlists> GetDdlUserBranch(string user)
        {
            using (var ctx = new ConXContext())
            {
                string sql = "select a.branchCode 'key' , a.branchNameThai value from Branches a , UserBranchPrvlgs b where a.branchId=b.branchId and a.status = 'A' and b.username = @p_user";

                List<Dropdownlists> ddl = ctx.Database.SqlQuery<Dropdownlists>(sql, new System.Data.SqlClient.SqlParameter("@p_user", user))
                                            .Select(x => new Dropdownlists()
                                            {
                                                key = x.key,
                                                value = x.value,
                                            })
                                            .ToList();
                return ddl;
            }
        }

        public List<Dropdownlists> GetDdlDocStatus()
        {
            using (var ctx = new ConXContext())
            {
                List<Dropdownlists> ddl = ctx.DocStatus
                    .OrderBy(o => o.statusId)
                    .Select(x => new Dropdownlists()
                    {
                        key = x.statusId,
                        value = x.statusName
                    })
                    .ToList();
                return ddl;
            }
        }
    }
}