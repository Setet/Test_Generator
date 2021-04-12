
namespace Test
{
    partial class FormTest
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
            this.WritePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_GenerateTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_SaveFile = new System.Windows.Forms.Button();
            this.labeln = new System.Windows.Forms.Label();
            this.button_FileCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WritePath
            // 
            this.WritePath.Location = new System.Drawing.Point(12, 114);
            this.WritePath.Name = "WritePath";
            this.WritePath.Size = new System.Drawing.Size(230, 20);
            this.WritePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // button_GenerateTest
            // 
            this.button_GenerateTest.Location = new System.Drawing.Point(12, 179);
            this.button_GenerateTest.Name = "button_GenerateTest";
            this.button_GenerateTest.Size = new System.Drawing.Size(230, 52);
            this.button_GenerateTest.TabIndex = 5;
            this.button_GenerateTest.Text = "Сгенерировать тест";
            this.button_GenerateTest.UseVisualStyleBackColor = true;
            this.button_GenerateTest.Click += new System.EventHandler(this.button_GenerateTest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // button_SaveFile
            // 
            this.button_SaveFile.Location = new System.Drawing.Point(130, 12);
            this.button_SaveFile.Name = "button_SaveFile";
            this.button_SaveFile.Size = new System.Drawing.Size(112, 38);
            this.button_SaveFile.TabIndex = 9;
            this.button_SaveFile.Text = "Выбрать файл";
            this.button_SaveFile.UseVisualStyleBackColor = true;
            this.button_SaveFile.Click += new System.EventHandler(this.button_SaveFile_Click);
            // 
            // labeln
            // 
            this.labeln.AutoSize = true;
            this.labeln.Location = new System.Drawing.Point(88, 137);
            this.labeln.Name = "labeln";
            this.labeln.Size = new System.Drawing.Size(35, 13);
            this.labeln.TabIndex = 10;
            this.labeln.Text = "labeln";
            // 
            // button_FileCreate
            // 
            this.button_FileCreate.Location = new System.Drawing.Point(12, 12);
            this.button_FileCreate.Name = "button_FileCreate";
            this.button_FileCreate.Size = new System.Drawing.Size(112, 38);
            this.button_FileCreate.TabIndex = 11;
            this.button_FileCreate.Text = "Создать файл и выбрать файл";
            this.button_FileCreate.UseVisualStyleBackColor = true;
            this.button_FileCreate.Click += new System.EventHandler(this.button_FileCreate_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 243);
            this.Controls.Add(this.button_FileCreate);
            this.Controls.Add(this.labeln);
            this.Controls.Add(this.button_SaveFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_GenerateTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WritePath);
            this.Name = "FormTest";
            this.Text = "Генератор тестов";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox WritePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_GenerateTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_SaveFile;
        private System.Windows.Forms.Label labeln;
        private System.Windows.Forms.Button button_FileCreate;
    }
}

