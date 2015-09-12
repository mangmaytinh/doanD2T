namespace WindowsApplication
{
    partial class Form1
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
            this.p = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbn = new System.Windows.Forms.Label();
            this.lbnt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(7, 52);
            this.p.Maximum = 60000;
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(655, 10);
            this.p.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbn
            // 
            this.lbn.AutoSize = true;
            this.lbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn.Location = new System.Drawing.Point(52, 110);
            this.lbn.Name = "lbn";
            this.lbn.Size = new System.Drawing.Size(93, 33);
            this.lbn.TabIndex = 1;
            this.lbn.Text = "label1";
            // 
            // lbnt
            // 
            this.lbnt.AutoSize = true;
            this.lbnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnt.Location = new System.Drawing.Point(52, 165);
            this.lbnt.Name = "lbnt";
            this.lbnt.Size = new System.Drawing.Size(93, 33);
            this.lbnt.TabIndex = 2;
            this.lbnt.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 236);
            this.Controls.Add(this.lbnt);
            this.Controls.Add(this.lbn);
            this.Controls.Add(this.p);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar p;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbn;
        private System.Windows.Forms.Label lbnt;
    }
}

