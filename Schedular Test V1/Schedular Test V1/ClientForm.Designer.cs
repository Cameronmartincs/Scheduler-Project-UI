namespace Schedular_Test_V1
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.listEditor1 = new SourceGrid.ListEditor();
            this.inputGrid = new SourceGrid.Grid();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listEditor1
            // 
            this.listEditor1.Editors = null;
            this.listEditor1.EnableAdd = true;
            this.listEditor1.EnableMove = true;
            this.listEditor1.EnableRefresh = true;
            this.listEditor1.EnableRemove = true;
            this.listEditor1.ItemType = null;
            this.listEditor1.List = null;
            this.listEditor1.Location = new System.Drawing.Point(58, 190);
            this.listEditor1.Name = "listEditor1";
            this.listEditor1.Properties = null;
            this.listEditor1.Size = new System.Drawing.Size(1154, 337);
            this.listEditor1.TabIndex = 13;
            this.listEditor1.Tempo = null;
            // 
            // inputGrid
            // 
            this.inputGrid.AutoStretchColumnsToFitWidth = true;
            this.inputGrid.EnableSort = true;
            this.inputGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputGrid.Location = new System.Drawing.Point(58, 43);
            this.inputGrid.Name = "inputGrid";
            this.inputGrid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.inputGrid.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.inputGrid.Size = new System.Drawing.Size(1154, 120);
            this.inputGrid.TabIndex = 12;
            this.inputGrid.TabStop = true;
            this.inputGrid.ToolTipText = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1116, 533);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 30);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.listEditor1);
            this.Controls.Add(this.inputGrid);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private SourceGrid.Grid inputGrid;
        private SourceGrid.ListEditor listEditor1;
        private System.Windows.Forms.Button btnSubmit;
    }


}