using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Raven.Client;
using Raven.Client.Document;
using Raven.Client.Indexes;
using System.Reflection;

namespace WebApp
{
    public class Global : System.Web.HttpApplication
    {

        public static IDocumentStore documentStore;

        protected void Application_Start(object sender, EventArgs e)
        {

            /* lets connect to our RavenDB for access in our website */
            documentStore = new DocumentStore { ConnectionStringName = "RavenDB" }.Initialize();
            IndexCreation.CreateIndexes(Assembly.GetCallingAssembly(), documentStore);

            /* UPDATE HiLo */
            //var generator = new MultiTypeHiLoKeyGenerator(Global.documentStore, 5);
            //Global.documentStore.Conventions.DocumentKeyGenerator = entity => generator.GenerateDocumentKey(Global.documentStore.Conventions, entity);

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpApplication app = (HttpApplication)sender;
            if (app.Context.Request.ApplicationPath.EndsWith("/time"))
            {
                
            }
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {
            documentStore.Dispose();
            documentStore = null;
        }
    
    }
     
}