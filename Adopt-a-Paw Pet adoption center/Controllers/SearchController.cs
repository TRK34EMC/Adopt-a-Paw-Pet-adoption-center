﻿using Adopt_a_Paw_Pet_adoption_center.Auth;
using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Adopt_a_Paw_Pet_adoption_center.Controllers
{
    [Logged]
    [RoutePrefix("api/search")]
    public class SearchController : ApiController
    {   
        [HttpGet]
        [Route("{str}")]
        public HttpResponseMessage Search(string str)
        {
            try
            {
                var data = SearchService.Search(str);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
