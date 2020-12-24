using System.Collections.Generic;
using MicroserviceWebapi.Model;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviceWebapi.Api
{
    public interface IService<T>
    {

        /*
            Get all
        */
        public ActionResult<List<T>> getAll();

        public ActionResult<ApiResponse> delete(string id);

        public void get(string id);
    }
}