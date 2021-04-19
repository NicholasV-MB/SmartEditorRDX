Imports System
Imports System.Collections
Imports System.Reflection
Imports RuleDesigner.Configurator.Core.RDCoreCompiler
Imports RuleDesigner.Configurator.Core.RDCoreCompiler.CompilerUtil
Imports RuleDesigner.Configurator.Core.RDCoreCompiler.BasicFunctionsProxy

Public Module GlobalScope

    Public _CurrentNode As String = ""
    Public _ExitTarget As String = ""
    Public _ActionResult As ActionResult = Nothing

    Public ReadOnly Property _Main() As RDCompiledProcess
        Get
            Return CompiledProcessMain
        End Get
    End Property

    Public ReadOnly Property _Param() As RDFunctionParam
        Get
            Return CompiledProcessState.ParamVar
        End Get
    End Property

    Public ReadOnly Property _Me() As Object
        Get
            Return CompiledProcessState.MeVar
        End Get
    End Property

End Module

Public Class RDCompiledProcess
    Implements IRDCompiledProcess

#Region " --- STANDARD INFRASTRUCTURE "

    Public ReadOnly Property StaticExpressionsType As Type Implements IRDCompiledProcess.StaticExpressionsType
        Get
            Return GetType(StaticExpressions)
        End Get
    End Property

    Public ReadOnly Property GlobalVarsType As Type Implements IRDCompiledProcess.GlobalVarsType
        Get
            Return GetType(GlobalVars)
        End Get
    End Property

    'Public ReadOnly Property GetDLL As String Implements IRDCompiledProcess.GetDLL
    '    Get
    '        Return Assembly.GetExecutingAssembly().Location
    '    End Get
    'End Property

<RuleDesignerAttribute(IsSystem:=True)>
    Public Sub Main(ByVal Parameters As Generic.List(Of RDParamValue)) Implements IRDCompiledProcess.Main
        Try
			'Recompile removing this comment to debug in VisualStudio
			'Debugger.Launch
			''''
10:         CompilerUtil.ClearGlobalVars(Me)
30:         CompilerUtil.SetInputParameters(Me, Parameters)
			''''
40:         Call ProcessMain()
			''''
50:         CompilerUtil.SetOutputParameters(Me, Parameters)
60:         CompilerUtil.CheckExitTarget(_ExitTarget)
			''''
        Catch ex As Exception
			if _CurrentNode <> "" then
				CompilerUtil.RaiseException(_CurrentNode, ex)
			else
				CompilerUtil.RaiseException(ex.Message)
			end if
        End Try
    End Sub

#End Region

#Region " --- PROCESS DECLARATIONS "

    Private Sub ProcessMain()


        'CALL TO MAIN PROCESS
        Call Main_Group_K_0008()

    End Sub

#Region " --- PROCESS FUNCTIONS TABLE "



#End Region

#End Region

#Region " --- PROCESS CODE TABLE "

	'Main Group *LOG_DISABLED
	Private Sub Main_Group_K_0008()
		_CurrentNode = "RDK:0008"
		'InsertTreni
		Call InsertTreni_K_52()
		If CompilerUtil.MustReturnToCaller(_ExitTarget,false) Then Return

	End Sub

	'InsertTreni
	Private Sub InsertTreni_K_52()
		_CurrentNode = "RDK:52"
		'Set iCol = 1
		_CurrentNode = "RDK:368"
		iCol = EvalConstant(iCol.GetType, "1")
		
		'SetStruct myShapeListOUT <-- CampataShapeIN = Campata|ServiceLibrary||CreateGUID()|Campata|||XPos|YPos|0|LunghezzaCampat... (237 chars)
		_CurrentNode = "RDK:392"
		CampataShapeIN = new Editor2DShapeType
		With CampataShapeIN
			.source = "Campata"
			.sourceLibrary = "ServiceLibrary"
			.id = EvalExpression("id_K_392")
			.name = "Campata"
			.x = EvalExpression("x_K_392")
			.y = EvalExpression("y_K_392")
			.z = 0
			.width = EvalExpression("width_K_392")
			.height = EvalExpression("height_K_392")
			.depth = EvalExpression("depth_K_392")
			.Livelli = EvalExpression("Livelli_K_392")
			.AltezzeLivelli = EvalExpression("AltezzeLivelli_K_392")
			.NomeTreno = EvalExpression("NomeTreno_K_392")
			.NumeroCampata = 1
		End With
		myShapeListOUT.Add(CampataShapeIN)
		
		'While iCol<=NumeroTreni is True
		Call WHILELOOP_K_372()
		If CompilerUtil.MustReturnToCaller(_ExitTarget,true) Then Return

		'Fine InsertTreni
		Call Fine_InsertTreni_K_51()
		If CompilerUtil.MustReturnToCaller(_ExitTarget,false) Then Return

	End Sub

	'While iCol<=NumeroTreni is True
	Private Sub WHILELOOP_K_372()
next_iteration:
		_CurrentNode = "RDK:372"
		'Group Conditions
		Dim _GroupExecute As Boolean = EvalExpression("CondExp1_K_372")
