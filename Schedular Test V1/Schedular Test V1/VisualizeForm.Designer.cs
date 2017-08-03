namespace Schedular_Test_V1
{
    partial class VisualizeForm
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
            this.planningGrid1 = new SourceGrid.Planning.PlanningGrid();
            this.SuspendLayout();
            // 
            // planningGrid1
            // 
            this.planningGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.planningGrid1.Location = new System.Drawing.Point(0, 0);
            this.planningGrid1.Name = "planningGrid1";
            this.planningGrid1.Size = new System.Drawing.Size(965, 673);
            this.planningGrid1.TabIndex = 0;
            // 
            // VisualizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 673);
            this.Controls.Add(this.planningGrid1);
            this.Name = "VisualizeForm";
            this.Text = "VisualizeForm";
            this.Load += new System.EventHandler(this.VisualizeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SourceGrid.Planning.PlanningGrid planningGrid1;
    }
}