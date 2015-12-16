namespace QuikApp.UI.Controls.DetailsPanels
{
    partial class PropertyDetailsPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txbPropertyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbAccessReadonly = new System.Windows.Forms.RadioButton();
            this.rdbAccessReadWrite = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbChangeEventYes = new System.Windows.Forms.RadioButton();
            this.rdbChangeEventDefault = new System.Windows.Forms.RadioButton();
            this.rdbChangeEventNo = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdbScriptNo = new System.Windows.Forms.RadioButton();
            this.rdbScriptYes = new System.Windows.Forms.RadioButton();
            this.rdbScriptDefault = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdbCardinalityList = new System.Windows.Forms.RadioButton();
            this.rdbCardinalitySingle = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbCarindalityArray = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdbValidateValuesNo = new System.Windows.Forms.RadioButton();
            this.rdbValidateValuesYes = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbAcceptableValues = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rdbInvalidInputIgnore = new System.Windows.Forms.RadioButton();
            this.rdbInvalidInputException = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Property";
            // 
            // txbPropertyName
            // 
            this.txbPropertyName.Location = new System.Drawing.Point(101, 4);
            this.txbPropertyName.Name = "txbPropertyName";
            this.txbPropertyName.Size = new System.Drawing.Size(290, 20);
            this.txbPropertyName.TabIndex = 1;
            this.txbPropertyName.TextChanged += new System.EventHandler(this.txbPropertyName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(101, 43);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(290, 80);
            this.txbDescription.TabIndex = 3;
            this.txbDescription.TextChanged += new System.EventHandler(this.txbDescription_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(101, 140);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(290, 21);
            this.cbxType.TabIndex = 5;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Access";
            // 
            // rdbAccessReadonly
            // 
            this.rdbAccessReadonly.AutoSize = true;
            this.rdbAccessReadonly.Location = new System.Drawing.Point(4, 3);
            this.rdbAccessReadonly.Name = "rdbAccessReadonly";
            this.rdbAccessReadonly.Size = new System.Drawing.Size(70, 17);
            this.rdbAccessReadonly.TabIndex = 7;
            this.rdbAccessReadonly.TabStop = true;
            this.rdbAccessReadonly.Text = "Readonly";
            this.rdbAccessReadonly.UseVisualStyleBackColor = true;
            this.rdbAccessReadonly.CheckedChanged += new System.EventHandler(this.rdbAccessReadonly_CheckedChanged);
            // 
            // rdbAccessReadWrite
            // 
            this.rdbAccessReadWrite.AutoSize = true;
            this.rdbAccessReadWrite.Location = new System.Drawing.Point(80, 3);
            this.rdbAccessReadWrite.Name = "rdbAccessReadWrite";
            this.rdbAccessReadWrite.Size = new System.Drawing.Size(81, 17);
            this.rdbAccessReadWrite.TabIndex = 8;
            this.rdbAccessReadWrite.TabStop = true;
            this.rdbAccessReadWrite.Text = "Read/Write";
            this.rdbAccessReadWrite.UseVisualStyleBackColor = true;
            this.rdbAccessReadWrite.CheckedChanged += new System.EventHandler(this.rdbAccessReadWrite_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbAccessReadWrite);
            this.panel1.Controls.Add(this.rdbAccessReadonly);
            this.panel1.Location = new System.Drawing.Point(101, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 26);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Change event";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbChangeEventNo);
            this.panel2.Controls.Add(this.rdbChangeEventYes);
            this.panel2.Controls.Add(this.rdbChangeEventDefault);
            this.panel2.Location = new System.Drawing.Point(101, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 26);
            this.panel2.TabIndex = 11;
            // 
            // rdbChangeEventYes
            // 
            this.rdbChangeEventYes.AutoSize = true;
            this.rdbChangeEventYes.Location = new System.Drawing.Point(80, 3);
            this.rdbChangeEventYes.Name = "rdbChangeEventYes";
            this.rdbChangeEventYes.Size = new System.Drawing.Size(43, 17);
            this.rdbChangeEventYes.TabIndex = 8;
            this.rdbChangeEventYes.TabStop = true;
            this.rdbChangeEventYes.Text = "Yes";
            this.rdbChangeEventYes.UseVisualStyleBackColor = true;
            this.rdbChangeEventYes.CheckedChanged += new System.EventHandler(this.rdbChangeEventYes_CheckedChanged);
            // 
            // rdbChangeEventDefault
            // 
            this.rdbChangeEventDefault.AutoSize = true;
            this.rdbChangeEventDefault.Location = new System.Drawing.Point(4, 3);
            this.rdbChangeEventDefault.Name = "rdbChangeEventDefault";
            this.rdbChangeEventDefault.Size = new System.Drawing.Size(59, 17);
            this.rdbChangeEventDefault.TabIndex = 7;
            this.rdbChangeEventDefault.TabStop = true;
            this.rdbChangeEventDefault.Text = "Default";
            this.rdbChangeEventDefault.UseVisualStyleBackColor = true;
            this.rdbChangeEventDefault.CheckedChanged += new System.EventHandler(this.rdbChangeEventDefault_CheckedChanged);
            // 
            // rdbChangeEventNo
            // 
            this.rdbChangeEventNo.AutoSize = true;
            this.rdbChangeEventNo.Location = new System.Drawing.Point(141, 3);
            this.rdbChangeEventNo.Name = "rdbChangeEventNo";
            this.rdbChangeEventNo.Size = new System.Drawing.Size(39, 17);
            this.rdbChangeEventNo.TabIndex = 9;
            this.rdbChangeEventNo.TabStop = true;
            this.rdbChangeEventNo.Text = "No";
            this.rdbChangeEventNo.UseVisualStyleBackColor = true;
            this.rdbChangeEventNo.CheckedChanged += new System.EventHandler(this.rdbChangeEventNo_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdbScriptNo);
            this.panel3.Controls.Add(this.rdbScriptYes);
            this.panel3.Controls.Add(this.rdbScriptDefault);
            this.panel3.Location = new System.Drawing.Point(101, 495);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 26);
            this.panel3.TabIndex = 13;
            // 
            // rdbScriptNo
            // 
            this.rdbScriptNo.AutoSize = true;
            this.rdbScriptNo.Location = new System.Drawing.Point(141, 3);
            this.rdbScriptNo.Name = "rdbScriptNo";
            this.rdbScriptNo.Size = new System.Drawing.Size(39, 17);
            this.rdbScriptNo.TabIndex = 9;
            this.rdbScriptNo.TabStop = true;
            this.rdbScriptNo.Text = "No";
            this.rdbScriptNo.UseVisualStyleBackColor = true;
            this.rdbScriptNo.CheckedChanged += new System.EventHandler(this.rdbScriptNo_CheckedChanged);
            // 
            // rdbScriptYes
            // 
            this.rdbScriptYes.AutoSize = true;
            this.rdbScriptYes.Location = new System.Drawing.Point(80, 3);
            this.rdbScriptYes.Name = "rdbScriptYes";
            this.rdbScriptYes.Size = new System.Drawing.Size(43, 17);
            this.rdbScriptYes.TabIndex = 8;
            this.rdbScriptYes.TabStop = true;
            this.rdbScriptYes.Text = "Yes";
            this.rdbScriptYes.UseVisualStyleBackColor = true;
            this.rdbScriptYes.CheckedChanged += new System.EventHandler(this.rdbScriptYes_CheckedChanged);
            // 
            // rdbScriptDefault
            // 
            this.rdbScriptDefault.AutoSize = true;
            this.rdbScriptDefault.Location = new System.Drawing.Point(4, 3);
            this.rdbScriptDefault.Name = "rdbScriptDefault";
            this.rdbScriptDefault.Size = new System.Drawing.Size(59, 17);
            this.rdbScriptDefault.TabIndex = 7;
            this.rdbScriptDefault.TabStop = true;
            this.rdbScriptDefault.Text = "Default";
            this.rdbScriptDefault.UseVisualStyleBackColor = true;
            this.rdbScriptDefault.CheckedChanged += new System.EventHandler(this.rdbScriptDefault_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Script support";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdbCarindalityArray);
            this.panel4.Controls.Add(this.rdbCardinalityList);
            this.panel4.Controls.Add(this.rdbCardinalitySingle);
            this.panel4.Location = new System.Drawing.Point(101, 221);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 26);
            this.panel4.TabIndex = 15;
            // 
            // rdbCardinalityList
            // 
            this.rdbCardinalityList.AutoSize = true;
            this.rdbCardinalityList.Location = new System.Drawing.Point(80, 3);
            this.rdbCardinalityList.Name = "rdbCardinalityList";
            this.rdbCardinalityList.Size = new System.Drawing.Size(41, 17);
            this.rdbCardinalityList.TabIndex = 8;
            this.rdbCardinalityList.TabStop = true;
            this.rdbCardinalityList.Text = "List";
            this.rdbCardinalityList.UseVisualStyleBackColor = true;
            this.rdbCardinalityList.CheckedChanged += new System.EventHandler(this.rdbCardinalityList_CheckedChanged);
            // 
            // rdbCardinalitySingle
            // 
            this.rdbCardinalitySingle.AutoSize = true;
            this.rdbCardinalitySingle.Location = new System.Drawing.Point(4, 3);
            this.rdbCardinalitySingle.Name = "rdbCardinalitySingle";
            this.rdbCardinalitySingle.Size = new System.Drawing.Size(54, 17);
            this.rdbCardinalitySingle.TabIndex = 7;
            this.rdbCardinalitySingle.TabStop = true;
            this.rdbCardinalitySingle.Text = "Single";
            this.rdbCardinalitySingle.UseVisualStyleBackColor = true;
            this.rdbCardinalitySingle.CheckedChanged += new System.EventHandler(this.rdbCardinalitySingle_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cardinality";
            // 
            // rdbCarindalityArray
            // 
            this.rdbCarindalityArray.AutoSize = true;
            this.rdbCarindalityArray.Location = new System.Drawing.Point(139, 3);
            this.rdbCarindalityArray.Name = "rdbCarindalityArray";
            this.rdbCarindalityArray.Size = new System.Drawing.Size(49, 17);
            this.rdbCarindalityArray.TabIndex = 9;
            this.rdbCarindalityArray.TabStop = true;
            this.rdbCarindalityArray.Text = "Array";
            this.rdbCarindalityArray.UseVisualStyleBackColor = true;
            this.rdbCarindalityArray.CheckedChanged += new System.EventHandler(this.rdbCarindalityArray_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rdbValidateValuesNo);
            this.panel5.Controls.Add(this.rdbValidateValuesYes);
            this.panel5.Location = new System.Drawing.Point(101, 264);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 26);
            this.panel5.TabIndex = 17;
            // 
            // rdbValidateValuesNo
            // 
            this.rdbValidateValuesNo.AutoSize = true;
            this.rdbValidateValuesNo.Location = new System.Drawing.Point(80, 3);
            this.rdbValidateValuesNo.Name = "rdbValidateValuesNo";
            this.rdbValidateValuesNo.Size = new System.Drawing.Size(39, 17);
            this.rdbValidateValuesNo.TabIndex = 8;
            this.rdbValidateValuesNo.TabStop = true;
            this.rdbValidateValuesNo.Text = "No";
            this.rdbValidateValuesNo.UseVisualStyleBackColor = true;
            this.rdbValidateValuesNo.CheckedChanged += new System.EventHandler(this.rdbValidateValuesNo_CheckedChanged);
            // 
            // rdbValidateValuesYes
            // 
            this.rdbValidateValuesYes.AutoSize = true;
            this.rdbValidateValuesYes.Location = new System.Drawing.Point(4, 3);
            this.rdbValidateValuesYes.Name = "rdbValidateValuesYes";
            this.rdbValidateValuesYes.Size = new System.Drawing.Size(43, 17);
            this.rdbValidateValuesYes.TabIndex = 7;
            this.rdbValidateValuesYes.TabStop = true;
            this.rdbValidateValuesYes.Text = "Yes";
            this.rdbValidateValuesYes.UseVisualStyleBackColor = true;
            this.rdbValidateValuesYes.CheckedChanged += new System.EventHandler(this.rdbValidateValuesYes_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Validate";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(16, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 57);
            this.label9.TabIndex = 18;
            this.label9.Text = "Acceptable values";
            // 
            // txbAcceptableValues
            // 
            this.txbAcceptableValues.Location = new System.Drawing.Point(101, 312);
            this.txbAcceptableValues.Multiline = true;
            this.txbAcceptableValues.Name = "txbAcceptableValues";
            this.txbAcceptableValues.Size = new System.Drawing.Size(290, 80);
            this.txbAcceptableValues.TabIndex = 19;
            this.txbAcceptableValues.TextChanged += new System.EventHandler(this.txbAcceptableValues_TextChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rdbInvalidInputIgnore);
            this.panel6.Controls.Add(this.rdbInvalidInputException);
            this.panel6.Location = new System.Drawing.Point(101, 409);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(310, 26);
            this.panel6.TabIndex = 21;
            // 
            // rdbInvalidInputIgnore
            // 
            this.rdbInvalidInputIgnore.AutoSize = true;
            this.rdbInvalidInputIgnore.Location = new System.Drawing.Point(80, 3);
            this.rdbInvalidInputIgnore.Name = "rdbInvalidInputIgnore";
            this.rdbInvalidInputIgnore.Size = new System.Drawing.Size(55, 17);
            this.rdbInvalidInputIgnore.TabIndex = 8;
            this.rdbInvalidInputIgnore.TabStop = true;
            this.rdbInvalidInputIgnore.Text = "Ignore";
            this.rdbInvalidInputIgnore.UseVisualStyleBackColor = true;
            this.rdbInvalidInputIgnore.CheckedChanged += new System.EventHandler(this.rdbInvalidInputIgnore_CheckedChanged);
            // 
            // rdbInvalidInputException
            // 
            this.rdbInvalidInputException.AutoSize = true;
            this.rdbInvalidInputException.Location = new System.Drawing.Point(4, 3);
            this.rdbInvalidInputException.Name = "rdbInvalidInputException";
            this.rdbInvalidInputException.Size = new System.Drawing.Size(72, 17);
            this.rdbInvalidInputException.TabIndex = 7;
            this.rdbInvalidInputException.TabStop = true;
            this.rdbInvalidInputException.Text = "Exception";
            this.rdbInvalidInputException.UseVisualStyleBackColor = true;
            this.rdbInvalidInputException.CheckedChanged += new System.EventHandler(this.rdbInvalidInputException_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "On invalid input";
            // 
            // PropertyDetailsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbAcceptableValues);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPropertyName);
            this.Controls.Add(this.label1);
            this.Name = "PropertyDetailsPanel";
            this.Size = new System.Drawing.Size(830, 570);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPropertyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbAccessReadonly;
        private System.Windows.Forms.RadioButton rdbAccessReadWrite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbChangeEventNo;
        private System.Windows.Forms.RadioButton rdbChangeEventYes;
        private System.Windows.Forms.RadioButton rdbChangeEventDefault;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdbScriptNo;
        private System.Windows.Forms.RadioButton rdbScriptYes;
        private System.Windows.Forms.RadioButton rdbScriptDefault;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdbCarindalityArray;
        private System.Windows.Forms.RadioButton rdbCardinalityList;
        private System.Windows.Forms.RadioButton rdbCardinalitySingle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rdbValidateValuesNo;
        private System.Windows.Forms.RadioButton rdbValidateValuesYes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbAcceptableValues;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rdbInvalidInputIgnore;
        private System.Windows.Forms.RadioButton rdbInvalidInputException;
        private System.Windows.Forms.Label label10;
    }
}
