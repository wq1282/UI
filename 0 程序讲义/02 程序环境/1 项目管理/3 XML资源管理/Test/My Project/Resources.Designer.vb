﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.18444
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    '此类是由 StronglyTypedResourceBuilder
    '类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    '若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    '(以 /str 作为命令选项)，或重新生成 VS 项目。
    '''<summary>
    '''  一个强类型的资源类，用于查找本地化的字符串等。
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  返回此类使用的缓存的 ResourceManager 实例。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Test.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  使用此强类型资源类，为所有资源查找
        '''  重写当前线程的 CurrentUICulture 属性。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  查找类似 &lt;Light&gt;
        '''    &lt;Light0&gt;
        '''      &lt;position&gt;0,0,0,1&lt;/position&gt;
        '''      &lt;ambient&gt;51,51,51,255&lt;/ambient&gt;
        '''      &lt;diffuse&gt;0,0,0,0&lt;/diffuse&gt;
        '''      &lt;specular&gt;0,0,0,0&lt;/specular&gt;
        '''    &lt;/Light0&gt;
        '''    
        '''    &lt;Light1&gt;
        '''      &lt;position&gt;75,100,130,1&lt;/position&gt;
        '''      &lt;ambient&gt;30,30,30,255&lt;/ambient&gt;
        '''      &lt;diffuse&gt;180,180,180,255&lt;/diffuse&gt;
        '''      &lt;specular&gt;0,0,0,0&lt;/specular&gt;
        '''    &lt;/Light1&gt;
        '''    
        '''    &lt;Light2&gt;
        '''      &lt;position&gt;-75,-100,0,1&lt;/position&gt;
        '''      &lt;ambient&gt;30,30,30,255&lt;/ambient&gt;
        '''      &lt;diffuse&gt;180,180,180,255&lt;/diff [字符串的其余部分被截断]&quot;; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property ConfigLight() As String
            Get
                Return ResourceManager.GetString("ConfigLight", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        '''&lt;Material&gt;
        '''  &lt;PrinterBox&gt;
        '''    &lt;ambient&gt;254,0,0,255&lt;/ambient&gt;
        '''    &lt;diffuse&gt;254,0,0,255&lt;/diffuse&gt;
        '''    &lt;specular&gt;254,0,0,255&lt;/specular&gt;
        '''    &lt;emission&gt;255,255,255,255&lt;/emission&gt;
        '''    &lt;shininess&gt;&lt;/shininess&gt;
        '''  &lt;/PrinterBox&gt;
        '''  &lt;PrinterBoxBed&gt;
        '''    &lt;ambient&gt;0,0,0,125&lt;/ambient&gt;
        '''    &lt;diffuse&gt;0,0,0,125&lt;/diffuse&gt;
        '''    &lt;specular&gt;0,0,0,0&lt;/specular&gt;
        '''    &lt;emission&gt;0,0,0,0&lt;/emission&gt;
        '''    &lt;shininess&gt;&lt;/shininess&gt;
        '''  &lt;/PrinterBoxBed&gt;
        '''
        '''  &lt;Model&gt;
        '''    &lt;ambient&gt;64,64,64,255&lt;/a [字符串的其余部分被截断]&quot;; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property ConfigMaterial() As String
            Get
                Return ResourceManager.GetString("ConfigMaterial", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
