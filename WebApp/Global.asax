<%@ Application Language="C#" %>

<script runat="server">
void Application_Start(object sender, EventArgs e)
{
    // *********************************************************************************************
    // You may get a compilation error message if you change the namespace of the project.
    // This file will not be re-generated. Namespace "MyCompany" must be changed manually.
    // *********************************************************************************************
    // Fires on application startup
    MyCompany.Services.ApplicationServices.Initialize();
}

void Application_End(object sender, EventArgs e)
{
    // Fires on application shutdown
}

void Application_Error(object sender, EventArgs e)
{
    // Fires when an unhandled error occurs
}

void Session_Start(object sender, EventArgs e)
{
    // Fires when a new session is started
    string sessionId = Session.SessionID;
    // The line above will prevent intermittent error “Session state has created a session id,
    // but cannot save it because the response was already flushed by the application.”
}

void Session_End(object sender, EventArgs e)
{
    // Fires when a session ends.
    // Note: The Session_End event is raised only when the sessionstate mode
    // is set to InProc in the Web.config file. If session mode is set to StateServer
    // or SQLServer, the event is not raised.
}
</script>