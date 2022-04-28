namespace MyTransportApp
{
    partial class FormAbfahtstafel
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbfahtstafel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvConnectionList = new System.Windows.Forms.DataGridView();
            this.ColumnFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboStation = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnectionList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.dgvConnectionList);
            this.panel1.Controls.Add(this.cboStation);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblIcon);
            this.panel1.Controls.Add(this.picIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 1053);
            this.panel1.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(206, 200);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(383, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvConnectionList
            // 
            this.dgvConnectionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnectionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFrom,
            this.ColumnTo,
            this.ColumnDeparture});
            this.dgvConnectionList.Location = new System.Drawing.Point(0, 249);
            this.dgvConnectionList.Name = "dgvConnectionList";
            this.dgvConnectionList.RowTemplate.Height = 25;
            this.dgvConnectionList.Size = new System.Drawing.Size(800, 804);
            this.dgvConnectionList.TabIndex = 14;
            // 
            // ColumnFrom
            // 
            this.ColumnFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFrom.HeaderText = "Von";
            this.ColumnFrom.Name = "ColumnFrom";
            this.ColumnFrom.ReadOnly = true;
            // 
            // ColumnTo
            // 
            this.ColumnTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTo.HeaderText = "Nach";
            this.ColumnTo.Name = "ColumnTo";
            this.ColumnTo.ReadOnly = true;
            // 
            // ColumnDeparture
            // 
            this.ColumnDeparture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDeparture.HeaderText = "Abfahrt";
            this.ColumnDeparture.Name = "ColumnDeparture";
            this.ColumnDeparture.ReadOnly = true;
            // 
            // cboStation
            // 
            this.cboStation.FormattingEnabled = true;
            this.cboStation.Location = new System.Drawing.Point(117, 171);
            this.cboStation.Name = "cboStation";
            this.cboStation.Size = new System.Drawing.Size(529, 23);
            this.cboStation.TabIndex = 13;
            this.cboStation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboStation_KeyUp);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Sitka Heading", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(290, 72);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(226, 50);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Abfahrtstafel";
            // 
            // lblIcon
            // 
            this.lblIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIcon.Location = new System.Drawing.Point(117, 47);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(132, 18);
            this.lblIcon.TabIndex = 10;
            this.lblIcon.Text = "SwissTransport";
            // 
            // picIcon
            // 
            this.picIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picIcon.Image = global::MyTransportApp.Properties.Resources.icon_removebg_preview;
            this.picIcon.Location = new System.Drawing.Point(12, 12);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(99, 53);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 9;
            this.picIcon.TabStop = false;
            // 
            // FormAbfahtstafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1053);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAbfahtstafel";
            this.Text = "Abfahtstafel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnectionList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Label lblIcon;
        private PictureBox picIcon;
        private ComboBox cboStation;
        private DataGridView dgvConnectionList;
        private Button btnSearch;
        private DataGridViewTextBoxColumn ColumnFrom;
        private DataGridViewTextBoxColumn ColumnTo;
        private DataGridViewTextBoxColumn ColumnDeparture;
    }
}