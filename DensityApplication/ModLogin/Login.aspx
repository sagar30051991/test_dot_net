<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DensityApplication.ModLogin.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="../../css/style.css" rel="Stylesheet" type="text/css" />
    <link href="../../css/reset.css" rel="Stylesheet" type="text/css" />
    <link href="../css/Alert.css" rel="stylesheet" type="text/css" />
    <script src="../../js/jquery-1.10.2.min.js" type="text/javascript"></script>
    <script src="../../js/prefixfree.min.js" type="text/javascript"></script>
    <script src="../js/jquery.alerts.js" type="text/javascript"></script>

</head>
<body>
  <div id="login">
  <form id="login_form" runat="server">
    <div class="field_container">
      <input type="text" placeholder="UserName" runat="server" id="txtUserName" />
    </div>

    <div class="field_container">
      <input type="Password" placeholder="Password" runat="server" id="txtPassword" />
      <button id="btnLogin" runat="server" onserverclick="btnLogin_Click" ValidationGroup="vgUser">
        <span class="button_text">Sign In</span>
      </button>
    </div>

     <asp:RequiredFieldValidator ID="rfvUserName" runat="server" ControlToValidate="txtUserName"
            Display="None" ErrorMessage="Please select User Name" 
            ValidationGroup="vgUser"></asp:RequiredFieldValidator>
     <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword"
            Display="None" ErrorMessage="Please Enter Password" 
            ValidationGroup="vgUser"></asp:RequiredFieldValidator>
     <asp:ValidationSummary ID="validSummary" runat="server" ValidationGroup="vgUser" ShowMessageBox="true"
            ShowSummary="false" />

    <%--<div id="sign_in_options" class="field_container">
        <div id="sign_in_alternatives_container">
          <span id="google_sign_in_option">or you can <a href="#" id="google_sign_in" class="login_link">sign in with Google</a></span>
          <span id="password_sign_in_option">or you can <a href="#" id="password_sign_in" class="login_link">sign in using a password</a></span>
        </div>
        <div id="remember_me_container">
          <input name="user[remember_me]" type="hidden" value="0"><input id="user_remember_me" name="user[remember_me]" type="checkbox" value="1">
          <label class="login_link" for="user_remember_me" id="remember_me_label">stay signed in</label>
        </div>
        <div class="clearfix"></div>
      </div>--%>
</form>
<%--<div id="chrome_web_store" style="opacity: 1;"><span id="chrome_logo"></span><h2>Using Google Chrome? <a id="chrome_ad_link" href="#">Get Login</a> for Chrome!</h2>
</div>--%>

  <%--<div id="dont_have_an_account">
    <h2>
      Need to <a href="#" class="login_link">sign up</a> for an account
      or <a href="#" id="forgot_password_link" class="login_link">reset</a> your password?
    </h2>
  </div>--%>
</div>

</body>
</html>
