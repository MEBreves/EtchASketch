'Miranda Breves
'RCET0265
'Spring 2022
'Etch-A-Sketch Program
'https://github.com/MEBreves/EtchASketch

Option Strict On
Option Explicit On

Public Class EtchASketchForm

    'Declaring global variables
    Dim currentColor As Color = Color.Black
    Dim pictureBoxSelected As String = ""       'This determines which color box is selected so that the program
    'can highlight and select it for user display. 

    Private Sub EtchASketchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This load sub, for some reason, gets called multiple times during runtime. It could be due to refreshing some
        'elements. To make sure the code itself only runs once, it's set beside 

        'Declaring variables
        Static firstTime As Boolean = True
        Dim pictureBoxArray() As PictureBox = {ColorBox1, ColorBox2, ColorBox3, ColorBox4,
            ColorBox5, ColorBox6, ColorBox7, ColorBox8, ColorBox9}

        If firstTime Then

            'Making the first color box black
            pictureBoxSelected = ColorBox1.Name
            ColorBox1.BackColor = Color.Black

            'Setting a default thickness - a thickness of 1 is too small usually
            ThicknessSlider.Value = 4
            ThicknessValueLabel.Text = "4"

            'Setting the context menu to the drawbox
            DisplayPictureBox.ContextMenuStrip = ContextMenuStrip1

            'Adding tooltips to the form objects (buttons and the picture boxes)
            ToolTip.SetToolTip(DisplayPictureBox, "This is your drawing area. There are options in the right-click menu " &
                               "or the sidebar on the right.")
            ToolTip.SetToolTip(SelectColorButton, "This allows you to set the color of your pen. It can also be activated " &
                               "by the 'S' key.")
            'Setting the colorbox tool tips
            For i As Integer = 0 To (pictureBoxArray.Length() - 1)
                ToolTip.SetToolTip(pictureBoxArray(i), "This holds a color you have currently or previously set.")
            Next

            ToolTip.SetToolTip(ThicknessSlider, "This adjusts your pen size.")
            ToolTip.SetToolTip(DrawWaveformsButton, "This draws sine, cosine, and tangent waveforms in the drawing " &
                               "area. It can also be activated by the 'D' key.")
            ToolTip.SetToolTip(ClearButton, "This clears the drawing area. It can also be activated by the 'C' key.")
            ToolTip.SetToolTip(ExitButton, "This shuts down the program. It can also be activated by the 'X' key.")

            firstTime = False
        End If

    End Sub

    ' ========================================== Button Handling =================================================
    Private Sub SelectColorButton_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click,
        SelectColorToolStripMenuItem.Click, PenColorContextToolStrip.Click

        'This sub opens the color box and sets the color of the user's pen
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
        For i As Integer = 1 To 4
            If i = 2 Then                   'The 2nd iteration is the X and Y axis (want them bold and bright)
                pen.Width = 3
                pen.Color = Color.White
            Else                            'Other divisions are less important, and thus dim and not bold
                pen.Width = 1
                pen.Color = Color.Gray
            End If

            'X divisions
            display.DrawLine(pen, 0, CInt(i * drawHeight / 4), drawWidth, CInt(i * drawHeight / 4))
            'Y divisions
            display.DrawLine(pen, CInt(i * drawWidth / 4), 0, CInt(i * drawWidth / 4), drawHeight)
        Next

        'Draw graticules. Graticule size = 2% width, 4% height
        graticuleWidth = CInt(0.02 * drawWidth)
        graticuleHeight = CInt(0.04 * drawHeight)

        pen.Color = Color.Gray

        'There will be a total of 20 graticules for each axis, spaced in equal intervals.
        For i As Integer = 1 To 20
            'X Graticules
            display.DrawLine(pen, CInt(i * drawWidth / 20), CInt((drawHeight / 2) - (graticuleHeight / 2)),
                             CInt(i * drawWidth / 20), CInt((drawHeight / 2) + (graticuleHeight / 2)))

            'Y Graticules
            display.DrawLine(pen, CInt((drawWidth / 2) - (graticuleWidth / 2)), CInt(i * drawHeight / 20),
                                CInt((drawWidth / 2) + (graticuleWidth / 2)), CInt(i * drawHeight / 20))

        Next

        'Draw sine, cosine, and tangent waves across the screen, one cycle wide, in different colors
        sinPen.Width = 2
        cosPen.Width = 2
        tanPen.Width = 2
        xPosition = 0
        sinWaveOldY = CInt(drawHeight / 2)          'The Old Y variables represent where the line left off when drawing the 
        cosWaveOldY = CInt((drawHeight / 2) + ((drawHeight / 2) * Math.Cos(6.2831 * (0 / 40))))     'trigonometric functions
        tanWaveOldY = CInt(drawHeight / 2)

        'The for loop will draw 40 lines per trigonometric function so that the functions look smooth
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

            'This updates the point where the next line needs to start; it is the end of the last line
            xPosition = CInt(i * drawWidth / 40)
            sinWaveOldY = CInt((drawHeight / 2) + ((drawHeight / 2) * Math.Sin(6.2831 * (i / 40))))
            cosWaveOldY = CInt((drawHeight / 2) + ((drawHeight / 2) * Math.Cos(6.2831 * (i / 40))))
            tanWaveOldY = CInt((drawHeight / 2) + ((drawHeight / 2) * Math.Tan(6.2831 * ((40 - i) / 40))))

        Next

        'Doing some cleaning to help with system memory
        pen.Dispose()
        sinPen.Dispose()
        cosPen.Dispose()
        tanPen.Dispose()
        display.Dispose()

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click,
        ClearDrawingContextToolStrip.Click

        'Make the window shake twice, and then return back to its original spot
        For j As Integer = 0 To 2

            'Move down and right
            For i As Integer = 1 To 15
                Me.Location = New Point(Me.Location.X + 5, Me.Location.Y + 5)
                Threading.Thread.CurrentThread.Sleep(1) 'This smoothes the shaking movement
            Next

            'Move up and left
            For i As Integer = 1 To 15
                Me.Location = New Point(Me.Location.X - 5, Me.Location.Y - 5)
                Threading.Thread.CurrentThread.Sleep(1) 'This smoothes the shaking movement
            Next

        Next

        'Setting the drawing space background back to the original color and clearing it
        DisplayPictureBox.BackColor = Control.DefaultBackColor
        DisplayPictureBox.Invalidate()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click

        'Closes the program.
        Me.Close()

    End Sub

    ' =================================== File and Context Menu Handling ==========================================
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        'In the top file menu, this creates a message box that pops up when the user clicks Help > About.
        Dim aboutText As String = vbTab & "Etch-A-Sketch Program" & vbCrLf &
                                    vbTab & "Version 1.0 (Build 1.0)" & vbCrLf &
                                    vbTab & "Copyright (C) 2022 Secret Corporation. All Rights Reserved."

        MsgBox(aboutText, MsgBoxStyle.Information, "About")

    End Sub

    Private Sub BackgroundColorToolStrip_Click(sender As Object, e As EventArgs) Handles BackgroundColorContextToolStrip.Click

        'If the user chooses the background color context menu, a color dialog box will appear letting them change the
        'background color of the drawing area.
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            DisplayPictureBox.BackColor = ColorDialog1.Color
        End If

    End Sub

    ' ====================================== Display Box Event Handling ===========================================
    Private Sub EtchASketchForm_MouseMove(sender As Object, e As MouseEventArgs) Handles DisplayPictureBox.MouseMove

        'Declaring variables
        Static oldX, oldY As Integer

        'If the user presses the left button over the drawing area, their position in the drawing area will be captured
        'and sent to the sketch function to be drawn.
        Select Case e.Button.ToString
            Case "Left"
                Sketch(oldX, oldY, e.X, e.Y)
        End Select

        'The end position of the current line will become the beginning position of the next line so they are connected.
        oldX = e.X
        oldY = e.Y

    End Sub

    Private Sub EtchASketchForm_MouseClick(sender As Object, e As MouseEventArgs) Handles DisplayPictureBox.MouseClick

        'If the user presses the middle mouse wheel button over the drawing area, they can select a pen color.
        Select Case e.Button.ToString
            Case "Middle"
                SelectAColor()
        End Select

    End Sub

    ' =========================================== Drawing Handling =================================================
    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles ColorBox1.Click, ColorBox2.Click,
        ColorBox3.Click, ColorBox4.Click, ColorBox5.Click, ColorBox6.Click, ColorBox7.Click, ColorBox8.Click,
        ColorBox9.Click

        'Declaring variables

        'Because the  sender is not specified with an object type, a variable casting the sender to an object type
        '(PictureBox) must be created in order to satisfy the Option Strict guideline.
        Dim distinguishedSender As PictureBox = DirectCast(sender, PictureBox)
        Dim pictureBoxArray() As PictureBox = {ColorBox1, ColorBox2, ColorBox3, ColorBox4, ColorBox5, ColorBox6,
                                                ColorBox7, ColorBox8, ColorBox9}

        'If the user selects a color box, its color will be set as the current color and the pen color.
        currentColor = distinguishedSender.BackColor
        pictureBoxSelected = distinguishedSender.Name

        'This highlights the border around the selected color box for user display.
        For i As Integer = 0 To pictureBoxArray.Length - 1

            pictureBoxArray(i).Refresh()

        Next

        'Clearing the selected name so that when the display is refreshed the border isn't highlighted again.
        pictureBoxSelected = ""

    End Sub

    Private Sub ThicknessSlider_Scroll(sender As Object, e As EventArgs) Handles ThicknessSlider.Scroll

        'This updates the pen size label with the current thickness value for user display.
        ThicknessValueLabel.Text = CStr(ThicknessSlider.Value)

    End Sub

    Sub SelectAColor()

        'Declaring variables
        Dim pictureBoxUsed As Boolean = False
        Dim pictureBoxArray() As PictureBox = {ColorBox1, ColorBox2, ColorBox3, ColorBox4,
            ColorBox5, ColorBox6, ColorBox7, ColorBox8, ColorBox9}

        'If the user selects a color from the dialog box, set the currentColor to that color and fill the next
        'avaialble color box with that color. The borders of that newly filled colorbox will also be highlighted.
        If ColorDialog1.ShowDialog() = DialogResult.OK Then

            Me.currentColor = ColorDialog1.Color
            pictureBoxSelected = "Not Yet Found"

            For i As Integer = 0 To pictureBoxArray.Length - 1

                'The if statement figures out the color box to fill with the new color.
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

            'Clearing the selected name so that when the display is refreshed the border isn't highlighted again.
            pictureBoxSelected = ""

        End If

    End Sub

    Sub Sketch(ByVal oldX As Integer, ByVal oldY As Integer, ByVal currentX As Integer, ByVal currentY As Integer)

        'Declaring variables
        Dim pen As New Pen(currentColor)

        'Setting the user's pen size to the slider value
        pen.Width = ThicknessSlider.Value

        'Drawing a line from previous coordinates to the new coordinates of the user's mouse
        DisplayPictureBox.CreateGraphics.DrawLine(pen, oldX, oldY, currentX, currentY)

        'Clearing the pen to improve system memory.
        pen.Dispose()

    End Sub

    Private Sub PaintPictureBox(sender As Object, e As PaintEventArgs) Handles ColorBox1.Paint, ColorBox2.Paint,
        ColorBox3.Paint, ColorBox4.Paint, ColorBox5.Paint, ColorBox6.Paint, ColorBox7.Paint, ColorBox8.Paint,
        ColorBox9.Paint

        'Declaring variables
        Dim borderWidth As Integer
        Dim borderColor As Color

        'Because the  sender is not specified with an object type, a variable casting the sender to an object type
        '(PictureBox) must be created in order to satisfy the Option Strict guideline.
        Dim distinguishedSender As PictureBox = DirectCast(sender, PictureBox)
        Dim rectangle As Drawing.Rectangle = distinguishedSender.ClientRectangle

        'If the color box's name is the set name, its border will be highlighted for user display
        If distinguishedSender.Name = pictureBoxSelected Then
            borderWidth = 3

            'If the filled color of the box is yellow, its border will be highlighted black. If not, it will be
            'highlighted yellow.
            If distinguishedSender.BackColor = Color.Yellow Then
                borderColor = Color.Black
            Else
                borderColor = Color.Yellow
            End If

        Else        'If the color box is not the selected box, its border will be set black and back to its
            '       original thickness
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
