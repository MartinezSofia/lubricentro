'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class ventacabecera
    Public Property idventa As Integer
    Public Property total As Decimal
    Public Property dnicli As Integer

    Public Overridable Property ventadetalle As ICollection(Of ventadetalle) = New HashSet(Of ventadetalle)

End Class
