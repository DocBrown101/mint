﻿namespace Mint
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblversion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botPanel = new System.Windows.Forms.Panel();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.checkAutoStart = new System.Windows.Forms.CheckBox();
            this.radioMinimal = new System.Windows.Forms.RadioButton();
            this.radioCaramel = new System.Windows.Forms.RadioButton();
            this.radioLime = new System.Windows.Forms.RadioButton();
            this.radioMagma = new System.Windows.Forms.RadioButton();
            this.radioOcean = new System.Windows.Forms.RadioButton();
            this.radioZerg = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panelApps = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listApps = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelAddApp = new System.Windows.Forms.Panel();
            this.btnLocate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAppTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAppLink = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.launcherIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.launcherMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.botPanel.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.panelApps.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelAddApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.btnUpdate);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.lblversion);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(773, 77);
            this.topPanel.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(664, 12);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 39);
            this.btnUpdate.TabIndex = 81;
            this.btnUpdate.Tag = "themeable";
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.ForeColor = System.Drawing.Color.Silver;
            this.lblversion.Location = new System.Drawing.Point(90, 46);
            this.lblversion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(68, 20);
            this.lblversion.TabIndex = 4;
            this.lblversion.Text = "Version: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mint";
            // 
            // botPanel
            // 
            this.botPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.botPanel.Controls.Add(this.panelOptions);
            this.botPanel.Controls.Add(this.panelApps);
            this.botPanel.Controls.Add(this.panelAddApp);
            this.botPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botPanel.Location = new System.Drawing.Point(0, 77);
            this.botPanel.Margin = new System.Windows.Forms.Padding(2);
            this.botPanel.Name = "botPanel";
            this.botPanel.Size = new System.Drawing.Size(773, 589);
            this.botPanel.TabIndex = 9;
            // 
            // panelOptions
            // 
            this.panelOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOptions.Controls.Add(this.checkAutoStart);
            this.panelOptions.Controls.Add(this.radioMinimal);
            this.panelOptions.Controls.Add(this.radioCaramel);
            this.panelOptions.Controls.Add(this.radioLime);
            this.panelOptions.Controls.Add(this.radioMagma);
            this.panelOptions.Controls.Add(this.radioOcean);
            this.panelOptions.Controls.Add(this.radioZerg);
            this.panelOptions.Controls.Add(this.label6);
            this.panelOptions.Location = new System.Drawing.Point(12, 302);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(370, 270);
            this.panelOptions.TabIndex = 91;
            // 
            // checkAutoStart
            // 
            this.checkAutoStart.AutoSize = true;
            this.checkAutoStart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAutoStart.ForeColor = System.Drawing.Color.Silver;
            this.checkAutoStart.Location = new System.Drawing.Point(17, 184);
            this.checkAutoStart.Name = "checkAutoStart";
            this.checkAutoStart.Size = new System.Drawing.Size(211, 32);
            this.checkAutoStart.TabIndex = 85;
            this.checkAutoStart.Text = "Start with Windows";
            this.checkAutoStart.UseVisualStyleBackColor = true;
            this.checkAutoStart.CheckedChanged += new System.EventHandler(this.checkAutoStart_CheckedChanged);
            // 
            // radioMinimal
            // 
            this.radioMinimal.AutoSize = true;
            this.radioMinimal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMinimal.ForeColor = System.Drawing.Color.Gray;
            this.radioMinimal.Location = new System.Drawing.Point(124, 137);
            this.radioMinimal.Name = "radioMinimal";
            this.radioMinimal.Size = new System.Drawing.Size(106, 32);
            this.radioMinimal.TabIndex = 84;
            this.radioMinimal.Text = "Minimal";
            this.radioMinimal.UseVisualStyleBackColor = true;
            this.radioMinimal.CheckedChanged += new System.EventHandler(this.radioMinimal_CheckedChanged);
            // 
            // radioCaramel
            // 
            this.radioCaramel.AutoSize = true;
            this.radioCaramel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCaramel.ForeColor = System.Drawing.Color.DarkOrange;
            this.radioCaramel.Location = new System.Drawing.Point(124, 61);
            this.radioCaramel.Name = "radioCaramel";
            this.radioCaramel.Size = new System.Drawing.Size(106, 32);
            this.radioCaramel.TabIndex = 83;
            this.radioCaramel.Text = "Caramel";
            this.radioCaramel.UseVisualStyleBackColor = true;
            this.radioCaramel.CheckedChanged += new System.EventHandler(this.radioCaramel_CheckedChanged);
            // 
            // radioLime
            // 
            this.radioLime.AutoSize = true;
            this.radioLime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLime.ForeColor = System.Drawing.Color.LimeGreen;
            this.radioLime.Location = new System.Drawing.Point(124, 99);
            this.radioLime.Name = "radioLime";
            this.radioLime.Size = new System.Drawing.Size(77, 32);
            this.radioLime.TabIndex = 82;
            this.radioLime.Text = "Lime";
            this.radioLime.UseVisualStyleBackColor = true;
            this.radioLime.CheckedChanged += new System.EventHandler(this.radioLime_CheckedChanged);
            // 
            // radioMagma
            // 
            this.radioMagma.AutoSize = true;
            this.radioMagma.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMagma.ForeColor = System.Drawing.Color.Tomato;
            this.radioMagma.Location = new System.Drawing.Point(17, 99);
            this.radioMagma.Name = "radioMagma";
            this.radioMagma.Size = new System.Drawing.Size(101, 32);
            this.radioMagma.TabIndex = 81;
            this.radioMagma.Text = "Magma";
            this.radioMagma.UseVisualStyleBackColor = true;
            this.radioMagma.CheckedChanged += new System.EventHandler(this.radioMagma_CheckedChanged);
            // 
            // radioOcean
            // 
            this.radioOcean.AutoSize = true;
            this.radioOcean.Checked = true;
            this.radioOcean.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOcean.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioOcean.Location = new System.Drawing.Point(17, 61);
            this.radioOcean.Name = "radioOcean";
            this.radioOcean.Size = new System.Drawing.Size(90, 32);
            this.radioOcean.TabIndex = 80;
            this.radioOcean.TabStop = true;
            this.radioOcean.Text = "Ocean";
            this.radioOcean.UseVisualStyleBackColor = true;
            this.radioOcean.CheckedChanged += new System.EventHandler(this.radioOcean_CheckedChanged);
            // 
            // radioZerg
            // 
            this.radioZerg.AutoSize = true;
            this.radioZerg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioZerg.ForeColor = System.Drawing.Color.MediumOrchid;
            this.radioZerg.Location = new System.Drawing.Point(17, 137);
            this.radioZerg.Name = "radioZerg";
            this.radioZerg.Size = new System.Drawing.Size(75, 32);
            this.radioZerg.TabIndex = 79;
            this.radioZerg.Text = "Zerg";
            this.radioZerg.UseVisualStyleBackColor = true;
            this.radioZerg.CheckedChanged += new System.EventHandler(this.radioZerg_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(11, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 35);
            this.label6.TabIndex = 78;
            this.label6.Tag = "themeable";
            this.label6.Text = "Options:";
            // 
            // panelApps
            // 
            this.panelApps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelApps.Controls.Add(this.panel2);
            this.panelApps.Controls.Add(this.label3);
            this.panelApps.Controls.Add(this.btnDelete);
            this.panelApps.Controls.Add(this.btnClear);
            this.panelApps.Location = new System.Drawing.Point(388, 17);
            this.panelApps.Name = "panelApps";
            this.panelApps.Size = new System.Drawing.Size(370, 555);
            this.panelApps.TabIndex = 90;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listApps);
            this.panel2.Location = new System.Drawing.Point(20, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 438);
            this.panel2.TabIndex = 83;
            // 
            // listApps
            // 
            this.listApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listApps.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listApps.ForeColor = System.Drawing.Color.White;
            this.listApps.FormattingEnabled = true;
            this.listApps.ItemHeight = 28;
            this.listApps.Location = new System.Drawing.Point(0, 0);
            this.listApps.Name = "listApps";
            this.listApps.Size = new System.Drawing.Size(323, 436);
            this.listApps.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 35);
            this.label3.TabIndex = 77;
            this.label3.Tag = "themeable";
            this.label3.Text = "Apps:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(258, 501);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 39);
            this.btnDelete.TabIndex = 81;
            this.btnDelete.Tag = "themeable";
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(20, 501);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 39);
            this.btnClear.TabIndex = 79;
            this.btnClear.Tag = "themeable";
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panelAddApp
            // 
            this.panelAddApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddApp.Controls.Add(this.btnLocate);
            this.panelAddApp.Controls.Add(this.btnAdd);
            this.panelAddApp.Controls.Add(this.txtAppTitle);
            this.panelAddApp.Controls.Add(this.label1);
            this.panelAddApp.Controls.Add(this.label5);
            this.panelAddApp.Controls.Add(this.txtAppLink);
            this.panelAddApp.Controls.Add(this.label4);
            this.panelAddApp.Location = new System.Drawing.Point(12, 17);
            this.panelAddApp.Name = "panelAddApp";
            this.panelAddApp.Size = new System.Drawing.Size(370, 279);
            this.panelAddApp.TabIndex = 89;
            // 
            // btnLocate
            // 
            this.btnLocate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLocate.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLocate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLocate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLocate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocate.ForeColor = System.Drawing.Color.White;
            this.btnLocate.Location = new System.Drawing.Point(309, 98);
            this.btnLocate.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocate.Name = "btnLocate";
            this.btnLocate.Size = new System.Drawing.Size(37, 34);
            this.btnLocate.TabIndex = 89;
            this.btnLocate.Tag = "themeable";
            this.btnLocate.Text = "...";
            this.btnLocate.UseVisualStyleBackColor = false;
            this.btnLocate.Click += new System.EventHandler(this.btnLocate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(252, 217);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 39);
            this.btnAdd.TabIndex = 80;
            this.btnAdd.Tag = "themeable";
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAppTitle
            // 
            this.txtAppTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtAppTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAppTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppTitle.ForeColor = System.Drawing.Color.White;
            this.txtAppTitle.Location = new System.Drawing.Point(17, 178);
            this.txtAppTitle.Name = "txtAppTitle";
            this.txtAppTitle.Size = new System.Drawing.Size(329, 34);
            this.txtAppTitle.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 35);
            this.label1.TabIndex = 84;
            this.label1.Tag = "themeable";
            this.label1.Text = "Add a new app:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(12, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 28);
            this.label5.TabIndex = 87;
            this.label5.Tag = "";
            this.label5.Text = "Locate app:";
            // 
            // txtAppLink
            // 
            this.txtAppLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtAppLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAppLink.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppLink.ForeColor = System.Drawing.Color.White;
            this.txtAppLink.Location = new System.Drawing.Point(17, 98);
            this.txtAppLink.Name = "txtAppLink";
            this.txtAppLink.Size = new System.Drawing.Size(287, 34);
            this.txtAppLink.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 28);
            this.label4.TabIndex = 86;
            this.label4.Tag = "";
            this.label4.Text = "App title:";
            // 
            // launcherIcon
            // 
            this.launcherIcon.ContextMenuStrip = this.launcherMenu;
            this.launcherIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("launcherIcon.Icon")));
            this.launcherIcon.Text = "Mint";
            this.launcherIcon.Visible = true;
            this.launcherIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.launcherIcon_MouseDoubleClick);
            // 
            // launcherMenu
            // 
            this.launcherMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.launcherMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.launcherMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.launcherMenu.Name = "launcherMenu";
            this.launcherMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.launcherMenu.ShowImageMargin = false;
            this.launcherMenu.Size = new System.Drawing.Size(36, 4);
            this.launcherMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.launcherMenu_ItemClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(773, 666);
            this.Controls.Add(this.botPanel);
            this.Controls.Add(this.topPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.botPanel.ResumeLayout(false);
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            this.panelApps.ResumeLayout(false);
            this.panelApps.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelAddApp.ResumeLayout(false);
            this.panelAddApp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel botPanel;
        private System.Windows.Forms.ListBox listApps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NotifyIcon launcherIcon;
        private System.Windows.Forms.ContextMenuStrip launcherMenu;
        private System.Windows.Forms.TextBox txtAppTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAppLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelApps;
        private System.Windows.Forms.Panel panelAddApp;
        private System.Windows.Forms.Button btnLocate;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioMinimal;
        private System.Windows.Forms.RadioButton radioCaramel;
        private System.Windows.Forms.RadioButton radioLime;
        private System.Windows.Forms.RadioButton radioMagma;
        private System.Windows.Forms.RadioButton radioOcean;
        private System.Windows.Forms.RadioButton radioZerg;
        private System.Windows.Forms.CheckBox checkAutoStart;
        private System.Windows.Forms.Button btnUpdate;
    }
}

