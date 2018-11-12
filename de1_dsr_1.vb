Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility

Module DataEnvironment_de1_Module
	Friend de1 As DataEnvironment_de1 = New DataEnvironment_de1()
End Module

Public Class DataEnvironment_de1
    Inherits VB6.BaseDataEnvironment
    Public WithEvents con_main As ADODB.Connection
    Public WithEvents con_eoffice As ADODB.Connection
    Public WithEvents conupdate As ADODB.Connection
    Public WithEvents Connection1 As ADODB.Connection
    Public WithEvents ConOracle As ADODB.Connection
    Public WithEvents rsfindbimar As ADODB.Recordset
    Private m_findbimar As ADODB.Command
    Public WithEvents rsbimarname As ADODB.Recordset
    Private m_bimarname As ADODB.Command
    Public WithEvents rsfinddocamal As ADODB.Recordset
    Private m_finddocamal As ADODB.Command
    Public WithEvents rsfinddocdetail As ADODB.Recordset
    Private m_finddocdetail As ADODB.Command
    Public WithEvents rslistdocamal As ADODB.Recordset
    Private m_listdocamal As ADODB.Command
    Public WithEvents rsfindcath As ADODB.Recordset
    Private m_findcath As ADODB.Command
    Public WithEvents rslist_nostype As ADODB.Recordset
    Private m_list_nostype As ADODB.Command
    Public WithEvents rsfind_nostype As ADODB.Recordset
    Private m_find_nostype As ADODB.Command
    Public WithEvents rsbrow_docdetail As ADODB.Recordset
    Private m_brow_docdetail As ADODB.Command
    Public WithEvents rslistostan As ADODB.Recordset
    Private m_listostan As ADODB.Command
    Public WithEvents rslistcath As ADODB.Recordset
    Private m_listcath As ADODB.Command
    Public WithEvents rsbrow_phadetail As ADODB.Recordset
    Private m_brow_phadetail As ADODB.Command
    Public WithEvents rsfindradifpha As ADODB.Recordset
    Private m_findradifpha As ADODB.Command
    Public WithEvents rsfindbdhosp As ADODB.Recordset
    Private m_findbdhosp As ADODB.Command
    Public WithEvents rsfindnamkar As ADODB.Recordset
    Private m_findnamkar As ADODB.Command
    Public WithEvents rsfindpass As ADODB.Recordset
    Private m_findpass As ADODB.Command
    Public WithEvents rsfindmain As ADODB.Recordset
    Private m_findmain As ADODB.Command
    Public WithEvents rsshow_phadetail As ADODB.Recordset
    Private m_show_phadetail As ADODB.Command
    Public WithEvents rsfindorgan As ADODB.Recordset
    Private m_findorgan As ADODB.Command
    Public WithEvents rsbdhospname As ADODB.Recordset
    Private m_bdhospname As ADODB.Command
    Public WithEvents rsbrowall As ADODB.Recordset
    Private m_browall As ADODB.Command
    Public WithEvents rsbrow_dnos As ADODB.Recordset
    Private m_brow_dnos As ADODB.Command
    Public WithEvents rsdarocode As ADODB.Recordset
    Private m_darocode As ADODB.Command
    Public WithEvents rslistdaro As ADODB.Recordset
    Private m_listdaro As ADODB.Command
    Public WithEvents rsbdkhas As ADODB.Recordset
    Private m_bdkhas As ADODB.Command
    Public WithEvents rslistkar As ADODB.Recordset
    Private m_listkar As ADODB.Command
    Public WithEvents rsfindkar As ADODB.Recordset
    Private m_findkar As ADODB.Command
    Public WithEvents rslistorgan As ADODB.Recordset
    Private m_listorgan As ADODB.Command
    Public WithEvents rsbdprintkar As ADODB.Recordset
    Private m_bdprintkar As ADODB.Command
    Public WithEvents rsbdprint As ADODB.Recordset
    Private m_bdprint As ADODB.Command
    Public WithEvents rsfindbdtakh As ADODB.Recordset
    Private m_findbdtakh As ADODB.Command
    Public WithEvents rslistbdtakh As ADODB.Recordset
    Private m_listbdtakh As ADODB.Command
    Public WithEvents rslistcomp As ADODB.Recordset
    Private m_listcomp As ADODB.Command
    Public WithEvents rsfindcomp As ADODB.Recordset
    Private m_findcomp As ADODB.Command
    Public WithEvents rsbrowdsus As ADODB.Recordset
    Private m_browdsus As ADODB.Command
    Public WithEvents rsfindsus As ADODB.Recordset
    Private m_findsus As ADODB.Command
    Public WithEvents rstanzim As ADODB.Recordset
    Private m_tanzim As ADODB.Command
    Public WithEvents rsfindsanad As ADODB.Recordset
    Private m_findsanad As ADODB.Command
    Public WithEvents rsbrow_sanadriz As ADODB.Recordset
    Private m_brow_sanadriz As ADODB.Command
    Public WithEvents rsfindcode As ADODB.Recordset
    Private m_findcode As ADODB.Command
    Public WithEvents rslistcode As ADODB.Recordset
    Private m_listcode As ADODB.Command
    Public WithEvents rssanad As ADODB.Recordset
    Private m_sanad As ADODB.Command
    Public WithEvents rsshowoldrem As ADODB.Recordset
    Private m_showoldrem As ADODB.Command
    Public WithEvents rsbrow_cardex As ADODB.Recordset
    Private m_brow_cardex As ADODB.Command
    Public WithEvents rsbrow_tempriz As ADODB.Recordset
    Private m_brow_tempriz As ADODB.Command
    Public WithEvents rsbrow_temp As ADODB.Recordset
    Private m_brow_temp As ADODB.Command
    Public WithEvents rsfindkala As ADODB.Recordset
    Private m_findkala As ADODB.Command
    Public WithEvents rsshow_phadetail1 As ADODB.Recordset
    Private m_show_phadetail1 As ADODB.Command
    Public WithEvents rsbrowbank As ADODB.Recordset
    Private m_browbank As ADODB.Command
    Public WithEvents rsfindbank As ADODB.Recordset
    Private m_findbank As ADODB.Command
    Public WithEvents rsshownumber As ADODB.Recordset
    Private m_shownumber As ADODB.Command
    Public WithEvents rsbrow_phanumber As ADODB.Recordset
    Private m_brow_phanumber As ADODB.Command
    Public WithEvents rsCo1 As ADODB.Recordset
    Private m_Co1 As ADODB.Command
    Public WithEvents rslisttemp As ADODB.Recordset
    Private m_listtemp As ADODB.Command
    Public WithEvents rslistpay As ADODB.Recordset
    Private m_listpay As ADODB.Command
    Public WithEvents rslistdarof As ADODB.Recordset
    Private m_listdarof As ADODB.Command
    Public WithEvents rsdarocode5 As ADODB.Recordset
    Private m_darocode5 As ADODB.Command
    Public WithEvents rslistara As ADODB.Recordset
    Private m_listara As ADODB.Command
    Public WithEvents rslistcardex As ADODB.Recordset
    Private m_listcardex As ADODB.Command
    Public WithEvents rsshowdaro As ADODB.Recordset
    Private m_showdaro As ADODB.Command
    Public WithEvents rsshowdarof As ADODB.Recordset
    Private m_showdarof As ADODB.Command
    Public WithEvents rsbrownprint As ADODB.Recordset
    Private m_brownprint As ADODB.Command
    Public WithEvents rsfindvcode As ADODB.Recordset
    Private m_findvcode As ADODB.Command
    Public WithEvents rsfindpharma As ADODB.Recordset
    Private m_findpharma As ADODB.Command
    Public WithEvents rspharmaname As ADODB.Recordset
    Private m_pharmaname As ADODB.Command
    Public WithEvents rsbrow_ham As ADODB.Recordset
    Private m_brow_ham As ADODB.Command
    Public WithEvents rsbrow_same As ADODB.Recordset
    Private m_brow_same As ADODB.Command
    Public WithEvents rseslami As ADODB.Recordset
    Private m_eslami As ADODB.Command
    Public WithEvents rsfindnos As ADODB.Recordset
    Private m_findnos As ADODB.Command
    Public WithEvents rsfindbim As ADODB.Recordset
    Private m_findbim As ADODB.Command
    Public WithEvents rsfindbimname As ADODB.Recordset
    Private m_findbimname As ADODB.Command
    Public WithEvents rsbrowcond As ADODB.Recordset
    Private m_browcond As ADODB.Command
    Public WithEvents rsbrowspmot As ADODB.Recordset
    Private m_browspmot As ADODB.Command
    Public WithEvents rsfindcond As ADODB.Recordset
    Private m_findcond As ADODB.Command
    Public WithEvents rsfindspmot As ADODB.Recordset
    Private m_findspmot As ADODB.Command
    Public WithEvents rsdarovir As ADODB.Recordset
    Private m_darovir As ADODB.Command
    Public WithEvents rsbrowvir As ADODB.Recordset
    Private m_browvir As ADODB.Command
    Public WithEvents rsbrowallnos As ADODB.Recordset
    Private m_browallnos As ADODB.Command
    Public WithEvents rsfindnprint As ADODB.Recordset
    Private m_findnprint As ADODB.Command
    Public WithEvents rsbrowhj As ADODB.Recordset
    Private m_browhj As ADODB.Command
    Public WithEvents rsfindcode6 As ADODB.Recordset
    Private m_findcode6 As ADODB.Command
    Public WithEvents rsbrowallnos1 As ADODB.Recordset
    Private m_browallnos1 As ADODB.Command
    Public WithEvents rsbrowfkey As ADODB.Recordset
    Private m_browfkey As ADODB.Command
    Public WithEvents rsaccname As ADODB.Recordset
    Private m_accname As ADODB.Command
    Public WithEvents rslistdarocond As ADODB.Recordset
    Private m_listdarocond As ADODB.Command
    Public WithEvents rsfindcode5 As ADODB.Recordset
    Private m_findcode5 As ADODB.Command
    Public WithEvents rsfindiokala As ADODB.Recordset
    Private m_findiokala As ADODB.Command
    Public WithEvents rsbrowdaro As ADODB.Recordset
    Private m_browdaro As ADODB.Command
    Public WithEvents rsshowdaro6 As ADODB.Recordset
    Private m_showdaro6 As ADODB.Command
    Public WithEvents rsfcode6 As ADODB.Recordset
    Private m_fcode6 As ADODB.Command
    Public WithEvents rsfc6 As ADODB.Recordset
    Private m_fc6 As ADODB.Command
    Public WithEvents rsder As ADODB.Recordset
    Private m_der As ADODB.Command
    Public WithEvents rsupddaro As ADODB.Recordset
    Private m_upddaro As ADODB.Command
    Public WithEvents rsupdnos As ADODB.Recordset
    Private m_updnos As ADODB.Command
    Public WithEvents rsupdcond As ADODB.Recordset
    Private m_updcond As ADODB.Command
    Public WithEvents rstanzimhesab As ADODB.Recordset
    Private m_tanzimhesab As ADODB.Command
    Public WithEvents rsbrowasnad As ADODB.Recordset
    Private m_browasnad As ADODB.Command
    Public WithEvents rstamin As ADODB.Recordset
    Private m_tamin As ADODB.Command
    Public WithEvents rsbrowotc As ADODB.Recordset
    Private m_browotc As ADODB.Command
    Public WithEvents rslistpaz As ADODB.Recordset
    Private m_listpaz As ADODB.Command
    Public WithEvents rsListNos As ADODB.Recordset
    Private m_ListNos As ADODB.Command
    Public WithEvents rsListRoutine As ADODB.Recordset
    Private m_ListRoutine As ADODB.Command
    Public WithEvents rsBrowRoutine As ADODB.Recordset
    Private m_BrowRoutine As ADODB.Command
    Public WithEvents rsShowRoutine As ADODB.Recordset
    Private m_ShowRoutine As ADODB.Command
    Public WithEvents rsShowPrintDastur As ADODB.Recordset
    Private m_ShowPrintDastur As ADODB.Command
    Public WithEvents rsRptDaro As ADODB.Recordset
    Private m_RptDaro As ADODB.Command
    Public WithEvents rsmynetwork As ADODB.Recordset
    Private m_mynetwork As ADODB.Command
    Public WithEvents rsDelMyNetwork As ADODB.Recordset
    Private m_DelMyNetwork As ADODB.Command
    Public WithEvents rsUpdCath As ADODB.Recordset
    Private m_UpdCath As ADODB.Command
    Public WithEvents rsListNprint As ADODB.Recordset
    Private m_ListNprint As ADODB.Command
    Public WithEvents rsListMoney As ADODB.Recordset
    Private m_ListMoney As ADODB.Command
    Public WithEvents rsFindMoney As ADODB.Recordset
    Private m_FindMoney As ADODB.Command
    Public WithEvents rsFindvcode1 As ADODB.Recordset
    Private m_Findvcode1 As ADODB.Command
    Public WithEvents rsListVcode As ADODB.Recordset
    Private m_ListVcode As ADODB.Command
    Public WithEvents rsListMyCath As ADODB.Recordset
    Private m_ListMyCath As ADODB.Command
    Public WithEvents rsh11cop As ADODB.Recordset
    Private m_h11cop As ADODB.Command
    Public WithEvents rsfactor As ADODB.Recordset
    Private m_factor As ADODB.Command
    Public WithEvents rsMyphaDetail As ADODB.Recordset
    Private m_MyphaDetail As ADODB.Command
    Public WithEvents rsMyPhaDnos As ADODB.Recordset
    Private m_MyPhaDnos As ADODB.Command
    Public WithEvents rslistdaroCond1 As ADODB.Recordset
    Private m_listdaroCond1 As ADODB.Command
    Public WithEvents rsbrow_MyCardex As ADODB.Recordset
    Private m_brow_MyCardex As ADODB.Command
    Public WithEvents rsmydoc As ADODB.Recordset
    Private m_mydoc As ADODB.Command
    Public WithEvents rslistcardex9 As ADODB.Recordset
    Private m_listcardex9 As ADODB.Command
    Public WithEvents rsInsMyCardex As ADODB.Recordset
    Private m_InsMyCardex As ADODB.Command
    Public WithEvents rsRtdaro As ADODB.Recordset
    Private m_Rtdaro As ADODB.Command
    Public WithEvents rsbrowTdaro As ADODB.Recordset
    Private m_browTdaro As ADODB.Command
    Public WithEvents rsbrowall1 As ADODB.Recordset
    Private m_browall1 As ADODB.Command
    Public WithEvents rsfindbarcode As ADODB.Recordset
    Private m_findbarcode As ADODB.Command
    Public WithEvents rsfindUser As ADODB.Recordset
    Private m_findUser As ADODB.Command
    Public WithEvents rsUpdateNezam As ADODB.Recordset
    Private m_UpdateNezam As ADODB.Command
    Public WithEvents rsshowRadif As ADODB.Recordset
    Private m_showRadif As ADODB.Command
    Public WithEvents rsShowNumberCath As ADODB.Recordset
    Private m_ShowNumberCath As ADODB.Command
    Public WithEvents rsListNumbercath As ADODB.Recordset
    Private m_ListNumbercath As ADODB.Command
    Public WithEvents rsBarCodeBrow As ADODB.Recordset
    Private m_BarCodeBrow As ADODB.Command
    Public WithEvents rsBarCodeFind As ADODB.Recordset
    Private m_BarCodeFind As ADODB.Command
    Public WithEvents rsBarCodeDel As ADODB.Recordset
    Private m_BarCodeDel As ADODB.Command
    Public WithEvents rsBrowmasraf As ADODB.Recordset
    Private m_Browmasraf As ADODB.Command
    Public WithEvents rsFindSMOT As ADODB.Recordset
    Private m_FindSMOT As ADODB.Command
    Public WithEvents rsbrowtakh As ADODB.Recordset
    Private m_browtakh As ADODB.Command
    Public WithEvents rsDaroSpCath As ADODB.Recordset
    Private m_DaroSpCath As ADODB.Command
    Public WithEvents rsSumCardexdaro As ADODB.Recordset
    Private m_SumCardexdaro As ADODB.Command
    Public WithEvents rslistType1 As ADODB.Recordset
    Private m_listType1 As ADODB.Command
    Public WithEvents rsFindType As ADODB.Recordset
    Private m_FindType As ADODB.Command
    Public WithEvents rslistTash As ADODB.Recordset
    Private m_listTash As ADODB.Command
    Public WithEvents rsfindTash As ADODB.Recordset
    Private m_findTash As ADODB.Command
    Public WithEvents rslistkala As ADODB.Recordset
    Private m_listkala As ADODB.Command
    Public WithEvents rsdelCardex As ADODB.Recordset
    Private m_delCardex As ADODB.Command
    Public WithEvents rsSumCardex As ADODB.Recordset
    Private m_SumCardex As ADODB.Command
    Public WithEvents rsBrowFam As ADODB.Recordset
    Private m_BrowFam As ADODB.Command
    Public WithEvents rsListCompany As ADODB.Recordset
    Private m_ListCompany As ADODB.Command
    Public WithEvents rsFindCompany As ADODB.Recordset
    Private m_FindCompany As ADODB.Command
    Public WithEvents rsBrowSpFani As ADODB.Recordset
    Private m_BrowSpFani As ADODB.Command
    Public WithEvents rsFindSpFani As ADODB.Recordset
    Private m_FindSpFani As ADODB.Command
    
    
    Public Sub New()
        MyBase.New()
        Dim par As ADODB.Parameter


        con_main = New ADODB.Connection()
        con_main.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=o:\database\docnet\data1391.mdb;Persist Security Info=False;"
        m_Connections.Add(con_main, "con_main")
        conupdate = New ADODB.Connection()
        conupdate.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=o:\database\docnet\update.mdb;Persist Security Info=False;"
        m_Connections.Add(conupdate, "conupdate")
        Connection1 = New ADODB.Connection()
        Connection1.ConnectionString = "Provider=SQLOLEDB.1;Password=7673;Persist Security Info=True;User ID=sa;Initial Catalog=asnadmain;Data Source=192.168.90.2;"
        m_Connections.Add(Connection1, "Connection1")
        ConOracle = New ADODB.Connection()
        ConOracle.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=Bimeh;Data Source=192.168.90.2;"
        m_Connections.Add(ConOracle, "ConOracle")
        m_findbimar = New ADODB.Command()
        rsfindbimar = New ADODB.Recordset()
        m_findbimar.Name = "findbimar"
        m_findbimar.CommandText = "select * from bimar where parvandeh=?"
        m_findbimar.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindbimar.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findbimar.CreateParameter
        par.Name = "parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findbimar.Parameters.Append(par)
        rsfindbimar.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindbimar.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindbimar.Source = m_findbimar
        m_Commands.Add(m_findbimar, "findbimar")
        m_Recordsets.Add(rsfindbimar, "findbimar")
        m_bimarname = New ADODB.Command()
        rsbimarname = New ADODB.Recordset()
        m_bimarname.Name = "bimarname"
        m_bimarname.CommandText = "select * from  bimar  where  bimar.famil  like ?"
        m_bimarname.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbimarname.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_bimarname.CreateParameter
        par.Name = "_famil"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_bimarname.Parameters.Append(par)
        rsbimarname.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbimarname.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbimarname.Source = m_bimarname
        m_Commands.Add(m_bimarname, "bimarname")
        m_Recordsets.Add(rsbimarname, "bimarname")
        m_finddocamal = New ADODB.Command()
        rsfinddocamal = New ADODB.Recordset()
        m_finddocamal.Name = "finddocamal"
        m_finddocamal.CommandText = "select * from doc_amalcode where cokm=?"
        m_finddocamal.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfinddocamal.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_finddocamal.CreateParameter
        par.Name = "parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_finddocamal.Parameters.Append(par)
        rsfinddocamal.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfinddocamal.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfinddocamal.Source = m_finddocamal
        m_Commands.Add(m_finddocamal, "finddocamal")
        m_Recordsets.Add(rsfinddocamal, "finddocamal")
        m_finddocdetail = New ADODB.Command()
        rsfinddocdetail = New ADODB.Recordset()
        m_finddocdetail.Name = "finddocdetail"
        m_finddocdetail.CommandText = "select * from  doc_detail where code=? and monthh=? and radif=?  and cokm=?"
        m_finddocdetail.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfinddocdetail.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_finddocdetail.CreateParameter
        par.Name = "_var"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_finddocdetail.Parameters.Append(par)
        par = m_finddocdetail.CreateParameter
        par.Name = "_var2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_finddocdetail.Parameters.Append(par)
        par = m_finddocdetail.CreateParameter
        par.Name = "_var3"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_finddocdetail.Parameters.Append(par)
        par = m_finddocdetail.CreateParameter
        par.Name = "_var4"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_finddocdetail.Parameters.Append(par)
        rsfinddocdetail.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfinddocdetail.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfinddocdetail.Source = m_finddocdetail
        m_Commands.Add(m_finddocdetail, "finddocdetail")
        m_Recordsets.Add(rsfinddocdetail, "finddocdetail")
        m_listdocamal = New ADODB.Command()
        rslistdocamal = New ADODB.Recordset()
        m_listdocamal.Name = "listdocamal"
        m_listdocamal.CommandText = "select * from doc_amalcode order by cokm"
        m_listdocamal.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistdocamal.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistdocamal.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistdocamal.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistdocamal.Source = m_listdocamal
        m_Commands.Add(m_listdocamal, "listdocamal")
        m_Recordsets.Add(rslistdocamal, "listdocamal")
        m_findcath = New ADODB.Command()
        rsfindcath = New ADODB.Recordset()
        m_findcath.Name = "findcath"
        m_findcath.CommandText = "select * from bdcath where cath=?"
        m_findcath.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindcath.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findcath.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findcath.Parameters.Append(par)
        rsfindcath.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindcath.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindcath.Source = m_findcath
        m_Commands.Add(m_findcath, "findcath")
        m_Recordsets.Add(rsfindcath, "findcath")
        m_list_nostype = New ADODB.Command()
        rslist_nostype = New ADODB.Recordset()
        m_list_nostype.Name = "list_nostype"
        m_list_nostype.CommandText = "select * from doc_nostype"
        m_list_nostype.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslist_nostype.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslist_nostype.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslist_nostype.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslist_nostype.Source = m_list_nostype
        m_Commands.Add(m_list_nostype, "list_nostype")
        m_Recordsets.Add(rslist_nostype, "list_nostype")
        m_find_nostype = New ADODB.Command()
        rsfind_nostype = New ADODB.Recordset()
        m_find_nostype.Name = "find_nostype"
        m_find_nostype.CommandText = "select * from doc_nostype where nos_type=?"
        m_find_nostype.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfind_nostype.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_find_nostype.CreateParameter
        par.Name = "_nostype"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_find_nostype.Parameters.Append(par)
        rsfind_nostype.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfind_nostype.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfind_nostype.Source = m_find_nostype
        m_Commands.Add(m_find_nostype, "find_nostype")
        m_Recordsets.Add(rsfind_nostype, "find_nostype")
        m_brow_docdetail = New ADODB.Command()
        rsbrow_docdetail = New ADODB.Recordset()
        m_brow_docdetail.Name = "brow_docdetail"
        m_brow_docdetail.CommandText = "select * from  doc_detail where code=? and monthh=? and radif=?"
        m_brow_docdetail.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrow_docdetail.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_brow_docdetail.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_docdetail.Parameters.Append(par)
        par = m_brow_docdetail.CreateParameter
        par.Name = "_parm2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_docdetail.Parameters.Append(par)
        par = m_brow_docdetail.CreateParameter
        par.Name = "_parm3"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_docdetail.Parameters.Append(par)
        rsbrow_docdetail.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrow_docdetail.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrow_docdetail.Source = m_brow_docdetail
        m_Commands.Add(m_brow_docdetail, "brow_docdetail")
        m_Recordsets.Add(rsbrow_docdetail, "brow_docdetail")
        m_listostan = New ADODB.Command()
        rslistostan = New ADODB.Recordset()
        m_listostan.Name = "listostan"
        m_listostan.CommandText = "select  * from ostan"
        m_listostan.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistostan.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistostan.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistostan.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistostan.Source = m_listostan
        m_Commands.Add(m_listostan, "listostan")
        m_Recordsets.Add(rslistostan, "listostan")
        m_listcath = New ADODB.Command()
        rslistcath = New ADODB.Recordset()
        m_listcath.Name = "listcath"
        m_listcath.CommandText = "select * from bdcath  order by cath"
        m_listcath.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistcath.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistcath.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistcath.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistcath.Source = m_listcath
        m_Commands.Add(m_listcath, "listcath")
        m_Recordsets.Add(rslistcath, "listcath")
        m_brow_phadetail = New ADODB.Command()
        rsbrow_phadetail = New ADODB.Recordset()
        m_brow_phadetail.Name = "brow_phadetail"
        m_brow_phadetail.CommandText = "select * from  pha_detail where  monthh=? and cath=? and   radif=?"
        m_brow_phadetail.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrow_phadetail.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_brow_phadetail.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_phadetail.Parameters.Append(par)
        par = m_brow_phadetail.CreateParameter
        par.Name = "_parm2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_phadetail.Parameters.Append(par)
        par = m_brow_phadetail.CreateParameter
        par.Name = "_parm3"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_phadetail.Parameters.Append(par)
        rsbrow_phadetail.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrow_phadetail.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrow_phadetail.Source = m_brow_phadetail
        m_Commands.Add(m_brow_phadetail, "brow_phadetail")
        m_Recordsets.Add(rsbrow_phadetail, "brow_phadetail")
        m_findradifpha = New ADODB.Command()
        rsfindradifpha = New ADODB.Recordset()
        m_findradifpha.Name = "findradifpha"
        m_findradifpha.CommandText = "select * from pha_detail where  monthh=? and cath=?    order by  radif "
        m_findradifpha.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindradifpha.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findradifpha.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findradifpha.Parameters.Append(par)
        par = m_findradifpha.CreateParameter
        par.Name = "_parm2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findradifpha.Parameters.Append(par)
        rsfindradifpha.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindradifpha.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindradifpha.Source = m_findradifpha
        m_Commands.Add(m_findradifpha, "findradifpha")
        m_Recordsets.Add(rsfindradifpha, "findradifpha")
        m_findbdhosp = New ADODB.Command()
        rsfindbdhosp = New ADODB.Recordset()
        m_findbdhosp.Name = "findbdhosp"
        m_findbdhosp.CommandText = "select * from bdhosp where code=? "
        m_findbdhosp.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindbdhosp.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findbdhosp.CreateParameter
        par.Name = "_code"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findbdhosp.Parameters.Append(par)
        rsfindbdhosp.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindbdhosp.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindbdhosp.Source = m_findbdhosp
        m_Commands.Add(m_findbdhosp, "findbdhosp")
        m_Recordsets.Add(rsfindbdhosp, "findbdhosp")
        m_findnamkar = New ADODB.Command()
        rsfindnamkar = New ADODB.Recordset()
        m_findnamkar.Name = "findnamkar"
        m_findnamkar.CommandText = "select * from karbar where naka=? "
        m_findnamkar.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindnamkar.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findnamkar.CreateParameter
        par.Name = "_naka"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findnamkar.Parameters.Append(par)
        rsfindnamkar.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindnamkar.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindnamkar.Source = m_findnamkar
        m_Commands.Add(m_findnamkar, "findnamkar")
        m_Recordsets.Add(rsfindnamkar, "findnamkar")
        m_findpass = New ADODB.Command()
        rsfindpass = New ADODB.Recordset()
        m_findpass.Name = "findpass"
        m_findpass.CommandText = "select * from karbar where naka=? and pass=?"
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
        m_show_phadetail = New ADODB.Command()
        rsshow_phadetail = New ADODB.Recordset()
        m_show_phadetail.Name = "show_phadetail"
        m_show_phadetail.CommandText = "select * from  pha_detail where  monthh=? and cath=?   order by radif"
        m_show_phadetail.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsshow_phadetail.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_show_phadetail.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_show_phadetail.Parameters.Append(par)
        par = m_show_phadetail.CreateParameter
        par.Name = "_parm2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_show_phadetail.Parameters.Append(par)
        rsshow_phadetail.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsshow_phadetail.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsshow_phadetail.Source = m_show_phadetail
        m_Commands.Add(m_show_phadetail, "show_phadetail")
        m_Recordsets.Add(rsshow_phadetail, "show_phadetail")
        m_findorgan = New ADODB.Command()
        rsfindorgan = New ADODB.Recordset()
        m_findorgan.Name = "findorgan"
        m_findorgan.CommandText = "select * from bdorgan where organ_code=?"
        m_findorgan.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindorgan.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findorgan.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findorgan.Parameters.Append(par)
        rsfindorgan.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindorgan.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindorgan.Source = m_findorgan
        m_Commands.Add(m_findorgan, "findorgan")
        m_Recordsets.Add(rsfindorgan, "findorgan")
        m_bdhospname = New ADODB.Command()
        rsbdhospname = New ADODB.Recordset()
        m_bdhospname.Name = "bdhospname"
        m_bdhospname.CommandText = "select * from  bdhosp "
        m_bdhospname.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbdhospname.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbdhospname.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbdhospname.LockType = ADODB.LockTypeEnum.adLockReadOnly
        rsbdhospname.Source = m_bdhospname
        m_Commands.Add(m_bdhospname, "bdhospname")
        m_Recordsets.Add(rsbdhospname, "bdhospname")
        m_browall = New ADODB.Command()
        rsbrowall = New ADODB.Recordset()
        m_browall.Name = "browall"
        m_browall.CommandText = "select  * from pha_detail"
        m_browall.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowall.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsbrowall.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowall.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowall.Source = m_browall
        m_Commands.Add(m_browall, "browall")
        m_Recordsets.Add(rsbrowall, "browall")
        m_brow_dnos = New ADODB.Command()
        rsbrow_dnos = New ADODB.Recordset()
        m_brow_dnos.Name = "brow_dnos"
        m_brow_dnos.CommandText = "select * from  pha_dnos where  monthh=? and   number=?  order by radif"
        m_brow_dnos.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrow_dnos.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_brow_dnos.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_dnos.Parameters.Append(par)
        par = m_brow_dnos.CreateParameter
        par.Name = "_parm2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_dnos.Parameters.Append(par)
        rsbrow_dnos.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrow_dnos.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrow_dnos.Source = m_brow_dnos
        m_Commands.Add(m_brow_dnos, "brow_dnos")
        m_Recordsets.Add(rsbrow_dnos, "brow_dnos")
        m_darocode = New ADODB.Command()
        rsdarocode = New ADODB.Recordset()
        m_darocode.Name = "darocode"
        m_darocode.CommandText = "select * from daro_code where daro_code=?"
        m_darocode.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsdarocode.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_darocode.CreateParameter
        par.Name = "_darocode"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_darocode.Parameters.Append(par)
        rsdarocode.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsdarocode.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsdarocode.Source = m_darocode
        m_Commands.Add(m_darocode, "darocode")
        m_Recordsets.Add(rsdarocode, "darocode")
        m_listdaro = New ADODB.Command()
        rslistdaro = New ADODB.Recordset()
        m_listdaro.Name = "listdaro"
        m_listdaro.CommandText = "select *    from daro_code  "
        m_listdaro.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistdaro.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistdaro.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistdaro.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistdaro.Source = m_listdaro
        m_Commands.Add(m_listdaro, "listdaro")
        m_Recordsets.Add(rslistdaro, "listdaro")
        m_bdkhas = New ADODB.Command()
        rsbdkhas = New ADODB.Recordset()
        m_bdkhas.Name = "bdkhas"
        m_bdkhas.CommandText = "select * from bdkhas where khas=?"
        m_bdkhas.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbdkhas.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_bdkhas.CreateParameter
        par.Name = "_khas"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_bdkhas.Parameters.Append(par)
        rsbdkhas.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbdkhas.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbdkhas.Source = m_bdkhas
        m_Commands.Add(m_bdkhas, "bdkhas")
        m_Recordsets.Add(rsbdkhas, "bdkhas")
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
        par.Name = "_coka"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findkar.Parameters.Append(par)
        rsfindkar.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindkar.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindkar.Source = m_findkar
        m_Commands.Add(m_findkar, "findkar")
        m_Recordsets.Add(rsfindkar, "findkar")
        m_listorgan = New ADODB.Command()
        rslistorgan = New ADODB.Recordset()
        m_listorgan.Name = "listorgan"
        m_listorgan.CommandText = "select * from bdorgan"
        m_listorgan.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistorgan.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistorgan.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistorgan.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistorgan.Source = m_listorgan
        m_Commands.Add(m_listorgan, "listorgan")
        m_Recordsets.Add(rslistorgan, "listorgan")
        m_bdprintkar = New ADODB.Command()
        rsbdprintkar = New ADODB.Recordset()
        m_bdprintkar.Name = "bdprintkar"
        m_bdprintkar.CommandText = "select * from bdprint where karbar=?"
        m_bdprintkar.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbdprintkar.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_bdprintkar.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_bdprintkar.Parameters.Append(par)
        rsbdprintkar.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbdprintkar.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbdprintkar.Source = m_bdprintkar
        m_Commands.Add(m_bdprintkar, "bdprintkar")
        m_Recordsets.Add(rsbdprintkar, "bdprintkar")
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
        m_findbdtakh = New ADODB.Command()
        rsfindbdtakh = New ADODB.Recordset()
        m_findbdtakh.Name = "findbdtakh"
        m_findbdtakh.CommandText = "select * from bdtakh where tkhs_code=?"
        m_findbdtakh.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindbdtakh.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findbdtakh.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findbdtakh.Parameters.Append(par)
        rsfindbdtakh.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindbdtakh.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindbdtakh.Source = m_findbdtakh
        m_Commands.Add(m_findbdtakh, "findbdtakh")
        m_Recordsets.Add(rsfindbdtakh, "findbdtakh")
        m_listbdtakh = New ADODB.Command()
        rslistbdtakh = New ADODB.Recordset()
        m_listbdtakh.Name = "listbdtakh"
        m_listbdtakh.CommandText = "select * from bdtakh  order by tkhs_name"
        m_listbdtakh.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistbdtakh.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistbdtakh.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistbdtakh.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistbdtakh.Source = m_listbdtakh
        m_Commands.Add(m_listbdtakh, "listbdtakh")
        m_Recordsets.Add(rslistbdtakh, "listbdtakh")
        m_listcomp = New ADODB.Command()
        rslistcomp = New ADODB.Recordset()
        m_listcomp.Name = "listcomp"
        m_listcomp.CommandText = "select * from company"
        m_listcomp.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistcomp.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistcomp.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistcomp.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistcomp.Source = m_listcomp
        m_Commands.Add(m_listcomp, "listcomp")
        m_Recordsets.Add(rslistcomp, "listcomp")
        m_findcomp = New ADODB.Command()
        rsfindcomp = New ADODB.Recordset()
        m_findcomp.Name = "findcomp"
        m_findcomp.CommandText = "select * from company  where compcode=?"
        m_findcomp.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindcomp.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findcomp.CreateParameter
        par.Name = "_compcode"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findcomp.Parameters.Append(par)
        rsfindcomp.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindcomp.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindcomp.Source = m_findcomp
        m_Commands.Add(m_findcomp, "findcomp")
        m_Recordsets.Add(rsfindcomp, "findcomp")
        m_browdsus = New ADODB.Command()
        rsbrowdsus = New ADODB.Recordset()
        m_browdsus.Name = "browdsus"
        m_browdsus.CommandText = "select * from daro_suspect  where   daro_code=?"
        m_browdsus.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowdsus.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_browdsus.CreateParameter
        par.Name = "_daro_code"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_browdsus.Parameters.Append(par)
        rsbrowdsus.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowdsus.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowdsus.Source = m_browdsus
        m_Commands.Add(m_browdsus, "browdsus")
        m_Recordsets.Add(rsbrowdsus, "browdsus")
        m_findsus = New ADODB.Command()
        rsfindsus = New ADODB.Recordset()
        m_findsus.Name = "findsus"
        m_findsus.CommandText = "select  * from daro_suspect  where   cath=? and daro_code =? "
        m_findsus.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindsus.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findsus.CreateParameter
        par.Name = "_cath"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findsus.Parameters.Append(par)
        par = m_findsus.CreateParameter
        par.Name = "_daro"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findsus.Parameters.Append(par)
        rsfindsus.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindsus.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindsus.Source = m_findsus
        m_Commands.Add(m_findsus, "findsus")
        m_Recordsets.Add(rsfindsus, "findsus")
        m_tanzim = New ADODB.Command()
        rstanzim = New ADODB.Recordset()
        m_tanzim.Name = "tanzim"
        m_tanzim.CommandText = "select * from tanzim"
        m_tanzim.CommandType = ADODB.CommandTypeEnum.adCmdText
        rstanzim.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rstanzim.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rstanzim.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rstanzim.Source = m_tanzim
        m_Commands.Add(m_tanzim, "tanzim")
        m_Recordsets.Add(rstanzim, "tanzim")
        m_findsanad = New ADODB.Command()
        rsfindsanad = New ADODB.Recordset()
        m_findsanad.Name = "findsanad"
        m_findsanad.CommandText = "select  * from asnad where ns=?"
        m_findsanad.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindsanad.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findsanad.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findsanad.Parameters.Append(par)
        rsfindsanad.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindsanad.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindsanad.Source = m_findsanad
        m_Commands.Add(m_findsanad, "findsanad")
        m_Recordsets.Add(rsfindsanad, "findsanad")
        m_brow_sanadriz = New ADODB.Command()
        rsbrow_sanadriz = New ADODB.Recordset()
        m_brow_sanadriz.Name = "brow_sanadriz"
        m_brow_sanadriz.CommandText = "select * from sanadriz where ns=?"
        m_brow_sanadriz.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrow_sanadriz.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_brow_sanadriz.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_sanadriz.Parameters.Append(par)
        rsbrow_sanadriz.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrow_sanadriz.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrow_sanadriz.Source = m_brow_sanadriz
        m_Commands.Add(m_brow_sanadriz, "brow_sanadriz")
        m_Recordsets.Add(rsbrow_sanadriz, "brow_sanadriz")
        m_findcode = New ADODB.Command()
        rsfindcode = New ADODB.Recordset()
        m_findcode.Name = "findcode"
        m_findcode.CommandText = "select * from  kol where code =?"
        m_findcode.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindcode.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findcode.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
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
        m_showoldrem = New ADODB.Command()
        rsshowoldrem = New ADODB.Recordset()
        m_showoldrem.Name = "showoldrem"
        m_showoldrem.CommandText = "SELECT SUM(bedeh) AS totbed, SUM(bestan) AS totbes FROM sanadriz WHERE code=? AND datee<?"
        m_showoldrem.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsshowoldrem.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_showoldrem.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_showoldrem.Parameters.Append(par)
        par = m_showoldrem.CreateParameter
        par.Name = "_parm2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_showoldrem.Parameters.Append(par)
        rsshowoldrem.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsshowoldrem.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsshowoldrem.Source = m_showoldrem
        m_Commands.Add(m_showoldrem, "showoldrem")
        m_Recordsets.Add(rsshowoldrem, "showoldrem")
        m_brow_cardex = New ADODB.Command()
        rsbrow_cardex = New ADODB.Recordset()
        m_brow_cardex.Name = "brow_cardex"
        m_brow_cardex.CommandText = "select * from pha_dnos  where nf=? and oper=?"
        m_brow_cardex.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrow_cardex.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_brow_cardex.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_cardex.Parameters.Append(par)
        par = m_brow_cardex.CreateParameter
        par.Name = "_parm2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_cardex.Parameters.Append(par)
        rsbrow_cardex.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrow_cardex.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrow_cardex.Source = m_brow_cardex
        m_Commands.Add(m_brow_cardex, "brow_cardex")
        m_Recordsets.Add(rsbrow_cardex, "brow_cardex")
        m_brow_tempriz = New ADODB.Command()
        rsbrow_tempriz = New ADODB.Recordset()
        m_brow_tempriz.Name = "brow_tempriz"
        m_brow_tempriz.CommandText = "select * from  sanadtempriz where radif=?"
        m_brow_tempriz.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrow_tempriz.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_brow_tempriz.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_tempriz.Parameters.Append(par)
        rsbrow_tempriz.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrow_tempriz.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrow_tempriz.Source = m_brow_tempriz
        m_Commands.Add(m_brow_tempriz, "brow_tempriz")
        m_Recordsets.Add(rsbrow_tempriz, "brow_tempriz")
        m_brow_temp = New ADODB.Command()
        rsbrow_temp = New ADODB.Recordset()
        m_brow_temp.Name = "brow_temp"
        m_brow_temp.CommandText = "select * from sanadtemp where radif=?"
        m_brow_temp.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrow_temp.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_brow_temp.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_temp.Parameters.Append(par)
        rsbrow_temp.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrow_temp.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrow_temp.Source = m_brow_temp
        m_Commands.Add(m_brow_temp, "brow_temp")
        m_Recordsets.Add(rsbrow_temp, "brow_temp")
        m_findkala = New ADODB.Command()
        rsfindkala = New ADODB.Recordset()
        m_findkala.Name = "findkala"
        m_findkala.CommandText = "select * from  daro_code where daro_code=?"
        m_findkala.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindkala.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findkala.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findkala.Parameters.Append(par)
        rsfindkala.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindkala.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindkala.Source = m_findkala
        m_Commands.Add(m_findkala, "findkala")
        m_Recordsets.Add(rsfindkala, "findkala")
        m_show_phadetail1 = New ADODB.Command()
        rsshow_phadetail1 = New ADODB.Recordset()
        m_show_phadetail1.Name = "show_phadetail1"
        m_show_phadetail1.CommandText = "select * from  pha_detail where  monthh=? and cath=?    order by datee"
        m_show_phadetail1.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsshow_phadetail1.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_show_phadetail1.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_show_phadetail1.Parameters.Append(par)
        par = m_show_phadetail1.CreateParameter
        par.Name = "_parm2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_show_phadetail1.Parameters.Append(par)
        rsshow_phadetail1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsshow_phadetail1.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsshow_phadetail1.Source = m_show_phadetail1
        m_Commands.Add(m_show_phadetail1, "show_phadetail1")
        m_Recordsets.Add(rsshow_phadetail1, "show_phadetail1")
        m_browbank = New ADODB.Command()
        rsbrowbank = New ADODB.Recordset()
        m_browbank.Name = "browbank"
        m_browbank.CommandText = "select * from bank "
        m_browbank.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowbank.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsbrowbank.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowbank.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowbank.Source = m_browbank
        m_Commands.Add(m_browbank, "browbank")
        m_Recordsets.Add(rsbrowbank, "browbank")
        m_findbank = New ADODB.Command()
        rsfindbank = New ADODB.Recordset()
        m_findbank.Name = "findbank"
        m_findbank.CommandText = "select * from bank where  organ_code=?"
        m_findbank.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindbank.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findbank.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findbank.Parameters.Append(par)
        rsfindbank.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindbank.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindbank.Source = m_findbank
        m_Commands.Add(m_findbank, "findbank")
        m_Recordsets.Add(rsfindbank, "findbank")
        m_shownumber = New ADODB.Command()
        rsshownumber = New ADODB.Recordset()
        m_shownumber.Name = "shownumber"
        m_shownumber.CommandText = "select number from pha_detail where pha_detail.monthh=? order by number"
        m_shownumber.CommandType = ADODB.CommandTypeEnum.adCmdText
        par = m_shownumber.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_shownumber.Parameters.Append(par)
        rsshownumber.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsshownumber.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsshownumber.LockType = ADODB.LockTypeEnum.adLockReadOnly
        rsshownumber.Source = m_shownumber
        m_Commands.Add(m_shownumber, "shownumber")
        m_Recordsets.Add(rsshownumber, "shownumber")
        m_brow_phanumber = New ADODB.Command()
        rsbrow_phanumber = New ADODB.Recordset()
        m_brow_phanumber.Name = "brow_phanumber"
        m_brow_phanumber.CommandText = "select * from  pha_detail where  monthh=? and    number=?"
        m_brow_phanumber.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrow_phanumber.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_brow_phanumber.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_phanumber.Parameters.Append(par)
        par = m_brow_phanumber.CreateParameter
        par.Name = "_parm2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_phanumber.Parameters.Append(par)
        rsbrow_phanumber.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrow_phanumber.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrow_phanumber.Source = m_brow_phanumber
        m_Commands.Add(m_brow_phanumber, "brow_phanumber")
        m_Recordsets.Add(rsbrow_phanumber, "brow_phanumber")
        m_Co1 = New ADODB.Command()
        rsCo1 = New ADODB.Recordset()
        m_Co1.Name = "Co1"
        m_Co1.CommandText = "select * from daro_code6"
        m_Co1.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsCo1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsCo1.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsCo1.LockType = ADODB.LockTypeEnum.adLockReadOnly
        rsCo1.Source = m_Co1
        m_Commands.Add(m_Co1, "Co1")
        m_Recordsets.Add(rsCo1, "Co1")
        m_listtemp = New ADODB.Command()
        rslisttemp = New ADODB.Recordset()
        m_listtemp.Name = "listtemp"
        m_listtemp.CommandText = "select * from drugsmaster"
        m_listtemp.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslisttemp.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslisttemp.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslisttemp.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslisttemp.Source = m_listtemp
        m_Commands.Add(m_listtemp, "listtemp")
        m_Recordsets.Add(rslisttemp, "listtemp")
        m_listpay = New ADODB.Command()
        rslistpay = New ADODB.Recordset()
        m_listpay.Name = "listpay"
        m_listpay.CommandText = "select * from daro_pay "
        m_listpay.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistpay.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistpay.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistpay.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistpay.Source = m_listpay
        m_Commands.Add(m_listpay, "listpay")
        m_Recordsets.Add(rslistpay, "listpay")
        m_listdarof = New ADODB.Command()
        rslistdarof = New ADODB.Recordset()
        m_listdarof.Name = "listdarof"
        m_listdarof.CommandText = "select *    from daro_code   order by daro_fname"
        m_listdarof.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistdarof.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistdarof.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistdarof.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistdarof.Source = m_listdarof
        m_Commands.Add(m_listdarof, "listdarof")
        m_Recordsets.Add(rslistdarof, "listdarof")
        m_darocode5 = New ADODB.Command()
        rsdarocode5 = New ADODB.Recordset()
        m_darocode5.Name = "darocode5"
        m_darocode5.CommandText = "select * from daro_code where intercode=?"
        m_darocode5.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsdarocode5.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_darocode5.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_darocode5.Parameters.Append(par)
        rsdarocode5.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsdarocode5.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsdarocode5.Source = m_darocode5
        m_Commands.Add(m_darocode5, "darocode5")
        m_Recordsets.Add(rsdarocode5, "darocode5")
        m_listara = New ADODB.Command()
        rslistara = New ADODB.Recordset()
        m_listara.Name = "listara"
        m_listara.CommandText = "select *    from daro_code   where tipsold=2 order by daro_fname"
        m_listara.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistara.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistara.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistara.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistara.Source = m_listara
        m_Commands.Add(m_listara, "listara")
        m_Recordsets.Add(rslistara, "listara")
        m_listcardex = New ADODB.Command()
        rslistcardex = New ADODB.Recordset()
        m_listcardex.Name = "listcardex"
        m_listcardex.CommandText = "select *  from pha_dnos"
        m_listcardex.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistcardex.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistcardex.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistcardex.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistcardex.Source = m_listcardex
        m_Commands.Add(m_listcardex, "listcardex")
        m_Recordsets.Add(rslistcardex, "listcardex")
        m_showdaro = New ADODB.Command()
        rsshowdaro = New ADODB.Recordset()
        m_showdaro.Name = "showdaro"
        m_showdaro.CommandText = "select * from daro_code "
        m_showdaro.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsshowdaro.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsshowdaro.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsshowdaro.LockType = ADODB.LockTypeEnum.adLockReadOnly
        rsshowdaro.Source = m_showdaro
        m_Commands.Add(m_showdaro, "showdaro")
        m_Recordsets.Add(rsshowdaro, "showdaro")
        m_showdarof = New ADODB.Command()
        rsshowdarof = New ADODB.Recordset()
        m_showdarof.Name = "showdarof"
        m_showdarof.CommandText = "select * from daro_code"
        m_showdarof.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsshowdarof.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsshowdarof.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsshowdarof.LockType = ADODB.LockTypeEnum.adLockReadOnly
        rsshowdarof.Source = m_showdarof
        m_Commands.Add(m_showdarof, "showdarof")
        m_Recordsets.Add(rsshowdarof, "showdarof")
        m_brownprint = New ADODB.Command()
        rsbrownprint = New ADODB.Recordset()
        m_brownprint.Name = "brownprint"
        m_brownprint.CommandText = "select * from nprinter "
        m_brownprint.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrownprint.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsbrownprint.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrownprint.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrownprint.Source = m_brownprint
        m_Commands.Add(m_brownprint, "brownprint")
        m_Recordsets.Add(rsbrownprint, "brownprint")
        m_findvcode = New ADODB.Command()
        rsfindvcode = New ADODB.Recordset()
        m_findvcode.Name = "findvcode"
        m_findvcode.CommandText = "select * from  vcode where  vcode=?  and tip=?"
        m_findvcode.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindvcode.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findvcode.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findvcode.Parameters.Append(par)
        par = m_findvcode.CreateParameter
        par.Name = "_parm2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findvcode.Parameters.Append(par)
        rsfindvcode.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindvcode.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindvcode.Source = m_findvcode
        m_Commands.Add(m_findvcode, "findvcode")
        m_Recordsets.Add(rsfindvcode, "findvcode")
        m_findpharma = New ADODB.Command()
        rsfindpharma = New ADODB.Recordset()
        m_findpharma.Name = "findpharma"
        m_findpharma.CommandText = "select * from pharma where id=?"
        m_findpharma.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindpharma.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findpharma.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findpharma.Parameters.Append(par)
        rsfindpharma.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindpharma.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindpharma.Source = m_findpharma
        m_Commands.Add(m_findpharma, "findpharma")
        m_Recordsets.Add(rsfindpharma, "findpharma")
        m_pharmaname = New ADODB.Command()
        rspharmaname = New ADODB.Recordset()
        m_pharmaname.Name = "pharmaname"
        m_pharmaname.CommandText = "select * from  pharma  where  name  like ?"
        m_pharmaname.CommandType = ADODB.CommandTypeEnum.adCmdText
        par = m_pharmaname.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_pharmaname.Parameters.Append(par)
        rspharmaname.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rspharmaname.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rspharmaname.LockType = ADODB.LockTypeEnum.adLockReadOnly
        rspharmaname.Source = m_pharmaname
        m_Commands.Add(m_pharmaname, "pharmaname")
        m_Recordsets.Add(rspharmaname, "pharmaname")
        m_brow_ham = New ADODB.Command()
        rsbrow_ham = New ADODB.Recordset()
        m_brow_ham.Name = "brow_ham"
        m_brow_ham.CommandText = "select * from daro_ham  where daro_code=?"
        m_brow_ham.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrow_ham.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_brow_ham.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_ham.Parameters.Append(par)
        rsbrow_ham.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrow_ham.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrow_ham.Source = m_brow_ham
        m_Commands.Add(m_brow_ham, "brow_ham")
        m_Recordsets.Add(rsbrow_ham, "brow_ham")
        m_brow_same = New ADODB.Command()
        rsbrow_same = New ADODB.Recordset()
        m_brow_same.Name = "brow_same"
        m_brow_same.CommandText = "select * from daro_same  where daro_code=?"
        m_brow_same.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrow_same.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_brow_same.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_same.Parameters.Append(par)
        rsbrow_same.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrow_same.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrow_same.Source = m_brow_same
        m_Commands.Add(m_brow_same, "brow_same")
        m_Recordsets.Add(rsbrow_same, "brow_same")
        m_eslami = New ADODB.Command()
        rseslami = New ADODB.Recordset()
        m_eslami.Name = "eslami"
        m_eslami.CommandText = "select * from drug  where num=?"
        m_eslami.CommandType = ADODB.CommandTypeEnum.adCmdText
        rseslami.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_eslami.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_eslami.Parameters.Append(par)
        rseslami.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rseslami.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rseslami.Source = m_eslami
        m_Commands.Add(m_eslami, "eslami")
        m_Recordsets.Add(rseslami, "eslami")
        m_findnos = New ADODB.Command()
        rsfindnos = New ADODB.Recordset()
        m_findnos.Name = "findnos"
        m_findnos.CommandText = "select * from  pha_dnos where  monthh=? and   number=? and radif=?"
        m_findnos.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindnos.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findnos.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findnos.Parameters.Append(par)
        par = m_findnos.CreateParameter
        par.Name = "_parm2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findnos.Parameters.Append(par)
        par = m_findnos.CreateParameter
        par.Name = "_parm3"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findnos.Parameters.Append(par)
        rsfindnos.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindnos.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindnos.Source = m_findnos
        m_Commands.Add(m_findnos, "findnos")
        m_Recordsets.Add(rsfindnos, "findnos")
        m_findbim = New ADODB.Command()
        rsfindbim = New ADODB.Recordset()
        m_findbim.Name = "findbim"
        m_findbim.CommandText = "select * from bimar where bimeh=?"
        m_findbim.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindbim.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findbim.CreateParameter
        par.Name = "_bimeh"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findbim.Parameters.Append(par)
        rsfindbim.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindbim.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindbim.Source = m_findbim
        m_Commands.Add(m_findbim, "findbim")
        m_Recordsets.Add(rsfindbim, "findbim")
        m_findbimname = New ADODB.Command()
        rsfindbimname = New ADODB.Recordset()
        m_findbimname.Name = "findbimname"
        m_findbimname.CommandText = "select * from  bimar  where  name  like ?"
        m_findbimname.CommandType = ADODB.CommandTypeEnum.adCmdText
        par = m_findbimname.CreateParameter
        par.Name = "_name"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findbimname.Parameters.Append(par)
        rsfindbimname.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindbimname.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindbimname.LockType = ADODB.LockTypeEnum.adLockReadOnly
        rsfindbimname.Source = m_findbimname
        m_Commands.Add(m_findbimname, "findbimname")
        m_Recordsets.Add(rsfindbimname, "findbimname")
        m_browcond = New ADODB.Command()
        rsbrowcond = New ADODB.Recordset()
        m_browcond.Name = "browcond"
        m_browcond.CommandText = "select * from daro_cond where daro_code=? order by cath"
        m_browcond.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowcond.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_browcond.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_browcond.Parameters.Append(par)
        rsbrowcond.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowcond.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowcond.Source = m_browcond
        m_Commands.Add(m_browcond, "browcond")
        m_Recordsets.Add(rsbrowcond, "browcond")
        m_browspmot = New ADODB.Command()
        rsbrowspmot = New ADODB.Recordset()
        m_browspmot.Name = "browspmot"
        m_browspmot.CommandText = "select * from daro_spmot  where daro_code=? order by cath,tkhs_code"
        m_browspmot.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowspmot.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_browspmot.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_browspmot.Parameters.Append(par)
        rsbrowspmot.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowspmot.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowspmot.Source = m_browspmot
        m_Commands.Add(m_browspmot, "browspmot")
        m_Recordsets.Add(rsbrowspmot, "browspmot")
        m_findcond = New ADODB.Command()
        rsfindcond = New ADODB.Recordset()
        m_findcond.Name = "findcond"
        m_findcond.CommandText = "select * from daro_cond where daro_code=? and cath=?"
        m_findcond.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindcond.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findcond.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findcond.Parameters.Append(par)
        par = m_findcond.CreateParameter
        par.Name = "_parm2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findcond.Parameters.Append(par)
        rsfindcond.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindcond.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindcond.Source = m_findcond
        m_Commands.Add(m_findcond, "findcond")
        m_Recordsets.Add(rsfindcond, "findcond")
        m_findspmot = New ADODB.Command()
        rsfindspmot = New ADODB.Recordset()
        m_findspmot.Name = "findspmot"
        m_findspmot.CommandText = "select * from daro_spmot  where daro_code=?  and tkhs_code=?"
        m_findspmot.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindspmot.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findspmot.CreateParameter
        par.Name = "_daro"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findspmot.Parameters.Append(par)
        par = m_findspmot.CreateParameter
        par.Name = "_tkhs"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findspmot.Parameters.Append(par)
        rsfindspmot.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindspmot.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindspmot.Source = m_findspmot
        m_Commands.Add(m_findspmot, "findspmot")
        m_Recordsets.Add(rsfindspmot, "findspmot")
        m_darovir = New ADODB.Command()
        rsdarovir = New ADODB.Recordset()
        m_darovir.Name = "darovir"
        m_darovir.CommandText = "select * from darovir where daro_code=?"
        m_darovir.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsdarovir.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_darovir.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_darovir.Parameters.Append(par)
        rsdarovir.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsdarovir.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsdarovir.Source = m_darovir
        m_Commands.Add(m_darovir, "darovir")
        m_Recordsets.Add(rsdarovir, "darovir")
        m_browvir = New ADODB.Command()
        rsbrowvir = New ADODB.Recordset()
        m_browvir.Name = "browvir"
        m_browvir.CommandText = "select * from darovir "
        m_browvir.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowvir.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsbrowvir.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowvir.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowvir.Source = m_browvir
        m_Commands.Add(m_browvir, "browvir")
        m_Recordsets.Add(rsbrowvir, "browvir")
        m_browallnos = New ADODB.Command()
        rsbrowallnos = New ADODB.Recordset()
        m_browallnos.Name = "browallnos"
        m_browallnos.CommandText = "select * from  pha_dnos"
        m_browallnos.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowallnos.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsbrowallnos.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowallnos.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowallnos.Source = m_browallnos
        m_Commands.Add(m_browallnos, "browallnos")
        m_Recordsets.Add(rsbrowallnos, "browallnos")
        m_findnprint = New ADODB.Command()
        rsfindnprint = New ADODB.Recordset()
        m_findnprint.Name = "findnprint"
        m_findnprint.CommandText = "select * from nprinter where id=?  and sizetip=?"
        m_findnprint.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindnprint.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findnprint.CreateParameter
        par.Name = "_nprint"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findnprint.Parameters.Append(par)
        par = m_findnprint.CreateParameter
        par.Name = "_sizetip"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findnprint.Parameters.Append(par)
        rsfindnprint.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindnprint.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindnprint.Source = m_findnprint
        m_Commands.Add(m_findnprint, "findnprint")
        m_Recordsets.Add(rsfindnprint, "findnprint")
        m_browhj = New ADODB.Command()
        rsbrowhj = New ADODB.Recordset()
        m_browhj.Name = "browhj"
        m_browhj.CommandText = "select * from d61 order by  codeh"
        m_browhj.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowhj.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowhj.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowhj.LockType = ADODB.LockTypeEnum.adLockReadOnly
        rsbrowhj.Source = m_browhj
        m_Commands.Add(m_browhj, "browhj")
        m_Recordsets.Add(rsbrowhj, "browhj")
        m_findcode6 = New ADODB.Command()
        rsfindcode6 = New ADODB.Recordset()
        m_findcode6.Name = "findcode6"
        m_findcode6.CommandText = "select * from daro_code where code6=?"
        m_findcode6.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindcode6.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findcode6.CreateParameter
        par.Name = "_code6"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findcode6.Parameters.Append(par)
        rsfindcode6.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindcode6.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindcode6.Source = m_findcode6
        m_Commands.Add(m_findcode6, "findcode6")
        m_Recordsets.Add(rsfindcode6, "findcode6")
        m_browallnos1 = New ADODB.Command()
        rsbrowallnos1 = New ADODB.Recordset()
        m_browallnos1.Name = "browallnos1"
        m_browallnos1.CommandText = "select  cokm,nom from  pha_dnos  where datee=?"
        m_browallnos1.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowallnos1.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_browallnos1.CreateParameter
        par.Name = "_date"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_browallnos1.Parameters.Append(par)
        rsbrowallnos1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowallnos1.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowallnos1.Source = m_browallnos1
        m_Commands.Add(m_browallnos1, "browallnos1")
        m_Recordsets.Add(rsbrowallnos1, "browallnos1")
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
        m_accname = New ADODB.Command()
        rsaccname = New ADODB.Recordset()
        m_accname.Name = "accname"
        m_accname.CommandText = "select * from  kol  where  name like ?"
        m_accname.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsaccname.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_accname.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_accname.Parameters.Append(par)
        rsaccname.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsaccname.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsaccname.Source = m_accname
        m_Commands.Add(m_accname, "accname")
        m_Recordsets.Add(rsaccname, "accname")
        m_listdarocond = New ADODB.Command()
        rslistdarocond = New ADODB.Recordset()
        m_listdarocond.Name = "listdarocond"
        m_listdarocond.CommandText = "select * from daro_cond"
        m_listdarocond.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistdarocond.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistdarocond.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistdarocond.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistdarocond.Source = m_listdarocond
        m_Commands.Add(m_listdarocond, "listdarocond")
        m_Recordsets.Add(rslistdarocond, "listdarocond")
        m_findcode5 = New ADODB.Command()
        rsfindcode5 = New ADODB.Recordset()
        m_findcode5.Name = "findcode5"
        m_findcode5.CommandText = "select * from daro_code where code5=?"
        m_findcode5.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindcode5.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findcode5.CreateParameter
        par.Name = "_code5"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findcode5.Parameters.Append(par)
        rsfindcode5.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindcode5.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindcode5.Source = m_findcode5
        m_Commands.Add(m_findcode5, "findcode5")
        m_Recordsets.Add(rsfindcode5, "findcode5")
        m_findiokala = New ADODB.Command()
        rsfindiokala = New ADODB.Recordset()
        m_findiokala.Name = "findiokala"
        m_findiokala.CommandText = "select * from iokala where  tip=? and nf=?"
        m_findiokala.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindiokala.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findiokala.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findiokala.Parameters.Append(par)
        par = m_findiokala.CreateParameter
        par.Name = "_parm2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findiokala.Parameters.Append(par)
        rsfindiokala.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindiokala.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindiokala.Source = m_findiokala
        m_Commands.Add(m_findiokala, "findiokala")
        m_Recordsets.Add(rsfindiokala, "findiokala")
        m_browdaro = New ADODB.Command()
        rsbrowdaro = New ADODB.Recordset()
        m_browdaro.Name = "browdaro"
        m_browdaro.CommandText = "select  * from daro"
        m_browdaro.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowdaro.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsbrowdaro.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowdaro.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowdaro.Source = m_browdaro
        m_Commands.Add(m_browdaro, "browdaro")
        m_Recordsets.Add(rsbrowdaro, "browdaro")
        m_showdaro6 = New ADODB.Command()
        rsshowdaro6 = New ADODB.Recordset()
        m_showdaro6.Name = "showdaro6"
        m_showdaro6.CommandText = "select * from daro6"
        m_showdaro6.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsshowdaro6.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsshowdaro6.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsshowdaro6.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsshowdaro6.Source = m_showdaro6
        m_Commands.Add(m_showdaro6, "showdaro6")
        m_Recordsets.Add(rsshowdaro6, "showdaro6")
        m_fcode6 = New ADODB.Command()
        rsfcode6 = New ADODB.Recordset()
        m_fcode6.Name = "fcode6"
        m_fcode6.CommandText = "select * from  daro where code6=?"
        m_fcode6.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfcode6.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_fcode6.CreateParameter
        par.Name = "_p1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_fcode6.Parameters.Append(par)
        rsfcode6.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfcode6.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfcode6.Source = m_fcode6
        m_Commands.Add(m_fcode6, "fcode6")
        m_Recordsets.Add(rsfcode6, "fcode6")
        m_fc6 = New ADODB.Command()
        rsfc6 = New ADODB.Recordset()
        m_fc6.Name = "fc6"
        m_fc6.CommandText = "select * from daro6 where daro_code=?"
        m_fc6.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfc6.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_fc6.CreateParameter
        par.Name = "_p1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_fc6.Parameters.Append(par)
        rsfc6.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfc6.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfc6.Source = m_fc6
        m_Commands.Add(m_fc6, "fc6")
        m_Recordsets.Add(rsfc6, "fc6")
        m_der = New ADODB.Command()
        rsder = New ADODB.Recordset()
        m_der.Name = "der"
        m_der.CommandText = "select * from daroerror"
        m_der.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsder.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsder.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsder.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsder.Source = m_der
        m_Commands.Add(m_der, "der")
        m_Recordsets.Add(rsder, "der")
        m_upddaro = New ADODB.Command()
        rsupddaro = New ADODB.Recordset()
        m_upddaro.Name = "upddaro"
        m_upddaro.CommandText = "select * from daro_code"
        m_upddaro.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsupddaro.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsupddaro.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsupddaro.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsupddaro.Source = m_upddaro
        m_Commands.Add(m_upddaro, "upddaro")
        m_Recordsets.Add(rsupddaro, "upddaro")
        m_updnos = New ADODB.Command()
        rsupdnos = New ADODB.Recordset()
        m_updnos.Name = "updnos"
        m_updnos.CommandText = "select * from  pha_dnos"
        m_updnos.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsupdnos.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsupdnos.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsupdnos.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsupdnos.Source = m_updnos
        m_Commands.Add(m_updnos, "updnos")
        m_Recordsets.Add(rsupdnos, "updnos")
        m_updcond = New ADODB.Command()
        rsupdcond = New ADODB.Recordset()
        m_updcond.Name = "updcond"
        m_updcond.CommandText = "select * from daro_cond"
        m_updcond.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsupdcond.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsupdcond.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsupdcond.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsupdcond.Source = m_updcond
        m_Commands.Add(m_updcond, "updcond")
        m_Recordsets.Add(rsupdcond, "updcond")
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
        m_tamin = New ADODB.Command()
        rstamin = New ADODB.Recordset()
        m_tamin.Name = "tamin"
        m_tamin.CommandText = "select * from tamin where  code5=?"
        m_tamin.CommandType = ADODB.CommandTypeEnum.adCmdText
        rstamin.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_tamin.CreateParameter
        par.Name = "_p1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_tamin.Parameters.Append(par)
        rstamin.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rstamin.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rstamin.Source = m_tamin
        m_Commands.Add(m_tamin, "tamin")
        m_Recordsets.Add(rstamin, "tamin")
        m_browotc = New ADODB.Command()
        rsbrowotc = New ADODB.Recordset()
        m_browotc.Name = "browotc"
        m_browotc.CommandText = "select * from daro_otc"
        m_browotc.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowotc.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsbrowotc.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowotc.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowotc.Source = m_browotc
        m_Commands.Add(m_browotc, "browotc")
        m_Recordsets.Add(rsbrowotc, "browotc")
        m_listpaz = New ADODB.Command()
        rslistpaz = New ADODB.Recordset()
        m_listpaz.Name = "listpaz"
        m_listpaz.CommandText = "select * from  pha_detail"
        m_listpaz.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistpaz.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistpaz.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistpaz.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistpaz.Source = m_listpaz
        m_Commands.Add(m_listpaz, "listpaz")
        m_Recordsets.Add(rslistpaz, "listpaz")
        m_ListNos = New ADODB.Command()
        rsListNos = New ADODB.Recordset()
        m_ListNos.Name = "ListNos"
        m_ListNos.CommandText = "select * from  pha_dnos"
        m_ListNos.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsListNos.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsListNos.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsListNos.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsListNos.Source = m_ListNos
        m_Commands.Add(m_ListNos, "ListNos")
        m_Recordsets.Add(rsListNos, "ListNos")
        m_ListRoutine = New ADODB.Command()
        rsListRoutine = New ADODB.Recordset()
        m_ListRoutine.Name = "ListRoutine"
        m_ListRoutine.CommandText = "select cath,name  from testRoutine  group by cath,name order by cath"
        m_ListRoutine.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsListRoutine.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsListRoutine.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsListRoutine.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsListRoutine.Source = m_ListRoutine
        m_Commands.Add(m_ListRoutine, "ListRoutine")
        m_Recordsets.Add(rsListRoutine, "ListRoutine")
        m_BrowRoutine = New ADODB.Command()
        rsBrowRoutine = New ADODB.Recordset()
        m_BrowRoutine.Name = "BrowRoutine"
        m_BrowRoutine.CommandText = "select * from testRoutine where cath=?"
        m_BrowRoutine.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsBrowRoutine.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_BrowRoutine.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_BrowRoutine.Parameters.Append(par)
        rsBrowRoutine.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsBrowRoutine.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsBrowRoutine.Source = m_BrowRoutine
        m_Commands.Add(m_BrowRoutine, "BrowRoutine")
        m_Recordsets.Add(rsBrowRoutine, "BrowRoutine")
        m_ShowRoutine = New ADODB.Command()
        rsShowRoutine = New ADODB.Recordset()
        m_ShowRoutine.Name = "ShowRoutine"
        m_ShowRoutine.CommandText = "select * from testRoutine "
        m_ShowRoutine.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsShowRoutine.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsShowRoutine.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsShowRoutine.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsShowRoutine.Source = m_ShowRoutine
        m_Commands.Add(m_ShowRoutine, "ShowRoutine")
        m_Recordsets.Add(rsShowRoutine, "ShowRoutine")
        m_ShowPrintDastur = New ADODB.Command()
        rsShowPrintDastur = New ADODB.Recordset()
        m_ShowPrintDastur.Name = "ShowPrintDastur"
        m_ShowPrintDastur.CommandText = "select * from PrintDastur"
        m_ShowPrintDastur.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsShowPrintDastur.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsShowPrintDastur.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsShowPrintDastur.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsShowPrintDastur.Source = m_ShowPrintDastur
        m_Commands.Add(m_ShowPrintDastur, "ShowPrintDastur")
        m_Recordsets.Add(rsShowPrintDastur, "ShowPrintDastur")
        m_RptDaro = New ADODB.Command()
        rsRptDaro = New ADODB.Recordset()
        m_RptDaro.Name = "RptDaro"
        m_RptDaro.CommandText = "select  daro_code,Daro_name,Daro_fname,daro_pay,code5  from daro_code"
        m_RptDaro.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsRptDaro.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsRptDaro.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsRptDaro.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsRptDaro.Source = m_RptDaro
        m_Commands.Add(m_RptDaro, "RptDaro")
        m_Recordsets.Add(rsRptDaro, "RptDaro")
        m_mynetwork = New ADODB.Command()
        rsmynetwork = New ADODB.Recordset()
        m_mynetwork.Name = "mynetwork"
        m_mynetwork.CommandText = "select * from mynetwork where  mynom=?"
        m_mynetwork.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsmynetwork.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_mynetwork.CreateParameter
        par.Name = "_mynom"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_mynetwork.Parameters.Append(par)
        rsmynetwork.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsmynetwork.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsmynetwork.Source = m_mynetwork
        m_Commands.Add(m_mynetwork, "mynetwork")
        m_Recordsets.Add(rsmynetwork, "mynetwork")
        m_DelMyNetwork = New ADODB.Command()
        rsDelMyNetwork = New ADODB.Recordset()
        m_DelMyNetwork.Name = "DelMyNetwork"
        m_DelMyNetwork.CommandText = "delete   from mynetwork where  mynom=?"
        m_DelMyNetwork.CommandType = ADODB.CommandTypeEnum.adCmdText
        par = m_DelMyNetwork.CreateParameter
        par.Name = "?"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Precision = 255
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_DelMyNetwork.Parameters.Append(par)
        rsDelMyNetwork.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsDelMyNetwork.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsDelMyNetwork.LockType = ADODB.LockTypeEnum.adLockReadOnly
        rsDelMyNetwork.Source = m_DelMyNetwork
        m_Commands.Add(m_DelMyNetwork, "DelMyNetwork")
        m_Recordsets.Add(rsDelMyNetwork, "DelMyNetwork")
        m_UpdCath = New ADODB.Command()
        rsUpdCath = New ADODB.Recordset()
        m_UpdCath.Name = "UpdCath"
        m_UpdCath.CommandText = "select * from bdcath"
        m_UpdCath.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsUpdCath.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsUpdCath.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsUpdCath.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsUpdCath.Source = m_UpdCath
        m_Commands.Add(m_UpdCath, "UpdCath")
        m_Recordsets.Add(rsUpdCath, "UpdCath")
        m_ListNprint = New ADODB.Command()
        rsListNprint = New ADODB.Recordset()
        m_ListNprint.Name = "ListNprint"
        m_ListNprint.CommandText = "select * from nprinter"
        m_ListNprint.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsListNprint.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsListNprint.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsListNprint.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsListNprint.Source = m_ListNprint
        m_Commands.Add(m_ListNprint, "ListNprint")
        m_Recordsets.Add(rsListNprint, "ListNprint")
        m_ListMoney = New ADODB.Command()
        rsListMoney = New ADODB.Recordset()
        m_ListMoney.Name = "ListMoney"
        m_ListMoney.CommandText = "select *  from  myMoney "
        m_ListMoney.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsListMoney.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsListMoney.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsListMoney.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsListMoney.Source = m_ListMoney
        m_Commands.Add(m_ListMoney, "ListMoney")
        m_Recordsets.Add(rsListMoney, "ListMoney")
        m_FindMoney = New ADODB.Command()
        rsFindMoney = New ADODB.Recordset()
        m_FindMoney.Name = "FindMoney"
        m_FindMoney.CommandText = "select * from  mymoney where id=?"
        m_FindMoney.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsFindMoney.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_FindMoney.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_FindMoney.Parameters.Append(par)
        rsFindMoney.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsFindMoney.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsFindMoney.Source = m_FindMoney
        m_Commands.Add(m_FindMoney, "FindMoney")
        m_Recordsets.Add(rsFindMoney, "FindMoney")
        m_Findvcode1 = New ADODB.Command()
        rsFindvcode1 = New ADODB.Recordset()
        m_Findvcode1.Name = "Findvcode1"
        m_Findvcode1.CommandText = "select * from vcode where daro_code=? and tip=?"
        m_Findvcode1.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsFindvcode1.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_Findvcode1.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_Findvcode1.Parameters.Append(par)
        par = m_Findvcode1.CreateParameter
        par.Name = "_parm2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_Findvcode1.Parameters.Append(par)
        rsFindvcode1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsFindvcode1.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsFindvcode1.Source = m_Findvcode1
        m_Commands.Add(m_Findvcode1, "Findvcode1")
        m_Recordsets.Add(rsFindvcode1, "Findvcode1")
        m_ListVcode = New ADODB.Command()
        rsListVcode = New ADODB.Recordset()
        m_ListVcode.Name = "ListVcode"
        m_ListVcode.CommandText = "select * from vcode"
        m_ListVcode.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsListVcode.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsListVcode.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsListVcode.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsListVcode.Source = m_ListVcode
        m_Commands.Add(m_ListVcode, "ListVcode")
        m_Recordsets.Add(rsListVcode, "ListVcode")
        m_ListMyCath = New ADODB.Command()
        rsListMyCath = New ADODB.Recordset()
        m_ListMyCath.Name = "ListMyCath"
        m_ListMyCath.CommandText = "select * from  mycath order by nomber"
        m_ListMyCath.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsListMyCath.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsListMyCath.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsListMyCath.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsListMyCath.Source = m_ListMyCath
        m_Commands.Add(m_ListMyCath, "ListMyCath")
        m_Recordsets.Add(rsListMyCath, "ListMyCath")
        m_h11cop = New ADODB.Command()
        rsh11cop = New ADODB.Recordset()
        m_h11cop.Name = "h11cop"
        m_h11cop.CommandText = "select * from  h11  "
        m_h11cop.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsh11cop.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsh11cop.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsh11cop.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsh11cop.Source = m_h11cop
        m_Commands.Add(m_h11cop, "h11cop")
        m_Recordsets.Add(rsh11cop, "h11cop")
        m_factor = New ADODB.Command()
        rsfactor = New ADODB.Recordset()
        m_factor.Name = "factor"
        m_factor.CommandText = "select * from factor"
        m_factor.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfactor.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsfactor.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfactor.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfactor.Source = m_factor
        m_Commands.Add(m_factor, "factor")
        m_Recordsets.Add(rsfactor, "factor")
        m_MyphaDetail = New ADODB.Command()
        rsMyphaDetail = New ADODB.Recordset()
        m_MyphaDetail.Name = "MyphaDetail"
        m_MyphaDetail.CommandText = "select * from pha_detail"
        m_MyphaDetail.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsMyphaDetail.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsMyphaDetail.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsMyphaDetail.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsMyphaDetail.Source = m_MyphaDetail
        m_Commands.Add(m_MyphaDetail, "MyphaDetail")
        m_Recordsets.Add(rsMyphaDetail, "MyphaDetail")
        m_MyPhaDnos = New ADODB.Command()
        rsMyPhaDnos = New ADODB.Recordset()
        m_MyPhaDnos.Name = "MyPhaDnos"
        m_MyPhaDnos.CommandText = "select * from pha_dnos"
        m_MyPhaDnos.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsMyPhaDnos.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsMyPhaDnos.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsMyPhaDnos.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsMyPhaDnos.Source = m_MyPhaDnos
        m_Commands.Add(m_MyPhaDnos, "MyPhaDnos")
        m_Recordsets.Add(rsMyPhaDnos, "MyPhaDnos")
        m_listdaroCond1 = New ADODB.Command()
        rslistdaroCond1 = New ADODB.Recordset()
        m_listdaroCond1.Name = "listdaroCond1"
        m_listdaroCond1.CommandText = "select * from daro_cond"
        m_listdaroCond1.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistdaroCond1.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistdaroCond1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistdaroCond1.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistdaroCond1.Source = m_listdaroCond1
        m_Commands.Add(m_listdaroCond1, "listdaroCond1")
        m_Recordsets.Add(rslistdaroCond1, "listdaroCond1")
        m_brow_MyCardex = New ADODB.Command()
        rsbrow_MyCardex = New ADODB.Recordset()
        m_brow_MyCardex.Name = "brow_MyCardex"
        m_brow_MyCardex.CommandText = "select * from pha_dnos where cath=? and nf=? and oper=? "
        m_brow_MyCardex.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrow_MyCardex.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_brow_MyCardex.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_MyCardex.Parameters.Append(par)
        par = m_brow_MyCardex.CreateParameter
        par.Name = "_parm2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_MyCardex.Parameters.Append(par)
        par = m_brow_MyCardex.CreateParameter
        par.Name = "_parm3"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_brow_MyCardex.Parameters.Append(par)
        rsbrow_MyCardex.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrow_MyCardex.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrow_MyCardex.Source = m_brow_MyCardex
        m_Commands.Add(m_brow_MyCardex, "brow_MyCardex")
        m_Recordsets.Add(rsbrow_MyCardex, "brow_MyCardex")
        m_mydoc = New ADODB.Command()
        rsmydoc = New ADODB.Recordset()
        m_mydoc.Name = "mydoc"
        m_mydoc.CommandText = "select * from bdhosp"
        m_mydoc.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsmydoc.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsmydoc.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsmydoc.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsmydoc.Source = m_mydoc
        m_Commands.Add(m_mydoc, "mydoc")
        m_Recordsets.Add(rsmydoc, "mydoc")
        m_listcardex9 = New ADODB.Command()
        rslistcardex9 = New ADODB.Recordset()
        m_listcardex9.Name = "listcardex9"
        m_listcardex9.CommandText = "select sum(nom) as tnom ,pha_dnos.cokm as cokm,daro_code.daro_fname  as daro_fname from pha_dnos inner join daro_code on pha_dnos.cokm=daro_code.daro_code group by pha_dnos.cokm,daro_code.daro_fname"
        m_listcardex9.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistcardex9.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistcardex9.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistcardex9.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistcardex9.Source = m_listcardex9
        m_Commands.Add(m_listcardex9, "listcardex9")
        m_Recordsets.Add(rslistcardex9, "listcardex9")
        m_InsMyCardex = New ADODB.Command()
        rsInsMyCardex = New ADODB.Recordset()
        m_InsMyCardex.Name = "InsMyCardex"
        m_InsMyCardex.CommandText = "select * from pha_dnos"
        m_InsMyCardex.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsInsMyCardex.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsInsMyCardex.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsInsMyCardex.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsInsMyCardex.Source = m_InsMyCardex
        m_Commands.Add(m_InsMyCardex, "InsMyCardex")
        m_Recordsets.Add(rsInsMyCardex, "InsMyCardex")
        m_Rtdaro = New ADODB.Command()
        rsRtdaro = New ADODB.Recordset()
        m_Rtdaro.Name = "Rtdaro"
        m_Rtdaro.CommandText = "select * from tdaro"
        m_Rtdaro.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsRtdaro.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsRtdaro.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsRtdaro.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsRtdaro.Source = m_Rtdaro
        m_Commands.Add(m_Rtdaro, "Rtdaro")
        m_Recordsets.Add(rsRtdaro, "Rtdaro")
        m_browTdaro = New ADODB.Command()
        rsbrowTdaro = New ADODB.Recordset()
        m_browTdaro.Name = "browTdaro"
        m_browTdaro.CommandText = "select * from  tdaro"
        m_browTdaro.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowTdaro.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsbrowTdaro.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowTdaro.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowTdaro.Source = m_browTdaro
        m_Commands.Add(m_browTdaro, "browTdaro")
        m_Recordsets.Add(rsbrowTdaro, "browTdaro")
        m_browall1 = New ADODB.Command()
        rsbrowall1 = New ADODB.Recordset()
        m_browall1.Name = "browall1"
        m_browall1.CommandText = "select * from  pha_dnos"
        m_browall1.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowall1.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsbrowall1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowall1.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowall1.Source = m_browall1
        m_Commands.Add(m_browall1, "browall1")
        m_Recordsets.Add(rsbrowall1, "browall1")
        m_findbarcode = New ADODB.Command()
        rsfindbarcode = New ADODB.Recordset()
        m_findbarcode.Name = "findbarcode"
        m_findbarcode.CommandText = "select * from  daro_code  where daro_code=?"
        m_findbarcode.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindbarcode.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findbarcode.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findbarcode.Parameters.Append(par)
        rsfindbarcode.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindbarcode.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindbarcode.Source = m_findbarcode
        m_Commands.Add(m_findbarcode, "findbarcode")
        m_Recordsets.Add(rsfindbarcode, "findbarcode")
        m_findUser = New ADODB.Command()
        rsfindUser = New ADODB.Recordset()
        m_findUser.Name = "findUser"
        m_findUser.CommandText = "select * from karbar where naka=?"
        m_findUser.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindUser.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findUser.CreateParameter
        par.Name = "_parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findUser.Parameters.Append(par)
        rsfindUser.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindUser.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindUser.Source = m_findUser
        m_Commands.Add(m_findUser, "findUser")
        m_Recordsets.Add(rsfindUser, "findUser")
        m_UpdateNezam = New ADODB.Command()
        rsUpdateNezam = New ADODB.Recordset()
        m_UpdateNezam.Name = "UpdateNezam"
        m_UpdateNezam.CommandText = "select * from  bdhosp"
        m_UpdateNezam.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsUpdateNezam.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsUpdateNezam.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsUpdateNezam.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsUpdateNezam.Source = m_UpdateNezam
        m_Commands.Add(m_UpdateNezam, "UpdateNezam")
        m_Recordsets.Add(rsUpdateNezam, "UpdateNezam")
        m_showRadif = New ADODB.Command()
        rsshowRadif = New ADODB.Recordset()
        m_showRadif.Name = "showRadif"
        m_showRadif.CommandText = "select radif from pha_detail where pha_detail.monthh=? order by radif"
        m_showRadif.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsshowRadif.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_showRadif.CreateParameter
        par.Name = "_p1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_showRadif.Parameters.Append(par)
        rsshowRadif.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsshowRadif.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsshowRadif.Source = m_showRadif
        m_Commands.Add(m_showRadif, "showRadif")
        m_Recordsets.Add(rsshowRadif, "showRadif")
        m_ShowNumberCath = New ADODB.Command()
        rsShowNumberCath = New ADODB.Recordset()
        m_ShowNumberCath.Name = "ShowNumberCath"
        m_ShowNumberCath.CommandText = "select number from pha_detail where pha_detail.monthh=? and pha_detail.cath=? order by number"
        m_ShowNumberCath.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsShowNumberCath.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_ShowNumberCath.CreateParameter
        par.Name = "_p1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ShowNumberCath.Parameters.Append(par)
        par = m_ShowNumberCath.CreateParameter
        par.Name = "_p2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ShowNumberCath.Parameters.Append(par)
        rsShowNumberCath.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsShowNumberCath.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsShowNumberCath.Source = m_ShowNumberCath
        m_Commands.Add(m_ShowNumberCath, "ShowNumberCath")
        m_Recordsets.Add(rsShowNumberCath, "ShowNumberCath")
        m_ListNumbercath = New ADODB.Command()
        rsListNumbercath = New ADODB.Recordset()
        m_ListNumbercath.Name = "ListNumbercath"
        m_ListNumbercath.CommandText = "select number from pha_detail where pha_detail.monthh=? and pha_detail.cath=? and pha_detail.number=? order by number"
        m_ListNumbercath.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsListNumbercath.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_ListNumbercath.CreateParameter
        par.Name = "_p1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ListNumbercath.Parameters.Append(par)
        par = m_ListNumbercath.CreateParameter
        par.Name = "_p2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ListNumbercath.Parameters.Append(par)
        par = m_ListNumbercath.CreateParameter
        par.Name = "_p3"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ListNumbercath.Parameters.Append(par)
        rsListNumbercath.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsListNumbercath.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsListNumbercath.Source = m_ListNumbercath
        m_Commands.Add(m_ListNumbercath, "ListNumbercath")
        m_Recordsets.Add(rsListNumbercath, "ListNumbercath")
        m_BarCodeBrow = New ADODB.Command()
        rsBarCodeBrow = New ADODB.Recordset()
        m_BarCodeBrow.Name = "BarCodeBrow"
        m_BarCodeBrow.CommandText = "select * from  barcode where daro_code=?"
        m_BarCodeBrow.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsBarCodeBrow.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_BarCodeBrow.CreateParameter
        par.Name = "parm1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_BarCodeBrow.Parameters.Append(par)
        rsBarCodeBrow.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsBarCodeBrow.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsBarCodeBrow.Source = m_BarCodeBrow
        m_Commands.Add(m_BarCodeBrow, "BarCodeBrow")
        m_Recordsets.Add(rsBarCodeBrow, "BarCodeBrow")
        m_BarCodeFind = New ADODB.Command()
        rsBarCodeFind = New ADODB.Recordset()
        m_BarCodeFind.Name = "BarCodeFind"
        m_BarCodeFind.CommandText = "select * from  barcode where barcode=?"
        m_BarCodeFind.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsBarCodeFind.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_BarCodeFind.CreateParameter
        par.Name = "_p1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_BarCodeFind.Parameters.Append(par)
        rsBarCodeFind.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsBarCodeFind.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsBarCodeFind.Source = m_BarCodeFind
        m_Commands.Add(m_BarCodeFind, "BarCodeFind")
        m_Recordsets.Add(rsBarCodeFind, "BarCodeFind")
        m_BarCodeDel = New ADODB.Command()
        rsBarCodeDel = New ADODB.Recordset()
        m_BarCodeDel.Name = "BarCodeDel"
        m_BarCodeDel.CommandText = "select * from  barcode  "
        m_BarCodeDel.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsBarCodeDel.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsBarCodeDel.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsBarCodeDel.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsBarCodeDel.Source = m_BarCodeDel
        m_Commands.Add(m_BarCodeDel, "BarCodeDel")
        m_Recordsets.Add(rsBarCodeDel, "BarCodeDel")
        m_Browmasraf = New ADODB.Command()
        rsBrowmasraf = New ADODB.Recordset()
        m_Browmasraf.Name = "Browmasraf"
        m_Browmasraf.CommandText = "select * from masraf"
        m_Browmasraf.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsBrowmasraf.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsBrowmasraf.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsBrowmasraf.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsBrowmasraf.Source = m_Browmasraf
        m_Commands.Add(m_Browmasraf, "Browmasraf")
        m_Recordsets.Add(rsBrowmasraf, "Browmasraf")
        m_FindSMOT = New ADODB.Command()
        rsFindSMOT = New ADODB.Recordset()
        m_FindSMOT.Name = "FindSMOT"
        m_FindSMOT.CommandText = "select * from daro_spmot where id=?"
        m_FindSMOT.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsFindSMOT.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_FindSMOT.CreateParameter
        par.Name = "_p1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_FindSMOT.Parameters.Append(par)
        rsFindSMOT.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsFindSMOT.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsFindSMOT.Source = m_FindSMOT
        m_Commands.Add(m_FindSMOT, "FindSMOT")
        m_Recordsets.Add(rsFindSMOT, "FindSMOT")
        m_browtakh = New ADODB.Command()
        rsbrowtakh = New ADODB.Recordset()
        m_browtakh.Name = "browtakh"
        m_browtakh.CommandText = "select * from bdtakh order by tkhs_name"
        m_browtakh.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsbrowtakh.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsbrowtakh.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsbrowtakh.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsbrowtakh.Source = m_browtakh
        m_Commands.Add(m_browtakh, "browtakh")
        m_Recordsets.Add(rsbrowtakh, "browtakh")
        m_DaroSpCath = New ADODB.Command()
        rsDaroSpCath = New ADODB.Recordset()
        m_DaroSpCath.Name = "DaroSpCath"
        m_DaroSpCath.CommandText = "select * from daro_spmot  where  cath=? and  daro_code=?"
        m_DaroSpCath.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsDaroSpCath.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_DaroSpCath.CreateParameter
        par.Name = "_p1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_DaroSpCath.Parameters.Append(par)
        par = m_DaroSpCath.CreateParameter
        par.Name = "_p2"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_DaroSpCath.Parameters.Append(par)
        rsDaroSpCath.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsDaroSpCath.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsDaroSpCath.Source = m_DaroSpCath
        m_Commands.Add(m_DaroSpCath, "DaroSpCath")
        m_Recordsets.Add(rsDaroSpCath, "DaroSpCath")
        m_SumCardexdaro = New ADODB.Command()
        rsSumCardexdaro = New ADODB.Recordset()
        m_SumCardexdaro.Name = "SumCardexdaro"
        m_SumCardexdaro.CommandText = "select sum(nom) as nom_out,sum(nom_in)  as nom_in from pha_dnos where cokm=?"
        m_SumCardexdaro.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsSumCardexdaro.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_SumCardexdaro.CreateParameter
        par.Name = "_p1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_SumCardexdaro.Parameters.Append(par)
        rsSumCardexdaro.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsSumCardexdaro.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsSumCardexdaro.Source = m_SumCardexdaro
        m_Commands.Add(m_SumCardexdaro, "SumCardexdaro")
        m_Recordsets.Add(rsSumCardexdaro, "SumCardexdaro")
        m_listType1 = New ADODB.Command()
        rslistType1 = New ADODB.Recordset()
        m_listType1.Name = "listType1"
        m_listType1.CommandText = "select * from  bdtype  order by code"
        m_listType1.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistType1.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistType1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistType1.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistType1.Source = m_listType1
        m_Commands.Add(m_listType1, "listType1")
        m_Recordsets.Add(rslistType1, "listType1")
        m_FindType = New ADODB.Command()
        rsFindType = New ADODB.Recordset()
        m_FindType.Name = "FindType"
        m_FindType.CommandText = "select * from bdtype where code=?"
        m_FindType.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsFindType.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_FindType.CreateParameter
        par.Name = "_p1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_FindType.Parameters.Append(par)
        rsFindType.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsFindType.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsFindType.Source = m_FindType
        m_Commands.Add(m_FindType, "FindType")
        m_Recordsets.Add(rsFindType, "FindType")
        m_listTash = New ADODB.Command()
        rslistTash = New ADODB.Recordset()
        m_listTash.Name = "listTash"
        m_listTash.CommandText = "select * from tashkhis "
        m_listTash.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistTash.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistTash.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistTash.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistTash.Source = m_listTash
        m_Commands.Add(m_listTash, "listTash")
        m_Recordsets.Add(rslistTash, "listTash")
        m_findTash = New ADODB.Command()
        rsfindTash = New ADODB.Recordset()
        m_findTash.Name = "findTash"
        m_findTash.CommandText = "select * from tashkhis where code=?"
        m_findTash.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsfindTash.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_findTash.CreateParameter
        par.Name = "_p1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_findTash.Parameters.Append(par)
        rsfindTash.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsfindTash.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsfindTash.Source = m_findTash
        m_Commands.Add(m_findTash, "findTash")
        m_Recordsets.Add(rsfindTash, "findTash")
        m_listkala = New ADODB.Command()
        rslistkala = New ADODB.Recordset()
        m_listkala.Name = "listkala"
        m_listkala.CommandText = "select * from  kala"
        m_listkala.CommandType = ADODB.CommandTypeEnum.adCmdText
        rslistkala.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rslistkala.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rslistkala.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rslistkala.Source = m_listkala
        m_Commands.Add(m_listkala, "listkala")
        m_Recordsets.Add(rslistkala, "listkala")
        m_delCardex = New ADODB.Command()
        rsdelCardex = New ADODB.Recordset()
        m_delCardex.Name = "delCardex"
        m_delCardex.CommandText = "select * from pha_dnos  "
        m_delCardex.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsdelCardex.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsdelCardex.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsdelCardex.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsdelCardex.Source = m_delCardex
        m_Commands.Add(m_delCardex, "delCardex")
        m_Recordsets.Add(rsdelCardex, "delCardex")
        m_SumCardex = New ADODB.Command()
        rsSumCardex = New ADODB.Recordset()
        m_SumCardex.Name = "SumCardex"
        m_SumCardex.CommandText = "select sum(nom) as nom_out,sum(nom_in)  as nom_in from pha_dnos  where cokm=?"
        m_SumCardex.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsSumCardex.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_SumCardex.CreateParameter
        par.Name = "_cokm"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_SumCardex.Parameters.Append(par)
        rsSumCardex.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsSumCardex.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsSumCardex.Source = m_SumCardex
        m_Commands.Add(m_SumCardex, "SumCardex")
        m_Recordsets.Add(rsSumCardex, "SumCardex")
        m_BrowFam = New ADODB.Command()
        rsBrowFam = New ADODB.Recordset()
        m_BrowFam.Name = "BrowFam"
        m_BrowFam.CommandText = "select * from sanadi"
        m_BrowFam.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsBrowFam.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsBrowFam.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsBrowFam.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsBrowFam.Source = m_BrowFam
        m_Commands.Add(m_BrowFam, "BrowFam")
        m_Recordsets.Add(rsBrowFam, "BrowFam")
        '------------------------------------------------------------------------
        m_ListCompany = New ADODB.Command()
        rsListCompany = New ADODB.Recordset()
        m_ListCompany.Name = "ListCompany"
        m_ListCompany.CommandText = "select * from company"
        m_ListCompany.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsListCompany.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsListCompany.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsListCompany.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsListCompany.Source = m_ListCompany
        m_Commands.Add(m_ListCompany, "ListCompany")
        m_Recordsets.Add(rsListCompany, "ListCompany")
        '---------------------------------------------------------------------------
        m_FindCompany = New ADODB.Command()
        rsFindCompany = New ADODB.Recordset()
        m_FindCompany.Name = "FindCompany"
        m_FindCompany.CommandText = "select * from company where compcode=?"
        m_FindCompany.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsFindCompany.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_FindCompany.CreateParameter
        par.Name = "_p1"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_FindCompany.Parameters.Append(par)
        rsFindCompany.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsFindCompany.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsFindCompany.Source = m_FindCompany
        m_Commands.Add(m_FindCompany, "FindCompany")
        m_Recordsets.Add(rsFindCompany, "FindCompany")
        '----------------------------------------------------------
        m_BrowSpFani = New ADODB.Command()
        rsBrowSpFani = New ADODB.Recordset()
        m_BrowSpFani.Name = "BrowSpFani"
        m_BrowSpFani.CommandText = "select * from  faniSpecial "
        m_BrowSpFani.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsBrowSpFani.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsBrowSpFani.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsBrowSpFani.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsBrowSpFani.Source = m_BrowSpFani
        m_Commands.Add(m_BrowSpFani, "BrowSpFani")
        m_Recordsets.Add(rsBrowSpFani, "BrowSpFani")
        '----------------------------------------------------------------
        m_FindSpFani = New ADODB.Command()
        rsFindSpFani = New ADODB.Recordset()
        m_FindSpFani.Name = "FindSpFani"
        m_FindSpFani.CommandText = "select * from faniSpecial where cath=?"
        m_FindSpFani.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsFindSpFani.LockType = ADODB.LockTypeEnum.adLockOptimistic
        par = m_FindSpFani.CreateParameter
        par.Name = "_cath"
        par.Type = ADODB.DataTypeEnum.adVarWChar
        par.Size = 510
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_FindSpFani.Parameters.Append(par)
        rsFindSpFani.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsFindSpFani.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsFindSpFani.Source = m_FindSpFani
        m_Commands.Add(m_FindSpFani, "FindSpFani")
        m_Recordsets.Add(rsFindSpFani, "FindSpFani")
        '----------------------------------------------------------
        
        


    End Sub
    Public Sub findbimar(ByVal parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindbimar.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindbimar.Close()
        End If
        m_findbimar.ActiveConnection = con_main
        m_findbimar.Parameters.Item("parm1").Value = parm1
        rsfindbimar.Open()
    End Sub
    Public Sub bimarname(ByVal _famil As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbimarname.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbimarname.Close()
        End If
        m_bimarname.ActiveConnection = con_main
        m_bimarname.Parameters.Item("_famil").Value = _famil
        rsbimarname.Open()
    End Sub
    Public Sub finddocamal(ByVal parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfinddocamal.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfinddocamal.Close()
        End If
        m_finddocamal.ActiveConnection = con_main
        m_finddocamal.Parameters.Item("parm1").Value = parm1
        rsfinddocamal.Open()
    End Sub
    Public Sub finddocdetail(ByVal _var As String, ByVal _var2 As String, ByVal _var3 As String, ByVal _var4 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfinddocdetail.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfinddocdetail.Close()
        End If
        m_finddocdetail.ActiveConnection = con_main
        m_finddocdetail.Parameters.Item("_var").Value = _var
        m_finddocdetail.Parameters.Item("_var2").Value = _var2
        m_finddocdetail.Parameters.Item("_var3").Value = _var3
        m_finddocdetail.Parameters.Item("_var4").Value = _var4
        rsfinddocdetail.Open()
    End Sub
    Public Sub listdocamal()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslistdocamal.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistdocamal.Close()
        End If
        m_listdocamal.ActiveConnection = con_main
        rslistdocamal.Open()
    End Sub
    Public Sub findcath(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindcath.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindcath.Close()
        End If
        m_findcath.ActiveConnection = con_main
        m_findcath.Parameters.Item("_parm1").Value = _parm1
        rsfindcath.Open()
    End Sub
    Public Sub list_nostype()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslist_nostype.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslist_nostype.Close()
        End If
        m_list_nostype.ActiveConnection = con_main
        rslist_nostype.Open()
    End Sub
    Public Sub find_nostype(ByVal _nostype As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfind_nostype.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfind_nostype.Close()
        End If
        m_find_nostype.ActiveConnection = con_main
        m_find_nostype.Parameters.Item("_nostype").Value = _nostype
        rsfind_nostype.Open()
    End Sub
    Public Sub brow_docdetail(ByVal _parm1 As String, ByVal _parm2 As String, ByVal _parm3 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrow_docdetail.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrow_docdetail.Close()
        End If
        m_brow_docdetail.ActiveConnection = con_main
        m_brow_docdetail.Parameters.Item("_parm1").Value = _parm1
        m_brow_docdetail.Parameters.Item("_parm2").Value = _parm2
        m_brow_docdetail.Parameters.Item("_parm3").Value = _parm3
        rsbrow_docdetail.Open()
    End Sub
    Public Sub listostan()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslistostan.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistostan.Close()
        End If
        m_listostan.ActiveConnection = con_main
        rslistostan.Open()
    End Sub
    Public Sub listcath()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslistcath.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistcath.Close()
        End If
        m_listcath.ActiveConnection = con_main
        rslistcath.Open()
    End Sub
    Public Sub brow_phadetail(ByVal _parm1 As String, ByVal _parm2 As String, ByVal _parm3 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrow_phadetail.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrow_phadetail.Close()
        End If
        m_brow_phadetail.ActiveConnection = con_main
        m_brow_phadetail.Parameters.Item("_parm1").Value = _parm1
        m_brow_phadetail.Parameters.Item("_parm2").Value = _parm2
        m_brow_phadetail.Parameters.Item("_parm3").Value = _parm3
        rsbrow_phadetail.Open()
    End Sub
    Public Sub findradifpha(ByVal _parm1 As String, ByVal _parm2 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindradifpha.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindradifpha.Close()
        End If
        m_findradifpha.ActiveConnection = con_main
        m_findradifpha.Parameters.Item("_parm1").Value = _parm1
        m_findradifpha.Parameters.Item("_parm2").Value = _parm2
        rsfindradifpha.Open()
    End Sub
    Public Sub findbdhosp(ByVal _code As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindbdhosp.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindbdhosp.Close()
        End If
        m_findbdhosp.ActiveConnection = con_main
        m_findbdhosp.Parameters.Item("_code").Value = _code
        rsfindbdhosp.Open()
    End Sub
    Public Sub findnamkar(ByVal _naka As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindnamkar.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindnamkar.Close()
        End If
        m_findnamkar.ActiveConnection = con_main
        m_findnamkar.Parameters.Item("_naka").Value = _naka
        rsfindnamkar.Open()
    End Sub
    Public Sub findpass(ByVal _naka As String, ByVal _pass As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindpass.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindpass.Close()
        End If
        m_findpass.ActiveConnection = con_main
        m_findpass.Parameters.Item("_naka").Value = _naka
        m_findpass.Parameters.Item("_pass").Value = _pass
        rsfindpass.Open()
    End Sub
    Public Sub findmain()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindmain.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindmain.Close()
        End If
        m_findmain.ActiveConnection = con_main
        rsfindmain.Open()
    End Sub
    Public Sub show_phadetail(ByVal _parm1 As String, ByVal _parm2 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsshow_phadetail.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsshow_phadetail.Close()
        End If
        m_show_phadetail.ActiveConnection = con_main
        m_show_phadetail.Parameters.Item("_parm1").Value = _parm1
        m_show_phadetail.Parameters.Item("_parm2").Value = _parm2
        rsshow_phadetail.Open()
    End Sub
    Public Sub findorgan(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindorgan.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindorgan.Close()
        End If
        m_findorgan.ActiveConnection = con_main
        m_findorgan.Parameters.Item("_parm1").Value = _parm1
        rsfindorgan.Open()
    End Sub
    Public Sub bdhospname(ByVal strsql As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbdhospname.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbdhospname.Close()
        End If
        m_bdhospname.ActiveConnection = con_main
        m_bdhospname.CommandText = strsql
        rsbdhospname.Open()
    End Sub
    Public Sub browall(ByVal strsql As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrowall.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowall.Close()
        End If
        m_browall.ActiveConnection = con_main
        m_browall.CommandText = strsql
        rsbrowall.Open()
    End Sub
    Public Sub brow_dnos(ByVal _parm1 As String, ByVal _parm2 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrow_dnos.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrow_dnos.Close()
        End If
        m_brow_dnos.ActiveConnection = con_main
        m_brow_dnos.Parameters.Item("_parm1").Value = _parm1
        m_brow_dnos.Parameters.Item("_parm2").Value = _parm2

        rsbrow_dnos.Open()
    End Sub
    Public Sub darocode(ByVal _darocode As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsdarocode.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsdarocode.Close()
        End If
        m_darocode.ActiveConnection = con_main
        m_darocode.Parameters.Item("_darocode").Value = _darocode
        rsdarocode.Open()
    End Sub
    Public Sub listdaro(ByVal SqlStr As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslistdaro.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistdaro.Close()
        End If
        m_listdaro.ActiveConnection = con_main
        m_listdaro.CommandText = SqlStr
        rslistdaro.Open()
    End Sub
    Public Sub bdkhas(ByVal _khas As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbdkhas.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbdkhas.Close()
        End If
        m_bdkhas.ActiveConnection = con_main
        m_bdkhas.Parameters.Item("_khas").Value = _khas
        rsbdkhas.Open()
    End Sub
    Public Sub listkar()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslistkar.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistkar.Close()
        End If
        m_listkar.ActiveConnection = con_main
        rslistkar.Open()
    End Sub
    Public Sub findkar(ByVal _coka As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindkar.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindkar.Close()
        End If
        m_findkar.ActiveConnection = con_main
        m_findkar.Parameters.Item("_coka").Value = _coka
        rsfindkar.Open()
    End Sub
    Public Sub listorgan()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslistorgan.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistorgan.Close()
        End If
        m_listorgan.ActiveConnection = con_main
        rslistorgan.Open()
    End Sub
    Public Sub bdprintkar(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbdprintkar.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbdprintkar.Close()
        End If
        m_bdprintkar.ActiveConnection = con_main
        m_bdprintkar.Parameters.Item("_parm1").Value = _parm1
        rsbdprintkar.Open()
    End Sub
    Public Sub bdprint()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbdprint.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbdprint.Close()
        End If
        m_bdprint.ActiveConnection = con_main
        rsbdprint.Open()
    End Sub
    Public Sub findbdtakh(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindbdtakh.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindbdtakh.Close()
        End If
        m_findbdtakh.ActiveConnection = con_main
        m_findbdtakh.Parameters.Item("_parm1").Value = _parm1
        rsfindbdtakh.Open()
    End Sub
    Public Sub listbdtakh()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslistbdtakh.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistbdtakh.Close()
        End If
        m_listbdtakh.ActiveConnection = con_main
        rslistbdtakh.Open()
    End Sub
    Public Sub listcomp()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslistcomp.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistcomp.Close()
        End If
        m_listcomp.ActiveConnection = con_main
        rslistcomp.Open()
    End Sub
    Public Sub findcomp(ByVal _compcode As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindcomp.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindcomp.Close()
        End If
        m_findcomp.ActiveConnection = con_main
        m_findcomp.Parameters.Item("_compcode").Value = _compcode
        rsfindcomp.Open()
    End Sub
    Public Sub browdsus(ByVal _daro_code As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrowdsus.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowdsus.Close()
        End If
        m_browdsus.ActiveConnection = con_main
        m_browdsus.Parameters.Item("_daro_code").Value = _daro_code
        rsbrowdsus.Open()
    End Sub
    Public Sub findsus(ByVal _cath As String, ByVal _daro As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindsus.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindsus.Close()
        End If
        m_findsus.ActiveConnection = con_main
        m_findsus.Parameters.Item("_cath").Value = _cath
        m_findsus.Parameters.Item("_daro").Value = _daro
        rsfindsus.Open()
    End Sub
    Public Sub tanzim()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rstanzim.State = ADODB.ObjectStateEnum.adStateOpen Then
            rstanzim.Close()
        End If
        m_tanzim.ActiveConnection = con_main
        rstanzim.Open()
    End Sub
    Public Sub findsanad(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindsanad.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindsanad.Close()
        End If
        m_findsanad.ActiveConnection = con_main
        m_findsanad.Parameters.Item("_parm1").Value = _parm1
        rsfindsanad.Open()
    End Sub
    Public Sub brow_sanadriz(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrow_sanadriz.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrow_sanadriz.Close()
        End If
        m_brow_sanadriz.ActiveConnection = con_main
        m_brow_sanadriz.Parameters.Item("_parm1").Value = _parm1
        rsbrow_sanadriz.Open()
    End Sub
    Public Sub findcode(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindcode.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindcode.Close()
        End If
        m_findcode.ActiveConnection = con_main
        m_findcode.Parameters.Item("_parm1").Value = _parm1
        rsfindcode.Open()
    End Sub
    Public Sub listcode()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslistcode.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistcode.Close()
        End If
        m_listcode.ActiveConnection = con_main
        rslistcode.Open()
    End Sub
    Public Sub sanad()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rssanad.State = ADODB.ObjectStateEnum.adStateOpen Then
            rssanad.Close()
        End If
        m_sanad.ActiveConnection = con_main
        rssanad.Open()
    End Sub
    Public Sub showoldrem(ByVal _parm1 As String, ByVal _parm2 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsshowoldrem.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsshowoldrem.Close()
        End If
        m_showoldrem.ActiveConnection = con_main
        m_showoldrem.Parameters.Item("_parm1").Value = _parm1
        m_showoldrem.Parameters.Item("_parm2").Value = _parm2
        rsshowoldrem.Open()
    End Sub
    Public Sub brow_cardex(ByVal _parm1 As String, ByVal _parm2 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrow_cardex.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrow_cardex.Close()
        End If
        m_brow_cardex.ActiveConnection = con_main
        m_brow_cardex.Parameters.Item("_parm1").Value = _parm1
        m_brow_cardex.Parameters.Item("_parm2").Value = _parm2
        rsbrow_cardex.Open()
    End Sub
    Public Sub brow_tempriz(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrow_tempriz.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrow_tempriz.Close()
        End If
        m_brow_tempriz.ActiveConnection = con_main
        m_brow_tempriz.Parameters.Item("_parm1").Value = _parm1
        rsbrow_tempriz.Open()
    End Sub
    Public Sub brow_temp(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrow_temp.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrow_temp.Close()
        End If
        m_brow_temp.ActiveConnection = con_main
        m_brow_temp.Parameters.Item("_parm1").Value = _parm1
        rsbrow_temp.Open()
    End Sub
    Public Sub findkala(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindkala.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindkala.Close()
        End If
        m_findkala.ActiveConnection = con_main
        m_findkala.Parameters.Item("_parm1").Value = _parm1
        rsfindkala.Open()
    End Sub
    Public Sub show_phadetail1(ByVal _parm1 As String, ByVal _parm2 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsshow_phadetail1.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsshow_phadetail1.Close()
        End If
        m_show_phadetail1.ActiveConnection = con_main
        m_show_phadetail1.Parameters.Item("_parm1").Value = _parm1
        m_show_phadetail1.Parameters.Item("_parm2").Value = _parm2
        rsshow_phadetail1.Open()
    End Sub
    Public Sub browbank()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrowbank.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowbank.Close()
        End If
        m_browbank.ActiveConnection = con_main
        rsbrowbank.Open()
    End Sub
    Public Sub findbank(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindbank.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindbank.Close()
        End If
        m_findbank.ActiveConnection = con_main
        m_findbank.Parameters.Item("_parm1").Value = _parm1
        rsfindbank.Open()
    End Sub
    Public Sub shownumber(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsshownumber.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsshownumber.Close()
        End If
        m_shownumber.ActiveConnection = con_main
        m_shownumber.Parameters.Item("_parm1").Value = _parm1
        rsshownumber.Open()
    End Sub
    Public Sub brow_phanumber(ByVal _parm1 As String, ByVal _parm2 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrow_phanumber.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrow_phanumber.Close()
        End If
        m_brow_phanumber.ActiveConnection = con_main
        m_brow_phanumber.Parameters.Item("_parm1").Value = _parm1
        m_brow_phanumber.Parameters.Item("_parm2").Value = _parm2
        rsbrow_phanumber.Open()
    End Sub
    Public Sub Co1()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsCo1.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsCo1.Close()
        End If
        m_Co1.ActiveConnection = con_main
        rsCo1.Open()
    End Sub
    Public Sub listtemp(ByVal strsql As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslisttemp.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslisttemp.Close()
        End If
        m_listtemp.ActiveConnection = con_main
        m_listtemp.CommandText = strsql
        rslisttemp.Open()
    End Sub
    Public Sub listpay()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslistpay.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistpay.Close()
        End If
        m_listpay.ActiveConnection = con_main
        rslistpay.Open()
    End Sub
    Public Sub listdarof()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslistdarof.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistdarof.Close()
        End If
        m_listdarof.ActiveConnection = con_main
        rslistdarof.Open()
    End Sub
    Public Sub darocode5(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsdarocode5.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsdarocode5.Close()
        End If
        m_darocode5.ActiveConnection = con_main
        m_darocode5.Parameters.Item("_parm1").Value = _parm1
        rsdarocode5.Open()
    End Sub
    Public Sub listara()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslistara.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistara.Close()
        End If
        m_listara.ActiveConnection = con_main
        rslistara.Open()
    End Sub
    Public Sub listcardex(ByVal strsql As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslistcardex.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistcardex.Close()
        End If
        m_listcardex.ActiveConnection = con_main
        m_listcardex.CommandText = strsql
        rslistcardex.Open()
    End Sub
    Public Sub showdaro(ByVal StrSql As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsshowdaro.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsshowdaro.Close()
        End If
        m_showdaro.ActiveConnection = con_main
        m_showdaro.CommandText = StrSql

        rsshowdaro.Open()
    End Sub
    Public Sub showdarof()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsshowdarof.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsshowdarof.Close()
        End If
        m_showdarof.ActiveConnection = con_main
        rsshowdarof.Open()
    End Sub
    Public Sub brownprint()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrownprint.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrownprint.Close()
        End If
        m_brownprint.ActiveConnection = con_main
        rsbrownprint.Open()
    End Sub
    Public Sub findvcode(ByVal _parm1 As String, ByVal _parm2 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindvcode.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindvcode.Close()
        End If
        m_findvcode.ActiveConnection = con_main
        m_findvcode.Parameters.Item("_parm1").Value = _parm1
        m_findvcode.Parameters.Item("_parm2").Value = _parm2
        rsfindvcode.Open()
    End Sub
    Public Sub findpharma(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindpharma.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindpharma.Close()
        End If
        m_findpharma.ActiveConnection = con_main
        m_findpharma.Parameters.Item("_parm1").Value = _parm1
        rsfindpharma.Open()
    End Sub
    Public Sub pharmaname(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rspharmaname.State = ADODB.ObjectStateEnum.adStateOpen Then
            rspharmaname.Close()
        End If
        m_pharmaname.ActiveConnection = con_main
        m_pharmaname.Parameters.Item("_parm1").Value = _parm1
        rspharmaname.Open()
    End Sub
    Public Sub brow_ham(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrow_ham.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrow_ham.Close()
        End If
        m_brow_ham.ActiveConnection = con_main
        m_brow_ham.Parameters.Item("_parm1").Value = _parm1
        rsbrow_ham.Open()
    End Sub
    Public Sub brow_same(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrow_same.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrow_same.Close()
        End If
        m_brow_same.ActiveConnection = con_main
        m_brow_same.Parameters.Item("_parm1").Value = _parm1
        rsbrow_same.Open()
    End Sub
    Public Sub eslami(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rseslami.State = ADODB.ObjectStateEnum.adStateOpen Then
            rseslami.Close()
        End If
        m_eslami.ActiveConnection = con_main
        m_eslami.Parameters.Item("_parm1").Value = _parm1
        rseslami.Open()
    End Sub
    Public Sub findnos(ByVal _parm1 As String, ByVal _parm2 As String, ByVal _parm3 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindnos.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindnos.Close()
        End If
        m_findnos.ActiveConnection = con_main
        m_findnos.Parameters.Item("_parm1").Value = _parm1
        m_findnos.Parameters.Item("_parm2").Value = _parm2
        m_findnos.Parameters.Item("_parm3").Value = _parm3
        rsfindnos.Open()
    End Sub
    Public Sub findbim(ByVal _bimeh As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindbim.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindbim.Close()
        End If
        m_findbim.ActiveConnection = con_main
        m_findbim.Parameters.Item("_bimeh").Value = _bimeh
        rsfindbim.Open()
    End Sub
    Public Sub findbimname(ByVal _name As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindbimname.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindbimname.Close()
        End If
        m_findbimname.ActiveConnection = con_main
        m_findbimname.Parameters.Item("_name").Value = _name
        rsfindbimname.Open()
    End Sub
    Public Sub browcond(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrowcond.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowcond.Close()
        End If
        m_browcond.ActiveConnection = con_main
        m_browcond.Parameters.Item("_parm1").Value = _parm1
        rsbrowcond.Open()
    End Sub
    Public Sub browspmot(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrowspmot.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowspmot.Close()
        End If
        m_browspmot.ActiveConnection = con_main
        m_browspmot.Parameters.Item("_parm1").Value = _parm1
        rsbrowspmot.Open()
    End Sub
    Public Sub findcond(ByVal _parm1 As String, ByVal _parm2 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindcond.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindcond.Close()
        End If
        m_findcond.ActiveConnection = con_main
        m_findcond.Parameters.Item("_parm1").Value = _parm1
        m_findcond.Parameters.Item("_parm2").Value = _parm2
        rsfindcond.Open()
    End Sub
    Public Sub findspmot(ByVal _daro As String, ByVal _tkhs As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindspmot.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindspmot.Close()
        End If
        m_findspmot.ActiveConnection = con_main
        m_findspmot.Parameters.Item("_daro").Value = _daro
        m_findspmot.Parameters.Item("_tkhs").Value = _tkhs
        rsfindspmot.Open()
    End Sub
    Public Sub darovir(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsdarovir.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsdarovir.Close()
        End If
        m_darovir.ActiveConnection = con_main
        m_darovir.Parameters.Item("_parm1").Value = _parm1
        rsdarovir.Open()
    End Sub
    Public Sub browvir()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrowvir.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowvir.Close()
        End If
        m_browvir.ActiveConnection = con_main
        rsbrowvir.Open()
    End Sub
    Public Sub browallnos(ByVal strsql As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrowallnos.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowallnos.Close()
        End If
        m_browallnos.ActiveConnection = con_main
        m_browallnos.CommandText = strsql
        rsbrowallnos.Open()
    End Sub
    Public Sub findnprint(ByVal _nprint As String, ByVal _sizetip As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindnprint.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindnprint.Close()
        End If
        m_findnprint.ActiveConnection = con_main
        m_findnprint.Parameters.Item("_nprint").Value = _nprint
        m_findnprint.Parameters.Item("_sizetip").Value = _sizetip
        rsfindnprint.Open()
    End Sub
    Public Sub browhj()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrowhj.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowhj.Close()
        End If
        m_browhj.ActiveConnection = con_main
        rsbrowhj.Open()
    End Sub
    Public Sub findcode6(ByVal _code6 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindcode6.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindcode6.Close()
        End If
        m_findcode6.ActiveConnection = con_main
        m_findcode6.Parameters.Item("_code6").Value = _code6
        rsfindcode6.Open()
    End Sub
    Public Sub browallnos1(ByVal _date As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrowallnos1.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowallnos1.Close()
        End If
        m_browallnos1.ActiveConnection = con_main
        m_browallnos1.Parameters.Item("_date").Value = _date
        rsbrowallnos1.Open()
    End Sub
    Public Sub browfkey()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrowfkey.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowfkey.Close()
        End If
        m_browfkey.ActiveConnection = con_main
        rsbrowfkey.Open()
    End Sub
    Public Sub accname(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsaccname.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsaccname.Close()
        End If
        m_accname.ActiveConnection = con_main
        m_accname.Parameters.Item("_parm1").Value = _parm1
        rsaccname.Open()
    End Sub
    Public Sub listdarocond(ByVal strsql As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslistdarocond.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistdarocond.Close()
        End If
        m_listdarocond.ActiveConnection = con_main
        m_listdarocond.CommandText = strsql
        rslistdarocond.Open()
    End Sub
    Public Sub findcode5(ByVal _code5 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindcode5.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindcode5.Close()
        End If
        m_findcode5.ActiveConnection = con_main
        m_findcode5.Parameters.Item("_code5").Value = _code5
        rsfindcode5.Open()
    End Sub
    Public Sub findiokala(ByVal _parm1 As String, ByVal _parm2 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindiokala.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindiokala.Close()
        End If
        m_findiokala.ActiveConnection = con_main
        m_findiokala.Parameters.Item("_parm1").Value = _parm1
        m_findiokala.Parameters.Item("_parm2").Value = _parm2
        rsfindiokala.Open()
    End Sub
    Public Sub browdaro()
        If conupdate.State = ADODB.ObjectStateEnum.adStateClosed Then
            conupdate.Open()
        End If
        If rsbrowdaro.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowdaro.Close()
        End If
        m_browdaro.ActiveConnection = conupdate
        rsbrowdaro.Open()
    End Sub
    Public Sub showdaro6()
        If conupdate.State = ADODB.ObjectStateEnum.adStateClosed Then
            conupdate.Open()
        End If
        If rsshowdaro6.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsshowdaro6.Close()
        End If
        m_showdaro6.ActiveConnection = conupdate
        rsshowdaro6.Open()
    End Sub
    Public Sub fcode6(ByVal _p1 As String)
        If conupdate.State = ADODB.ObjectStateEnum.adStateClosed Then
            conupdate.Open()
        End If
        If rsfcode6.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfcode6.Close()
        End If
        m_fcode6.ActiveConnection = conupdate
        m_fcode6.Parameters.Item("_p1").Value = _p1
        rsfcode6.Open()
    End Sub
    Public Sub fc6(ByVal _p1 As String)
        If conupdate.State = ADODB.ObjectStateEnum.adStateClosed Then
            conupdate.Open()
        End If
        If rsfc6.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfc6.Close()
        End If
        m_fc6.ActiveConnection = conupdate
        m_fc6.Parameters.Item("_p1").Value = _p1
        rsfc6.Open()
    End Sub
    Public Sub der()
        If conupdate.State = ADODB.ObjectStateEnum.adStateClosed Then
            conupdate.Open()
        End If
        If rsder.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsder.Close()
        End If
        m_der.ActiveConnection = conupdate
        rsder.Open()
    End Sub
    Public Sub upddaro()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsupddaro.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsupddaro.Close()
        End If
        m_upddaro.ActiveConnection = con_main
        rsupddaro.Open()
    End Sub
    Public Sub updnos()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsupdnos.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsupdnos.Close()
        End If
        m_updnos.ActiveConnection = con_main
        rsupdnos.Open()
    End Sub
    Public Sub updcond()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsupdcond.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsupdcond.Close()
        End If
        m_updcond.ActiveConnection = con_main
        rsupdcond.Open()
    End Sub
    Public Sub tanzimhesab()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rstanzimhesab.State = ADODB.ObjectStateEnum.adStateOpen Then
            rstanzimhesab.Close()
        End If
        m_tanzimhesab.ActiveConnection = con_main
        rstanzimhesab.Open()
    End Sub
    Public Sub browasnad()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrowasnad.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowasnad.Close()
        End If
        m_browasnad.ActiveConnection = con_main
        rsbrowasnad.Open()
    End Sub
    Public Sub tamin(ByVal _p1 As String)
        If conupdate.State = ADODB.ObjectStateEnum.adStateClosed Then
            conupdate.Open()
        End If
        If rstamin.State = ADODB.ObjectStateEnum.adStateOpen Then
            rstamin.Close()
        End If
        m_tamin.ActiveConnection = conupdate
        m_tamin.Parameters.Item("_p1").Value = _p1
        rstamin.Open()
    End Sub
    Public Sub browotc()
        If conupdate.State = ADODB.ObjectStateEnum.adStateClosed Then
            conupdate.Open()
        End If
        If rsbrowotc.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowotc.Close()
        End If
        m_browotc.ActiveConnection = conupdate
        rsbrowotc.Open()
    End Sub
    Public Sub listpaz()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslistpaz.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistpaz.Close()
        End If
        m_listpaz.ActiveConnection = con_main
        rslistpaz.Open()
    End Sub
    Public Sub ListNos()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsListNos.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsListNos.Close()
        End If
        m_ListNos.ActiveConnection = con_main
        rsListNos.Open()
    End Sub
    Public Sub ListRoutine()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsListRoutine.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsListRoutine.Close()
        End If
        m_ListRoutine.ActiveConnection = con_main
        rsListRoutine.Open()
    End Sub
    Public Sub BrowRoutine(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsBrowRoutine.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsBrowRoutine.Close()
        End If
        m_BrowRoutine.ActiveConnection = con_main
        m_BrowRoutine.Parameters.Item("_parm1").Value = _parm1
        rsBrowRoutine.Open()
    End Sub
    Public Sub ShowRoutine(ByVal strsql As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsShowRoutine.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsShowRoutine.Close()
        End If
        m_ShowRoutine.ActiveConnection = con_main
        m_ShowRoutine.CommandText = strsql
        rsShowRoutine.Open()
    End Sub
    Public Sub ShowPrintDastur(ByVal strsql As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsShowPrintDastur.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsShowPrintDastur.Close()
        End If
        m_ShowPrintDastur.ActiveConnection = con_main
        m_ShowPrintDastur.CommandText = strsql
        rsShowPrintDastur.Open()
    End Sub
    Public Sub RptDaro(ByVal strsql As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsRptDaro.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsRptDaro.Close()
        End If
        m_RptDaro.ActiveConnection = con_main
        m_RptDaro.CommandText = strsql
        rsRptDaro.Open()
    End Sub
    Public Sub mynetwork(ByVal _mynom As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsmynetwork.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsmynetwork.Close()
        End If
        m_mynetwork.ActiveConnection = con_main
        m_mynetwork.Parameters.Item("_mynom").Value = _mynom
        rsmynetwork.Open()
    End Sub
    Public Sub DelMyNetwork(ByVal _par1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsDelMyNetwork.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsDelMyNetwork.Close()
        End If
        m_DelMyNetwork.ActiveConnection = con_main
        m_DelMyNetwork.Parameters.Item("_par1").Value = _par1
        rsDelMyNetwork.Open()
    End Sub
    Public Sub UpdCath()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsUpdCath.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsUpdCath.Close()
        End If
        m_UpdCath.ActiveConnection = con_main
        rsUpdCath.Open()
    End Sub
    Public Sub ListNprint()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsListNprint.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsListNprint.Close()
        End If
        m_ListNprint.ActiveConnection = con_main
        rsListNprint.Open()
    End Sub
    Public Sub ListMoney(ByVal strsql As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsListMoney.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsListMoney.Close()
        End If
        m_ListMoney.ActiveConnection = con_main
        m_ListMoney.CommandText = strsql
        rsListMoney.Open()
    End Sub
    Public Sub FindMoney(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsFindMoney.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsFindMoney.Close()
        End If
        m_FindMoney.ActiveConnection = con_main
        m_FindMoney.Parameters.Item("_parm1").Value = _parm1
        rsFindMoney.Open()
    End Sub
    Public Sub Findvcode1(ByVal _parm1 As String, ByVal _parm2 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsFindvcode1.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsFindvcode1.Close()
        End If
        m_Findvcode1.ActiveConnection = con_main
        m_Findvcode1.Parameters.Item("_parm1").Value = _parm1
        m_Findvcode1.Parameters.Item("_parm2").Value = _parm2
        rsFindvcode1.Open()
    End Sub
    Public Sub ListVcode(ByVal strsql As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsListVcode.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsListVcode.Close()
        End If
        m_ListVcode.ActiveConnection = con_main
        m_ListVcode.CommandText = strsql
        rsListVcode.Open()
    End Sub
    Public Sub ListMyCath()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsListMyCath.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsListMyCath.Close()
        End If
        m_ListMyCath.ActiveConnection = con_main
        rsListMyCath.Open()
    End Sub
    Public Sub h11cop()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsh11cop.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsh11cop.Close()
        End If
        m_h11cop.ActiveConnection = con_main
        rsh11cop.Open()
    End Sub
    Public Sub factor(ByVal SqlStr As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfactor.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfactor.Close()
        End If
        m_factor.ActiveConnection = con_main

        m_factor.CommandText = SqlStr
        rsfactor.Open()
    End Sub
    Public Sub MyphaDetail()
        If conupdate.State = ADODB.ObjectStateEnum.adStateClosed Then
            conupdate.Open()
        End If
        If rsMyphaDetail.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsMyphaDetail.Close()
        End If
        m_MyphaDetail.ActiveConnection = conupdate
        rsMyphaDetail.Open()
    End Sub
    Public Sub MyPhaDnos()
        If conupdate.State = ADODB.ObjectStateEnum.adStateClosed Then
            conupdate.Open()
        End If
        If rsMyPhaDnos.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsMyPhaDnos.Close()
        End If
        m_MyPhaDnos.ActiveConnection = conupdate
        rsMyPhaDnos.Open()
    End Sub
    Public Sub listdaroCond1(ByVal strsql As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslistdaroCond1.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistdaroCond1.Close()
        End If
        m_listdaroCond1.ActiveConnection = con_main
        m_listdaroCond1.CommandText = strsql
        rslistdaroCond1.Open()
    End Sub
    Public Sub brow_MyCardex(ByVal _parm1 As String, ByVal _parm2 As String, ByVal _parm3 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrow_MyCardex.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrow_MyCardex.Close()
        End If
        m_brow_MyCardex.ActiveConnection = con_main
        m_brow_MyCardex.Parameters.Item("_parm1").Value = _parm1
        m_brow_MyCardex.Parameters.Item("_parm2").Value = _parm2
        m_brow_MyCardex.Parameters.Item("_parm3").Value = _parm3
        rsbrow_MyCardex.Open()
    End Sub
    Public Sub mydoc()
        If conupdate.State = ADODB.ObjectStateEnum.adStateClosed Then
            conupdate.Open()
        End If
        If rsmydoc.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsmydoc.Close()
        End If
        m_mydoc.ActiveConnection = conupdate
        rsmydoc.Open()
    End Sub
    Public Sub listcardex9()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslistcardex9.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistcardex9.Close()
        End If
        m_listcardex9.ActiveConnection = con_main
        rslistcardex9.Open()
    End Sub
    Public Sub InsMyCardex()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsInsMyCardex.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsInsMyCardex.Close()
        End If
        m_InsMyCardex.ActiveConnection = con_main
        rsInsMyCardex.Open()
    End Sub
    Public Sub Rtdaro()
        If Connection1.State = ADODB.ObjectStateEnum.adStateClosed Then
            Connection1.Open()
        End If
        If rsRtdaro.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsRtdaro.Close()
        End If
        m_Rtdaro.ActiveConnection = Connection1
        rsRtdaro.Open()
    End Sub
    Public Sub browTdaro()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrowTdaro.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowTdaro.Close()
        End If
        m_browTdaro.ActiveConnection = con_main
        rsbrowTdaro.Open()
    End Sub
    Public Sub browall1(ByVal strsql As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrowall1.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowall1.Close()
        End If
        m_browall1.ActiveConnection = con_main
        m_browall1.CommandText = strsql
        rsbrowall1.Open()
    End Sub
    Public Sub findbarcode(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindbarcode.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindbarcode.Close()
        End If
        m_findbarcode.ActiveConnection = con_main
        m_findbarcode.Parameters.Item("_parm1").Value = _parm1
        rsfindbarcode.Open()
    End Sub
    Public Sub findUser(ByVal _parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindUser.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindUser.Close()
        End If
        m_findUser.ActiveConnection = con_main
        m_findUser.Parameters.Item("_parm1").Value = _parm1
        rsfindUser.Open()
    End Sub
    Public Sub UpdateNezam()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsUpdateNezam.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsUpdateNezam.Close()
        End If
        m_UpdateNezam.ActiveConnection = con_main
        rsUpdateNezam.Open()
    End Sub
    Public Sub showRadif(ByVal _p1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsshowRadif.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsshowRadif.Close()
        End If
        m_showRadif.ActiveConnection = con_main
        m_showRadif.Parameters.Item("_p1").Value = _p1
        rsshowRadif.Open()
    End Sub
    Public Sub ShowNumberCath(ByVal _p1 As String, ByVal _p2 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsShowNumberCath.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsShowNumberCath.Close()
        End If
        m_ShowNumberCath.ActiveConnection = con_main
        m_ShowNumberCath.Parameters.Item("_p1").Value = _p1
        m_ShowNumberCath.Parameters.Item("_p2").Value = _p2
        rsShowNumberCath.Open()
    End Sub
    Public Sub ListNumbercath(ByVal _p1 As String, ByVal _p2 As String, ByVal _p3 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsListNumbercath.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsListNumbercath.Close()
        End If
        m_ListNumbercath.ActiveConnection = con_main
        m_ListNumbercath.Parameters.Item("_p1").Value = _p1
        m_ListNumbercath.Parameters.Item("_p2").Value = _p2
        m_ListNumbercath.Parameters.Item("_p3").Value = _p3
        rsListNumbercath.Open()
    End Sub
    Public Sub BarCodeBrow(ByVal parm1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsBarCodeBrow.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsBarCodeBrow.Close()
        End If
        m_BarCodeBrow.ActiveConnection = con_main
        m_BarCodeBrow.Parameters.Item("parm1").Value = parm1
        rsBarCodeBrow.Open()
    End Sub
    Public Sub BarCodeFind(ByVal _p1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsBarCodeFind.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsBarCodeFind.Close()
        End If
        m_BarCodeFind.ActiveConnection = con_main
        m_BarCodeFind.Parameters.Item("_p1").Value = _p1
        rsBarCodeFind.Open()
    End Sub
    Public Sub BarCodeDel(ByVal strsql As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsBarCodeDel.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsBarCodeDel.Close()
        End If
        m_BarCodeDel.ActiveConnection = con_main
        m_BarCodeDel.CommandText = strsql
        rsBarCodeDel.Open()
    End Sub
    Public Sub Browmasraf(ByVal strsql As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsBrowmasraf.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsBrowmasraf.Close()
        End If
        m_Browmasraf.ActiveConnection = con_main
        m_Browmasraf.CommandText = strsql
        rsBrowmasraf.Open()
    End Sub
    Public Sub FindSMOT(ByVal _p1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsFindSMOT.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsFindSMOT.Close()
        End If
        m_FindSMOT.ActiveConnection = con_main
        m_FindSMOT.Parameters.Item("_p1").Value = _p1
        rsFindSMOT.Open()
    End Sub
    Public Sub browtakh()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsbrowtakh.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsbrowtakh.Close()
        End If
        m_browtakh.ActiveConnection = con_main
        rsbrowtakh.Open()
    End Sub
    Public Sub DaroSpCath(ByVal _p1 As String, ByVal _p2 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsDaroSpCath.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsDaroSpCath.Close()
        End If
        m_DaroSpCath.ActiveConnection = con_main
        m_DaroSpCath.Parameters.Item("_p1").Value = _p1
        m_DaroSpCath.Parameters.Item("_p2").Value = _p2
        rsDaroSpCath.Open()
    End Sub
    Public Sub SumCardexdaro(ByVal _p1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsSumCardexdaro.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsSumCardexdaro.Close()
        End If
        m_SumCardexdaro.ActiveConnection = con_main
        m_SumCardexdaro.Parameters.Item("_p1").Value = _p1
        rsSumCardexdaro.Open()
    End Sub
    Public Sub listType1()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslistType1.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistType1.Close()
        End If
        m_listType1.ActiveConnection = con_main
        rslistType1.Open()
    End Sub
    Public Sub FindType(ByVal _p1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsFindType.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsFindType.Close()
        End If
        m_FindType.ActiveConnection = con_main
        m_FindType.Parameters.Item("_p1").Value = _p1
        rsFindType.Open()
    End Sub
    Public Sub listTash()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslistTash.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistTash.Close()
        End If
        m_listTash.ActiveConnection = con_main
        rslistTash.Open()
    End Sub
    Public Sub findTash(ByVal _p1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsfindTash.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsfindTash.Close()
        End If
        m_findTash.ActiveConnection = con_main
        m_findTash.Parameters.Item("_p1").Value = _p1
        rsfindTash.Open()
    End Sub
    Public Sub listkala()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rslistkala.State = ADODB.ObjectStateEnum.adStateOpen Then
            rslistkala.Close()
        End If
        m_listkala.ActiveConnection = con_main
        rslistkala.Open()
    End Sub
    Public Sub delCardex(ByVal SqlStr As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsdelCardex.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsdelCardex.Close()
        End If
        m_delCardex.ActiveConnection = con_main
        m_delCardex.CommandText = SqlStr
        rsdelCardex.Open()
    End Sub
    Public Sub SumCardex(ByVal _cokm As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsSumCardex.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsSumCardex.Close()
        End If
        m_SumCardex.ActiveConnection = con_main
        m_SumCardex.Parameters.Item("_cokm").Value = _cokm
        rsSumCardex.Open()
    End Sub
    Public Sub BrowFam()
        If ConOracle.State = ADODB.ObjectStateEnum.adStateClosed Then
            ConOracle.Open()
        End If
        If rsBrowFam.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsBrowFam.Close()
        End If
        m_BrowFam.ActiveConnection = ConOracle
        rsBrowFam.Open()
    End Sub
    Public Sub ListCompany()
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsListCompany.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsListCompany.Close()
        End If
        m_ListCompany.ActiveConnection = con_main
        rsListCompany.Open()
    End Sub
    Public Sub FindCompany(ByVal _p1 As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsFindCompany.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsFindCompany.Close()
        End If
        m_FindCompany.ActiveConnection = con_main
        m_FindCompany.Parameters.Item("_p1").Value = _p1
        rsFindCompany.Open()
    End Sub
    Public Sub BrowSpFani(ByVal strsql As String)
        If con_main.State = ADODB.ObjectStateEnum.adStateClosed Then
            con_main.Open()
        End If
        If rsBrowSpFani.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsBrowSpFani.Close()
        End If
        m_BrowSpFani.ActiveConnection = con_main
        m_BrowSpFani.CommandText = strsql
        rsBrowSpFani.Open()
    End Sub


    Private Sub con_fox_InfoMessage(ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pConnection As ADODB.Connection)

    End Sub
End Class