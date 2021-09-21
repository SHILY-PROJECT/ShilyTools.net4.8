namespace ShilyTools.SymbolsHandler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2ElipseForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.appExitButton = new Guna.UI2.WinForms.Guna2Button();
            this.inputTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.resultTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.labelSoft = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.appMinimizedButton = new Guna.UI2.WinForms.Guna2Button();
            this.modeHandleTextComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // guna2ElipseForm
            // 
            this.guna2ElipseForm.BorderRadius = 20;
            this.guna2ElipseForm.TargetControl = this;
            // 
            // appExitButton
            // 
            this.appExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appExitButton.Animated = true;
            this.appExitButton.AutoRoundedCorners = true;
            this.appExitButton.BorderRadius = 8;
            this.appExitButton.CheckedState.Parent = this.appExitButton;
            this.appExitButton.CustomImages.Parent = this.appExitButton;
            this.appExitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.appExitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.appExitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.appExitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.appExitButton.DisabledState.Parent = this.appExitButton;
            this.appExitButton.FillColor = System.Drawing.Color.Tomato;
            this.appExitButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.appExitButton.ForeColor = System.Drawing.Color.White;
            this.appExitButton.HoverState.FillColor = System.Drawing.Color.Red;
            this.appExitButton.HoverState.Parent = this.appExitButton;
            this.appExitButton.Location = new System.Drawing.Point(515, 9);
            this.appExitButton.Name = "appExitButton";
            this.appExitButton.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.appExitButton.ShadowDecoration.Parent = this.appExitButton;
            this.appExitButton.Size = new System.Drawing.Size(18, 18);
            this.appExitButton.TabIndex = 0;
            // 
            // inputTextBox
            // 
            this.inputTextBox.BorderColor = System.Drawing.Color.Silver;
            this.inputTextBox.BorderRadius = 10;
            this.inputTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputTextBox.DefaultText = "";
            this.inputTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputTextBox.DisabledState.Parent = this.inputTextBox;
            this.inputTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputTextBox.FocusedState.Parent = this.inputTextBox;
            this.inputTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inputTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputTextBox.HoverState.Parent = this.inputTextBox;
            this.inputTextBox.Location = new System.Drawing.Point(5, 115);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.PasswordChar = '\0';
            this.inputTextBox.PlaceholderText = "Введите текст для обработки...";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.SelectedText = "";
            this.inputTextBox.ShadowDecoration.Parent = this.inputTextBox;
            this.inputTextBox.Size = new System.Drawing.Size(530, 140);
            this.inputTextBox.TabIndex = 1;
            // 
            // resultTextBox
            // 
            this.resultTextBox.BorderColor = System.Drawing.Color.Silver;
            this.resultTextBox.BorderRadius = 10;
            this.resultTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resultTextBox.DefaultText = "";
            this.resultTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.resultTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.resultTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.resultTextBox.DisabledState.Parent = this.resultTextBox;
            this.resultTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.resultTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resultTextBox.FocusedState.Parent = this.resultTextBox;
            this.resultTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resultTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resultTextBox.HoverState.Parent = this.resultTextBox;
            this.resultTextBox.Location = new System.Drawing.Point(5, 261);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.PasswordChar = '\0';
            this.resultTextBox.PlaceholderText = "Здесь будет результат обработки...";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.SelectedText = "";
            this.resultTextBox.ShadowDecoration.Parent = this.resultTextBox;
            this.resultTextBox.Size = new System.Drawing.Size(530, 140);
            this.resultTextBox.TabIndex = 2;
            // 
            // shadowForm
            // 
            this.shadowForm.BorderRadius = 20;
            this.shadowForm.ShadowColor = System.Drawing.Color.DimGray;
            // 
            // labelSoft
            // 
            this.labelSoft.BackColor = System.Drawing.Color.Transparent;
            this.labelSoft.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSoft.ForeColor = System.Drawing.Color.Gray;
            this.labelSoft.Location = new System.Drawing.Point(10, 7);
            this.labelSoft.Name = "labelSoft";
            this.labelSoft.Size = new System.Drawing.Size(198, 22);
            this.labelSoft.TabIndex = 4;
            this.labelSoft.Text = "ShilyTools | Symbols handler";
            // 
            // appMinimizedButton
            // 
            this.appMinimizedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appMinimizedButton.Animated = true;
            this.appMinimizedButton.AutoRoundedCorners = true;
            this.appMinimizedButton.BorderRadius = 8;
            this.appMinimizedButton.CheckedState.Parent = this.appMinimizedButton;
            this.appMinimizedButton.CustomImages.Parent = this.appMinimizedButton;
            this.appMinimizedButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.appMinimizedButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.appMinimizedButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.appMinimizedButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.appMinimizedButton.DisabledState.Parent = this.appMinimizedButton;
            this.appMinimizedButton.FillColor = System.Drawing.Color.SkyBlue;
            this.appMinimizedButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.appMinimizedButton.ForeColor = System.Drawing.Color.White;
            this.appMinimizedButton.HoverState.FillColor = System.Drawing.Color.RoyalBlue;
            this.appMinimizedButton.HoverState.Parent = this.appMinimizedButton;
            this.appMinimizedButton.Location = new System.Drawing.Point(491, 9);
            this.appMinimizedButton.Name = "appMinimizedButton";
            this.appMinimizedButton.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.appMinimizedButton.ShadowDecoration.Parent = this.appMinimizedButton;
            this.appMinimizedButton.Size = new System.Drawing.Size(18, 18);
            this.appMinimizedButton.TabIndex = 5;
            // 
            // modeHandleTextComboBox
            // 
            this.modeHandleTextComboBox.BackColor = System.Drawing.Color.Transparent;
            this.modeHandleTextComboBox.BorderColor = System.Drawing.Color.Silver;
            this.modeHandleTextComboBox.BorderRadius = 10;
            this.modeHandleTextComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.modeHandleTextComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeHandleTextComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.modeHandleTextComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.modeHandleTextComboBox.FocusedState.Parent = this.modeHandleTextComboBox;
            this.modeHandleTextComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.modeHandleTextComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.modeHandleTextComboBox.HoverState.Parent = this.modeHandleTextComboBox;
            this.modeHandleTextComboBox.ItemHeight = 30;
            this.modeHandleTextComboBox.ItemsAppearance.Parent = this.modeHandleTextComboBox;
            this.modeHandleTextComboBox.Location = new System.Drawing.Point(5, 74);
            this.modeHandleTextComboBox.Name = "modeHandleTextComboBox";
            this.modeHandleTextComboBox.ShadowDecoration.BorderRadius = 10;
            this.modeHandleTextComboBox.ShadowDecoration.Parent = this.modeHandleTextComboBox;
            this.modeHandleTextComboBox.Size = new System.Drawing.Size(530, 36);
            this.modeHandleTextComboBox.TabIndex = 6;
            this.modeHandleTextComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(542, 408);
            this.Controls.Add(this.modeHandleTextComboBox);
            this.Controls.Add(this.appMinimizedButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.appExitButton);
            this.Controls.Add(this.labelSoft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Symbols handler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseForm;
        private Guna.UI2.WinForms.Guna2Button appExitButton;
        private Guna.UI2.WinForms.Guna2TextBox resultTextBox;
        private Guna.UI2.WinForms.Guna2TextBox inputTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelSoft;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm;
        private Guna.UI2.WinForms.Guna2Button appMinimizedButton;
        private Guna.UI2.WinForms.Guna2ComboBox modeHandleTextComboBox;
    }
}

