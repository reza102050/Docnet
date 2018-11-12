Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility

Module DataEnvironment_deHesab_Module
    Friend deHesab As DataEnvironment_deHesab = New DataEnvironment_deHesab()
End Module

Friend Class DataEnvironment_deHesab
    Inherits VB6.BaseDataEnvironment
    Public WithEvents con_data As ADODB.Connection
    Public WithEvents con_newyear As ADODB.Connection
    Public WithEvents ConUpdate As ADODB.Connection
    Public WithEvents rsfindcode As ADODB.Recordset
    Private m_findcode As ADODB.Command
    Public WithEvents rslistcode As ADODB.Recordset
    Private m_listcode As ADODB.Command
    Public WithEvents rsfindkala As ADODB.Recordset
    Private m_findkala As ADODB.Command
    Public WithEvents rslistkala As ADODB.Recordset
    Private m_listkala As ADODB.Command
    Public WithEvents rsbrow_cardex As ADODB.Recordset
    Private m_brow_cardex As ADODB.Command
    Public WithEvents rstanzimhesab As ADODB.Recordset
    Private m_tanzimhesab As ADODB.Command
    Public WithEvents rsbrow_temp As ADODB.Recordset
    Private m_brow_temp As ADODB.Command
    Public WithEvents rsbrow_tempriz As ADODB.Recordset
    Private m_brow_tempriz As ADODB.Command
    Public WithEvents rslisttemp As ADODB.Recordset
    Private m_listtemp As ADODB.Command
    Public WithEvents rsbrow_sanadcode As ADODB.Recordset
    Private m_brow_sanadcode As ADODB.Command
    Public WithEvents rsshowoldrem As ADODB.Recordset
    Private m_showoldrem As ADODB.Command
    Public WithEvents rssanad As ADODB.Recordset
    Private m_sanad As ADODB.Command
    Public WithEvents rsbrow_sanadriz As ADODB.Recordset
    Private m_brow_sanadriz As ADODB.Command
    Public WithEvents rsfindsanad As ADODB.Recordset
    Private m_findsanad As ADODB.Command
    Public WithEvents rsbdhospname As ADODB.Recordset
    Private m_bdhospname As ADODB.Command
    Public WithEvents rsfindchek As ADODB.Recordset
    Private m_findchek As ADODB.Command
    Public WithEvents rsshowoldcardex As ADODB.Recordset
    Private m_showoldcardex As ADODB.Command
    Public WithEvents rsbrowall As ADODB.Recordset
    Private m_browall As ADODB.Command
    Public WithEvents rsiokala As ADODB.Recordset
    Private m_iokala As ADODB.Command
    Public WithEvents rsfindiokala As ADODB.Recordset
    Private m_findiokala As ADODB.Command
    Public WithEvents rsbrowasnad As ADODB.Recordset
    Private m_browasnad As ADODB.Command
    Public WithEvents rsbrowfkey As ADODB.Recordset
    Private m_browfkey As ADODB.Command
    Public WithEvents rsshowkala As ADODB.Recordset
    Private m_showkala As ADODB.Command
    Public WithEvents rsbrowkol As ADODB.Recordset
    Private m_browkol As ADODB.Command
    Public WithEvents rslistchek As ADODB.Recordset
    Private m_listchek As ADODB.Command
    Public WithEvents rsfindtemp As ADODB.Recordset
    Private m_findtemp As ADODB.Command
    Public WithEvents rsbrow_amani As ADODB.Recordset
    Private m_brow_amani As ADODB.Command
    Public WithEvents rsbrow_ioamani As ADODB.Recordset
    Private m_brow_ioamani As ADODB.Command
    Public WithEvents rslistasnad As ADODB.Recordset
    Private m_listasnad As ADODB.Command
    Public WithEvents rskolnewyear As ADODB.Recordset
    Private m_kolnewyear As ADODB.Command
    Public WithEvents rssanadriznewyear As ADODB.Recordset
    Private m_sanadriznewyear As ADODB.Command
    Public WithEvents rssanadnewyear As ADODB.Recordset
    Private m_sanadnewyear As ADODB.Command
    Public WithEvents rsfindmain As ADODB.Recordset
    Private m_findmain As ADODB.Command
    Public WithEvents rslistkar As ADODB.Recordset
    Private m_listkar As ADODB.Command
    Public WithEvents rsfindkar As ADODB.Recordset
    Private m_findkar As ADODB.Command
    Public WithEvents rsfindpass As ADODB.Recordset
    Private m_findpass As ADODB.Command
    Public WithEvents rsfindnamkar As ADODB.Recordset
    Private m_findnamkar As ADODB.Command
    Public WithEvents rsbdprint As ADODB.Recordset
    Private m_bdprint As ADODB.Command
    Public WithEvents rsbdprintkar As ADODB.Recordset
    Private m_bdprintkar As ADODB.Command
    Public WithEvents rsbrowpid As ADODB.Recordset
    Private m_browpid As ADODB.Command
    Public WithEvents rslistsal As ADODB.Recordset
    Private m_listsal As ADODB.Command
    Public WithEvents rsfindsal As ADODB.Recordset
    Private m_findsal As ADODB.Command
    Public WithEvents rslistprogid As ADODB.Recordset
    Private m_listprogid As ADODB.Command
    Public WithEvents rsfindserial As ADODB.Recordset
    Private m_findserial As ADODB.Command
    Public WithEvents rslistStore As ADODB.Recordset
    Private m_listStore As ADODB.Command
    Public WithEvents rsfindStore As ADODB.Recordset
    Private m_findStore As ADODB.Command
    Public WithEvents rsListCardex As ADODB.Recordset
    Private m_ListCardex As ADODB.Command
    Public WithEvents rsListMyAnaliz As ADODB.Recordset
    Private m_ListMyAnaliz As ADODB.Command
    Public WithEvents rsGetTemp As ADODB.Recordset
    Private m_GetTemp As ADODB.Command
    Public WithEvents rsGetSold As ADODB.Recordset
    Private m_GetSold As ADODB.Command
    Public WithEvents rsrptkol As ADODB.Recordset
    Private m_rptkol As ADODB.Command
    Public WithEvents rsrptsanadriz As ADODB.Recordset
    Private m_rptsanadriz As ADODB.Command
    Public WithEvents rsrptasnad As ADODB.Recordset
    Private m_rptasnad As ADODB.Command
    Public WithEvents rsrptkoltraz As ADODB.Recordset
    Private m_rptkoltraz As ADODB.Command
    Public WithEvents rsrptchek As ADODB.Recordset
    Private m_rptchek As ADODB.Command
    Public WithEvents rsrptcardex As ADODB.Recordset
    Private m_rptcardex As ADODB.Command
    Public WithEvents rsrptiokala As ADODB.Recordset
    Private m_rptiokala As ADODB.Command
    Public WithEvents rsrptkala As ADODB.Recordset
    Private m_rptkala As ADODB.Command
    Public WithEvents rsGetSanad As ADODB.Recordset
    Private m_GetSanad As ADODB.Command
    Public WithEvents rsListCardexKala As ADODB.Recordset
    Private m_ListCardexKala As ADODB.Command
    Public WithEvents rsSumCardexKala As ADODB.Recordset
    Private m_SumCardexKala As ADODB.Command
    Public WithEvents rsUkol As ADODB.Recordset
    Private m_Ukol As ADODB.Command
    Public WithEvents rsfindcheck As ADODB.Recordset
    Private m_findcheck As ADODB.Command
    Public WithEvents rslistcheck As ADODB.Recordset
    Private m_listcheck As ADODB.Command
    Public WithEvents rsfindchktnz As ADODB.Recordset
    Private m_findchktnz As ADODB.Command
    Public WithEvents rsbrowchektanzim As ADODB.Recordset
    Private m_browchektanzim As ADODB.Command
    Public WithEvents rsfindhazineh As ADODB.Recordset
    Private m_findhazineh As ADODB.Command
    Public WithEvents rslisthazineh As ADODB.Recordset
    Private m_listhazineh As ADODB.Command
    Public WithEvents rsfindVisitor As ADODB.Recordset
    Private m_findVisitor As ADODB.Command
    Public WithEvents rslistVisitor As ADODB.Recordset
    Private m_listVisitor As ADODB.Command
    Public WithEvents rsListTemp1 As ADODB.Recordset
    Private m_ListTemp1 As ADODB.Command
    Public WithEvents rstanzimhesabnewyear As ADODB.Recordset
    Private m_tanzimhesabnewyear As ADODB.Command
    Public WithEvents rskalaNewYear As ADODB.Recordset
    Private m_kalaNewYear As ADODB.Command
    Public WithEvents rsCardexNewYear As ADODB.Recordset
    Private m_CardexNewYear As ADODB.Command
    Public WithEvents rscoding As ADODB.Recordset
    Private m_coding As ADODB.Command
    Public WithEvents rsrptkalaIO As ADODB.Recordset
    Private m_rptkalaIO As ADODB.Command
    Public WithEvents rsSumRow As ADODB.Recordset
    Private m_SumRow As ADODB.Command
    Public WithEvents rsListCardexByCode As ADODB.Recordset
    Private m_ListCardexByCode As ADODB.Command
    Public WithEvents rsBrowKolTemp As ADODB.Recordset
    Private m_BrowKolTemp As ADODB.Command
    Public WithEvents rsbrowVcode As ADODB.Recordset
    Private m_browVcode As ADODB.Command
    Public Sub New()
        MyBase.New()
        Dim par As ADODB.Parameter


        con_data = New ADODB.Connection()
        con_data.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\WACCOUNT\HESAB1388.MDB;Persist Security Info=False;"
        m_Connections.Add(con_data, "con_data")
        con_newyear = New ADODB.Connection()
        con_newyear.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\WACCOUNT\HESAB1384.MDB;Persist Security Info=False;"
        m_Connections.Add(con_newyear, "con_newyear")
        ConUpdate = New ADODB.Connection()
        ConUpdate.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\WACCOUNT\update.mdb;Persist Security Info=False;"
        m_Connections.Add(ConUpdate, "ConUpdate")
        m_findcode = New ADODB.Command()
        rsfindcode = New ADODB.Recordset()
        m_findcode.Name = "findcode"
        m_findcode.CommandText = "select * from  kol where code =?"
        m_findcode.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindcode.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findcode.CreateParameter
        par.Name = "_code"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 10
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findcode.Parameters.Append(par)
        rsfindcode.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindcode.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindcode.Source = m_findcode
        m_Commands.Add(m_findcode, "findcode")
        m_Recordsets.Add(rsfindcode, "findcode")
        m_listcode = New ADODB.Command()
        rslistcode = New ADODB.Recordset()
        m_listcode.Name = "listcode"
        m_listcode.CommandText = "select * from kol"
        m_listcode.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistcode.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistcode.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistcode.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistcode.Source = m_listcode
        m_Commands.Add(m_listcode, "listcode")
        m_Recordsets.Add(rslistcode, "listcode")
        m_findkala = New ADODB.Command()
        rsfindkala = New ADODB.Recordset()
        m_findkala.Name = "findkala"
        m_findkala.CommandText = "select * from  kala where ck=?"
        m_findkala.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindkala.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findkala.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findkala.Parameters.Append(par)
        rsfindkala.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindkala.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindkala.Source = m_findkala
        m_Commands.Add(m_findkala, "findkala")
        m_Recordsets.Add(rsfindkala, "findkala")
        m_listkala = New ADODB.Command()
        rslistkala = New ADODB.Recordset()
        m_listkala.Name = "listkala"
        m_listkala.CommandText = "select * from kala order by ck"
        m_listkala.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistkala.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistkala.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistkala.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistkala.Source = m_listkala
        m_Commands.Add(m_listkala, "listkala")
        m_Recordsets.Add(rslistkala, "listkala")
        m_brow_cardex = New ADODB.Command()
        rsbrow_cardex = New ADODB.Recordset()
        m_brow_cardex.Name = "brow_cardex"
        m_brow_cardex.CommandText = "select * from cardex where nf=? and oper=?"
        m_brow_cardex.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrow_cardex.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_brow_cardex.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_cardex.Parameters.Append(par)
        par = m_brow_cardex.CreateParameter
        par.Name = "_par2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_cardex.Parameters.Append(par)
        rsbrow_cardex.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrow_cardex.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrow_cardex.Source = m_brow_cardex
        m_Commands.Add(m_brow_cardex, "brow_cardex")
        m_Recordsets.Add(rsbrow_cardex, "brow_cardex")
        m_tanzimhesab = New ADODB.Command()
        rstanzimhesab = New ADODB.Recordset()
        m_tanzimhesab.Name = "tanzimhesab"
        m_tanzimhesab.CommandText = "select * from tanzimhesab"
        m_tanzimhesab.CommandType = ADODB.CommandTypeEnum.adCmdText
        rstanzimhesab.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rstanzimhesab.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rstanzimhesab.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rstanzimhesab.Source = m_tanzimhesab
        m_Commands.Add(m_tanzimhesab, "tanzimhesab")
        m_Recordsets.Add(rstanzimhesab, "tanzimhesab")
        m_brow_temp = New ADODB.Command()
        rsbrow_temp = New ADODB.Recordset()
        m_brow_temp.Name = "brow_temp"
        m_brow_temp.CommandText = "select * from sanadtemp where radif=?"
        m_brow_temp.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrow_temp.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_brow_temp.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_temp.Parameters.Append(par)
        rsbrow_temp.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrow_temp.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrow_temp.Source = m_brow_temp
        m_Commands.Add(m_brow_temp, "brow_temp")
        m_Recordsets.Add(rsbrow_temp, "brow_temp")
        m_brow_tempriz = New ADODB.Command()
        rsbrow_tempriz = New ADODB.Recordset()
        m_brow_tempriz.Name = "brow_tempriz"
        m_brow_tempriz.CommandText = "select * from  sanadtempriz where radif=?"
        m_brow_tempriz.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrow_tempriz.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_brow_tempriz.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_tempriz.Parameters.Append(par)
        rsbrow_tempriz.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrow_tempriz.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrow_tempriz.Source = m_brow_tempriz
        m_Commands.Add(m_brow_tempriz, "brow_tempriz")
        m_Recordsets.Add(rsbrow_tempriz, "brow_tempriz")
        m_listtemp = New ADODB.Command()
        rslisttemp = New ADODB.Recordset()
        m_listtemp.Name = "listtemp"
        m_listtemp.CommandText = "select * from  sanadtemp where vaz=0  order by radif"
        m_listtemp.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslisttemp.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslisttemp.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslisttemp.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslisttemp.Source = m_listtemp
        m_Commands.Add(m_listtemp, "listtemp")
        m_Recordsets.Add(rslisttemp, "listtemp")
        m_brow_sanadcode = New ADODB.Command()
        rsbrow_sanadcode = New ADODB.Recordset()
        m_brow_sanadcode.Name = "brow_sanadcode"
        m_brow_sanadcode.CommandText = "select * from  sanadriz "
        m_brow_sanadcode.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrow_sanadcode.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsbrow_sanadcode.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrow_sanadcode.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrow_sanadcode.Source = m_brow_sanadcode
        m_Commands.Add(m_brow_sanadcode, "brow_sanadcode")
        m_Recordsets.Add(rsbrow_sanadcode, "brow_sanadcode")
        m_showoldrem = New ADODB.Command()
        rsshowoldrem = New ADODB.Recordset()
        m_showoldrem.Name = "showoldrem"
        m_showoldrem.CommandText = "SELECT SUM(bedeh) AS totbed, SUM(bestan) AS totbes FROM sanadriz "
        m_showoldrem.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsshowoldrem.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsshowoldrem.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsshowoldrem.LockType = ADODB.LockTypeEnum.adLockReadOnly
        rsshowoldrem.Source = m_showoldrem
        m_Commands.Add(m_showoldrem, "showoldrem")
        m_Recordsets.Add(rsshowoldrem, "showoldrem")
        m_sanad = New ADODB.Command()
        rssanad = New ADODB.Recordset()
        m_sanad.Name = "sanad"
        m_sanad.CommandText = "select * from  sanadriz "
        m_sanad.CommandType = ADODB.CommandTypeEnum.adCmdText
        rssanad.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rssanad.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rssanad.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rssanad.Source = m_sanad
        m_Commands.Add(m_sanad, "sanad")
        m_Recordsets.Add(rssanad, "sanad")
        m_brow_sanadriz = New ADODB.Command()
        rsbrow_sanadriz = New ADODB.Recordset()
        m_brow_sanadriz.Name = "brow_sanadriz"
        m_brow_sanadriz.CommandText = "select * from sanadriz where ns=? order by radif"
        m_brow_sanadriz.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrow_sanadriz.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_brow_sanadriz.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_sanadriz.Parameters.Append(par)
        rsbrow_sanadriz.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrow_sanadriz.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrow_sanadriz.Source = m_brow_sanadriz
        m_Commands.Add(m_brow_sanadriz, "brow_sanadriz")
        m_Recordsets.Add(rsbrow_sanadriz, "brow_sanadriz")
        m_findsanad = New ADODB.Command()
        rsfindsanad = New ADODB.Recordset()
        m_findsanad.Name = "findsanad"
        m_findsanad.CommandText = "select  * from asnad where ns=?"
        m_findsanad.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindsanad.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findsanad.CreateParameter
        par.Name = "_ns"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findsanad.Parameters.Append(par)
        rsfindsanad.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindsanad.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindsanad.Source = m_findsanad
        m_Commands.Add(m_findsanad, "findsanad")
        m_Recordsets.Add(rsfindsanad, "findsanad")
        m_bdhospname = New ADODB.Command()
        rsbdhospname = New ADODB.Recordset()
        m_bdhospname.Name = "bdhospname"
        m_bdhospname.CommandText = "select * from  kol where  kol.name like ?"
        m_bdhospname.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbdhospname.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_bdhospname.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_bdhospname.Parameters.Append(par)
        rsbdhospname.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbdhospname.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbdhospname.Source = m_bdhospname
        m_Commands.Add(m_bdhospname, "bdhospname")
        m_Recordsets.Add(rsbdhospname, "bdhospname")
        m_findchek = New ADODB.Command()
        rsfindchek = New ADODB.Recordset()
        m_findchek.Name = "findchek"
        m_findchek.CommandText = "SELECT * FROM chek  WHERE (IDCHEK = ?)"
        m_findchek.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindchek.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findchek.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findchek.Parameters.Append(par)
        rsfindchek.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindchek.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindchek.Source = m_findchek
        m_Commands.Add(m_findchek, "findchek")
        m_Recordsets.Add(rsfindchek, "findchek")
        m_showoldcardex = New ADODB.Command()
        rsshowoldcardex = New ADODB.Recordset()
        m_showoldcardex.Name = "showoldcardex"
        m_showoldcardex.CommandText = "SELECT SUM(nom_in) AS totbed, SUM(nom_out) AS totbes FROM cardex   WHERE ck=? AND datee<?"
        m_showoldcardex.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsshowoldcardex.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_showoldcardex.CreateParameter
        par.Name = "_ck"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_showoldcardex.Parameters.Append(par)
        par = m_showoldcardex.CreateParameter
        par.Name = "_date"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_showoldcardex.Parameters.Append(par)
        rsshowoldcardex.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsshowoldcardex.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsshowoldcardex.Source = m_showoldcardex
        m_Commands.Add(m_showoldcardex, "showoldcardex")
        m_Recordsets.Add(rsshowoldcardex, "showoldcardex")
        m_browall = New ADODB.Command()
        rsbrowall = New ADODB.Recordset()
        m_browall.Name = "browall"
        m_browall.CommandText = "select * from kol"
        m_browall.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowall.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsbrowall.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowall.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowall.Source = m_browall
        m_Commands.Add(m_browall, "browall")
        m_Recordsets.Add(rsbrowall, "browall")
        m_iokala = New ADODB.Command()
        rsiokala = New ADODB.Recordset()
        m_iokala.Name = "iokala"
        m_iokala.CommandText = "select * from iokala"
        m_iokala.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsiokala.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsiokala.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsiokala.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsiokala.Source = m_iokala
        m_Commands.Add(m_iokala, "iokala")
        m_Recordsets.Add(rsiokala, "iokala")
        m_findiokala = New ADODB.Command()
        rsfindiokala = New ADODB.Recordset()
        m_findiokala.Name = "findiokala"
        m_findiokala.CommandText = "select * from iokala where  tip=? and nf=?"
        m_findiokala.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindiokala.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findiokala.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findiokala.Parameters.Append(par)
        par = m_findiokala.CreateParameter
        par.Name = "_par2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findiokala.Parameters.Append(par)
        rsfindiokala.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindiokala.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindiokala.Source = m_findiokala
        m_Commands.Add(m_findiokala, "findiokala")
        m_Recordsets.Add(rsfindiokala, "findiokala")
        m_browasnad = New ADODB.Command()
        rsbrowasnad = New ADODB.Recordset()
        m_browasnad.Name = "browasnad"
        m_browasnad.CommandText = "select * from sanadriz "
        m_browasnad.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowasnad.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsbrowasnad.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowasnad.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowasnad.Source = m_browasnad
        m_Commands.Add(m_browasnad, "browasnad")
        m_Recordsets.Add(rsbrowasnad, "browasnad")
        m_browfkey = New ADODB.Command()
        rsbrowfkey = New ADODB.Recordset()
        m_browfkey.Name = "browfkey"
        m_browfkey.CommandText = "select * from fkey  order by keyid"
        m_browfkey.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowfkey.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsbrowfkey.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowfkey.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowfkey.Source = m_browfkey
        m_Commands.Add(m_browfkey, "browfkey")
        m_Recordsets.Add(rsbrowfkey, "browfkey")
        m_showkala = New ADODB.Command()
        rsshowkala = New ADODB.Recordset()
        m_showkala.Name = "showkala"
        m_showkala.CommandText = "select * from kala"
        m_showkala.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsshowkala.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsshowkala.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsshowkala.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsshowkala.Source = m_showkala
        m_Commands.Add(m_showkala, "showkala")
        m_Recordsets.Add(rsshowkala, "showkala")
        m_browkol = New ADODB.Command()
        rsbrowkol = New ADODB.Recordset()
        m_browkol.Name = "browkol"
        m_browkol.CommandText = "select * from kol"
        m_browkol.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowkol.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsbrowkol.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowkol.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowkol.Source = m_browkol
        m_Commands.Add(m_browkol, "browkol")
        m_Recordsets.Add(rsbrowkol, "browkol")
        m_listchek = New ADODB.Command()
        rslistchek = New ADODB.Recordset()
        m_listchek.Name = "listchek"
        m_listchek.CommandText = "select * from chek "
        m_listchek.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistchek.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistchek.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistchek.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistchek.Source = m_listchek
        m_Commands.Add(m_listchek, "listchek")
        m_Recordsets.Add(rslistchek, "listchek")
        m_findtemp = New ADODB.Command()
        rsfindtemp = New ADODB.Recordset()
        m_findtemp.Name = "findtemp"
        m_findtemp.CommandText = "select * from  sanadtemp where radif=?"
        m_findtemp.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindtemp.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findtemp.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findtemp.Parameters.Append(par)
        rsfindtemp.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindtemp.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindtemp.Source = m_findtemp
        m_Commands.Add(m_findtemp, "findtemp")
        m_Recordsets.Add(rsfindtemp, "findtemp")
        m_brow_amani = New ADODB.Command()
        rsbrow_amani = New ADODB.Recordset()
        m_brow_amani.Name = "brow_amani"
        m_brow_amani.CommandText = "select * from cardamani where nf=?  order by radif"
        m_brow_amani.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrow_amani.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_brow_amani.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_amani.Parameters.Append(par)
        rsbrow_amani.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrow_amani.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrow_amani.Source = m_brow_amani
        m_Commands.Add(m_brow_amani, "brow_amani")
        m_Recordsets.Add(rsbrow_amani, "brow_amani")
        m_brow_ioamani = New ADODB.Command()
        rsbrow_ioamani = New ADODB.Recordset()
        m_brow_ioamani.Name = "brow_ioamani"
        m_brow_ioamani.CommandText = "select * from  ioamani where nf=? "
        m_brow_ioamani.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrow_ioamani.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_brow_ioamani.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_ioamani.Parameters.Append(par)
        rsbrow_ioamani.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrow_ioamani.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrow_ioamani.Source = m_brow_ioamani
        m_Commands.Add(m_brow_ioamani, "brow_ioamani")
        m_Recordsets.Add(rsbrow_ioamani, "brow_ioamani")
        m_listasnad = New ADODB.Command()
        rslistasnad = New ADODB.Recordset()
        m_listasnad.Name = "listasnad"
        m_listasnad.CommandText = "select * from asnad"
        m_listasnad.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistasnad.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistasnad.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistasnad.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistasnad.Source = m_listasnad
        m_Commands.Add(m_listasnad, "listasnad")
        m_Recordsets.Add(rslistasnad, "listasnad")
        m_kolnewyear = New ADODB.Command()
        rskolnewyear = New ADODB.Recordset()
        m_kolnewyear.Name = "kolnewyear"
        m_kolnewyear.CommandText = "select * from kol"
        m_kolnewyear.CommandType = ADODB.CommandTypeEnum.adCmdText
        rskolnewyear.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rskolnewyear.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rskolnewyear.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rskolnewyear.Source = m_kolnewyear
        m_Commands.Add(m_kolnewyear, "kolnewyear")
        m_Recordsets.Add(rskolnewyear, "kolnewyear")
        m_sanadriznewyear = New ADODB.Command()
        rssanadriznewyear = New ADODB.Recordset()
        m_sanadriznewyear.Name = "sanadriznewyear"
        m_sanadriznewyear.CommandText = "select * from sanadriz "
        m_sanadriznewyear.CommandType = ADODB.CommandTypeEnum.adCmdText
        rssanadriznewyear.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rssanadriznewyear.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rssanadriznewyear.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rssanadriznewyear.Source = m_sanadriznewyear
        m_Commands.Add(m_sanadriznewyear, "sanadriznewyear")
        m_Recordsets.Add(rssanadriznewyear, "sanadriznewyear")
        m_sanadnewyear = New ADODB.Command()
        rssanadnewyear = New ADODB.Recordset()
        m_sanadnewyear.Name = "sanadnewyear"
        m_sanadnewyear.CommandText = "select * from asnad "
        m_sanadnewyear.CommandType = ADODB.CommandTypeEnum.adCmdText
        rssanadnewyear.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rssanadnewyear.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rssanadnewyear.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rssanadnewyear.Source = m_sanadnewyear
        m_Commands.Add(m_sanadnewyear, "sanadnewyear")
        m_Recordsets.Add(rssanadnewyear, "sanadnewyear")
        m_findmain = New ADODB.Command()
        rsfindmain = New ADODB.Recordset()
        m_findmain.Name = "findmain"
        m_findmain.CommandText = "select * from main"
        m_findmain.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindmain.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsfindmain.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindmain.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindmain.Source = m_findmain
        m_Commands.Add(m_findmain, "findmain")
        m_Recordsets.Add(rsfindmain, "findmain")
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
        par.Name = "Param1"
        par.Type = ADODB.DataTypeEnum.adInteger
        par.Size = 4
        par.Precision = 10
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findkar.Parameters.Append(par)
        rsfindkar.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindkar.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindkar.Source = m_findkar
        m_Commands.Add(m_findkar, "findkar")
        m_Recordsets.Add(rsfindkar, "findkar")
        m_findpass = New ADODB.Command()
        rsfindpass = New ADODB.Recordset()
        m_findpass.Name = "findpass"
        m_findpass.CommandText = "select * from karbar where naka=? and pass=?"
        m_findpass.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindpass.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findpass.CreateParameter
        par.Name = "Param1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 50
        par.Precision = 255
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findpass.Parameters.Append(par)
        par = m_findpass.CreateParameter
        par.Name = "Param2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 20
        par.Precision = 255
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findpass.Parameters.Append(par)
        rsfindpass.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindpass.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindpass.Source = m_findpass
        m_Commands.Add(m_findpass, "findpass")
        m_Recordsets.Add(rsfindpass, "findpass")
        m_findnamkar = New ADODB.Command()
        rsfindnamkar = New ADODB.Recordset()
        m_findnamkar.Name = "findnamkar"
        m_findnamkar.CommandText = "select * from karbar where naka=? "
        m_findnamkar.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindnamkar.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findnamkar.CreateParameter
        par.Name = "Param1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 50
        par.Precision = 255
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findnamkar.Parameters.Append(par)
        rsfindnamkar.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindnamkar.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindnamkar.Source = m_findnamkar
        m_Commands.Add(m_findnamkar, "findnamkar")
        m_Recordsets.Add(rsfindnamkar, "findnamkar")
        m_bdprint = New ADODB.Command()
        rsbdprint = New ADODB.Recordset()
        m_bdprint.Name = "bdprint"
        m_bdprint.CommandText = "select * from bdprint"
        m_bdprint.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbdprint.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsbdprint.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbdprint.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbdprint.Source = m_bdprint
        m_Commands.Add(m_bdprint, "bdprint")
        m_Recordsets.Add(rsbdprint, "bdprint")
        m_bdprintkar = New ADODB.Command()
        rsbdprintkar = New ADODB.Recordset()
        m_bdprintkar.Name = "bdprintkar"
        m_bdprintkar.CommandText = "select * from bdprint where karbar=?"
        m_bdprintkar.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbdprintkar.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_bdprintkar.CreateParameter
        par.Name = "Param1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 50
        par.Precision = 255
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_bdprintkar.Parameters.Append(par)
        rsbdprintkar.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbdprintkar.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbdprintkar.Source = m_bdprintkar
        m_Commands.Add(m_bdprintkar, "bdprintkar")
        m_Recordsets.Add(rsbdprintkar, "bdprintkar")
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
        m_listsal = New ADODB.Command()
        rslistsal = New ADODB.Recordset()
        m_listsal.Name = "listsal"
        m_listsal.CommandText = "select * from sal "
        m_listsal.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistsal.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistsal.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistsal.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistsal.Source = m_listsal
        m_Commands.Add(m_listsal, "listsal")
        m_Recordsets.Add(rslistsal, "listsal")
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
        m_listprogid = New ADODB.Command()
        rslistprogid = New ADODB.Recordset()
        m_listprogid.Name = "listprogid"
        m_listprogid.CommandText = "select  * from progid"
        m_listprogid.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistprogid.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistprogid.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistprogid.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistprogid.Source = m_listprogid
        m_Commands.Add(m_listprogid, "listprogid")
        m_Recordsets.Add(rslistprogid, "listprogid")
        m_findserial = New ADODB.Command()
        rsfindserial = New ADODB.Recordset()
        m_findserial.Name = "findserial"
        m_findserial.CommandText = "select * from main"
        m_findserial.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindserial.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsfindserial.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindserial.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindserial.Source = m_findserial
        m_Commands.Add(m_findserial, "findserial")
        m_Recordsets.Add(rsfindserial, "findserial")
        m_listStore = New ADODB.Command()
        rslistStore = New ADODB.Recordset()
        m_listStore.Name = "listStore"
        m_listStore.CommandText = "select * from store"
        m_listStore.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistStore.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistStore.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistStore.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistStore.Source = m_listStore
        m_Commands.Add(m_listStore, "listStore")
        m_Recordsets.Add(rslistStore, "listStore")
        m_findStore = New ADODB.Command()
        rsfindStore = New ADODB.Recordset()
        m_findStore.Name = "findStore"
        m_findStore.CommandText = "select * from Store where storeCode=?"
        m_findStore.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindStore.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findStore.CreateParameter
        par.Name = "Param1"
        par.Type = ADODB.DataTypeEnum.adInteger
        par.Size = 4
        par.Precision = 10
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findStore.Parameters.Append(par)
        rsfindStore.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindStore.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindStore.Source = m_findStore
        m_Commands.Add(m_findStore, "findStore")
        m_Recordsets.Add(rsfindStore, "findStore")
        m_ListCardex = New ADODB.Command()
        rsListCardex = New ADODB.Recordset()
        m_ListCardex.Name = "ListCardex"
        m_ListCardex.CommandText = "select * from cardex "
        m_ListCardex.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsListCardex.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsListCardex.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsListCardex.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsListCardex.Source = m_ListCardex
        m_Commands.Add(m_ListCardex, "ListCardex")
        m_Recordsets.Add(rsListCardex, "ListCardex")
        m_ListMyAnaliz = New ADODB.Command()
        rsListMyAnaliz = New ADODB.Recordset()
        m_ListMyAnaliz.Name = "ListMyAnaliz"
        m_ListMyAnaliz.CommandText = "select * from MyAnaliz"
        m_ListMyAnaliz.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsListMyAnaliz.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsListMyAnaliz.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsListMyAnaliz.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsListMyAnaliz.Source = m_ListMyAnaliz
        m_Commands.Add(m_ListMyAnaliz, "ListMyAnaliz")
        m_Recordsets.Add(rsListMyAnaliz, "ListMyAnaliz")
        m_GetTemp = New ADODB.Command()
        rsGetTemp = New ADODB.Recordset()
        m_GetTemp.Name = "GetTemp"
        m_GetTemp.CommandText = "select * from  sanadtemp  where  Radif=?"
        m_GetTemp.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsGetTemp.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_GetTemp.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_GetTemp.Parameters.Append(par)
        rsGetTemp.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsGetTemp.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsGetTemp.Source = m_GetTemp
        m_Commands.Add(m_GetTemp, "GetTemp")
        m_Recordsets.Add(rsGetTemp, "GetTemp")
        m_GetSold = New ADODB.Command()
        rsGetSold = New ADODB.Recordset()
        m_GetSold.Name = "GetSold"
        m_GetSold.CommandText = "select * from  iokala   where  tip=?  and nf=?"
        m_GetSold.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsGetSold.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_GetSold.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_GetSold.Parameters.Append(par)
        par = m_GetSold.CreateParameter
        par.Name = "_par2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_GetSold.Parameters.Append(par)
        rsGetSold.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsGetSold.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsGetSold.Source = m_GetSold
        m_Commands.Add(m_GetSold, "GetSold")
        m_Recordsets.Add(rsGetSold, "GetSold")
        m_rptkol = New ADODB.Command()
        rsrptkol = New ADODB.Recordset()
        m_rptkol.Name = "rptkol"
        m_rptkol.CommandText = "select  code,name,bedeh,bestan  from kol"
        m_rptkol.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsrptkol.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsrptkol.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsrptkol.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsrptkol.Source = m_rptkol
        m_Commands.Add(m_rptkol, "rptkol")
        m_Recordsets.Add(rsrptkol, "rptkol")
        m_rptsanadriz = New ADODB.Command()
        rsrptsanadriz = New ADODB.Recordset()
        m_rptsanadriz.Name = "rptsanadriz"
        m_rptsanadriz.CommandText = "select ns,sanadriz.code,sanadriz.codk,sanadriz.codm,sanadriz.codj,comment,sanadriz.bedeh,sanadriz.bestan,datee,name from sanadriz inner join kol on sanadriz.code=kol.code"
        m_rptsanadriz.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsrptsanadriz.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsrptsanadriz.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsrptsanadriz.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsrptsanadriz.Source = m_rptsanadriz
        m_Commands.Add(m_rptsanadriz, "rptsanadriz")
        m_Recordsets.Add(rsrptsanadriz, "rptsanadriz")
        m_rptasnad = New ADODB.Command()
        rsrptasnad = New ADODB.Recordset()
        m_rptasnad.Name = "rptasnad"
        m_rptasnad.CommandText = "select ns,datee,SUM(BEDEH) AS BEDEH,sum(bestan) as bestan,comment    from asnad group by ns,datee,comment order by ns"
        m_rptasnad.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsrptasnad.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsrptasnad.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsrptasnad.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsrptasnad.Source = m_rptasnad
        m_Commands.Add(m_rptasnad, "rptasnad")
        m_Recordsets.Add(rsrptasnad, "rptasnad")
        m_rptkoltraz = New ADODB.Command()
        rsrptkoltraz = New ADODB.Recordset()
        m_rptkoltraz.Name = "rptkoltraz"
        m_rptkoltraz.CommandText = "select  sum(sanadriz.bedeh) as bedeh,sum(sanadriz.bestan) as bestan ,kol.code,kol.name   from sanadriz  inner join kol on sanadriz.codk=kol.code group by kol.code,kol.name  "
        m_rptkoltraz.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsrptkoltraz.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsrptkoltraz.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsrptkoltraz.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsrptkoltraz.Source = m_rptkoltraz
        m_Commands.Add(m_rptkoltraz, "rptkoltraz")
        m_Recordsets.Add(rsrptkoltraz, "rptkoltraz")
        m_rptchek = New ADODB.Command()
        rsrptchek = New ADODB.Recordset()
        m_rptchek.Name = "rptchek"
        m_rptchek.CommandText = "select  *    from chek"
        m_rptchek.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsrptchek.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsrptchek.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsrptchek.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsrptchek.Source = m_rptchek
        m_Commands.Add(m_rptchek, "rptchek")
        m_Recordsets.Add(rsrptchek, "rptchek")
        m_rptcardex = New ADODB.Command()
        rsrptcardex = New ADODB.Recordset()
        m_rptcardex.Name = "rptcardex"
        m_rptcardex.CommandText = "select * from cardex"
        m_rptcardex.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsrptcardex.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsrptcardex.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsrptcardex.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsrptcardex.Source = m_rptcardex
        m_Commands.Add(m_rptcardex, "rptcardex")
        m_Recordsets.Add(rsrptcardex, "rptcardex")
        m_rptiokala = New ADODB.Command()
        rsrptiokala = New ADODB.Recordset()
        m_rptiokala.Name = "rptiokala"
        m_rptiokala.CommandText = "select * from iokala"
        m_rptiokala.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsrptiokala.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsrptiokala.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsrptiokala.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsrptiokala.Source = m_rptiokala
        m_Commands.Add(m_rptiokala, "rptiokala")
        m_Recordsets.Add(rsrptiokala, "rptiokala")
        m_rptkala = New ADODB.Command()
        rsrptkala = New ADODB.Recordset()
        m_rptkala.Name = "rptkala"
        m_rptkala.CommandText = "select  * from kala"
        m_rptkala.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsrptkala.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsrptkala.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsrptkala.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsrptkala.Source = m_rptkala
        m_Commands.Add(m_rptkala, "rptkala")
        m_Recordsets.Add(rsrptkala, "rptkala")
        m_GetSanad = New ADODB.Command()
        rsGetSanad = New ADODB.Recordset()
        m_GetSanad.Name = "GetSanad"
        m_GetSanad.CommandText = "select * from  asnad  where  ns=?"
        m_GetSanad.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsGetSanad.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_GetSanad.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_GetSanad.Parameters.Append(par)
        rsGetSanad.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsGetSanad.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsGetSanad.Source = m_GetSanad
        m_Commands.Add(m_GetSanad, "GetSanad")
        m_Recordsets.Add(rsGetSanad, "GetSanad")
        m_ListCardexKala = New ADODB.Command()
        rsListCardexKala = New ADODB.Recordset()
        m_ListCardexKala.Name = "ListCardexKala"
        m_ListCardexKala.CommandText = "select * from cardex  where ck=? order by datee,nom_out"
        m_ListCardexKala.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsListCardexKala.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_ListCardexKala.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ListCardexKala.Parameters.Append(par)
        rsListCardexKala.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsListCardexKala.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsListCardexKala.Source = m_ListCardexKala
        m_Commands.Add(m_ListCardexKala, "ListCardexKala")
        m_Recordsets.Add(rsListCardexKala, "ListCardexKala")
        m_SumCardexKala = New ADODB.Command()
        rsSumCardexKala = New ADODB.Recordset()
        m_SumCardexKala.Name = "SumCardexKala"
        m_SumCardexKala.CommandText = "select sum(nom_out) as nom_out,sum(nom_in)  as nom_in from cardex where ck=?"
        m_SumCardexKala.CommandType = ADODB.CommandTypeEnum.adCmdText
        par = m_SumCardexKala.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_SumCardexKala.Parameters.Append(par)
        rsSumCardexKala.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsSumCardexKala.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsSumCardexKala.LockType = ADODB.LockTypeEnum.adLockReadOnly
        rsSumCardexKala.Source = m_SumCardexKala
        m_Commands.Add(m_SumCardexKala, "SumCardexKala")
        m_Recordsets.Add(rsSumCardexKala, "SumCardexKala")
        m_Ukol = New ADODB.Command()
        rsUkol = New ADODB.Recordset()
        m_Ukol.Name = "Ukol"
        m_Ukol.CommandText = "select * from kol"
        m_Ukol.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsUkol.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsUkol.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsUkol.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsUkol.Source = m_Ukol
        m_Commands.Add(m_Ukol, "Ukol")
        m_Recordsets.Add(rsUkol, "Ukol")
        m_findcheck = New ADODB.Command()
        rsfindcheck = New ADODB.Recordset()
        m_findcheck.Name = "findcheck"
        m_findcheck.CommandText = "select * from bdcheck where id=?"
        m_findcheck.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindcheck.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findcheck.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findcheck.Parameters.Append(par)
        rsfindcheck.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindcheck.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindcheck.Source = m_findcheck
        m_Commands.Add(m_findcheck, "findcheck")
        m_Recordsets.Add(rsfindcheck, "findcheck")
        m_listcheck = New ADODB.Command()
        rslistcheck = New ADODB.Recordset()
        m_listcheck.Name = "listcheck"
        m_listcheck.CommandText = "select * from bdcheck order by datee desc,id desc"
        m_listcheck.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistcheck.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistcheck.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistcheck.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistcheck.Source = m_listcheck
        m_Commands.Add(m_listcheck, "listcheck")
        m_Recordsets.Add(rslistcheck, "listcheck")
        m_findchktnz = New ADODB.Command()
        rsfindchktnz = New ADODB.Recordset()
        m_findchktnz.Name = "findchktnz"
        m_findchktnz.CommandText = "select * from bdchektanzim where id=? "
        m_findchktnz.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindchktnz.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findchktnz.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findchktnz.Parameters.Append(par)
        rsfindchktnz.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindchktnz.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindchktnz.Source = m_findchktnz
        m_Commands.Add(m_findchktnz, "findchktnz")
        m_Recordsets.Add(rsfindchktnz, "findchktnz")
        m_browchektanzim = New ADODB.Command()
        rsbrowchektanzim = New ADODB.Recordset()
        m_browchektanzim.Name = "browchektanzim"
        m_browchektanzim.CommandText = "select * from bdchektanzim "
        m_browchektanzim.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowchektanzim.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsbrowchektanzim.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowchektanzim.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowchektanzim.Source = m_browchektanzim
        m_Commands.Add(m_browchektanzim, "browchektanzim")
        m_Recordsets.Add(rsbrowchektanzim, "browchektanzim")
        m_findhazineh = New ADODB.Command()
        rsfindhazineh = New ADODB.Recordset()
        m_findhazineh.Name = "findhazineh"
        m_findhazineh.CommandText = "select * from  hazineh  where storeCode=?"
        m_findhazineh.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindhazineh.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findhazineh.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findhazineh.Parameters.Append(par)
        rsfindhazineh.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindhazineh.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindhazineh.Source = m_findhazineh
        m_Commands.Add(m_findhazineh, "findhazineh")
        m_Recordsets.Add(rsfindhazineh, "findhazineh")
        m_listhazineh = New ADODB.Command()
        rslisthazineh = New ADODB.Recordset()
        m_listhazineh.Name = "listhazineh"
        m_listhazineh.CommandText = "select * from hazineh"
        m_listhazineh.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslisthazineh.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslisthazineh.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslisthazineh.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslisthazineh.Source = m_listhazineh
        m_Commands.Add(m_listhazineh, "listhazineh")
        m_Recordsets.Add(rslisthazineh, "listhazineh")
        m_findVisitor = New ADODB.Command()
        rsfindVisitor = New ADODB.Recordset()
        m_findVisitor.Name = "findVisitor"
        m_findVisitor.CommandText = "select * from  visitor  where storeCode=?"
        m_findVisitor.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindVisitor.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findVisitor.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findVisitor.Parameters.Append(par)
        rsfindVisitor.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindVisitor.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindVisitor.Source = m_findVisitor
        m_Commands.Add(m_findVisitor, "findVisitor")
        m_Recordsets.Add(rsfindVisitor, "findVisitor")
        m_listVisitor = New ADODB.Command()
        rslistVisitor = New ADODB.Recordset()
        m_listVisitor.Name = "listVisitor"
        m_listVisitor.CommandText = "select * from visitor"
        m_listVisitor.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistVisitor.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistVisitor.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistVisitor.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistVisitor.Source = m_listVisitor
        m_Commands.Add(m_listVisitor, "listVisitor")
        m_Recordsets.Add(rslistVisitor, "listVisitor")
        m_ListTemp1 = New ADODB.Command()
        rsListTemp1 = New ADODB.Recordset()
        m_ListTemp1.Name = "ListTemp1"
        m_ListTemp1.CommandText = "select * from  sanadtemp "
        m_ListTemp1.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsListTemp1.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsListTemp1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsListTemp1.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsListTemp1.Source = m_ListTemp1
        m_Commands.Add(m_ListTemp1, "ListTemp1")
        m_Recordsets.Add(rsListTemp1, "ListTemp1")
        m_tanzimhesabnewyear = New ADODB.Command()
        rstanzimhesabnewyear = New ADODB.Recordset()
        m_tanzimhesabnewyear.Name = "tanzimhesabnewyear"
        m_tanzimhesabnewyear.CommandText = "select * from tanzimhesab"
        m_tanzimhesabnewyear.CommandType = ADODB.CommandTypeEnum.adCmdText
        rstanzimhesabnewyear.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rstanzimhesabnewyear.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rstanzimhesabnewyear.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rstanzimhesabnewyear.Source = m_tanzimhesabnewyear
        m_Commands.Add(m_tanzimhesabnewyear, "tanzimhesabnewyear")
        m_Recordsets.Add(rstanzimhesabnewyear, "tanzimhesabnewyear")
        m_kalaNewYear = New ADODB.Command()
        rskalaNewYear = New ADODB.Recordset()
        m_kalaNewYear.Name = "kalaNewYear"
        m_kalaNewYear.CommandText = "select * from kala"
        m_kalaNewYear.CommandType = ADODB.CommandTypeEnum.adCmdText
        rskalaNewYear.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rskalaNewYear.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rskalaNewYear.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rskalaNewYear.Source = m_kalaNewYear
        m_Commands.Add(m_kalaNewYear, "kalaNewYear")
        m_Recordsets.Add(rskalaNewYear, "kalaNewYear")
        m_CardexNewYear = New ADODB.Command()
        rsCardexNewYear = New ADODB.Recordset()
        m_CardexNewYear.Name = "CardexNewYear"
        m_CardexNewYear.CommandText = "select * from cardex"
        m_CardexNewYear.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsCardexNewYear.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsCardexNewYear.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsCardexNewYear.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsCardexNewYear.Source = m_CardexNewYear
        m_Commands.Add(m_CardexNewYear, "CardexNewYear")
        m_Recordsets.Add(rsCardexNewYear, "CardexNewYear")
        m_coding = New ADODB.Command()
        rscoding = New ADODB.Recordset()
        m_coding.Name = "coding"
        m_coding.CommandText = "select * from coding"
        m_coding.CommandType = ADODB.CommandTypeEnum.adCmdText
        rscoding.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rscoding.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rscoding.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rscoding.Source = m_coding
        m_Commands.Add(m_coding, "coding")
        m_Recordsets.Add(rscoding, "coding")
        m_rptkalaIO = New ADODB.Command()
        rsrptkalaIO = New ADODB.Recordset()
        m_rptkalaIO.Name = "rptkalaIO"
        m_rptkalaIO.CommandText = "select sum(cardex.nom_out) as nom_out,sum(cardex.nom_in) as nom_in,cardex.ck,kala.namk  from cardex inner join kala on cardex.ck=kala.ck group by cardex.ck,kala.namk"
        m_rptkalaIO.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsrptkalaIO.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsrptkalaIO.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsrptkalaIO.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsrptkalaIO.Source = m_rptkalaIO
        m_Commands.Add(m_rptkalaIO, "rptkalaIO")
        m_Recordsets.Add(rsrptkalaIO, "rptkalaIO")
        m_SumRow = New ADODB.Command()
        rsSumRow = New ADODB.Recordset()
        m_SumRow.Name = "SumRow"
        m_SumRow.CommandText = "select * from sanadriz "
        m_SumRow.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsSumRow.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsSumRow.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsSumRow.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsSumRow.Source = m_SumRow
        m_Commands.Add(m_SumRow, "SumRow")
        m_Recordsets.Add(rsSumRow, "SumRow")
        m_ListCardexByCode = New ADODB.Command()
        rsListCardexByCode = New ADODB.Recordset()
        m_ListCardexByCode.Name = "ListCardexByCode"
        m_ListCardexByCode.CommandText = "select * from cardex  where code=? order by datee desc"
        m_ListCardexByCode.CommandType = ADODB.CommandTypeEnum.adCmdText
        par = m_ListCardexByCode.CreateParameter
        par.Name = "_par1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ListCardexByCode.Parameters.Append(par)
        rsListCardexByCode.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsListCardexByCode.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsListCardexByCode.LockType = ADODB.LockTypeEnum.adLockReadOnly
        rsListCardexByCode.Source = m_ListCardexByCode
        m_Commands.Add(m_ListCardexByCode, "ListCardexByCode")
        m_Recordsets.Add(rsListCardexByCode, "ListCardexByCode")
        m_BrowKolTemp = New ADODB.Command()
        rsBrowKolTemp = New ADODB.Recordset()
        m_BrowKolTemp.Name = "BrowKolTemp"
        m_BrowKolTemp.CommandText = "select  code,name,bedeh,bestan,tremain from kolTemp"
        m_BrowKolTemp.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsBrowKolTemp.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsBrowKolTemp.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsBrowKolTemp.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsBrowKolTemp.Source = m_BrowKolTemp
        m_Commands.Add(m_BrowKolTemp, "BrowKolTemp")
        m_Recordsets.Add(rsBrowKolTemp, "BrowKolTemp")
    End Sub
    Public Sub findcode(ByVal _code As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsfindcode.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindcode.Close()
        End If
        m_findcode.ActiveConnection = con_data
        m_findcode.Parameters.Item("_code").Value = _code
        rsfindcode.Open()
    End Sub
    Public Sub listcode(ByVal sqlstr As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rslistcode.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistcode.Close()
        End If
        m_listcode.ActiveConnection = con_data
        m_listcode.CommandText = SqlStr
        rslistcode.Open()
    End Sub
    Public Sub findkala(ByVal _par1 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsfindkala.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindkala.Close()
        End If
        m_findkala.ActiveConnection = con_data
        m_findkala.Parameters.Item("_par1").Value = _par1
        rsfindkala.Open()
    End Sub
    Public Sub listkala(ByVal strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rslistkala.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistkala.Close()
        End If
        m_listkala.ActiveConnection = con_data
        m_listkala.CommandText = strsql
        rslistkala.Open()
    End Sub
    Public Sub brow_cardex(ByVal _par1 As String, ByVal _par2 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsbrow_cardex.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrow_cardex.Close()
        End If
        m_brow_cardex.ActiveConnection = con_data
        m_brow_cardex.Parameters.Item("_par1").Value = _par1
        m_brow_cardex.Parameters.Item("_par2").Value = _par2
        rsbrow_cardex.Open()
    End Sub
    Public Sub tanzimhesab()
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rstanzimhesab.State = ADODB.ObjectStateEnum.adStateOpen Then
            rstanzimhesab.Close()
        End If
        m_tanzimhesab.ActiveConnection = con_data
        rstanzimhesab.Open()
    End Sub
    Public Sub brow_temp(ByVal _par1 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsbrow_temp.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrow_temp.Close()
        End If
        m_brow_temp.ActiveConnection = con_data
        m_brow_temp.Parameters.Item("_par1").Value = _par1
        rsbrow_temp.Open()
    End Sub
    Public Sub brow_tempriz(ByVal _par1 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsbrow_tempriz.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrow_tempriz.Close()
        End If
        m_brow_tempriz.ActiveConnection = con_data
        m_brow_tempriz.Parameters.Item("_par1").Value = _par1
        rsbrow_tempriz.Open()
    End Sub
    Public Sub listtemp(ByVal strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rslisttemp.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslisttemp.Close()
        End If
        m_listtemp.ActiveConnection = con_data
        m_listtemp.CommandText = strsql
        rslisttemp.Open()
    End Sub
    Public Sub brow_sanadcode(ByVal strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsbrow_sanadcode.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrow_sanadcode.Close()
        End If
        m_brow_sanadcode.ActiveConnection = con_data
        m_brow_sanadcode.CommandText = strsql
        rsbrow_sanadcode.Open()
    End Sub
    Public Sub showoldrem(ByVal Strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsshowoldrem.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsshowoldrem.Close()
        End If
        m_showoldrem.ActiveConnection = con_data
        m_showoldrem.CommandText = Strsql
        rsshowoldrem.Open()
    End Sub
    Public Sub sanad(ByVal strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rssanad.State = ADODB.ObjectStateEnum.adStateOpen Then
            rssanad.Close()
        End If
        m_sanad.ActiveConnection = con_data
        m_sanad.CommandText = strsql
        rssanad.Open()
    End Sub
    Public Sub brow_sanadriz(ByVal _par1 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsbrow_sanadriz.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrow_sanadriz.Close()
        End If
        m_brow_sanadriz.ActiveConnection = con_data
        m_brow_sanadriz.Parameters.Item("_par1").Value = _par1
        rsbrow_sanadriz.Open()
    End Sub
    Public Sub findsanad(ByVal _ns As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsfindsanad.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindsanad.Close()
        End If
        m_findsanad.ActiveConnection = con_data
        m_findsanad.Parameters.Item("_ns").Value = _ns
        rsfindsanad.Open()
    End Sub
    Public Sub bdhospname(ByVal _par1 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsbdhospname.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbdhospname.Close()
        End If
        m_bdhospname.ActiveConnection = con_data
        m_bdhospname.Parameters.Item("_par1").Value = _par1
        rsbdhospname.Open()
    End Sub
    Public Sub findchek(ByVal _par1 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsfindchek.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindchek.Close()
        End If
        m_findchek.ActiveConnection = con_data
        m_findchek.Parameters.Item("_par1").Value = _par1
        rsfindchek.Open()
    End Sub
    Public Sub showoldcardex(ByVal _ck As String, ByVal _date As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsshowoldcardex.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsshowoldcardex.Close()
        End If
        m_showoldcardex.ActiveConnection = con_data
        m_showoldcardex.Parameters.Item("_ck").Value = _ck
        m_showoldcardex.Parameters.Item("_date").Value = _date
        rsshowoldcardex.Open()
    End Sub
    Public Sub browall(ByVal Strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsbrowall.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowall.Close()
        End If
        m_browall.ActiveConnection = con_data
        m_browall.CommandText = Strsql
        rsbrowall.Open()
    End Sub
    Public Sub iokala()
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsiokala.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsiokala.Close()
        End If
        m_iokala.ActiveConnection = con_data
        rsiokala.Open()
    End Sub
    Public Sub findiokala(ByVal _par1 As String, ByVal _par2 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsfindiokala.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindiokala.Close()
        End If
        m_findiokala.ActiveConnection = con_data
        m_findiokala.Parameters.Item("_par1").Value = _par1
        m_findiokala.Parameters.Item("_par2").Value = _par2
        rsfindiokala.Open()
    End Sub
    Public Sub browasnad(ByVal strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsbrowasnad.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowasnad.Close()
        End If
        m_browasnad.ActiveConnection = con_data
        m_browasnad.CommandText = strsql
        rsbrowasnad.Open()
    End Sub
    Public Sub browfkey()
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsbrowfkey.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowfkey.Close()
        End If
        m_browfkey.ActiveConnection = con_data
        rsbrowfkey.Open()
    End Sub
    Public Sub showkala(ByVal Sql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsshowkala.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsshowkala.Close()
        End If
        m_showkala.ActiveConnection = con_data
        m_showkala.CommandText = Sql
        rsshowkala.Open()
    End Sub
    Public Sub browkol(ByVal strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsbrowkol.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowkol.Close()
        End If
        m_browkol.ActiveConnection = con_data
        m_browkol.CommandText = strsql
        rsbrowkol.Open()
    End Sub
    Public Sub listchek(ByVal strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rslistchek.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistchek.Close()
        End If
        m_listchek.ActiveConnection = con_data
        m_listcheck.CommandText = strsql
        rslistchek.Open()
    End Sub
    Public Sub findtemp(ByVal _par1 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsfindtemp.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindtemp.Close()
        End If
        m_findtemp.ActiveConnection = con_data
        m_findtemp.Parameters.Item("_par1").Value = _par1
        rsfindtemp.Open()
    End Sub
    Public Sub brow_amani(ByVal _par1 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsbrow_amani.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrow_amani.Close()
        End If
        m_brow_amani.ActiveConnection = con_data
        m_brow_amani.Parameters.Item("_par1").Value = _par1
        rsbrow_amani.Open()
    End Sub
    

    Public Sub brow_ioamani(ByVal _par1 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsbrow_ioamani.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrow_ioamani.Close()
        End If
        m_brow_ioamani.ActiveConnection = con_data
        m_brow_ioamani.Parameters.Item("_par1").Value = _par1
        rsbrow_ioamani.Open()
    End Sub
    Public Sub listasnad(ByVal SqlStr As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rslistasnad.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistasnad.Close()
        End If
        m_listasnad.ActiveConnection = con_data
        m_listasnad.CommandText = SqlStr
        rslistasnad.Open()
    End Sub
    Public Sub kolnewyear()
        If con_newyear.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_newyear.Open()
        End If
        If rskolnewyear.State = ADODB.ObjectStateEnum.adStateOpen Then
            rskolnewyear.Close()
        End If
        m_kolnewyear.ActiveConnection = con_newyear
        rskolnewyear.Open()
    End Sub
    Public Sub sanadriznewyear(ByVal strsql As String)
        If con_newyear.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_newyear.Open()
        End If
        If rssanadriznewyear.State = ADODB.ObjectStateEnum.adStateOpen Then
            rssanadriznewyear.Close()
        End If
        m_sanadriznewyear.ActiveConnection = con_newyear
        m_sanadriznewyear.CommandText = strsql
        rssanadriznewyear.Open()
    End Sub
    Public Sub sanadnewyear(ByVal strsql As String)
        If con_newyear.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_newyear.Open()
        End If
        If rssanadnewyear.State = ADODB.ObjectStateEnum.adStateOpen Then
            rssanadnewyear.Close()
        End If
        m_sanadnewyear.ActiveConnection = con_newyear
        m_sanadnewyear.CommandText = strsql
        rssanadnewyear.Open()
    End Sub
    Public Sub findmain()
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsfindmain.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindmain.Close()
        End If
        m_findmain.ActiveConnection = con_data
        rsfindmain.Open()
    End Sub
    Public Sub listkar(ByVal Strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rslistkar.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistkar.Close()
        End If
        m_listkar.ActiveConnection = con_data
        m_listkar.CommandText = Strsql
        rslistkar.Open()
    End Sub
    Public Sub findkar(ByVal Param1 As Integer)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsfindkar.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindkar.Close()
        End If
        m_findkar.ActiveConnection = con_data
        m_findkar.Parameters.Item("Param1").Value = Param1
        rsfindkar.Open()
    End Sub
    Public Sub findpass(ByVal Param1 As String, ByVal Param2 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsfindpass.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindpass.Close()
        End If
        m_findpass.ActiveConnection = con_data
        m_findpass.Parameters.Item("Param1").Value = Param1
        m_findpass.Parameters.Item("Param2").Value = Param2
        rsfindpass.Open()
    End Sub
    Public Sub findnamkar(ByVal Param1 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsfindnamkar.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindnamkar.Close()
        End If
        m_findnamkar.ActiveConnection = con_data
        m_findnamkar.Parameters.Item("Param1").Value = Param1
        rsfindnamkar.Open()
    End Sub
    Public Sub bdprint()
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsbdprint.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbdprint.Close()
        End If
        m_bdprint.ActiveConnection = con_data
        rsbdprint.Open()
    End Sub
    Public Sub bdprintkar(ByVal Param1 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsbdprintkar.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbdprintkar.Close()
        End If
        m_bdprintkar.ActiveConnection = con_data
        m_bdprintkar.Parameters.Item("Param1").Value = Param1
        rsbdprintkar.Open()
    End Sub
    Public Sub browpid(ByVal Strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsbrowpid.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowpid.Close()
        End If
        m_browpid.ActiveConnection = con_data
        m_browpid.CommandText = Strsql
        rsbrowpid.Open()
    End Sub
    Public Sub listsal()
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rslistsal.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistsal.Close()
        End If
        m_listsal.ActiveConnection = con_data
        rslistsal.Open()
    End Sub
    Public Sub findsal(ByVal Param1 As Integer)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsfindsal.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindsal.Close()
        End If
        m_findsal.ActiveConnection = con_data
        m_findsal.Parameters.Item("Param1").Value = Param1
        rsfindsal.Open()
    End Sub
    Public Sub listprogid(ByVal Strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rslistprogid.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistprogid.Close()
        End If
        m_listprogid.ActiveConnection = con_data
        m_listprogid.CommandText = Strsql
        rslistprogid.Open()
    End Sub
    Public Sub findserial()
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsfindserial.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindserial.Close()
        End If
        m_findserial.ActiveConnection = con_data
        rsfindserial.Open()
    End Sub
    Public Sub listStore(ByVal strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rslistStore.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistStore.Close()
        End If
        m_listStore.ActiveConnection = con_data
        m_listStore.CommandText = strsql
        rslistStore.Open()
    End Sub
    Public Sub findStore(ByVal Param1 As Integer)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsfindStore.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindStore.Close()
        End If
        m_findStore.ActiveConnection = con_data
        m_findStore.Parameters.Item("Param1").Value = Param1
        rsfindStore.Open()
    End Sub
    Public Sub ListCardex(ByVal strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsListCardex.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsListCardex.Close()
        End If
        m_ListCardex.ActiveConnection = con_data
        m_ListCardex.CommandText = strsql
        rsListCardex.Open()
    End Sub
    Public Sub ListMyAnaliz(ByVal Strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsListMyAnaliz.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsListMyAnaliz.Close()
        End If
        m_ListMyAnaliz.ActiveConnection = con_data
        m_ListMyAnaliz.CommandText = Strsql
        rsListMyAnaliz.Open()
    End Sub
    Public Sub GetTemp(ByVal _par1 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsGetTemp.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsGetTemp.Close()
        End If
        m_GetTemp.ActiveConnection = con_data
        m_GetTemp.Parameters.Item("_par1").Value = _par1
        rsGetTemp.Open()
    End Sub
    Public Sub GetSold(ByVal _par1 As String, ByVal _par2 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsGetSold.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsGetSold.Close()
        End If
        m_GetSold.ActiveConnection = con_data
        m_GetSold.Parameters.Item("_par1").Value = _par1
        m_GetSold.Parameters.Item("_par2").Value = _par2
        rsGetSold.Open()
    End Sub
    Public Sub rptkol(ByVal strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsrptkol.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsrptkol.Close()
        End If
        m_rptkol.ActiveConnection = con_data
        m_rptkol.CommandText = strsql
        rsrptkol.Open()
    End Sub
    Public Sub rptsanadriz(ByVal strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsrptsanadriz.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsrptsanadriz.Close()
        End If
        m_rptsanadriz.ActiveConnection = con_data
        m_rptsanadriz.CommandText = strsql
        rsrptsanadriz.Open()
    End Sub
    Public Sub rptasnad(ByVal Strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsrptasnad.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsrptasnad.Close()
        End If
        m_rptasnad.ActiveConnection = con_data
        m_rptasnad.CommandText = Strsql
        rsrptasnad.Open()
    End Sub
    Public Sub rptkoltraz()
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsrptkoltraz.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsrptkoltraz.Close()
        End If
        m_rptkoltraz.ActiveConnection = con_data
        rsrptkoltraz.Open()
    End Sub
    Public Sub rptchek(ByVal Strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsrptchek.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsrptchek.Close()
        End If
        m_rptchek.ActiveConnection = con_data
        m_rptchek.CommandText = Strsql
        rsrptchek.Open()
    End Sub
    Public Sub rptcardex(ByVal Strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsrptcardex.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsrptcardex.Close()
        End If
        m_rptcardex.ActiveConnection = con_data
        m_rptcardex.CommandText = Strsql
        rsrptcardex.Open()
    End Sub
    Public Sub rptiokala(ByVal Strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsrptiokala.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsrptiokala.Close()
        End If
        m_rptiokala.ActiveConnection = con_data
        m_rptiokala.CommandText = Strsql
        rsrptiokala.Open()
    End Sub
    Public Sub rptkala(ByVal Strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsrptkala.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsrptkala.Close()
        End If
        m_rptkala.ActiveConnection = con_data
        m_rptkala.CommandText = Strsql
        rsrptkala.Open()
    End Sub
    Public Sub GetSanad(ByVal _par1 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsGetSanad.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsGetSanad.Close()
        End If
        m_GetSanad.ActiveConnection = con_data
        m_GetSanad.Parameters.Item("_par1").Value = _par1
        rsGetSanad.Open()
    End Sub
    Public Sub ListCardexKala(ByVal _par1 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsListCardexKala.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsListCardexKala.Close()
        End If
        m_ListCardexKala.ActiveConnection = con_data
        m_ListCardexKala.Parameters.Item("_par1").Value = _par1
        rsListCardexKala.Open()
    End Sub
    Public Sub SumCardexKala(ByVal _par1 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsSumCardexKala.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsSumCardexKala.Close()
        End If
        m_SumCardexKala.ActiveConnection = con_data
        m_SumCardexKala.Parameters.Item("_par1").Value = _par1
        rsSumCardexKala.Open()
    End Sub
    Public Sub Ukol()
        If ConUpdate.State = ADODB.ObjectStateEnum.adStateClosed Then
            ConUpdate.Open()
        End If
        If rsUkol.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsUkol.Close()
        End If
        m_Ukol.ActiveConnection = ConUpdate
        rsUkol.Open()
    End Sub
    Public Sub findcheck(ByVal _par1 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsfindcheck.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindcheck.Close()
        End If
        m_findcheck.ActiveConnection = con_data
        m_findcheck.Parameters.Item("_par1").Value = _par1
        rsfindcheck.Open()
    End Sub
    Public Sub listcheck(ByVal strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rslistcheck.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistcheck.Close()
        End If
        m_listcheck.ActiveConnection = con_data
        m_listcheck.CommandText = strsql
        rslistcheck.Open()
    End Sub
    Public Sub findchktnz(ByVal _par1 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsfindchktnz.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindchktnz.Close()
        End If
        m_findchktnz.ActiveConnection = con_data
        m_findchktnz.Parameters.Item("_par1").Value = _par1
        rsfindchktnz.Open()
    End Sub
    Public Sub browchektanzim()
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsbrowchektanzim.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowchektanzim.Close()
        End If
        m_browchektanzim.ActiveConnection = con_data
        rsbrowchektanzim.Open()
    End Sub
    Public Sub findhazineh(ByVal _par1 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsfindhazineh.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindhazineh.Close()
        End If
        m_findhazineh.ActiveConnection = con_data
        m_findhazineh.Parameters.Item("_par1").Value = _par1
        rsfindhazineh.Open()
    End Sub
    Public Sub listhazineh(ByVal strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rslisthazineh.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslisthazineh.Close()
        End If
        m_listhazineh.ActiveConnection = con_data
        m_listhazineh.CommandText = strsql
        rslisthazineh.Open()
    End Sub
    Public Sub findVisitor(ByVal _par1 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsfindVisitor.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindVisitor.Close()
        End If
        m_findVisitor.ActiveConnection = con_data
        m_findVisitor.Parameters.Item("_par1").Value = _par1
        rsfindVisitor.Open()
    End Sub
    Public Sub listVisitor(ByVal strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rslistVisitor.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistVisitor.Close()
        End If
        m_listVisitor.ActiveConnection = con_data
        m_listVisitor.CommandText = strsql
        rslistVisitor.Open()
    End Sub
    Public Sub ListTemp1(ByVal strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsListTemp1.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsListTemp1.Close()
        End If
        m_ListTemp1.ActiveConnection = con_data
        m_ListTemp1.CommandText = strsql
        rsListTemp1.Open()
    End Sub
    Public Sub tanzimhesabnewyear()
        If con_newyear.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_newyear.Open()
        End If
        If rstanzimhesabnewyear.State = ADODB.ObjectStateEnum.adStateOpen Then
            rstanzimhesabnewyear.Close()
        End If
        m_tanzimhesabnewyear.ActiveConnection = con_newyear
        rstanzimhesabnewyear.Open()
    End Sub
    Public Sub kalaNewYear()
        If con_newyear.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_newyear.Open()
        End If
        If rskalaNewYear.State = ADODB.ObjectStateEnum.adStateOpen Then
            rskalaNewYear.Close()
        End If
        m_kalaNewYear.ActiveConnection = con_newyear
        rskalaNewYear.Open()
    End Sub
    Public Sub CardexNewYear(ByVal Strsql As String)
        If con_newyear.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_newyear.Open()
        End If
        If rsCardexNewYear.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsCardexNewYear.Close()
        End If
        m_CardexNewYear.ActiveConnection = con_newyear
        m_CardexNewYear.CommandText = Strsql
        rsCardexNewYear.Open()
    End Sub
    Public Sub coding()
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rscoding.State = ADODB.ObjectStateEnum.adStateOpen Then
            rscoding.Close()
        End If
        m_coding.ActiveConnection = con_data
        rscoding.Open()
    End Sub
    Public Sub rptkalaIO(ByVal Strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsrptkalaIO.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsrptkalaIO.Close()
        End If
        m_rptkalaIO.ActiveConnection = con_data
        m_rptkalaIO.CommandText = Strsql
        rsrptkalaIO.Open()
    End Sub
    Public Sub SumRow(ByVal strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsSumRow.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsSumRow.Close()
        End If
        m_SumRow.ActiveConnection = con_data
        m_SumRow.CommandText = strsql
        rsSumRow.Open()
    End Sub
    Public Sub ListCardexByCode(ByVal _par1 As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsListCardexByCode.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsListCardexByCode.Close()
        End If
        m_ListCardexByCode.ActiveConnection = con_data
        m_ListCardexByCode.Parameters.Item("_par1").Value = _par1
        rsListCardexByCode.Open()
    End Sub
    Public Sub BrowKolTemp(ByVal strsql As String)
        If con_data.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_data.Open()
        End If
        If rsBrowKolTemp.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsBrowKolTemp.Close()
        End If
        m_BrowKolTemp.ActiveConnection = con_data
        m_BrowKolTemp.CommandText = strsql
        rsBrowKolTemp.Open()
    End Sub
End Class
