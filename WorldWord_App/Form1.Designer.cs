
namespace WorldWord_App
{
    partial class WorldWord
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
            this.btn_AllWord = new System.Windows.Forms.Button();
            this.btn_wordslearned = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVlastW = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVlastW)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AllWord
            // 
            this.btn_AllWord.Location = new System.Drawing.Point(46, 49);
            this.btn_AllWord.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AllWord.Name = "btn_AllWord";
            this.btn_AllWord.Size = new System.Drawing.Size(208, 90);
            this.btn_AllWord.TabIndex = 0;
            this.btn_AllWord.Text = "All Words";
            this.btn_AllWord.UseVisualStyleBackColor = true;
            this.btn_AllWord.Click += new System.EventHandler(this.btn_AllWord_Click);
            // 
            // btn_wordslearned
            // 
            this.btn_wordslearned.Location = new System.Drawing.Point(46, 168);
            this.btn_wordslearned.Margin = new System.Windows.Forms.Padding(4);
            this.btn_wordslearned.Name = "btn_wordslearned";
            this.btn_wordslearned.Size = new System.Drawing.Size(208, 90);
            this.btn_wordslearned.TabIndex = 1;
            this.btn_wordslearned.Text = "All the words I learned";
            this.btn_wordslearned.UseVisualStyleBackColor = true;
            this.btn_wordslearned.Click += new System.EventHandler(this.btn_wordslearned_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVlastW);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(277, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 432);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // DGVlastW
            // 
            this.DGVlastW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVlastW.Location = new System.Drawing.Point(6, 50);
            this.DGVlastW.Name = "DGVlastW";
            this.DGVlastW.RowHeadersWidth = 51;
            this.DGVlastW.RowTemplate.Height = 24;
            this.DGVlastW.Size = new System.Drawing.Size(462, 376);
            this.DGVlastW.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last words added";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(46, 285);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(208, 90);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // WorldWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 456);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_wordslearned);
            this.Controls.Add(this.btn_AllWord);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorldWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorldWord";
            this.Load += new System.EventHandler(this.WorldWord_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVlastW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AllWord;
        private System.Windows.Forms.Button btn_wordslearned;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVlastW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Exit;
    }
}

