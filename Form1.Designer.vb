<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Hangman
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Hangman))
        Me.btn_A = New System.Windows.Forms.Button()
        Me.btn_B = New System.Windows.Forms.Button()
        Me.btn_C = New System.Windows.Forms.Button()
        Me.btn_E = New System.Windows.Forms.Button()
        Me.btn_D = New System.Windows.Forms.Button()
        Me.btn_F = New System.Windows.Forms.Button()
        Me.btn_K = New System.Windows.Forms.Button()
        Me.btn_J = New System.Windows.Forms.Button()
        Me.btn_L = New System.Windows.Forms.Button()
        Me.btn_I = New System.Windows.Forms.Button()
        Me.btn_H = New System.Windows.Forms.Button()
        Me.btn_G = New System.Windows.Forms.Button()
        Me.btn_Q = New System.Windows.Forms.Button()
        Me.btn_P = New System.Windows.Forms.Button()
        Me.btn_R = New System.Windows.Forms.Button()
        Me.btn_O = New System.Windows.Forms.Button()
        Me.btn_N = New System.Windows.Forms.Button()
        Me.btn_M = New System.Windows.Forms.Button()
        Me.btn_W = New System.Windows.Forms.Button()
        Me.btn_V = New System.Windows.Forms.Button()
        Me.btn_X = New System.Windows.Forms.Button()
        Me.btn_U = New System.Windows.Forms.Button()
        Me.btn_T = New System.Windows.Forms.Button()
        Me.btn_S = New System.Windows.Forms.Button()
        Me.btn_Y = New System.Windows.Forms.Button()
        Me.btn_Z = New System.Windows.Forms.Button()
        Me.btn_NewWord = New System.Windows.Forms.Button()
        Me.btn_Start = New System.Windows.Forms.Button()
        Me.btn_End = New System.Windows.Forms.Button()
        Me.groupLetters = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_Guess = New System.Windows.Forms.Button()
        Me.txtbox_GuessWord = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_word = New System.Windows.Forms.Label()
        Me.lbl_guessedLetters = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_wins = New System.Windows.Forms.TextBox()
        Me.txt_loses = New System.Windows.Forms.TextBox()
        Me.groupLetters.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_A
        '
        Me.btn_A.BackColor = System.Drawing.Color.Transparent
        Me.btn_A.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_A.FlatAppearance.BorderSize = 10
        Me.btn_A.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_A.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_A.Location = New System.Drawing.Point(28, 33)
        Me.btn_A.Name = "btn_A"
        Me.btn_A.Size = New System.Drawing.Size(28, 23)
        Me.btn_A.TabIndex = 0
        Me.btn_A.Text = "A"
        Me.btn_A.UseVisualStyleBackColor = False
        '
        'btn_B
        '
        Me.btn_B.Location = New System.Drawing.Point(62, 33)
        Me.btn_B.Name = "btn_B"
        Me.btn_B.Size = New System.Drawing.Size(28, 23)
        Me.btn_B.TabIndex = 1
        Me.btn_B.Text = "B"
        Me.btn_B.UseVisualStyleBackColor = True
        '
        'btn_C
        '
        Me.btn_C.Location = New System.Drawing.Point(96, 33)
        Me.btn_C.Name = "btn_C"
        Me.btn_C.Size = New System.Drawing.Size(28, 23)
        Me.btn_C.TabIndex = 2
        Me.btn_C.Text = "C"
        Me.btn_C.UseVisualStyleBackColor = True
        '
        'btn_E
        '
        Me.btn_E.Location = New System.Drawing.Point(164, 33)
        Me.btn_E.Name = "btn_E"
        Me.btn_E.Size = New System.Drawing.Size(28, 23)
        Me.btn_E.TabIndex = 5
        Me.btn_E.Text = "E"
        Me.btn_E.UseVisualStyleBackColor = True
        '
        'btn_D
        '
        Me.btn_D.Location = New System.Drawing.Point(130, 33)
        Me.btn_D.Name = "btn_D"
        Me.btn_D.Size = New System.Drawing.Size(28, 23)
        Me.btn_D.TabIndex = 4
        Me.btn_D.Text = "D"
        Me.btn_D.UseVisualStyleBackColor = True
        '
        'btn_F
        '
        Me.btn_F.Location = New System.Drawing.Point(198, 33)
        Me.btn_F.Name = "btn_F"
        Me.btn_F.Size = New System.Drawing.Size(28, 23)
        Me.btn_F.TabIndex = 3
        Me.btn_F.Text = "F"
        Me.btn_F.UseVisualStyleBackColor = True
        '
        'btn_K
        '
        Me.btn_K.Location = New System.Drawing.Point(164, 62)
        Me.btn_K.Name = "btn_K"
        Me.btn_K.Size = New System.Drawing.Size(28, 23)
        Me.btn_K.TabIndex = 11
        Me.btn_K.Text = "K"
        Me.btn_K.UseVisualStyleBackColor = True
        '
        'btn_J
        '
        Me.btn_J.Location = New System.Drawing.Point(130, 62)
        Me.btn_J.Name = "btn_J"
        Me.btn_J.Size = New System.Drawing.Size(28, 23)
        Me.btn_J.TabIndex = 10
        Me.btn_J.Text = "J"
        Me.btn_J.UseVisualStyleBackColor = True
        '
        'btn_L
        '
        Me.btn_L.Location = New System.Drawing.Point(198, 62)
        Me.btn_L.Name = "btn_L"
        Me.btn_L.Size = New System.Drawing.Size(28, 23)
        Me.btn_L.TabIndex = 9
        Me.btn_L.Text = "L"
        Me.btn_L.UseVisualStyleBackColor = True
        '
        'btn_I
        '
        Me.btn_I.Location = New System.Drawing.Point(96, 62)
        Me.btn_I.Name = "btn_I"
        Me.btn_I.Size = New System.Drawing.Size(28, 23)
        Me.btn_I.TabIndex = 8
        Me.btn_I.Text = "I"
        Me.btn_I.UseVisualStyleBackColor = True
        '
        'btn_H
        '
        Me.btn_H.Location = New System.Drawing.Point(62, 62)
        Me.btn_H.Name = "btn_H"
        Me.btn_H.Size = New System.Drawing.Size(28, 23)
        Me.btn_H.TabIndex = 7
        Me.btn_H.Text = "H"
        Me.btn_H.UseVisualStyleBackColor = True
        '
        'btn_G
        '
        Me.btn_G.Location = New System.Drawing.Point(28, 62)
        Me.btn_G.Name = "btn_G"
        Me.btn_G.Size = New System.Drawing.Size(28, 23)
        Me.btn_G.TabIndex = 6
        Me.btn_G.Text = "G"
        Me.btn_G.UseVisualStyleBackColor = True
        '
        'btn_Q
        '
        Me.btn_Q.Location = New System.Drawing.Point(164, 91)
        Me.btn_Q.Name = "btn_Q"
        Me.btn_Q.Size = New System.Drawing.Size(28, 23)
        Me.btn_Q.TabIndex = 17
        Me.btn_Q.Text = "Q"
        Me.btn_Q.UseVisualStyleBackColor = True
        '
        'btn_P
        '
        Me.btn_P.Location = New System.Drawing.Point(130, 91)
        Me.btn_P.Name = "btn_P"
        Me.btn_P.Size = New System.Drawing.Size(28, 23)
        Me.btn_P.TabIndex = 16
        Me.btn_P.Text = "P"
        Me.btn_P.UseVisualStyleBackColor = True
        '
        'btn_R
        '
        Me.btn_R.Location = New System.Drawing.Point(198, 91)
        Me.btn_R.Name = "btn_R"
        Me.btn_R.Size = New System.Drawing.Size(28, 23)
        Me.btn_R.TabIndex = 15
        Me.btn_R.Text = "R"
        Me.btn_R.UseVisualStyleBackColor = True
        '
        'btn_O
        '
        Me.btn_O.Location = New System.Drawing.Point(96, 91)
        Me.btn_O.Name = "btn_O"
        Me.btn_O.Size = New System.Drawing.Size(28, 23)
        Me.btn_O.TabIndex = 14
        Me.btn_O.Text = "O"
        Me.btn_O.UseVisualStyleBackColor = True
        '
        'btn_N
        '
        Me.btn_N.Location = New System.Drawing.Point(62, 91)
        Me.btn_N.Name = "btn_N"
        Me.btn_N.Size = New System.Drawing.Size(28, 23)
        Me.btn_N.TabIndex = 13
        Me.btn_N.Text = "N"
        Me.btn_N.UseVisualStyleBackColor = True
        '
        'btn_M
        '
        Me.btn_M.Location = New System.Drawing.Point(28, 91)
        Me.btn_M.Name = "btn_M"
        Me.btn_M.Size = New System.Drawing.Size(28, 23)
        Me.btn_M.TabIndex = 12
        Me.btn_M.Text = "M"
        Me.btn_M.UseVisualStyleBackColor = True
        '
        'btn_W
        '
        Me.btn_W.Location = New System.Drawing.Point(164, 120)
        Me.btn_W.Name = "btn_W"
        Me.btn_W.Size = New System.Drawing.Size(28, 23)
        Me.btn_W.TabIndex = 23
        Me.btn_W.Text = "W"
        Me.btn_W.UseVisualStyleBackColor = True
        '
        'btn_V
        '
        Me.btn_V.Location = New System.Drawing.Point(130, 120)
        Me.btn_V.Name = "btn_V"
        Me.btn_V.Size = New System.Drawing.Size(28, 23)
        Me.btn_V.TabIndex = 22
        Me.btn_V.Text = "V"
        Me.btn_V.UseVisualStyleBackColor = True
        '
        'btn_X
        '
        Me.btn_X.Location = New System.Drawing.Point(198, 120)
        Me.btn_X.Name = "btn_X"
        Me.btn_X.Size = New System.Drawing.Size(28, 23)
        Me.btn_X.TabIndex = 21
        Me.btn_X.Text = "X"
        Me.btn_X.UseVisualStyleBackColor = True
        '
        'btn_U
        '
        Me.btn_U.Location = New System.Drawing.Point(96, 120)
        Me.btn_U.Name = "btn_U"
        Me.btn_U.Size = New System.Drawing.Size(28, 23)
        Me.btn_U.TabIndex = 20
        Me.btn_U.Text = "U"
        Me.btn_U.UseVisualStyleBackColor = True
        '
        'btn_T
        '
        Me.btn_T.Location = New System.Drawing.Point(62, 120)
        Me.btn_T.Name = "btn_T"
        Me.btn_T.Size = New System.Drawing.Size(28, 23)
        Me.btn_T.TabIndex = 19
        Me.btn_T.Text = "T"
        Me.btn_T.UseVisualStyleBackColor = True
        '
        'btn_S
        '
        Me.btn_S.Location = New System.Drawing.Point(28, 120)
        Me.btn_S.Name = "btn_S"
        Me.btn_S.Size = New System.Drawing.Size(28, 23)
        Me.btn_S.TabIndex = 18
        Me.btn_S.Text = "S"
        Me.btn_S.UseVisualStyleBackColor = True
        '
        'btn_Y
        '
        Me.btn_Y.Location = New System.Drawing.Point(28, 149)
        Me.btn_Y.Name = "btn_Y"
        Me.btn_Y.Size = New System.Drawing.Size(28, 23)
        Me.btn_Y.TabIndex = 24
        Me.btn_Y.Text = "Y"
        Me.btn_Y.UseVisualStyleBackColor = True
        '
        'btn_Z
        '
        Me.btn_Z.Location = New System.Drawing.Point(62, 149)
        Me.btn_Z.Name = "btn_Z"
        Me.btn_Z.Size = New System.Drawing.Size(28, 23)
        Me.btn_Z.TabIndex = 25
        Me.btn_Z.Text = "Z"
        Me.btn_Z.UseVisualStyleBackColor = True
        '
        'btn_NewWord
        '
        Me.btn_NewWord.Location = New System.Drawing.Point(117, 58)
        Me.btn_NewWord.Name = "btn_NewWord"
        Me.btn_NewWord.Size = New System.Drawing.Size(75, 23)
        Me.btn_NewWord.TabIndex = 26
        Me.btn_NewWord.Text = "New Word"
        Me.btn_NewWord.UseVisualStyleBackColor = True
        '
        'btn_Start
        '
        Me.btn_Start.Location = New System.Drawing.Point(12, 29)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(75, 23)
        Me.btn_Start.TabIndex = 27
        Me.btn_Start.Text = "Hangman!"
        Me.btn_Start.UseVisualStyleBackColor = True
        '
        'btn_End
        '
        Me.btn_End.Location = New System.Drawing.Point(491, 347)
        Me.btn_End.Name = "btn_End"
        Me.btn_End.Size = New System.Drawing.Size(75, 23)
        Me.btn_End.TabIndex = 28
        Me.btn_End.Text = "End Game"
        Me.btn_End.UseVisualStyleBackColor = True
        '
        'groupLetters
        '
        Me.groupLetters.BackColor = System.Drawing.Color.Transparent
        Me.groupLetters.Controls.Add(Me.btn_A)
        Me.groupLetters.Controls.Add(Me.btn_B)
        Me.groupLetters.Controls.Add(Me.btn_C)
        Me.groupLetters.Controls.Add(Me.btn_F)
        Me.groupLetters.Controls.Add(Me.btn_Z)
        Me.groupLetters.Controls.Add(Me.btn_D)
        Me.groupLetters.Controls.Add(Me.btn_Y)
        Me.groupLetters.Controls.Add(Me.btn_E)
        Me.groupLetters.Controls.Add(Me.btn_W)
        Me.groupLetters.Controls.Add(Me.btn_G)
        Me.groupLetters.Controls.Add(Me.btn_V)
        Me.groupLetters.Controls.Add(Me.btn_H)
        Me.groupLetters.Controls.Add(Me.btn_X)
        Me.groupLetters.Controls.Add(Me.btn_I)
        Me.groupLetters.Controls.Add(Me.btn_U)
        Me.groupLetters.Controls.Add(Me.btn_L)
        Me.groupLetters.Controls.Add(Me.btn_T)
        Me.groupLetters.Controls.Add(Me.btn_J)
        Me.groupLetters.Controls.Add(Me.btn_S)
        Me.groupLetters.Controls.Add(Me.btn_K)
        Me.groupLetters.Controls.Add(Me.btn_Q)
        Me.groupLetters.Controls.Add(Me.btn_M)
        Me.groupLetters.Controls.Add(Me.btn_P)
        Me.groupLetters.Controls.Add(Me.btn_N)
        Me.groupLetters.Controls.Add(Me.btn_R)
        Me.groupLetters.Controls.Add(Me.btn_O)
        Me.groupLetters.Location = New System.Drawing.Point(327, 29)
        Me.groupLetters.Name = "groupLetters"
        Me.groupLetters.Size = New System.Drawing.Size(251, 196)
        Me.groupLetters.TabIndex = 29
        Me.groupLetters.TabStop = False
        Me.groupLetters.Text = "Pick a Letter"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btn_Guess)
        Me.GroupBox2.Controls.Add(Me.txtbox_GuessWord)
        Me.GroupBox2.Controls.Add(Me.btn_NewWord)
        Me.GroupBox2.Location = New System.Drawing.Point(327, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 100)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Guess the Word"
        '
        'btn_Guess
        '
        Me.btn_Guess.Location = New System.Drawing.Point(15, 58)
        Me.btn_Guess.Name = "btn_Guess"
        Me.btn_Guess.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guess.TabIndex = 1
        Me.btn_Guess.Text = "Guess"
        Me.btn_Guess.UseVisualStyleBackColor = True
        '
        'txtbox_GuessWord
        '
        Me.txtbox_GuessWord.Location = New System.Drawing.Point(48, 19)
        Me.txtbox_GuessWord.Name = "txtbox_GuessWord"
        Me.txtbox_GuessWord.Size = New System.Drawing.Size(178, 20)
        Me.txtbox_GuessWord.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(12, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(299, 304)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'lbl_word
        '
        Me.lbl_word.AutoSize = True
        Me.lbl_word.BackColor = System.Drawing.Color.Transparent
        Me.lbl_word.Location = New System.Drawing.Point(38, 402)
        Me.lbl_word.Name = "lbl_word"
        Me.lbl_word.Size = New System.Drawing.Size(0, 13)
        Me.lbl_word.TabIndex = 32
        '
        'lbl_guessedLetters
        '
        Me.lbl_guessedLetters.AutoSize = True
        Me.lbl_guessedLetters.BackColor = System.Drawing.Color.Transparent
        Me.lbl_guessedLetters.Location = New System.Drawing.Point(297, 402)
        Me.lbl_guessedLetters.Name = "lbl_guessedLetters"
        Me.lbl_guessedLetters.Size = New System.Drawing.Size(0, 13)
        Me.lbl_guessedLetters.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(207, 402)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Letters Guessed:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(38, 432)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Wins:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(38, 452)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Loses:"
        '
        'txt_wins
        '
        Me.txt_wins.Location = New System.Drawing.Point(87, 425)
        Me.txt_wins.Name = "txt_wins"
        Me.txt_wins.Size = New System.Drawing.Size(25, 20)
        Me.txt_wins.TabIndex = 38
        '
        'txt_loses
        '
        Me.txt_loses.Location = New System.Drawing.Point(87, 449)
        Me.txt_loses.Name = "txt_loses"
        Me.txt_loses.Size = New System.Drawing.Size(25, 20)
        Me.txt_loses.TabIndex = 39
        '
        'Form_Hangman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(590, 478)
        Me.Controls.Add(Me.txt_loses)
        Me.Controls.Add(Me.txt_wins)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_guessedLetters)
        Me.Controls.Add(Me.lbl_word)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.groupLetters)
        Me.Controls.Add(Me.btn_End)
        Me.Controls.Add(Me.btn_Start)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(606, 512)
        Me.MinimumSize = New System.Drawing.Size(606, 512)
        Me.Name = "Form_Hangman"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hangman v 1.1"
        Me.groupLetters.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_A As System.Windows.Forms.Button
    Friend WithEvents btn_B As System.Windows.Forms.Button
    Friend WithEvents btn_C As System.Windows.Forms.Button
    Friend WithEvents btn_E As System.Windows.Forms.Button
    Friend WithEvents btn_D As System.Windows.Forms.Button
    Friend WithEvents btn_F As System.Windows.Forms.Button
    Friend WithEvents btn_K As System.Windows.Forms.Button
    Friend WithEvents btn_J As System.Windows.Forms.Button
    Friend WithEvents btn_L As System.Windows.Forms.Button
    Friend WithEvents btn_I As System.Windows.Forms.Button
    Friend WithEvents btn_H As System.Windows.Forms.Button
    Friend WithEvents btn_G As System.Windows.Forms.Button
    Friend WithEvents btn_Q As System.Windows.Forms.Button
    Friend WithEvents btn_P As System.Windows.Forms.Button
    Friend WithEvents btn_R As System.Windows.Forms.Button
    Friend WithEvents btn_O As System.Windows.Forms.Button
    Friend WithEvents btn_N As System.Windows.Forms.Button
    Friend WithEvents btn_M As System.Windows.Forms.Button
    Friend WithEvents btn_W As System.Windows.Forms.Button
    Friend WithEvents btn_V As System.Windows.Forms.Button
    Friend WithEvents btn_X As System.Windows.Forms.Button
    Friend WithEvents btn_U As System.Windows.Forms.Button
    Friend WithEvents btn_T As System.Windows.Forms.Button
    Friend WithEvents btn_S As System.Windows.Forms.Button
    Friend WithEvents btn_Y As System.Windows.Forms.Button
    Friend WithEvents btn_Z As System.Windows.Forms.Button
    Friend WithEvents btn_NewWord As System.Windows.Forms.Button
    Friend WithEvents btn_Start As System.Windows.Forms.Button
    Friend WithEvents btn_End As System.Windows.Forms.Button
    Friend WithEvents groupLetters As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Guess As System.Windows.Forms.Button
    Friend WithEvents txtbox_GuessWord As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_word As System.Windows.Forms.Label
    Friend WithEvents lbl_guessedLetters As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_wins As System.Windows.Forms.TextBox
    Friend WithEvents txt_loses As System.Windows.Forms.TextBox

End Class
