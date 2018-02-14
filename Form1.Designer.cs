namespace FacadePattern
{
    partial class Form1
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
            this.label19 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.combo_channel = new System.Windows.Forms.ComboBox();
            this.combo_vehicle = new System.Windows.Forms.ComboBox();
            this.btn_setupCommand = new System.Windows.Forms.Button();
            this.btn_setupRtns = new System.Windows.Forms.Button();
            this.btn_setupSpec = new System.Windows.Forms.Button();
            this.btn_setupOps = new System.Windows.Forms.Button();
            this.btn_setupCommo = new System.Windows.Forms.Button();
            this.btn_setupMedic = new System.Windows.Forms.Button();
            this.btn_setupAll = new System.Windows.Forms.Button();
            this.txtBox_display = new System.Windows.Forms.RichTextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 36);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "Channel Select";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(11, 9);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(75, 13);
            this.label29.TabIndex = 13;
            this.label29.Text = "Vehicle Select";
            // 
            // combo_channel
            // 
            this.combo_channel.FormattingEnabled = true;
            this.combo_channel.Items.AddRange(new object[] {
            "Chanel 1",
            "Chanel 2",
            "Chanel 3",
            "Chanel 4",
            "Chanel 5",
            "Chanel 6",
            "Chanel 7",
            "Chanel 8",
            "Chanel 9",
            "Chanel 10"});
            this.combo_channel.Location = new System.Drawing.Point(88, 32);
            this.combo_channel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combo_channel.Name = "combo_channel";
            this.combo_channel.Size = new System.Drawing.Size(135, 21);
            this.combo_channel.TabIndex = 12;
            this.combo_channel.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // combo_vehicle
            // 
            this.combo_vehicle.FormattingEnabled = true;
            this.combo_vehicle.Items.AddRange(new object[] {
            "Command",
            "Communications",
            "Medic",
            "Operations",
            "Retans Station",
            "Special Operations"});
            this.combo_vehicle.Location = new System.Drawing.Point(88, 7);
            this.combo_vehicle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combo_vehicle.Name = "combo_vehicle";
            this.combo_vehicle.Size = new System.Drawing.Size(135, 21);
            this.combo_vehicle.TabIndex = 10;
            this.combo_vehicle.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // btn_setupCommand
            // 
            this.btn_setupCommand.Location = new System.Drawing.Point(14, 58);
            this.btn_setupCommand.Name = "btn_setupCommand";
            this.btn_setupCommand.Size = new System.Drawing.Size(140, 23);
            this.btn_setupCommand.TabIndex = 16;
            this.btn_setupCommand.Text = "Setup Command";
            this.btn_setupCommand.UseVisualStyleBackColor = true;
            this.btn_setupCommand.Click += new System.EventHandler(this.btn_setupCommand_Click);
            // 
            // btn_setupRtns
            // 
            this.btn_setupRtns.Location = new System.Drawing.Point(15, 203);
            this.btn_setupRtns.Name = "btn_setupRtns";
            this.btn_setupRtns.Size = new System.Drawing.Size(139, 23);
            this.btn_setupRtns.TabIndex = 17;
            this.btn_setupRtns.Text = "Setup Retans";
            this.btn_setupRtns.UseVisualStyleBackColor = true;
            this.btn_setupRtns.Click += new System.EventHandler(this.btn_setupRtns_Click);
            // 
            // btn_setupSpec
            // 
            this.btn_setupSpec.Location = new System.Drawing.Point(15, 174);
            this.btn_setupSpec.Name = "btn_setupSpec";
            this.btn_setupSpec.Size = new System.Drawing.Size(139, 23);
            this.btn_setupSpec.TabIndex = 18;
            this.btn_setupSpec.Text = "Setup Spec Ops";
            this.btn_setupSpec.UseVisualStyleBackColor = true;
            this.btn_setupSpec.Click += new System.EventHandler(this.btn_setupSpec_Click);
            // 
            // btn_setupOps
            // 
            this.btn_setupOps.Location = new System.Drawing.Point(15, 145);
            this.btn_setupOps.Name = "btn_setupOps";
            this.btn_setupOps.Size = new System.Drawing.Size(139, 23);
            this.btn_setupOps.TabIndex = 19;
            this.btn_setupOps.Text = "Setup Operations";
            this.btn_setupOps.UseVisualStyleBackColor = true;
            this.btn_setupOps.Click += new System.EventHandler(this.btn_setupOps_Click);
            // 
            // btn_setupCommo
            // 
            this.btn_setupCommo.Location = new System.Drawing.Point(15, 116);
            this.btn_setupCommo.Name = "btn_setupCommo";
            this.btn_setupCommo.Size = new System.Drawing.Size(139, 23);
            this.btn_setupCommo.TabIndex = 20;
            this.btn_setupCommo.Text = "Setup Communications";
            this.btn_setupCommo.UseVisualStyleBackColor = true;
            this.btn_setupCommo.Click += new System.EventHandler(this.btn_setupCommo_Click);
            // 
            // btn_setupMedic
            // 
            this.btn_setupMedic.Location = new System.Drawing.Point(15, 87);
            this.btn_setupMedic.Name = "btn_setupMedic";
            this.btn_setupMedic.Size = new System.Drawing.Size(139, 23);
            this.btn_setupMedic.TabIndex = 21;
            this.btn_setupMedic.Text = "Setup Medic";
            this.btn_setupMedic.UseVisualStyleBackColor = true;
            this.btn_setupMedic.Click += new System.EventHandler(this.btn_setupMedic_Click);
            // 
            // btn_setupAll
            // 
            this.btn_setupAll.Location = new System.Drawing.Point(15, 233);
            this.btn_setupAll.Name = "btn_setupAll";
            this.btn_setupAll.Size = new System.Drawing.Size(139, 23);
            this.btn_setupAll.TabIndex = 22;
            this.btn_setupAll.Text = "Setup All";
            this.btn_setupAll.UseVisualStyleBackColor = true;
            this.btn_setupAll.Click += new System.EventHandler(this.btn_setupAll_Click);
            // 
            // txtBox_display
            // 
            this.txtBox_display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_display.Location = new System.Drawing.Point(228, 6);
            this.txtBox_display.Name = "txtBox_display";
            this.txtBox_display.Size = new System.Drawing.Size(159, 279);
            this.txtBox_display.TabIndex = 23;
            this.txtBox_display.Text = "";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(13, 261);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(139, 23);
            this.btn_reset.TabIndex = 24;
            this.btn_reset.Text = "Reset Radios";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 302);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txtBox_display);
            this.Controls.Add(this.btn_setupAll);
            this.Controls.Add(this.btn_setupMedic);
            this.Controls.Add(this.btn_setupCommo);
            this.Controls.Add(this.btn_setupOps);
            this.Controls.Add(this.btn_setupSpec);
            this.Controls.Add(this.btn_setupRtns);
            this.Controls.Add(this.btn_setupCommand);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.combo_channel);
            this.Controls.Add(this.combo_vehicle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Facade Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox combo_channel;
        private System.Windows.Forms.ComboBox combo_vehicle;
        private System.Windows.Forms.Button btn_setupCommand;
        private System.Windows.Forms.Button btn_setupRtns;
        private System.Windows.Forms.Button btn_setupSpec;
        private System.Windows.Forms.Button btn_setupOps;
        private System.Windows.Forms.Button btn_setupCommo;
        private System.Windows.Forms.Button btn_setupMedic;
        private System.Windows.Forms.Button btn_setupAll;
        private System.Windows.Forms.RichTextBox txtBox_display;
        private System.Windows.Forms.Button btn_reset;
    }
}

