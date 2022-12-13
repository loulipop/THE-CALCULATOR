
namespace Calculator
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
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjButtonClearEntry = new Calculator.RJButton();
            this.rjButtonClear = new Calculator.RJButton();
            this.rjButtonEquals = new Calculator.RJButton();
            this.rjButtonRightBracket = new Calculator.RJButton();
            this.rjButtonLeftBracket = new Calculator.RJButton();
            this.rjButtonAddition = new Calculator.RJButton();
            this.rjButtonSubstraction = new Calculator.RJButton();
            this.rjButtonMultiplication = new Calculator.RJButton();
            this.rjButtonDivision = new Calculator.RJButton();
            this.rjButtonDecimal = new Calculator.RJButton();
            this.rjButton0 = new Calculator.RJButton();
            this.rjButton9 = new Calculator.RJButton();
            this.rjButton8 = new Calculator.RJButton();
            this.rjButton7 = new Calculator.RJButton();
            this.rjButton6 = new Calculator.RJButton();
            this.rjButton5 = new Calculator.RJButton();
            this.rjButton4 = new Calculator.RJButton();
            this.rjButton3 = new Calculator.RJButton();
            this.rjButton2 = new Calculator.RJButton();
            this.rjButton1 = new Calculator.RJButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.textBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutput.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 24F);
            this.textBoxOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBoxOutput.Location = new System.Drawing.Point(34, 29);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(367, 102);
            this.textBoxOutput.TabIndex = 21;
            this.textBoxOutput.Text = "0";
            this.textBoxOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.textBoxOutput);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 154);
            this.panel1.TabIndex = 43;
            // 
            // rjButtonClearEntry
            // 
            this.rjButtonClearEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButtonClearEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(143)))));
            this.rjButtonClearEntry.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(143)))));
            this.rjButtonClearEntry.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(143)))));
            this.rjButtonClearEntry.BorderRadius = 40;
            this.rjButtonClearEntry.BorderSize = 2;
            this.rjButtonClearEntry.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButtonClearEntry.FlatAppearance.BorderSize = 0;
            this.rjButtonClearEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(120)))));
            this.rjButtonClearEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            this.rjButtonClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonClearEntry.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonClearEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButtonClearEntry.Location = new System.Drawing.Point(126, 172);
            this.rjButtonClearEntry.Name = "rjButtonClearEntry";
            this.rjButtonClearEntry.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.rjButtonClearEntry.Size = new System.Drawing.Size(80, 80);
            this.rjButtonClearEntry.TabIndex = 42;
            this.rjButtonClearEntry.Text = "DEL";
            this.rjButtonClearEntry.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButtonClearEntry.UseCompatibleTextRendering = true;
            this.rjButtonClearEntry.UseVisualStyleBackColor = false;
            this.rjButtonClearEntry.Click += new System.EventHandler(this.buttonClearEntry_Click);
            // 
            // rjButtonClear
            // 
            this.rjButtonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(143)))));
            this.rjButtonClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(143)))));
            this.rjButtonClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(143)))));
            this.rjButtonClear.BorderRadius = 40;
            this.rjButtonClear.BorderSize = 2;
            this.rjButtonClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButtonClear.FlatAppearance.BorderSize = 0;
            this.rjButtonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(120)))));
            this.rjButtonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            this.rjButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonClear.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButtonClear.Location = new System.Drawing.Point(40, 172);
            this.rjButtonClear.Name = "rjButtonClear";
            this.rjButtonClear.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.rjButtonClear.Size = new System.Drawing.Size(80, 80);
            this.rjButtonClear.TabIndex = 41;
            this.rjButtonClear.Text = "AC";
            this.rjButtonClear.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButtonClear.UseCompatibleTextRendering = true;
            this.rjButtonClear.UseVisualStyleBackColor = false;
            this.rjButtonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // rjButtonEquals
            // 
            this.rjButtonEquals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButtonEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButtonEquals.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButtonEquals.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButtonEquals.BorderRadius = 40;
            this.rjButtonEquals.BorderSize = 2;
            this.rjButtonEquals.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButtonEquals.FlatAppearance.BorderSize = 0;
            this.rjButtonEquals.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(222)))));
            this.rjButtonEquals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButtonEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonEquals.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonEquals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButtonEquals.Location = new System.Drawing.Point(212, 516);
            this.rjButtonEquals.Name = "rjButtonEquals";
            this.rjButtonEquals.Padding = new System.Windows.Forms.Padding(0, 5, 2, 0);
            this.rjButtonEquals.Size = new System.Drawing.Size(80, 80);
            this.rjButtonEquals.TabIndex = 40;
            this.rjButtonEquals.Text = "=";
            this.rjButtonEquals.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButtonEquals.UseCompatibleTextRendering = true;
            this.rjButtonEquals.UseVisualStyleBackColor = false;
            this.rjButtonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // rjButtonRightBracket
            // 
            this.rjButtonRightBracket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButtonRightBracket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButtonRightBracket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButtonRightBracket.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButtonRightBracket.BorderRadius = 40;
            this.rjButtonRightBracket.BorderSize = 2;
            this.rjButtonRightBracket.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButtonRightBracket.FlatAppearance.BorderSize = 0;
            this.rjButtonRightBracket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.rjButtonRightBracket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButtonRightBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonRightBracket.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonRightBracket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButtonRightBracket.Location = new System.Drawing.Point(298, 172);
            this.rjButtonRightBracket.Name = "rjButtonRightBracket";
            this.rjButtonRightBracket.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.rjButtonRightBracket.Size = new System.Drawing.Size(80, 80);
            this.rjButtonRightBracket.TabIndex = 39;
            this.rjButtonRightBracket.Text = ")";
            this.rjButtonRightBracket.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButtonRightBracket.UseCompatibleTextRendering = true;
            this.rjButtonRightBracket.UseVisualStyleBackColor = false;
            this.rjButtonRightBracket.Click += new System.EventHandler(this.button_Click);
            // 
            // rjButtonLeftBracket
            // 
            this.rjButtonLeftBracket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButtonLeftBracket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButtonLeftBracket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButtonLeftBracket.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButtonLeftBracket.BorderRadius = 40;
            this.rjButtonLeftBracket.BorderSize = 2;
            this.rjButtonLeftBracket.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButtonLeftBracket.FlatAppearance.BorderSize = 0;
            this.rjButtonLeftBracket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.rjButtonLeftBracket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButtonLeftBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonLeftBracket.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonLeftBracket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButtonLeftBracket.Location = new System.Drawing.Point(212, 172);
            this.rjButtonLeftBracket.Name = "rjButtonLeftBracket";
            this.rjButtonLeftBracket.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.rjButtonLeftBracket.Size = new System.Drawing.Size(80, 80);
            this.rjButtonLeftBracket.TabIndex = 38;
            this.rjButtonLeftBracket.Text = "(";
            this.rjButtonLeftBracket.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButtonLeftBracket.UseCompatibleTextRendering = true;
            this.rjButtonLeftBracket.UseVisualStyleBackColor = false;
            this.rjButtonLeftBracket.Click += new System.EventHandler(this.button_Click);
            // 
            // rjButtonAddition
            // 
            this.rjButtonAddition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButtonAddition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButtonAddition.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButtonAddition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButtonAddition.BorderRadius = 40;
            this.rjButtonAddition.BorderSize = 2;
            this.rjButtonAddition.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButtonAddition.FlatAppearance.BorderSize = 0;
            this.rjButtonAddition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.rjButtonAddition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButtonAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonAddition.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonAddition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButtonAddition.Location = new System.Drawing.Point(298, 258);
            this.rjButtonAddition.Name = "rjButtonAddition";
            this.rjButtonAddition.Padding = new System.Windows.Forms.Padding(2, 3, 0, 0);
            this.rjButtonAddition.Size = new System.Drawing.Size(80, 80);
            this.rjButtonAddition.TabIndex = 36;
            this.rjButtonAddition.Text = "+";
            this.rjButtonAddition.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButtonAddition.UseCompatibleTextRendering = true;
            this.rjButtonAddition.UseVisualStyleBackColor = false;
            this.rjButtonAddition.Click += new System.EventHandler(this.button_Click);
            // 
            // rjButtonSubstraction
            // 
            this.rjButtonSubstraction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButtonSubstraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButtonSubstraction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButtonSubstraction.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButtonSubstraction.BorderRadius = 40;
            this.rjButtonSubstraction.BorderSize = 2;
            this.rjButtonSubstraction.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButtonSubstraction.FlatAppearance.BorderSize = 0;
            this.rjButtonSubstraction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.rjButtonSubstraction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButtonSubstraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonSubstraction.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonSubstraction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButtonSubstraction.Location = new System.Drawing.Point(298, 344);
            this.rjButtonSubstraction.Name = "rjButtonSubstraction";
            this.rjButtonSubstraction.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.rjButtonSubstraction.Size = new System.Drawing.Size(80, 80);
            this.rjButtonSubstraction.TabIndex = 35;
            this.rjButtonSubstraction.Text = "-";
            this.rjButtonSubstraction.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButtonSubstraction.UseCompatibleTextRendering = true;
            this.rjButtonSubstraction.UseVisualStyleBackColor = false;
            this.rjButtonSubstraction.Click += new System.EventHandler(this.button_Click);
            // 
            // rjButtonMultiplication
            // 
            this.rjButtonMultiplication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButtonMultiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButtonMultiplication.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButtonMultiplication.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButtonMultiplication.BorderRadius = 40;
            this.rjButtonMultiplication.BorderSize = 2;
            this.rjButtonMultiplication.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButtonMultiplication.FlatAppearance.BorderSize = 0;
            this.rjButtonMultiplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.rjButtonMultiplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButtonMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonMultiplication.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonMultiplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButtonMultiplication.Location = new System.Drawing.Point(298, 430);
            this.rjButtonMultiplication.Name = "rjButtonMultiplication";
            this.rjButtonMultiplication.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.rjButtonMultiplication.Size = new System.Drawing.Size(80, 80);
            this.rjButtonMultiplication.TabIndex = 34;
            this.rjButtonMultiplication.Text = "x";
            this.rjButtonMultiplication.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButtonMultiplication.UseCompatibleTextRendering = true;
            this.rjButtonMultiplication.UseVisualStyleBackColor = false;
            this.rjButtonMultiplication.Click += new System.EventHandler(this.button_Click);
            // 
            // rjButtonDivision
            // 
            this.rjButtonDivision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButtonDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButtonDivision.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButtonDivision.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButtonDivision.BorderRadius = 40;
            this.rjButtonDivision.BorderSize = 2;
            this.rjButtonDivision.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButtonDivision.FlatAppearance.BorderSize = 0;
            this.rjButtonDivision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.rjButtonDivision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButtonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonDivision.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonDivision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButtonDivision.Location = new System.Drawing.Point(298, 516);
            this.rjButtonDivision.Name = "rjButtonDivision";
            this.rjButtonDivision.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.rjButtonDivision.Size = new System.Drawing.Size(80, 80);
            this.rjButtonDivision.TabIndex = 33;
            this.rjButtonDivision.Text = "÷";
            this.rjButtonDivision.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButtonDivision.UseCompatibleTextRendering = true;
            this.rjButtonDivision.UseVisualStyleBackColor = false;
            this.rjButtonDivision.Click += new System.EventHandler(this.button_Click);
            // 
            // rjButtonDecimal
            // 
            this.rjButtonDecimal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButtonDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButtonDecimal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButtonDecimal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButtonDecimal.BorderRadius = 40;
            this.rjButtonDecimal.BorderSize = 2;
            this.rjButtonDecimal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButtonDecimal.FlatAppearance.BorderSize = 0;
            this.rjButtonDecimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(222)))));
            this.rjButtonDecimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButtonDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonDecimal.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonDecimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButtonDecimal.Location = new System.Drawing.Point(126, 516);
            this.rjButtonDecimal.Name = "rjButtonDecimal";
            this.rjButtonDecimal.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.rjButtonDecimal.Size = new System.Drawing.Size(80, 80);
            this.rjButtonDecimal.TabIndex = 32;
            this.rjButtonDecimal.Text = ".";
            this.rjButtonDecimal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButtonDecimal.UseCompatibleTextRendering = true;
            this.rjButtonDecimal.UseVisualStyleBackColor = false;
            this.rjButtonDecimal.Click += new System.EventHandler(this.button_Click);
            // 
            // rjButton0
            // 
            this.rjButton0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton0.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton0.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButton0.BorderRadius = 40;
            this.rjButton0.BorderSize = 2;
            this.rjButton0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButton0.FlatAppearance.BorderSize = 0;
            this.rjButton0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(222)))));
            this.rjButton0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButton0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton0.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButton0.Location = new System.Drawing.Point(40, 516);
            this.rjButton0.Name = "rjButton0";
            this.rjButton0.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.rjButton0.Size = new System.Drawing.Size(80, 80);
            this.rjButton0.TabIndex = 31;
            this.rjButton0.Text = "0";
            this.rjButton0.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButton0.UseCompatibleTextRendering = true;
            this.rjButton0.UseVisualStyleBackColor = false;
            this.rjButton0.Click += new System.EventHandler(this.button_Click);
            // 
            // rjButton9
            // 
            this.rjButton9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButton9.BorderRadius = 40;
            this.rjButton9.BorderSize = 2;
            this.rjButton9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButton9.FlatAppearance.BorderSize = 0;
            this.rjButton9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(222)))));
            this.rjButton9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton9.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButton9.Location = new System.Drawing.Point(212, 258);
            this.rjButton9.Name = "rjButton9";
            this.rjButton9.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.rjButton9.Size = new System.Drawing.Size(80, 80);
            this.rjButton9.TabIndex = 30;
            this.rjButton9.Text = "9";
            this.rjButton9.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButton9.UseCompatibleTextRendering = true;
            this.rjButton9.UseVisualStyleBackColor = false;
            this.rjButton9.Click += new System.EventHandler(this.button_Click);
            // 
            // rjButton8
            // 
            this.rjButton8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButton8.BorderRadius = 40;
            this.rjButton8.BorderSize = 2;
            this.rjButton8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButton8.FlatAppearance.BorderSize = 0;
            this.rjButton8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(222)))));
            this.rjButton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton8.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButton8.Location = new System.Drawing.Point(126, 258);
            this.rjButton8.Name = "rjButton8";
            this.rjButton8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.rjButton8.Size = new System.Drawing.Size(80, 80);
            this.rjButton8.TabIndex = 29;
            this.rjButton8.Text = "8";
            this.rjButton8.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButton8.UseCompatibleTextRendering = true;
            this.rjButton8.UseVisualStyleBackColor = false;
            this.rjButton8.Click += new System.EventHandler(this.button_Click);
            // 
            // rjButton7
            // 
            this.rjButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButton7.BorderRadius = 40;
            this.rjButton7.BorderSize = 2;
            this.rjButton7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButton7.FlatAppearance.BorderSize = 0;
            this.rjButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(222)))));
            this.rjButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton7.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButton7.Location = new System.Drawing.Point(40, 258);
            this.rjButton7.Name = "rjButton7";
            this.rjButton7.Padding = new System.Windows.Forms.Padding(0, 5, 2, 0);
            this.rjButton7.Size = new System.Drawing.Size(80, 80);
            this.rjButton7.TabIndex = 28;
            this.rjButton7.Text = "7";
            this.rjButton7.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButton7.UseCompatibleTextRendering = true;
            this.rjButton7.UseVisualStyleBackColor = false;
            this.rjButton7.Click += new System.EventHandler(this.button_Click);
            // 
            // rjButton6
            // 
            this.rjButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButton6.BorderRadius = 40;
            this.rjButton6.BorderSize = 2;
            this.rjButton6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButton6.FlatAppearance.BorderSize = 0;
            this.rjButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(222)))));
            this.rjButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton6.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButton6.Location = new System.Drawing.Point(212, 344);
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.rjButton6.Size = new System.Drawing.Size(80, 80);
            this.rjButton6.TabIndex = 27;
            this.rjButton6.Text = "6";
            this.rjButton6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButton6.UseCompatibleTextRendering = true;
            this.rjButton6.UseVisualStyleBackColor = false;
            this.rjButton6.Click += new System.EventHandler(this.button_Click);
            // 
            // rjButton5
            // 
            this.rjButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButton5.BorderRadius = 40;
            this.rjButton5.BorderSize = 2;
            this.rjButton5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(222)))));
            this.rjButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButton5.Location = new System.Drawing.Point(126, 344);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Padding = new System.Windows.Forms.Padding(0, 5, 2, 0);
            this.rjButton5.Size = new System.Drawing.Size(80, 80);
            this.rjButton5.TabIndex = 26;
            this.rjButton5.Text = "5";
            this.rjButton5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButton5.UseCompatibleTextRendering = true;
            this.rjButton5.UseVisualStyleBackColor = false;
            this.rjButton5.Click += new System.EventHandler(this.button_Click);
            // 
            // rjButton4
            // 
            this.rjButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButton4.BorderRadius = 40;
            this.rjButton4.BorderSize = 2;
            this.rjButton4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(222)))));
            this.rjButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButton4.Location = new System.Drawing.Point(40, 344);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Padding = new System.Windows.Forms.Padding(0, 5, 2, 0);
            this.rjButton4.Size = new System.Drawing.Size(80, 80);
            this.rjButton4.TabIndex = 25;
            this.rjButton4.Text = "4";
            this.rjButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButton4.UseCompatibleTextRendering = true;
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.button_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButton3.BorderRadius = 40;
            this.rjButton3.BorderSize = 2;
            this.rjButton3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(222)))));
            this.rjButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButton3.Location = new System.Drawing.Point(212, 430);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Padding = new System.Windows.Forms.Padding(0, 5, 2, 0);
            this.rjButton3.Size = new System.Drawing.Size(80, 80);
            this.rjButton3.TabIndex = 24;
            this.rjButton3.Text = "3";
            this.rjButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButton3.UseCompatibleTextRendering = true;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.button_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButton2.BorderRadius = 40;
            this.rjButton2.BorderSize = 2;
            this.rjButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(222)))));
            this.rjButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButton2.Location = new System.Drawing.Point(126, 430);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.rjButton2.Size = new System.Drawing.Size(80, 80);
            this.rjButton2.TabIndex = 23;
            this.rjButton2.Text = "2";
            this.rjButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButton2.UseCompatibleTextRendering = true;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.button_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rjButton1.BorderRadius = 40;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(222)))));
            this.rjButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Be Vietnam Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButton1.Location = new System.Drawing.Point(40, 430);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.rjButton1.Size = new System.Drawing.Size(80, 80);
            this.rjButton1.TabIndex = 22;
            this.rjButton1.Text = "1";
            this.rjButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rjButton1.UseCompatibleTextRendering = true;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(424, 635);
            this.Controls.Add(this.rjButtonClearEntry);
            this.Controls.Add(this.rjButtonClear);
            this.Controls.Add(this.rjButtonEquals);
            this.Controls.Add(this.rjButtonRightBracket);
            this.Controls.Add(this.rjButtonLeftBracket);
            this.Controls.Add(this.rjButtonAddition);
            this.Controls.Add(this.rjButtonSubstraction);
            this.Controls.Add(this.rjButtonMultiplication);
            this.Controls.Add(this.rjButtonDivision);
            this.Controls.Add(this.rjButtonDecimal);
            this.Controls.Add(this.rjButton0);
            this.Controls.Add(this.rjButton9);
            this.Controls.Add(this.rjButton8);
            this.Controls.Add(this.rjButton7);
            this.Controls.Add(this.rjButton6);
            this.Controls.Add(this.rjButton5);
            this.Controls.Add(this.rjButton4);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxOutput;
        private RJButton rjButton1;
        private RJButton rjButton2;
        private RJButton rjButton3;
        private RJButton rjButton4;
        private RJButton rjButton5;
        private RJButton rjButton6;
        private RJButton rjButton7;
        private RJButton rjButton8;
        private RJButton rjButton9;
        private RJButton rjButton0;
        private RJButton rjButtonDecimal;
        private RJButton rjButtonDivision;
        private RJButton rjButtonMultiplication;
        private RJButton rjButtonSubstraction;
        private RJButton rjButtonAddition;
        private RJButton rjButtonLeftBracket;
        private RJButton rjButtonRightBracket;
        private RJButton rjButtonEquals;
        private RJButton rjButtonClear;
        private RJButton rjButtonClearEntry;
        private System.Windows.Forms.Panel panel1;
    }
}

