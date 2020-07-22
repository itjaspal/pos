﻿using api.ActionFilters;
using api.Interfaces;
using api.ModelViews;
using api.Services;
using AttributeRouting.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api.Controllers
{
    //[AuthorizationRequired]
   
    public class DropdownlistController : ApiController
    {

        IDropdownlistService ddlSvc;
        public DropdownlistController()
        {
            ddlSvc = new DropdownlistService();
        }

        //[GET("getDdlBranchStatus")]
        [Route("dropdownlist/getDdlBranchStatus")]
        public HttpResponseMessage getBranchInfo()
        {
            try
            {
                var result = ddlSvc.GetDdlBranchStatus();

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }

        //[GET("getDdlBranchGroup")]
        [Route("dropdownlist/getDdlBranchGroup")]
        public HttpResponseMessage getDdlBranchGroup()
        {
            try
            {
                var result = ddlSvc.GetDdlBranchGroup();

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }

        //[GET("getDdlBranch/{branchId}")]
        [Route("dropdownlist/getDdlBranch")]
        public HttpResponseMessage getDdlBranch()
        {
            try
            {
                var result = ddlSvc.GetDdlBranch();

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }


        //[GET("getDdlBranchInGroup/{branchGropupId}")]
        [Route("dropdownlist/getDdlBranchInGroup/{branchGropupId}")]
        public HttpResponseMessage getDdlBranchInGroup(int branchGropupId)
        {
            try
            {
                var result = ddlSvc.GetDdlBranchInGroup(branchGropupId);

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }


        //[GET("getDdlDepartment")]
        [Route("dropdownlist/getDdlDepartment")]
        public HttpResponseMessage getDdlDepartment()
        {
            try
            {
                var result = ddlSvc.GetDdlDepartment();

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }

        //[POST("inquiryDdlUserRole")]
        [Route("dropdownlist/inquiryDdlUserRole")]
        public HttpResponseMessage PostinquiryDdlUserRole(OwnerRole ownerRole)
        {
            try
            {
                var result = ddlSvc.GetDdlUserRole(ownerRole);

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }


        //[GET("GetDdlYear")]
        [Route("dropdownlist/GetDdlYear")]
        public HttpResponseMessage GetDdlYear()
        {
            try
            {
                var result = ddlSvc.GetDdlYear();

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }

        //[GET("GetDdlMonth")]
        [Route("dropdownlist/GetDdlMonth")]
        public HttpResponseMessage GetDdlMonth()
        {
            try
            {
                var result = ddlSvc.GetDdlMonth();

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }

        
        [Route("dropdownlist/getDdlProductBrand")]
        public HttpResponseMessage getDdlProductBrand()
        {
            try
            {
                var result = ddlSvc.GetDdlProductBrand();

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }


        [Route("dropdownlist/getDdlProductColor")]
        public HttpResponseMessage getDdlProductColor()
        {
            try
            {
                var result = ddlSvc.GetDdlProductColor();

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }

        [Route("dropdownlist/getDdlProductType")]
        public HttpResponseMessage getDdlProductType()
        {
            try
            {
                var result = ddlSvc.GetDdlProductType();

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }


        [Route("dropdownlist/getDdlProductSize")]
        public HttpResponseMessage getDdlProductSize()
        {
            try
            {
                var result = ddlSvc.GetDdlProductSize();

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }

        [Route("dropdownlist/getDdlProductAttributeType")]
        public HttpResponseMessage getDdlProductAttributeType()
        {
            try
            {
                var result = ddlSvc.GetDdlProductAttributeType();

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }

        [Route("dropdownlist/getDdlProductDesign")]
        public HttpResponseMessage getDdlProductDesign()
        {
            try
            {
                var result = ddlSvc.GetDdlProductDesign();

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }

        [Route("dropdownlist/getDdlUserBranch/{user}")]
        public HttpResponseMessage getDdlUserBranch(string user)
        {
            try
            {
                var result = ddlSvc.GetDdlUserBranch(user);

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }

        [Route("dropdownlist/getDdlDocStatus")]
        public HttpResponseMessage getDdlDocStatus()
        {
            try
            {
                var result = ddlSvc.GetDdlDocStatus();

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }

    }
}