
namespace FileManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sourceText = new System.Windows.Forms.TextBox();
            this.buttonMove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonsource = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.targetText = new System.Windows.Forms.TextBox();
            this.buttontarget = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rename = new System.Windows.Forms.RadioButton();
            this.uzerineyaz = new System.Windows.Forms.RadioButton();
            this.zipLevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.subdirectorieszipped = new System.Windows.Forms.CheckBox();
            this.changeSave = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // sourceText
            // 
            this.sourceText.Location = new System.Drawing.Point(16, 75);
            this.sourceText.Name = "sourceText";
            this.sourceText.Size = new System.Drawing.Size(277, 20);
            this.sourceText.TabIndex = 0;
            // 
            // buttonMove
            // 
            this.buttonMove.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMove.Location = new System.Drawing.Point(188, 244);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(105, 39);
            this.buttonMove.TabIndex = 2;
            this.buttonMove.Text = "Çevir ve Taşı";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kaynak Dosyası Seçiniz";
            // 
            // buttonsource
            // 
            this.buttonsource.Location = new System.Drawing.Point(253, 46);
            this.buttonsource.Name = "buttonsource";
            this.buttonsource.Size = new System.Drawing.Size(36, 23);
            this.buttonsource.TabIndex = 5;
            this.buttonsource.Text = "...";
            this.buttonsource.UseVisualStyleBackColor = true;
            this.buttonsource.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "File to Zip Converter";
            // 
            // targetText
            // 
            this.targetText.Location = new System.Drawing.Point(16, 135);
            this.targetText.Name = "targetText";
            this.targetText.Size = new System.Drawing.Size(277, 20);
            this.targetText.TabIndex = 8;
            // 
            // buttontarget
            // 
            this.buttontarget.Location = new System.Drawing.Point(253, 106);
            this.buttontarget.Name = "buttontarget";
            this.buttontarget.Size = new System.Drawing.Size(36, 23);
            this.buttontarget.TabIndex = 10;
            this.buttontarget.Text = "...";
            this.buttontarget.UseVisualStyleBackColor = true;
            this.buttontarget.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hedef Dosyası Seçiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hedefte aynı dosya varsa ?";
            // 
            // rename
            // 
            this.rename.AutoSize = true;
            this.rename.Location = new System.Drawing.Point(16, 216);
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(105, 17);
            this.rename.TabIndex = 15;
            this.rename.Text = "Yeniden Adlandır";
            this.rename.UseVisualStyleBackColor = true;
            // 
            // uzerineyaz
            // 
            this.uzerineyaz.AutoSize = true;
            this.uzerineyaz.Checked = true;
            this.uzerineyaz.Location = new System.Drawing.Point(16, 192);
            this.uzerineyaz.Name = "uzerineyaz";
            this.uzerineyaz.Size = new System.Drawing.Size(80, 17);
            this.uzerineyaz.TabIndex = 16;
            this.uzerineyaz.TabStop = true;
            this.uzerineyaz.Text = "Üzerine yaz";
            this.uzerineyaz.UseVisualStyleBackColor = true;
            // 
            // zipLevel
            // 
            this.zipLevel.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3"});
            this.zipLevel.Cursor = System.Windows.Forms.Cursors.Default;
            this.zipLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zipLevel.FormattingEnabled = true;
            this.zipLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.zipLevel.Items.AddRange(new object[] {
            "Normal",
            "Sıkıştır",
            "Sıkıştırma"});
            this.zipLevel.Location = new System.Drawing.Point(16, 262);
            this.zipLevel.Name = "zipLevel";
            this.zipLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.zipLevel.Size = new System.Drawing.Size(104, 21);
            this.zipLevel.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sıkıştırılma düzeyi";
            // 
            // subdirectorieszipped
            // 
            this.subdirectorieszipped.AutoSize = true;
            this.subdirectorieszipped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subdirectorieszipped.Location = new System.Drawing.Point(163, 192);
            this.subdirectorieszipped.Name = "subdirectorieszipped";
            this.subdirectorieszipped.Size = new System.Drawing.Size(130, 19);
            this.subdirectorieszipped.TabIndex = 20;
            this.subdirectorieszipped.Text = "Alt Dizinler de ziple";
            this.subdirectorieszipped.UseVisualStyleBackColor = true;
            // 
            // changeSave
            // 
            this.changeSave.AutoSize = true;
            this.changeSave.Location = new System.Drawing.Point(163, 216);
            this.changeSave.Name = "changeSave";
            this.changeSave.Size = new System.Drawing.Size(103, 17);
            this.changeSave.TabIndex = 21;
            this.changeSave.Text = "Değerleri kaydet";
            this.changeSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(309, 291);
            this.Controls.Add(this.changeSave);
            this.Controls.Add(this.subdirectorieszipped);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zipLevel);
            this.Controls.Add(this.uzerineyaz);
            this.Controls.Add(this.rename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttontarget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.targetText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonsource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.sourceText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File to Zip Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourceText;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonsource;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox targetText;
        private System.Windows.Forms.Button buttontarget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rename;
        private System.Windows.Forms.RadioButton uzerineyaz;
        private System.Windows.Forms.ComboBox zipLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox subdirectorieszipped;
        private System.Windows.Forms.CheckBox changeSave;
    }
}

