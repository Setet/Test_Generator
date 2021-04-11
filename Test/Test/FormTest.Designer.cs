
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
            this.NumberOfQuestions = new System.Windows.Forms.TextBox();
            this.WritePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListOfSurnames = new System.Windows.Forms.RichTextBox();
            this.button_ToAccept = new System.Windows.Forms.Button();
            this.button_GenerateTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumberOfQuestions
            // 
            this.NumberOfQuestions.Location = new System.Drawing.Point(12, 23);
            this.NumberOfQuestions.Name = "NumberOfQuestions";
            this.NumberOfQuestions.Size = new System.Drawing.Size(100, 20);
            this.NumberOfQuestions.TabIndex = 0;
            // 
            // WritePath
            // 
            this.WritePath.Location = new System.Drawing.Point(12, 80);
            this.WritePath.Name = "WritePath";
            this.WritePath.Size = new System.Drawing.Size(230, 20);
            this.WritePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // ListOfSurnames
            // 
            this.ListOfSurnames.AutoWordSelection = true;
            this.ListOfSurnames.Location = new System.Drawing.Point(248, 7);
            this.ListOfSurnames.Name = "ListOfSurnames";
            this.ListOfSurnames.Size = new System.Drawing.Size(187, 197);
            this.ListOfSurnames.TabIndex = 3;
            this.ListOfSurnames.Text = "";
            // 
            // button_ToAccept
            // 
            this.button_ToAccept.Location = new System.Drawing.Point(118, 21);
            this.button_ToAccept.Name = "button_ToAccept";
            this.button_ToAccept.Size = new System.Drawing.Size(75, 23);
            this.button_ToAccept.TabIndex = 4;
            this.button_ToAccept.Text = "Принять";
            this.button_ToAccept.UseVisualStyleBackColor = true;
            this.button_ToAccept.Click += new System.EventHandler(this.button_ToAccept_Click);
            // 
            // button_GenerateTest
            // 
            this.button_GenerateTest.Location = new System.Drawing.Point(12, 152);
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
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кол-во вопросов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Путь сохранения файла";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 212);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_GenerateTest);
            this.Controls.Add(this.button_ToAccept);
            this.Controls.Add(this.ListOfSurnames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WritePath);
            this.Controls.Add(this.NumberOfQuestions);
            this.Name = "FormTest";
            this.Text = "Генератор тестов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberOfQuestions;
        private System.Windows.Forms.TextBox WritePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ListOfSurnames;
        private System.Windows.Forms.Button button_ToAccept;
        private System.Windows.Forms.Button button_GenerateTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

