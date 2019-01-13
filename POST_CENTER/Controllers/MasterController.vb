Imports System.Web.Mvc

Namespace Controllers
    Public Class MasterController
        Inherits Controller
        Dim db_post As New Linq_postDataContext
        Dim model As New FULL_MODEL

        ' GET: Master
        Function Index() As ActionResult
            Return View()
        End Function

        Function GET_PROCESS_MENU() As JsonResult
            model.LIST_PROCESS_MENU = (From p In db_post.PROCESS_MENUs Where p.PLUBLIC_STATUS = "1").ToList
            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function
    End Class
End Namespace