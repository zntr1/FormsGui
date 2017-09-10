namespace FormsGui
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.panel_left = new System.Windows.Forms.Panel();
            this.button_user = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel_header = new System.Windows.Forms.Panel();
            this.button_search = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.panel_left.Controls.Add(this.button_search);
            this.panel_left.Controls.Add(this.button_user);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(108, 422);
            this.panel_left.TabIndex = 0;
            // 
            // button_user
            // 
            this.button_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.button_user.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.button_user.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_user.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_user.ForeColor = System.Drawing.Color.White;
            this.button_user.Image = ((System.Drawing.Image)(resources.GetObject("button_user.Image")));
            this.button_user.ImagePosition = 15;
            this.button_user.ImageZoom = 50;
            this.button_user.LabelPosition = 26;
            this.button_user.LabelText = "Tile 1";
            this.button_user.Location = new System.Drawing.Point(0, 81);
            this.button_user.Margin = new System.Windows.Forms.Padding(5);
            this.button_user.Name = "button_user";
            this.button_user.Size = new System.Drawing.Size(108, 84);
            this.button_user.TabIndex = 2;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(108, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(599, 73);
            this.panel_header.TabIndex = 1;
            this.panel_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseDown);
            this.panel_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel_header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseUp);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.button_search.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.button_search.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Image = ((System.Drawing.Image)(resources.GetObject("button_search.Image")));
            this.button_search.ImagePosition = 15;
            this.button_search.ImageZoom = 40;
            this.button_search.LabelPosition = 26;
            this.button_search.LabelText = "Tile 1";
            this.button_search.Location = new System.Drawing.Point(0, 157);
            this.button_search.Margin = new System.Windows.Forms.Padding(5);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(108, 84);
            this.button_search.TabIndex = 3;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 422);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainform";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.main_MouseUp);
            this.panel_left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_header;
        private Bunifu.Framework.UI.BunifuTileButton button_user;
        private Bunifu.Framework.UI.BunifuTileButton button_search;
    }
}

