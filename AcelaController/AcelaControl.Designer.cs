namespace Drakenya.AcelaController
{
    partial class AcelaControlForm
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
            this.btnStatus = new System.Windows.Forms.Button();
            this.grpCab1 = new System.Windows.Forms.GroupBox();
            this.trkCab1Speed = new System.Windows.Forms.TrackBar();
            this.trkCab1Inertia = new System.Windows.Forms.TrackBar();
            this.rdoCab1Reverse = new System.Windows.Forms.RadioButton();
            this.rdoCab1Forward = new System.Windows.Forms.RadioButton();
            this.chkCab1Brake = new System.Windows.Forms.CheckBox();
            this.grpCab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkCab1Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkCab1Inertia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(12, 12);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(75, 23);
            this.btnStatus.TabIndex = 0;
            this.btnStatus.Text = "Offline";
            this.btnStatus.UseVisualStyleBackColor = true;
            // 
            // grpCab1
            // 
            this.grpCab1.Controls.Add(this.trkCab1Speed);
            this.grpCab1.Controls.Add(this.trkCab1Inertia);
            this.grpCab1.Controls.Add(this.rdoCab1Reverse);
            this.grpCab1.Controls.Add(this.rdoCab1Forward);
            this.grpCab1.Controls.Add(this.chkCab1Brake);
            this.grpCab1.Location = new System.Drawing.Point(46, 70);
            this.grpCab1.Name = "grpCab1";
            this.grpCab1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpCab1.Size = new System.Drawing.Size(192, 177);
            this.grpCab1.TabIndex = 1;
            this.grpCab1.TabStop = false;
            this.grpCab1.Text = "Cab 1";
            // 
            // trkCab1Speed
            // 
            this.trkCab1Speed.Location = new System.Drawing.Point(6, 125);
            this.trkCab1Speed.Maximum = 100;
            this.trkCab1Speed.Name = "trkCab1Speed";
            this.trkCab1Speed.Size = new System.Drawing.Size(180, 45);
            this.trkCab1Speed.TabIndex = 4;
            this.trkCab1Speed.Scroll += new System.EventHandler(this.trkCab1Speed_Scroll);
            // 
            // trkCab1Inertia
            // 
            this.trkCab1Inertia.Location = new System.Drawing.Point(6, 74);
            this.trkCab1Inertia.Maximum = 7;
            this.trkCab1Inertia.Name = "trkCab1Inertia";
            this.trkCab1Inertia.Size = new System.Drawing.Size(180, 45);
            this.trkCab1Inertia.TabIndex = 3;
            this.trkCab1Inertia.Scroll += new System.EventHandler(this.trkCab1Inertia_Scroll);
            // 
            // rdoCab1Reverse
            // 
            this.rdoCab1Reverse.AutoSize = true;
            this.rdoCab1Reverse.Location = new System.Drawing.Point(112, 42);
            this.rdoCab1Reverse.Name = "rdoCab1Reverse";
            this.rdoCab1Reverse.Size = new System.Drawing.Size(65, 17);
            this.rdoCab1Reverse.TabIndex = 2;
            this.rdoCab1Reverse.Text = "Reverse";
            this.rdoCab1Reverse.UseVisualStyleBackColor = true;
            this.rdoCab1Reverse.CheckedChanged += new System.EventHandler(this.rdoCab1Reverse_CheckedChanged);
            // 
            // rdoCab1Forward
            // 
            this.rdoCab1Forward.AutoSize = true;
            this.rdoCab1Forward.Checked = true;
            this.rdoCab1Forward.Location = new System.Drawing.Point(112, 19);
            this.rdoCab1Forward.Name = "rdoCab1Forward";
            this.rdoCab1Forward.Size = new System.Drawing.Size(63, 17);
            this.rdoCab1Forward.TabIndex = 1;
            this.rdoCab1Forward.TabStop = true;
            this.rdoCab1Forward.Text = "Forward";
            this.rdoCab1Forward.UseVisualStyleBackColor = true;
            this.rdoCab1Forward.CheckedChanged += new System.EventHandler(this.rdoCab1Forward_CheckedChanged);
            // 
            // chkCab1Brake
            // 
            this.chkCab1Brake.AutoSize = true;
            this.chkCab1Brake.Location = new System.Drawing.Point(6, 19);
            this.chkCab1Brake.Name = "chkCab1Brake";
            this.chkCab1Brake.Size = new System.Drawing.Size(100, 17);
            this.chkCab1Brake.TabIndex = 0;
            this.chkCab1Brake.Text = "Brake Engaged";
            this.chkCab1Brake.UseVisualStyleBackColor = true;
            this.chkCab1Brake.CheckedChanged += new System.EventHandler(this.chkCab1Brake_CheckedChanged);
            // 
            // AcelaControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 519);
            this.Controls.Add(this.grpCab1);
            this.Controls.Add(this.btnStatus);
            this.Name = "AcelaControlForm";
            this.Text = "Acela Controller";
            this.Load += new System.EventHandler(this.AcelaControlForm_Load);
            this.grpCab1.ResumeLayout(false);
            this.grpCab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkCab1Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkCab1Inertia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.GroupBox grpCab1;
        private System.Windows.Forms.RadioButton rdoCab1Reverse;
        private System.Windows.Forms.RadioButton rdoCab1Forward;
        private System.Windows.Forms.CheckBox chkCab1Brake;
        private System.Windows.Forms.TrackBar trkCab1Speed;
        private System.Windows.Forms.TrackBar trkCab1Inertia;
    }
}

