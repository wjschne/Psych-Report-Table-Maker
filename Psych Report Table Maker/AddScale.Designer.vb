﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddScale
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddScale))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtScale = New System.Windows.Forms.TextBox()
        Me.tmDataSet = New Psych_Report_Table_Maker.tmDataSet()
        Me.ScoreTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ScoreTypeTableAdapter = New Psych_Report_Table_Maker.tmDataSetTableAdapters.ScoreTypeTableAdapter()
        Me.TableAdapterManager = New Psych_Report_Table_Maker.tmDataSetTableAdapters.TableAdapterManager()
        Me.ScoreTypeListBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstLevel = New System.Windows.Forms.ListBox()
        CType(Me.tmDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScoreTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Scale"
        '
        'txtScale
        '
        Me.txtScale.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtScale.Location = New System.Drawing.Point(90, 6)
        Me.txtScale.Name = "txtScale"
        Me.txtScale.Size = New System.Drawing.Size(549, 29)
        Me.txtScale.TabIndex = 0
        '
        'tmDataSet
        '
        Me.tmDataSet.DataSetName = "tmDataSet"
        Me.tmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ScoreTypeBindingSource
        '
        Me.ScoreTypeBindingSource.DataMember = "ScoreType"
        Me.ScoreTypeBindingSource.DataSource = Me.tmDataSet
        '
        'ScoreTypeTableAdapter
        '
        Me.ScoreTypeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BatteryTableAdapter = Nothing
        Me.TableAdapterManager.DisplayTableItemMarkerTableAdapter = Nothing
        Me.TableAdapterManager.DisplayTableItemTableAdapter = Nothing
        Me.TableAdapterManager.DisplayTableMarkerTableAdapter = Nothing
        Me.TableAdapterManager.DisplayTableTableAdapter = Nothing
        Me.TableAdapterManager.PersonBatteryAdministrationTableAdapter = Nothing
        Me.TableAdapterManager.PersonBatteryScaleTableAdapter = Nothing
        Me.TableAdapterManager.PersonBatteryTableAdapter = Nothing
        Me.TableAdapterManager.PersonTableAdapter = Nothing
        Me.TableAdapterManager.RangeLabelTableAdapter = Nothing
        Me.TableAdapterManager.RangeTableAdapter = Nothing
        Me.TableAdapterManager.ReportItemTableAdapter = Nothing
        Me.TableAdapterManager.ReportTableAdapter = Nothing
        Me.TableAdapterManager.ScaleTableAdapter = Nothing
        Me.TableAdapterManager.ScoreTypeTableAdapter = Me.ScoreTypeTableAdapter
        Me.TableAdapterManager.UpdateOrder = Psych_Report_Table_Maker.tmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ScoreTypeListBox
        '
        Me.ScoreTypeListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScoreTypeListBox.DataSource = Me.ScoreTypeBindingSource
        Me.ScoreTypeListBox.DisplayMember = "ScoreTypeName"
        Me.ScoreTypeListBox.FormattingEnabled = True
        Me.ScoreTypeListBox.ItemHeight = 21
        Me.ScoreTypeListBox.Location = New System.Drawing.Point(90, 97)
        Me.ScoreTypeListBox.Name = "ScoreTypeListBox"
        Me.ScoreTypeListBox.Size = New System.Drawing.Size(549, 214)
        Me.ScoreTypeListBox.TabIndex = 2
        Me.ScoreTypeListBox.ValueMember = "ScoreTypeID"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 52)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Score Type"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(466, 317)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(173, 35)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOkay
        '
        Me.btnOkay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOkay.Location = New System.Drawing.Point(90, 317)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(370, 35)
        Me.btnOkay.TabIndex = 3
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Type"
        '
        'lstLevel
        '
        Me.lstLevel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstLevel.DisplayMember = "ScoreTypeID"
        Me.lstLevel.FormattingEnabled = True
        Me.lstLevel.ItemHeight = 21
        Me.lstLevel.Items.AddRange(New Object() {"Scale", "Subscale"})
        Me.lstLevel.Location = New System.Drawing.Point(90, 44)
        Me.lstLevel.Name = "lstLevel"
        Me.lstLevel.Size = New System.Drawing.Size(549, 46)
        Me.lstLevel.TabIndex = 1
        Me.lstLevel.ValueMember = "ScoreTypeID"
        '
        'AddScale
        '
        Me.AcceptButton = Me.btnOkay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(651, 360)
        Me.Controls.Add(Me.lstLevel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.ScoreTypeListBox)
        Me.Controls.Add(Me.txtScale)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AddScale"
        Me.Text = "AddScale"
        CType(Me.tmDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScoreTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtScale As System.Windows.Forms.TextBox
    Friend WithEvents tmDataSet As Psych_Report_Table_Maker.tmDataSet
    Friend WithEvents ScoreTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ScoreTypeTableAdapter As Psych_Report_Table_Maker.tmDataSetTableAdapters.ScoreTypeTableAdapter
    Friend WithEvents TableAdapterManager As Psych_Report_Table_Maker.tmDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ScoreTypeListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstLevel As System.Windows.Forms.ListBox
End Class
