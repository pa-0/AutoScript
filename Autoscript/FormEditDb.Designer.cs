using System.Windows.Forms;
using System.ComponentModel;

namespace Autoscript
{
    partial class FormEditDb
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.groupTextBoxes = new System.Windows.Forms.GroupBox();
            this.fctbDateChange = new FastColoredTextBoxNS.FastColoredTextBox();
            this.contextMenuOfTextBox1 = new Autoscript.ContextMenuOfTextBox();
            this.fctbDateCreate = new FastColoredTextBoxNS.FastColoredTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDateCreate = new System.Windows.Forms.Label();
            this.Topics = new Autoscript.FilteredComboBox();
            this.fctbNum = new FastColoredTextBoxNS.FastColoredTextBox();
            this.fctbExamples = new FastColoredTextBoxNS.FastColoredTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fctbQuestion = new FastColoredTextBoxNS.FastColoredTextBox();
            this.fctbAnswer = new FastColoredTextBoxNS.FastColoredTextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblTopics = new System.Windows.Forms.Label();
            this.btnNewRow = new System.Windows.Forms.Button();
            this.btnSaveChanged = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCompactAndRepair = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupButtons = new System.Windows.Forms.GroupBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.groupTextBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbDateChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbDateCreate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbExamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupButtons.SuspendLayout();

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 =
                new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 =
                new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 =
                new System.Windows.Forms.DataGridViewCellStyle();


            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupTextBoxes
            // 
            this.groupTextBoxes.Controls.Add(this.fctbDateChange);
            this.groupTextBoxes.Controls.Add(this.fctbDateCreate);
            this.groupTextBoxes.Controls.Add(this.label1);
            this.groupTextBoxes.Controls.Add(this.lblDateCreate);
            this.groupTextBoxes.Controls.Add(this.Topics);
            this.groupTextBoxes.Controls.Add(this.fctbNum);
            this.groupTextBoxes.Controls.Add(this.fctbExamples);
            this.groupTextBoxes.Controls.Add(this.label6);
            this.groupTextBoxes.Controls.Add(this.label4);
            this.groupTextBoxes.Controls.Add(this.fctbQuestion);
            this.groupTextBoxes.Controls.Add(this.fctbAnswer);
            this.groupTextBoxes.Controls.Add(this.lblQuestion);
            this.groupTextBoxes.Controls.Add(this.lblAnswer);
            this.groupTextBoxes.Controls.Add(this.lblTopics);
            this.groupTextBoxes.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTextBoxes.Location = new System.Drawing.Point(0, 0);
            this.groupTextBoxes.Name = "groupTextBoxes";
            this.groupTextBoxes.Size = new System.Drawing.Size(890, 201);
            this.groupTextBoxes.TabIndex = 1;
            this.groupTextBoxes.TabStop = false;
            // 
            // fctbDateChange
            // 
            this.fctbDateChange.AllowDrop = false;
            this.fctbDateChange.AutoCompleteBracketsList = new char[] {
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
            this.fctbDateChange.AutoIndentCharsPatterns = "";
            this.fctbDateChange.AutoScrollMinSize = new System.Drawing.Size(0, 17);
            this.fctbDateChange.BackBrush = null;
            this.fctbDateChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctbDateChange.CharHeight = 17;
            this.fctbDateChange.CharWidth = 8;
            this.fctbDateChange.CommentPrefix = "--";
            this.fctbDateChange.ContextMenuStrip = this.contextMenuOfTextBox1;
            this.fctbDateChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbDateChange.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fctbDateChange.Font = new System.Drawing.Font("Consolas", 11F);
            this.fctbDateChange.IndentBackColor = System.Drawing.SystemColors.Control;
            this.fctbDateChange.IsReplaceMode = false;
            this.fctbDateChange.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctbDateChange.LeftBracket = '(';
            this.fctbDateChange.Location = new System.Drawing.Point(58, 172);
            this.fctbDateChange.Name = "fctbDateChange";
            this.fctbDateChange.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbDateChange.ReadOnly = true;
            this.fctbDateChange.RightBracket = ')';
            this.fctbDateChange.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbDateChange.ServiceColors = null;
            this.fctbDateChange.ShowLineNumbers = false;
            this.fctbDateChange.Size = new System.Drawing.Size(99, 23);
            this.fctbDateChange.TabIndex = 31;
            this.fctbDateChange.WordWrap = true;
            this.fctbDateChange.Zoom = 100;
            // 
            // contextMenuOfTextBox1
            // 
            this.contextMenuOfTextBox1.Name = "contextMenu";
            this.contextMenuOfTextBox1.Size = new System.Drawing.Size(186, 198);
            // 
            // fctbDateCreate
            // 
            this.fctbDateCreate.AllowDrop = false;
            this.fctbDateCreate.AutoCompleteBracketsList = new char[] {
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
            this.fctbDateCreate.AutoIndentCharsPatterns = "";
            this.fctbDateCreate.AutoScrollMinSize = new System.Drawing.Size(0, 17);
            this.fctbDateCreate.BackBrush = null;
            this.fctbDateCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctbDateCreate.CharHeight = 17;
            this.fctbDateCreate.CharWidth = 8;
            this.fctbDateCreate.CommentPrefix = "--";
            this.fctbDateCreate.ContextMenuStrip = this.contextMenuOfTextBox1;
            this.fctbDateCreate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbDateCreate.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fctbDateCreate.Font = new System.Drawing.Font("Consolas", 11F);
            this.fctbDateCreate.IndentBackColor = System.Drawing.SystemColors.Control;
            this.fctbDateCreate.IsReplaceMode = false;
            this.fctbDateCreate.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctbDateCreate.LeftBracket = '(';
            this.fctbDateCreate.Location = new System.Drawing.Point(58, 145);
            this.fctbDateCreate.Name = "fctbDateCreate";
            this.fctbDateCreate.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbDateCreate.ReadOnly = true;
            this.fctbDateCreate.RightBracket = ')';
            this.fctbDateCreate.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbDateCreate.ServiceColors = null;
            this.fctbDateCreate.ShowLineNumbers = false;
            this.fctbDateCreate.Size = new System.Drawing.Size(99, 23);
            this.fctbDateCreate.TabIndex = 30;
            this.fctbDateCreate.WordWrap = true;
            this.fctbDateCreate.Zoom = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Изменён";
            // 
            // lblDateCreate
            // 
            this.lblDateCreate.AutoSize = true;
            this.lblDateCreate.Location = new System.Drawing.Point(15, 148);
            this.lblDateCreate.Name = "lblDateCreate";
            this.lblDateCreate.Size = new System.Drawing.Size(44, 13);
            this.lblDateCreate.TabIndex = 28;
            this.lblDateCreate.Text = "Создан";
            // 
            // Topics
            // 
            this.Topics.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Topics.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Topics.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Topics.FormattingEnabled = true;
            this.Topics.Location = new System.Drawing.Point(6, 25);
            this.Topics.Name = "Topics";
            this.Topics.Size = new System.Drawing.Size(151, 24);
            this.Topics.Sorted = true;
            this.Topics.TabIndex = 0;
            this.Topics.SelectedIndexChanged += new System.EventHandler(this.Topics_SelectedIndexChanged);
            // 
            // fctbNum
            // 
            this.fctbNum.AllowDrop = false;
            this.fctbNum.AutoCompleteBracketsList = new char[] {
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
            this.fctbNum.AutoIndentCharsPatterns = "";
            this.fctbNum.AutoScrollMinSize = new System.Drawing.Size(0, 17);
            this.fctbNum.BackBrush = null;
            this.fctbNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctbNum.CharHeight = 17;
            this.fctbNum.CharWidth = 8;
            this.fctbNum.CommentPrefix = "--";
            this.fctbNum.ContextMenuStrip = this.contextMenuOfTextBox1;
            this.fctbNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbNum.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fctbNum.Font = new System.Drawing.Font("Consolas", 11F);
            this.fctbNum.IndentBackColor = System.Drawing.SystemColors.Control;
            this.fctbNum.IsReplaceMode = false;
            this.fctbNum.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctbNum.LeftBracket = '(';
            this.fctbNum.Location = new System.Drawing.Point(58, 118);
            this.fctbNum.Name = "fctbNum";
            this.fctbNum.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbNum.ReadOnly = true;
            this.fctbNum.RightBracket = ')';
            this.fctbNum.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbNum.ServiceColors = null;
            this.fctbNum.ShowLineNumbers = false;
            this.fctbNum.Size = new System.Drawing.Size(99, 23);
            this.fctbNum.TabIndex = 21;
            this.fctbNum.WordWrap = true;
            this.fctbNum.Zoom = 100;
            // 
            // fctbExamples
            // 
            this.fctbExamples.AllowDrop = false;
            this.fctbExamples.AutoCompleteBracketsList = new char[] {
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
            this.fctbExamples.AutoIndentCharsPatterns = "";
            this.fctbExamples.AutoScrollMinSize = new System.Drawing.Size(2, 17);
            this.fctbExamples.BackBrush = null;
            this.fctbExamples.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctbExamples.CharHeight = 17;
            this.fctbExamples.CharWidth = 8;
            this.fctbExamples.CommentPrefix = "--";
            this.fctbExamples.ContextMenuStrip = this.contextMenuOfTextBox1;
            this.fctbExamples.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbExamples.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fctbExamples.Font = new System.Drawing.Font("Consolas", 11F);
            this.fctbExamples.IndentBackColor = System.Drawing.SystemColors.Control;
            this.fctbExamples.IsReplaceMode = false;
            this.fctbExamples.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctbExamples.LeftBracket = '(';
            this.fctbExamples.Location = new System.Drawing.Point(6, 80);
            this.fctbExamples.Multiline = false;
            this.fctbExamples.Name = "fctbExamples";
            this.fctbExamples.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbExamples.RightBracket = ')';
            this.fctbExamples.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbExamples.ServiceColors = null;
            this.fctbExamples.ShowLineNumbers = false;
            this.fctbExamples.ShowScrollBars = false;
            this.fctbExamples.Size = new System.Drawing.Size(151, 23);
            this.fctbExamples.TabIndex = 3;
            this.fctbExamples.WordWrapAutoIndent = false;
            this.fctbExamples.Zoom = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "№ п/п";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Примеры обращений";
            // 
            // fctbQuestion
            // 
            this.fctbQuestion.AllowDrop = false;
            this.fctbQuestion.AutoCompleteBracketsList = new char[] {
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
            this.fctbQuestion.AutoIndentCharsPatterns = "";
            this.fctbQuestion.AutoScrollMinSize = new System.Drawing.Size(0, 17);
            this.fctbQuestion.BackBrush = null;
            this.fctbQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctbQuestion.CharHeight = 17;
            this.fctbQuestion.CharWidth = 8;
            this.fctbQuestion.CommentPrefix = "--";
            this.fctbQuestion.ContextMenuStrip = this.contextMenuOfTextBox1;
            this.fctbQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbQuestion.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fctbQuestion.Font = new System.Drawing.Font("Consolas", 11F);
            this.fctbQuestion.IndentBackColor = System.Drawing.SystemColors.Control;
            this.fctbQuestion.IsReplaceMode = false;
            this.fctbQuestion.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctbQuestion.LeftBracket = '(';
            this.fctbQuestion.Location = new System.Drawing.Point(171, 25);
            this.fctbQuestion.Name = "fctbQuestion";
            this.fctbQuestion.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbQuestion.RightBracket = ')';
            this.fctbQuestion.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbQuestion.ServiceColors = null;
            this.fctbQuestion.ShowLineNumbers = false;
            this.fctbQuestion.Size = new System.Drawing.Size(187, 170);
            this.fctbQuestion.TabIndex = 1;
            this.fctbQuestion.WordWrap = true;
            this.fctbQuestion.Zoom = 100;
            // 
            // fctbAnswer
            // 
            this.fctbAnswer.AutoCompleteBracketsList = new char[] {
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
            this.fctbAnswer.AutoIndentCharsPatterns = "";
            this.fctbAnswer.AutoScrollMinSize = new System.Drawing.Size(0, 17);
            this.fctbAnswer.BackBrush = null;
            this.fctbAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctbAnswer.CharHeight = 17;
            this.fctbAnswer.CharWidth = 8;
            this.fctbAnswer.CommentPrefix = "--";
            this.fctbAnswer.ContextMenuStrip = this.contextMenuOfTextBox1;
            this.fctbAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbAnswer.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fctbAnswer.Font = new System.Drawing.Font("Consolas", 11F);
            this.fctbAnswer.IndentBackColor = System.Drawing.SystemColors.Control;
            this.fctbAnswer.IsReplaceMode = false;
            this.fctbAnswer.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctbAnswer.LeftBracket = '(';
            this.fctbAnswer.Location = new System.Drawing.Point(364, 25);
            this.fctbAnswer.Name = "fctbAnswer";
            this.fctbAnswer.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbAnswer.RightBracket = ')';
            this.fctbAnswer.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbAnswer.ServiceColors = null;
            this.fctbAnswer.ShowLineNumbers = false;
            this.fctbAnswer.Size = new System.Drawing.Size(514, 170);
            this.fctbAnswer.TabIndex = 2;
            this.fctbAnswer.WordWrap = true;
            this.fctbAnswer.Zoom = 100;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(173, 9);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(43, 13);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "Задача";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(367, 9);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(52, 13);
            this.lblAnswer.TabIndex = 11;
            this.lblAnswer.Text = "Решение";
            // 
            // lblTopics
            // 
            this.lblTopics.AutoSize = true;
            this.lblTopics.Location = new System.Drawing.Point(9, 9);
            this.lblTopics.Name = "lblTopics";
            this.lblTopics.Size = new System.Drawing.Size(34, 13);
            this.lblTopics.TabIndex = 9;
            this.lblTopics.Text = "Тема";
            // 
            // btnNewRow
            // 
            this.btnNewRow.Location = new System.Drawing.Point(6, 10);
            this.btnNewRow.Name = "btnNewRow";
            this.btnNewRow.Size = new System.Drawing.Size(127, 25);
            this.btnNewRow.TabIndex = 6;
            this.btnNewRow.Text = "Добавить запись";
            this.btnNewRow.UseVisualStyleBackColor = true;
            this.btnNewRow.Click += new System.EventHandler(this.btnNewRow_Click);
            // 
            // btnSaveChanged
            // 
            this.btnSaveChanged.Image = global::Autoscript.Properties.Resources.copy_16x16;
            this.btnSaveChanged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChanged.Location = new System.Drawing.Point(139, 10);
            this.btnSaveChanged.Name = "btnSaveChanged";
            this.btnSaveChanged.Size = new System.Drawing.Size(127, 25);
            this.btnSaveChanged.TabIndex = 7;
            this.btnSaveChanged.Text = "Сохранить";
            this.btnSaveChanged.UseVisualStyleBackColor = true;
            this.btnSaveChanged.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Autoscript.Properties.Resources.cut_16x16;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(272, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 25);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Удалить запись";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(406, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 25);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Очистить форму";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCompactAndRepair
            // 
            this.btnCompactAndRepair.Location = new System.Drawing.Point(623, 10);
            this.btnCompactAndRepair.Name = "btnCompactAndRepair";
            this.btnCompactAndRepair.Size = new System.Drawing.Size(149, 25);
            this.btnCompactAndRepair.TabIndex = 19;
            this.btnCompactAndRepair.Text = "Сжать и восстановить БД";
            this.btnCompactAndRepair.UseVisualStyleBackColor = true;
            this.btnCompactAndRepair.Click += new System.EventHandler(this.btnCompactAndRepair_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.groupButtons);
            this.splitContainer1.Panel1.Controls.Add(this.groupTextBoxes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv1);
            this.splitContainer1.Size = new System.Drawing.Size(890, 655);
            this.splitContainer1.SplitterDistance = 238;
            this.splitContainer1.TabIndex = 12;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // groupButtons
            // 
            this.groupButtons.Controls.Add(this.btnNewRow);
            this.groupButtons.Controls.Add(this.btnSaveChanged);
            this.groupButtons.Controls.Add(this.btnCompactAndRepair);
            this.groupButtons.Controls.Add(this.btnClear);
            this.groupButtons.Controls.Add(this.btnDelete);
            this.groupButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupButtons.Location = new System.Drawing.Point(0, 199);
            this.groupButtons.Name = "groupButtons";
            this.groupButtons.Size = new System.Drawing.Size(890, 39);
            this.groupButtons.TabIndex = 1;
            this.groupButtons.TabStop = false;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.Location = new System.Drawing.Point(0, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Size = new System.Drawing.Size(890, 413);
            this.dgv1.TabIndex = 0;
            this.dgv1.Click += new System.EventHandler(this.dgv1_Click);

            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.RowsDefaultCellStyle = dataGridViewCellStyle1;

            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;

            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgv1.RowTemplate.Height = 48;
            this.dgv1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;

            // 
            // FormEditDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 655);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Name = "FormEditDb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование БД скриптов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEditDb_Load);
            this.SizeChanged += new System.EventHandler(this.FormEditDb_SizeChanged);
            this.groupTextBoxes.ResumeLayout(false);
            this.groupTextBoxes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbDateChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbDateCreate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbExamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbAnswer)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupTextBoxes;
        private Button btnDelete;
        private Label lblQuestion;
        private Label lblAnswer;
        private Button btnSaveChanged;
        private Button btnNewRow;
        private Label lblTopics;
        private Label label4;
        private Label label6;
        private Button btnClear;
        private FastColoredTextBoxNS.FastColoredTextBox fctbQuestion;
        private FastColoredTextBoxNS.FastColoredTextBox fctbAnswer;
        private Button btnCompactAndRepair;
        private FastColoredTextBoxNS.FastColoredTextBox fctbNum;
        private FastColoredTextBoxNS.FastColoredTextBox fctbExamples;
        private FilteredComboBox Topics;
        private SplitContainer splitContainer1;
        private GroupBox groupButtons;
        private ContextMenuOfTextBox contextMenuOfTextBox1;
        private Label label1;
        private Label lblDateCreate;
        private FastColoredTextBoxNS.FastColoredTextBox fctbDateChange;
        private FastColoredTextBoxNS.FastColoredTextBox fctbDateCreate;
        private DataGridView dgv1;
    }
}