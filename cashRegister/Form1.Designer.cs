namespace cashRegister
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.hotdogLabel = new System.Windows.Forms.Label();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.sausageLabel = new System.Windows.Forms.Label();
            this.hotdogInput = new System.Windows.Forms.TextBox();
            this.drinkInput = new System.Windows.Forms.TextBox();
            this.sausageInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.nameReceiptLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.divider = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Red;
            this.titleLabel.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(365, 87);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Drew\'s Dogs";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hotdogLabel
            // 
            this.hotdogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotdogLabel.Location = new System.Drawing.Point(12, 124);
            this.hotdogLabel.Name = "hotdogLabel";
            this.hotdogLabel.Size = new System.Drawing.Size(242, 32);
            this.hotdogLabel.TabIndex = 1;
            this.hotdogLabel.Text = "Number of Hot Dogs";
            this.hotdogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // drinkLabel
            // 
            this.drinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkLabel.Location = new System.Drawing.Point(12, 200);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(242, 32);
            this.drinkLabel.TabIndex = 2;
            this.drinkLabel.Text = "Number of Drinks";
            this.drinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sausageLabel
            // 
            this.sausageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sausageLabel.Location = new System.Drawing.Point(12, 162);
            this.sausageLabel.Name = "sausageLabel";
            this.sausageLabel.Size = new System.Drawing.Size(242, 32);
            this.sausageLabel.TabIndex = 3;
            this.sausageLabel.Text = "Number of Sausages";
            this.sausageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hotdogInput
            // 
            this.hotdogInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotdogInput.Location = new System.Drawing.Point(260, 125);
            this.hotdogInput.Name = "hotdogInput";
            this.hotdogInput.Size = new System.Drawing.Size(117, 31);
            this.hotdogInput.TabIndex = 1;
            // 
            // drinkInput
            // 
            this.drinkInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkInput.Location = new System.Drawing.Point(260, 200);
            this.drinkInput.Name = "drinkInput";
            this.drinkInput.Size = new System.Drawing.Size(117, 31);
            this.drinkInput.TabIndex = 3;
            // 
            // sausageInput
            // 
            this.sausageInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sausageInput.Location = new System.Drawing.Point(260, 163);
            this.sausageInput.Name = "sausageInput";
            this.sausageInput.Size = new System.Drawing.Size(117, 31);
            this.sausageInput.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Red;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(260, 238);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(117, 37);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(12, 283);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(242, 32);
            this.subtotalLabel.TabIndex = 8;
            this.subtotalLabel.Text = "Subtotal";
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxLabel
            // 
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(12, 320);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(242, 32);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(12, 378);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(242, 32);
            this.tenderedLabel.TabIndex = 11;
            this.tenderedLabel.Text = "Tendered";
            this.tenderedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.Color.Red;
            this.totalButton.Enabled = false;
            this.totalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.Location = new System.Drawing.Point(260, 418);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(117, 37);
            this.totalButton.TabIndex = 8;
            this.totalButton.Text = "Total";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // tenderedInput
            // 
            this.tenderedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.Location = new System.Drawing.Point(260, 379);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(117, 31);
            this.tenderedInput.TabIndex = 7;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(12, 463);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(242, 32);
            this.totalLabel.TabIndex = 17;
            this.totalLabel.Text = "Total";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.Red;
            this.receiptButton.Enabled = false;
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.Location = new System.Drawing.Point(399, 24);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(260, 56);
            this.receiptButton.TabIndex = 11;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.White;
            this.receiptLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(559, 154);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(100, 301);
            this.receiptLabel.TabIndex = 20;
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.Color.White;
            this.subtotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.Location = new System.Drawing.Point(260, 285);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(117, 28);
            this.subtotalOutput.TabIndex = 5;
            this.subtotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.White;
            this.taxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(260, 323);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(117, 27);
            this.taxOutput.TabIndex = 6;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.Color.White;
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(260, 465);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(117, 28);
            this.totalOutput.TabIndex = 9;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.Color.White;
            this.changeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(260, 502);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(117, 28);
            this.changeOutput.TabIndex = 10;
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(12, 500);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(242, 32);
            this.changeLabel.TabIndex = 25;
            this.changeLabel.Text = "Change";
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // itemLabel
            // 
            this.itemLabel.BackColor = System.Drawing.Color.White;
            this.itemLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.Location = new System.Drawing.Point(398, 154);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(161, 301);
            this.itemLabel.TabIndex = 26;
            // 
            // nameReceiptLabel
            // 
            this.nameReceiptLabel.BackColor = System.Drawing.Color.White;
            this.nameReceiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameReceiptLabel.Location = new System.Drawing.Point(398, 94);
            this.nameReceiptLabel.Name = "nameReceiptLabel";
            this.nameReceiptLabel.Size = new System.Drawing.Size(261, 60);
            this.nameReceiptLabel.TabIndex = 27;
            this.nameReceiptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Red;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(401, 465);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(260, 67);
            this.resetButton.TabIndex = 28;
            this.resetButton.Text = "New Order";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.Black;
            this.divider.Location = new System.Drawing.Point(149, 358);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(228, 13);
            this.divider.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(670, 550);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.nameReceiptLabel);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.sausageInput);
            this.Controls.Add(this.drinkInput);
            this.Controls.Add(this.hotdogInput);
            this.Controls.Add(this.sausageLabel);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.hotdogLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Drew\'s Dogs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label hotdogLabel;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.Label sausageLabel;
        private System.Windows.Forms.TextBox hotdogInput;
        private System.Windows.Forms.TextBox drinkInput;
        private System.Windows.Forms.TextBox sausageInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label nameReceiptLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label divider;
    }
}

