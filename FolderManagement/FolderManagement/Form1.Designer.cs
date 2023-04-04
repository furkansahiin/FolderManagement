
namespace FolderManagement
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
            this.buttonsource = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sourceText = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.changeSave = new System.Windows.Forms.CheckBox();
            this.subdirectorieszipped = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.zipLevel = new System.Windows.Forms.ComboBox();
            this.uzerineyaz = new System.Windows.Forms.RadioButton();
            this.rename = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.buttontarget = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.targetText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonsource
            // 
            this.buttonsource.Location = new System.Drawing.Point(253, 63);
            this.buttonsource.Name = "buttonsource";
            this.buttonsource.Size = new System.Drawing.Size(36, 23);
            this.buttonsource.TabIndex = 25;
            this.buttonsource.Text = "...";
            this.buttonsource.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Kaynak Klasörü Seçiniz";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(188, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 23;
            this.button1.Text = "Çevir ve Taşı";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sourceText
            // 
            this.sourceText.Location = new System.Drawing.Point(16, 92);
            this.sourceText.Name = "sourceText";
            this.sourceText.Size = new System.Drawing.Size(277, 20);
            this.sourceText.TabIndex = 22;
            // 
            // changeSave
            // 
            this.changeSave.AutoSize = true;
            this.changeSave.Location = new System.Drawing.Point(60, 266);
            this.changeSave.Name = "changeSave";
            this.changeSave.Size = new System.Drawing.Size(164, 17);
            this.changeSave.TabIndex = 36;
            this.changeSave.Text = "Değerleri app.config\'e kaydet";
            this.changeSave.UseVisualStyleBackColor = true;
            // 
            // subdirectorieszipped
            // 
            this.subdirectorieszipped.AutoSize = true;
            this.subdirectorieszipped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subdirectorieszipped.Location = new System.Drawing.Point(60, 241);
            this.subdirectorieszipped.Name = "subdirectorieszipped";
            this.subdirectorieszipped.Size = new System.Drawing.Size(130, 19);
            this.subdirectorieszipped.TabIndex = 35;
            this.subdirectorieszipped.Text = "Alt Dizinler de ziple";
            this.subdirectorieszipped.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Sıkıştırılma düzeyi";
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
            this.zipLevel.Location = new System.Drawing.Point(18, 324);
            this.zipLevel.Name = "zipLevel";
            this.zipLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.zipLevel.Size = new System.Drawing.Size(104, 21);
            this.zipLevel.TabIndex = 33;
            // 
            // uzerineyaz
            // 
            this.uzerineyaz.AutoSize = true;
            this.uzerineyaz.Checked = true;
            this.uzerineyaz.Location = new System.Drawing.Point(36, 209);
            this.uzerineyaz.Name = "uzerineyaz";
            this.uzerineyaz.Size = new System.Drawing.Size(80, 17);
            this.uzerineyaz.TabIndex = 32;
            this.uzerineyaz.TabStop = true;
            this.uzerineyaz.Text = "Üzerine yaz";
            this.uzerineyaz.UseVisualStyleBackColor = true;
            // 
            // rename
            // 
            this.rename.AutoSize = true;
            this.rename.Location = new System.Drawing.Point(158, 209);
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(105, 17);
            this.rename.TabIndex = 31;
            this.rename.Text = "Yeniden Adlandır";
            this.rename.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Hedefte aynı dosya varsa ?";
            // 
            // buttontarget
            // 
            this.buttontarget.Location = new System.Drawing.Point(253, 123);
            this.buttontarget.Name = "buttontarget";
            this.buttontarget.Size = new System.Drawing.Size(36, 23);
            this.buttontarget.TabIndex = 29;
            this.buttontarget.Text = "...";
            this.buttontarget.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Hedef Klasörü Seçiniz";
            // 
            // targetText
            // 
            this.targetText.Location = new System.Drawing.Point(16, 152);
            this.targetText.Name = "targetText";
            this.targetText.Size = new System.Drawing.Size(277, 20);
            this.targetText.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Folder to Zip Converter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(311, 367);
            this.Controls.Add(this.buttonsource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sourceText);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Folder Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonsource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sourceText;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox changeSave;
        private System.Windows.Forms.CheckBox subdirectorieszipped;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox zipLevel;
        private System.Windows.Forms.RadioButton uzerineyaz;
        private System.Windows.Forms.RadioButton rename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttontarget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox targetText;
        private System.Windows.Forms.Label label3;
    }
}

