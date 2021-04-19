Imports System
Imports System.Collections
Imports System.Reflection
Imports RuleDesigner.Configurator.Core.RDCoreCompiler
Imports RuleDesigner.Configurator.Core.RDCoreCompiler.CompilerUtil

Public Module GlobalVars

#Region " -- Process Parameters Table -- "

	Public [NumeroTreni] As integer	'IN
	Public [CampateXTreno] As integer	'IN
	Public [ProfonditàCampate] As integer	'IN
	Public [LunghezzaCampate] As integer	'IN
	Public [AltezzaCampate] As integer	'IN
	Public [XPos] As integer	'IN
	Public [YPos] As integer	'IN
	Public [DistanzaTraTreni] As integer	'IN
	Public [Livelli] As integer	'IN
	Public [AltezzeLivelli] As New Generic.List(Of integer)	'IN
	Public [myShapeListOUT] As New Generic.List(Of Editor2DShapeType)	'OUT


#End Region

#Region " -- Process Types Table -- "

Public Class Editor2DOptionType
		Public [PageUnit] As string
		Public [PageLanguage] As string
		Public [PageNumberOfDecimal] As integer
		Public [PageOrigin] As string
		Public [PageFontSize] As integer
		Public [PageFormat] As string
		Public [PageOrientation] As string
		Public [PageGridSize] As string
		Public [PageGridRotation] As string
		Public [PageScaleFactor] As string
		Public [PageSnapToGrid] As boolean
		Public [PageSnapToObject] As boolean
		Public [PageSnapToPolyline] As boolean
		Public [PageSnapToShapeCenter] As boolean
		Public [PageQuickPickIgnoreThreshold] As string
		Public [PageShowGrid] As boolean
		Public [PageShowRulers] As boolean
		Public [PageShowActions] As boolean
		Public [PageShowUndoRedo] As boolean
		Public [PageShowTextTools] As boolean
		Public [PageShowDrawTools] As boolean
		Public [PageShowSmartLineTools] As boolean
		Public [PageShowSmartCopyTools] As boolean
		Public [PageShowConnectorTools] As boolean
		Public [PageShowConnectionPointTools] As boolean
		Public [PageShowGridPatternTools] As boolean
		Public [PageShowZIndexTools] As boolean
		Public [PageShowGroupTools] As boolean
		Public [PageShowQuoteTools] As boolean
		Public [PageShowLinkTools] As boolean
		Public [PageShowCustomOrigin] As boolean
		Public [PageShowUtils] As boolean
		Public [PageShowSave] As boolean
		Public [PageShowHelp] As boolean
		Public [PageShowHelpPopup] As boolean
		Public [PageShowPreview3D] As boolean
		Public [PageShowPreview3DDinamicLights] As boolean
		Public [PageShowPreview3DGround] As boolean
		Public [PageShowPreview3DViewStyle] As string
		Public [PageShowPreview3DEnableFloor] As boolean
		Public [PageShowPreview3DFloorImage] As string
		Public [PageShowPreview3DFloorThickness] As double
		Public [PageShowPreview3DEnableWalls] As boolean
		Public [PageShowPreview3DWallDimensions] As string
		Public [PageShowToolsOnToolbar] As string
		Public [PageShowShapeProperties] As boolean
		Public [PageShowQuoteUOM] As boolean
		Public [PageIncludeConnectionPoints] As boolean
		Public [PageCheckInclusions] As boolean
		Public [PageCheckCollisions] As boolean
		Public [PageCheckQuotes] As boolean
		Public [PageCheckBackgroundCollisions] As boolean
		Public [PageActiveBackground] As boolean
		Public [PageZoomFit] As boolean
		Public [PageZoomPage] As boolean
		Public [ShapeEvents] As string
		Public [ShapeLibrary] As string
		Public [ShapeLibraryHideList] As string
		Public [ShapeLibraryOpenList] As string
		Public [DoBackgroundCheckOnly] As boolean
		Public [DoAutoSave] As boolean
		Public [DoExportImage2D] As boolean
		Public [DoExportImage3D] As boolean
End Class

Public Class Editor2DCategory
		Public [id] As string
		Public [parentId] As string
		Public [name] As string
		Public [description] As string
		Public [icon] As string
		Public [hidden] As boolean
		Public [userFilter] As string
		Public [styleTags] As string
End Class

Public Class Editor2DShapeType
		Public [source] As string
		Public [sourceLibrary] As string
		Public [signature] As string
		Public [id] As string
		Public [name] As string
		Public [family] As string
		Public [description] As string
		Public [x] As double
		Public [y] As double
		Public [z] As double
		Public [width] As double
		Public [height] As double
		Public [depth] As double
		Public [rotation] As double
		Public [text] As string
		Public [behaviour] As string
		Public [datadump] As string
		Public [path] As string
		Public [ctrl1x] As double
		Public [ctrl1y] As double
		Public [ctrl2x] As double
		Public [ctrl2y] As double
		Public [shapeFromId] As string
		Public [shapeFromPointIndex] As string
		Public [shapeToId] As string
		Public [shapeToPointIndex] As string
		Public [dimStack] As double
		Public [dimType] As string
		Public [dimDriving] As boolean
		Public [dimValue] As double
		Public [color] As string
		Public [colorOpacity] As double
		Public [color3D] As string
		Public [colorOpacity3D] As double
		Public [lineWidth] As string
		Public [lineColor] As string
		Public [lineOpacity] As double
		Public [lineColor3D] As string
		Public [lineOpacity3D] As double
		Public [links] As New Generic.List(Of string)
		Public [group] As string
		Public [layer] As string
		Public [connectionPoints] As string
		Public [modified] As boolean
		Public [pinned] As boolean
		Public [selected] As boolean
		Public [includeInBOM] As boolean
		Public [Livelli] As integer
		Public [AltezzeLivelli] As New Generic.List(Of integer)
		Public [NomeTreno] As string
		Public [NumeroCampata] As integer
