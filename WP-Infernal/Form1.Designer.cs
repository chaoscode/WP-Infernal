
namespace WP_Infernal
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
            this.MainView = new System.Windows.Forms.TreeView();
            this.WebsiteBox = new System.Windows.Forms.TextBox();
            this.getAPI = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabwpInfo1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabwpInfo1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainView
            // 
            this.MainView.Location = new System.Drawing.Point(7, 8);
            this.MainView.Margin = new System.Windows.Forms.Padding(2);
            this.MainView.Name = "MainView";
            this.MainView.Size = new System.Drawing.Size(314, 609);
            this.MainView.TabIndex = 0;
            // 
            // WebsiteBox
            // 
            this.WebsiteBox.Location = new System.Drawing.Point(7, 619);
            this.WebsiteBox.Margin = new System.Windows.Forms.Padding(2);
            this.WebsiteBox.Name = "WebsiteBox";
            this.WebsiteBox.Size = new System.Drawing.Size(314, 26);
            this.WebsiteBox.TabIndex = 1;
            this.WebsiteBox.Text = "https://wpengine.com/";
            // 
            // getAPI
            // 
            this.getAPI.Location = new System.Drawing.Point(7, 649);
            this.getAPI.Margin = new System.Windows.Forms.Padding(2);
            this.getAPI.Name = "getAPI";
            this.getAPI.Size = new System.Drawing.Size(120, 39);
            this.getAPI.TabIndex = 2;
            this.getAPI.Text = "Get API";
            this.getAPI.UseVisualStyleBackColor = true;
            this.getAPI.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabwpInfo1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(365, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1091, 637);
            this.tabControl1.TabIndex = 5;
            // 
            // tabwpInfo1
            // 
            this.tabwpInfo1.Controls.Add(this.nameLabel);
            this.tabwpInfo1.Controls.Add(this.homeLabel);
            this.tabwpInfo1.Controls.Add(this.descriptionLabel);
            this.tabwpInfo1.Location = new System.Drawing.Point(4, 29);
            this.tabwpInfo1.Name = "tabwpInfo1";
            this.tabwpInfo1.Padding = new System.Windows.Forms.Padding(3);
            this.tabwpInfo1.Size = new System.Drawing.Size(1083, 604);
            this.tabwpInfo1.TabIndex = 0;
            this.tabwpInfo1.Text = "WordPress Information";
            this.tabwpInfo1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1083, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(10, 101);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description";
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Location = new System.Drawing.Point(10, 53);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(85, 20);
            this.homeLabel.TabIndex = 5;
            this.homeLabel.Text = "HomeURL";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(14, 7);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 695);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.getAPI);
            this.Controls.Add(this.WebsiteBox);
            this.Controls.Add(this.MainView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "WP-Infernal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabwpInfo1.ResumeLayout(false);
            this.tabwpInfo1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView MainView;
        private System.Windows.Forms.TextBox WebsiteBox;
        private System.Windows.Forms.Button getAPI;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabwpInfo1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}

