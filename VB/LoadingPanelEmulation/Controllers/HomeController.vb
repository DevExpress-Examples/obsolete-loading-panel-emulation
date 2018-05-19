Imports System.Threading

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        'Additional time for demonstrating functionality of the solution
        Thread.Sleep(2000)
        Return View()
    End Function
End Class
