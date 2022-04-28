namespace MyTransportApp
{
    partial class StartupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.btnStationen = new System.Windows.Forms.Button();
            this.btnVerbindungen = new System.Windows.Forms.Button();
            this.lblIcon = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAbfahrtstafel);
            this.panel1.Controls.Add(this.btnStationen);
            this.panel1.Controls.Add(this.btnVerbindungen);
            this.panel1.Controls.Add(this.lblIcon);
            this.panel1.Controls.Add(this.picIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 223);
            this.panel1.TabIndex = 0;
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(316, 134);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(145, 72);
            this.btnAbfahrtstafel.TabIndex = 9;
            this.btnAbfahrtstafel.Text = "Abfahrtstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            this.btnAbfahrtstafel.Click += new System.EventHandler(this.btnAbfahrtstafel_Click);
            // 
            // btnStationen
            // 
            this.btnStationen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStationen.Location = new System.Drawing.Point(161, 134);
            this.btnStationen.Name = "btnStationen";
            this.btnStationen.Size = new System.Drawing.Size(145, 72);
            this.btnStationen.TabIndex = 8;
            this.btnStationen.Text = "Stationen in meiner Nähe";
            this.btnStationen.UseVisualStyleBackColor = true;
            // 
            // btnVerbindungen
            // 
            this.btnVerbindungen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerbindungen.Location = new System.Drawing.Point(8, 134);
            this.btnVerbindungen.Name = "btnVerbindungen";
            this.btnVerbindungen.Size = new System.Drawing.Size(145, 72);
            this.btnVerbindungen.TabIndex = 7;
            this.btnVerbindungen.Text = "Verbindungen";
            this.btnVerbindungen.UseVisualStyleBackColor = true;
            this.btnVerbindungen.Click += new System.EventHandler(this.btnVerbindungen_Click);
            // 
            // lblIcon
            // 
            this.lblIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIcon.Location = new System.Drawing.Point(117, 51);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(132, 18);
            this.lblIcon.TabIndex = 6;
            this.lblIcon.Text = "SwissTransport";
            // 
            // picIcon
            // 
            this.picIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picIcon.Image = global::MyTransportApp.Properties.Resources.icon_removebg_preview;
            this.picIcon.Location = new System.Drawing.Point(12, 16);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(99, 53);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 5;
            this.picIcon.TabStop = false;
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 223);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartupForm";
            this.Text = "SwissTransport Startsite";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnAbfahrtstafel;
        private Button btnStationen;
        private Button btnVerbindungen;
        private Label lblIcon;
        private PictureBox picIcon;
    }
}