End Class

Public Class Editor2DShapeConnectionPointType
		Public [id] As string
		Public [shapeId] As string
		Public [cpId] As string
		Public [x] As double
		Public [y] As double
		Public [z] As double
		Public [noRX] As double
		Public [noRY] As double
		Public [noRZ] As double
		Public [direction] As string
		Public [linkClass] As string
End Class

Public Class Editor2DShapePropertyType
		Public [id] As string
		Public [name] As string
		Public [family] As string
		Public [description] As string
		Public [text] As string
		Public [shapeMode] As integer
		Public [icon] As string
		Public [iconBig] As string
		Public [image] As string
		Public [srcSVG] As string
		Public [src3D] As string
		Public [srcTexture3D] As string
		Public [width] As double
		Public [height] As double
		Public [depth] As double
		Public [behaviour] As string
		Public [help] As string
		Public [eventClass] As string
		Public [linkClass] As string
		Public [collisionClass] As string
		Public [containerClass] As string
		Public [snapClass] As string
		Public [color] As string
		Public [colorOpacity] As double
		Public [lineColor] As string
		Public [lineColorOpacity] As double
		Public [color3D] As string
		Public [colorOpacity3D] As double
		Public [lineColor3D] As string
		Public [lineColorOpacity3D] As double
		Public [custom] As string
		Public [connectionPoints] As string
		Public [group2dShapes] As string
		Public [group2dConnectors] As string
		Public [group3d] As string
		Public [eventHandler] As string
		Public [eventHandlers] As string
End Class

Public Class Editor2DChildType
		Public [id] As string
		Public [source] As string
		Public [width] As double
		Public [height] As double
		Public [depth] As double
		Public [x] As double
		Public [y] As double
		Public [z] As double
		Public [rotation] As string
		Public [data] As string
		Public [color] As string
		Public [colorOpacity] As double
End Class

Public Class Editor2DChildConnectorType
		Public [source] As string
		Public [x1] As double
		Public [y1] As double
		Public [x2] As double
		Public [y2] As double
		Public [path] As string
		Public [ctrl1x] As double
		Public [ctrl1y] As double
		Public [ctrl2x] As double
		Public [ctrl2y] As double
		Public [shapeFromId] As string
		Public [shapeFromPointIndex] As string
		Public [shapeToId] As string
		Public [shapeToPointIndex] As string
End Class

Public Class Editor2DConnectionPointType
		Public [id] As string
		Public [x] As double
		Public [y] As double
		Public [z] As double
		Public [xMin] As string
		Public [xMax] As string
		Public [xStep] As string
		Public [yMin] As string
		Public [yMax] As string
		Public [yStep] As string
		Public [zMin] As string
		Public [zMax] As string
		Public [zStep] As string
		Public [direction] As double
		Public [linkClass] As string
		Public [label] As string
		Public [isDimension] As boolean
End Class

Public Class Editor2DParameterType
		Public [name] As string
		Public [value] As string
End Class

Public Class Editor2DEventHandlerType
		Public [handler] As string
		Public [params] As New Generic.List(Of Editor2DParameterType)
End Class

Public Class Editor2DEventArgumentsType
		Public [class] As string
		Public [handler] As New Editor2DEventHandlerType
		Public [connectionPointID] As string
		Public [shapeID] As string
		Public [group] As string
		Public [options] As string
End Class

Public Class Editor2DEventHandlersType
		Public [generic] As New Editor2DEventHandlerType
		Public [inserted] As New Editor2DEventHandlerType
		Public [stretched] As New Editor2DEventHandlerType
		Public [linked] As New Editor2DEventHandlerType
		Public [removed] As New Editor2DEventHandlerType
		Public [rotated] As New Editor2DEventHandlerType
		Public [regrouped] As New Editor2DEventHandlerType
		Public [doubleclick] As New Editor2DEventHandlerType
End Class

Public Class Editor2DBoxType
		Public [width] As double
		Public [height] As double
		Public [depth] As double
End Class

Public Class Editor2DEventClassType
		Public [id] As string
		Public [types] As New Generic.List(Of string)
		Public [handler] As New Editor2DEventHandlerType
End Class

Public Class Editor2DLinkClassType
		Public [id] As string
		Public [handler] As New Editor2DEventHandlerType
		Public [xMin] As string
		Public [xMax] As string
		Public [xStep] As string
		Public [yMin] As string
		Public [yMax] As string
		Public [yStep] As string
		Public [zMin] As string
		Public [zMax] As string
		Public [zStep] As string
End Class



#End Region

#Region " -- Process Variables Table -- "

	Public [iRow] As integer
	Public [iCol] As integer
	Public [CampataShapeNew] As New Editor2DShapeType
	Public [myShapeLink] As New Editor2DShapeType
	Public [CampataShapeIN] As New Editor2DShapeType


#End Region

End Module


