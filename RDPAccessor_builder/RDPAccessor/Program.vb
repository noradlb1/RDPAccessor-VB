Imports System
Imports System.Windows.Forms

Namespace RDPAccessor
    Friend Module Program
        ''' <summary>
        ''' Главная точка входа для приложения.
        ''' </summary>
        <STAThread>
        Private Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New Form1())
        End Sub
    End Module
End Namespace
