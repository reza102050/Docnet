Imports Microsoft.VisualBasic.Compatibility.VB6
Module DataEnvironment_de4_Module
    Friend de4 As DataEnvironment_de4 = New DataEnvironment_de4()
End Module
Friend Class DataEnvironment_de4
    Inherits VB6.BaseDataEnvironment

    Public WithEvents con_Sql As ADODB.Connection
    Public WithEvents con_Update As ADODB.Connection
    Public WithEvents rslistsal As ADODB.Recordset
    Public WithEvents rsDelsal As ADODB.Recordset
    Public WithEvents rsBrowAll As ADODB.Recordset
    Public WithEvents rsFindKarbar As ADODB.Recordset
    Public WithEvents rsfindsal As ADODB.Recordset
    Public WithEvents rsfindnamkar As ADODB.Recordset
    Private m_findnamkar As ADODB.Command

    Private m_listsal As ADODB.Command
    Private m_BrowAll As ADODB.Command
    Private m_Delsal As ADODB.Command
    Private m_findkarbar As ADODB.Command
    Private m_findsal As ADODB.Command
    Public Sub New()
        MyBase.New()
        Dim strcnn1, tmpdbname, tmpUserId, tmpUserPass, tmpServerLocation As String
        tmpdbname = ""
        tmpUserId = "Sa"
        tmpUserPass = "km681000!"
        tmpServerLocation = "10.69.76.210"

        con_Sql = New ADODB.Connection()
        strcnn1 = "Provider=SQLOLEDB;Data Source=" + tmpServerLocation + ";Persist Security Info=True;User ID=" + tmpUserId + ";password=" + tmpUserPass + ";Initial Catalog=" + tmpdbname + ";"
        con_Sql.ConnectionString = strcnn1
        m_Connections.Add(con_Sql, "con_eoffice")

        '----------------------------
        con_Update = New ADODB.Connection()
        con_Update.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\daro\Eoffice1389.mdb;Persist Security Info=False;"
        m_Connections.Add(con_Update, "con_Update")

        '------------------------
        m_BrowAll = New ADODB.Command()
        rsBrowAll = New ADODB.Recordset()
        m_BrowAll.Name = "BrowAll"
        m_BrowAll.CommandText = "select * from Tblmsg "
        m_BrowAll.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsBrowAll.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsBrowAll.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsBrowAll.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsBrowAll.Source = m_BrowAll
        m_Commands.Add(m_BrowAll, "BrowAll")
        m_Recordsets.Add(rsBrowAll, "BrowAll")


    End Sub
    Public Sub BrowAll(ByVal Sql As String)
        If con_Update.State = ADODB.ObjectStateEnum.adStateClosed Then

            con_Update.Open()
        End If
        If rsBrowAll.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsBrowAll.Close()
        End If
        m_BrowAll.ActiveConnection = con_Update
        m_BrowAll.CommandText = Sql
        rsBrowAll.Open()
    End Sub

End Class

