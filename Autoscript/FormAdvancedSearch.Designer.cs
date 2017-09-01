namespace Autoscript
{
    partial class FormAdvancedSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fctbSearchLine = new FastColoredTextBoxNS.FastColoredTextBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.Number = new Autoscript.DataGridViewRichTextBoxColumn();
            this.Tema = new Autoscript.DataGridViewRichTextBoxColumn();
            this.Zadacha = new Autoscript.DataGridViewRichTextBoxColumn();
            this.Script = new Autoscript.DataGridViewRichTextBoxColumn();
            this.Example_ZnO = new Autoscript.DataGridViewRichTextBoxColumn();
            this.Date_create = new Autoscript.DataGridViewRichTextBoxColumn();
            this.Date_change = new Autoscript.DataGridViewRichTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbSearchLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Autoscript.Properties.Resources.find_16x16;
            this.btnSearch.Location = new System.Drawing.Point(403, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 24);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Найти";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fctbSearchLine);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvResult);
            this.splitContainer1.Size = new System.Drawing.Size(739, 568);
            this.splitContainer1.SplitterDistance = 68;
            this.splitContainer1.TabIndex = 2;
            // 
            // fctbSearchLine
            // 
            this.fctbSearchLine.AllowDrop = false;
            this.fctbSearchLine.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctbSearchLine.AutoIndentCharsPatterns = "";
            this.fctbSearchLine.AutoScrollMinSize = new System.Drawing.Size(2, 17);
            this.fctbSearchLine.BackBrush = null;
            this.fctbSearchLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctbSearchLine.CharHeight = 17;
            this.fctbSearchLine.CharWidth = 8;
            this.fctbSearchLine.CommentPrefix = "--";
            this.fctbSearchLine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbSearchLine.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fctbSearchLine.Font = new System.Drawing.Font("Consolas", 11F);
            this.fctbSearchLine.IndentBackColor = System.Drawing.SystemColors.Control;
            this.fctbSearchLine.IsReplaceMode = false;
            this.fctbSearchLine.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctbSearchLine.LeftBracket = '(';
            this.fctbSearchLine.Location = new System.Drawing.Point(246, 26);
            this.fctbSearchLine.Multiline = false;
            this.fctbSearchLine.Name = "fctbSearchLine";
            this.fctbSearchLine.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbSearchLine.RightBracket = ')';
            this.fctbSearchLine.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbSearchLine.ServiceColors = null;
            this.fctbSearchLine.ShowLineNumbers = false;
            this.fctbSearchLine.ShowScrollBars = false;
            this.fctbSearchLine.Size = new System.Drawing.Size(151, 23);
            this.fctbSearchLine.TabIndex = 0;
            this.fctbSearchLine.WordWrapAutoIndent = false;
            this.fctbSearchLine.Zoom = 100;
            this.fctbSearchLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fctbSearchLine_KeyDown);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.Number,
                this.Tema,
                this.Zadacha,
                this.Script,
                this.Example_ZnO,
                this.Date_create,
                this.Date_change
            });
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.Location = new System.Drawing.Point(0, 0);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowTemplate.Height = 60;
            this.dgvResult.Size = new System.Drawing.Size(739, 496);
            this.dgvResult.TabIndex = 1;
            this.dgvResult.Click += new System.EventHandler(this.dgvResult_Click);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.DefaultCellStyle = dataGridViewCellStyle1;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "N";
            this.Number.Name = "Number";
            // 
            // Tema
            // 
            this.Tema.DataPropertyName = "Tema";
            this.Tema.HeaderText = "Тема";
            this.Tema.Name = "Tema";
            // 
            // Zadacha
            // 
            this.Zadacha.DataPropertyName = "Zadacha";
            this.Zadacha.HeaderText = "Задача";
            this.Zadacha.Name = "Zadacha";
            // 
            // Script
            // 
            this.Script.DataPropertyName = "Script";
            this.Script.HeaderText = "Решение";
            this.Script.Name = "Script";
            // 
            // Example_ZnO
            // 
            this.Example_ZnO.DataPropertyName = "Example_ZnO";
            this.Example_ZnO.HeaderText = "Пример";
            this.Example_ZnO.Name = "Example_ZnO";
            // 
            // Date_create
            // 
            this.Date_create.DataPropertyName = "Date_create";
            this.Date_create.HeaderText = "Создан";
            this.Date_create.Name = "Date_create";
            // 
            // Date_change
            // 
            this.Date_change.DataPropertyName = "Date_change";
            this.Date_change.HeaderText = "Изменён";
            this.Date_change.Name = "Date_change";
            // 
            // FormAdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 568);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormAdvancedSearch";
            this.Text = "Расширенный поиск";
            this.Load += new System.EventHandler(this.FormAdvancedSearch_Load);
            this.SizeChanged += new System.EventHandler(this.FormAdvancedSearch_SizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctbSearchLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private FastColoredTextBoxNS.FastColoredTextBox fctbSearchLine;
        private System.Windows.Forms.DataGridView dgvResult;
        private DataGridViewRichTextBoxColumn Number;
        private DataGridViewRichTextBoxColumn Tema;
        private DataGridViewRichTextBoxColumn Zadacha;
        private DataGridViewRichTextBoxColumn Script;
        private DataGridViewRichTextBoxColumn Example_ZnO;
        private DataGridViewRichTextBoxColumn Date_create;
        private DataGridViewRichTextBoxColumn Date_change;
    }
}