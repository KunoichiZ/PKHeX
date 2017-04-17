﻿namespace PKHeX.WinForms
{
    partial class SAV_Misc3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAV_Misc3));
            this.B_Save = new System.Windows.Forms.Button();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TAB_Main = new System.Windows.Forms.TabPage();
            this.TB_OTName = new System.Windows.Forms.TextBox();
            this.L_TrainerName = new System.Windows.Forms.Label();
            this.NUD_BP = new System.Windows.Forms.NumericUpDown();
            this.L_BP = new System.Windows.Forms.Label();
            this.TAB_Joyful = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_B3 = new System.Windows.Forms.MaskedTextBox();
            this.TB_B2 = new System.Windows.Forms.MaskedTextBox();
            this.TB_B1 = new System.Windows.Forms.MaskedTextBox();
            this.L_B5Score = new System.Windows.Forms.Label();
            this.L_BHigh = new System.Windows.Forms.Label();
            this.L_BCaught = new System.Windows.Forms.Label();
            this.TB_J3 = new System.Windows.Forms.MaskedTextBox();
            this.TB_J2 = new System.Windows.Forms.MaskedTextBox();
            this.TB_J1 = new System.Windows.Forms.MaskedTextBox();
            this.L_JFlaw = new System.Windows.Forms.Label();
            this.L_JHigh = new System.Windows.Forms.Label();
            this.L_JRow = new System.Windows.Forms.Label();
            this.NUD_Coins = new System.Windows.Forms.NumericUpDown();
            this.L_Coins = new System.Windows.Forms.Label();
            this.TAB_Ferry = new System.Windows.Forms.TabPage();
            this.CHK_Catchable = new System.Windows.Forms.CheckBox();
            this.GB_Reachable = new System.Windows.Forms.GroupBox();
            this.CHK_ReachSouthern = new System.Windows.Forms.CheckBox();
            this.CHK_ReachNavel = new System.Windows.Forms.CheckBox();
            this.CHK_ReachBirth = new System.Windows.Forms.CheckBox();
            this.CHK_ReachFaraway = new System.Windows.Forms.CheckBox();
            this.CHK_ReachBF = new System.Windows.Forms.CheckBox();
            this.GB_InitialEvent = new System.Windows.Forms.GroupBox();
            this.CHK_InitialSouthern = new System.Windows.Forms.CheckBox();
            this.CHK_InitialNavel = new System.Windows.Forms.CheckBox();
            this.CHK_InitialBirth = new System.Windows.Forms.CheckBox();
            this.CHK_InitialFaraway = new System.Windows.Forms.CheckBox();
            this.B_GetTickets = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TAB_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_BP)).BeginInit();
            this.TAB_Joyful.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Coins)).BeginInit();
            this.TAB_Ferry.SuspendLayout();
            this.GB_Reachable.SuspendLayout();
            this.GB_InitialEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Save
            // 
            this.B_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Save.Location = new System.Drawing.Point(178, 209);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(75, 23);
            this.B_Save.TabIndex = 73;
            this.B_Save.Text = "Save";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // B_Cancel
            // 
            this.B_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Cancel.Location = new System.Drawing.Point(97, 209);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(75, 23);
            this.B_Cancel.TabIndex = 72;
            this.B_Cancel.Text = "Cancel";
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TAB_Main);
            this.tabControl1.Controls.Add(this.TAB_Joyful);
            this.tabControl1.Controls.Add(this.TAB_Ferry);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(239, 191);
            this.tabControl1.TabIndex = 74;
            // 
            // TAB_Main
            // 
            this.TAB_Main.Controls.Add(this.NUD_Coins);
            this.TAB_Main.Controls.Add(this.L_Coins);
            this.TAB_Main.Controls.Add(this.TB_OTName);
            this.TAB_Main.Controls.Add(this.L_TrainerName);
            this.TAB_Main.Controls.Add(this.NUD_BP);
            this.TAB_Main.Controls.Add(this.L_BP);
            this.TAB_Main.Location = new System.Drawing.Point(4, 22);
            this.TAB_Main.Name = "TAB_Main";
            this.TAB_Main.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_Main.Size = new System.Drawing.Size(231, 165);
            this.TAB_Main.TabIndex = 0;
            this.TAB_Main.Text = "Main";
            this.TAB_Main.UseVisualStyleBackColor = true;
            // 
            // TB_OTName
            // 
            this.TB_OTName.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_OTName.Location = new System.Drawing.Point(120, 77);
            this.TB_OTName.MaxLength = 7;
            this.TB_OTName.Name = "TB_OTName";
            this.TB_OTName.Size = new System.Drawing.Size(63, 20);
            this.TB_OTName.TabIndex = 31;
            this.TB_OTName.Text = "WWWWWWW";
            this.TB_OTName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // L_TrainerName
            // 
            this.L_TrainerName.Location = new System.Drawing.Point(28, 79);
            this.L_TrainerName.Name = "L_TrainerName";
            this.L_TrainerName.Size = new System.Drawing.Size(87, 16);
            this.L_TrainerName.TabIndex = 32;
            this.L_TrainerName.Text = "Rival Name:";
            this.L_TrainerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NUD_BP
            // 
            this.NUD_BP.Location = new System.Drawing.Point(120, 25);
            this.NUD_BP.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NUD_BP.Name = "NUD_BP";
            this.NUD_BP.Size = new System.Drawing.Size(47, 20);
            this.NUD_BP.TabIndex = 33;
            this.NUD_BP.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // L_BP
            // 
            this.L_BP.Location = new System.Drawing.Point(33, 23);
            this.L_BP.Name = "L_BP";
            this.L_BP.Size = new System.Drawing.Size(81, 20);
            this.L_BP.TabIndex = 30;
            this.L_BP.Text = "BP:";
            this.L_BP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TAB_Joyful
            // 
            this.TAB_Joyful.Controls.Add(this.label5);
            this.TAB_Joyful.Controls.Add(this.label4);
            this.TAB_Joyful.Controls.Add(this.TB_B3);
            this.TAB_Joyful.Controls.Add(this.TB_B2);
            this.TAB_Joyful.Controls.Add(this.TB_B1);
            this.TAB_Joyful.Controls.Add(this.L_B5Score);
            this.TAB_Joyful.Controls.Add(this.L_BHigh);
            this.TAB_Joyful.Controls.Add(this.L_BCaught);
            this.TAB_Joyful.Controls.Add(this.TB_J3);
            this.TAB_Joyful.Controls.Add(this.TB_J2);
            this.TAB_Joyful.Controls.Add(this.TB_J1);
            this.TAB_Joyful.Controls.Add(this.L_JFlaw);
            this.TAB_Joyful.Controls.Add(this.L_JHigh);
            this.TAB_Joyful.Controls.Add(this.L_JRow);
            this.TAB_Joyful.Location = new System.Drawing.Point(4, 22);
            this.TAB_Joyful.Name = "TAB_Joyful";
            this.TAB_Joyful.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_Joyful.Size = new System.Drawing.Size(231, 165);
            this.TAB_Joyful.TabIndex = 1;
            this.TAB_Joyful.Text = "Joyful";
            this.TAB_Joyful.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(118, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 65;
            this.label5.Text = "Berry Picking";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 64;
            this.label4.Text = "Pokémon Jump";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_B3
            // 
            this.TB_B3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_B3.Location = new System.Drawing.Point(184, 76);
            this.TB_B3.Mask = "0000";
            this.TB_B3.Name = "TB_B3";
            this.TB_B3.Size = new System.Drawing.Size(35, 20);
            this.TB_B3.TabIndex = 62;
            // 
            // TB_B2
            // 
            this.TB_B2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_B2.Location = new System.Drawing.Point(184, 57);
            this.TB_B2.Mask = "0000";
            this.TB_B2.Name = "TB_B2";
            this.TB_B2.Size = new System.Drawing.Size(35, 20);
            this.TB_B2.TabIndex = 61;
            // 
            // TB_B1
            // 
            this.TB_B1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_B1.Location = new System.Drawing.Point(184, 38);
            this.TB_B1.Mask = "0000";
            this.TB_B1.Name = "TB_B1";
            this.TB_B1.Size = new System.Drawing.Size(35, 20);
            this.TB_B1.TabIndex = 60;
            // 
            // L_B5Score
            // 
            this.L_B5Score.AutoSize = true;
            this.L_B5Score.Location = new System.Drawing.Point(118, 79);
            this.L_B5Score.Name = "L_B5Score";
            this.L_B5Score.Size = new System.Drawing.Size(62, 13);
            this.L_B5Score.TabIndex = 59;
            this.L_B5Score.Text = "5 In a Row:";
            // 
            // L_BHigh
            // 
            this.L_BHigh.AutoSize = true;
            this.L_BHigh.Location = new System.Drawing.Point(118, 60);
            this.L_BHigh.Name = "L_BHigh";
            this.L_BHigh.Size = new System.Drawing.Size(63, 13);
            this.L_BHigh.TabIndex = 58;
            this.L_BHigh.Text = "High Score:";
            // 
            // L_BCaught
            // 
            this.L_BCaught.AutoSize = true;
            this.L_BCaught.Location = new System.Drawing.Point(118, 41);
            this.L_BCaught.Name = "L_BCaught";
            this.L_BCaught.Size = new System.Drawing.Size(44, 13);
            this.L_BCaught.TabIndex = 57;
            this.L_BCaught.Text = "Caught:";
            // 
            // TB_J3
            // 
            this.TB_J3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_J3.Location = new System.Drawing.Point(77, 76);
            this.TB_J3.Mask = "0000";
            this.TB_J3.Name = "TB_J3";
            this.TB_J3.Size = new System.Drawing.Size(35, 20);
            this.TB_J3.TabIndex = 56;
            // 
            // TB_J2
            // 
            this.TB_J2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_J2.Location = new System.Drawing.Point(77, 57);
            this.TB_J2.Mask = "0000";
            this.TB_J2.Name = "TB_J2";
            this.TB_J2.Size = new System.Drawing.Size(35, 20);
            this.TB_J2.TabIndex = 55;
            // 
            // TB_J1
            // 
            this.TB_J1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_J1.Location = new System.Drawing.Point(77, 38);
            this.TB_J1.Mask = "0000";
            this.TB_J1.Name = "TB_J1";
            this.TB_J1.Size = new System.Drawing.Size(35, 20);
            this.TB_J1.TabIndex = 54;
            // 
            // L_JFlaw
            // 
            this.L_JFlaw.AutoSize = true;
            this.L_JFlaw.Location = new System.Drawing.Point(9, 79);
            this.L_JFlaw.Name = "L_JFlaw";
            this.L_JFlaw.Size = new System.Drawing.Size(62, 13);
            this.L_JFlaw.TabIndex = 53;
            this.L_JFlaw.Text = "5 In a Row:";
            // 
            // L_JHigh
            // 
            this.L_JHigh.AutoSize = true;
            this.L_JHigh.Location = new System.Drawing.Point(9, 60);
            this.L_JHigh.Name = "L_JHigh";
            this.L_JHigh.Size = new System.Drawing.Size(63, 13);
            this.L_JHigh.TabIndex = 52;
            this.L_JHigh.Text = "High Score:";
            // 
            // L_JRow
            // 
            this.L_JRow.AutoSize = true;
            this.L_JRow.Location = new System.Drawing.Point(9, 41);
            this.L_JRow.Name = "L_JRow";
            this.L_JRow.Size = new System.Drawing.Size(53, 13);
            this.L_JRow.TabIndex = 51;
            this.L_JRow.Text = "In a Row:";
            // 
            // NUD_Coins
            // 
            this.NUD_Coins.Location = new System.Drawing.Point(120, 51);
            this.NUD_Coins.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NUD_Coins.Name = "NUD_Coins";
            this.NUD_Coins.Size = new System.Drawing.Size(47, 20);
            this.NUD_Coins.TabIndex = 35;
            this.NUD_Coins.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // L_Coins
            // 
            this.L_Coins.Location = new System.Drawing.Point(33, 49);
            this.L_Coins.Name = "L_Coins";
            this.L_Coins.Size = new System.Drawing.Size(81, 20);
            this.L_Coins.TabIndex = 34;
            this.L_Coins.Text = "Coins:";
            this.L_Coins.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TAB_Ferry
            // 
            this.TAB_Ferry.Controls.Add(this.B_GetTickets);
            this.TAB_Ferry.Controls.Add(this.GB_InitialEvent);
            this.TAB_Ferry.Controls.Add(this.GB_Reachable);
            this.TAB_Ferry.Controls.Add(this.CHK_Catchable);
            this.TAB_Ferry.Location = new System.Drawing.Point(4, 22);
            this.TAB_Ferry.Name = "TAB_Ferry";
            this.TAB_Ferry.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_Ferry.Size = new System.Drawing.Size(225, 165);
            this.TAB_Ferry.TabIndex = 2;
            this.TAB_Ferry.Text = "Ferry";
            this.TAB_Ferry.UseVisualStyleBackColor = true;
            // 
            // CHK_Catchable
            // 
            this.CHK_Catchable.AutoSize = true;
            this.CHK_Catchable.Location = new System.Drawing.Point(6, 140);
            this.CHK_Catchable.Name = "CHK_Catchable";
            this.CHK_Catchable.Size = new System.Drawing.Size(85, 16);
            this.CHK_Catchable.TabIndex = 0;
            this.CHK_Catchable.Text = "can get ride";
            this.CHK_Catchable.UseVisualStyleBackColor = true;
            // 
            // GB_Reachable
            // 
            this.GB_Reachable.Controls.Add(this.CHK_ReachBF);
            this.GB_Reachable.Controls.Add(this.CHK_ReachFaraway);
            this.GB_Reachable.Controls.Add(this.CHK_ReachBirth);
            this.GB_Reachable.Controls.Add(this.CHK_ReachNavel);
            this.GB_Reachable.Controls.Add(this.CHK_ReachSouthern);
            this.GB_Reachable.Location = new System.Drawing.Point(6, 6);
            this.GB_Reachable.Name = "GB_Reachable";
            this.GB_Reachable.Size = new System.Drawing.Size(111, 128);
            this.GB_Reachable.TabIndex = 2;
            this.GB_Reachable.TabStop = false;
            this.GB_Reachable.Text = "Reachable";
            // 
            // CHK_ReachSouthern
            // 
            this.CHK_ReachSouthern.AutoSize = true;
            this.CHK_ReachSouthern.Location = new System.Drawing.Point(6, 18);
            this.CHK_ReachSouthern.Name = "CHK_ReachSouthern";
            this.CHK_ReachSouthern.Size = new System.Drawing.Size(84, 16);
            this.CHK_ReachSouthern.TabIndex = 0;
            this.CHK_ReachSouthern.Text = "Southern Is.";
            this.CHK_ReachSouthern.UseVisualStyleBackColor = true;
            // 
            // CHK_ReachNavel
            // 
            this.CHK_ReachNavel.AutoSize = true;
            this.CHK_ReachNavel.Location = new System.Drawing.Point(6, 40);
            this.CHK_ReachNavel.Name = "CHK_ReachNavel";
            this.CHK_ReachNavel.Size = new System.Drawing.Size(83, 16);
            this.CHK_ReachNavel.TabIndex = 1;
            this.CHK_ReachNavel.Text = "Navel Rock";
            this.CHK_ReachNavel.UseVisualStyleBackColor = true;
            // 
            // CHK_ReachBirth
            // 
            this.CHK_ReachBirth.AutoSize = true;
            this.CHK_ReachBirth.Location = new System.Drawing.Point(6, 62);
            this.CHK_ReachBirth.Name = "CHK_ReachBirth";
            this.CHK_ReachBirth.Size = new System.Drawing.Size(64, 16);
            this.CHK_ReachBirth.TabIndex = 2;
            this.CHK_ReachBirth.Text = "Birth Is.";
            this.CHK_ReachBirth.UseVisualStyleBackColor = true;
            // 
            // CHK_ReachFaraway
            // 
            this.CHK_ReachFaraway.AutoSize = true;
            this.CHK_ReachFaraway.Location = new System.Drawing.Point(6, 84);
            this.CHK_ReachFaraway.Name = "CHK_ReachFaraway";
            this.CHK_ReachFaraway.Size = new System.Drawing.Size(82, 16);
            this.CHK_ReachFaraway.TabIndex = 3;
            this.CHK_ReachFaraway.Text = "Faraway Is.";
            this.CHK_ReachFaraway.UseVisualStyleBackColor = true;
            // 
            // CHK_ReachBF
            // 
            this.CHK_ReachBF.AutoSize = true;
            this.CHK_ReachBF.Location = new System.Drawing.Point(6, 106);
            this.CHK_ReachBF.Name = "CHK_ReachBF";
            this.CHK_ReachBF.Size = new System.Drawing.Size(99, 16);
            this.CHK_ReachBF.TabIndex = 4;
            this.CHK_ReachBF.Text = "Battle Frontier";
            this.CHK_ReachBF.UseVisualStyleBackColor = true;
            // 
            // GB_InitialEvent
            // 
            this.GB_InitialEvent.Controls.Add(this.CHK_InitialSouthern);
            this.GB_InitialEvent.Controls.Add(this.CHK_InitialNavel);
            this.GB_InitialEvent.Controls.Add(this.CHK_InitialBirth);
            this.GB_InitialEvent.Controls.Add(this.CHK_InitialFaraway);
            this.GB_InitialEvent.Location = new System.Drawing.Point(123, 6);
            this.GB_InitialEvent.Name = "GB_InitialEvent";
            this.GB_InitialEvent.Size = new System.Drawing.Size(96, 106);
            this.GB_InitialEvent.TabIndex = 3;
            this.GB_InitialEvent.TabStop = false;
            this.GB_InitialEvent.Text = "Initial Event";
            // 
            // CHK_InitialSouthern
            // 
            this.CHK_InitialSouthern.AutoSize = true;
            this.CHK_InitialSouthern.Location = new System.Drawing.Point(6, 18);
            this.CHK_InitialSouthern.Name = "CHK_InitialSouthern";
            this.CHK_InitialSouthern.Size = new System.Drawing.Size(84, 16);
            this.CHK_InitialSouthern.TabIndex = 4;
            this.CHK_InitialSouthern.Text = "Southern Is.";
            this.CHK_InitialSouthern.UseVisualStyleBackColor = true;
            // 
            // CHK_InitialNavel
            // 
            this.CHK_InitialNavel.AutoSize = true;
            this.CHK_InitialNavel.Location = new System.Drawing.Point(6, 40);
            this.CHK_InitialNavel.Name = "CHK_InitialNavel";
            this.CHK_InitialNavel.Size = new System.Drawing.Size(83, 16);
            this.CHK_InitialNavel.TabIndex = 5;
            this.CHK_InitialNavel.Text = "Navel Rock";
            this.CHK_InitialNavel.UseVisualStyleBackColor = true;
            // 
            // CHK_InitialBirth
            // 
            this.CHK_InitialBirth.AutoSize = true;
            this.CHK_InitialBirth.Location = new System.Drawing.Point(6, 62);
            this.CHK_InitialBirth.Name = "CHK_InitialBirth";
            this.CHK_InitialBirth.Size = new System.Drawing.Size(64, 16);
            this.CHK_InitialBirth.TabIndex = 6;
            this.CHK_InitialBirth.Text = "Birth Is.";
            this.CHK_InitialBirth.UseVisualStyleBackColor = true;
            // 
            // CHK_InitialFaraway
            // 
            this.CHK_InitialFaraway.AutoSize = true;
            this.CHK_InitialFaraway.Location = new System.Drawing.Point(6, 84);
            this.CHK_InitialFaraway.Name = "CHK_InitialFaraway";
            this.CHK_InitialFaraway.Size = new System.Drawing.Size(82, 16);
            this.CHK_InitialFaraway.TabIndex = 7;
            this.CHK_InitialFaraway.Text = "Faraway Is.";
            this.CHK_InitialFaraway.UseVisualStyleBackColor = true;
            // 
            // B_GetTickets
            // 
            this.B_GetTickets.Location = new System.Drawing.Point(123, 133);
            this.B_GetTickets.Name = "B_GetTickets";
            this.B_GetTickets.Size = new System.Drawing.Size(96, 23);
            this.B_GetTickets.TabIndex = 4;
            this.B_GetTickets.Text = "Get Tickets";
            this.B_GetTickets.UseVisualStyleBackColor = true;
            this.B_GetTickets.Click += new System.EventHandler(this.B_GetTickets_Click);
            // 
            // SAV_Misc3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 244);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.B_Cancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(200, 150);
            this.Name = "SAV_Misc3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trainer Data Editor";
            this.tabControl1.ResumeLayout(false);
            this.TAB_Main.ResumeLayout(false);
            this.TAB_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_BP)).EndInit();
            this.TAB_Joyful.ResumeLayout(false);
            this.TAB_Joyful.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Coins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Button B_Cancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TAB_Main;
        private System.Windows.Forms.TabPage TAB_Joyful;
        private System.Windows.Forms.MaskedTextBox TB_B3;
        private System.Windows.Forms.MaskedTextBox TB_B2;
        private System.Windows.Forms.MaskedTextBox TB_B1;
        private System.Windows.Forms.Label L_BHigh;
        private System.Windows.Forms.Label L_BCaught;
        private System.Windows.Forms.MaskedTextBox TB_J3;
        private System.Windows.Forms.MaskedTextBox TB_J2;
        private System.Windows.Forms.MaskedTextBox TB_J1;
        private System.Windows.Forms.Label L_JFlaw;
        private System.Windows.Forms.Label L_JHigh;
        private System.Windows.Forms.Label L_JRow;
        private System.Windows.Forms.Label L_B5Score;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_OTName;
        private System.Windows.Forms.Label L_TrainerName;
        private System.Windows.Forms.NumericUpDown NUD_BP;
        private System.Windows.Forms.Label L_BP;
        private System.Windows.Forms.NumericUpDown NUD_Coins;
        private System.Windows.Forms.Label L_Coins;
        private System.Windows.Forms.TabPage TAB_Ferry;
        private System.Windows.Forms.GroupBox GB_InitialEvent;
        private System.Windows.Forms.CheckBox CHK_InitialSouthern;
        private System.Windows.Forms.CheckBox CHK_InitialNavel;
        private System.Windows.Forms.CheckBox CHK_InitialBirth;
        private System.Windows.Forms.CheckBox CHK_InitialFaraway;
        private System.Windows.Forms.GroupBox GB_Reachable;
        private System.Windows.Forms.CheckBox CHK_ReachBF;
        private System.Windows.Forms.CheckBox CHK_ReachFaraway;
        private System.Windows.Forms.CheckBox CHK_ReachBirth;
        private System.Windows.Forms.CheckBox CHK_ReachNavel;
        private System.Windows.Forms.CheckBox CHK_ReachSouthern;
        private System.Windows.Forms.CheckBox CHK_Catchable;
        private System.Windows.Forms.Button B_GetTickets;
    }
}
