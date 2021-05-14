
namespace Lab__05
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ltbx1min = new System.Windows.Forms.Label();
            this.ltbx2min = new System.Windows.Forms.Label();
            this.ltbx1max = new System.Windows.Forms.Label();
            this.ltbx2max = new System.Windows.Forms.Label();
            this.ltbdx1 = new System.Windows.Forms.Label();
            this.ltbdx2 = new System.Windows.Forms.Label();
            this.tbx1min = new System.Windows.Forms.TextBox();
            this.tbx1max = new System.Windows.Forms.TextBox();
            this.tbx2max = new System.Windows.Forms.TextBox();
            this.tbx2min = new System.Windows.Forms.TextBox();
            this.tbdx2 = new System.Windows.Forms.TextBox();
            this.tbdx1 = new System.Windows.Forms.TextBox();
            this.gv = new System.Windows.Forms.DataGridView();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // ltbx1min
            // 
            this.ltbx1min.AutoSize = true;
            this.ltbx1min.Location = new System.Drawing.Point(21, 37);
            this.ltbx1min.Name = "ltbx1min";
            this.ltbx1min.Size = new System.Drawing.Size(82, 32);
            this.ltbx1min.TabIndex = 0;
            this.ltbx1min.Text = "X1min";
            this.ltbx1min.Click += new System.EventHandler(this.label1_Click);
            // 
            // ltbx2min
            // 
            this.ltbx2min.AutoSize = true;
            this.ltbx2min.Location = new System.Drawing.Point(21, 97);
            this.ltbx2min.Name = "ltbx2min";
            this.ltbx2min.Size = new System.Drawing.Size(82, 32);
            this.ltbx2min.TabIndex = 1;
            this.ltbx2min.Text = "X2min";
            // 
            // ltbx1max
            // 
            this.ltbx1max.AutoSize = true;
            this.ltbx1max.Location = new System.Drawing.Point(316, 37);
            this.ltbx1max.Name = "ltbx1max";
            this.ltbx1max.Size = new System.Drawing.Size(85, 32);
            this.ltbx1max.TabIndex = 2;
            this.ltbx1max.Text = "X1max";
            // 
            // ltbx2max
            // 
            this.ltbx2max.AutoSize = true;
            this.ltbx2max.Location = new System.Drawing.Point(316, 97);
            this.ltbx2max.Name = "ltbx2max";
            this.ltbx2max.Size = new System.Drawing.Size(82, 38);
            this.ltbx2max.TabIndex = 5;
            this.ltbx2max.Text = "X2max";
            this.ltbx2max.UseCompatibleTextRendering = true;
            // 
            // ltbdx1
            // 
            this.ltbdx1.AutoSize = true;
            this.ltbdx1.Location = new System.Drawing.Point(637, 30);
            this.ltbdx1.Name = "ltbdx1";
            this.ltbdx1.Size = new System.Drawing.Size(55, 32);
            this.ltbdx1.TabIndex = 4;
            this.ltbdx1.Text = "dX1";
            this.ltbdx1.Click += new System.EventHandler(this.tbx5min_Click);
            // 
            // ltbdx2
            // 
            this.ltbdx2.AutoSize = true;
            this.ltbdx2.Location = new System.Drawing.Point(637, 104);
            this.ltbdx2.Name = "ltbdx2";
            this.ltbdx2.Size = new System.Drawing.Size(55, 32);
            this.ltbdx2.TabIndex = 3;
            this.ltbdx2.Text = "dX2";
            // 
            // tbx1min
            // 
            this.tbx1min.Location = new System.Drawing.Point(109, 37);
            this.tbx1min.Name = "tbx1min";
            this.tbx1min.Size = new System.Drawing.Size(129, 39);
            this.tbx1min.TabIndex = 6;
            this.tbx1min.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbx1max
            // 
            this.tbx1max.Location = new System.Drawing.Point(407, 30);
            this.tbx1max.Name = "tbx1max";
            this.tbx1max.Size = new System.Drawing.Size(146, 39);
            this.tbx1max.TabIndex = 7;
            // 
            // tbx2max
            // 
            this.tbx2max.Location = new System.Drawing.Point(407, 97);
            this.tbx2max.Name = "tbx2max";
            this.tbx2max.Size = new System.Drawing.Size(146, 39);
            this.tbx2max.TabIndex = 9;
            // 
            // tbx2min
            // 
            this.tbx2min.Location = new System.Drawing.Point(109, 97);
            this.tbx2min.Name = "tbx2min";
            this.tbx2min.Size = new System.Drawing.Size(129, 39);
            this.tbx2min.TabIndex = 8;
            // 
            // tbdx2
            // 
            this.tbdx2.Location = new System.Drawing.Point(698, 94);
            this.tbdx2.Name = "tbdx2";
            this.tbdx2.Size = new System.Drawing.Size(134, 39);
            this.tbdx2.TabIndex = 11;
            // 
            // tbdx1
            // 
            this.tbdx1.Location = new System.Drawing.Point(698, 27);
            this.tbdx1.Name = "tbdx1";
            this.tbdx1.Size = new System.Drawing.Size(134, 39);
            this.tbdx1.TabIndex = 10;
            // 
            // gv
            // 
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(21, 185);
            this.gv.Name = "gv";
            this.gv.RowHeadersWidth = 82;
            this.gv.RowTemplate.Height = 41;
            this.gv.Size = new System.Drawing.Size(964, 333);
            this.gv.TabIndex = 12;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCalc.Location = new System.Drawing.Point(1014, 188);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(176, 46);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "Розрахувати";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1014, 270);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(176, 46);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Location = new System.Drawing.Point(1014, 475);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 46);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Вийти";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 909);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.tbdx2);
            this.Controls.Add(this.tbdx1);
            this.Controls.Add(this.tbx2max);
            this.Controls.Add(this.tbx2min);
            this.Controls.Add(this.tbx1max);
            this.Controls.Add(this.tbx1min);
            this.Controls.Add(this.ltbx2max);
            this.Controls.Add(this.ltbdx1);
            this.Controls.Add(this.ltbdx2);
            this.Controls.Add(this.ltbx1max);
            this.Controls.Add(this.ltbx2min);
            this.Controls.Add(this.ltbx1min);
            this.Name = "fMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ltbx1min;
        private System.Windows.Forms.Label ltbx2min;
        private System.Windows.Forms.Label ltbx1max;
        private System.Windows.Forms.Label ltbx2max;
        private System.Windows.Forms.Label ltbdx1;
        private System.Windows.Forms.Label ltbdx2;
        private System.Windows.Forms.TextBox tbx1min;
        private System.Windows.Forms.TextBox tbx1max;
        private System.Windows.Forms.TextBox tbx2max;
        private System.Windows.Forms.TextBox tbx2min;
        private System.Windows.Forms.TextBox tbdx2;
        private System.Windows.Forms.TextBox tbdx1;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

