
namespace WorldWord_App.Forms
{
    partial class AddorEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddorEdit));
            this.label1 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTranslation = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Word : ";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(158, 27);
            this.txtWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(250, 28);
            this.txtWord.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Translation : ";
            // 
            // txtTranslation
            // 
            this.txtTranslation.Location = new System.Drawing.Point(158, 94);
            this.txtTranslation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTranslation.Name = "txtTranslation";
            this.txtTranslation.Size = new System.Drawing.Size(250, 28);
            this.txtTranslation.TabIndex = 4;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(30, 145);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(378, 36);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Add";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtWord;
            this.requiredFieldValidator1.ErrorMessage = "please Entert a Word!";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtTranslation;
            this.requiredFieldValidator2.ErrorMessage = "please Entert a Translation!";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // AddorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 193);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTranslation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWord);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddorEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.AddorEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTranslation;
        private System.Windows.Forms.Button btn_save;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
    }
}