
Partial Class _Default
    Inherits System.Web.UI.Page

    Sub disp_values()
        If Trim(txt1.Text) = "" Then txt1.Text = "0"
        If CInt(txt1.Text) > 0 Then
            panel2.Visible = "true"

            calc1()
            calc2()
        Else
            panel2.Visible = "false"
        End If


    End Sub

    Sub calc1()

        Dim lbl2 As String
        Dim lbl3 As String
        Dim lbl4 As String

        For i As Integer = 0 To CInt(txt1.Text)
            If lbl2 = "" Then
                lbl2 = i
            Else
                lbl2 = lbl2 & "," & i
            End If
            label2.Text = lbl2 'all  nos

            If i Mod 2 = 0 Then
                If lbl3 = "" Then
                    lbl3 = i
                Else
                    lbl3 = lbl3 & "," & i
                End If
                ' MsgBox("The number " & " " & i & " is an even number")
            Else
                If lbl4 = "" Then
                    lbl4 = i
                Else
                    lbl4 = lbl4 & "," & i
                End If
                ' MsgBox(i & " " & "is an Odd number")
            End If

            label3.Text = lbl3 'odd nos
            label7.Text = lbl4 'even nos
        Next

    End Sub

    Sub calc2()
        Dim list1 As String
        For i As Integer = 0 To CInt(txt1.Text)
            Dim v1 = fibnoacci_func(i)
            If v1 > CInt(txt1.Text) Then
                label1.Text = list1 'fibnoacci nos
                Exit Sub
            Else
                If list1 = "" Then
                    list1 = v1
                Else
                    list1 = list1 & "," & v1
                End If
                label1.Text = list1 'fibnoacci nos
            End If
        Next
    End Sub

    Function fibnoacci_func(ByVal n As Integer) As ULong
        Dim no1 As ULong = 0
        Dim no2 As ULong = 1

        For i As Integer = 0 To n - 1
            Dim no3 As ULong = no1
            no1 = no2
            no2 = no3 + no2
        Next
        Return no1
    End Function

End Class
