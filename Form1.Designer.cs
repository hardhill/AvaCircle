namespace Avacircle
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlConrol = new System.Windows.Forms.Panel();
            this.bSave = new System.Windows.Forms.Button();
            this.trbPicsize = new System.Windows.Forms.TrackBar();
            this.bLoad = new System.Windows.Forms.Button();
            this.dlgOpenPisture = new System.Windows.Forms.OpenFileDialog();
            this.stbMain = new System.Windows.Forms.StatusStrip();
            this.toolImageInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.dlgSavePicture = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.trbQuality = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlConrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbPicsize)).BeginInit();
            this.stbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // pnlConrol
            // 
            this.pnlConrol.Controls.Add(this.label2);
            this.pnlConrol.Controls.Add(this.trbQuality);
            this.pnlConrol.Controls.Add(this.label1);
            this.pnlConrol.Controls.Add(this.bSave);
            this.pnlConrol.Controls.Add(this.trbPicsize);
            this.pnlConrol.Controls.Add(this.bLoad);
            this.pnlConrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConrol.Location = new System.Drawing.Point(0, 0);
            this.pnlConrol.Name = "pnlConrol";
            this.pnlConrol.Size = new System.Drawing.Size(878, 68);
            this.pnlConrol.TabIndex = 0;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(12, 39);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 2;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // trbPicsize
            // 
            this.trbPicsize.AutoSize = false;
            this.trbPicsize.Location = new System.Drawing.Point(93, 39);
            this.trbPicsize.Maximum = 200;
            this.trbPicsize.Name = "trbPicsize";
            this.trbPicsize.Size = new System.Drawing.Size(315, 23);
            this.trbPicsize.TabIndex = 1;
            this.trbPicsize.Value = 100;
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(12, 12);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(75, 23);
            this.bLoad.TabIndex = 0;
            this.bLoad.Text = "Загрузить";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // dlgOpenPisture
            // 
            this.dlgOpenPisture.Filter = "JPG file|*.jpg;*.jpeg";
            this.dlgOpenPisture.Title = "Select JPG file";
            // 
            // stbMain
            // 
            this.stbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolImageInfo});
            this.stbMain.Location = new System.Drawing.Point(0, 474);
            this.stbMain.Name = "stbMain";
            this.stbMain.Size = new System.Drawing.Size(878, 22);
            this.stbMain.TabIndex = 1;
            // 
            // toolImageInfo
            // 
            this.toolImageInfo.Name = "toolImageInfo";
            this.toolImageInfo.Size = new System.Drawing.Size(118, 17);
            this.toolImageInfo.Text = "toolStripStatusLabel1";
            // 
            // dlgSavePicture
            // 
            this.dlgSavePicture.Filter = "File PNG (*.png)|*.png|File JPG (*.jpg)|*.jpg";
            this.dlgSavePicture.Title = "Сохранить фото как...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Масштаб";
            // 
            // trbQuality
            // 
            this.trbQuality.AutoSize = false;
            this.trbQuality.Location = new System.Drawing.Point(734, 39);
            this.trbQuality.Maximum = 100;
            this.trbQuality.Minimum = 5;
            this.trbQuality.Name = "trbQuality";
            this.trbQuality.Size = new System.Drawing.Size(132, 18);
            this.trbQuality.SmallChange = 5;
            this.trbQuality.TabIndex = 4;
            this.trbQuality.TickFrequency = 5;
            this.trbQuality.Value = 90;
            this.trbQuality.Scroll += new System.EventHandler(this.trbQuality_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Качество";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 496);
            this.Controls.Add(this.stbMain);
            this.Controls.Add(this.pnlConrol);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AvaCircle";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlConrol.ResumeLayout(false);
            this.pnlConrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbPicsize)).EndInit();
            this.stbMain.ResumeLayout(false);
            this.stbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbQuality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlConrol;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.TrackBar trbPicsize;
        private System.Windows.Forms.OpenFileDialog dlgOpenPisture;
        private System.Windows.Forms.StatusStrip stbMain;
        private System.Windows.Forms.ToolStripStatusLabel toolImageInfo;
        private System.Windows.Forms.SaveFileDialog dlgSavePicture;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trbQuality;
        private System.Windows.Forms.Label label1;
    }
}

