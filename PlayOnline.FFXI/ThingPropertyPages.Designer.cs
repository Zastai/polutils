namespace PlayOnline.FFXI {

  partial class ThingPropertyPages {

    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing) {
      if (disposing && components != null)
	components.Dispose();
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThingPropertyPages));
      this.tabPages = new System.Windows.Forms.TabControl();
      this.tabDummy = new System.Windows.Forms.TabPage();
      this.pnlButtons = new System.Windows.Forms.Panel();
      this.btnClose = new System.Windows.Forms.Button();
      this.tabPages.SuspendLayout();
      this.pnlButtons.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabPages
      // 
      this.tabPages.Controls.Add(this.tabDummy);
      resources.ApplyResources(this.tabPages, "tabPages");
      this.tabPages.HotTrack = true;
      this.tabPages.Multiline = true;
      this.tabPages.Name = "tabPages";
      this.tabPages.SelectedIndex = 0;
      // 
      // tabDummy
      // 
      resources.ApplyResources(this.tabDummy, "tabDummy");
      this.tabDummy.Name = "tabDummy";
      this.tabDummy.UseVisualStyleBackColor = true;
      // 
      // pnlButtons
      // 
      this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
      this.pnlButtons.Controls.Add(this.btnClose);
      resources.ApplyResources(this.pnlButtons, "pnlButtons");
      this.pnlButtons.Name = "pnlButtons";
      // 
      // btnClose
      // 
      resources.ApplyResources(this.btnClose, "btnClose");
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnClose.Name = "btnClose";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // ThingPropertyPages
      // 
      this.AcceptButton = this.btnClose;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ControlBox = false;
      this.Controls.Add(this.tabPages);
      this.Controls.Add(this.pnlButtons);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ThingPropertyPages";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.tabPages.ResumeLayout(false);
      this.pnlButtons.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabPages;
    private System.Windows.Forms.Panel pnlButtons;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.TabPage tabDummy;

  }

}