Public Class frmDraw
    Dim Xstart As Integer, Ystart As Integer
    Dim ColorCounter As Integer
    Dim g As System.Drawing.Graphics
    Dim myPen As New System.Drawing.Pen(Color.Black)
    Dim xSize As Integer = 1, xSizeIncrement As Integer
    Dim MakeBig As Integer = 1, MaxSize As Integer
    Dim MinSize As Integer, DrawWhat As String
   
    Private Sub frmDraw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        G = Me.CreateGraphics
        myPen.Width = 1
        myPen.Color = Color.Black
        MinSize = txtMin.Text : MaxSize = txtMax.Text
    End Sub



(Interface?)
    'Private Sub frmDraw_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
    '    Xstart = e.X
    '    Ystart = e.Y
    'End Sub

    'Private Sub frmDraw_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
    '    If e.Button = MouseButtons.Left Then
    '        If MakeBig = 1 Then
    '            If xSize > MaxSize Then
    '                MakeBig = 2
    '            End If
    '            If MakeBig = 2 Then
    '                If xSize <= MinSize Then
    '                    MakeBig = 1
    '                End If
    '             End If
    '            If MakeBig = 1 Then xSize += txtIncrement.Text
    '            If MakeBig = 2 Then xSize -= txtIncrement.Text

    '            If DrawWhat = "CIRCLES" Then
    '                g.DrawEllipse(myPen, e.X, e.Y, xSize, xSize)
    '            End If
    '            If DrawWhat = "LINES" Then
    '                g.FillEllipse(New SolidBrush(myPen.Color), e.X, e.Y, xSize, xSize)
    '            End If
    '            If DrawWhat = "ZONGERS" Then
    '                g.DrawLine(myPen, Xstart, Ystart, e.X, e.Y)
    '            End If
    '        End If
    '    End If

    'End Sub


    Private Sub tbMin_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbMin.Scroll
        txtMin.Text = tbMin.Value
        MinSize = txtMin.Text
        xSize = txtMin.Text
    End Sub

    Private Sub tbMax_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbMax.Scroll
        txtMax.Text = tbMax.Value
        MaxSize = txtMax.Text
        xSize = txtMin.Text
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Me.Refresh()
    End Sub

    Private Sub btnSetColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetColor.Click
        Dim ColorBox As ColorDialog = New ColorDialog()
        Dim Result As DialogResult
        Result = ColorBox.ShowDialog()
        If Result = DialogResult.Cancel Then Exit Sub
        myPen.Color = ColorBox.Color
    End Sub

    Private Sub btnCircles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCircles.Click
        DrawWhat = "CIRCLES"
    End Sub

    Private Sub btnLines_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLines.Click
        DrawWhat = "LINES"

    End Sub

    Private Sub btnZongers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZongers.Click
        DrawWhat = "ZONGERS"
    End Sub

    'Private Sub Panel1_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel1.MouseClick
    '    Select Case Panel1.
    '        Case 0 : Me.Dispose()
    '        Case 1 : Me.Refresh()
    '        Case 2
    '            Dim ColorBox As ColorDialog = New ColorDialog()
    '            Dim Result As DialogResult
    '            Result = ColorBox.ShowDialog()
    '            If Result = DialogResult.Cancel Then Exit Sub
    '            myPen.Color = ColorBox.Color
    '        Case 3 : DrawWhat = "CIRCLES"
    '        Case 4 : DrawWhat = "LINES"
    '        Case 5 : DrawWhat = "ZONGERS"
    '    End Select
    'End Sub

    Private Sub frmDraw_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Xstart = e.X
        Ystart = e.Y
    End Sub

    Private Sub frmDraw_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            If MakeBig = 1 Then
                If xSize > MaxSize Then
                    MakeBig = 2
                End If
            End If

            If MakeBig = 2 Then
                If xSize <= MinSize Then
                    MakeBig = 1
                End If
            End If
            If MakeBig = 1 Then xSize += txtIncrement.Text
            If MakeBig = 2 Then xSize -= txtIncrement.Text

            If DrawWhat = "CIRCLES" Then
                g.DrawEllipse(myPen, e.X, e.Y, xSize, xSize)
            End If
            If DrawWhat = "LINES" Then
                g.FillEllipse(New SolidBrush(myPen.Color), e.X, e.Y, xSize, xSize)
            End If
            If DrawWhat = "ZONGERS" Then
                g.DrawLine(myPen, Xstart, Ystart, e.X, e.Y)
            End If
        End If


    End Sub

End Class