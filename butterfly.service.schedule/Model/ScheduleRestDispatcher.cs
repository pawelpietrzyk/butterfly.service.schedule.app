using butterfly.com.rest;
using butterfly.com.rest.client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace butterfly.service.schedule.Model
{
    public class ScheduleRestDispatcher : RestDispatcher
    {

        public override void DispatchRestMethod(RestMethod method)
        {
            throw new NotImplementedException();
        }

        public override void GET(System.Web.HttpContext context)
        {
            List<Day> days = ScheduleDataService.GetDays(String.Empty);
            if (days != null)
            {
                context.Response.Status = "200 OK";
                context.Response.StatusCode = 200;
                Serializer.Serialize(days, context.Response.OutputStream);
            }            
        }

        public override void POST(System.Web.HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
