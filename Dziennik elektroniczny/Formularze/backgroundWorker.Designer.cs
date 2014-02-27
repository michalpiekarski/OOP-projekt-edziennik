namespace Dziennik_elektroniczny.Formularze
{
    partial class backgroundWorker
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
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bw
            // 
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DoSomeWork);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WorkCompleted);
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(99, 214);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(232, 23);
            this.pb.TabIndex = 0;
            this.pb.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(222, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 84);
            this.button1.TabIndex = 1;
            this.button1.Text = "Do some background work";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RunBW);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(12, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 84);
            this.button2.TabIndex = 2;
            this.button2.Text = "Do some work";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RunTask);
            // 
            // backgroundWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 375);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb);
            this.Name = "backgroundWorker";
            this.Text = "backgroundWorker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}