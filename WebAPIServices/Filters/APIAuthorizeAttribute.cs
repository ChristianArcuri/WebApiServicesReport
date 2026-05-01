using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

using WebAPIBusiness.WireSecurity;
using System.Text;


namespace WebAPIServices.Filters
{
    public class APIAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext filterContext)
        {
            if (Authorize(filterContext))
            {
                return;
            }
            HandleUnauthorizedRequest(filterContext);
        }
        protected override void HandleUnauthorizedRequest(HttpActionContext filterContext)
        {
            base.HandleUnauthorizedRequest(filterContext);
        }


        private bool Authorize(HttpActionContext actionContext)
        {
            try
            {
                string authHeader = actionContext.Request.Headers.GetValues("Authorization").First();

                if (string.IsNullOrEmpty(authHeader) || !authHeader.StartsWith("Basic"))
                    return false;

                string base64Credentials = authHeader.Substring(6);
                string[] credentials = Encoding.ASCII.GetString(Convert.FromBase64String(base64Credentials)).Split(new char[] { ':' });

                if (credentials.Length != 2 || string.IsNullOrEmpty(credentials[0]) || string.IsNullOrEmpty(credentials[1])) 
                    return false;

                int environmentId = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["EnvironmentId"]);
                int appId = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["ApplicationId"]);

                var dt = new BSConfigParam().GetConnectionInformation("WEBAPISERVICES",environmentId, appId);

                var userDB = dt.Rows.Count > 0 ? dt.Rows[0]["UserName"].ToString(): string.Empty;
                var pwdDB = dt.Rows.Count > 0 ? dt.Rows[0]["Password"].ToString() : string.Empty;

                if (credentials[0].Equals(userDB) && credentials[1].Equals(pwdDB))// || (credentials[0].Equals("mabel") && credentials[1].Equals("mio123")))
                    return true;
              

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}