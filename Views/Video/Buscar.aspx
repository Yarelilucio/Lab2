﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Buscar</title>
</head>
<body>
      <form action="/Video/Buscar" method="post">
        <fieldset>
         <legend> Datos del Video</legend>

         <label for="idVideo">Id Video</label>
         <input type="text" name="IdVideo" />
            <br />
         <input type="submit"  name="buscarVideo" value="Buscar video " />
      </fieldset>
     </form>
      <br />
</body>
</html>
