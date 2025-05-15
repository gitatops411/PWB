using System;

namespace PWB
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.DataGridColumnPWB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridColumnPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridColumnPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridColumnPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HJSPickWaveBatchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Dataset = new PWB.Dataset();
            this.HJSPickWaveBatchesTableAdapter = new PWB.DatasetTableAdapters.view_HJS_Pick_Wave_BatchesTableAdapter();
            this.ClockDisplay = new System.Windows.Forms.TextBox();
            this.NetworkErrorMsg = new System.Windows.Forms.TextBox();
            this.NetworkRetrySecs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HJSPickWaveBatchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dataset)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Enabled = true;
            this.RefreshTimer.Interval = 1;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowDrop = true;
            this.DataGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.AutoGenerateColumns = false;
            this.DataGrid.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridColumnPWB,
            this.DataGridColumnPL,
            this.DataGridColumnPI,
            this.DataGridColumnPK,
            this.DataGridColumnTime});
            this.DataGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DataGrid.DataSource = this.HJSPickWaveBatchesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.EnableHeadersVisualStyles = false;
            this.DataGrid.GridColor = System.Drawing.Color.Gainsboro;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.DataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.RowTemplate.Height = 40;
            this.DataGrid.RowTemplate.ReadOnly = true;
            this.DataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.ShowCellErrors = false;
            this.DataGrid.ShowCellToolTips = false;
            this.DataGrid.ShowEditingIcon = false;
            this.DataGrid.ShowRowErrors = false;
            this.DataGrid.Size = new System.Drawing.Size(1388, 399);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.VirtualMode = true;
            // 
            // DataGridColumnPWB
            // 
            this.DataGridColumnPWB.DataPropertyName = "PWB";
            this.DataGridColumnPWB.HeaderText = "Pick Wave Batch";
            this.DataGridColumnPWB.Name = "DataGridColumnPWB";
            this.DataGridColumnPWB.ReadOnly = true;
            this.DataGridColumnPWB.Width = 465;
            // 
            // DataGridColumnPL
            // 
            this.DataGridColumnPL.DataPropertyName = "PL";
            this.DataGridColumnPL.HeaderText = "Planned";
            this.DataGridColumnPL.Name = "DataGridColumnPL";
            this.DataGridColumnPL.ReadOnly = true;
            this.DataGridColumnPL.Width = 180;
            // 
            // DataGridColumnPI
            // 
            this.DataGridColumnPI.DataPropertyName = "PI";
            this.DataGridColumnPI.HeaderText = "Picked";
            this.DataGridColumnPI.Name = "DataGridColumnPI";
            this.DataGridColumnPI.ReadOnly = true;
            this.DataGridColumnPI.Width = 180;
            // 
            // DataGridColumnPK
            // 
            this.DataGridColumnPK.DataPropertyName = "PK";
            this.DataGridColumnPK.HeaderText = "Packed";
            this.DataGridColumnPK.Name = "DataGridColumnPK";
            this.DataGridColumnPK.ReadOnly = true;
            this.DataGridColumnPK.Width = 180;
            // 
            // DataGridColumnTime
            // 
            this.DataGridColumnTime.DataPropertyName = "Created / Refresh Time";
            this.DataGridColumnTime.HeaderText = "Created Time";
            this.DataGridColumnTime.Name = "DataGridColumnTime";
            this.DataGridColumnTime.ReadOnly = true;
            this.DataGridColumnTime.Width = 382;
            // 
            // HJSPickWaveBatchesBindingSource
            // 
            this.HJSPickWaveBatchesBindingSource.DataMember = "view_HJS_Pick_Wave_Batches";
            this.HJSPickWaveBatchesBindingSource.DataSource = this.Dataset;
            // 
            // Dataset
            // 
            this.Dataset.DataSetName = "Dataset";
            this.Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HJSPickWaveBatchesTableAdapter
            // 
            this.HJSPickWaveBatchesTableAdapter.ClearBeforeFill = true;
            // 
            // ClockDisplay
            // 
            this.ClockDisplay.BackColor = System.Drawing.Color.White;
            this.ClockDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClockDisplay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ClockDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockDisplay.Location = new System.Drawing.Point(1276, 405);
            this.ClockDisplay.MaxLength = 32;
            this.ClockDisplay.Name = "ClockDisplay";
            this.ClockDisplay.ReadOnly = true;
            this.ClockDisplay.Size = new System.Drawing.Size(100, 22);
            this.ClockDisplay.TabIndex = 1;
            this.ClockDisplay.Text = "55:55 am";
            this.ClockDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClockDisplay.WordWrap = false;
            this.ClockDisplay.Click += new System.EventHandler(this.ClockDisplay_Click);
            // 
            // NetworkErrorMsg
            // 
            this.NetworkErrorMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.NetworkErrorMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NetworkErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkErrorMsg.Location = new System.Drawing.Point(409, 198);
            this.NetworkErrorMsg.Multiline = true;
            this.NetworkErrorMsg.Name = "NetworkErrorMsg";
            this.NetworkErrorMsg.Size = new System.Drawing.Size(594, 146);
            this.NetworkErrorMsg.TabIndex = 2;
            this.NetworkErrorMsg.Text = "\r\nThe network connection was lost or interrupted.\r\nA new connection attempt will " +
    "occur in\r\n       seconds";
            this.NetworkErrorMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NetworkErrorMsg.Visible = false;
            // 
            // NetworkRetrySecs
            // 
            this.NetworkRetrySecs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.NetworkRetrySecs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NetworkRetrySecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkRetrySecs.ForeColor = System.Drawing.Color.Green;
            this.NetworkRetrySecs.Location = new System.Drawing.Point(620, 286);
            this.NetworkRetrySecs.Name = "NetworkRetrySecs";
            this.NetworkRetrySecs.Size = new System.Drawing.Size(50, 28);
            this.NetworkRetrySecs.TabIndex = 3;
            this.NetworkRetrySecs.Text = "00";
            this.NetworkRetrySecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1388, 446);
            this.Controls.Add(this.NetworkRetrySecs);
            this.Controls.Add(this.NetworkErrorMsg);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.ClockDisplay);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pick Wave Batch Monitor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HJSPickWaveBatchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.DataGridView DataGrid;
        private Dataset Dataset;
        private System.Windows.Forms.BindingSource HJSPickWaveBatchesBindingSource;
        private DatasetTableAdapters.view_HJS_Pick_Wave_BatchesTableAdapter HJSPickWaveBatchesTableAdapter;
        private System.Windows.Forms.TextBox ClockDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnPWB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnTime;
        private System.Windows.Forms.TextBox NetworkErrorMsg;
        private System.Windows.Forms.TextBox NetworkRetrySecs;
    }
}

