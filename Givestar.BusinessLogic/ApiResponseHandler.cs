using GiveStarModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Givestar.BusinessLogic
{
    public class ApiResponseHandler
    {
        public static ApiResponse Success(object data, string msg = "Request completed successfully")
        {

            ApiResponse res = new()
            {
                StatusCode = 200,//HttpStatusCode.OK
                MessageTitle = "Success",
                Message = msg,
                Data = data,
                ModelValid = true

            };

            return res;
        }

        public static ApiResponse Error(object? data, string msg = "Website is unable to return a given request. Please try again.")
        {

            ApiResponse res = new()
            {
                StatusCode = 417, //HttpStatusCode.ExpectationFailed
                MessageTitle = "Error",
                Message = msg,
                Data = data,
                ModelValid = true
            };

            return res;
        }

        public static ApiResponse Error(object? data, int errorNumber, string msg = "")
        {
            switch (errorNumber)
            {
                case -1:
                    ApiResponse res = new()
                    {
                        StatusCode = 417, //HttpStatusCode.ExpectationFailed
                        MessageTitle = "Error",
                        Message = "You don't have permission to perfrom this action!. Please contact your administrator.",
                        Data = data,
                        ModelValid = true
                    };
                    return res;
                default:
                    ApiResponse resDefault = new()
                    {
                        StatusCode = 417, //HttpStatusCode.ExpectationFailed
                        MessageTitle = "Error",
                        Message = (string.IsNullOrEmpty(msg)) ? "Website is unable to update the request. Please try again. Error Code:" + errorNumber : msg + " Error Code:" + errorNumber,
                        Data = data,
                        ModelValid = true
                    };
                    return resDefault;
            }
        }

        public static ApiResponse Exception(object? data, string msg)
        {

            ApiResponse res = new()
            {
                StatusCode = 500,//HttpStatusCode.InternalServerError
                MessageTitle = "Error",
                Message = "Internal server error. " + msg + " Please contact support",
                Data = data,
                ModelValid = true
            };

            return res;
        }

        public static ApiResponse Unauthorized()
        {

            ApiResponse res = new()
            {
                StatusCode = 401,
                MessageTitle = "Unauthorized",
                Message = "Unauthorized request!. Please login again or contact support",
                Data = null,
                ModelValid = true
            };

            return res;
        }
    }
}
