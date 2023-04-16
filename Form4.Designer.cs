namespace forms_hw_2
{
    partial class Form4
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
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_1 = new System.Windows.Forms.NumericUpDown();
            this.exit = new System.Windows.Forms.Button();
            this.countdown = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.timer_1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_start.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(48, 225);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(142, 84);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.BackColor = System.Drawing.Color.Aquamarine;
            this.button_stop.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stop.Location = new System.Drawing.Point(257, 225);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(146, 84);
            this.button_stop.TabIndex = 4;
            this.button_stop.Text = "STOP";
            this.button_stop.UseVisualStyleBackColor = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "seconds";
            // 
            // timer_1
            // 
            this.timer_1.Location = new System.Drawing.Point(248, 85);
            this.timer_1.Name = "timer_1";
            this.timer_1.Size = new System.Drawing.Size(120, 26);
            this.timer_1.TabIndex = 6;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Bisque;
            this.exit.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(461, 225);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(142, 84);
            this.exit.TabIndex = 7;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // countdown
            // 
            this.countdown.BackColor = System.Drawing.Color.Plum;
            this.countdown.Location = new System.Drawing.Point(457, 73);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(112, 57);
            this.countdown.TabIndex = 8;
            this.countdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.timer_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.timer_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown timer_1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Timer timer2;
    }
}