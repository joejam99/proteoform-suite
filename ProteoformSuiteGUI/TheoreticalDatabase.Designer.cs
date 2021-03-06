﻿namespace ProteoformSuiteGUI
{
    partial class TheoreticalDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheoreticalDatabase));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_amendModNames = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_modTableFilter = new System.Windows.Forms.TextBox();
            this.btn_loadModNames = new System.Windows.Forms.Button();
            this.btn_saveModNames = new System.Windows.Forms.Button();
            this.btn_downloadUniProtPtmList = new System.Windows.Forms.Button();
            this.cb_limitLargePtmSets = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_totalTheoreticalProteoforms = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_modTypesToExclude = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tableFilter = new System.Windows.Forms.TextBox();
            this.cmb_loadTable = new System.Windows.Forms.ComboBox();
            this.dgv_loadFiles = new System.Windows.Forms.DataGridView();
            this.btn_addFiles = new System.Windows.Forms.Button();
            this.btn_clearFiles = new System.Windows.Forms.Button();
            this.ckbx_combineTheoreticalsByMass = new System.Windows.Forms.CheckBox();
            this.ckbx_combineIdenticalSequences = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nUD_MinPeptideLength = new System.Windows.Forms.NumericUpDown();
            this.btn_Make_Databases = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbx_DisplayWhichDB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nUD_NumDecoyDBs = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nUD_MaxPTMs = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_NeuCode_Hv = new System.Windows.Forms.RadioButton();
            this.btn_NeuCode_Lt = new System.Windows.Forms.RadioButton();
            this.btn_NaturalIsotopes = new System.Windows.Forms.RadioButton();
            this.ckbx_Meth_Cleaved = new System.Windows.Forms.CheckBox();
            this.ckbx_Carbam = new System.Windows.Forms.CheckBox();
            this.ckbx_OxidMeth = new System.Windows.Forms.CheckBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgv_Database = new System.Windows.Forms.DataGridView();
            this.dgv_unlocalizedModifications = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loadFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MinPeptideLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_NumDecoyDBs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MaxPTMs)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_unlocalizedModifications)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.btn_downloadUniProtPtmList);
            this.splitContainer1.Panel1.Controls.Add(this.cb_limitLargePtmSets);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.tb_totalTheoreticalProteoforms);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.tb_modTypesToExclude);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.tb_tableFilter);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_loadTable);
            this.splitContainer1.Panel1.Controls.Add(this.dgv_loadFiles);
            this.splitContainer1.Panel1.Controls.Add(this.btn_addFiles);
            this.splitContainer1.Panel1.Controls.Add(this.btn_clearFiles);
            this.splitContainer1.Panel1.Controls.Add(this.ckbx_combineTheoreticalsByMass);
            this.splitContainer1.Panel1.Controls.Add(this.ckbx_combineIdenticalSequences);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.nUD_MinPeptideLength);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Make_Databases);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.cmbx_DisplayWhichDB);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.nUD_NumDecoyDBs);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.nUD_MaxPTMs);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.ckbx_Meth_Cleaved);
            this.splitContainer1.Panel1.Controls.Add(this.ckbx_Carbam);
            this.splitContainer1.Panel1.Controls.Add(this.ckbx_OxidMeth);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Size = new System.Drawing.Size(1362, 741);
            this.splitContainer1.SplitterDistance = 452;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_amendModNames);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_modTableFilter);
            this.groupBox2.Controls.Add(this.btn_loadModNames);
            this.groupBox2.Controls.Add(this.btn_saveModNames);
            this.groupBox2.Location = new System.Drawing.Point(238, 534);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 150);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modification Names";
            // 
            // btn_amendModNames
            // 
            this.btn_amendModNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_amendModNames.Location = new System.Drawing.Point(4, 49);
            this.btn_amendModNames.Name = "btn_amendModNames";
            this.btn_amendModNames.Size = new System.Drawing.Size(189, 26);
            this.btn_amendModNames.TabIndex = 56;
            this.btn_amendModNames.Text = "Amend Stored Mod Names";
            this.btn_amendModNames.UseVisualStyleBackColor = true;
            this.btn_amendModNames.Click += new System.EventHandler(this.btn_amendModNames_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Modification Table Filter";
            // 
            // tb_modTableFilter
            // 
            this.tb_modTableFilter.Location = new System.Drawing.Point(6, 124);
            this.tb_modTableFilter.Name = "tb_modTableFilter";
            this.tb_modTableFilter.Size = new System.Drawing.Size(188, 20);
            this.tb_modTableFilter.TabIndex = 54;
            this.tb_modTableFilter.TextChanged += new System.EventHandler(this.tb_modTableFilter_TextChanged);
            // 
            // btn_loadModNames
            // 
            this.btn_loadModNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_loadModNames.Location = new System.Drawing.Point(6, 79);
            this.btn_loadModNames.Name = "btn_loadModNames";
            this.btn_loadModNames.Size = new System.Drawing.Size(189, 26);
            this.btn_loadModNames.TabIndex = 35;
            this.btn_loadModNames.Text = "Load Modification Names";
            this.btn_loadModNames.UseVisualStyleBackColor = true;
            this.btn_loadModNames.Click += new System.EventHandler(this.btn_loadModNames_Click);
            // 
            // btn_saveModNames
            // 
            this.btn_saveModNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_saveModNames.Location = new System.Drawing.Point(5, 19);
            this.btn_saveModNames.Name = "btn_saveModNames";
            this.btn_saveModNames.Size = new System.Drawing.Size(189, 26);
            this.btn_saveModNames.TabIndex = 34;
            this.btn_saveModNames.Text = "Save Modification Names";
            this.btn_saveModNames.UseVisualStyleBackColor = true;
            this.btn_saveModNames.Click += new System.EventHandler(this.btn_saveModNames_Click);
            // 
            // btn_downloadUniProtPtmList
            // 
            this.btn_downloadUniProtPtmList.Location = new System.Drawing.Point(156, 236);
            this.btn_downloadUniProtPtmList.Name = "btn_downloadUniProtPtmList";
            this.btn_downloadUniProtPtmList.Size = new System.Drawing.Size(122, 36);
            this.btn_downloadUniProtPtmList.TabIndex = 52;
            this.btn_downloadUniProtPtmList.Text = "Download UniProt PTM List";
            this.btn_downloadUniProtPtmList.UseVisualStyleBackColor = true;
            this.btn_downloadUniProtPtmList.Click += new System.EventHandler(this.btn_downloadUniProtPtmList_Click);
            // 
            // cb_limitLargePtmSets
            // 
            this.cb_limitLargePtmSets.AutoSize = true;
            this.cb_limitLargePtmSets.Checked = true;
            this.cb_limitLargePtmSets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_limitLargePtmSets.Location = new System.Drawing.Point(230, 511);
            this.cb_limitLargePtmSets.Name = "cb_limitLargePtmSets";
            this.cb_limitLargePtmSets.Size = new System.Drawing.Size(216, 17);
            this.cb_limitLargePtmSets.TabIndex = 51;
            this.cb_limitLargePtmSets.Text = "Limit Triples and Larger (Recommended)";
            this.cb_limitLargePtmSets.UseVisualStyleBackColor = true;
            this.cb_limitLargePtmSets.CheckedChanged += new System.EventHandler(this.cb_limitLargePtmSets_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 692);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total Theoretical Proteoforms";
            // 
            // tb_totalTheoreticalProteoforms
            // 
            this.tb_totalTheoreticalProteoforms.Location = new System.Drawing.Point(238, 713);
            this.tb_totalTheoreticalProteoforms.Margin = new System.Windows.Forms.Padding(2);
            this.tb_totalTheoreticalProteoforms.Name = "tb_totalTheoreticalProteoforms";
            this.tb_totalTheoreticalProteoforms.Size = new System.Drawing.Size(208, 20);
            this.tb_totalTheoreticalProteoforms.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 358);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Modification Types to Exclude";
            // 
            // tb_modTypesToExclude
            // 
            this.tb_modTypesToExclude.Location = new System.Drawing.Point(238, 373);
            this.tb_modTypesToExclude.Margin = new System.Windows.Forms.Padding(2);
            this.tb_modTypesToExclude.Name = "tb_modTypesToExclude";
            this.tb_modTypesToExclude.Size = new System.Drawing.Size(202, 20);
            this.tb_modTypesToExclude.TabIndex = 49;
            this.tb_modTypesToExclude.TextChanged += new System.EventHandler(this.tb_modTypesToExclude_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 626);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Database Filter";
            // 
            // tb_tableFilter
            // 
            this.tb_tableFilter.Location = new System.Drawing.Point(9, 642);
            this.tb_tableFilter.Name = "tb_tableFilter";
            this.tb_tableFilter.Size = new System.Drawing.Size(201, 20);
            this.tb_tableFilter.TabIndex = 47;
            this.tb_tableFilter.TextChanged += new System.EventHandler(this.tb_tableFilter_TextChanged);
            // 
            // cmb_loadTable
            // 
            this.cmb_loadTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_loadTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_loadTable.FormattingEnabled = true;
            this.cmb_loadTable.Location = new System.Drawing.Point(11, 10);
            this.cmb_loadTable.Name = "cmb_loadTable";
            this.cmb_loadTable.Size = new System.Drawing.Size(429, 28);
            this.cmb_loadTable.TabIndex = 34;
            this.cmb_loadTable.SelectedIndexChanged += new System.EventHandler(this.cmbx_DisplayWhichDB_SelectedIndexChanged);
            this.cmb_loadTable.TextChanged += new System.EventHandler(this.cmb_empty_TextChanged);
            // 
            // dgv_loadFiles
            // 
            this.dgv_loadFiles.AllowDrop = true;
            this.dgv_loadFiles.AllowUserToOrderColumns = true;
            this.dgv_loadFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loadFiles.Location = new System.Drawing.Point(11, 44);
            this.dgv_loadFiles.Name = "dgv_loadFiles";
            this.dgv_loadFiles.Size = new System.Drawing.Size(430, 186);
            this.dgv_loadFiles.TabIndex = 25;
            this.dgv_loadFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgv_loadFiles_DragDrop);
            this.dgv_loadFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgv_loadFiles_DragEnter);
            // 
            // btn_addFiles
            // 
            this.btn_addFiles.Location = new System.Drawing.Point(18, 236);
            this.btn_addFiles.Name = "btn_addFiles";
            this.btn_addFiles.Size = new System.Drawing.Size(122, 36);
            this.btn_addFiles.TabIndex = 24;
            this.btn_addFiles.Text = "Add";
            this.btn_addFiles.UseVisualStyleBackColor = true;
            this.btn_addFiles.Click += new System.EventHandler(this.btn_addFiles_Click);
            // 
            // btn_clearFiles
            // 
            this.btn_clearFiles.Location = new System.Drawing.Point(296, 236);
            this.btn_clearFiles.Name = "btn_clearFiles";
            this.btn_clearFiles.Size = new System.Drawing.Size(122, 36);
            this.btn_clearFiles.TabIndex = 23;
            this.btn_clearFiles.Text = "Clear";
            this.btn_clearFiles.UseVisualStyleBackColor = true;
            this.btn_clearFiles.Click += new System.EventHandler(this.btn_clearFiles_Click);
            // 
            // ckbx_combineTheoreticalsByMass
            // 
            this.ckbx_combineTheoreticalsByMass.AutoSize = true;
            this.ckbx_combineTheoreticalsByMass.Location = new System.Drawing.Point(7, 688);
            this.ckbx_combineTheoreticalsByMass.Margin = new System.Windows.Forms.Padding(2);
            this.ckbx_combineTheoreticalsByMass.Name = "ckbx_combineTheoreticalsByMass";
            this.ckbx_combineTheoreticalsByMass.Size = new System.Drawing.Size(225, 17);
            this.ckbx_combineTheoreticalsByMass.TabIndex = 22;
            this.ckbx_combineTheoreticalsByMass.Text = "Combine Theoretical Proteoforms By Mass";
            this.ckbx_combineTheoreticalsByMass.UseVisualStyleBackColor = true;
            this.ckbx_combineTheoreticalsByMass.CheckedChanged += new System.EventHandler(this.ckbx_combineTheoreticalsByMass_CheckedChanged);
            // 
            // ckbx_combineIdenticalSequences
            // 
            this.ckbx_combineIdenticalSequences.AutoSize = true;
            this.ckbx_combineIdenticalSequences.Location = new System.Drawing.Point(7, 667);
            this.ckbx_combineIdenticalSequences.Margin = new System.Windows.Forms.Padding(2);
            this.ckbx_combineIdenticalSequences.Name = "ckbx_combineIdenticalSequences";
            this.ckbx_combineIdenticalSequences.Size = new System.Drawing.Size(203, 17);
            this.ckbx_combineIdenticalSequences.TabIndex = 17;
            this.ckbx_combineIdenticalSequences.Text = "Combine Sequence-Identical Proteins";
            this.ckbx_combineIdenticalSequences.UseVisualStyleBackColor = true;
            this.ckbx_combineIdenticalSequences.CheckedChanged += new System.EventHandler(this.ckbx_combineIdenticalSequences_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 565);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Minimum Peptide Length";
            // 
            // nUD_MinPeptideLength
            // 
            this.nUD_MinPeptideLength.Location = new System.Drawing.Point(9, 562);
            this.nUD_MinPeptideLength.Margin = new System.Windows.Forms.Padding(2);
            this.nUD_MinPeptideLength.Name = "nUD_MinPeptideLength";
            this.nUD_MinPeptideLength.Size = new System.Drawing.Size(48, 20);
            this.nUD_MinPeptideLength.TabIndex = 15;
            this.nUD_MinPeptideLength.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nUD_MinPeptideLength.ValueChanged += new System.EventHandler(this.nUD_MinPeptideLength_ValueChanged);
            // 
            // btn_Make_Databases
            // 
            this.btn_Make_Databases.Location = new System.Drawing.Point(7, 713);
            this.btn_Make_Databases.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Make_Databases.Name = "btn_Make_Databases";
            this.btn_Make_Databases.Size = new System.Drawing.Size(207, 22);
            this.btn_Make_Databases.TabIndex = 14;
            this.btn_Make_Databases.Text = "Time to make the databases";
            this.btn_Make_Databases.UseVisualStyleBackColor = true;
            this.btn_Make_Databases.Click += new System.EventHandler(this.btn_Make_Databases_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 588);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Database Displayed";
            // 
            // cmbx_DisplayWhichDB
            // 
            this.cmbx_DisplayWhichDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_DisplayWhichDB.FormattingEnabled = true;
            this.cmbx_DisplayWhichDB.Location = new System.Drawing.Point(9, 603);
            this.cmbx_DisplayWhichDB.Margin = new System.Windows.Forms.Padding(2);
            this.cmbx_DisplayWhichDB.Name = "cmbx_DisplayWhichDB";
            this.cmbx_DisplayWhichDB.Size = new System.Drawing.Size(201, 21);
            this.cmbx_DisplayWhichDB.TabIndex = 10;
            this.cmbx_DisplayWhichDB.SelectedIndexChanged += new System.EventHandler(this.cmbx_DisplayWhichDB_SelectedIndexChanged);
            this.cmbx_DisplayWhichDB.TextChanged += new System.EventHandler(this.cmb_empty_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 539);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number of Decoy Databases";
            // 
            // nUD_NumDecoyDBs
            // 
            this.nUD_NumDecoyDBs.Location = new System.Drawing.Point(9, 536);
            this.nUD_NumDecoyDBs.Margin = new System.Windows.Forms.Padding(2);
            this.nUD_NumDecoyDBs.Name = "nUD_NumDecoyDBs";
            this.nUD_NumDecoyDBs.Size = new System.Drawing.Size(48, 20);
            this.nUD_NumDecoyDBs.TabIndex = 8;
            this.nUD_NumDecoyDBs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_NumDecoyDBs.ValueChanged += new System.EventHandler(this.nUD_NumDecoyDBs_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 515);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Max PTMs per Proteoform";
            // 
            // nUD_MaxPTMs
            // 
            this.nUD_MaxPTMs.Location = new System.Drawing.Point(9, 511);
            this.nUD_MaxPTMs.Margin = new System.Windows.Forms.Padding(2);
            this.nUD_MaxPTMs.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUD_MaxPTMs.Name = "nUD_MaxPTMs";
            this.nUD_MaxPTMs.Size = new System.Drawing.Size(48, 20);
            this.nUD_MaxPTMs.TabIndex = 6;
            this.nUD_MaxPTMs.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUD_MaxPTMs.ValueChanged += new System.EventHandler(this.nUD_MaxPTMs_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_NeuCode_Hv);
            this.groupBox1.Controls.Add(this.btn_NeuCode_Lt);
            this.groupBox1.Controls.Add(this.btn_NaturalIsotopes);
            this.groupBox1.Location = new System.Drawing.Point(-1, 396);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(215, 105);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lysine Isotope Composition";
            // 
            // btn_NeuCode_Hv
            // 
            this.btn_NeuCode_Hv.AutoSize = true;
            this.btn_NeuCode_Hv.Location = new System.Drawing.Point(11, 75);
            this.btn_NeuCode_Hv.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NeuCode_Hv.Name = "btn_NeuCode_Hv";
            this.btn_NeuCode_Hv.Size = new System.Drawing.Size(104, 17);
            this.btn_NeuCode_Hv.TabIndex = 7;
            this.btn_NeuCode_Hv.TabStop = true;
            this.btn_NeuCode_Hv.Text = "NeuCode Heavy";
            this.btn_NeuCode_Hv.UseVisualStyleBackColor = true;
            this.btn_NeuCode_Hv.CheckedChanged += new System.EventHandler(this.btn_NeuCode_Hv_CheckedChanged);
            // 
            // btn_NeuCode_Lt
            // 
            this.btn_NeuCode_Lt.AutoSize = true;
            this.btn_NeuCode_Lt.Location = new System.Drawing.Point(11, 49);
            this.btn_NeuCode_Lt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NeuCode_Lt.Name = "btn_NeuCode_Lt";
            this.btn_NeuCode_Lt.Size = new System.Drawing.Size(96, 17);
            this.btn_NeuCode_Lt.TabIndex = 6;
            this.btn_NeuCode_Lt.TabStop = true;
            this.btn_NeuCode_Lt.Text = "NeuCode Light";
            this.btn_NeuCode_Lt.UseVisualStyleBackColor = true;
            this.btn_NeuCode_Lt.CheckedChanged += new System.EventHandler(this.btn_NeuCode_Lt_CheckedChanged);
            // 
            // btn_NaturalIsotopes
            // 
            this.btn_NaturalIsotopes.AutoSize = true;
            this.btn_NaturalIsotopes.Location = new System.Drawing.Point(11, 23);
            this.btn_NaturalIsotopes.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NaturalIsotopes.Name = "btn_NaturalIsotopes";
            this.btn_NaturalIsotopes.Size = new System.Drawing.Size(155, 17);
            this.btn_NaturalIsotopes.TabIndex = 0;
            this.btn_NaturalIsotopes.TabStop = true;
            this.btn_NaturalIsotopes.Text = "Natural Isotope Abundance";
            this.btn_NaturalIsotopes.UseVisualStyleBackColor = true;
            this.btn_NaturalIsotopes.CheckedChanged += new System.EventHandler(this.btn_NaturalIsotopes_CheckedChanged);
            // 
            // ckbx_Meth_Cleaved
            // 
            this.ckbx_Meth_Cleaved.AutoSize = true;
            this.ckbx_Meth_Cleaved.Checked = true;
            this.ckbx_Meth_Cleaved.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbx_Meth_Cleaved.Location = new System.Drawing.Point(8, 364);
            this.ckbx_Meth_Cleaved.Margin = new System.Windows.Forms.Padding(2);
            this.ckbx_Meth_Cleaved.Name = "ckbx_Meth_Cleaved";
            this.ckbx_Meth_Cleaved.Size = new System.Drawing.Size(131, 17);
            this.ckbx_Meth_Cleaved.TabIndex = 4;
            this.ckbx_Meth_Cleaved.Text = "Cleaved N-Methionine";
            this.ckbx_Meth_Cleaved.UseVisualStyleBackColor = true;
            this.ckbx_Meth_Cleaved.CheckedChanged += new System.EventHandler(this.ckbx_Meth_Cleaved_CheckedChanged);
            // 
            // ckbx_Carbam
            // 
            this.ckbx_Carbam.AutoSize = true;
            this.ckbx_Carbam.Checked = true;
            this.ckbx_Carbam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbx_Carbam.Location = new System.Drawing.Point(8, 338);
            this.ckbx_Carbam.Margin = new System.Windows.Forms.Padding(2);
            this.ckbx_Carbam.Name = "ckbx_Carbam";
            this.ckbx_Carbam.Size = new System.Drawing.Size(157, 17);
            this.ckbx_Carbam.TabIndex = 3;
            this.ckbx_Carbam.Text = "Fixed Carbamidomethylation";
            this.ckbx_Carbam.UseVisualStyleBackColor = true;
            this.ckbx_Carbam.CheckedChanged += new System.EventHandler(this.ckbx_Carbam_CheckedChanged);
            // 
            // ckbx_OxidMeth
            // 
            this.ckbx_OxidMeth.AutoSize = true;
            this.ckbx_OxidMeth.Checked = true;
            this.ckbx_OxidMeth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbx_OxidMeth.Location = new System.Drawing.Point(8, 313);
            this.ckbx_OxidMeth.Margin = new System.Windows.Forms.Padding(2);
            this.ckbx_OxidMeth.Name = "ckbx_OxidMeth";
            this.ckbx_OxidMeth.Size = new System.Drawing.Size(162, 17);
            this.ckbx_OxidMeth.TabIndex = 2;
            this.ckbx_OxidMeth.Text = "Variable Oxidized Methionine";
            this.ckbx_OxidMeth.UseVisualStyleBackColor = true;
            this.ckbx_OxidMeth.CheckedChanged += new System.EventHandler(this.ckbx_OxidMeth_CheckedChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgv_Database);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgv_unlocalizedModifications);
            this.splitContainer2.Size = new System.Drawing.Size(900, 737);
            this.splitContainer2.SplitterDistance = 300;
            this.splitContainer2.TabIndex = 2;
            // 
            // dgv_Database
            // 
            this.dgv_Database.AllowUserToAddRows = false;
            this.dgv_Database.AllowUserToDeleteRows = false;
            this.dgv_Database.AllowUserToOrderColumns = true;
            this.dgv_Database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Database.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Database.Location = new System.Drawing.Point(0, 0);
            this.dgv_Database.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Database.Name = "dgv_Database";
            this.dgv_Database.ReadOnly = true;
            this.dgv_Database.RowTemplate.Height = 28;
            this.dgv_Database.Size = new System.Drawing.Size(900, 300);
            this.dgv_Database.TabIndex = 3;
            // 
            // dgv_unlocalizedModifications
            // 
            this.dgv_unlocalizedModifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_unlocalizedModifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_unlocalizedModifications.Location = new System.Drawing.Point(0, 0);
            this.dgv_unlocalizedModifications.Name = "dgv_unlocalizedModifications";
            this.dgv_unlocalizedModifications.Size = new System.Drawing.Size(900, 433);
            this.dgv_unlocalizedModifications.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitter1.Size = new System.Drawing.Size(3, 737);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // TheoreticalDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TheoreticalDatabase";
            this.Text = "Theoretical Database";
            this.Load += new System.EventHandler(this.TheoreticalDatabase_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loadFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MinPeptideLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_NumDecoyDBs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MaxPTMs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_unlocalizedModifications)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbx_DisplayWhichDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUD_NumDecoyDBs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUD_MaxPTMs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btn_NeuCode_Hv;
        private System.Windows.Forms.RadioButton btn_NeuCode_Lt;
        private System.Windows.Forms.RadioButton btn_NaturalIsotopes;
        private System.Windows.Forms.CheckBox ckbx_Meth_Cleaved;
        private System.Windows.Forms.CheckBox ckbx_Carbam;
        private System.Windows.Forms.CheckBox ckbx_OxidMeth;
        private System.Windows.Forms.Button btn_Make_Databases;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nUD_MinPeptideLength;
        private System.Windows.Forms.CheckBox ckbx_combineIdenticalSequences;
        private System.Windows.Forms.CheckBox ckbx_combineTheoreticalsByMass;
        private System.Windows.Forms.DataGridView dgv_loadFiles;
        private System.Windows.Forms.Button btn_addFiles;
        private System.Windows.Forms.Button btn_clearFiles;
        private System.Windows.Forms.ComboBox cmb_loadTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tableFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_modTypesToExclude;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_totalTheoreticalProteoforms;
        private System.Windows.Forms.CheckBox cb_limitLargePtmSets;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btn_downloadUniProtPtmList;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgv_Database;
        private System.Windows.Forms.DataGridView dgv_unlocalizedModifications;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_loadModNames;
        private System.Windows.Forms.Button btn_saveModNames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_modTableFilter;
        private System.Windows.Forms.Button btn_amendModNames;
    }
}