exec_group:
'----------------------------------------------------
		if not _GroupExecute then return
		
		'Set iRow = 2
		_CurrentNode = "RDK:41"
		iRow = EvalConstant(iRow.GetType, "2")
		
		'While iRow<=CampateXTreno is True
		Call WHILELOOP_K_49()
		If CompilerUtil.MustReturnToCaller(_ExitTarget,true) Then Return

		'Set YPos = CampataShapeNew.y +ProfonditàCampate+ DistanzaTraTreni
		_CurrentNode = "RDK:385"
		YPos = EvalExpression("Set_YPos_K_385")
		
		'Set iCol = iCol+1
		_CurrentNode = "RDK:398"
		iCol = EvalExpression("Set_iCol_K_398")
		
		'Group <iCol<=NumeroTreni is True>
		Call Group_K_418()
		If CompilerUtil.MustReturnToCaller(_ExitTarget,false) Then Return
		If CompilerUtil.MustDoNextIteration(_ExitTarget) Then goto next_iteration

		goto next_iteration
	End Sub

	'While iRow<=CampateXTreno is True
	Private Sub WHILELOOP_K_49()
next_iteration:
		_CurrentNode = "RDK:49"
		'Group Conditions
		Dim _GroupExecute As Boolean = EvalExpression("CondExp1_K_49")
exec_group:
'----------------------------------------------------
		if not _GroupExecute then return
		
		'SetStruct myShapeListOUT <-- CampataShapeNew = CampataShapeIN.source|CampataShapeIN.sourceLibrary||CreateGUID()|CampataS... (384 chars)
		_CurrentNode = "RDK:358"
		CampataShapeNew = new Editor2DShapeType
		With CampataShapeNew
			.source = EvalExpression("source_K_358")
			.sourceLibrary = EvalExpression("sourceLibrary_K_358")
			.id = EvalExpression("id_K_358")
			.name = EvalExpression("name_K_358")
			.family = EvalExpression("family_K_358")
			.description = EvalExpression("description_K_358")
			.x = EvalExpression("x_K_358")
			.y = EvalExpression("y_K_358")
			.z = EvalExpression("z_K_358")
			.width = EvalExpression("width_K_358")
			.height = EvalExpression("height_K_358")
			.depth = EvalExpression("depth_K_358")
			.Livelli = EvalExpression("Livelli_K_358")
			.AltezzeLivelli = EvalExpression("AltezzeLivelli_K_358")
			.NomeTreno = EvalExpression("NomeTreno_K_358")
			.NumeroCampata = EvalExpression("NumeroCampata_K_358")
		End With
		myShapeListOUT.Add(CampataShapeNew)
		
		'SetStruct myShapeListOUT <-- myShapeLink = link-line|ServiceLibrary||CreateGUID()|||||||||||||||||||CampataShapeNew.id|c... (144 chars)
		_CurrentNode = "RDK:352"
		myShapeLink = new Editor2DShapeType
		With myShapeLink
			.source = "link-line"
			.sourceLibrary = "ServiceLibrary"
			.id = EvalExpression("id_K_352")
			.shapeFromId = EvalExpression("shapeFromId_K_352")
			.shapeFromPointIndex = "cp1"
			.shapeToId = EvalExpression("shapeToId_K_352")
			.shapeToPointIndex = "cp2"
		End With
		myShapeListOUT.Add(myShapeLink)
		
		'Set CampataShapeIN = CampataShapeNew
		_CurrentNode = "RDK:47"
		CampataShapeIN = EvalExpression("Set_CampataShapeIN_K_47")
		
		'Set iRow = iRow+1
		_CurrentNode = "RDK:48"
		iRow = EvalExpression("Set_iRow_K_48")
		
		goto next_iteration
	End Sub

	'Group <iCol<=NumeroTreni is True>
	Private Sub Group_K_418()
		_CurrentNode = "RDK:418"
		'Group Conditions
		Dim _GroupExecute As Boolean = EvalExpression("CondExp1_K_418")
exec_group:
'----------------------------------------------------
		if not _GroupExecute then return
		'SetStruct myShapeListOUT <-- CampataShapeIN = Campata|ServiceLibrary||CreateGUID()|Campata|||XPos|YPos|0|LunghezzaCampat... (237 chars)
		_CurrentNode = "RDK:424"
		CampataShapeIN = new Editor2DShapeType
		With CampataShapeIN
			.source = "Campata"
			.sourceLibrary = "ServiceLibrary"
			.id = EvalExpression("id_K_424")
			.name = "Campata"
			.x = EvalExpression("x_K_424")
			.y = EvalExpression("y_K_424")
			.z = 0
			.width = EvalExpression("width_K_424")
			.height = EvalExpression("height_K_424")
			.depth = EvalExpression("depth_K_424")
			.Livelli = EvalExpression("Livelli_K_424")
			.AltezzeLivelli = EvalExpression("AltezzeLivelli_K_424")
			.NomeTreno = EvalExpression("NomeTreno_K_424")
			.NumeroCampata = 1
		End With
		myShapeListOUT.Add(CampataShapeIN)
		
	End Sub

	'Fine InsertTreni
	Private Sub Fine_InsertTreni_K_51()
		_CurrentNode = "RDK:51"
	End Sub



#End Region

End Class
