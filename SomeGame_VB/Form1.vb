Public Class Form1



    Private Sub TickTimer_Tick(sender As Object, e As EventArgs) Handles TickTimer.Tick
        'At each tick, move the stuff
        CycleThroughMovableObjects()
    End Sub

    Private Sub CycleThroughMovableObjects()
        'Go through each movable object and change it's state

        'Move object 1
        MoveObject(ToyPanel, ToyEnabledCheckBox.Checked, ToyHSpeedNumericUpDown.Value, ToyVSpeedNumericUpDown.Value)
        ValidateObjectPosition(ToyPanel, 0 - ToyPanel.Width, PlayAreaPanel.Width + ToyPanel.Width, 0 - ToyPanel.Height, PlayAreaPanel.Height + ToyPanel.Height) 'Allow the toy to leave the border, and only move once it's gone

        'Move object 2
        MoveObject(GreenToyPanel, GreenToyEnabledCheckBox.Checked, GreenToyHSpeedNumericUpDown.Value, GreenToyVSpeedNumericUpDown.Value)
        ValidateObjectPosition(GreenToyPanel, 0 - GreenToyPanel.Width, PlayAreaPanel.Width + GreenToyPanel.Width, 0 - GreenToyPanel.Height, PlayAreaPanel.Height + GreenToyPanel.Height) 'Allow the toy to leave the border, and only move once it's gone


    End Sub

    Private Sub ValidateObjectPosition(Toy As Object, LeftBorder As Integer, RightBorder As Integer, TopBorder As Integer, BottomBorder As Integer)
        'If the object has gone outside of the bounds, adjust as needed
        'wrap for now, maybe bounce later

        If Toy.Location.x < LeftBorder Then
            'Passed the left border, wrap to the right
            Toy.location = New Point(RightBorder, Toy.location.y)
        End If

        If Toy.location.x > RightBorder Then
            'Passed the right border, wrap to the left
            Toy.location = New Point(LeftBorder, Toy.location.y)
        End If

        If Toy.location.y < TopBorder Then
            'Passed the top border, wrap to the bottom
            Toy.location = New Point(Toy.location.x, BottomBorder)
        End If

        If Toy.location.y > BottomBorder Then
            'Passed the bottom border, wrap to the top
            Toy.location = New Point(Toy.location.x, TopBorder)
        End If

    End Sub

    Private Sub MoveObject(Toy As Object, isEnabled As Boolean, dx As Integer, dy As Integer)
        'Move the object that was sent
        'If Enabled

        If isEnabled Then
            'It's enabled, apply the movement
            Toy.Location = New Point(Toy.Location.X + dx, Toy.Location.Y + dy)
        End If

        'ToyPanel

    End Sub

    Private Sub GreenToyPictureBox_Click(sender As Object, e As EventArgs) Handles GreenToyPictureBox.Click

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        On Error Resume Next
        ' When the movement keys are pressed, change the velocity of the cars.
        If (e.KeyCode = Keys.D) Then
            ToyHSpeedNumericUpDown.Value += 1
        ElseIf (e.KeyCode = Keys.a) Then
            ToyHSpeedNumericUpDown.Value -= 1
        ElseIf (e.KeyCode = Keys.l) Then
            GreenToyHSpeedNumericUpDown.Value += 1
        ElseIf (e.KeyCode = Keys.j) Then
            GreenToyHSpeedNumericUpDown.Value -= 1
        ElseIf (e.KeyCode = Keys.W) Then
            ToyVSpeedNumericUpDown.Value -= 1
        ElseIf (e.KeyCode = Keys.s) Then
            ToyVSpeedNumericUpDown.Value += 1
        ElseIf (e.KeyCode = Keys.I) Then
            GreenToyVSpeedNumericUpDown.Value -= 1
        ElseIf (e.KeyCode = Keys.K) Then
            GreenToyVSpeedNumericUpDown.Value += 1
        End If
    End Sub
End Class
