'Author: Chris Manek'
'Date: 1/26/2016'
'Description: Hangman game designed in Visual Studio VB.NET'
'Version: 2.0'

'Variables being declared'
Public Class Form_Hangman
    Dim word As String
    Dim testLetter As String
    Dim thisLetter As String
    Dim guess As String
    Dim wins As Integer = 0
    Dim loses As Integer = 0
    Dim score As Integer = 0
    Dim answer As String

    'If the user clicks new word, a new word is displayed and the hangman game is reset'
    Private Sub btn_NewWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NewWord.Click
        word = ""
        lbl_guessedLetters.Text = ""
        testLetter = ""
        txtbox_GuessWord.Text = ""
        Call showWord()
        'Enable Buttons to begin game'
        btn_A.Enabled = True
        btn_B.Enabled = True
        btn_C.Enabled = True
        btn_D.Enabled = True
        btn_E.Enabled = True
        btn_F.Enabled = True
        btn_G.Enabled = True
        btn_H.Enabled = True
        btn_I.Enabled = True
        btn_J.Enabled = True
        btn_K.Enabled = True
        btn_L.Enabled = True
        btn_M.Enabled = True
        btn_N.Enabled = True
        btn_O.Enabled = True
        btn_P.Enabled = True
        btn_Q.Enabled = True
        btn_R.Enabled = True
        btn_S.Enabled = True
        btn_T.Enabled = True
        btn_U.Enabled = True
        btn_V.Enabled = True
        btn_W.Enabled = True
        btn_X.Enabled = True
        btn_Y.Enabled = True
        btn_Z.Enabled = True
        PictureBox1.Image = FinalProject.My.Resources.Resources.Stage1
        score = 0
    End Sub
    'Code is running when the form loads, not when the game starts! Default all the buttons to unclickable'
    Private Sub Form_Hangman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_A.Enabled = False
        btn_B.Enabled = False
        btn_C.Enabled = False
        btn_D.Enabled = False
        btn_E.Enabled = False
        btn_F.Enabled = False
        btn_G.Enabled = False
        btn_H.Enabled = False
        btn_I.Enabled = False
        btn_J.Enabled = False
        btn_K.Enabled = False
        btn_L.Enabled = False
        btn_M.Enabled = False
        btn_N.Enabled = False
        btn_O.Enabled = False
        btn_P.Enabled = False
        btn_Q.Enabled = False
        btn_R.Enabled = False
        btn_S.Enabled = False
        btn_T.Enabled = False
        btn_U.Enabled = False
        btn_V.Enabled = False
        btn_W.Enabled = False
        btn_X.Enabled = False
        btn_Y.Enabled = False
        btn_Z.Enabled = False
        txtbox_GuessWord.Enabled = False
        btn_Guess.Enabled = False
        btn_NewWord.Enabled = False
        btn_End.Enabled = False
    End Sub
    'These Items are enabled when the user clicks start game'
    Private Sub btn_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Start.Click
        btn_A.Enabled = True
        btn_B.Enabled = True
        btn_C.Enabled = True
        btn_D.Enabled = True
        btn_E.Enabled = True
        btn_F.Enabled = True
        btn_G.Enabled = True
        btn_H.Enabled = True
        btn_I.Enabled = True
        btn_J.Enabled = True
        btn_K.Enabled = True
        btn_L.Enabled = True
        btn_M.Enabled = True
        btn_N.Enabled = True
        btn_O.Enabled = True
        btn_P.Enabled = True
        btn_Q.Enabled = True
        btn_R.Enabled = True
        btn_S.Enabled = True
        btn_T.Enabled = True
        btn_U.Enabled = True
        btn_V.Enabled = True
        btn_W.Enabled = True
        btn_X.Enabled = True
        btn_Y.Enabled = True
        btn_Z.Enabled = True
        txtbox_GuessWord.Enabled = True
        btn_Guess.Enabled = True
        btn_NewWord.Enabled = True
        btn_End.Enabled = True
        Call showWord()
        btn_Start.Visible = False
        txt_loses.Text = loses
        txt_wins.Text = wins
        PictureBox1.Image = My.Resources.Stage1
    End Sub
    'Win Function'
    Private Sub win()
        If lbl_word.Text.IndexOf("_") = -1 Then
            MsgBox("You Win Congrats")
            wins += 1
            txt_wins.Text = wins
            btn_NewWord.PerformClick()
        End If

    End Sub
    'Lose Function'
    Private Sub Lose()
        If word.IndexOf(thisLetter) = -1 Then
            score += 1
            'Select Case for misses or wrong letter fill these up and Lose the game'
            Select Case score
                Case 0
                    PictureBox1.Image = My.Resources.Stage1
                Case 1
                    PictureBox1.Image = My.Resources.stage2
                Case 2
                    PictureBox1.Image = My.Resources.stage3
                Case 3
                    PictureBox1.Image = My.Resources.stage4
                Case 4
                    PictureBox1.Image = My.Resources.stage5
                Case 5
                    PictureBox1.Image = My.Resources.stage6
                Case 6
                    PictureBox1.Image = My.Resources.stage7
                    If score = 6 Then
                        loses += 1
                        txt_loses.Text = loses
                        MsgBox("You Lost Nice Try Though")
                        btn_NewWord.PerformClick()
                    End If
            End Select
        End If
    End Sub
    'Generates a Random Number and uses that number to pick from a wordlist array'
    Private Sub showWord()
        'Generate Random Number'
        Randomize()
        Dim randomNumber As Integer = Int(5 * Rnd()) + 1
        'Set my wordlist'
        Dim words() As String
        words = My.Resources.list.Split(vbNewLine)
        
        word = words(randomNumber - 1)

        Dim output As String = ""

        For i As Integer = 1 To word.Length - 1
            output &= " _"
        Next
        lbl_word.Text = output
        answer = output
    End Sub
    'When the user clicks a letter this will test if the letter chosen was part of the word selected'
    Private Sub tryLetter()
        lbl_guessedLetters.Text = testLetter

        Dim output As String = ""

        For i As Integer = 1 To word.Length - 1
            If (testLetter.IndexOf(word.Substring(i, 1)) <> -1) Then
                output &= " " & word.Substring(i, 1) & " "
            Else
                output &= " _"
            End If
        Next
        lbl_word.Text = output

    End Sub
    'Setup each button'
    Private Sub btn_A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_A.Click
        testLetter += "a"
        thisLetter = "a"
        btn_A.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_B.Click
        testLetter += "b"
        thisLetter = "b"
        btn_B.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_C.Click
        testLetter += "c"
        thisLetter = "c"
        btn_C.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_D_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_D.Click
        testLetter += "d"
        thisLetter = "d"
        btn_D.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_E.Click
        testLetter += "e"
        thisLetter = "e"
        btn_E.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_F_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_F.Click
        testLetter += "f"
        thisLetter = "f"
        btn_F.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_G_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_G.Click
        testLetter += "g"
        thisLetter = "g"
        btn_G.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_H_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_H.Click
        testLetter += "h"
        thisLetter = "h"
        btn_H.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_I_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_I.Click
        testLetter += "i"
        thisLetter = "i"
        btn_I.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_J_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_J.Click
        testLetter += "j"
        thisLetter = "j"
        btn_J.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_K_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_K.Click
        testLetter += "k"
        thisLetter = "k"
        btn_K.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_L_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_L.Click
        testLetter += "l"
        thisLetter = "l"
        btn_L.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_M_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_M.Click
        testLetter += "m"
        thisLetter = "m"
        btn_M.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_N_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_N.Click
        testLetter += "n"
        thisLetter = "n"
        btn_N.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_O_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_O.Click
        testLetter += "o"
        thisLetter = "o"
        btn_O.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_P_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_P.Click
        testLetter += "p"
        thisLetter = "p"
        btn_P.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_Q_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Q.Click
        testLetter += "q"
        thisLetter = "q"
        btn_Q.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_R_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_R.Click
        testLetter += "r"
        thisLetter = "r"
        btn_R.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_S_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_S.Click
        testLetter += "s"
        thisLetter = "s"
        btn_S.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_T_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_T.Click
        testLetter += "t"
        thisLetter = "t"
        btn_T.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_U_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_U.Click
        testLetter += "u"
        thisLetter = "u"
        btn_U.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_V.Click
        testLetter += "v"
        thisLetter = "v"
        btn_V.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_W_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_W.Click
        testLetter += "w"
        thisLetter = "w"
        btn_W.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_X_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_X.Click
        testLetter += "x"
        thisLetter = "x"
        btn_X.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_Y_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Y.Click
        testLetter += "y"
        thisLetter = "y"
        btn_Y.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'Setup each button'
    Private Sub btn_Z_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Z.Click
        testLetter += "z"
        thisLetter = "z"
        btn_Z.Enabled = False
        Call tryLetter()
        Call Lose()
        Call win()
    End Sub
    'This function test the guess word to see if it matches the word that was selected if it does you win if it doesnt you lose'
    Private Sub btn_Guess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guess.Click
        guess = txtbox_GuessWord.Text
        If InStr(word, guess, vbTextCompare) Then
            MsgBox("You Won!")
            wins += 1
            txt_wins.Text = wins
            txtbox_GuessWord.Text = ""
            btn_NewWord.PerformClick()



            'You lose code'
        Else
            MsgBox("You Lost!")
            loses += 1
            txt_loses.Text = loses
            txtbox_GuessWord.Text = ""
            btn_NewWord.PerformClick()
        End If

    End Sub
    'End of game code'
    Private Sub btn_End_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_End.Click
        MsgBox("Thanks For Playing Hangman, hope you had fun!")
        Me.Close()
    End Sub
End Class
