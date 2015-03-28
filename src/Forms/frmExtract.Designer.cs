namespace BIN_Editor.Forms
{
    partial class frmExtract
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
            this.lv_tasks = new System.Windows.Forms.ListView();
            this.pgb_current = new System.Windows.Forms.ProgressBar();
            this.pgb_all = new System.Windows.Forms.ProgressBar();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_tasks
            // 
            this.lv_tasks.Location = new System.Drawing.Point(12, 12);
            this.lv_tasks.Name = "lv_tasks";
            this.lv_tasks.Size = new System.Drawing.Size(593, 204);
            this.lv_tasks.TabIndex = 0;
            this.lv_tasks.UseCompatibleStateImageBehavior = false;
            // 
            // pgb_current
            // 
            this.pgb_current.Location = new System.Drawing.Point(12, 222);
            this.pgb_current.Name = "pgb_current";
            this.pgb_current.Size = new System.Drawing.Size(593, 23);
            this.pgb_current.TabIndex = 1;
            // 
            // pgb_all
            // 
            this.pgb_all.Location = new System.Drawing.Point(12, 251);
            this.pgb_all.Name = "pgb_all";
            this.pgb_all.Size = new System.Drawing.Size(593, 23);
            this.pgb_all.TabIndex = 2;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(530, 280);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(449, 280);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // frmExtract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 315);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.pgb_all);
            this.Controls.Add(this.pgb_current);
            this.Controls.Add(this.lv_tasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExtract";
            this.Text = "Extracting ...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_tasks;
        private System.Windows.Forms.ProgressBar pgb_current;
        private System.Windows.Forms.ProgressBar pgb_all;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
    }
}