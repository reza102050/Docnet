Imports Microsoft.VisualBasic.Compatibility.VB6
Module DataEnvironment_de3_Module
    Friend de3 As DataEnvironment_de3 = New DataEnvironment_de3()
End Module
Friend Class DataEnvironment_de3
    Inherits VB6.BaseDataEnvironment

    Public WithEvents con_eoffice As ADODB.Connection
    Public WithEvents rslistsal As ADODB.Recordset
    Public WithEvents rslistkar As ADODB.Recordset
    Public WithEvents rsDelsal As ADODB.Recordset
    Public WithEvents rsfindpass As ADODB.Recordset
    Private m_findpass As ADODB.Command
    Public WithEvents rsfinduser As ADODB.Recordset
    Private m_finduser As ADODB.Command
    Private m_listsal As ADODB.Command
    Private m_Delsal As ADODB.Command
    Private m_listkar As ADODB.Command
    Public WithEvents rsfindkar As ADODB.Recordset
    Private m_findkar As ADODB.Command
    Public WithEvents rsfindsal As ADODB.Recordset
    Private m_findsal As ADODB.Command
    Public WithEvents rsbrowpid As ADODB.Recordset
    Private m_browpid As ADODB.Command
    Public WithEvents rsbrowAll As ADODB.Recordset
    Private m_browAll As ADODB.Command

    Public Sub New()
        MyBase.New()
        con_eoffice = New ADODB.Connection()
        con_eoffice.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\daro\Eoffice1389.mdb;Persist Security Info=False;"
        m_Connections.Add(con_eoffice, "con_eoffice")
        Dim par As ADODB.Parameter
        '------------------------
        m_listsal = New ADODB.Command()
        rslistsal = New ADODB.Recordset()
        m_listsal.Name = "listsal"
        m_listsal.CommandText = "select * from sal order by psal desc"
        m_listsal.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistsal.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistsal.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistsal.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistsal.Source = m_listsal
        m_Commands.Add(m_listsal, "listsal")
        m_Recordsets.Add(rslistsal, "listsal")
        '-----------------------------------
        m_findsal = New ADODB.Command()
        rsfindsal = New ADODB.Recordset()
        m_findsal.Name = "findsal"
        m_findsal.CommandText = "select * from sal where id=?"
        m_findsal.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindsal.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findsal.CreateParameter
        par.Name = "Param1"
        par.Type = ADODB.DataTypeEnum.adInteger
        par.Size = 4
        par.Precision = 10
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findsal.Parameters.Append(par)
        rsfindsal.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindsal.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindsal.Source = m_findsal
        m_Commands.Add(m_findsal, "findsal")
        m_Recordsets.Add(rsfindsal, "findsal")
        '------------------------
        m_delsal = New ADODB.Command()
        rsdelsal = New ADODB.Recordset()
        m_Delsal.Name = "Delsal"
        m_Delsal.CommandText = "Delete  * from sal "
        m_delsal.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsdelsal.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsdelsal.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsdelsal.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsdelsal.Source = m_delsal
        m_Commands.Add(m_Delsal, "Delsal")
        m_Recordsets.Add(rsDelsal, "Delsal")
        '---------------------------------------------------
        m_findpass = New ADODB.Command()
        rsfindpass = New ADODB.Recordset()
        m_findpass.Name = "findpass"
        m_findpass.CommandText = "select *  from karbar where naka=? and pass=?"
        m_findpass.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindpass.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findpass.CreateParameter
        par.Name = "_naka"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findpass.Parameters.Append(par)
        par = m_findpass.CreateParameter
        par.Name = "_pass"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findpass.Parameters.Append(par)
        rsfindpass.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindpass.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindpass.Source = m_findpass
        m_Commands.Add(m_findpass, "findpass")
        m_Recordsets.Add(rsfindpass, "findpass")
        m_finduser = New ADODB.Command()
        rsfinduser = New ADODB.Recordset()
        m_finduser.Name = "finduser"
        m_finduser.CommandText = "select * from karbar where naka=?"
        m_finduser.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfinduser.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_finduser.CreateParameter
        par.Name = "_parm"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Precision = 255
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_finduser.Parameters.Append(par)
        rsfinduser.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfinduser.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfinduser.Source = m_finduser
        m_Commands.Add(m_finduser, "finduser")
        m_Recordsets.Add(rsfinduser, "finduser")
        '---------------------------------------------------------
        m_listkar = New ADODB.Command()
        rslistkar = New ADODB.Recordset()
        m_listkar.Name = "listkar"
        m_listkar.CommandText = "select * from karbar"
        m_listkar.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistkar.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistkar.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistkar.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistkar.Source = m_listkar
        m_Commands.Add(m_listkar, "listkar")
        m_Recordsets.Add(rslistkar, "listkar")
        m_findkar = New ADODB.Command()
        rsfindkar = New ADODB.Recordset()
        m_findkar.Name = "findkar"
        m_findkar.CommandText = "select * from karbar where coka=?"
        m_findkar.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindkar.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findkar.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Precision = 255
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findkar.Parameters.Append(par)
        rsfindkar.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindkar.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindkar.Source = m_findkar
        m_Commands.Add(m_findkar, "findkar")
        m_Recordsets.Add(rsfindkar, "findkar")
        '--------------------------------------------
        '----------------------------------
        m_browpid = New ADODB.Command()
        rsbrowpid = New ADODB.Recordset()
        m_browpid.Name = "browpid"
        m_browpid.CommandText = "select * from progid "
        m_browpid.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowpid.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsbrowpid.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowpid.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowpid.Source = m_browpid
        m_Commands.Add(m_browpid, "browpid")
        m_Recordsets.Add(rsbrowpid, "browpid")

        '----------------------------------
        m_browAll = New ADODB.Command()
        rsbrowAll = New ADODB.Recordset()
        m_browAll.Name = "browAll"
        m_browAll.CommandText = "select * from karbar "
        m_browAll.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowAll.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsbrowAll.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowAll.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowAll.Source = m_browAll
        m_Commands.Add(m_listsal, "browAll")
        m_Recordsets.Add(rslistsal, "browAll")
        '---------------------------------------------------

    End Sub
    Public Sub listsal(ByVal Tsql As String)
        If con_eoffice.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_eoffice.Open()
        End If
        If rslistsal.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistsal.Close()
        End If
        m_listsal.CommandText = Tsql
        m_listsal.ActiveConnection = con_eoffice
        rslistsal.Open()
    End Sub
    Public Sub Delsal()
        If con_eoffice.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_eoffice.Open()
        End If
        If rsDelsal.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsDelsal.Close()
        End If
        m_Delsal.ActiveConnection = con_eoffice
        rsDelsal.Open()
    End Sub
    Public Sub findsal(ByVal Param1 As Integer)
        If con_eoffice.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_eoffice.Open()
        End If
        If rsfindsal.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindsal.Close()
        End If
        m_findsal.ActiveConnection = con_eoffice
        m_findsal.Parameters.Item("Param1").Value = Param1
        rsfindsal.Open()
    End Sub
    Public Sub findpass(ByVal _naka As String, ByVal _pass As String)
        If con_eoffice.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_eoffice.Open()
        End If
        If rsfindpass.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindpass.Close()
        End If
        m_findpass.ActiveConnection = con_eoffice
        m_findpass.Parameters.Item("_naka").Value = _naka
        m_findpass.Parameters.Item("_pass").Value = _pass
        rsfindpass.Open()
    End Sub
    Public Sub finduser(ByVal _parm1 As String)
        If con_eoffice.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_eoffice.Open()
        End If
        If rsfinduser.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfinduser.Close()
        End If
        m_finduser.ActiveConnection = con_eoffice
        m_finduser.Parameters.Item("_parm").Value = _parm1
        rsfinduser.Open()
    End Sub
    Public Sub listkar()
        If con_eoffice.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_eoffice.Open()
        End If
        If rslistkar.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistkar.Close()
        End If
        m_listkar.ActiveConnection = con_eoffice
        rslistkar.Open()
    End Sub
    Public Sub findkar(ByVal _parm1 As String)
        If con_eoffice.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_eoffice.Open()
        End If
        If rsfindkar.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindkar.Close()
        End If
        m_findkar.ActiveConnection = con_eoffice
        m_findkar.Parameters.Item("_parm1").Value = _parm1
        rsfindkar.Open()
    End Sub
    Public Sub browpid(ByVal Strsql As String)
        If con_eoffice.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_eoffice.Open()
        End If
        If rsbrowpid.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowpid.Close()
        End If
        m_browpid.ActiveConnection = con_eoffice
        m_browpid.CommandText = Strsql
        rsbrowpid.Open()
    End Sub
    Public Sub browAll(ByVal Strsql As String)
        If con_eoffice.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_eoffice.Open()
        End If
        If rsbrowAll.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowAll.Close()
        End If
        m_browAll.ActiveConnection = con_eoffice
        m_browAll.CommandText = Strsql
        rsbrowAll.Open()
    End Sub

End Class
