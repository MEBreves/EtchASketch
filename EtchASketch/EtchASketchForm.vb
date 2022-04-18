'Miranda Breves
'RCET0265
'Spring 2022
'Etch-A-Sketch Program
'github url

Option Strict On
Option Explicit On

Public Class EtchASketchForm

    Dim currentColor As Color = Color.Black
    Dim pictureBoxSelected As String = ""

    Private Sub EtchASketchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Static firstTime As Boolean = True

        If firstTime Then
            'Making the first color box black
            pictureBoxSelected = PictureBox2.Name
            PictureBox2.BackColor = Color.Black

            'Setting a default thickness - a thickness of 1 is too small usually
            ThicknessSlider.Value = 4
            ThicknessValueLabel.Text = "4"

            'Setting the context menu to the drawbox
            DisplayPictureBox.ContextMenuStrip = ContextMenuStrip1

            firstTime = False
        End If

    End Sub

    ' ========================================== Button Handling =================================================
    Private Sub SelectColorButton_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click,
        SelectColorToolStripMenuItem.Click, PenColorContextToolStrip.Click

        SelectAColor()

    End Sub

    Private Sub DrawWaveformsButton_Click(sender As Object, e As EventArgs) Handles DrawWaveformsButton.Click,
        DrawWaveformsToolStripMenuItem.Click, DrawWaveformsContextToolStrip.Click

        'Declaring variables
        Dim display As Graphics = DisplayPictureBox.CreateGraphics
        Dim pen As New Pen(currentColor)
        Dim sinPen As New Pen(Color.LawnGreen)
        Dim cosPen As New Pen(Color.Tomato)
        Dim tanPen As New Pen(Color.DeepSkyBlue)
        Dim drawWidth As Integer = DisplayPictureBox.Width
        Dim drawHeight As Integer = DisplayPictureBox.Height
        Dim graticuleWidth, graticuleHeight, xPosition, sinWaveOldY, cosWaveOldY, tanWaveOldY As Integer

        'Clear the picturebox
        DisplayPictureBox.BackColor = Color.Black
        DisplayPictureBox.Refresh()     'Display needs to refresh or else the following drawings won't show up

        'Draw screen divisions (axes and others)
        For i As Integer = 1 To 8
            If i = 4 Then                   'The 4th iteration is the X and Y axis (want them bold and bright)
                pen.Width = 3
                pen.Color = Color.White
            Else                            'Other divisions are less important, and thus dim and not bold
                pen.Width = 1
                pen.Color = Color.Gray
            End If

            'X divisions
            display.DrawLine(pen, 0, CInt(i * drawHeight / 8), drawWidth, CInt(i * drawHeight / 8))
            'Y divisions
            display.DrawLine(pen, CInt(i * drawWidth / 8), 0, CInt(i * drawWidth / 8), drawHeight)
        Next

        'Draw graticules. Graticule size = 2% width, 4% height
        graticuleWidth = CInt(0.02 * drawWidth)
        graticuleHeight = CInt(0.04 * drawHeight)

        pen.Color = Color.Gray

        For i As Integer = 1 To 40
            'X Graticules
            display.DrawLine(pen, CInt(i * drawWidth / 40), CInt((drawHeight / 2) - (graticuleHeight / 2)),
                             CInt(i * drawWidth / 40), CInt((drawHeight / 2) + (graticuleHeight / 2)))

            'Y Graticules
            display.DrawLine(pen, CInt((drawWidth / 2) - (graticuleWidth / 2)), CInt(i * drawHeight / 40),
                                CInt((drawWidth / 2) + (graticuleWidth / 2)), CInt(i * drawHeight / 40))

        Next

        'Draw sine, cosine, and tangent waves across the screen, one cycle wide, in different colors
        sinPen.Width = 2
        cosPen.Width = 2
        tanPen.Width = 2
        xPosition = 0
        sinWaveOldY = CInt(drawHeight / 2)
        cosWaveOldY = CInt((drawHeight / 2) + ((drawHeight / 2) * Math.Cos(6.2831 * (0 / 40))))
        tanWaveOldY = CInt(drawHeight / 2)

        For i As Integer = 1 To 40

            'Draw sine wave, 1 period
            display.DrawLine(sinPen, xPosition, sinWaveOldY, CInt(i * drawWidth / 40),
                             CInt((drawHeight / 2) + ((drawHeight / 2) * Math.Sin(6.2831 * (i / 40)))))

            'Draw cos wave, 1 period
            display.DrawLine(cosPen, xPosition, cosWaveOldY, CInt(i * drawWidth / 40),
                             CInt((drawHeight / 2) + ((drawHeight / 2) * Math.Cos(6.2831 * (i / 40)))))

            'Draw tan wave, 1 period
            display.DrawLine(tanPen, xPosition, tanWaveOldY, CInt(i * drawWidth / 40),
                             CInt((drawHeight / 2) + ((drawHeight / 2) * Math.Tan(6.2831 * ((40 - i) / 40)))))

            xPosition = CInt(i * drawWidth / 40)
            sinWaveOldY = CInt((drawHeight / 2) + ((drawHeight / 2) * Math.Sin(6.2831 * (i / 40))))
            cosWaveOldY = CInt((drawHeight / 2) + ((drawHeight / 2) * Math.Cos(6.2831 * (i / 40))))
            tanWaveOldY = CInt((drawHeight / 2) + ((drawHeight / 2) * Math.Tan(6.2831 * ((40 - i) / 40))))

        Next

        pen.Dispose()
        sinPen.Dispose()
        cosPen.Dispose()
        tanPen.Dispose()
        display.Dispose()

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click,
        ClearDrawingContextToolStrip.Click

        'Make the window shake
        For j As Integer = 0 To 2

            For i As Integer = 1 To 15
                Me.Location = New Point(Me.Location.X + 5, Me.Location.Y + 5)
                Threading.Thread.CurrentThread.Sleep(1)
            Next

            For i As Integer = 1 To 15
                Me.Location = New Point(Me.Location.X - 5, Me.Location.Y - 5)
                Threading.Thread.CurrentThread.Sleep(1)
            Next

        Next

        DisplayPictureBox.BackColor = Control.DefaultBackColor
        DisplayPictureBox.Invalidate()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' ======================================== Context Menu Handling ==============================================
    Private Sub BackgroundColorToolStrip_Click(sender As Object, e As EventArgs) Handles BackgroundColorContextToolStrip.Click

        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            DisplayPictureBox.BackColor = ColorDialog1.Color
        End If

    End Sub

    ' ====================================== Display Box Event Handling ===========================================
    Private Sub EtchASketchForm_MouseMove(sender As Object, e As MouseEventArgs) Handles DisplayPictureBox.MouseMove

        Static oldX, oldY As Integer

        Select Case e.Button.ToString
            Case "Left"
                Sketch(oldX, oldY, e.X, e.Y)
        End Select

        oldX = e.X
        oldY = e.Y

    End Sub

    Private Sub EtchASketchForm_MouseClick(sender As Object, e As MouseEventArgs) Handles DisplayPictureBox.MouseClick

        Select Case e.Button.ToString
            Case "Middle"
                SelectAColor()
        End Select

    End Sub

    ' =========================================== Drawing Handling =================================================
    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, PictureBox3.Click,
        PictureBox4.Click, PictureBox5.Click, PictureBox6.Click, PictureBox7.Click, PictureBox8.Click, PictureBox9.Click,
        PictureBox10.Click

        Dim distinguishedSender As PictureBox = DirectCast(sender, PictureBox)

        Dim pictureBoxArray() As PictureBox = {PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7,
                                                PictureBox8, PictureBox9, PictureBox10}

        currentColor = distinguishedSender.BackColor
        pictureBoxSelected = distinguishedSender.Name

        For i As Integer = 0 To pictureBoxArray.Length - 1

            pictureBoxArray(i).Refresh()

        Next

        pictureBoxSelected = ""

    End Sub

    Private Sub ThicknessSlider_Scroll(sender As Object, e As EventArgs) Handles ThicknessSlider.Scroll

        ThicknessValueLabel.Text = CStr(ThicknessSlider.Value)

    End Sub

    Sub SelectAColor()

        Dim pictureBoxUsed As Boolean = False
        Dim pictureBoxArray() As PictureBox = {PictureBox2, PictureBox3, PictureBox4, PictureBox5,
            PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10}

        If ColorDialog1.ShowDialog() = DialogResult.OK Then

            Me.currentColor = ColorDialog1.Color
            pictureBoxSelected = "Not Yet Found"

            For i As Integer = 0 To pictureBoxArray.Length - 1

                If pictureBoxArray(i).BackColor = Control.DefaultBackColor And Not pictureBoxUsed Then
                    pictureBoxSelected = pictureBoxArray(i).Name
                    pictureBoxArray(i).BackColor = ColorDialog1.Color
                    pictureBoxUsed = True

                ElseIf i = (pictureBoxArray.Length - 1) And Not pictureBoxUsed Then
                    pictureBoxArray(i).BackColor = ColorDialog1.Color
                    pictureBoxSelected = pictureBoxArray(i).Name

                End If

                'Changing the border to be yellow for the current color box and black for the unselected color boxes
                pictureBoxArray(i).Refresh()

            Next

            pictureBoxSelected = ""

        End If

    End Sub

    Sub Sketch(ByVal oldX As Integer, ByVal oldY As Integer, ByVal currentX As Integer, ByVal currentY As Integer)

        Dim pen As New Pen(currentColor)

        pen.Width = ThicknessSlider.Value
        DisplayPictureBox.CreateGraphics.DrawLine(pen, oldX, oldY, currentX, currentY)

        pen.Dispose()

    End Sub

    Private Sub PaintPictureBox(sender As Object, e As PaintEventArgs) Handles PictureBox2.Paint, PictureBox3.Paint,
        PictureBox4.Paint, PictureBox5.Paint, PictureBox6.Paint, PictureBox7.Paint, PictureBox8.Paint, PictureBox9.Paint,
        PictureBox10.Paint

        Dim borderWidth As Integer
        Dim borderColor As Color

        Dim distinguishedSender As PictureBox = DirectCast(sender, PictureBox)
        Dim rectangle As Drawing.Rectangle = distinguishedSender.ClientRectangle

        If distinguishedSender.Name = pictureBoxSelected Then
            borderWidth = 3

            If distinguishedSender.BackColor = Color.Yellow Then
                borderColor = Color.Black
            Else
                borderColor = Color.Yellow
            End If

        Else
            borderWidth = 1
            borderColor = Color.Black
        End If

        ControlPaint.DrawBorder(e.Graphics, rectangle,
                                            borderColor, borderWidth, ButtonBorderStyle.Solid,  'Left border
                                            borderColor, borderWidth, ButtonBorderStyle.Solid,  'Top border
                                            borderColor, borderWidth, ButtonBorderStyle.Solid,  'Right border
                                            borderColor, borderWidth, ButtonBorderStyle.Solid)  'Bottom border

    End Sub

End Class
