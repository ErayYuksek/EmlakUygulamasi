namespace Emlak_Uygulaması_Proje
{
    partial class KonutResimleri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KonutResimleri));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnArnova = new System.Windows.Forms.Button();
            this.btnTime = new System.Windows.Forms.Button();
            this.btnCold = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnArnova
            // 
            this.btnArnova.BackColor = System.Drawing.Color.LightGray;
            this.btnArnova.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnArnova.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArnova.Location = new System.Drawing.Point(132, 45);
            this.btnArnova.Name = "btnArnova";
            this.btnArnova.Size = new System.Drawing.Size(323, 85);
            this.btnArnova.TabIndex = 0;
            this.btnArnova.Text = "Arnova";
            this.btnArnova.UseVisualStyleBackColor = false;
            this.btnArnova.Click += new System.EventHandler(this.btnArnova_Click);
            // 
            // btnTime
            // 
            this.btnTime.BackColor = System.Drawing.Color.LightGray;
            this.btnTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTime.Location = new System.Drawing.Point(132, 154);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(323, 85);
            this.btnTime.TabIndex = 1;
            this.btnTime.Text = "Time";
            this.btnTime.UseVisualStyleBackColor = false;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // btnCold
            // 
            this.btnCold.BackColor = System.Drawing.Color.LightGray;
            this.btnCold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnCold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCold.Location = new System.Drawing.Point(132, 268);
            this.btnCold.Name = "btnCold";
            this.btnCold.Size = new System.Drawing.Size(323, 85);
            this.btnCold.TabIndex = 2;
            this.btnCold.Text = "Cold";
            this.btnCold.UseVisualStyleBackColor = false;
            this.btnCold.Click += new System.EventHandler(this.btnCold_Click);
            // 
            // KonutResimleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(609, 425);
            this.Controls.Add(this.btnCold);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.btnArnova);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KonutResimleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KonutResimleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnArnova;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button btnCold;
    }
}