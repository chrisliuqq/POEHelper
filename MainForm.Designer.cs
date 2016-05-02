namespace POEHelper
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSetting = new System.Windows.Forms.Button();
            this.checkBoxGlobalHotKey = new System.Windows.Forms.CheckBox();
            this.labelChannel = new System.Windows.Forms.Label();
            this.comboBoxChannel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSetting
            // 
            this.buttonSetting.Location = new System.Drawing.Point(131, 12);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(75, 23);
            this.buttonSetting.TabIndex = 0;
            this.buttonSetting.Text = "設定";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // checkBoxGlobalHotKey
            // 
            this.checkBoxGlobalHotKey.AutoSize = true;
            this.checkBoxGlobalHotKey.Location = new System.Drawing.Point(12, 16);
            this.checkBoxGlobalHotKey.Name = "checkBoxGlobalHotKey";
            this.checkBoxGlobalHotKey.Size = new System.Drawing.Size(108, 16);
            this.checkBoxGlobalHotKey.TabIndex = 1;
            this.checkBoxGlobalHotKey.Text = "啟用全域快速鍵";
            this.checkBoxGlobalHotKey.UseVisualStyleBackColor = true;
            this.checkBoxGlobalHotKey.CheckedChanged += new System.EventHandler(this.checkBoxGlobalHotKey_CheckedChanged);
            // 
            // labelChannel
            // 
            this.labelChannel.AutoSize = true;
            this.labelChannel.Location = new System.Drawing.Point(12, 52);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.Size = new System.Drawing.Size(65, 12);
            this.labelChannel.TabIndex = 2;
            this.labelChannel.Text = "回復頻道：";
            // 
            // comboBoxChannel
            // 
            this.comboBoxChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChannel.FormattingEnabled = true;
            this.comboBoxChannel.Items.AddRange(new object[] {
            "無",
            "公會",
            "隊伍"});
            this.comboBoxChannel.Location = new System.Drawing.Point(83, 49);
            this.comboBoxChannel.Name = "comboBoxChannel";
            this.comboBoxChannel.Size = new System.Drawing.Size(123, 20);
            this.comboBoxChannel.TabIndex = 3;
            this.comboBoxChannel.SelectedIndexChanged += new System.EventHandler(this.comboBoxChannel_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 90);
            this.Controls.Add(this.comboBoxChannel);
            this.Controls.Add(this.labelChannel);
            this.Controls.Add(this.checkBoxGlobalHotKey);
            this.Controls.Add(this.buttonSetting);
            this.Name = "MainForm";
            this.Text = "POE 小幫手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.CheckBox checkBoxGlobalHotKey;
        private System.Windows.Forms.Label labelChannel;
        private System.Windows.Forms.ComboBox comboBoxChannel;
    }
}

