Imports System.Drawing.Text
Imports System.Drawing.Drawing2D
Imports System.ComponentModel

''     DO NOT REMOVE CREDITS! IF YOU USE PLEASE CREDIT!     ''

''' <summary>
''' LogIn GDI+ Theme
''' Creator: Xertz (HF)
''' Version: 1.2
''' Control Count: 28
''' Date Created: 18/12/2013
''' Date Changed: 01/01/2014
''' UID: 1602992
''' For any bugs / errors, PM me.
''' </summary>
''' <remarks></remarks>

Module DrawHelpers

#Region "Functions"
    
    Public Function RoundRectangle(ByVal Rectangle As Rectangle, ByVal Curve As Integer) As GraphicsPath
        Dim P As GraphicsPath = New GraphicsPath()
        Dim ArcRectangleWidth As Integer = Curve * 2
        P.AddArc(New Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90)
        P.AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90)
        P.AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90)
        P.AddArc(New Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90)
        P.AddLine(New Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), New Point(Rectangle.X, Curve + Rectangle.Y))
        Return P
    End Function

    Public Function RoundRect(x!, y!, w!, h!, Optional r! = 0.3, Optional TL As Boolean = True, Optional TR As Boolean = True, Optional BR As Boolean = True, Optional BL As Boolean = True) As GraphicsPath
        Dim d! = Math.Min(w, h) * r, xw = x + w, yh = y + h
        RoundRect = New GraphicsPath

        With RoundRect
            If TL Then .AddArc(x, y, d, d, 180, 90) Else .AddLine(x, y, x, y)
            If TR Then .AddArc(xw - d, y, d, d, 270, 90) Else .AddLine(xw, y, xw, y)
            If BR Then .AddArc(xw - d, yh - d, d, d, 0, 90) Else .AddLine(xw, yh, xw, yh)
            If BL Then .AddArc(x, yh - d, d, d, 90, 90) Else .AddLine(x, yh, x, yh)

            .CloseFigure()
        End With
    End Function

    Enum MouseState As Byte
        None = 0
        Over = 1
        Down = 2
        Block = 3
    End Enum

#End Region

End Module

Public Class LogInThemeContainer
    Inherits ContainerControl

#Region "Declarations"
    Private _AllowClose As Boolean = True
    Private _AllowMinimize As Boolean = True
    Private _AllowMaximize As Boolean = True
    Private _FontSize As Integer = 12
    Private ReadOnly _Font As Font = New Font("Segoe UI", _FontSize)
    Private _ShowIcon As Boolean = True
    Private State As MouseState = MouseState.None
    Private MouseXLoc As Integer
    Private MouseYLoc As Integer
    Private CaptureMovement As Boolean = False
    Private Const MoveHeight As Integer = 35
    Private MouseP As Point = New Point(0, 0)
    Private _FontColour As Color = Color.FromArgb(255, 255, 255)
    Private _BaseColour As Color = Color.FromArgb(35, 35, 35)
    Private _ContainerColour As Color = Color.FromArgb(54, 54, 54)
    Private _BorderColour As Color = Color.FromArgb(60, 60, 60)
    Private _HoverColour As Color = Color.FromArgb(42, 42, 42)
#End Region

#Region "Properties & Events"

    <Category("Control")>
    Public Property FontSize As Integer
        Get
            Return _FontSize
        End Get
        Set(value As Integer)
            _FontSize = value
        End Set
    End Property

    <Category("Control")>
    Public Property AllowMinimize As Boolean
        Get
            Return _AllowMinimize
        End Get
        Set(value As Boolean)
            _AllowMinimize = value
        End Set
    End Property

    <Category("Control")>
    Public Property AllowMaximize As Boolean
        Get
            Return _AllowMaximize
        End Get
        Set(value As Boolean)
            _AllowMaximize = value
        End Set
    End Property

    <Category("Control")>
    Public Property ShowIcon As Boolean
        Get
            Return _ShowIcon
        End Get
        Set(value As Boolean)
            _ShowIcon = value
        End Set
    End Property

    <Category("Control")>
    Public Property AllowClose As Boolean
        Get
            Return _AllowClose
        End Get
        Set(value As Boolean)
            _AllowClose = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property HoverColour As Color
        Get
            Return _HoverColour
        End Get
        Set(value As Color)
            _HoverColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property ContainerColour As Color
        Get
            Return _ContainerColour
        End Get
        Set(value As Color)
            _ContainerColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property FontColour As Color
        Get
            Return _FontColour
        End Get
        Set(value As Color)
            _FontColour = value
        End Set
    End Property

    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        CaptureMovement = False
        State = MouseState.Over
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        MouseXLoc = e.Location.X
        MouseYLoc = e.Location.Y
        Invalidate()
        If CaptureMovement Then
            Parent.Location = MousePosition - MouseP
        End If
        If e.X < Width - 90 AndAlso e.Y > 35 Then Cursor = Cursors.Arrow Else Cursor = Cursors.Hand
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If MouseXLoc > Width - 39 AndAlso MouseXLoc < Width - 16 AndAlso MouseYLoc < 22 Then
            If _AllowClose Then
                Environment.Exit(0)
            End If
        ElseIf MouseXLoc > Width - 64 AndAlso MouseXLoc < Width - 41 AndAlso MouseYLoc < 22 Then
            If _AllowMaximize Then
                Select Case FindForm.WindowState
                    Case FormWindowState.Maximized
                        FindForm.WindowState = FormWindowState.Normal
                    Case FormWindowState.Normal
                        FindForm.WindowState = FormWindowState.Maximized
                End Select
            End If
        ElseIf MouseXLoc > Width - 89 AndAlso MouseXLoc < Width - 66 AndAlso MouseYLoc < 22 Then
            If _AllowMinimize Then
                Select Case FindForm.WindowState
                    Case FormWindowState.Normal
                        FindForm.WindowState = FormWindowState.Minimized
                    Case FormWindowState.Maximized
                        FindForm.WindowState = FormWindowState.Minimized
                End Select
            End If
        ElseIf e.Button = Windows.Forms.MouseButtons.Left And New Rectangle(0, 0, Width - 90, MoveHeight).Contains(e.Location) Then
            CaptureMovement = True
            MouseP = e.Location
        ElseIf e.Button = Windows.Forms.MouseButtons.Left And New Rectangle(Width - 90, 22, 75, 13).Contains(e.Location) Then
            CaptureMovement = True
            MouseP = e.Location
        ElseIf e.Button = Windows.Forms.MouseButtons.Left And New Rectangle(Width - 15, 0, 15, MoveHeight).Contains(e.Location) Then
            CaptureMovement = True
            MouseP = e.Location
        Else
            Focus()
        End If
        State = MouseState.Down
        Invalidate()
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.DoubleBuffered = True
        Me.BackColor = _BaseColour
        Me.Dock = DockStyle.Fill
    End Sub

    Protected Overrides Sub OnCreateControl()
        Try
            MyBase.OnCreateControl()
            'ParentForm.FormBorderStyle = FormBorderStyle.None
            'ParentForm.AllowTransparency = False
            'ParentForm.TransparencyKey = Color.Fuchsia
            'ParentForm.FindForm.StartPosition = FormStartPosition.CenterScreen
            Dock = DockStyle.Fill
            Invalidate()
        Catch ex As Exception

        End Try
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .FillRectangle(New SolidBrush(_BaseColour), New Rectangle(0, 0, Width, Height))
            .FillRectangle(New SolidBrush(_ContainerColour), New Rectangle(2, 35, Width - 4, Height - 37))
            .DrawRectangle(New Pen(_BorderColour), New Rectangle(0, 0, Width, Height))
            Dim ControlBoxPoints() As Point = {New Point(Width - 90, 0), New Point(Width - 90, 22), New Point(Width - 15, 22), New Point(Width - 15, 0)}
            .DrawLines(New Pen(_BorderColour), ControlBoxPoints)
            .DrawLine(New Pen(_BorderColour), Width - 65, 0, Width - 65, 22)
            Select Case State
                Case MouseState.Over
                    If MouseXLoc > Width - 39 AndAlso MouseXLoc < Width - 16 AndAlso MouseYLoc < 22 Then
                        .FillRectangle(New SolidBrush(_HoverColour), New Rectangle(Width - 39, 0, 23, 22))
                    ElseIf MouseXLoc > Width - 64 AndAlso MouseXLoc < Width - 41 AndAlso MouseYLoc < 22 Then
                        .FillRectangle(New SolidBrush(_HoverColour), New Rectangle(Width - 64, 0, 23, 22))
                        ElseIf MouseXLoc > Width - 89 AndAlso MouseXLoc < Width - 66 AndAlso MouseYLoc < 22 Then
                        .FillRectangle(New SolidBrush(_HoverColour), New Rectangle(Width - 89, 0, 23, 22))
                    End If
            End Select
            .DrawLine(New Pen(_BorderColour), Width - 40, 0, Width - 40, 22)
            ''Close Button
            .DrawLine(New Pen(_FontColour), Width - 33, 6, Width - 22, 16)
            .DrawLine(New Pen(_FontColour), Width - 33, 16, Width - 22, 6)
            ''Minimize Button
            .DrawLine(New Pen(_FontColour), Width - 83, 16, Width - 72, 16)
            ''Maximize Button
            .DrawLine(New Pen(_FontColour), Width - 58, 16, Width - 47, 16)
            .DrawLine(New Pen(_FontColour), Width - 58, 16, Width - 58, 6)
            .DrawLine(New Pen(_FontColour), Width - 47, 16, Width - 47, 6)
            .DrawLine(New Pen(_FontColour), Width - 58, 6, Width - 47, 6)
            .DrawLine(New Pen(_FontColour), Width - 58, 7, Width - 47, 7)
            If _ShowIcon Then
                .DrawIcon(FindForm.Icon, New Rectangle(6, 6, 22, 22))
                .DrawString(Text, _Font, New SolidBrush(_FontColour), New RectangleF(31, 0, Width - 110, 35), New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})
            Else
                .DrawString(Text, _Font, New SolidBrush(_FontColour), New RectangleF(3, 0, Width - 110, 35), New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})
            End If
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

<DefaultEvent("TextChanged")>
Public Class LogInUserTextBox
    Inherits Control

#Region "Declarations"
    Private State As MouseState = MouseState.None
    Private WithEvents TB As Windows.Forms.TextBox
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
#End Region

#Region "TextBox Properties"

    Private _TextAlign As HorizontalAlignment = HorizontalAlignment.Left
    <Category("Options")>
    Property TextAlign() As HorizontalAlignment
        Get
            Return _TextAlign
        End Get
        Set(ByVal value As HorizontalAlignment)
            _TextAlign = value
            If TB IsNot Nothing Then
                TB.TextAlign = value
            End If
        End Set
    End Property
    Private _MaxLength As Integer = 32767
    <Category("Options")>
    Property MaxLength() As Integer
        Get
            Return _MaxLength
        End Get
        Set(ByVal value As Integer)
            _MaxLength = value
            If TB IsNot Nothing Then
                TB.MaxLength = value
            End If
        End Set
    End Property
    Private _ReadOnly As Boolean
    <Category("Options")>
    Property [ReadOnly]() As Boolean
        Get
            Return _ReadOnly
        End Get
        Set(ByVal value As Boolean)
            _ReadOnly = value
            If TB IsNot Nothing Then
                TB.ReadOnly = value
            End If
        End Set
    End Property
    Private _UseSystemPasswordChar As Boolean
    <Category("Options")>
    Property UseSystemPasswordChar() As Boolean
        Get
            Return _UseSystemPasswordChar
        End Get
        Set(ByVal value As Boolean)
            _UseSystemPasswordChar = value
            If TB IsNot Nothing Then
                TB.UseSystemPasswordChar = value
            End If
        End Set
    End Property
    Private _Multiline As Boolean
    <Category("Options")>
    Property Multiline() As Boolean
        Get
            Return _Multiline
        End Get
        Set(ByVal value As Boolean)
            _Multiline = value
            If TB IsNot Nothing Then
                TB.Multiline = value

                If value Then
                    TB.Height = Height - 11
                Else
                    Height = TB.Height + 11
                End If

            End If
        End Set
    End Property
    <Category("Options")>
    Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            If TB IsNot Nothing Then
                TB.Text = value
            End If
        End Set
    End Property
    <Category("Options")>
    Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            If TB IsNot Nothing Then
                TB.Font = value
                TB.Location = New Point(3, 5)
                TB.Width = Width - 35

                If Not _Multiline Then
                    Height = TB.Height + 11
                End If
            End If
        End Set
    End Property

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        If Not Controls.Contains(TB) Then
            Controls.Add(TB)
        End If
    End Sub
    Private Sub OnBaseTextChanged(ByVal s As Object, ByVal e As EventArgs)
        Text = TB.Text
    End Sub
    Private Sub OnBaseKeyDown(ByVal s As Object, ByVal e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.A Then
            TB.SelectAll()
            e.SuppressKeyPress = True
        End If
        If e.Control AndAlso e.KeyCode = Keys.C Then
            TB.Copy()
            e.SuppressKeyPress = True
        End If
    End Sub
    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        TB.Location = New Point(5, 5)
        TB.Width = Width - 35

        If _Multiline Then
            TB.Height = Height - 11
        Else
            Height = TB.Height + 11
        End If

        MyBase.OnResize(e)
    End Sub

#End Region

#Region "Colour Properties"

    <Category("Colours")>
    Public Property BackgroundColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

#End Region

#Region "Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : TB.Focus() : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        BackColor = Color.Transparent
        TB = New Windows.Forms.TextBox
        TB.Height = 190
        TB.Font = New Font("Segoe UI", 10)
        TB.Text = Text
        TB.BackColor = Color.FromArgb(42, 42, 42)
        TB.ForeColor = Color.FromArgb(255, 255, 255)
        TB.MaxLength = _MaxLength
        TB.Multiline = False
        TB.ReadOnly = _ReadOnly
        TB.UseSystemPasswordChar = _UseSystemPasswordChar
        TB.BorderStyle = BorderStyle.None
        TB.Location = New Point(5, 5)
        TB.Width = Width - 35
        AddHandler TB.TextChanged, AddressOf OnBaseTextChanged
        AddHandler TB.KeyDown, AddressOf OnBaseKeyDown
    End Sub


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim GP As GraphicsPath
        Dim Base As New Rectangle(0, 0, Width, Height)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            TB.BackColor = Color.FromArgb(42, 42, 42)
            TB.ForeColor = Color.FromArgb(255, 255, 255)
            GP = RoundRectangle(Base, 6)
            .FillPath(New SolidBrush(Color.FromArgb(42, 42, 42)), GP)
            .DrawPath(New Pen(New SolidBrush(Color.FromArgb(35, 35, 35)), 2), GP)
            .FillPie(New SolidBrush(FindForm.BackColor), New Rectangle(Width - 25, Height - 23, Height + 25, Height + 25), 180, 90)
            .DrawPie(New Pen(Color.FromArgb(35, 35, 35), 2), New Rectangle(Width - 25, Height - 23, Height + 25, Height + 25), 180, 90)
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub



#End Region

End Class

<DefaultEvent("TextChanged")>
Public Class LogInPassTextBox
    Inherits Control

#Region "Declarations"
    Private State As MouseState = MouseState.None
    Private WithEvents TB As Windows.Forms.TextBox
    Private _BaseColour As Color = Color.FromArgb(255, 255, 255)
    Private _TextColour As Color = Color.FromArgb(50, 50, 50)
    Private _BorderColour As Color = Color.FromArgb(180, 187, 205)
#End Region

#Region "TextBox Properties"

    Private _TextAlign As HorizontalAlignment = HorizontalAlignment.Left
    <Category("Options")>
    Property TextAlign() As HorizontalAlignment
        Get
            Return _TextAlign
        End Get
        Set(ByVal value As HorizontalAlignment)
            _TextAlign = value
            If TB IsNot Nothing Then
                TB.TextAlign = value
            End If
        End Set
    End Property
    Private _MaxLength As Integer = 32767
    <Category("Options")>
    Property MaxLength() As Integer
        Get
            Return _MaxLength
        End Get
        Set(ByVal value As Integer)
            _MaxLength = value
            If TB IsNot Nothing Then
                TB.MaxLength = value
            End If
        End Set
    End Property
    Private _ReadOnly As Boolean
    <Category("Options")>
    Property [ReadOnly]() As Boolean
        Get
            Return _ReadOnly
        End Get
        Set(ByVal value As Boolean)
            _ReadOnly = value
            If TB IsNot Nothing Then
                TB.ReadOnly = value
            End If
        End Set
    End Property
    Private _UseSystemPasswordChar As Boolean
    <Category("Options")>
    Property UseSystemPasswordChar() As Boolean
        Get
            Return _UseSystemPasswordChar
        End Get
        Set(ByVal value As Boolean)
            _UseSystemPasswordChar = value
            If TB IsNot Nothing Then
                TB.UseSystemPasswordChar = value
            End If
        End Set
    End Property
    Private _Multiline As Boolean
    <Category("Options")>
    Property Multiline() As Boolean
        Get
            Return _Multiline
        End Get
        Set(ByVal value As Boolean)
            _Multiline = value
            If TB IsNot Nothing Then
                TB.Multiline = value

                If value Then
                    TB.Height = Height - 11
                Else
                    Height = TB.Height + 11
                End If

            End If
        End Set
    End Property
    <Category("Options")>
    Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            If TB IsNot Nothing Then
                TB.Text = value
            End If
        End Set
    End Property
    <Category("Options")>
    Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            If TB IsNot Nothing Then
                TB.Font = value
                TB.Location = New Point(3, 5)
                TB.Width = Width - 35

                If Not _Multiline Then
                    Height = TB.Height + 11
                End If
            End If
        End Set
    End Property

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        If Not Controls.Contains(TB) Then
            Controls.Add(TB)
        End If
    End Sub
    Private Sub OnBaseTextChanged(ByVal s As Object, ByVal e As EventArgs)
        Text = TB.Text
    End Sub
    Private Sub OnBaseKeyDown(ByVal s As Object, ByVal e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.A Then
            TB.SelectAll()
            e.SuppressKeyPress = True
        End If
        If e.Control AndAlso e.KeyCode = Keys.C Then
            TB.Copy()
            e.SuppressKeyPress = True
        End If
    End Sub
    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        TB.Location = New Point(5, 5)
        TB.Width = Width - 35

        If _Multiline Then
            TB.Height = Height - 11
        Else
            Height = TB.Height + 11
        End If

        MyBase.OnResize(e)
    End Sub
#End Region

#Region "Colour Properties"

    <Category("Colours")>
    Public Property BackgroundColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

#End Region

#Region "Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : TB.Focus() : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        BackColor = Color.Transparent
        TB = New Windows.Forms.TextBox
        TB.Height = 190
        TB.Font = New Font("Segoe UI", 10)
        TB.Text = Text
        TB.BackColor = Color.FromArgb(42, 42, 42)
        TB.ForeColor = Color.FromArgb(255, 255, 255)
        TB.MaxLength = _MaxLength
        TB.Multiline = False
        TB.ReadOnly = _ReadOnly
        TB.UseSystemPasswordChar = _UseSystemPasswordChar
        TB.BorderStyle = BorderStyle.None
        TB.Location = New Point(5, 5)
        TB.Width = Width - 35
        AddHandler TB.TextChanged, AddressOf OnBaseTextChanged
        AddHandler TB.KeyDown, AddressOf OnBaseKeyDown
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim GP As GraphicsPath
        Dim Base As New Rectangle(0, 0, Width, Height)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            TB.BackColor = Color.FromArgb(42, 42, 42)
            TB.ForeColor = Color.FromArgb(255, 255, 255)
            GP = RoundRectangle(Base, 6)
            .FillPath(New SolidBrush(Color.FromArgb(42, 42, 42)), GP)
            .DrawPath(New Pen(New SolidBrush(Color.FromArgb(35, 35, 35)), 2), GP)
            .FillPie(New SolidBrush(FindForm.BackColor), New Rectangle(Width - 25, Height - 60, Height + 25, Height + 25), 90, 90)
            .DrawPie(New Pen(Color.FromArgb(35, 35, 35), 2), New Rectangle(Width - 25, Height - 60, Height + 25, Height + 25), 90, 90)
            .FillEllipse(New SolidBrush(_TextColour), New Rectangle(10, 5, 10, 7))
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub
#End Region

End Class

Public Class LogInLogButton
    Inherits Control

#Region "Declarations"
    Private State As MouseState = MouseState.None
    Private _ArcColour As Color = Color.FromArgb(43, 43, 43)
    Private _ArrowColour As Color = Color.FromArgb(235, 233, 234)
    Private _ArrowBorderColour As Color = Color.FromArgb(170, 170, 170)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _HoverColour As Color = Color.FromArgb(0, 130, 169)
    Private _PressedColour As Color = Color.FromArgb(0, 145, 184)
    Private _NormalColour As Color = Color.FromArgb(0, 160, 199)
#End Region

#Region "Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

#End Region

#Region "Colour Properties"
    <Category("Colours")>
    Public Property ArcColour As Color
        Get
            Return _ArcColour
        End Get
        Set(value As Color)
            _ArcColour = value
        End Set
    End Property
    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property
    <Category("Colours")>
    Public Property ArrowColour As Color
        Get
            Return _ArrowColour
        End Get
        Set(value As Color)
            _ArrowColour = value
        End Set
    End Property
    <Category("Colours")>
    Public Property ArrowBorderColour As Color
        Get
            Return _ArrowBorderColour
        End Get
        Set(value As Color)
            _ArrowBorderColour = value
        End Set
    End Property
    <Category("Colours")>
    Public Property HoverColour As Color
        Get
            Return _HoverColour
        End Get
        Set(value As Color)
            _HoverColour = value
        End Set
    End Property
    <Category("Colours")>
    Public Property PressedColour As Color
        Get
            Return _PressedColour
        End Get
        Set(value As Color)
            _PressedColour = value
        End Set
    End Property
    <Category("Colours")>
    Public Property NormalColour As Color
        Get
            Return _NormalColour
        End Get
        Set(value As Color)
            _NormalColour = value
        End Set
    End Property

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Size = New Size(50, 50)
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
                ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Size = New Size(50, 50)
        BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Height, Height)
        Dim G = Graphics.FromImage(B)
        Dim GP, GP1 As New GraphicsPath
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            Dim P() As Point = {New Point(18, 22), New Point(28, 22), New Point(28, 18), New Point(34, 25), New Point(28, 32), New Point(28, 28), New Point(18, 28)}
            Select Case State
                Case MouseState.None
                    .FillEllipse(New SolidBrush(Color.FromArgb(56, 56, 56)), New Rectangle(CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 3, Height - 3 - 3))
                    .DrawArc(New Pen(New SolidBrush(_ArcColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 3, Height - 3 - 3, -90, 360)
                    .DrawEllipse(New Pen(_BorderColour), New Rectangle(1, 1, Height - 3, Height - 3))
                    .FillEllipse(New SolidBrush(_NormalColour), New Rectangle(CInt(3 / 2) + 3, CInt(3 / 2) + 3, Height - 11, Height - 11))
                    .FillPolygon(New SolidBrush(_ArrowColour), P)
                    .DrawPolygon(New Pen(_ArrowBorderColour), P)
                Case MouseState.Over
                    .DrawArc(New Pen(New SolidBrush(_ArcColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 3, Height - 3 - 3, -90, 360)
                    .DrawEllipse(New Pen(_BorderColour), New Rectangle(1, 1, Height - 3, Height - 3))
                    .FillEllipse(New SolidBrush(_HoverColour), New Rectangle(6, 6, Height - 13, Height - 13))
                    .FillPolygon(New SolidBrush(_ArrowColour), P)
                    .DrawPolygon(New Pen(_ArrowBorderColour), P)
                Case MouseState.Down
                    .DrawArc(New Pen(New SolidBrush(_ArcColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 3, Height - 3 - 3, -90, 360)
                    .DrawEllipse(New Pen(_BorderColour), New Rectangle(1, 1, Height - 3, Height - 3))
                    .FillEllipse(New SolidBrush(_PressedColour), New Rectangle(6, 6, Height - 13, Height - 13))
                    .FillPolygon(New SolidBrush(_ArrowColour), P)
                    .DrawPolygon(New Pen(_ArrowBorderColour), P)
            End Select
        End With
        MyBase.OnPaint(e)
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

<DefaultEvent("CheckedChanged")>
Public Class LogInCheckBox
    Inherits Control

#Region "Declarations"
    Private _Checked As Boolean
    Private State As MouseState = MouseState.None
    Private _CheckedColour As Color = Color.FromArgb(173, 173, 174)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _BackColour As Color = Color.FromArgb(42, 42, 42)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
#End Region

#Region "Colour & Other Properties"

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _BackColour
        End Get
        Set(value As Color)
            _BackColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property CheckedColour As Color
        Get
            Return _CheckedColour
        End Get
        Set(value As Color)
            _CheckedColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property FontColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub

    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(ByVal value As Boolean)
            _Checked = value
            Invalidate()
        End Set
    End Property

    Event CheckedChanged(ByVal sender As Object)
    Protected Overrides Sub OnClick(ByVal e As EventArgs)
        _Checked = Not _Checked
        RaiseEvent CheckedChanged(Me)
        MyBase.OnClick(e)
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = 22
    End Sub
#End Region

#Region "Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                   ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Cursor = Cursors.Hand
        Size = New Size(100, 22)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, 20, 20)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(Color.FromArgb(54, 54, 54))
            .FillRectangle(New SolidBrush(_BackColour), Base)
            .DrawRectangle(New Pen(_BorderColour), New Rectangle(1, 1, 18, 18))
            Select Case State
                Case MouseState.Over
                    .FillRectangle(New SolidBrush(Color.FromArgb(50, 49, 51)), Base)
                    .DrawRectangle(New Pen(_BorderColour), New Rectangle(1, 1, 18, 18))
            End Select
            If Checked Then
                Dim P() As Point = {New Point(4, 11), New Point(6, 8), New Point(9, 12), New Point(15, 3), New Point(17, 6), New Point(9, 16)}
                .FillPolygon(New SolidBrush(_CheckedColour), P)
            End If
            .DrawString(Text, Font, New SolidBrush(_TextColour), New Rectangle(24, 1, Width, Height - 2), New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center})
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub
#End Region

End Class

Public Class LogInNormalTextBox
    Inherits Control

#Region "Declarations"
    Private State As MouseState = MouseState.None
    Private WithEvents TB As Windows.Forms.TextBox
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _Style As Styles = Styles.NotRounded
    Private _TextAlign As HorizontalAlignment = HorizontalAlignment.Left
    Private _MaxLength As Integer = 32767
    Private _ReadOnly As Boolean
    Private _UseSystemPasswordChar As Boolean
    Private _Multiline As Boolean
#End Region

#Region "TextBox Properties"

    Enum Styles
        Rounded
        NotRounded
    End Enum

    <Category("Options")>
    Property TextAlign() As HorizontalAlignment
        Get
            Return _TextAlign
        End Get
        Set(ByVal value As HorizontalAlignment)
            _TextAlign = value
            If TB IsNot Nothing Then
                TB.TextAlign = value
            End If
        End Set
    End Property

    <Category("Options")>
    Property MaxLength() As Integer
        Get
            Return _MaxLength
        End Get
        Set(ByVal value As Integer)
            _MaxLength = value
            If TB IsNot Nothing Then
                TB.MaxLength = value
            End If
        End Set
    End Property

    <Category("Options")>
    Property [ReadOnly]() As Boolean
        Get
            Return _ReadOnly
        End Get
        Set(ByVal value As Boolean)
            _ReadOnly = value
            If TB IsNot Nothing Then
                TB.ReadOnly = value
            End If
        End Set
    End Property

    <Category("Options")>
    Property UseSystemPasswordChar() As Boolean
        Get
            Return _UseSystemPasswordChar
        End Get
        Set(ByVal value As Boolean)
            _UseSystemPasswordChar = value
            If TB IsNot Nothing Then
                TB.UseSystemPasswordChar = value
            End If
        End Set
    End Property

    <Category("Options")>
    Property Multiline() As Boolean
        Get
            Return _Multiline
        End Get
        Set(ByVal value As Boolean)
            _Multiline = value
            If TB IsNot Nothing Then
                TB.Multiline = value

                If value Then
                    TB.Height = Height - 11
                Else
                    Height = TB.Height + 11
                End If

            End If
        End Set
    End Property

    <Category("Options")>
    Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            If TB IsNot Nothing Then
                TB.Text = value
            End If
        End Set
    End Property

    <Category("Options")>
    Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            If TB IsNot Nothing Then
                TB.Font = value
                TB.Location = New Point(3, 5)
                TB.Width = Width - 6

                If Not _Multiline Then
                    Height = TB.Height + 11
                End If
            End If
        End Set
    End Property

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        If Not Controls.Contains(TB) Then
            Controls.Add(TB)
        End If
    End Sub

    Private Sub OnBaseTextChanged(ByVal s As Object, ByVal e As EventArgs)
        Text = TB.Text
    End Sub

    Private Sub OnBaseKeyDown(ByVal s As Object, ByVal e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.A Then
            TB.SelectAll()
            e.SuppressKeyPress = True
        End If
        If e.Control AndAlso e.KeyCode = Keys.C Then
            TB.Copy()
            e.SuppressKeyPress = True
        End If
    End Sub

    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        TB.Location = New Point(5, 5)
        TB.Width = Width - 10

        If _Multiline Then
            TB.Height = Height - 11
        Else
            Height = TB.Height + 11
        End If

        MyBase.OnResize(e)
    End Sub

    Public Property Style As Styles
        Get
            Return _Style
        End Get
        Set(value As Styles)
            _Style = value
        End Set
    End Property

    Public Sub SelectAll()
        TB.Focus()
        TB.SelectAll()
    End Sub


#End Region

#Region "Colour Properties"

    <Category("Colours")>
    Public Property BackgroundColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

#End Region

#Region "Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : TB.Focus() : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        BackColor = Color.Transparent
        TB = New Windows.Forms.TextBox
        TB.Height = 190
        TB.Font = New Font("Segoe UI", 10)
        TB.Text = Text
        TB.BackColor = Color.FromArgb(42, 42, 42)
        TB.ForeColor = Color.FromArgb(255, 255, 255)
        TB.MaxLength = _MaxLength
        TB.Multiline = False
        TB.ReadOnly = _ReadOnly
        TB.UseSystemPasswordChar = _UseSystemPasswordChar
        TB.BorderStyle = BorderStyle.None
        TB.Location = New Point(5, 5)
        TB.Width = Width - 35
        AddHandler TB.TextChanged, AddressOf OnBaseTextChanged
        AddHandler TB.KeyDown, AddressOf OnBaseKeyDown
    End Sub


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim GP As GraphicsPath
        Dim Base As New Rectangle(0, 0, Width, Height)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            TB.BackColor = Color.FromArgb(42, 42, 42)
            TB.ForeColor = Color.FromArgb(255, 255, 255)
            Select Case _Style
                Case Styles.Rounded
                    GP = RoundRectangle(Base, 6)
                    .FillPath(New SolidBrush(Color.FromArgb(42, 42, 42)), GP)
                    .DrawPath(New Pen(New SolidBrush(Color.FromArgb(35, 35, 35)), 2), GP)
                Case Styles.NotRounded
                    .FillRectangle(New SolidBrush(Color.FromArgb(42, 42, 42)), New Rectangle(0, 0, Width - 1, Height - 1))
                    .DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(35, 35, 35)), 2), New Rectangle(0, 0, Width, Height))
            End Select

        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub



#End Region

End Class

Public Class LogInRadialProgressBar
    Inherits Control

#Region "Declarations"
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _ProgressColour As Color = Color.FromArgb(0, 160, 199)
    Private _Value As Integer = 0
    Private _Maximum As Integer = 100
    Private _StartingAngle As Integer = 110
    Private _RotationAngle As Integer = 255
    Private ReadOnly _Font As Font = New Font("Segoe UI", 20)
#End Region

#Region "Properties"

    <Category("Control")>
    Public Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(V As Integer)
            Select Case V
                Case Is < _Value
                    _Value = V
            End Select
            _Maximum = V
            Invalidate()
        End Set
    End Property

    <Category("Control")>
    Public Property Value() As Integer
        Get
            Select Case _Value
                Case 0
                    Return 0
                Case Else
                    Return _Value
            End Select
        End Get

        Set(V As Integer)
            Select Case V
                Case Is > _Maximum
                    V = _Maximum
                    Invalidate()
            End Select
            _Value = V
            Invalidate()
        End Set
    End Property

    Public Sub Increment(ByVal Amount As Integer)
        Value += Amount
    End Sub

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property ProgressColour As Color
        Get
            Return _ProgressColour
        End Get
        Set(value As Color)
            _ProgressColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Control")>
    Public Property StartingAngle As Integer
        Get
            Return _StartingAngle
        End Get
        Set(value As Integer)
            _StartingAngle = value
        End Set
    End Property

    <Category("Control")>
    Public Property RotationAngle As Integer
        Get
            Return _RotationAngle
        End Get
        Set(value As Integer)
            _RotationAngle = value
        End Set
    End Property

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
                ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Size = New Size(78, 78)
        BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        With G
            .TextRenderingHint = TextRenderingHint.AntiAliasGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            Select Case _Value
                Case 0
                    .DrawArc(New Pen(New SolidBrush(_BorderColour), 1 + 5), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle - 3, _RotationAngle + 5)
                    .DrawArc(New Pen(New SolidBrush(_BaseColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle, _RotationAngle)
                    .DrawString(_Value, _Font, Brushes.White, New Point(Width / 2, Height / 2 - 1), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                Case _Maximum
                    .DrawArc(New Pen(New SolidBrush(_BorderColour), 1 + 5), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle - 3, _RotationAngle + 5)
                    .DrawArc(New Pen(New SolidBrush(_BaseColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle, _RotationAngle)
                    .DrawArc(New Pen(New SolidBrush(_ProgressColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle, _RotationAngle)
                    .DrawString(_Value, _Font, Brushes.White, New Point(Width / 2, Height / 2 - 1), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                Case Else
                    .DrawArc(New Pen(New SolidBrush(_BorderColour), 1 + 5), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle - 3, _RotationAngle + 5)
                    .DrawArc(New Pen(New SolidBrush(_BaseColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle, _RotationAngle)
                    .DrawArc(New Pen(New SolidBrush(_ProgressColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle, CInt((_RotationAngle / _Maximum) * _Value))
                    .DrawString(_Value, _Font, Brushes.White, New Point(Width / 2, Height / 2 - 1), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
            End Select
        End With
        MyBase.OnPaint(e)
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub
#End Region

End Class

<DefaultEvent("CheckedChanged")>
Public Class LogInRadioButton
    Inherits Control

#Region "Declarations"
    Private _Checked As Boolean
    Private State As MouseState = MouseState.None
    Private _HoverColour As Color = Color.FromArgb(50, 49, 51)
    Private _CheckedColour As Color = Color.FromArgb(173, 173, 174)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _BackColour As Color = Color.FromArgb(42, 42, 42)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
#End Region

#Region "Colour & Other Properties"

    <Category("Colours")>
    Public Property HighlightColour As Color
        Get
            Return _HoverColour
        End Get
        Set(value As Color)
            _HoverColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _BackColour
        End Get
        Set(value As Color)
            _BackColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property CheckedColour As Color
        Get
            Return _CheckedColour
        End Get
        Set(value As Color)
            _CheckedColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property FontColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    Event CheckedChanged(ByVal sender As Object)
    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(value As Boolean)
            _Checked = value
            InvalidateControls()
            RaiseEvent CheckedChanged(Me)
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnClick(e As EventArgs)
        If Not _Checked Then Checked = True
        MyBase.OnClick(e)
    End Sub
    Private Sub InvalidateControls()
        If Not IsHandleCreated OrElse Not _Checked Then Return
        For Each C As Control In Parent.Controls
            If C IsNot Me AndAlso TypeOf C Is LogInRadioButton Then
                DirectCast(C, LogInRadioButton).Checked = False
                Invalidate()
            End If
        Next
    End Sub
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        InvalidateControls()
    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = 22
    End Sub
#End Region

#Region "Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                   ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Cursor = Cursors.Hand
        Size = New Size(100, 22)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(1, 1, Height - 2, Height - 2)
        Dim Circle As New Rectangle(6, 6, Height - 12, Height - 12)
         With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(Color.FromArgb(54, 54, 54))
            .FillEllipse(New SolidBrush(_BackColour), Base)
            .DrawEllipse(New Pen(_BorderColour, 2), Base)
            If Checked Then
                Select Case State
                    Case MouseState.Over
                        .FillEllipse(New SolidBrush(_HoverColour), New Rectangle(2, 2, Height - 4, Height - 4))
                End Select
                .FillEllipse(New SolidBrush(_CheckedColour), Circle)
            Else
                Select Case State
                    Case MouseState.Over
                        .FillEllipse(New SolidBrush(_HoverColour), New Rectangle(2, 2, Height - 4, Height - 4))
                End Select
            End If
            .DrawString(Text, Font, New SolidBrush(_TextColour), New Rectangle(24, 3, Width, Height), New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near})
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub
#End Region

End Class

Public Class LogInLabel
    Inherits Label

#Region "Declaration"
    Private _FontColour As Color = Color.FromArgb(255, 255, 255)
#End Region

#Region "Property & Event"

    <Category("Colours")>
    Public Property FontColour As Color
        Get
            Return _FontColour
        End Get
        Set(value As Color)
            _FontColour = value
        End Set
    End Property

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e) : Invalidate()
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Font = New Font("Segoe UI", 9)
        ForeColor = _FontColour
        BackColor = Color.Transparent
        Text = Text
    End Sub

#End Region

End Class

Public Class LogInButton
    Inherits Control

#Region "Declarations"
    Private ReadOnly _Font As New Font("Segoe UI", 9)
    Private _ProgressColour As Color = Color.FromArgb(0, 191, 255)
    Private _BorderColour As Color = Color.FromArgb(25, 25, 25)
    Private _FontColour As Color = Color.FromArgb(255, 255, 255)
    Private _MainColour As Color = Color.FromArgb(42, 42, 42)
    Private _HoverColour As Color = Color.FromArgb(52, 52, 52)
    Private _PressedColour As Color = Color.FromArgb(47, 47, 47)
    Private State As New MouseState
#End Region

#Region "Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

#End Region

#Region "Properties"

    <Category("Colours")>
    Public Property ProgressColour As Color
        Get
            Return _ProgressColour
        End Get
        Set(value As Color)
            _ProgressColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property FontColour As Color
        Get
            Return _FontColour
        End Get
        Set(value As Color)
            _FontColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _MainColour
        End Get
        Set(value As Color)
            _MainColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property HoverColour As Color
        Get
            Return _HoverColour
        End Get
        Set(value As Color)
            _HoverColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property PressedColour As Color
        Get
            Return _PressedColour
        End Get
        Set(value As Color)
            _PressedColour = value
        End Set
    End Property

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
              ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
              ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Size = New Size(75, 30)
        BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            Select Case State
                Case MouseState.None
                    .FillRectangle(New SolidBrush(_MainColour), New Rectangle(0, 0, Width, Height))
                    .DrawRectangle(New Pen(_BorderColour, 2), New Rectangle(0, 0, Width, Height))
                    .DrawString(Text, _Font, Brushes.White, New Point(Width / 2, Height / 2), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                Case MouseState.Over
                    .FillRectangle(New SolidBrush(_HoverColour), New Rectangle(0, 0, Width, Height))
                    .DrawRectangle(New Pen(_BorderColour, 1), New Rectangle(1, 1, Width - 2, Height - 2))
                    .DrawString(Text, _Font, Brushes.White, New Point(Width / 2, Height / 2), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                Case MouseState.Down
                    .FillRectangle(New SolidBrush(_PressedColour), New Rectangle(0, 0, Width, Height))
                    .DrawRectangle(New Pen(_BorderColour, 1), New Rectangle(1, 1, Width - 2, Height - 2))
                    .DrawString(Text, _Font, Brushes.White, New Point(Width / 2, Height / 2), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
            End Select
         End With
        MyBase.OnPaint(e)
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInButtonWithProgress
    Inherits Control

#Region "Declarations"
    Private _Value As Integer = 0
    Private _Maximum As Integer = 100
    Private _Font As New Font("Segoe UI", 9)
    Private _ProgressColour As Color = Color.FromArgb(0, 191, 255)
    Private _BorderColour As Color = Color.FromArgb(25, 25, 25)
    Private _FontColour As Color = Color.FromArgb(255, 255, 255)
    Private _MainColour As Color = Color.FromArgb(42, 42, 42)
    Private _HoverColour As Color = Color.FromArgb(52, 52, 52)
    Private _PressedColour As Color = Color.FromArgb(47, 47, 47)
    Private State As New MouseState
#End Region

#Region "Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

#End Region

#Region "Properties"

    <Category("Colours")>
    Public Property ProgressColour As Color
        Get
            Return _ProgressColour
        End Get
        Set(value As Color)
            _ProgressColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property FontColour As Color
        Get
            Return _FontColour
        End Get
        Set(value As Color)
            _FontColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _MainColour
        End Get
        Set(value As Color)
            _MainColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property HoverColour As Color
        Get
            Return _HoverColour
        End Get
        Set(value As Color)
            _HoverColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property PressedColour As Color
        Get
            Return _PressedColour
        End Get
        Set(value As Color)
            _PressedColour = value
        End Set
    End Property

    <Category("Control")>
    Public Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(V As Integer)
            Select Case V
                Case Is < _Value
                    _Value = V
            End Select
            _Maximum = V
            Invalidate()
        End Set
    End Property

    <Category("Control")>
    Public Property Value() As Integer
        Get
            Select Case _Value
                Case 0
                    Return 0

                Case Else
                    Return _Value

            End Select
        End Get
        Set(V As Integer)
            Select Case V
                Case Is > _Maximum
                    V = _Maximum
                    Invalidate()
            End Select
            _Value = V
            Invalidate()
        End Set
    End Property

    Public Sub Increment(ByVal Amount As Integer)
        Value += Amount
    End Sub

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
              ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
              ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Size = New Size(75, 30)
        BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim GP, GP1 As New GraphicsPath
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            Select Case State
                Case MouseState.None
                    .FillRectangle(New SolidBrush(_MainColour), New Rectangle(0, 0, Width, Height - 4))
                    .DrawRectangle(New Pen(_BorderColour, 2), New Rectangle(0, 0, Width, Height - 4))
                    .DrawString(Text, _Font, Brushes.White, New Point(Width / 2, Height / 2 - 2), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                Case MouseState.Over
                    .FillRectangle(New SolidBrush(_HoverColour), New Rectangle(0, 0, Width, Height - 4))
                    .DrawRectangle(New Pen(_BorderColour, 1), New Rectangle(1, 1, Width - 2, Height - 5))
                    .DrawString(Text, _Font, Brushes.White, New Point(Width / 2, Height / 2 - 2), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                Case MouseState.Down
                    .FillRectangle(New SolidBrush(_PressedColour), New Rectangle(0, 0, Width, Height - 4))
                    .DrawRectangle(New Pen(_BorderColour, 1), New Rectangle(1, 1, Width - 2, Height - 5))
                    .DrawString(Text, _Font, Brushes.White, New Point(Width / 2, Height / 2 - 2), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
            End Select
            Select Case _Value
                Case 0
                Case _Maximum
                    .FillRectangle(New SolidBrush(_ProgressColour), New Rectangle(0, Height - 4, Width, Height - 4))
                    .DrawRectangle(New Pen(_BorderColour, 2), New Rectangle(0, 0, Width, Height))
                Case Else
                    .FillRectangle(New SolidBrush(_ProgressColour), New Rectangle(0, Height - 4, Width / _Maximum * _Value, Height - 4))
                    .DrawRectangle(New Pen(_BorderColour, 2), New Rectangle(0, 0, Width, Height))
            End Select
        End With
        MyBase.OnPaint(e)
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInGroupBox
    Inherits ContainerControl

#Region "Declarations"
    Private _MainColour As Color = Color.FromArgb(47, 47, 47)
    Private _HeaderColour As Color = Color.FromArgb(42, 42, 42)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
#End Region

#Region "Properties"

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property HeaderColour As Color
        Get
            Return _HeaderColour
        End Get
        Set(value As Color)
            _HeaderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property MainColour As Color
        Get
            Return _MainColour
        End Get
        Set(value As Color)
            _MainColour = value
        End Set
    End Property

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
               ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
               ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Size = New Size(160, 110)
        Font = New Font("Segoe UI", 10, FontStyle.Bold)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(Color.FromArgb(54, 54, 54))
            .FillRectangle(New SolidBrush(_MainColour), New Rectangle(0, 28, Width, Height))
            .FillRectangle(New SolidBrush(_HeaderColour), New Rectangle(0, 0, .MeasureString(Text, Font).Width + 7, 28))
            .DrawString(Text, Font, New SolidBrush(_TextColour), New Point(5, 5))
            Dim P() As Point = {New Point(0, 0), New Point(.MeasureString(Text, Font).Width + 7, 0), New Point(.MeasureString(Text, Font).Width + 7, 28), _
                                New Point(Width - 1, 28), New Point(Width - 1, Height - 1), New Point(1, Height - 1), New Point(1, 1)}
            .DrawLines(New Pen(_BorderColour), P)
            .DrawLine(New Pen(_BorderColour, 2), New Point(0, 28), New Point(.MeasureString(Text, Font).Width + 7, 28))
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub
#End Region

End Class

Public Class LogInSeperator
    Inherits Control

#Region "Declarations"
    Private _SeperatorColour As Color = Color.FromArgb(35, 35, 35)
    Private _Alignment As Style = Style.Horizontal
    Private _Thickness As Single = 1
#End Region

#Region "Properties"

    Enum Style
        Horizontal
        Verticle
    End Enum

    <Category("Control")>
    Public Property Thickness As Single
        Get
            Return _Thickness
        End Get
        Set(value As Single)
            _Thickness = value
        End Set
    End Property

    <Category("Control")>
    Public Property Alignment As Style
        Get
            Return _Alignment
        End Get
        Set(value As Style)
            _Alignment = value
        End Set
    End Property

    <Category("Colours")>
    Public Property SeperatorColour As Color
        Get
            Return _SeperatorColour
        End Get
        Set(value As Color)
            _SeperatorColour = value
        End Set
    End Property

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        BackColor = Color.Transparent
        Size = New Size(20, 20)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, Width - 1, Height - 1)
        With G
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            Select Case _Alignment
                Case Style.Horizontal
                    .DrawLine(New Pen(_SeperatorColour, _Thickness), New Point(0, Height / 2), New Point(Width, Height / 2))
                Case Style.Verticle
                    .DrawLine(New Pen(_SeperatorColour, _Thickness), New Point(Width / 2, 0), New Point(Width / 2, Height))
            End Select
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub
#End Region

End Class

Public Class LogInNumeric
    Inherits Control

#Region "Variables"

    Private State As MouseState = MouseState.None
    Private MouseXLoc, MouseYLoc As Integer
    Private _Value As Long
    Private _Minimum As Long = 0
    Private _Maximum As Long = 9999999
    Private BoolValue As Boolean
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _ButtonColour As Color = Color.FromArgb(47, 47, 47)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _SecondBorderColour As Color = Color.FromArgb(0, 191, 255)
    Private _FontColour As Color = Color.FromArgb(255, 255, 255)

#End Region

#Region "Properties & Events"

    Public Property Value As Long
        Get
            Return _Value
        End Get
        Set(value As Long)
            If value <= _Maximum And value >= _Minimum Then _Value = value
            Invalidate()
        End Set
    End Property

    Public Property Maximum As Long
        Get
            Return _Maximum
        End Get
        Set(value As Long)
            If value > _Minimum Then _Maximum = value
            If _Value > _Maximum Then _Value = _Maximum
            Invalidate()
        End Set
    End Property

    Public Property Minimum As Long
        Get
            Return _Minimum
        End Get
        Set(value As Long)
            If value < _Maximum Then _Minimum = value
            If _Value < _Minimum Then _Value = Minimum
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        MouseXLoc = e.Location.X
        MouseYLoc = e.Location.Y
        Invalidate()
        If e.X < Width - 47 Then Cursor = Cursors.IBeam Else Cursor = Cursors.Hand
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If MouseXLoc > Width - 47 AndAlso MouseXLoc < Width - 3 Then
            If MouseXLoc < Width - 23 Then
                If (Value + 1) <= _Maximum Then _Value += 1
            Else
                If (Value - 1) >= _Minimum Then _Value -= 1
            End If
        Else
            BoolValue = Not BoolValue
            Focus()
        End If
        Invalidate()
    End Sub

    Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
        MyBase.OnKeyPress(e)
        Try
            If BoolValue Then _Value = CStr(CStr(_Value) & e.KeyChar.ToString())
            If _Value > _Maximum Then _Value = _Maximum
            Invalidate()
        Catch : End Try
    End Sub

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.KeyCode = Keys.Back Then
            Value = 0
        End If
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = 24
    End Sub

    <Category("Colours")> _
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ButtonColour As Color
        Get
            Return _ButtonColour
        End Get
        Set(value As Color)
            _ButtonColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property SecondBorderColour As Color
        Get
            Return _SecondBorderColour
        End Get
        Set(value As Color)
            _SecondBorderColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property FontColour As Color
        Get
            Return _FontColour
        End Get
        Set(value As Color)
            _FontColour = value
        End Set
    End Property

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
        ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
        ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 10)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, Width, Height)
        Dim CenterSF As New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center}
        With G
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .Clear(BackColor)
            .FillRectangle(New SolidBrush(_BaseColour), Base)
            .FillRectangle(New SolidBrush(_ButtonColour), New Rectangle(Width - 48, 0, 48, Height))
            .DrawRectangle(New Pen(_BorderColour, 2), Base)
            .DrawLine(New Pen(_SecondBorderColour), New Point(Width - 48, 1), New Point(Width - 48, Height - 2))
            .DrawLine(New Pen(_BorderColour), New Point(Width - 24, 1), New Point(Width - 24, Height - 2))
            .DrawLine(New Pen(_FontColour), New Point(Width - 36, 7), New Point(Width - 36, 17))
            .DrawLine(New Pen(_FontColour), New Point(Width - 31, 12), New Point(Width - 41, 12))
            .DrawLine(New Pen(_FontColour), New Point(Width - 17, 13), New Point(Width - 7, 13))
            .DrawString(Value, Font, New SolidBrush(_FontColour), New Rectangle(5, 1, Width, Height), New StringFormat() With {.LineAlignment = StringAlignment.Center})
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInColourTable
    Inherits ProfessionalColorTable

#Region "Declarations"

    Private _BackColour As Color = Color.FromArgb(42, 42, 42)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _SelectedColour As Color = Color.FromArgb(47, 47, 47)

#End Region

#Region "Properties"

    <Category("Colours")>
    Public Property SelectedColour As Color
        Get
            Return _SelectedColour
        End Get
        Set(value As Color)
            _SelectedColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BackColour As Color
        Get
            Return _BackColour
        End Get
        Set(value As Color)
            _BackColour = value
        End Set
    End Property

    Public Overrides ReadOnly Property ButtonSelectedBorder() As Color
        Get
            Return _BackColour
        End Get
    End Property

    Public Overrides ReadOnly Property CheckBackground() As Color
        Get
            Return _BackColour
        End Get
    End Property

    Public Overrides ReadOnly Property CheckPressedBackground() As Color
        Get
            Return _BackColour
        End Get
    End Property

    Public Overrides ReadOnly Property CheckSelectedBackground() As Color
        Get
            Return _BackColour
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientBegin() As Color
        Get
            Return _BackColour
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientEnd() As Color
        Get
            Return _BackColour
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientMiddle() As Color
        Get
            Return _BackColour
        End Get
    End Property

    Public Overrides ReadOnly Property MenuBorder() As Color
        Get
            Return _BorderColour
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemBorder() As Color
        Get
            Return _BackColour
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelected() As Color
        Get
            Return _SelectedColour
        End Get
    End Property

    Public Overrides ReadOnly Property SeparatorDark() As Color
        Get
            Return _BorderColour
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripDropDownBackground() As Color
        Get
            Return _BackColour
        End Get
    End Property

#End Region

End Class

Public Class LogInListBox
    Inherits Control

#Region "Variables"

    Private WithEvents ListB As New ListBox
    Private _Items As String() = {""}
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _SelectedColour As Color = Color.FromArgb(55, 55, 55)
    Private _ListBaseColour As Color = Color.FromArgb(47, 47, 47)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)

#End Region

#Region "Properties"

    <Category("Control")> _
    Public Property Items As String()
        Get
            Return _Items
        End Get
        Set(value As String())
            _Items = value
            ListB.Items.Clear()
            ListB.Items.AddRange(value)
            Invalidate()
        End Set
    End Property

    <Category("Colours")> _
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property SelectedColour As Color
        Get
            Return _SelectedColour
        End Get
        Set(value As Color)
            _SelectedColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ListBaseColour As Color
        Get
            Return _ListBaseColour
        End Get
        Set(value As Color)
            _ListBaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    Public ReadOnly Property SelectedItem() As String
        Get
            Return ListB.SelectedItem
        End Get
    End Property

    Public ReadOnly Property SelectedIndex() As Integer
        Get
            Return ListB.SelectedIndex
            If ListB.SelectedIndex < 0 Then Exit Property
        End Get
    End Property

    Public Sub Clear()
        ListB.Items.Clear()
    End Sub

    Public Sub ClearSelected()
        For i As Integer = (ListB.SelectedItems.Count - 1) To 0 Step -1
            ListB.Items.Remove(ListB.SelectedItems(i))
        Next
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        If Not Controls.Contains(ListB) Then
            Controls.Add(ListB)
        End If
    End Sub

    Sub AddRange(ByVal items As Object())
        ListB.Items.Remove("")
        ListB.Items.AddRange(items)
    End Sub

    Sub AddItem(ByVal item As Object)
        ListB.Items.Remove("")
        ListB.Items.Add(item)
    End Sub

#End Region

#Region "Draw Control"

    Sub Drawitem(ByVal sender As Object, ByVal e As DrawItemEventArgs) Handles ListB.DrawItem
        If e.Index < 0 Then Exit Sub
        e.DrawBackground()
        e.DrawFocusRectangle()
        With e.Graphics
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .InterpolationMode = InterpolationMode.HighQualityBicubic
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            If InStr(e.State.ToString, "Selected,") > 0 Then
                .FillRectangle(New SolidBrush(_SelectedColour), New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height - 1))
                .DrawString(" " & ListB.Items(e.Index).ToString(), New Font("Segoe UI", 9, FontStyle.Bold), New SolidBrush(_TextColour), e.Bounds.X, e.Bounds.Y + 2)
            Else
                .FillRectangle(New SolidBrush(_ListBaseColour), New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
                .DrawString(" " & ListB.Items(e.Index).ToString(), New Font("Segoe UI", 8), New SolidBrush(_TextColour), e.Bounds.X, e.Bounds.Y + 2)
            End If
            .Dispose()
        End With
    End Sub

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
            ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        ListB.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
        ListB.ScrollAlwaysVisible = False
        ListB.HorizontalScrollbar = False
        ListB.BorderStyle = BorderStyle.None
        ListB.BackColor = _BaseColour
        ListB.Location = New Point(3, 3)
        ListB.Font = New Font("Segoe UI", 8)
        ListB.ItemHeight = 20
        ListB.Items.Clear()
        ListB.IntegralHeight = False
        Size = New Size(130, 100)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, Width, Height)
        With G
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .Clear(BackColor)
            ListB.Size = New Size(Width - 6, Height - 5)
            .FillRectangle(New SolidBrush(_BaseColour), Base)
            .DrawRectangle(New Pen(_BorderColour, 3), New Rectangle(0, 0, Width, Height - 1))
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInTitledListBox
    Inherits Control

#Region "Variables"

    Private WithEvents ListB As New ListBox
    Private _Items As String() = {""}
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _SelectedColour As Color = Color.FromArgb(55, 55, 55)
    Private _ListBaseColour As Color = Color.FromArgb(47, 47, 47)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _TitleFont As New Font("Segeo UI", 10, FontStyle.Bold)

#End Region

#Region "Properties"

    <Category("Control")>
    Public Property TitleFont As Font
        Get
            Return _TitleFont
        End Get
        Set(value As Font)
            _TitleFont = value
        End Set
    End Property

    <Category("Control")> _
    Public Property Items As String()
        Get
            Return _Items
        End Get
        Set(value As String())
            _Items = value
            ListB.Items.Clear()
            ListB.Items.AddRange(value)
            Invalidate()
        End Set
    End Property

    <Category("Colours")> _
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property SelectedColour As Color
        Get
            Return _SelectedColour
        End Get
        Set(value As Color)
            _SelectedColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ListBaseColour As Color
        Get
            Return _ListBaseColour
        End Get
        Set(value As Color)
            _ListBaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    Public ReadOnly Property SelectedItem() As String
        Get
            Return ListB.SelectedItem
        End Get
    End Property

    Public ReadOnly Property SelectedIndex() As Integer
        Get
            Return ListB.SelectedIndex
            If ListB.SelectedIndex < 0 Then Exit Property
        End Get
    End Property

    Public Sub Clear()
        ListB.Items.Clear()
    End Sub

    Public Sub ClearSelected()
        For i As Integer = (ListB.SelectedItems.Count - 1) To 0 Step -1
            ListB.Items.Remove(ListB.SelectedItems(i))
        Next
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        If Not Controls.Contains(ListB) Then
            Controls.Add(ListB)
        End If
    End Sub

    Sub AddRange(ByVal items As Object())
        ListB.Items.Remove("")
        ListB.Items.AddRange(items)
    End Sub

    Sub AddItem(ByVal item As Object)
        ListB.Items.Remove("")
        ListB.Items.Add(item)
    End Sub

#End Region

#Region "Draw Control"

    Sub Drawitem(ByVal sender As Object, ByVal e As DrawItemEventArgs) Handles ListB.DrawItem
        If e.Index < 0 Then Exit Sub
        e.DrawBackground()
        e.DrawFocusRectangle()
        With e.Graphics
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .InterpolationMode = InterpolationMode.HighQualityBicubic
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            If InStr(e.State.ToString, "Selected,") > 0 Then
                .FillRectangle(New SolidBrush(_SelectedColour), New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height - 1))
                .DrawString(" " & ListB.Items(e.Index).ToString(), New Font("Segoe UI", 9, FontStyle.Bold), New SolidBrush(_TextColour), e.Bounds.X, e.Bounds.Y + 2)
            Else
                .FillRectangle(New SolidBrush(_ListBaseColour), New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
                .DrawString(" " & ListB.Items(e.Index).ToString(), New Font("Segoe UI", 8), New SolidBrush(_TextColour), e.Bounds.X, e.Bounds.Y + 2)
            End If
            .Dispose()
        End With
    End Sub

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
            ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        ListB.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
        ListB.ScrollAlwaysVisible = False
        ListB.HorizontalScrollbar = False
        ListB.BorderStyle = BorderStyle.None
        ListB.BackColor = BaseColour
        ListB.Location = New Point(3, 28)
        ListB.Font = New Font("Segoe UI", 8)
        ListB.ItemHeight = 20
        ListB.Items.Clear()
        ListB.IntegralHeight = False
        Size = New Size(130, 100)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, Width, Height)
        With G
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .Clear(BackColor)
            ListB.Size = New Size(Width - 6, Height - 30)
            .FillRectangle(New SolidBrush(BaseColour), Base)
            .DrawRectangle(New Pen((_BorderColour), 3), New Rectangle(0, 0, Width, Height - 1))
            .DrawLine(New Pen((_BorderColour), 2), New Point(0, 27), New Point(Width - 1, 27))
            .DrawString(Text, _TitleFont, New SolidBrush(_TextColour), New Rectangle(2, 5, Width - 5, 20), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInContextMenu
    Inherits ContextMenuStrip

#Region "Declarations"

    Private _FontColour As Color = Color.FromArgb(55, 255, 255)

#End Region

#Region "Properties"

    Public Property FontColour As Color
        Get
            Return _FontColour
        End Get
        Set(value As Color)
            _FontColour = value
        End Set
    End Property

#End Region

#Region "Draw Control"

    Sub New()
        Renderer = New ToolStripProfessionalRenderer(New LogInColourTable())
        ShowCheckMargin = False
        ShowImageMargin = False
        ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        MyBase.OnPaint(e)
    End Sub

#End Region

End Class

Public Class LogInProgressBar
    Inherits Control

#Region "Declarations"
    Private _ProgressColour As Color = Color.FromArgb(0, 160, 199)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _FontColour As Color = Color.FromArgb(50, 50, 50)
    Private _SecondColour As Color = Color.FromArgb(0, 145, 184)
    Private _Value As Integer = 0
    Private _Maximum As Integer = 100
    Private _TwoColour As Boolean = True
#End Region

#Region "Properties"

    Public Property SecondColour As Color
        Get
            Return _SecondColour
        End Get
        Set(value As Color)
            _SecondColour = value
        End Set
    End Property

    <Category("Control")>
    Public Property TwoColour As Boolean
        Get
            Return _TwoColour
        End Get
        Set(value As Boolean)
            _TwoColour = value
        End Set
    End Property

    <Category("Control")>
    Public Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(V As Integer)
            Select Case V
                Case Is < _Value
                    _Value = V
            End Select
            _Maximum = V
            Invalidate()
        End Set
    End Property

    <Category("Control")>
    Public Property Value() As Integer
        Get
            Select Case _Value
                Case 0
                    Return 0
                    Invalidate()
                Case Else
                    Return _Value
                    Invalidate()
            End Select
        End Get
        Set(V As Integer)
            Select Case V
                Case Is > _Maximum
                    V = _Maximum
                    Invalidate()
            End Select
            _Value = V
            Invalidate()
        End Set
    End Property

    <Category("Colours")>
    Public Property ProgressColour As Color
        Get
            Return _ProgressColour
        End Get
        Set(value As Color)
            _ProgressColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property FontColour As Color
        Get
            Return _FontColour
        End Get
        Set(value As Color)
            _FontColour = value
        End Set
    End Property

#End Region

#Region "Events"

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = 25
    End Sub

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Height = 25
    End Sub

    Public Sub Increment(ByVal Amount As Integer)
        Value += Amount
    End Sub

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B = New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, Width, Height)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            Dim ProgVal As Integer = CInt(_Value / _Maximum * Width)
            Select Case Value
                Case 0
                    .FillRectangle(New SolidBrush(_BaseColour), Base)
                    .FillRectangle(New SolidBrush(_ProgressColour), New Rectangle(0, 0, ProgVal - 1, Height))
                    .DrawRectangle(New Pen(_BorderColour, 3), Base)
                Case _Maximum
                    .FillRectangle(New SolidBrush(_BaseColour), Base)
                    .FillRectangle(New SolidBrush(_ProgressColour), New Rectangle(0, 0, ProgVal - 1, Height))
                    If _TwoColour Then
                        G.SetClip(New Rectangle(0, -10, Width * _Value / _Maximum - 1, Height - 5))
                        For i = 0 To (Width - 1) * _Maximum / _Value Step 25
                            G.DrawLine(New Pen(New SolidBrush(_SecondColour), 7), New Point(i, 0), New Point(i - 15, Height))
                        Next
                        G.ResetClip()
                    Else
                    End If
                    .DrawRectangle(New Pen(_BorderColour, 3), Base)
                Case Else
                    .FillRectangle(New SolidBrush(_BaseColour), Base)
                    .FillRectangle(New SolidBrush(_ProgressColour), New Rectangle(0, 0, ProgVal - 1, Height))
                    If _TwoColour Then
                        .SetClip(New Rectangle(0, 0, Width * _Value / _Maximum - 1, Height - 1))
                        For i = 0 To (Width - 1) * _Maximum / _Value Step 25
                            .DrawLine(New Pen(New SolidBrush(_SecondColour), 7), New Point(i, 0), New Point(i - 10, Height))
                        Next
                        .ResetClip()
                    Else
                    End If
                    .DrawRectangle(New Pen(_BorderColour, 3), Base)
            End Select
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInRichTextBox
    Inherits Control

#Region "Declarations"
    Private WithEvents TB As New RichTextBox
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
#End Region

#Region "Properties"

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

#End Region

#Region "Events"

    Public Sub AppendText(ByVal AppendingText As String)
        TB.Focus()
        TB.AppendText(AppendingText)
        Invalidate()
    End Sub

    Overrides Property Text As String
        Get
            Return TB.Text
        End Get
        Set(value As String)
            TB.Text = value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnBackColorChanged(ByVal e As System.EventArgs)
        MyBase.OnBackColorChanged(e)
        TB.BackColor = BackColor
        Invalidate()
    End Sub

    Protected Overrides Sub OnForeColorChanged(ByVal e As System.EventArgs)
        MyBase.OnForeColorChanged(e)
        TB.ForeColor = ForeColor
        Invalidate()
    End Sub

    Protected Overrides Sub OnSizeChanged(ByVal e As System.EventArgs)
        MyBase.OnSizeChanged(e)
        TB.Size = New Size(Width - 10, Height - 11)
    End Sub

    Protected Overrides Sub OnFontChanged(ByVal e As System.EventArgs)
        MyBase.OnFontChanged(e)
        TB.Font = Font
    End Sub

    Sub TextChanges() Handles MyBase.TextChanged
        TB.Text = Text
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        With TB
            .Multiline = True
            .BackColor = _BaseColour
            .ForeColor = _TextColour
            .Text = String.Empty
            .BorderStyle = BorderStyle.None
            .Location = New Point(5, 5)
            .Font = New Font("Segeo UI", 9)
            .Size = New Size(Width - 10, Height - 10)
        End With
        Controls.Add(TB)
        Size = New Size(135, 35)
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, Width - 1, Height - 1)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(_BaseColour)
            .DrawRectangle(New Pen(_BorderColour, 2), ClientRectangle)
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInStatusBar
    Inherits Control

#Region "Variables"
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _TextColour As Color = Color.White
    Private _RectColour As Color = Color.FromArgb(21, 117, 149)
    Private _ShowLine As Boolean = True
    Private _LinesToShow As LinesCount = LinesCount.One
    Private _Alignment As Alignments = Alignments.Left
    Private _ShowBorder As Boolean = True
#End Region

#Region "Properties"

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    Enum LinesCount As Integer
        One = 1
        Two = 2
    End Enum

    Enum Alignments
        Left
        Center
        Right
    End Enum

    <Category("Control")>
    Public Property Alignment As Alignments
        Get
            Return _Alignment
        End Get
        Set(value As Alignments)
            _Alignment = value
        End Set
    End Property

    <Category("Control")>
    Public Property LinesToShow As LinesCount
        Get
            Return _LinesToShow
        End Get
        Set(value As LinesCount)
            _LinesToShow = value
        End Set
    End Property

    Public Property ShowBorder As Boolean
        Get
            Return _ShowBorder
        End Get
        Set(value As Boolean)
            _ShowBorder = value
        End Set
    End Property

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Dock = DockStyle.Bottom
    End Sub

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e) : Invalidate()
    End Sub

    <Category("Colours")> _
    Public Property RectangleColor As Color
        Get
            Return _RectColour
        End Get
        Set(value As Color)
            _RectColour = value
        End Set
    End Property

    Public Property ShowLine As Boolean
        Get
            Return _ShowLine
        End Get
        Set(value As Boolean)
            _ShowLine = value
        End Set
    End Property

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 9)
        ForeColor = Color.White
        Size = New Size(Width, 20)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, Width, Height)
        With G
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .Clear(BaseColour)
            .FillRectangle(New SolidBrush(BaseColour), Base)
            If _ShowLine = True Then
                Select Case _LinesToShow
                    Case LinesCount.One
                        If _Alignment = Alignments.Left Then
                            .DrawString(Text, Font, New SolidBrush(_TextColour), New Rectangle(22, 2, Width, Height), New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near})
                        ElseIf _Alignment = Alignments.Center Then
                            .DrawString(Text, Font, New SolidBrush(_TextColour), New Rectangle(0, 0, Width, Height), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                        Else
                            .DrawString(Text, Font, New SolidBrush(_TextColour), New Rectangle(0, 0, Width - 5, Height), New StringFormat With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Center})
                        End If
                        .FillRectangle(New SolidBrush(_RectColour), New Rectangle(5, 9, 14, 3))
                    Case LinesCount.Two
                        If _Alignment = Alignments.Left Then
                            .DrawString(Text, Font, New SolidBrush(_TextColour), New Rectangle(22, 2, Width, Height), New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near})
                        ElseIf _Alignment = Alignments.Center Then
                            .DrawString(Text, Font, New SolidBrush(_TextColour), New Rectangle(0, 0, Width, Height), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                        Else
                            .DrawString(Text, Font, New SolidBrush(_TextColour), New Rectangle(0, 0, Width - 22, Height), New StringFormat With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Center})
                        End If
                        .FillRectangle(New SolidBrush(_RectColour), New Rectangle(5, 9, 14, 3))
                        .FillRectangle(New SolidBrush(_RectColour), New Rectangle(Width - 20, 9, 14, 3))
                End Select
            Else
                .DrawString(Text, Font, Brushes.White, New Rectangle(5, 2, Width, Height), New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near})
            End If
            If _ShowBorder Then
                .DrawLine(New Pen(_BorderColour, 2), New Point(0, 0), New Point(Width, 0))
            Else
            End If
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInOnOffSwitch
    Inherits Control

#Region "Declarations"

    Private _Toggled As Toggles = Toggles.NotToggled
    Private MouseXLoc As Integer
    Private ToggleLocation As Integer = 0
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _NonToggledTextColour As Color = Color.FromArgb(155, 155, 155)
    Private _ToggledColour As Color = Color.FromArgb(23, 119, 151)

#End Region

#Region "Properties & Events"

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property NonToggledTextColourderColour As Color
        Get
            Return _NonToggledTextColour
        End Get
        Set(value As Color)
            _NonToggledTextColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property ToggledColour As Color
        Get
            Return _ToggledColour
        End Get
        Set(value As Color)
            _ToggledColour = value
        End Set
    End Property

    Enum Toggles
        Toggled
        NotToggled
    End Enum

    Event ToggledChanged()

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        MouseXLoc = e.Location.X
        Invalidate()
        If e.X < Width - 40 AndAlso e.X > 40 Then Cursor = Cursors.IBeam Else Cursor = Cursors.Arrow
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If MouseXLoc > Width - 39 Then
            _Toggled = Toggles.Toggled
            ToggledValue()
        ElseIf MouseXLoc < 39 Then
            _Toggled = Toggles.NotToggled
            ToggledValue()
        End If
        Invalidate()
    End Sub

    Public Property Toggled() As Toggles
        Get
            Return _Toggled
        End Get
        Set(ByVal value As Toggles)
            _Toggled = value
            Invalidate()
        End Set
    End Property

    Private Sub ToggledValue()
        If _Toggled Then
            If ToggleLocation < 100 Then
                ToggleLocation += 10
            End If
        Else
            If ToggleLocation > 0 Then
                ToggleLocation -= 10
            End If
        End If
        Invalidate()
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or _
                ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G As Graphics = e.Graphics
        G.Clear(Parent.FindForm.BackColor)
        G.SmoothingMode = SmoothingMode.AntiAlias
        G.FillRectangle(New SolidBrush(_BaseColour), New Rectangle(0, 0, 39, Height))
        G.FillRectangle(New SolidBrush(_BaseColour), New Rectangle(Width - 40, 0, Width, Height))
        G.FillRectangle(New SolidBrush(_BaseColour), New Rectangle(38, 9, Width - 40, 5))
        Dim P As Point() = {New Point(0, 0), New Point(39, 0), New Point(39, 9), New Point(Width - 40, 9), New Point(Width - 40, 0), _
                           New Point(Width - 2, 0), New Point(Width - 2, Height - 1), New Point(Width - 40, Height - 1), _
                            New Point(Width - 40, 14), New Point(39, 14), New Point(39, Height - 1), New Point(0, Height - 1), New Point()}
        G.DrawLines(New Pen(_BorderColour, 2), P)
        If _Toggled = Toggles.Toggled Then
            G.FillRectangle(New SolidBrush(_ToggledColour), New Rectangle(Width / 2, 10, Width / 2 - 38, 3))
            G.FillRectangle(New SolidBrush(_ToggledColour), New Rectangle(Width - 39, 2, 36, Height - 5))
        Else
        End If
        If _Toggled = Toggles.Toggled Then
            G.DrawString("ON", New Font("Microsoft Sans Serif", 7, FontStyle.Bold), New SolidBrush(_TextColour), New Rectangle(2, -1, Width - 20 + 20 / 3, Height), New StringFormat() With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Center})
            G.DrawString("OFF", New Font("Microsoft Sans Serif", 7, FontStyle.Bold), New SolidBrush(_NonToggledTextColour), New Rectangle(20 - 20 / 3 - 6, -1, Width - 20 + 20 / 3, Height), New StringFormat() With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center})
        ElseIf _Toggled = Toggles.NotToggled Then
            G.DrawString("OFF", New Font("Microsoft Sans Serif", 7, FontStyle.Bold), New SolidBrush(_TextColour), New Rectangle(20 - 20 / 3 - 6, -1, Width - 20 + 20 / 3, Height), New StringFormat() With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center})
            G.DrawString("ON", New Font("Microsoft Sans Serif", 7, FontStyle.Bold), New SolidBrush(_NonToggledTextColour), New Rectangle(2, -1, Width - 20 + 20 / 3, Height), New StringFormat() With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Center})
        End If
        G.DrawLine(New Pen(_BorderColour, 2), New Point(Width / 2, 0), New Point(Width / 2, Height))
    End Sub

#End Region

End Class

Public Class LogInComboBox
    Inherits ComboBox

#Region "Declarations"
    Private _StartIndex As Integer = 0
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _FontColour As Color = Color.FromArgb(255, 255, 255)
    Private _LineColour As Color = Color.FromArgb(23, 119, 151)
    Private _SqaureColour As Color = Color.FromArgb(47, 47, 47)
    Private _ArrowColour As Color = Color.FromArgb(30, 30, 30)
    Private _SqaureHoverColour As Color = Color.FromArgb(52, 52, 52)
    Private State As MouseState = MouseState.None
#End Region

#Region "Properties & Events"

    <Category("Colours")>
    Public Property LineColour As Color
        Get
            Return _LineColour
        End Get
        Set(value As Color)
            _LineColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property SqaureColour As Color
        Get
            Return _SqaureColour
        End Get
        Set(value As Color)
            _SqaureColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property ArrowColour As Color
        Get
            Return _ArrowColour
        End Get
        Set(value As Color)
            _ArrowColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property SqaureHoverColour As Color
        Get
            Return _SqaureHoverColour
        End Get
        Set(value As Color)
            _SqaureHoverColour = value
        End Set
    End Property

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property FontColour As Color
        Get
            Return _FontColour
        End Get
        Set(value As Color)
            _FontColour = value
        End Set
    End Property

    Public Property StartIndex As Integer
        Get
            Return _StartIndex
        End Get
        Set(ByVal value As Integer)
            _StartIndex = value
            Try
                MyBase.SelectedIndex = value
            Catch
            End Try
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnTextChanged(e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        Invalidate()
        OnMouseClick(e)
    End Sub

    Protected Overrides Sub OnMouseUp(e As System.Windows.Forms.MouseEventArgs)
        Invalidate()
        MyBase.OnMouseUp(e)
    End Sub

#End Region

#Region "Draw Control"

    Sub ReplaceItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Me.DrawItem
        e.DrawBackground()
        e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        Dim Rect As New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width + 1, e.Bounds.Height + 1)
        Try
            With e.Graphics
                If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                    .FillRectangle(New SolidBrush(_SqaureColour), Rect)
                    .DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), Font, New SolidBrush(_FontColour), 1, e.Bounds.Top + 2)
                Else
                    .FillRectangle(New SolidBrush(_BaseColour), Rect)
                    .DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), Font, New SolidBrush(_FontColour), 1, e.Bounds.Top + 2)
                End If
            End With
        Catch
        End Try
        e.DrawFocusRectangle()
        Invalidate()

    End Sub

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
               ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
               ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        BackColor = Color.Transparent
        DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
        DropDownStyle = ComboBoxStyle.DropDownList
        Width = 163
        Font = New Font("Segoe UI", 10)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            Try
                Dim Square As New Rectangle(Width - 25, 0, Width, Height)
                .FillRectangle(New SolidBrush(_BaseColour), New Rectangle(0, 0, Width - 25, Height))
                Select Case State
                    Case MouseState.None
                        .FillRectangle(New SolidBrush(_SqaureColour), Square)
                    Case MouseState.Over
                        .FillRectangle(New SolidBrush(_SqaureHoverColour), Square)
                End Select
                .DrawLine(New Pen(_LineColour, 2), New Point(Width - 26, 1), New Point(Width - 26, Height - 1))
                Try
                    .DrawString(Text, Font, New SolidBrush(_FontColour), New Rectangle(3, 0, Width - 20, Height), New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})
                Catch : End Try
                .DrawRectangle(New Pen(_BorderColour, 2), New Rectangle(0, 0, Width, Height))
                Dim P() As Point = {New Point(Width - 17, 11), New Point(Width - 13, 5), New Point(Width - 9, 11)}
                .FillPolygon(New SolidBrush(_BorderColour), P)
                .DrawPolygon(New Pen(_ArrowColour), P)
                Dim P1() As Point = {New Point(Width - 17, 15), New Point(Width - 13, 21), New Point(Width - 9, 15)}
                .FillPolygon(New SolidBrush(_BorderColour), P1)
                .DrawPolygon(New Pen(_ArrowColour), P1)
            Catch
            End Try
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInTabControl
    Inherits TabControl

#Region "Declarations"

    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _BackTabColour As Color = Color.FromArgb(54, 54, 54)
    Private _BaseColour As Color = Color.FromArgb(35, 35, 35)
    Private _ActiveColour As Color = Color.FromArgb(47, 47, 47)
    Private _BorderColour As Color = Color.FromArgb(30, 30, 30)
    Private _UpLineColour As Color = Color.FromArgb(0, 160, 199)
    Private _HorizLineColour As Color = Color.FromArgb(23, 119, 151)
    Private CenterSF As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}

#End Region

#Region "Properties"

    <Category("Colours")> _
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property UpLineColour As Color
        Get
            Return _UpLineColour
        End Get
        Set(value As Color)
            _UpLineColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property HorizontalLineColour As Color
        Get
            Return _HorizLineColour
        End Get
        Set(value As Color)
            _HorizLineColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BackTabColour As Color
        Get
            Return _BackTabColour
        End Get
        Set(value As Color)
            _BackTabColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ActiveColour As Color
        Get
            Return _ActiveColour
        End Get
        Set(value As Color)
            _ActiveColour = value
        End Set
    End Property

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Alignment = TabAlignment.Top
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 10)
        SizeMode = TabSizeMode.Normal
        ItemSize = New Size(240, 32)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        With G
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .Clear(_BaseColour)
            Try : SelectedTab.BackColor = _BackTabColour : Catch : End Try
            Try : SelectedTab.BorderStyle = BorderStyle.FixedSingle : Catch : End Try
            .DrawRectangle(New Pen(_BorderColour, 2), New Rectangle(0, 0, Width, Height))
            For i = 0 To TabCount - 1
                Dim Base As New Rectangle(New Point(GetTabRect(i).Location.X, GetTabRect(i).Location.Y), New Size(GetTabRect(i).Width, GetTabRect(i).Height))
                Dim BaseSize As New Rectangle(Base.Location, New Size(Base.Width, Base.Height))
                If i = SelectedIndex Then
                    .FillRectangle(New SolidBrush(_BaseColour), BaseSize)
                    .FillRectangle(New SolidBrush(_ActiveColour), New Rectangle(Base.X + 1, Base.Y - 3, Base.Width, Base.Height + 5))
                    .DrawString(TabPages(i).Text, Font, New SolidBrush(_TextColour), New Rectangle(Base.X + 7, Base.Y, Base.Width - 3, Base.Height), CenterSF)
                    .DrawLine(New Pen(_HorizLineColour, 2), New Point(Base.X + 3, Base.Height / 2 + 2), New Point(Base.X + 9, Base.Height / 2 + 2))
                    .DrawLine(New Pen(_UpLineColour, 2), New Point(Base.X + 3, Base.Y - 3), New Point(Base.X + 3, Base.Height + 5))
                Else
                    .DrawString(TabPages(i).Text, Font, New SolidBrush(_TextColour), BaseSize, CenterSF)
                End If
            Next
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInTrackBar
    Inherits Control

#Region "Declaration"
    Private _Maximum As Integer = 10
    Private _Value As Integer = 0
    Private CaptureMovement As Boolean = False
    Private Bar As Rectangle = New Rectangle(0, 10, Width - 21, Height - 21)
    Private Track As Size = New Size(25, 14)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _BarBaseColour As Color = Color.FromArgb(47, 47, 47)
    Private _StripColour As Color = Color.FromArgb(42, 42, 42)
    Private _StripAmountColour As Color = Color.FromArgb(23, 119, 151)
#End Region

#Region "Properties"

    <Category("Colours")> _
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BarBaseColour As Color
        Get
            Return _BarBaseColour
        End Get
        Set(value As Color)
            _BarBaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property StripColour As Color
        Get
            Return _StripColour
        End Get
        Set(value As Color)
            _StripColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property StripAmountColour As Color
        Get
            Return _StripAmountColour
        End Get
        Set(value As Color)
            _StripAmountColour = value
        End Set
    End Property

    Public Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal value As Integer)
            If value > 0 Then _Maximum = value
            If value < _Value Then _Value = value
            Invalidate()
        End Set
    End Property

    Event ValueChanged()

    Public Property Value() As Integer
        Get
            Return _Value
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is = _Value
                    Exit Property
                Case Is < 0
                    _Value = 0
                Case Is > _Maximum
                    _Value = _Maximum
                Case Else
                    _Value = value
            End Select
            Invalidate()
            RaiseEvent ValueChanged()
        End Set
    End Property

    Protected Overrides Sub OnHandleCreated(ByVal e As System.EventArgs)
        BackColor = Color.Transparent
        MyBase.OnHandleCreated(e)
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        Dim MovementPoint As New Rectangle(New Point(e.Location.X, e.Location.Y), New Size(1, 1))
        Dim Bar As New Rectangle(10, 10, Width - 21, Height - 21)
        If New Rectangle(New Point(Bar.X + CInt(Bar.Width * (Value / Maximum)) - CInt(Track.Width / 2 - 1), 0), New Size(Track.Width, Height)).IntersectsWith(MovementPoint) Then
            CaptureMovement = True
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        CaptureMovement = False
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        If CaptureMovement Then
            Dim MovementPoint As New Point(e.X, e.Y)
            Dim Bar As New Rectangle(10, 10, Width - 21, Height - 21)
            Value = CInt(Maximum * ((MovementPoint.X - Bar.X) / Bar.Width))
        End If
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        MyBase.OnMouseLeave(e) : CaptureMovement = False
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or _
                    ControlStyles.UserPaint Or ControlStyles.Selectable Or _
                    ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        With G
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            Bar = New Rectangle(13, 11, Width - 27, Height - 21)
            .Clear(Parent.FindForm.BackColor)
            .SmoothingMode = SmoothingMode.AntiAlias
            .TextRenderingHint = TextRenderingHint.AntiAliasGridFit
            .FillRectangle(New SolidBrush(_StripColour), New Rectangle(3, CInt((Height / 2) - 4), Width - 5, 8))
            .DrawRectangle(New Pen(_BorderColour, 2), New Rectangle(4, CInt((Height / 2) - 4), Width - 5, 8))
            .FillRectangle(New SolidBrush(_StripAmountColour), New Rectangle(4, CInt((Height / 2) - 4), CInt(Bar.Width * (Value / Maximum)) + CInt(Track.Width / 2), 8))
            .FillRectangle(New SolidBrush(_BarBaseColour), Bar.X + CInt(Bar.Width * (Value / Maximum)) - CInt(Track.Width / 2), Bar.Y + CInt((Bar.Height / 2)) - CInt(Track.Height / 2), Track.Width, Track.Height)
            .DrawRectangle(New Pen(_BorderColour, 2), Bar.X + CInt(Bar.Width * (Value / Maximum)) - CInt(Track.Width / 2), Bar.Y + CInt((Bar.Height / 2)) - CInt(Track.Height / 2), Track.Width, Track.Height)
            .DrawString(_Value, New Font("Segoe UI", 6.5, FontStyle.Regular), New SolidBrush(_TextColour), New Rectangle(Bar.X + CInt(Bar.Width * (Value / Maximum)) - CInt(Track.Width / 2), Bar.Y + CInt((Bar.Height / 2)) - CInt(Track.Height / 2), Track.Width - 1, Track.Height), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

<DefaultEvent("Scroll")>
Public Class LogInVerticalScrollBar
    Inherits Control

#Region "Declarations"

    Private ThumbMovement As Integer
    Private TSA As Rectangle
    Private BSA As Rectangle
    Private Shaft As Rectangle
    Private Thumb As Rectangle
    Private ShowThumb As Boolean
    Private ThumbPressed As Boolean
    Private _ThumbSize As Integer = 24
    Private _Minimum As Integer = 0
    Private _Maximum As Integer = 100
    Private _Value As Integer = 0
    Private _SmallChange As Integer = 1
    Private _ButtonSize As Integer = 16
    Private _LargeChange As Integer = 10
    Private _ThumbBorder As Color = Color.FromArgb(35, 35, 35)
    Private _LineColour As Color = Color.FromArgb(23, 119, 151)
    Private _ArrowColour As Color = Color.FromArgb(37, 37, 37)
    Private _BaseColour As Color = Color.FromArgb(47, 47, 47)
    Private _ThumbColour As Color = Color.FromArgb(55, 55, 55)
    Private _ThumbSecondBorder As Color = Color.FromArgb(65, 65, 65)
    Private _FirstBorder As Color = Color.FromArgb(55, 55, 55)
    Private _SecondBorder As Color = Color.FromArgb(35, 35, 35)

#End Region

#Region "Properties & Events"

    <Category("Colours")> _
    Public Property ThumbBorder As Color
        Get
            Return _ThumbBorder
        End Get
        Set(value As Color)
            _ThumbBorder = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property LineColour As Color
        Get
            Return _LineColour
        End Get
        Set(value As Color)
            _LineColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ArrowColour As Color
        Get
            Return _ArrowColour
        End Get
        Set(value As Color)
            _ArrowColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ThumbColour As Color
        Get
            Return _ThumbColour
        End Get
        Set(value As Color)
            _ThumbColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ThumbSecondBorder As Color
        Get
            Return _ThumbSecondBorder
        End Get
        Set(value As Color)
            _ThumbSecondBorder = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property FirstBorder As Color
        Get
            Return _FirstBorder
        End Get
        Set(value As Color)
            _FirstBorder = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property SecondBorder As Color
        Get
            Return _SecondBorder
        End Get
        Set(value As Color)
            _SecondBorder = value
        End Set
    End Property

    Event Scroll(ByVal sender As Object)

    Property Minimum() As Integer
        Get
            Return _Minimum
        End Get
        Set(ByVal value As Integer)
            _Minimum = value
            If value > _Value Then _Value = value
            If value > _Maximum Then _Maximum = value
            InvalidateLayout()
        End Set
    End Property

    Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal value As Integer)
            If value < _Value Then _Value = value
            If value < _Minimum Then _Minimum = value
        End Set
    End Property

    Property Value() As Integer
        Get
            Return _Value
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is = _Value
                    Exit Property
                Case Is < _Minimum
                    _Value = _Minimum
                Case Is > _Maximum
                    _Value = _Maximum
                Case Else
                    _Value = value
            End Select
            InvalidatePosition()
            RaiseEvent Scroll(Me)
        End Set
    End Property

    Public Property SmallChange() As Integer
        Get
            Return _SmallChange
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is < 1
                Case Is >
                    _SmallChange = value
            End Select
        End Set
    End Property

    Public Property LargeChange() As Integer
        Get
            Return _LargeChange
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is < 1
                Case Else
                    _LargeChange = value
            End Select
        End Set
    End Property

    Public Property ButtonSize As Integer
        Get
            Return _ButtonSize
        End Get
        Set(value As Integer)
            Select Case value
                Case Is < 16
                    _ButtonSize = 16
                Case Else
                    _ButtonSize = value
            End Select
        End Set
    End Property

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        InvalidateLayout()
    End Sub

    Private Sub InvalidateLayout()
        TSA = New Rectangle(0, 1, Width, 0)
        Shaft = New Rectangle(0, TSA.Bottom - 1, Width, Height - 3)
        ShowThumb = ((_Maximum - _Minimum))
        If ShowThumb Then
            Thumb = New Rectangle(1, 0, Width - 3, _ThumbSize)
        End If
        RaiseEvent Scroll(Me)
        InvalidatePosition()
    End Sub

    Private Sub InvalidatePosition()
        Thumb.Y = CInt(((_Value - _Minimum) / (_Maximum - _Minimum)) * (Shaft.Height - _ThumbSize) + 1)
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left AndAlso ShowThumb Then
            If TSA.Contains(e.Location) Then
                ThumbMovement = _Value - _SmallChange
            ElseIf BSA.Contains(e.Location) Then
                ThumbMovement = _Value + _SmallChange
            Else
                If Thumb.Contains(e.Location) Then
                    ThumbPressed = True
                    Return
                Else
                    If e.Y < Thumb.Y Then
                        ThumbMovement = _Value - _LargeChange
                    Else
                        ThumbMovement = _Value + _LargeChange
                    End If
                End If
            End If
            Value = Math.Min(Math.Max(ThumbMovement, _Minimum), _Maximum)
            InvalidatePosition()
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        If ThumbPressed AndAlso ShowThumb Then
            Dim ThumbPosition As Integer = e.Y - TSA.Height - (_ThumbSize \ 2)
            Dim ThumbBounds As Integer = Shaft.Height - _ThumbSize
            ThumbMovement = CInt((ThumbPosition / ThumbBounds) * (_Maximum - _Minimum)) + _Minimum
            Value = Math.Min(Math.Max(ThumbMovement, _Minimum), _Maximum)
            InvalidatePosition()
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        ThumbPressed = False
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or _
                            ControlStyles.UserPaint Or ControlStyles.Selectable Or _
                            ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Size = New Size(24, 50)
    End Sub

    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        Dim B As New Bitmap(Height, Height)
        Dim G = Graphics.FromImage(B)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(_BaseColour)
            Dim P() As Point = {New Point(Width / 2, 5), New Point(Width / 4, 13), New Point(Width / 2 - 2, 13), New Point(Width / 2 - 2, Height - 13), _
                                New Point(Width / 4, Height - 13), New Point(Width / 2, Height - 5), New Point(Width - Width / 4 - 1, Height - 13), New Point(Width / 2 + 2, Height - 13), _
                                New Point(Width / 2 + 2, 13), New Point(Width - Width / 4 - 1, 13)}
            .FillPolygon(New SolidBrush(_ArrowColour), P)
            .FillRectangle(New SolidBrush(_ThumbColour), Thumb)
            .DrawRectangle(New Pen(_ThumbBorder), Thumb)
            .DrawRectangle(New Pen(_ThumbSecondBorder), Thumb.X + 1, Thumb.Y + 1, Thumb.Width - 2, Thumb.Height - 2)
            .DrawLine(New Pen(_LineColour, 2), New Point(CInt(Thumb.Width / 2 + 1), Thumb.Y + 4), New Point(CInt(Thumb.Width / 2 + 1), Thumb.Bottom - 4))
            .DrawRectangle(New Pen(_FirstBorder), 0, 0, Width - 1, Height - 1)
            .DrawRectangle(New Pen(_SecondBorder), 1, 1, Width - 3, Height - 3)
        End With
        MyBase.OnPaint(e)
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

<DefaultEvent("Scroll")> _
Public Class LogInHorizontalScrollBar
    Inherits Control

#Region "Declarations"

    Private ThumbMovement As Integer
    Private LSA As Rectangle
    Private RSA As Rectangle
    Private Shaft As Rectangle
    Private Thumb As Rectangle
    Private ShowThumb As Boolean
    Private ThumbPressed As Boolean
    Private _ThumbSize As Integer = 24
    Private _Minimum As Integer = 0
    Private _Maximum As Integer = 100
    Private _Value As Integer = 0
    Private _SmallChange As Integer = 1
    Private _ButtonSize As Integer = 16
    Private _LargeChange As Integer = 10
    Private _ThumbBorder As Color = Color.FromArgb(35, 35, 35)
    Private _LineColour As Color = Color.FromArgb(23, 119, 151)
    Private _ArrowColour As Color = Color.FromArgb(37, 37, 37)
    Private _BaseColour As Color = Color.FromArgb(47, 47, 47)
    Private _ThumbColour As Color = Color.FromArgb(55, 55, 55)
    Private _ThumbSecondBorder As Color = Color.FromArgb(65, 65, 65)
    Private _FirstBorder As Color = Color.FromArgb(55, 55, 55)
    Private _SecondBorder As Color = Color.FromArgb(35, 35, 35)
    Private ThumbDown As Boolean = False
#End Region

#Region "Properties & Events"

    <Category("Colours")> _
    Public Property ThumbBorder As Color
        Get
            Return _ThumbBorder
        End Get
        Set(value As Color)
            _ThumbBorder = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property LineColour As Color
        Get
            Return _LineColour
        End Get
        Set(value As Color)
            _LineColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ArrowColour As Color
        Get
            Return _ArrowColour
        End Get
        Set(value As Color)
            _ArrowColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ThumbColour As Color
        Get
            Return _ThumbColour
        End Get
        Set(value As Color)
            _ThumbColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ThumbSecondBorder As Color
        Get
            Return _ThumbSecondBorder
        End Get
        Set(value As Color)
            _ThumbSecondBorder = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property FirstBorder As Color
        Get
            Return _FirstBorder
        End Get
        Set(value As Color)
            _FirstBorder = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property SecondBorder As Color
        Get
            Return _SecondBorder
        End Get
        Set(value As Color)
            _SecondBorder = value
        End Set
    End Property

    Event Scroll(ByVal sender As Object)

    Property Minimum() As Integer
        Get
            Return _Minimum
        End Get
        Set(ByVal value As Integer)
            _Minimum = value
            If value > _Value Then _Value = value
            If value > _Maximum Then _Maximum = value
            InvalidateLayout()
        End Set
    End Property

    Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal value As Integer)
            If value < _Value Then _Value = value
            If value < _Minimum Then _Minimum = value
        End Set
    End Property

    Property Value() As Integer
        Get
            Return _Value
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is = _Value
                    Exit Property
                Case Is < _Minimum
                    _Value = _Minimum
                Case Is > _Maximum
                    _Value = _Maximum
                Case Else
                    _Value = value
            End Select
            InvalidatePosition()
            RaiseEvent Scroll(Me)
        End Set
    End Property

    Public Property SmallChange() As Integer
        Get
            Return _SmallChange
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is < 1
                Case Is >
                    _SmallChange = value
            End Select
        End Set
    End Property

    Public Property LargeChange() As Integer
        Get
            Return _LargeChange
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is < 1
                Case Else
                    _LargeChange = value
            End Select
        End Set
    End Property

    Public Property ButtonSize As Integer
        Get
            Return _ButtonSize
        End Get
        Set(value As Integer)
            Select Case value
                Case Is < 16
                    _ButtonSize = 16
                Case Else
                    _ButtonSize = value
            End Select
        End Set
    End Property

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        InvalidateLayout()
    End Sub

    Private Sub InvalidateLayout()
        LSA = New Rectangle(0, 1, 0, Height)
        Shaft = New Rectangle(LSA.Right + 1, 0, Width - 3, Height)
        ShowThumb = ((_Maximum - _Minimum))
        Thumb = New Rectangle(0, 1, _ThumbSize, Height - 3)
        RaiseEvent Scroll(Me)
        InvalidatePosition()
    End Sub

    Private Sub InvalidatePosition()
        Thumb.X = CInt(((_Value - _Minimum) / (_Maximum - _Minimum)) * (Shaft.Width - _ThumbSize) + 1)
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left AndAlso ShowThumb Then
            If LSA.Contains(e.Location) Then
                ThumbMovement = _Value - _SmallChange
            ElseIf RSA.Contains(e.Location) Then
                ThumbMovement = _Value + _SmallChange
            Else
                If Thumb.Contains(e.Location) Then
                    ThumbDown = True
                    Return
                Else
                    If e.X < Thumb.X Then
                        ThumbMovement = _Value - _LargeChange
                    Else
                        ThumbMovement = _Value + _LargeChange
                    End If
                End If
            End If
            Value = Math.Min(Math.Max(ThumbMovement, _Minimum), _Maximum)
            InvalidatePosition()
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        If ThumbDown AndAlso ShowThumb Then
            Dim ThumbPosition As Integer = e.X - LSA.Width - (_ThumbSize \ 2)
            Dim ThumbBounds As Integer = Shaft.Width - _ThumbSize

            ThumbMovement = CInt((ThumbPosition / ThumbBounds) * (_Maximum - _Minimum)) + _Minimum

            Value = Math.Min(Math.Max(ThumbMovement, _Minimum), _Maximum)
            InvalidatePosition()
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        ThumbDown = False
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or _
                           ControlStyles.UserPaint Or ControlStyles.Selectable Or _
                           ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Height = 18
    End Sub

    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        Dim B As New Bitmap(Width, Width)
        Dim G = Graphics.FromImage(B)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(Color.FromArgb(47, 47, 47))
            Dim P() As Point = {New Point(5, Height / 2), New Point(13, Height / 4), New Point(13, Height / 2 - 2), New Point(Width - 13, Height / 2 - 2), _
                    New Point(Width - 13, Height / 4), New Point(Width - 5, Height / 2), New Point(Width - 13, Height - Height / 4 - 1), New Point(Width - 13, Height / 2 + 2), _
                               New Point(13, Height / 2 + 2), New Point(13, Height - Height / 4 - 1)}
            .FillPolygon(New SolidBrush(_ArrowColour), P)
            .FillRectangle(New SolidBrush(_ThumbColour), Thumb)
            .DrawRectangle(New Pen(_ThumbBorder), Thumb)
            .DrawRectangle(New Pen(_ThumbSecondBorder), Thumb.X + 1, Thumb.Y + 1, Thumb.Width - 2, Thumb.Height - 2)
            .DrawLine(New Pen((_LineColour), 2), New Point(Thumb.X + 4, (CInt(Thumb.Height / 2 + 1))), New Point(Thumb.Right - 4, (CInt(Thumb.Height / 2 + 1))))
            .DrawRectangle(New Pen(_FirstBorder), 0, 0, Width - 1, Height - 1)
            .DrawRectangle(New Pen(_SecondBorder), 1, 1, Width - 3, Height - 3)
        End With
        MyBase.OnPaint(e)
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInTitledListBoxWBuiltInScrollBar
    Inherits Control

#Region "Declarations"

    Private _Items As New List(Of LogInListBoxItem)
    Private ReadOnly _SelectedItems As New List(Of LogInListBoxItem)
    Private _MultiSelect As Boolean = True
    Private ItemHeight As Integer = 24
    Private ReadOnly VerticalScrollbar As LogInVerticalScrollBar
    Private _BaseColour As Color = Color.FromArgb(55, 55, 55)
    Private _SelectedItemColour As Color = Color.FromArgb(50, 50, 50)
    Private _NonSelectedItemColour As Color = Color.FromArgb(47, 47, 47)
    Private _TitleAreaColour As Color = Color.FromArgb(42, 42, 42)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)

#End Region

#Region "Properties & Events"

    <Category("Colours")> _
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property SelectedItemColour As Color
        Get
            Return _SelectedItemColour
        End Get
        Set(value As Color)
            _SelectedItemColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property NonSelectedItemColour As Color
        Get
            Return _NonSelectedItemColour
        End Get
        Set(value As Color)
            _NonSelectedItemColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property TitleAreaColour As Color
        Get
            Return _TitleAreaColour
        End Get
        Set(value As Color)
            _TitleAreaColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    Private Sub HandleScroll(ByVal sender As Object)
        Invalidate()
    End Sub

    Private Sub InvalidateScroll()
        VerticalScrollbar.Maximum = (_Items.Count * ItemHeight)
        Invalidate()
    End Sub

    Private Sub InvalidateLayout()
        VerticalScrollbar.Location = New Point(Width - VerticalScrollbar.Width - 2, 25)
        VerticalScrollbar.Size = New Size(18, Height - 27)
        Invalidate()
    End Sub

    Public Class LogInListBoxItem
        Property Text As String
        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)> _
    Public Property Items() As LogInListBoxItem()
        Get
            Return _Items.ToArray()
        End Get
        Set(ByVal value As LogInListBoxItem())
            _Items = New List(Of LogInListBoxItem)(value)
            InvalidateScroll()
        End Set
    End Property

    Public ReadOnly Property SelectedItems() As LogInListBoxItem()
        Get
            Return _SelectedItems.ToArray()
        End Get
    End Property

    Public Property MultiSelect() As Boolean
        Get
            Return _MultiSelect
        End Get
        Set(ByVal value As Boolean)
            _MultiSelect = value

            If _SelectedItems.Count > 1 Then
                _SelectedItems.RemoveRange(1, _SelectedItems.Count - 1)
            End If

            Invalidate()
        End Set
    End Property

    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            ItemHeight = CInt(Graphics.FromHwnd(Handle).MeasureString("@", Font).Height) + 6
            If VerticalScrollbar IsNot Nothing Then
                VerticalScrollbar.SmallChange = ItemHeight
                VerticalScrollbar.LargeChange = ItemHeight
            End If
            MyBase.Font = value
            InvalidateLayout()
        End Set
    End Property

    Public Sub AddItem(ByVal Items As String)
        Dim Item As New LogInListBoxItem()
        Item.Text = Items
        _Items.Add(Item)
        InvalidateScroll()
    End Sub

    Public Sub AddItems(ByVal Items() As String)
        For Each I In Items
            Dim Item As New LogInListBoxItem()
            Item.Text = I
            _Items.Add(Item)
        Next
        InvalidateScroll()
    End Sub

    Public Sub RemoveItemAt(ByVal index As Integer)
        _Items.RemoveAt(index)
        InvalidateScroll()
    End Sub

    Public Sub RemoveItem(ByVal item As LogInListBoxItem)
        _Items.Remove(item)
        InvalidateScroll()
    End Sub

    Public Sub RemoveItems(ByVal items As LogInListBoxItem())
        For Each I As LogInListBoxItem In items
            _Items.Remove(I)
        Next
        InvalidateScroll()
    End Sub

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        InvalidateLayout()
        MyBase.OnSizeChanged(e)
    End Sub

    Private Sub Vertical_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        Focus()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        Focus()

        If e.Button = MouseButtons.Left Then
            Dim Offset As Integer = CInt(VerticalScrollbar.Value * (VerticalScrollbar.Maximum - (Height - (ItemHeight * 2))))
            Dim Index As Integer = ((e.Y + Offset - ItemHeight) \ ItemHeight)

            If Index > _Items.Count - 1 Then Index = -1

            If Not Index = -1 Then

                If ModifierKeys = Keys.Control AndAlso _MultiSelect Then
                    If _SelectedItems.Contains(_Items(Index)) Then
                        _SelectedItems.Remove(_Items(Index))
                    Else
                        _SelectedItems.Add(_Items(Index))
                    End If
                Else
                    _SelectedItems.Clear()
                    _SelectedItems.Add(_Items(Index))
                End If
            End If

            Invalidate()
        End If
        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseWheel(ByVal e As MouseEventArgs)
        Dim Move As Integer = -((e.Delta * SystemInformation.MouseWheelScrollLines \ 120) * (ItemHeight \ 2))
        Dim Value As Integer = Math.Max(Math.Min(VerticalScrollbar.Value + Move, VerticalScrollbar.Maximum), VerticalScrollbar.Minimum)
        VerticalScrollbar.Value = Value
        MyBase.OnMouseWheel(e)
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or _
                    ControlStyles.UserPaint Or ControlStyles.Selectable Or _
                    ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        VerticalScrollbar = New LogInVerticalScrollBar
        VerticalScrollbar.SmallChange = ItemHeight
        VerticalScrollbar.LargeChange = ItemHeight
        AddHandler VerticalScrollbar.Scroll, AddressOf HandleScroll
        AddHandler VerticalScrollbar.MouseDown, AddressOf Vertical_MouseDown
        Controls.Add(VerticalScrollbar)
        InvalidateLayout()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim B As New Bitmap(Width, Width)
        Dim G = Graphics.FromImage(B)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(_BaseColour)
            Dim AllItems As LogInListBoxItem
            Dim Offset As Integer = CInt(VerticalScrollbar.Value * (VerticalScrollbar.Maximum - (Height - (ItemHeight * 2))))
            Dim StartIndex As Integer
            If Offset = 0 Then StartIndex = 0 Else StartIndex = (Offset \ ItemHeight)
            Dim EndIndex As Integer = Math.Min(StartIndex + (Height \ ItemHeight), _Items.Count - 1)
            For I As Integer = StartIndex To EndIndex
                AllItems = Items(I)
                Dim Y As Integer = (ItemHeight + (I * ItemHeight) + 1 - Offset) + CInt((ItemHeight / 2) - 8)
                If _SelectedItems.Contains(AllItems) Then
                    .FillRectangle(New SolidBrush(_SelectedItemColour), New Rectangle(0, ItemHeight + (I * ItemHeight) + 1 - Offset, Width - 19, ItemHeight - 1))
                Else
                    .FillRectangle(New SolidBrush(_NonSelectedItemColour), New Rectangle(0, ItemHeight + (I * ItemHeight) + 1 - Offset, Width - 19, ItemHeight - 1))
                End If
                .DrawLine(New Pen(_BorderColour), 0, (ItemHeight + (I * ItemHeight) + 1 - Offset) + ItemHeight - 1, Width - 18, (ItemHeight + (I * ItemHeight) + 1 - Offset) + ItemHeight - 1)
                .DrawString(AllItems.Text, New Font("Segoe UI", 8), New SolidBrush(_TextColour), 9, Y)
                .ResetClip()
            Next
            .FillRectangle(New SolidBrush(_TitleAreaColour), New Rectangle(0, 0, Width, ItemHeight))
            .DrawRectangle(New Pen(Color.FromArgb(35, 35, 35)), 1, 1, Width - 3, ItemHeight - 2)
            .DrawString(Text, New Font("Segoe UI", 10, FontStyle.Bold), New SolidBrush(_TextColour), New Rectangle(0, 0, Width, ItemHeight + 2), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
            .DrawRectangle(New Pen(Color.FromArgb(35, 35, 35), 2), 1, 0, Width - 2, Height - 1)
            .DrawLine(New Pen(_BorderColour), 0, ItemHeight, Width, ItemHeight)
            .DrawLine(New Pen(_BorderColour, 2), VerticalScrollbar.Location.X - 1, ItemHeight, VerticalScrollbar.Location.X - 1, Height)
        End With
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInListBoxWBuiltInScrollBar
    Inherits Control

#Region "Declarations"

    Private _Items As New List(Of LogInListBoxItem)
    Private ReadOnly _SelectedItems As New List(Of LogInListBoxItem)
    Private _MultiSelect As Boolean = True
    Private ItemHeight As Integer = 24
    Private ReadOnly VerticalScrollbar As LogInVerticalScrollBar
    Private _BaseColour As Color = Color.FromArgb(55, 55, 55)
    Private _SelectedItemColour As Color = Color.FromArgb(50, 50, 50)
    Private _NonSelectedItemColour As Color = Color.FromArgb(47, 47, 47)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)

#End Region

#Region "Properties & Events"

    <Category("Colours")> _
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property SelectedItemColour As Color
        Get
            Return _SelectedItemColour
        End Get
        Set(value As Color)
            _SelectedItemColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property NonSelectedItemColour As Color
        Get
            Return _NonSelectedItemColour
        End Get
        Set(value As Color)
            _NonSelectedItemColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    Private Sub HandleScroll(ByVal sender As Object)
        Invalidate()
    End Sub

    Private Sub InvalidateScroll()
        VerticalScrollbar.Maximum = (_Items.Count * ItemHeight)
        Invalidate()
    End Sub

    Private Sub InvalidateLayout()
        VerticalScrollbar.Location = New Point(Width - VerticalScrollbar.Width - 2, 2)
        VerticalScrollbar.Size = New Size(18, Height - 4)
        Invalidate()
    End Sub

    Public Class LogInListBoxItem
        Property Text As String
        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)> _
    Public Property Items() As LogInListBoxItem()
        Get
            Return _Items.ToArray()
        End Get
        Set(ByVal value As LogInListBoxItem())
            _Items = New List(Of LogInListBoxItem)(value)
            InvalidateScroll()
        End Set
    End Property

    Public ReadOnly Property SelectedItems() As LogInListBoxItem()
        Get
            Return _SelectedItems.ToArray()
        End Get
    End Property

    Public Property MultiSelect() As Boolean
        Get
            Return _MultiSelect
        End Get
        Set(ByVal value As Boolean)
            _MultiSelect = value

            If _SelectedItems.Count > 1 Then
                _SelectedItems.RemoveRange(1, _SelectedItems.Count - 1)
            End If

            Invalidate()
        End Set
    End Property

    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            ItemHeight = CInt(Graphics.FromHwnd(Handle).MeasureString("@", Font).Height) + 6
            If VerticalScrollbar IsNot Nothing Then
                VerticalScrollbar.SmallChange = ItemHeight
                VerticalScrollbar.LargeChange = ItemHeight
            End If
            MyBase.Font = value
            InvalidateLayout()
        End Set
    End Property

    Public Sub AddItem(ByVal Items As String)
        Dim Item As New LogInListBoxItem()
        Item.Text = Items
        _Items.Add(Item)
        InvalidateScroll()
    End Sub

    Public Sub AddItems(ByVal Items() As String)
        For Each I In Items
            Dim Item As New LogInListBoxItem()
            Item.Text = I
            _Items.Add(Item)
        Next
        InvalidateScroll()
    End Sub

    Public Sub RemoveItemAt(ByVal index As Integer)
        _Items.RemoveAt(index)
        InvalidateScroll()
    End Sub

    Public Sub RemoveItem(ByVal item As LogInListBoxItem)
        _Items.Remove(item)
        InvalidateScroll()
    End Sub

    Public Sub RemoveItems(ByVal items As LogInListBoxItem())
        For Each I As LogInListBoxItem In items
            _Items.Remove(I)
        Next
        InvalidateScroll()
    End Sub

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        InvalidateLayout()
        MyBase.OnSizeChanged(e)
    End Sub

    Private Sub Vertical_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        Focus()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        Focus()

        If e.Button = MouseButtons.Left Then
            Dim Offset As Integer = CInt(VerticalScrollbar.Value * (VerticalScrollbar.Maximum - (Height - (ItemHeight * 2))))
            Dim Index As Integer = ((e.Y + Offset) \ ItemHeight)

            If Index > _Items.Count - 1 Then Index = -1

            If Not Index = -1 Then

                If ModifierKeys = Keys.Control AndAlso _MultiSelect Then
                    If _SelectedItems.Contains(_Items(Index)) Then
                        _SelectedItems.Remove(_Items(Index))
                    Else
                        _SelectedItems.Add(_Items(Index))
                    End If
                Else
                    _SelectedItems.Clear()
                    _SelectedItems.Add(_Items(Index))
                End If
            End If

            Invalidate()
        End If
        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseWheel(ByVal e As MouseEventArgs)
        Dim Move As Integer = -((e.Delta * SystemInformation.MouseWheelScrollLines \ 120) * (ItemHeight \ 2))
        Dim Value As Integer = Math.Max(Math.Min(VerticalScrollbar.Value + Move, VerticalScrollbar.Maximum), VerticalScrollbar.Minimum)
        VerticalScrollbar.Value = Value
        MyBase.OnMouseWheel(e)
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or _
                    ControlStyles.UserPaint Or ControlStyles.Selectable Or _
                    ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        VerticalScrollbar = New LogInVerticalScrollBar
        VerticalScrollbar.SmallChange = ItemHeight
        VerticalScrollbar.LargeChange = ItemHeight
        AddHandler VerticalScrollbar.Scroll, AddressOf HandleScroll
        AddHandler VerticalScrollbar.MouseDown, AddressOf Vertical_MouseDown
        Controls.Add(VerticalScrollbar)
        InvalidateLayout()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim B As New Bitmap(Width, Width)
        Dim G = Graphics.FromImage(B)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(_BaseColour)
            Dim AllItems As LogInListBoxItem
            Dim Offset As Integer = CInt(VerticalScrollbar.Value * (VerticalScrollbar.Maximum - (Height - (ItemHeight * 2))))
            Dim StartIndex As Integer
            If Offset = 0 Then StartIndex = 0 Else StartIndex = (Offset \ ItemHeight)
            Dim EndIndex As Integer = Math.Min(StartIndex + (Height \ ItemHeight), _Items.Count - 1)
            For I As Integer = StartIndex To EndIndex
                AllItems = Items(I)
                Dim Y As Integer = ((I * ItemHeight) + 1 - Offset) + CInt((ItemHeight / 2) - 8)
                If _SelectedItems.Contains(AllItems) Then
                    .FillRectangle(New SolidBrush(_SelectedItemColour), New Rectangle(0, (I * ItemHeight) + 1 - Offset, Width - 19, ItemHeight - 1))
                Else
                    .FillRectangle(New SolidBrush(_NonSelectedItemColour), New Rectangle(0, (I * ItemHeight) + 1 - Offset, Width - 19, ItemHeight - 1))
                End If
                .DrawLine(New Pen(_BorderColour), 0, ((I * ItemHeight) + 1 - Offset) + ItemHeight - 1, Width - 18, ((I * ItemHeight) + 1 - Offset) + ItemHeight - 1)
                .DrawString(AllItems.Text, New Font("Segoe UI", 8), New SolidBrush(_TextColour), 9, Y)
                .ResetClip()
            Next
            .DrawRectangle(New Pen(Color.FromArgb(35, 35, 35), 2), 1, 1, Width - 2, Height - 2)
            '   .DrawLine(New Pen(_BorderColour), 0, ItemHeight, Width, ItemHeight)
            .DrawLine(New Pen(_BorderColour, 2), VerticalScrollbar.Location.X - 1, 0, VerticalScrollbar.Location.X - 1, Height)
        End With
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class
