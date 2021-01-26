namespace SOM {
   partial class frmMain {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.loadCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.panel1 = new System.Windows.Forms.Panel();
         this.label1 = new System.Windows.Forms.Label();
         this.txtScale = new System.Windows.Forms.TextBox();
         this.Pesgo1 = new Gigasoft.ProEssentials.Pesgo();
         this.label2 = new System.Windows.Forms.Label();
         this.txtError = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.txtMaxIter = new System.Windows.Forms.TextBox();
         this.lblResErr = new System.Windows.Forms.Label();
         this.menuStrip1.SuspendLayout();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(832, 24);
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCSVToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // loadCSVToolStripMenuItem
         // 
         this.loadCSVToolStripMenuItem.Name = "loadCSVToolStripMenuItem";
         this.loadCSVToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.loadCSVToolStripMenuItem.Text = "Load CSV";
         this.loadCSVToolStripMenuItem.Click += new System.EventHandler(this.loadCSVToolStripMenuItem_Click);
         // 
         // panel1
         // 
         this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panel1.Controls.Add(this.Pesgo1);
         this.panel1.Location = new System.Drawing.Point(0, 49);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(832, 500);
         this.panel1.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(6, 33);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(73, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "Desired Scale";
         // 
         // txtScale
         // 
         this.txtScale.Location = new System.Drawing.Point(85, 26);
         this.txtScale.Name = "txtScale";
         this.txtScale.Size = new System.Drawing.Size(55, 20);
         this.txtScale.TabIndex = 3;
         this.txtScale.Text = "100";
         // 
         // Pesgo1
         // 
         this.Pesgo1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.Pesgo1.Location = new System.Drawing.Point(0, 0);
         this.Pesgo1.Name = "Pesgo1";
         this.Pesgo1.Size = new System.Drawing.Size(832, 500);
         this.Pesgo1.TabIndex = 0;
         this.Pesgo1.Text = "pesgo1";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(184, 33);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(63, 13);
         this.label2.TabIndex = 4;
         this.label2.Text = "Target Error";
         // 
         // txtError
         // 
         this.txtError.Location = new System.Drawing.Point(253, 26);
         this.txtError.Name = "txtError";
         this.txtError.Size = new System.Drawing.Size(59, 20);
         this.txtError.TabIndex = 5;
         this.txtError.Text = "0.0001";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(342, 33);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(73, 13);
         this.label3.TabIndex = 6;
         this.label3.Text = "Max Iterations";
         // 
         // txtMaxIter
         // 
         this.txtMaxIter.Location = new System.Drawing.Point(421, 26);
         this.txtMaxIter.Name = "txtMaxIter";
         this.txtMaxIter.Size = new System.Drawing.Size(59, 20);
         this.txtMaxIter.TabIndex = 7;
         this.txtMaxIter.Text = "50000000";
         // 
         // lblResErr
         // 
         this.lblResErr.AutoSize = true;
         this.lblResErr.Location = new System.Drawing.Point(511, 33);
         this.lblResErr.Name = "lblResErr";
         this.lblResErr.Size = new System.Drawing.Size(88, 13);
         this.lblResErr.TabIndex = 8;
         this.lblResErr.Text = "Result Error: N/A";
         // 
         // frmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(832, 548);
         this.Controls.Add(this.lblResErr);
         this.Controls.Add(this.txtMaxIter);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.txtError);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtScale);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.menuStrip1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "frmMain";
         this.Text = "Self Organizing Map Analysis";
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem loadCSVToolStripMenuItem;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtScale;
      private Gigasoft.ProEssentials.Pesgo Pesgo1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtError;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtMaxIter;
      private System.Windows.Forms.Label lblResErr;
   }
}

