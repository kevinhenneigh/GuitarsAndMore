namespace GuitarsAndMore
{
    partial class MainForm
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
            this.AddGuitarBtn = new System.Windows.Forms.Button();
            this.UpdateGuitarBtn = new System.Windows.Forms.Button();
            this.DeleteGuitarBtn = new System.Windows.Forms.Button();
            this.InventoryListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddGuitarBtn
            // 
            this.AddGuitarBtn.Location = new System.Drawing.Point(491, 70);
            this.AddGuitarBtn.Name = "AddGuitarBtn";
            this.AddGuitarBtn.Size = new System.Drawing.Size(75, 73);
            this.AddGuitarBtn.TabIndex = 0;
            this.AddGuitarBtn.Text = "Add Guitar";
            this.AddGuitarBtn.UseVisualStyleBackColor = true;
            this.AddGuitarBtn.Click += new System.EventHandler(this.AddGuitarBtn_Click);
            // 
            // UpdateGuitarBtn
            // 
            this.UpdateGuitarBtn.Location = new System.Drawing.Point(491, 173);
            this.UpdateGuitarBtn.Name = "UpdateGuitarBtn";
            this.UpdateGuitarBtn.Size = new System.Drawing.Size(75, 75);
            this.UpdateGuitarBtn.TabIndex = 1;
            this.UpdateGuitarBtn.Text = "Update Guitar";
            this.UpdateGuitarBtn.UseVisualStyleBackColor = true;
            this.UpdateGuitarBtn.Click += new System.EventHandler(this.UpdateGuitarBtn_Click);
            // 
            // DeleteGuitarBtn
            // 
            this.DeleteGuitarBtn.Location = new System.Drawing.Point(491, 286);
            this.DeleteGuitarBtn.Name = "DeleteGuitarBtn";
            this.DeleteGuitarBtn.Size = new System.Drawing.Size(75, 74);
            this.DeleteGuitarBtn.TabIndex = 2;
            this.DeleteGuitarBtn.Text = "Delete Guitar";
            this.DeleteGuitarBtn.UseVisualStyleBackColor = true;
            this.DeleteGuitarBtn.Click += new System.EventHandler(this.DeleteGuitarBtn_Click);
            // 
            // InventoryListBox
            // 
            this.InventoryListBox.FormattingEnabled = true;
            this.InventoryListBox.Location = new System.Drawing.Point(217, 70);
            this.InventoryListBox.Name = "InventoryListBox";
            this.InventoryListBox.Size = new System.Drawing.Size(225, 290);
            this.InventoryListBox.TabIndex = 3;
            this.InventoryListBox.SelectedIndexChanged += new System.EventHandler(this.InventoryListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InventoryListBox);
            this.Controls.Add(this.DeleteGuitarBtn);
            this.Controls.Add(this.UpdateGuitarBtn);
            this.Controls.Add(this.AddGuitarBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddGuitarBtn;
        private System.Windows.Forms.Button UpdateGuitarBtn;
        private System.Windows.Forms.Button DeleteGuitarBtn;
        private System.Windows.Forms.ListBox InventoryListBox;
    }
}

