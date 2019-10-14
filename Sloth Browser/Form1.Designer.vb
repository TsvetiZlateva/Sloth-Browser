<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SlothBrowser = New System.Windows.Forms.WebBrowser()
        Me.txbAdress = New System.Windows.Forms.TextBox()
        Me.txbSearch = New System.Windows.Forms.TextBox()
        Me.Refresh = New System.Windows.Forms.Button()
        Me.GO = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Button()
        Me.Settings = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.Forward = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrStatus = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'SlothBrowser
        '
        Me.SlothBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SlothBrowser.Location = New System.Drawing.Point(0, 68)
        Me.SlothBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.SlothBrowser.Name = "SlothBrowser"
        Me.SlothBrowser.Size = New System.Drawing.Size(1176, 651)
        Me.SlothBrowser.TabIndex = 0
        '
        'txbAdress
        '
        Me.txbAdress.Location = New System.Drawing.Point(171, 24)
        Me.txbAdress.Name = "txbAdress"
        Me.txbAdress.Size = New System.Drawing.Size(520, 26)
        Me.txbAdress.TabIndex = 1
        '
        'txbSearch
        '
        Me.txbSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txbSearch.Location = New System.Drawing.Point(832, 24)
        Me.txbSearch.Name = "txbSearch"
        Me.txbSearch.Size = New System.Drawing.Size(203, 26)
        Me.txbSearch.TabIndex = 2
        Me.txbSearch.Text = "Search..."
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(107, 17)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(40, 40)
        Me.Refresh.TabIndex = 3
        Me.Refresh.Text = "R"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'GO
        '
        Me.GO.BackColor = System.Drawing.SystemColors.Control
        Me.GO.Location = New System.Drawing.Point(697, 17)
        Me.GO.Name = "GO"
        Me.GO.Size = New System.Drawing.Size(72, 40)
        Me.GO.TabIndex = 4
        Me.GO.Text = "Sloth!"
        Me.GO.UseVisualStyleBackColor = False
        '
        'Search
        '
        Me.Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Search.Location = New System.Drawing.Point(1041, 19)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(80, 40)
        Me.Search.TabIndex = 5
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.Settings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Settings.Location = New System.Drawing.Point(1127, 19)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(42, 40)
        Me.Settings.TabIndex = 6
        Me.Settings.Text = "..."
        Me.Settings.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(15, 17)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(40, 40)
        Me.Back.TabIndex = 7
        Me.Back.Text = "<"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Forward
        '
        Me.Forward.Location = New System.Drawing.Point(61, 17)
        Me.Forward.Name = "Forward"
        Me.Forward.Size = New System.Drawing.Size(40, 40)
        Me.Forward.TabIndex = 8
        Me.Forward.Text = ">"
        Me.Forward.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 726)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 9
        '
        'tmrStatus
        '
        Me.tmrStatus.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 744)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Forward)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Settings)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.GO)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.txbSearch)
        Me.Controls.Add(Me.txbAdress)
        Me.Controls.Add(Me.SlothBrowser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1200, 800)
        Me.Name = "Form1"
        Me.RightToLeftLayout = True
        Me.Text = "Sloth"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SlothBrowser As WebBrowser
    Friend WithEvents txbAdress As TextBox
    Friend WithEvents txbSearch As TextBox
    Friend WithEvents Refresh As Button
    Friend WithEvents GO As Button
    Friend WithEvents Search As Button
    Friend WithEvents Settings As Button
    Friend WithEvents Back As Button
    Friend WithEvents Forward As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tmrStatus As Timer
End Class
