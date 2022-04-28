namespace MyTransportApp
{
    partial class FormVerbindungen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerbindungen));
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxTime = new System.Windows.Forms.TextBox();
            this.dtpVerbindungen = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboEndstation = new System.Windows.Forms.ComboBox();
            this.cboStartstation = new System.Windows.Forms.ComboBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.lblIcon = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.dgvConnectionList = new System.Windows.Forms.DataGridView();
            this.ColumnFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeparturePlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArrivalPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBusTrainNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnectionList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Sitka Heading", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(249, 75);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(304, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Verbindungen suchen ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbxTime);
            this.panel1.Controls.Add(this.dtpVerbindungen);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(82, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 327);
            this.panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(166, 231);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(304, 66);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxTime
            // 
            this.tbxTime.Location = new System.Drawing.Point(441, 188);
            this.tbxTime.Name = "tbxTime";
            this.tbxTime.Size = new System.Drawing.Size(100, 23);
            this.tbxTime.TabIndex = 3;
            // 
            // dtpVerbindungen
            // 
            this.dtpVerbindungen.CustomFormat = "dd/MM/yyyy";
            this.dtpVerbindungen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVerbindungen.Location = new System.Drawing.Point(63, 185);
            this.dtpVerbindungen.Name = "dtpVerbindungen";
            this.dtpVerbindungen.Size = new System.Drawing.Size(208, 23);
            this.dtpVerbindungen.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.cboEndstation);
            this.panel2.Controls.Add(this.cboStartstation);
            this.panel2.Controls.Add(this.btnReverse);
            this.panel2.Location = new System.Drawing.Point(48, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 124);
            this.panel2.TabIndex = 0;
            // 
            // cboEndstation
            // 
            this.cboEndstation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboEndstation.FormattingEnabled = true;
            this.cboEndstation.Location = new System.Drawing.Point(319, 54);
            this.cboEndstation.Name = "cboEndstation";
            this.cboEndstation.Size = new System.Drawing.Size(184, 23);
            this.cboEndstation.TabIndex = 4;
            this.cboEndstation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboEndstation_KeyUp);
            // 
            // cboStartstation
            // 
            this.cboStartstation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboStartstation.FormattingEnabled = true;
            this.cboStartstation.Location = new System.Drawing.Point(27, 54);
            this.cboStartstation.Name = "cboStartstation";
            this.cboStartstation.Size = new System.Drawing.Size(184, 23);
            this.cboStartstation.TabIndex = 3;
            this.cboStartstation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboStartstation_KeyUp);
            // 
            // btnReverse
            // 
            this.btnReverse.Image = ((System.Drawing.Image)(resources.GetObject("btnReverse.Image")));
            this.btnReverse.Location = new System.Drawing.Point(236, 37);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(59, 54);
            this.btnReverse.TabIndex = 2;
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // lblIcon
            // 
            this.lblIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIcon.Location = new System.Drawing.Point(117, 47);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(132, 18);
            this.lblIcon.TabIndex = 8;
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
            this.picIcon.TabIndex = 7;
            this.picIcon.TabStop = false;
            // 
            // dgvConnectionList
            // 
            this.dgvConnectionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnectionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFrom,
            this.ColumnTo,
            this.ColumnDeparture,
            this.ColumnArrival,
            this.ColumnDeparturePlatform,
            this.ColumnArrivalPlatform,
            this.ColumnDuration});
            this.dgvConnectionList.Location = new System.Drawing.Point(-2, 495);
            this.dgvConnectionList.Name = "dgvConnectionList";
            this.dgvConnectionList.RowTemplate.Height = 25;
            this.dgvConnectionList.Size = new System.Drawing.Size(800, 423);
            this.dgvConnectionList.TabIndex = 9;
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
            // ColumnArrival
            // 
            this.ColumnArrival.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnArrival.HeaderText = "Ankunkft";
            this.ColumnArrival.Name = "ColumnArrival";
            // 
            // ColumnDeparturePlatform
            // 
            this.ColumnDeparturePlatform.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDeparturePlatform.HeaderText = "Abfahrt Gleis";
            this.ColumnDeparturePlatform.Name = "ColumnDeparturePlatform";
            this.ColumnDeparturePlatform.ReadOnly = true;
            // 
            // ColumnArrivalPlatform
            // 
            this.ColumnArrivalPlatform.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnArrivalPlatform.HeaderText = "Ankunft Gleis";
            this.ColumnArrivalPlatform.Name = "ColumnArrivalPlatform";
            this.ColumnArrivalPlatform.ReadOnly = true;
            // 
            // ColumnDuration
            // 
            this.ColumnDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDuration.HeaderText = "Dauer";
            this.ColumnDuration.Name = "ColumnDuration";
            this.ColumnDuration.ReadOnly = true;
            // 
            // ColumnBusTrainNumber
            // 
            this.ColumnBusTrainNumber.HeaderText = "Bus|Zug und Nr.";
            this.ColumnBusTrainNumber.Name = "ColumnBusTrainNumber";
            this.ColumnBusTrainNumber.ReadOnly = true;
            // 
            // ColumnDirection
            // 
            this.ColumnDirection.HeaderText = "Richtung";
            this.ColumnDirection.Name = "ColumnDirection";
            this.ColumnDirection.ReadOnly = true;
            // 
            // FormVerbindungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 917);
            this.Controls.Add(this.dgvConnectionList);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormVerbindungen";
            this.Text = "Verbindungen";
            this.Load += new System.EventHandler(this.FormVerbindungen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnectionList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private DateTimePicker dtpVerbindungen;
        private Panel panel2;
        private Button btnReverse;
        private TextBox tbxTime;
        private Label lblIcon;
        private PictureBox picIcon;
        private DataGridView dgvConnectionList;
        private DataGridViewTextBoxColumn ColumnBusTrainNumber;
        private DataGridViewTextBoxColumn ColumnDirection;
        private Button btnSearch;
        private DataGridViewTextBoxColumn ColumnFrom;
        private DataGridViewTextBoxColumn ColumnTo;
        private DataGridViewTextBoxColumn ColumnDeparture;
        private DataGridViewTextBoxColumn ColumnArrival;
        private DataGridViewTextBoxColumn ColumnDeparturePlatform;
        private DataGridViewTextBoxColumn ColumnArrivalPlatform;
        private DataGridViewTextBoxColumn ColumnDuration;
        private ComboBox cboEndstation;
        private ComboBox cboStartstation;
    }
}