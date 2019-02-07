namespace ExamenPatterns
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelAuthorName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1Author = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxChooseYourCafe = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectAMeal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAddToMeal = new System.Windows.Forms.ComboBox();
            this.labelAddToMeal = new System.Windows.Forms.Label();
            this.listBoxOrdersCheckList = new System.Windows.Forms.ListBox();
            this.labelOrdersListCheck = new System.Windows.Forms.Label();
            this.buttonAddToOrderList = new System.Windows.Forms.Button();
            this.buttonGetCheck = new System.Windows.Forms.Button();
            this.listBoxPrice = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxChange = new System.Windows.Forms.GroupBox();
            this.buttonMarketChange = new System.Windows.Forms.Button();
            this.buttonSetNewPrice = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNewPrice = new System.Windows.Forms.TextBox();
            this.comboBoxSelectAMealForChange = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxIngredientsWeight = new System.Windows.Forms.ComboBox();
            this.labelIngredientsWeight = new System.Windows.Forms.Label();
            this.comboBoxSelectTypeOfMeal = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxSelectComposition = new System.Windows.Forms.ComboBox();
            this.labelSelectComposition = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBoxChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelAuthorName,
            this.toolStripStatusLabel1Author,
            this.toolStripStatusLabel2Date,
            this.toolStripStatusLabel3Time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 483);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1125, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelAuthorName
            // 
            this.toolStripStatusLabelAuthorName.Name = "toolStripStatusLabelAuthorName";
            this.toolStripStatusLabelAuthorName.Size = new System.Drawing.Size(57, 20);
            this.toolStripStatusLabelAuthorName.Text = "Author:";
            // 
            // toolStripStatusLabel1Author
            // 
            this.toolStripStatusLabel1Author.Name = "toolStripStatusLabel1Author";
            this.toolStripStatusLabel1Author.Size = new System.Drawing.Size(91, 20);
            this.toolStripStatusLabel1Author.Text = "Манько Н.Г.";
            // 
            // toolStripStatusLabel2Date
            // 
            this.toolStripStatusLabel2Date.Name = "toolStripStatusLabel2Date";
            this.toolStripStatusLabel2Date.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel3Time
            // 
            this.toolStripStatusLabel3Time.Name = "toolStripStatusLabel3Time";
            this.toolStripStatusLabel3Time.Size = new System.Drawing.Size(0, 20);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose your cafe";
            // 
            // comboBoxChooseYourCafe
            // 
            this.comboBoxChooseYourCafe.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChooseYourCafe.FormattingEnabled = true;
            this.comboBoxChooseYourCafe.Location = new System.Drawing.Point(19, 65);
            this.comboBoxChooseYourCafe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxChooseYourCafe.Name = "comboBoxChooseYourCafe";
            this.comboBoxChooseYourCafe.Size = new System.Drawing.Size(192, 31);
            this.comboBoxChooseYourCafe.TabIndex = 3;
            this.comboBoxChooseYourCafe.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseYourCafe_SelectedIndexChanged);
            // 
            // comboBoxSelectAMeal
            // 
            this.comboBoxSelectAMeal.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectAMeal.FormattingEnabled = true;
            this.comboBoxSelectAMeal.Location = new System.Drawing.Point(19, 126);
            this.comboBoxSelectAMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSelectAMeal.Name = "comboBoxSelectAMeal";
            this.comboBoxSelectAMeal.Size = new System.Drawing.Size(192, 31);
            this.comboBoxSelectAMeal.TabIndex = 5;
            this.comboBoxSelectAMeal.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectAMeal_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select a meal";
            // 
            // comboBoxAddToMeal
            // 
            this.comboBoxAddToMeal.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAddToMeal.FormattingEnabled = true;
            this.comboBoxAddToMeal.Location = new System.Drawing.Point(19, 363);
            this.comboBoxAddToMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxAddToMeal.Name = "comboBoxAddToMeal";
            this.comboBoxAddToMeal.Size = new System.Drawing.Size(192, 31);
            this.comboBoxAddToMeal.TabIndex = 7;
            // 
            // labelAddToMeal
            // 
            this.labelAddToMeal.AutoSize = true;
            this.labelAddToMeal.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddToMeal.Location = new System.Drawing.Point(12, 343);
            this.labelAddToMeal.Name = "labelAddToMeal";
            this.labelAddToMeal.Size = new System.Drawing.Size(122, 23);
            this.labelAddToMeal.TabIndex = 6;
            this.labelAddToMeal.Text = "Add to meal";
            // 
            // listBoxOrdersCheckList
            // 
            this.listBoxOrdersCheckList.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOrdersCheckList.FormattingEnabled = true;
            this.listBoxOrdersCheckList.ItemHeight = 18;
            this.listBoxOrdersCheckList.Location = new System.Drawing.Point(217, 39);
            this.listBoxOrdersCheckList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxOrdersCheckList.Name = "listBoxOrdersCheckList";
            this.listBoxOrdersCheckList.Size = new System.Drawing.Size(465, 418);
            this.listBoxOrdersCheckList.TabIndex = 8;
            // 
            // labelOrdersListCheck
            // 
            this.labelOrdersListCheck.AutoSize = true;
            this.labelOrdersListCheck.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdersListCheck.Location = new System.Drawing.Point(319, 9);
            this.labelOrdersListCheck.Name = "labelOrdersListCheck";
            this.labelOrdersListCheck.Size = new System.Drawing.Size(123, 27);
            this.labelOrdersListCheck.TabIndex = 9;
            this.labelOrdersListCheck.Text = "Orders list";
            // 
            // buttonAddToOrderList
            // 
            this.buttonAddToOrderList.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToOrderList.Location = new System.Drawing.Point(19, 400);
            this.buttonAddToOrderList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddToOrderList.Name = "buttonAddToOrderList";
            this.buttonAddToOrderList.Size = new System.Drawing.Size(192, 37);
            this.buttonAddToOrderList.TabIndex = 10;
            this.buttonAddToOrderList.Text = "Add to order list";
            this.buttonAddToOrderList.UseVisualStyleBackColor = true;
            this.buttonAddToOrderList.Click += new System.EventHandler(this.buttonAddToOrderList_Click);
            // 
            // buttonGetCheck
            // 
            this.buttonGetCheck.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetCheck.Location = new System.Drawing.Point(19, 438);
            this.buttonGetCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGetCheck.Name = "buttonGetCheck";
            this.buttonGetCheck.Size = new System.Drawing.Size(192, 37);
            this.buttonGetCheck.TabIndex = 11;
            this.buttonGetCheck.Text = "Get a check";
            this.buttonGetCheck.UseVisualStyleBackColor = true;
            this.buttonGetCheck.Click += new System.EventHandler(this.buttonGetCheck_Click);
            // 
            // listBoxPrice
            // 
            this.listBoxPrice.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPrice.FormattingEnabled = true;
            this.listBoxPrice.ItemHeight = 23;
            this.listBoxPrice.Location = new System.Drawing.Point(896, 39);
            this.listBoxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPrice.Name = "listBoxPrice";
            this.listBoxPrice.Size = new System.Drawing.Size(217, 418);
            this.listBoxPrice.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(891, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "Price list";
            // 
            // groupBoxChange
            // 
            this.groupBoxChange.Controls.Add(this.buttonMarketChange);
            this.groupBoxChange.Controls.Add(this.buttonSetNewPrice);
            this.groupBoxChange.Controls.Add(this.label7);
            this.groupBoxChange.Controls.Add(this.textBoxNewPrice);
            this.groupBoxChange.Controls.Add(this.comboBoxSelectAMealForChange);
            this.groupBoxChange.Controls.Add(this.label5);
            this.groupBoxChange.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChange.Location = new System.Drawing.Point(688, 39);
            this.groupBoxChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxChange.Name = "groupBoxChange";
            this.groupBoxChange.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxChange.Size = new System.Drawing.Size(202, 436);
            this.groupBoxChange.TabIndex = 15;
            this.groupBoxChange.TabStop = false;
            this.groupBoxChange.Text = "Price change block";
            // 
            // buttonMarketChange
            // 
            this.buttonMarketChange.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMarketChange.Location = new System.Drawing.Point(6, 395);
            this.buttonMarketChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMarketChange.Name = "buttonMarketChange";
            this.buttonMarketChange.Size = new System.Drawing.Size(190, 37);
            this.buttonMarketChange.TabIndex = 24;
            this.buttonMarketChange.Text = "Change market";
            this.buttonMarketChange.UseVisualStyleBackColor = true;
            this.buttonMarketChange.Click += new System.EventHandler(this.buttonMarketChange_Click);
            // 
            // buttonSetNewPrice
            // 
            this.buttonSetNewPrice.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetNewPrice.Location = new System.Drawing.Point(6, 354);
            this.buttonSetNewPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSetNewPrice.Name = "buttonSetNewPrice";
            this.buttonSetNewPrice.Size = new System.Drawing.Size(190, 37);
            this.buttonSetNewPrice.TabIndex = 16;
            this.buttonSetNewPrice.Text = "Set a new price";
            this.buttonSetNewPrice.UseVisualStyleBackColor = true;
            this.buttonSetNewPrice.Click += new System.EventHandler(this.buttonSetNewPrice_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "New price";
            // 
            // textBoxNewPrice
            // 
            this.textBoxNewPrice.Location = new System.Drawing.Point(10, 171);
            this.textBoxNewPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewPrice.Name = "textBoxNewPrice";
            this.textBoxNewPrice.Size = new System.Drawing.Size(186, 30);
            this.textBoxNewPrice.TabIndex = 20;
            // 
            // comboBoxSelectAMealForChange
            // 
            this.comboBoxSelectAMealForChange.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectAMealForChange.FormattingEnabled = true;
            this.comboBoxSelectAMealForChange.Location = new System.Drawing.Point(10, 87);
            this.comboBoxSelectAMealForChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSelectAMealForChange.Name = "comboBoxSelectAMealForChange";
            this.comboBoxSelectAMealForChange.Size = new System.Drawing.Size(186, 31);
            this.comboBoxSelectAMealForChange.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Select a meal";
            // 
            // comboBoxIngredientsWeight
            // 
            this.comboBoxIngredientsWeight.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIngredientsWeight.FormattingEnabled = true;
            this.comboBoxIngredientsWeight.Location = new System.Drawing.Point(19, 309);
            this.comboBoxIngredientsWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxIngredientsWeight.Name = "comboBoxIngredientsWeight";
            this.comboBoxIngredientsWeight.Size = new System.Drawing.Size(192, 31);
            this.comboBoxIngredientsWeight.TabIndex = 17;
            // 
            // labelIngredientsWeight
            // 
            this.labelIngredientsWeight.AutoSize = true;
            this.labelIngredientsWeight.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngredientsWeight.Location = new System.Drawing.Point(15, 283);
            this.labelIngredientsWeight.Name = "labelIngredientsWeight";
            this.labelIngredientsWeight.Size = new System.Drawing.Size(179, 23);
            this.labelIngredientsWeight.TabIndex = 16;
            this.labelIngredientsWeight.Text = "Ingredients weight";
            // 
            // comboBoxSelectTypeOfMeal
            // 
            this.comboBoxSelectTypeOfMeal.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectTypeOfMeal.FormattingEnabled = true;
            this.comboBoxSelectTypeOfMeal.Location = new System.Drawing.Point(19, 185);
            this.comboBoxSelectTypeOfMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSelectTypeOfMeal.Name = "comboBoxSelectTypeOfMeal";
            this.comboBoxSelectTypeOfMeal.Size = new System.Drawing.Size(192, 31);
            this.comboBoxSelectTypeOfMeal.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Select type of meal";
            // 
            // comboBoxSelectComposition
            // 
            this.comboBoxSelectComposition.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectComposition.FormattingEnabled = true;
            this.comboBoxSelectComposition.Location = new System.Drawing.Point(19, 245);
            this.comboBoxSelectComposition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSelectComposition.Name = "comboBoxSelectComposition";
            this.comboBoxSelectComposition.Size = new System.Drawing.Size(192, 31);
            this.comboBoxSelectComposition.TabIndex = 21;
            // 
            // labelSelectComposition
            // 
            this.labelSelectComposition.AutoSize = true;
            this.labelSelectComposition.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectComposition.Location = new System.Drawing.Point(15, 219);
            this.labelSelectComposition.Name = "labelSelectComposition";
            this.labelSelectComposition.Size = new System.Drawing.Size(174, 23);
            this.labelSelectComposition.TabIndex = 20;
            this.labelSelectComposition.Text = "Select composition";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 508);
            this.Controls.Add(this.comboBoxSelectComposition);
            this.Controls.Add(this.labelSelectComposition);
            this.Controls.Add(this.comboBoxSelectTypeOfMeal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxIngredientsWeight);
            this.Controls.Add(this.labelIngredientsWeight);
            this.Controls.Add(this.groupBoxChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxPrice);
            this.Controls.Add(this.buttonGetCheck);
            this.Controls.Add(this.buttonAddToOrderList);
            this.Controls.Add(this.labelOrdersListCheck);
            this.Controls.Add(this.listBoxOrdersCheckList);
            this.Controls.Add(this.comboBoxAddToMeal);
            this.Controls.Add(this.labelAddToMeal);
            this.Controls.Add(this.comboBoxSelectAMeal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxChooseYourCafe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Patterns Examen";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxChange.ResumeLayout(false);
            this.groupBoxChange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1Author;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2Date;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAuthorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxChooseYourCafe;
        private System.Windows.Forms.ComboBox comboBoxSelectAMeal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAddToMeal;
        private System.Windows.Forms.Label labelAddToMeal;
        private System.Windows.Forms.ListBox listBoxOrdersCheckList;
        private System.Windows.Forms.Label labelOrdersListCheck;
        private System.Windows.Forms.Button buttonAddToOrderList;
        private System.Windows.Forms.Button buttonGetCheck;
        private System.Windows.Forms.ListBox listBoxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxChange;
        private System.Windows.Forms.Button buttonSetNewPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNewPrice;
        private System.Windows.Forms.ComboBox comboBoxSelectAMealForChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxIngredientsWeight;
        private System.Windows.Forms.Label labelIngredientsWeight;
        private System.Windows.Forms.ComboBox comboBoxSelectTypeOfMeal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxSelectComposition;
        private System.Windows.Forms.Label labelSelectComposition;
        private System.Windows.Forms.Button buttonMarketChange;
    }
}

