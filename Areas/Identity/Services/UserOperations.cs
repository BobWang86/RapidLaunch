using Microsoft.AspNetCore.Authorization.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Areas.Identity.Services
{
    public static class UserOperations
    {
        public static OperationAuthorizationRequirement Create =
            new OperationAuthorizationRequirement { Name = Constants.CreateOperationName };
        public static OperationAuthorizationRequirement Read =
            new OperationAuthorizationRequirement { Name = Constants.ReadOperationName };
        public static OperationAuthorizationRequirement Update =
            new OperationAuthorizationRequirement { Name = Constants.UpdateOperationName };
        public static OperationAuthorizationRequirement Delete =
            new OperationAuthorizationRequirement { Name = Constants.DeleteOperationName };
        public static OperationAuthorizationRequirement Upload =
            new OperationAuthorizationRequirement { Name = Constants.UploadOperationName };
        public static OperationAuthorizationRequirement Download =
            new OperationAuthorizationRequirement { Name = Constants.DownloadOperationName };
        public static OperationAuthorizationRequirement DeleteAccount =
            new OperationAuthorizationRequirement { Name = Constants.DeleteAccountOperationName };
    }

    public class Constants
    {
        public static readonly string CreateOperationName = "Create";
        public static readonly string ReadOperationName = "Read";
        public static readonly string UpdateOperationName = "Update";
        public static readonly string DeleteOperationName = "Delete";
        public static readonly string UploadOperationName = "Upload";
        public static readonly string DownloadOperationName = "Download";
        public static readonly string DeleteAccountOperationName = "DeleteAccount";
    }
}
