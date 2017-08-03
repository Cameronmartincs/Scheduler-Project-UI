namespace Schedular_Test_V1
{
    partial class RulesForm
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
            this.btnConfirmType = new System.Windows.Forms.Button();
            this.rulePanel = new System.Windows.Forms.Panel();
            this.lblField3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblField2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblField1 = new System.Windows.Forms.Label();
            this.cbRuleType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRules = new System.Windows.Forms.ListBox();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblField4 = new System.Windows.Forms.Label();
            this.rulePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmType
            // 
            this.btnConfirmType.Location = new System.Drawing.Point(265, 40);
            this.btnConfirmType.Name = "btnConfirmType";
            this.btnConfirmType.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmType.TabIndex = 0;
            this.btnConfirmType.Text = "Confirm";
            this.btnConfirmType.UseVisualStyleBackColor = true;
            this.btnConfirmType.Click += new System.EventHandler(this.btnConfirmType_Click);
            // 
            // rulePanel
            // 
            this.rulePanel.Controls.Add(this.lblField4);
            this.rulePanel.Controls.Add(this.lblField3);
            this.rulePanel.Controls.Add(this.textBox2);
            this.rulePanel.Controls.Add(this.lblField2);
            this.rulePanel.Controls.Add(this.textBox1);
            this.rulePanel.Controls.Add(this.lblField1);
            this.rulePanel.Location = new System.Drawing.Point(346, 12);
            this.rulePanel.Name = "rulePanel";
            this.rulePanel.Size = new System.Drawing.Size(598, 89);
            this.rulePanel.TabIndex = 1;
            this.rulePanel.Visible = false;
            // 
            // lblField3
            // 
            this.lblField3.AutoSize = true;
            this.lblField3.Location = new System.Drawing.Point(277, 33);
            this.lblField3.Name = "lblField3";
            this.lblField3.Size = new System.Drawing.Size(33, 13);
            this.lblField3.TabIndex = 4;
            this.lblField3.Text = "Have";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(347, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblField2
            // 
            this.lblField2.AutoSize = true;
            this.lblField2.Location = new System.Drawing.Point(251, 33);
            this.lblField2.Name = "lblField2";
            this.lblField2.Size = new System.Drawing.Size(30, 13);
            this.lblField2.TabIndex = 2;
            this.lblField2.Text = "Must";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblField1
            // 
            this.lblField1.AutoSize = true;
            this.lblField1.Location = new System.Drawing.Point(28, 32);
            this.lblField1.Name = "lblField1";
            this.lblField1.Size = new System.Drawing.Size(35, 13);
            this.lblField1.TabIndex = 0;
            this.lblField1.Text = "label1";
            // 
            // cbRuleType
            // 
            this.cbRuleType.FormattingEnabled = true;
            this.cbRuleType.Location = new System.Drawing.Point(138, 40);
            this.cbRuleType.Name = "cbRuleType";
            this.cbRuleType.Size = new System.Drawing.Size(121, 21);
            this.cbRuleType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Type of Rule:";
            // 
            // lbRules
            // 
            this.lbRules.FormattingEnabled = true;
            this.lbRules.Location = new System.Drawing.Point(39, 121);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(681, 368);
            this.lbRules.TabIndex = 4;
            // 
            // btnFinalize
            // 
            this.btnFinalize.Location = new System.Drawing.Point(755, 466);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(75, 23);
            this.btnFinalize.TabIndex = 5;
            this.btnFinalize.Text = "Finalize";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(755, 121);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create Rule";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblField4
            // 
            this.lblField4.AutoSize = true;
            this.lblField4.Location = new System.Drawing.Point(307, 33);
            this.lblField4.Name = "lblField4";
            this.lblField4.Size = new System.Drawing.Size(35, 13);
            this.lblField4.TabIndex = 5;
            this.lblField4.Text = "label1";
            // 
            // RulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 553);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.lbRules);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRuleType);
            this.Controls.Add(this.rulePanel);
            this.Controls.Add(this.btnConfirmType);
            this.Name = "RulesForm";
            this.Text = "RulesForm";
            this.Load += new System.EventHandler(this.RulesForm_Load);
            this.rulePanel.ResumeLayout(false);
            this.rulePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmType;
        private System.Windows.Forms.Panel rulePanel;
        private System.Windows.Forms.Label lblField3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblField2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblField1;
        private System.Windows.Forms.ComboBox cbRuleType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbRules;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblField4;
    }
}