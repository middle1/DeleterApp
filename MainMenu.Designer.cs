
namespace DeleterApp
{
    partial class MainMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseForm = new System.Windows.Forms.Label();
            this.MinimizeForm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ClearAllButton = new System.Windows.Forms.Label();
            this.ClearAllDefault = new System.Windows.Forms.Label();
            this.ClearAllFull = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LoadingGif = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(488, 31);
            this.panel1.MaximumSize = new System.Drawing.Size(373, 224);
            this.panel1.MinimumSize = new System.Drawing.Size(373, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 224);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panel1.DragLeave += new System.EventHandler(this.panel1_DragLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(88, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перетащите файл сюда";
            // 
            // CloseForm
            // 
            this.CloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseForm.AutoSize = true;
            this.CloseForm.BackColor = System.Drawing.Color.Transparent;
            this.CloseForm.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CloseForm.Location = new System.Drawing.Point(860, 2);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(22, 26);
            this.CloseForm.TabIndex = 1;
            this.CloseForm.Text = "X";
            this.CloseForm.Click += new System.EventHandler(this.Close_Click);
            this.CloseForm.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.CloseForm.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // MinimizeForm
            // 
            this.MinimizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeForm.AutoSize = true;
            this.MinimizeForm.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeForm.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizeForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MinimizeForm.Location = new System.Drawing.Point(836, 3);
            this.MinimizeForm.Name = "MinimizeForm";
            this.MinimizeForm.Size = new System.Drawing.Size(19, 26);
            this.MinimizeForm.TabIndex = 2;
            this.MinimizeForm.Text = "-";
            this.MinimizeForm.Click += new System.EventHandler(this.Minimize_Click);
            this.MinimizeForm.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.MinimizeForm.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(2, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(483, 519);
            this.label3.TabIndex = 4;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Impact", 11.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(756, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "1";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(486, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "1";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Impact", 11.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(487, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "1";
            this.label6.Visible = false;
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearAllButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClearAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAllButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClearAllButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ClearAllButton.Location = new System.Drawing.Point(781, 531);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(101, 50);
            this.ClearAllButton.TabIndex = 5;
            this.ClearAllButton.Text = "Очистить список";
            this.ClearAllButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClearAllButton.Visible = false;
            this.ClearAllButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearAllDefault
            // 
            this.ClearAllDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearAllDefault.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClearAllDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearAllDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAllDefault.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClearAllDefault.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ClearAllDefault.Location = new System.Drawing.Point(485, 460);
            this.ClearAllDefault.Name = "ClearAllDefault";
            this.ClearAllDefault.Size = new System.Drawing.Size(116, 51);
            this.ClearAllDefault.TabIndex = 5;
            this.ClearAllDefault.Text = "Очистить стандартно";
            this.ClearAllDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClearAllDefault.Visible = false;
            this.ClearAllDefault.Click += new System.EventHandler(this.ClearAllDefault_Click);
            // 
            // ClearAllFull
            // 
            this.ClearAllFull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearAllFull.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClearAllFull.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearAllFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAllFull.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClearAllFull.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClearAllFull.Location = new System.Drawing.Point(617, 460);
            this.ClearAllFull.Name = "ClearAllFull";
            this.ClearAllFull.Size = new System.Drawing.Size(116, 51);
            this.ClearAllFull.TabIndex = 5;
            this.ClearAllFull.Text = "Очистить полностью";
            this.ClearAllFull.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClearAllFull.Visible = false;
            this.ClearAllFull.Click += new System.EventHandler(this.ClearAllFull_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.progressBar1.ForeColor = System.Drawing.Color.Maroon;
            this.progressBar1.Location = new System.Drawing.Point(66, 542);
            this.progressBar1.MarqueeAnimationSpeed = 1000;
            this.progressBar1.Maximum = 20;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(419, 43);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Visible = false;
            // 
            // LoadingGif
            // 
            this.LoadingGif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadingGif.Image = global::DeleterApp.Properties.Resources.Loading;
            this.LoadingGif.Location = new System.Drawing.Point(10, 531);
            this.LoadingGif.MaximumSize = new System.Drawing.Size(50, 50);
            this.LoadingGif.MinimumSize = new System.Drawing.Size(50, 50);
            this.LoadingGif.Name = "LoadingGif";
            this.LoadingGif.Size = new System.Drawing.Size(50, 50);
            this.LoadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingGif.TabIndex = 6;
            this.LoadingGif.TabStop = false;
            this.LoadingGif.UseWaitCursor = true;
            this.LoadingGif.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(890, 590);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LoadingGif);
            this.Controls.Add(this.ClearAllFull);
            this.Controls.Add(this.ClearAllDefault);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MinimizeForm);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(426, 315);
            this.Name = "MainMenu";
            this.Opacity = 0.99D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CloseForm;
        private System.Windows.Forms.Label MinimizeForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ClearAllButton;
        private System.Windows.Forms.PictureBox LoadingGif;
        private System.Windows.Forms.Label ClearAllDefault;
        private System.Windows.Forms.Label ClearAllFull;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

