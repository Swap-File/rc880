Public Class Form1

    Inherits System.Windows.Forms.Form
    Private m_CommPort As New Rs232
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents CLS As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents ComboBox8 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Button8 = New System.Windows.Forms.Button
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.CLS = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.ComboBox6 = New System.Windows.Forms.ComboBox
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.ComboBox7 = New System.Windows.Forms.ComboBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Button14 = New System.Windows.Forms.Button
        Me.ComboBox8 = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(64, 184)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(512, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(504, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Graphics"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(32, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 32)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Factory Reset"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(32, 128)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 32)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Send"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(24, 272)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 32)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Text Color"
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.AddRange(New Object() {"Black", "Dark Red", "Orange", "Red", "Purple", "Dark Green", "Brown", "Magenta", "Dark Blue", "Green", "Yellow", "Pink", "Blue", "Aqua", "Cream", "White"})
        Me.ComboBox1.Location = New System.Drawing.Point(24, 312)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(24, 232)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 32)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Background Color"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(152, 232)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(96, 32)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Time"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(272, 232)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(88, 32)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Messages"
        '
        'ComboBox2
        '
        Me.ComboBox2.Items.AddRange(New Object() {"No Smoking", "Merry Christmas", "Thank You", "American Flag", "Attention", "Welcome", "Happy Hour", "Don't Drink", "Open House", "Sale"})
        Me.ComboBox2.Location = New System.Drawing.Point(272, 288)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(96, 21)
        Me.ComboBox2.TabIndex = 9
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(392, 232)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(88, 32)
        Me.Button8.TabIndex = 10
        Me.Button8.Text = "Text Speed"
        '
        'ComboBox3
        '
        Me.ComboBox3.Items.AddRange(New Object() {"0 Fastest", "1", "2", "3", "4", "5", "6", "7 Slowest"})
        Me.ComboBox3.Location = New System.Drawing.Point(392, 288)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(88, 21)
        Me.ComboBox3.TabIndex = 11
        '
        'ComboBox4
        '
        Me.ComboBox4.Items.AddRange(New Object() {"Heart", "Green Pacman", "Phone", "Spinning Wheel", "Bounce", "Plane", "Boat", "House", "Car"})
        Me.ComboBox4.Location = New System.Drawing.Point(504, 288)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(72, 21)
        Me.ComboBox4.TabIndex = 12
        '
        'CLS
        '
        Me.CLS.Location = New System.Drawing.Point(592, 176)
        Me.CLS.Name = "CLS"
        Me.CLS.Size = New System.Drawing.Size(48, 40)
        Me.CLS.TabIndex = 13
        Me.CLS.Text = "CLS"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(152, 280)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(96, 32)
        Me.Button9.TabIndex = 14
        Me.Button9.Text = "Set Clock"
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(152, 328)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(40, 16)
        Me.RadioButton1.TabIndex = 15
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "12"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(208, 328)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(40, 16)
        Me.RadioButton2.TabIndex = 16
        Me.RadioButton2.Text = "24"
        '
        'ComboBox5
        '
        Me.ComboBox5.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.ComboBox5.Location = New System.Drawing.Point(24, 184)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(32, 21)
        Me.ComboBox5.TabIndex = 17
        '
        'ComboBox6
        '
        Me.ComboBox6.Items.AddRange(New Object() {"Dazzle", "Tiny", "Normal", "Double", "Thin", "Bold", "Rainbow", "Italic", "Condensed", "Horizontal Rainbow", "Flash", "Marquee"})
        Me.ComboBox6.Location = New System.Drawing.Point(368, 112)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(88, 21)
        Me.ComboBox6.TabIndex = 18
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(368, 64)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(88, 32)
        Me.Button10.TabIndex = 19
        Me.Button10.Text = "Text Style"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(480, 64)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(80, 32)
        Me.Button11.TabIndex = 20
        Me.Button11.Text = "Other Stuff"
        '
        'ComboBox7
        '
        Me.ComboBox7.Items.AddRange(New Object() {"Magic", "Magic Off", "Beep", "Up", "Down", "Left", "Right", "Jump", "Crawl", "Quick"})
        Me.ComboBox7.Location = New System.Drawing.Point(480, 112)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(80, 21)
        Me.ComboBox7.TabIndex = 21
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.AddExtension = False
        Me.OpenFileDialog1.Filter = "16 Color Bitmaps (*.BMP)|*.BMP"
        Me.OpenFileDialog1.ReadOnlyChecked = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(232, 96)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(72, 23)
        Me.Button12.TabIndex = 23
        Me.Button12.Text = "Open BMP"
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(232, 128)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(72, 24)
        Me.Button13.TabIndex = 24
        Me.Button13.Text = "Draw BMP"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(184, 112)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 28)
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(200, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(96, 20)
        Me.TextBox2.TabIndex = 26
        Me.TextBox2.Text = ""
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(200, 16)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(88, 24)
        Me.Button14.TabIndex = 27
        Me.Button14.Text = "Set Sequence"
        '
        'ComboBox8
        '
        Me.ComboBox8.Items.AddRange(New Object() {"COM 1", "COM 2", "COM 3", "COM 4"})
        Me.ComboBox8.Location = New System.Drawing.Point(40, 24)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(88, 21)
        Me.ComboBox8.TabIndex = 28
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 357)
        Me.Controls.Add(Me.ComboBox8)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.CLS)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "RC-880 Control"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim bmp As New Bitmap(6, 7)
    Dim port As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Select Case ComboBox4.SelectedItem
            Case "Heart"
                TextBox1.AppendText(Chr(225))
            Case "Green Pacman"
                TextBox1.AppendText(Chr(226))
            Case "Phone"
                TextBox1.AppendText(Chr(227))
            Case "Spinning Wheel"
                TextBox1.AppendText(Chr(228))
            Case "Bounce"
                TextBox1.AppendText(Chr(229))
            Case "Plane"
                TextBox1.AppendText(Chr(230))
            Case "Boat"
                TextBox1.AppendText(Chr(231))
            Case "House"
                TextBox1.AppendText(Chr(232))
            Case "Car"
                TextBox1.AppendText(Chr(233))

            Case Else
        End Select


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        m_CommPort.Open(port, 300, 8, Rs232.DataParity.Parity_None, Rs232.DataStopBit.StopBit_2, 512)
        m_CommPort.Write(Chr(2) & Chr(3) & "Y" & Chr(16))
        m_CommPort.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim i As Integer
        i = 0
        m_CommPort.Open(port, 300, 8, Rs232.DataParity.Parity_None, Rs232.DataStopBit.StopBit_2, 512)
        m_CommPort.Write(Chr(2) & Chr(11) & ComboBox5.SelectedItem & Chr(9))
        While (i < TextBox1.Text.Length)
            System.Threading.Thread.Sleep(200)
            m_CommPort.Write(TextBox1.Text.Chars(i))
            i = i + 1
        End While
        m_CommPort.Write(Chr(16))
        m_CommPort.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Select Case ComboBox1.SelectedItem
            Case "Black"
                TextBox1.AppendText(Chr(208))
            Case "Dark Red"
                TextBox1.AppendText(Chr(209))
            Case "Orange"
                TextBox1.AppendText(Chr(210))
            Case "Red"
                TextBox1.AppendText(Chr(211))
            Case "Purple"
                TextBox1.AppendText(Chr(212))
            Case "Dark Green"
                TextBox1.AppendText(Chr(213))
            Case "Brown"
                TextBox1.AppendText(Chr(214))
            Case "Magenta"
                TextBox1.AppendText(Chr(215))
            Case "Dark Blue"
                TextBox1.AppendText(Chr(216))
            Case "Green"
                TextBox1.AppendText(Chr(217))
            Case "Yellow"
                TextBox1.AppendText(Chr(218))
            Case "Pink"
                TextBox1.AppendText(Chr(219))
            Case "Blue"
                TextBox1.AppendText(Chr(220))
            Case "Aqua"
                TextBox1.AppendText(Chr(221))
            Case "Cream"
                TextBox1.AppendText(Chr(222))
            Case "White"
                TextBox1.AppendText(Chr(223))
            Case Else
        End Select
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Select Case ComboBox1.SelectedItem
            Case "Black"
                TextBox1.AppendText(Chr(160))
            Case "Dark Red"
                TextBox1.AppendText(Chr(161))
            Case "Orange"
                TextBox1.AppendText(Chr(162))
            Case "Red"
                TextBox1.AppendText(Chr(163))
            Case "Purple"
                TextBox1.AppendText(Chr(164))
            Case "Dark Green"
                TextBox1.AppendText(Chr(165))
            Case "Brown"
                TextBox1.AppendText(Chr(166))
            Case "Magenta"
                TextBox1.AppendText(Chr(167))
            Case "Dark Blue"
                TextBox1.AppendText(Chr(168))
            Case "Green"
                TextBox1.AppendText(Chr(169))
            Case "Yellow"
                TextBox1.AppendText(Chr(170))
            Case "Pink"
                TextBox1.AppendText(Chr(171))
            Case "Blue"
                TextBox1.AppendText(Chr(172))
            Case "Aqua"
                TextBox1.AppendText(Chr(173))
            Case "Cream"
                TextBox1.AppendText(Chr(174))
            Case "White"
                TextBox1.AppendText(Chr(175))
            Case Else
        End Select

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox1.AppendText(Chr(176))
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Select Case ComboBox2.SelectedItem
            Case "No Smoking"
                TextBox1.AppendText(Chr(133) & "a")
            Case "Merry Christmas"
                TextBox1.AppendText(Chr(133) & "b")
            Case "Thank You"
                TextBox1.AppendText(Chr(133) & "c")
            Case "American Flag"
                TextBox1.AppendText(Chr(133) & "d")
            Case "Attention"
                TextBox1.AppendText(Chr(133) & "e")
            Case "Welcome"
                TextBox1.AppendText(Chr(133) & "g")
            Case "Happy Hour"
                TextBox1.AppendText(Chr(133) & "h")
            Case "Don't Drink"
                TextBox1.AppendText(Chr(133) & "i")
            Case "Open House"
                TextBox1.AppendText(Chr(133) & "j")
            Case "Sale"
                TextBox1.AppendText(Chr(133) & "k")
            Case Else
        End Select
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Select Case ComboBox3.SelectedItem
            Case "0 Fastest"
                TextBox1.AppendText(Chr(144))
            Case "1"
                TextBox1.AppendText(Chr(145))
            Case "2"
                TextBox1.AppendText(Chr(146))
            Case "3"
                TextBox1.AppendText(Chr(147))
            Case "4"
                TextBox1.AppendText(Chr(148))
            Case "5"
                TextBox1.AppendText(Chr(149))
            Case "6"
                TextBox1.AppendText(Chr(150))
            Case "7 Slowest"
                TextBox1.AppendText(Chr(151))
            Case Else
        End Select
    End Sub

    Private Sub CLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLS.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If RadioButton1.Checked Then
            m_CommPort.Open(port, 300, 8, Rs232.DataParity.Parity_None, Rs232.DataStopBit.StopBit_2, 512)
            m_CommPort.Write(Chr(2) & Chr(15) & "12" & Chr(16))
            If Date.Now.Hour > 12 Then
                m_CommPort.Write("PM" & Chr(16) & (Date.Now.Hour - 12) & Chr(16) & Date.Now.Minute & Chr(16) & Chr(16))
            Else
                m_CommPort.Write("AM" & Chr(16) & Date.Now.Hour & Chr(16) & Date.Now.Minute & Chr(16) & Chr(16))
            End If
            m_CommPort.Close()
        ElseIf RadioButton2.Checked Then
            m_CommPort.Open(1, 300, 8, Rs232.DataParity.Parity_None, Rs232.DataStopBit.StopBit_2, 512)
            m_CommPort.Write(Chr(2) & Chr(15) & "24" & Chr(16) & Date.Now.Hour & Chr(16) & Date.Now.Minute & Chr(16) & Chr(16))
            m_CommPort.Close()
        End If

    End Sub


    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Select Case ComboBox6.SelectedItem
            Case "Dazzle"
                TextBox1.AppendText(Chr(193))
            Case "Tiny"
                TextBox1.AppendText(Chr(194))
            Case "Normal"
                TextBox1.AppendText(Chr(195))
            Case "Double"
                TextBox1.AppendText(Chr(196))
            Case "Thin"
                TextBox1.AppendText(Chr(197))
            Case "Bold"
                TextBox1.AppendText(Chr(198))
            Case "Rainbow"
                TextBox1.AppendText(Chr(199))
            Case "Italic"
                TextBox1.AppendText(Chr(200))
            Case "Condensed"
                TextBox1.AppendText(Chr(201))
            Case "Horizontal Rainbow"
                TextBox1.AppendText(Chr(202))
            Case "Flash"
                TextBox1.AppendText(Chr(203))
            Case "Marquee"
                TextBox1.AppendText(Chr(205))
            Case Else
        End Select


    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Select Case ComboBox7.SelectedItem
            Case "Magic"
                TextBox1.AppendText(Chr(181))
            Case "Beep"
                TextBox1.AppendText(Chr(182))
            Case "Magic Off"
                TextBox1.AppendText(Chr(183))
            Case "Up"
                TextBox1.AppendText(Chr(184))
            Case "Down"
                TextBox1.AppendText(Chr(185))
            Case "Jump"
                TextBox1.AppendText(Chr(186))
            Case "Right"
                TextBox1.AppendText(Chr(187))
            Case "Crawl"
                TextBox1.AppendText(Chr(188))
            Case "Quick"
                TextBox1.AppendText(Chr(189))
            Case "Left"
                TextBox1.AppendText(Chr(191))
            Case Else
        End Select

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox5.SelectedIndex = 0
        ComboBox8.SelectedIndex = 0
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            If (Image.FromFile(OpenFileDialog1.FileName).Width = 6) And (Image.FromFile(OpenFileDialog1.FileName).Height = 7) Then

                bmp = Image.FromFile(OpenFileDialog1.FileName)
                'image resizer code, default resize does weird filtering
                Dim bmp2 As New Bitmap(24, 28)
                For x As Integer = 0 To 23
                    For y As Integer = 0 To 27
                        bmp2.SetPixel(x, y, bmp.GetPixel(Math.Floor(x / 4), Math.Floor(y / 4)))
                    Next y
                Next x
                PictureBox2.Image = bmp2
            Else
                MsgBox("Invalid BMP - Must be 6 pixels wide, 7 pixels tall, 16 Colors", 0, "Invalid BMP")
            End If
        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox1.AppendText(Chr(18))
        Dim Color1 As Color
        For x As Integer = 0 To 5
            For y As Integer = 0 To 6
                Color1 = bmp.GetPixel(x, y)
                If Color1.R = 0 And Color1.G = 0 And Color1.B = 0 Then
                    'black
                    TextBox1.AppendText("M") 'black
                ElseIf Color1.R = 255 And Color1.G = 255 And Color1.B = 255 Then
                    'white
                    TextBox1.AppendText("D") 'white
                ElseIf Color1.R = 128 And Color1.G = 128 And Color1.B = 128 Then
                    'gray
                    TextBox1.AppendText("F") 'brown
                ElseIf Color1.R = 192 And Color1.G = 192 And Color1.B = 192 Then
                    'light gray
                    TextBox1.AppendText("H") 'cream
                ElseIf Color1.R = 128 And Color1.G = 0 And Color1.B = 0 Then
                    'dark red
                    TextBox1.AppendText("I") 'dark red
                ElseIf Color1.R = 255 And Color1.G = 0 And Color1.B = 0 Then
                    'red
                    TextBox1.AppendText("A") 'red
                ElseIf Color1.R = 128 And Color1.G = 128 And Color1.B = 0 Then
                    'Dark yellow
                    TextBox1.AppendText("E") 'orange
                ElseIf Color1.R = 255 And Color1.G = 255 And Color1.B = 0 Then
                    'yellow
                    TextBox1.AppendText("G") 'yellow
                ElseIf Color1.R = 0 And Color1.G = 128 And Color1.B = 0 Then
                    'dark green
                    TextBox1.AppendText("J") 'dark green
                ElseIf Color1.R = 0 And Color1.G = 255 And Color1.B = 0 Then
                    'green
                    TextBox1.AppendText("K") 'green
                ElseIf Color1.R = 0 And Color1.G = 128 And Color1.B = 128 Then
                    'd aqua
                    TextBox1.AppendText("B") 'Magenta
                ElseIf Color1.R = 0 And Color1.G = 255 And Color1.B = 255 Then
                    'aqua
                    TextBox1.AppendText("L") 'aqua
                ElseIf Color1.R = 0 And Color1.G = 0 And Color1.B = 128 Then
                    'd blue
                    TextBox1.AppendText("O") 'dark blue
                ElseIf Color1.R = 0 And Color1.G = 0 And Color1.B = 255 Then
                    'blue
                    TextBox1.AppendText("P") 'blue
                ElseIf Color1.R = 128 And Color1.G = 0 And Color1.B = 128 Then
                    'd purple
                    TextBox1.AppendText("C") 'Pink
                ElseIf Color1.R = 255 And Color1.G = 0 And Color1.B = 255 Then
                    'purple
                    TextBox1.AppendText("N") 'purple
                End If
            Next y
        Next x
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim i As Integer
        i = 0
        m_CommPort.Open(port, 300, 8, Rs232.DataParity.Parity_None, Rs232.DataStopBit.StopBit_2, 512)
        m_CommPort.Write(Chr(2) & Chr(12))
        While (i < TextBox2.Text.Length)
            System.Threading.Thread.Sleep(200)
            m_CommPort.Write(TextBox2.Text.Chars(i))
            i = i + 1
        End While
        m_CommPort.Write(Chr(16))
        m_CommPort.Close()
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox8.SelectedIndexChanged
        Select Case ComboBox8.SelectedItem
            Case "COM 1"
                port = 1
            Case "COM 2"
                port = 2
            Case "COM 3"
                port = 3
            Case "COM 4"
                port = 4
        End Select
    End Sub
End Class
