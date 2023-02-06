'Name: Ice Cream Flavors
'Purpose: Display pictures of ice cream flavors
'Programmer: Lily Woodworth Wisdom on 2/6/23

Option Strict On
Option Infer Off
Option Explicit On


Public Class frmMain
    Private Sub listboxflavors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxFlavors.SelectedIndexChanged
        If ListBoxFlavors.SelectedIndex = 0 Then
            picFlavors.Image = My.Resources.strawberry_icecream
        ElseIf ListBoxFlavors.SelectedIndex = 1 Then
            picFlavors.Image = My.Resources.vanilla_ice_cream
        ElseIf ListBoxFlavors.SelectedIndex = 2 Then
            picFlavors.Image = My.Resources.chocolate_ice_cream
        ElseIf ListBoxFlavors.SelectedIndex = 3 Then
            picFlavors.Image = My.Resources.pistachio_ice_cream
        ElseIf ListBoxFlavors.SelectedIndex = 4 Then
            picFlavors.Image = My.Resources.CARAEML
        End If
    End Sub
End Class

