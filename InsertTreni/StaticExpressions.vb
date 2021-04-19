Imports System
Imports System.Collections
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports RuleDesigner.Configurator.Core.RDCoreCompiler.BasicFunctionsProxy

Module StaticExpressions

    'This placeholder is for static expression table
	'OriginalExpression: 'CreateGUID()
	<Extension()>
	Public Function Eval_Static_id_K_392(ByVal Main As RDCompiledProcess) As Object
		return CreateGUID()
	End Function

	'OriginalExpression: 'XPos
	<Extension()>
	Public Function Eval_Static_x_K_392(ByVal Main As RDCompiledProcess) As Object
		return XPos
	End Function

	'OriginalExpression: 'YPos
	<Extension()>
	Public Function Eval_Static_y_K_392(ByVal Main As RDCompiledProcess) As Object
		return YPos
	End Function

	'OriginalExpression: 'LunghezzaCampate
	<Extension()>
	Public Function Eval_Static_width_K_392(ByVal Main As RDCompiledProcess) As Object
		return LunghezzaCampate
	End Function

	'OriginalExpression: 'ProfonditàCampate
	<Extension()>
	Public Function Eval_Static_height_K_392(ByVal Main As RDCompiledProcess) As Object
		return ProfonditàCampate
	End Function

	'OriginalExpression: 'AltezzaCampate
	<Extension()>
	Public Function Eval_Static_depth_K_392(ByVal Main As RDCompiledProcess) As Object
		return AltezzaCampate
	End Function

	'OriginalExpression: 'Livelli
	<Extension()>
	Public Function Eval_Static_Livelli_K_392(ByVal Main As RDCompiledProcess) As Object
		return Livelli
	End Function

	'OriginalExpression: 'AltezzeLivelli
	<Extension()>
	Public Function Eval_Static_AltezzeLivelli_K_392(ByVal Main As RDCompiledProcess) As Object
		return AltezzeLivelli
	End Function

	'OriginalExpression: '"Treno_"+IntToStr(iCol)
	<Extension()>
	Public Function Eval_Static_NomeTreno_K_392(ByVal Main As RDCompiledProcess) As Object
		return "Treno_"+IntToStr(iCol)
	End Function

	'Condition for group WHILE
	'OriginalExpression: 'iCol<=NumeroTreni
	<Extension()>
	Public Function Eval_Static_CondExp1_K_372(ByVal Main As RDCompiledProcess) As Object
		return iCol<=NumeroTreni
	End Function

	'Condition for group WHILE
	'OriginalExpression: 'iRow<=CampateXTreno
	<Extension()>
	Public Function Eval_Static_CondExp1_K_49(ByVal Main As RDCompiledProcess) As Object
		return iRow<=CampateXTreno
	End Function

	'OriginalExpression: 'CampataShapeIN.source
	<Extension()>
	Public Function Eval_Static_source_K_358(ByVal Main As RDCompiledProcess) As Object
		return CampataShapeIN.source
	End Function

	'OriginalExpression: 'CampataShapeIN.sourceLibrary
	<Extension()>
	Public Function Eval_Static_sourceLibrary_K_358(ByVal Main As RDCompiledProcess) As Object
		return CampataShapeIN.sourceLibrary
	End Function

	'OriginalExpression: 'CreateGUID()
	<Extension()>
	Public Function Eval_Static_id_K_358(ByVal Main As RDCompiledProcess) As Object
		return CreateGUID()
	End Function

	'OriginalExpression: 'CampataShapeIN.name
	<Extension()>
	Public Function Eval_Static_name_K_358(ByVal Main As RDCompiledProcess) As Object
		return CampataShapeIN.name
	End Function

	'OriginalExpression: 'CampataShapeIN.family
	<Extension()>
	Public Function Eval_Static_family_K_358(ByVal Main As RDCompiledProcess) As Object
		return CampataShapeIN.family
	End Function

	'OriginalExpression: 'CampataShapeIN.description
	<Extension()>
	Public Function Eval_Static_description_K_358(ByVal Main As RDCompiledProcess) As Object
		return CampataShapeIN.description
	End Function

	'OriginalExpression: 'XPos
	<Extension()>
	Public Function Eval_Static_x_K_358(ByVal Main As RDCompiledProcess) As Object
		return XPos
	End Function

	'OriginalExpression: 'YPos
	<Extension()>
	Public Function Eval_Static_y_K_358(ByVal Main As RDCompiledProcess) As Object
		return YPos
	End Function

	'OriginalExpression: 'CampataShapeIN.z
	<Extension()>
	Public Function Eval_Static_z_K_358(ByVal Main As RDCompiledProcess) As Object
		return CampataShapeIN.z
	End Function

	'OriginalExpression: 'CampataShapeIN.width
	<Extension()>
	Public Function Eval_Static_width_K_358(ByVal Main As RDCompiledProcess) As Object
		return CampataShapeIN.width
	End Function

	'OriginalExpression: 'CampataShapeIN.height
	<Extension()>
	Public Function Eval_Static_height_K_358(ByVal Main As RDCompiledProcess) As Object
		return CampataShapeIN.height
	End Function

	'OriginalExpression: 'CampataShapeIN.depth
	<Extension()>
	Public Function Eval_Static_depth_K_358(ByVal Main As RDCompiledProcess) As Object
		return CampataShapeIN.depth
	End Function

	'OriginalExpression: 'Livelli
	<Extension()>
	Public Function Eval_Static_Livelli_K_358(ByVal Main As RDCompiledProcess) As Object
		return Livelli
	End Function

	'OriginalExpression: 'AltezzeLivelli
	<Extension()>
	Public Function Eval_Static_AltezzeLivelli_K_358(ByVal Main As RDCompiledProcess) As Object
		return AltezzeLivelli
	End Function

	'OriginalExpression: 'CampataShapeIN.NomeTreno
	<Extension()>
	Public Function Eval_Static_NomeTreno_K_358(ByVal Main As RDCompiledProcess) As Object
		return CampataShapeIN.NomeTreno
	End Function

	'OriginalExpression: 'CampataShapeIN.NumeroCampata+1
	<Extension()>
	Public Function Eval_Static_NumeroCampata_K_358(ByVal Main As RDCompiledProcess) As Object
		return CampataShapeIN.NumeroCampata+1
	End Function

	'OriginalExpression: 'CreateGUID()
	<Extension()>
	Public Function Eval_Static_id_K_352(ByVal Main As RDCompiledProcess) As Object
		return CreateGUID()
	End Function

	'OriginalExpression: 'CampataShapeNew.id
	<Extension()>
	Public Function Eval_Static_shapeFromId_K_352(ByVal Main As RDCompiledProcess) As Object
		return CampataShapeNew.id
	End Function

	'OriginalExpression: 'CampataShapeIN.id
	<Extension()>
	Public Function Eval_Static_shapeToId_K_352(ByVal Main As RDCompiledProcess) As Object
		return CampataShapeIN.id
	End Function

	'OriginalExpression: 'CampataShapeNew
	<Extension()>
	Public Function Eval_Static_Set_CampataShapeIN_K_47(ByVal Main As RDCompiledProcess) As Object
		return CampataShapeNew
	End Function

	'OriginalExpression: 'iRow+1
	<Extension()>
	Public Function Eval_Static_Set_iRow_K_48(ByVal Main As RDCompiledProcess) As Object
		return iRow+1
	End Function

	'OriginalExpression: 'CampataShapeNew.y +ProfonditàCampate+ DistanzaTraTreni
	<Extension()>
	Public Function Eval_Static_Set_YPos_K_385(ByVal Main As RDCompiledProcess) As Object
		return CampataShapeNew.y +ProfonditàCampate+ DistanzaTraTreni
	End Function

	'OriginalExpression: 'iCol+1
	<Extension()>
	Public Function Eval_Static_Set_iCol_K_398(ByVal Main As RDCompiledProcess) As Object
		return iCol+1
	End Function

	'Condition for group Group
	'OriginalExpression: 'iCol<=NumeroTreni
	<Extension()>
	Public Function Eval_Static_CondExp1_K_418(ByVal Main As RDCompiledProcess) As Object
		return iCol<=NumeroTreni
	End Function

	'OriginalExpression: 'CreateGUID()
	<Extension()>
	Public Function Eval_Static_id_K_424(ByVal Main As RDCompiledProcess) As Object
		return CreateGUID()
	End Function

	'OriginalExpression: 'XPos
	<Extension()>
	Public Function Eval_Static_x_K_424(ByVal Main As RDCompiledProcess) As Object
		return XPos
	End Function

	'OriginalExpression: 'YPos
	<Extension()>
	Public Function Eval_Static_y_K_424(ByVal Main As RDCompiledProcess) As Object
		return YPos
	End Function

	'OriginalExpression: 'LunghezzaCampate
	<Extension()>
	Public Function Eval_Static_width_K_424(ByVal Main As RDCompiledProcess) As Object
		return LunghezzaCampate
	End Function

	'OriginalExpression: 'ProfonditàCampate
	<Extension()>
	Public Function Eval_Static_height_K_424(ByVal Main As RDCompiledProcess) As Object
		return ProfonditàCampate
	End Function

	'OriginalExpression: 'AltezzaCampate
	<Extension()>
	Public Function Eval_Static_depth_K_424(ByVal Main As RDCompiledProcess) As Object
		return AltezzaCampate
	End Function

	'OriginalExpression: 'Livelli
	<Extension()>
	Public Function Eval_Static_Livelli_K_424(ByVal Main As RDCompiledProcess) As Object
		return Livelli
	End Function

	'OriginalExpression: 'AltezzeLivelli
	<Extension()>
	Public Function Eval_Static_AltezzeLivelli_K_424(ByVal Main As RDCompiledProcess) As Object
		return AltezzeLivelli
	End Function

	'OriginalExpression: '"Treno_"+IntToStr(iCol)
	<Extension()>
	Public Function Eval_Static_NomeTreno_K_424(ByVal Main As RDCompiledProcess) As Object
		return "Treno_"+IntToStr(iCol)
	End Function



End Module
