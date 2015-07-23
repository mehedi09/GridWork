<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="Controls_Login"  %>
              
<div data-app-role="page" data-content-framework="bootstrap">
      <div class="navbar navbar-default navbar-static-top" role="navigation">
          <div class="container">
              <div class="navbar-header">
                  <span class="navbar-brand">Standalone Login Page</span>
              </div>
              <div class="navbar-collapse">
                  <div class="navbar-form navbar-right" role="form">
                      <div class="form-group">
                          <input id="login-user-name" type="text" placeholder="Username" class="form-control" autocapitalize="off">
                      </div>
                      <div class="form-group">
                          <input id="login-password" type="password" placeholder="Password" class="form-control">
                      </div>
                      <button id="login-button" class="btn btn-success">Sign in</button><br />
                      <asp:HyperLink ID="ForgotPassword" runat="server" NavigateUrl="~/ForgotPassword.aspx"  >Forgot Password?</asp:HyperLink>
                  </div>
              </div>
              <!--/.navbar-collapse -->
          </div>
      </div>
      <!-- Main jumbotron for a primary marketing message or call to action -->
      <div class="jumbotron">
          <div class="container">
             <%-- <h1><span class="glyphicon glyphicon-globe"></span>&nbsp;Hello, world!</h1>
              <p>
                  This is a template for a custom login screen. It includes a large callout called a jumbotron and three supporting content blocks. 
                 
                  Edit the "Login" control in Visual Studio to create something more unique.
              </p>

              <p><a href="http://codeontime.com/learn/user-controls/extending-pages" class="btn btn-primary btn-lg" role="button">Learn more &raquo;</a></p>--%>
              <%--<img src="../App_Themes/NewFolder1/AccountBack.png" />--%>
              <%--<img src="../Pages/images/AccountBack.jpg" />--%>
              <%--<img src="../App_Themes/MyCompany/AccountBack.png" />--%>
              <%--<img src="../Pages/images/AccountBack.jpg" />--%>
              <img src="../App_Themes/MyCompany/AccountBack.png" width="100%" height="60%" />
          </div>
      </div>
    

      <div class="container">

          <%--<div class="row">
              <div class="col-sm-8">
                  <h2>^SignInInstruction^Sign in to access the protected site content.^SignInInstruction^</h2>
                  <p>
                      ^SignInPara1^Two standard user accounts are automatically created when application is initialized
  if membership option has been selected for this application.^SignInPara1^
                  </p>

                  <p>
                      ^SignInPara2^The administrative account <b>admin</b> is authorized to access all areas of the
  web site and membership manager. The standard <b>user</b> account is allowed to
  access all areas of the web site with the exception of membership manager.^SignInPara2^
                  </p>
              </div>
              <div class="col-sm-4">
                  <div class="panel panel-success">
                      <div class="panel-heading">
                          <span>^AdminDesc^Administrative account^AdminDesc^</span>
                      </div>
                      <div class="panel-body">
                          User Name: <b title="User Name">admin</b><br />
                          Password: <b title="Password">admin123%</b>
                      </div>
                  </div>

                  <div class="panel panel-default">
                      <div class="panel-heading">
                          <span>^UserDesc^Standard user account^UserDesc^</span>
                      </div>
                      <div class="panel-body">
                          User Name: <b title="User Name">user</b><br />
                          Password: <b title="Password">user123%</b>
                      </div>
                  </div>
              </div>
          </div>--%>
          <hr />
          <!-- Example row of columns -->
          <%--<div class="row">
              <div class="col-sm-4">
                  <h2>Heading</h2>
                  <p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui. </p>
                  <p><a class="btn btn-default" href="#" role="button">View details &raquo;</a></p>
              </div>
              <div class="col-sm-4">
                  <h2>Heading</h2>
                  <p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui. </p>
                  <p><a class="btn btn-default" href="#" role="button">View details &raquo;</a></p>
              </div>
              <div class="col-sm-4">
                  <h2>Heading</h2>
                  <p>Donec sed odio dui. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Vestibulum id ligula porta felis euismod semper. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus.</p>
                  <p><a class="btn btn-default" href="#" role="button">View details &raquo;</a></p>
              </div>
          </div>--%>

          <hr />
      </div>
      <!-- /container -->
</div>


<script type="text/javascript">
    (function () {
        var resources = Web.MembershipResources.Messages;

        function performLogin() {

            var userName = $('#login-user-name'),
                password = $('#login-password');
            if (!userName.val())
                $app.alert(resources.BlankUserName, function () {
                    userName.focus();
                });
            else if (!password.val())
                $app.alert(resources.BlankPassword, function () {
                    password.focus();
                });
            else
                $app.login(userName.val(), password.val(), true,
                    function () {
                        var returnUrl = window.location.href.match(/\?ReturnUrl=(.+)$/);
                        window.location.replace(returnUrl && decodeURIComponent(returnUrl[1]) || __baseUrl);
                    },
                    function () {
                        $app.alert(resources.InvalidUserNameAndPassword, function () {
                            userName.focus();
                        });
                    });
            return false;
        }

        // remove any other "app" pages 
        $('div.SettingsPanel div[data-app-role="page"]').remove();
        // register event handlers
        $(document)
            .on('click', '#login-button', performLogin)
            .on('keydown', '#login-user-name,#login-password', function (event) {
                if (event.which == 13) {
                    performLogin();
                    return false;
                }
            });
    })();
</script>

            