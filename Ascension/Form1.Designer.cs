namespace Ascension
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            title = new System.Windows.Forms.Label();
            checkBox1 = new System.Windows.Forms.CheckBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            squad_folder_names_browse = new System.Windows.Forms.Button();
            squad_folder_names_text = new System.Windows.Forms.TextBox();
            layout_h2_scen = new System.Windows.Forms.TableLayoutPanel();
            browse_scen_h2 = new System.Windows.Forms.Button();
            h2_scen_box = new System.Windows.Forms.TextBox();
            hintlabel = new System.Windows.Forms.Label();
            checkBox2 = new System.Windows.Forms.CheckBox();
            checkBox3 = new System.Windows.Forms.CheckBox();
            bsp_label = new System.Windows.Forms.Label();
            bsps_box = new System.Windows.Forms.ListBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            bsp_add = new System.Windows.Forms.Button();
            bsp_remove = new System.Windows.Forms.Button();
            scenario_label = new System.Windows.Forms.Label();
            layout_scenario = new System.Windows.Forms.TableLayoutPanel();
            browse_scen = new System.Windows.Forms.Button();
            scen_box = new System.Windows.Forms.TextBox();
            h2_scen_label = new System.Windows.Forms.Label();
            start_button = new System.Windows.Forms.Button();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            existing_bitmaps = new System.Windows.Forms.CheckBox();
            info_label = new System.Windows.Forms.LinkLabel();
            checkBox4 = new System.Windows.Forms.CheckBox();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            use_squad_folder_names = new System.Windows.Forms.CheckBox();
            help_squad_folders = new System.Windows.Forms.LinkLabel();
            tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            create_objects = new System.Windows.Forms.CheckBox();
            help_create_objects = new System.Windows.Forms.LinkLabel();
            versionLabel = new System.Windows.Forms.Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            layout_h2_scen.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            layout_scenario.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.AccessibleName = "";
            title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            title.AutoSize = true;
            title.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            title.Location = new System.Drawing.Point(210, 0);
            title.Name = "title";
            title.Size = new System.Drawing.Size(90, 28);
            title.TabIndex = 0;
            title.Text = "Ascension";
            title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            title.Click += label1_Click;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBox1.Location = new System.Drawing.Point(221, 60);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(67, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Shaders";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 19);
            tableLayoutPanel1.Controls.Add(layout_h2_scen, 0, 17);
            tableLayoutPanel1.Controls.Add(title, 1, 0);
            tableLayoutPanel1.Controls.Add(hintlabel, 0, 1);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(checkBox2, 0, 3);
            tableLayoutPanel1.Controls.Add(checkBox3, 0, 4);
            tableLayoutPanel1.Controls.Add(bsp_label, 0, 7);
            tableLayoutPanel1.Controls.Add(bsps_box, 0, 8);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 9);
            tableLayoutPanel1.Controls.Add(scenario_label, 0, 11);
            tableLayoutPanel1.Controls.Add(layout_scenario, 0, 12);
            tableLayoutPanel1.Controls.Add(h2_scen_label, 0, 16);
            tableLayoutPanel1.Controls.Add(start_button, 0, 21);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 13);
            tableLayoutPanel1.Controls.Add(checkBox4, 0, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 18);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 14);
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 22;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            tableLayoutPanel1.Size = new System.Drawing.Size(510, 690);
            tableLayoutPanel1.TabIndex = 3;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.90543F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.09456F));
            tableLayoutPanel4.Controls.Add(squad_folder_names_browse, 1, 0);
            tableLayoutPanel4.Controls.Add(squad_folder_names_text, 0, 0);
            tableLayoutPanel4.Location = new System.Drawing.Point(57, 599);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel4.Size = new System.Drawing.Size(396, 28);
            tableLayoutPanel4.TabIndex = 15;
            // 
            // squad_folder_names_browse
            // 
            squad_folder_names_browse.Anchor = System.Windows.Forms.AnchorStyles.None;
            squad_folder_names_browse.Enabled = false;
            squad_folder_names_browse.Location = new System.Drawing.Point(323, 3);
            squad_folder_names_browse.Name = "squad_folder_names_browse";
            squad_folder_names_browse.Size = new System.Drawing.Size(66, 22);
            squad_folder_names_browse.TabIndex = 12;
            squad_folder_names_browse.Text = "Browse";
            squad_folder_names_browse.UseVisualStyleBackColor = true;
            squad_folder_names_browse.Click += squad_folder_names_browse_Click;
            // 
            // squad_folder_names_text
            // 
            squad_folder_names_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            squad_folder_names_text.Enabled = false;
            squad_folder_names_text.Location = new System.Drawing.Point(3, 3);
            squad_folder_names_text.Name = "squad_folder_names_text";
            squad_folder_names_text.Size = new System.Drawing.Size(310, 23);
            squad_folder_names_text.TabIndex = 13;
            // 
            // layout_h2_scen
            // 
            layout_h2_scen.Anchor = System.Windows.Forms.AnchorStyles.None;
            layout_h2_scen.ColumnCount = 2;
            layout_h2_scen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.90543F));
            layout_h2_scen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.09456F));
            layout_h2_scen.Controls.Add(browse_scen_h2, 1, 0);
            layout_h2_scen.Controls.Add(h2_scen_box, 0, 0);
            layout_h2_scen.Location = new System.Drawing.Point(57, 533);
            layout_h2_scen.Name = "layout_h2_scen";
            layout_h2_scen.RowCount = 2;
            layout_h2_scen.RowStyles.Add(new System.Windows.Forms.RowStyle());
            layout_h2_scen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            layout_h2_scen.Size = new System.Drawing.Size(396, 28);
            layout_h2_scen.TabIndex = 14;
            // 
            // browse_scen_h2
            // 
            browse_scen_h2.Anchor = System.Windows.Forms.AnchorStyles.None;
            browse_scen_h2.Enabled = false;
            browse_scen_h2.Location = new System.Drawing.Point(323, 3);
            browse_scen_h2.Name = "browse_scen_h2";
            browse_scen_h2.Size = new System.Drawing.Size(66, 22);
            browse_scen_h2.TabIndex = 12;
            browse_scen_h2.Text = "Browse";
            browse_scen_h2.UseVisualStyleBackColor = true;
            browse_scen_h2.Click += browse_scen_h2_Click;
            // 
            // h2_scen_box
            // 
            h2_scen_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            h2_scen_box.Enabled = false;
            h2_scen_box.Location = new System.Drawing.Point(3, 3);
            h2_scen_box.Name = "h2_scen_box";
            h2_scen_box.Size = new System.Drawing.Size(310, 23);
            h2_scen_box.TabIndex = 13;
            // 
            // hintlabel
            // 
            hintlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            hintlabel.AutoSize = true;
            hintlabel.Location = new System.Drawing.Point(131, 34);
            hintlabel.Name = "hintlabel";
            hintlabel.Size = new System.Drawing.Size(247, 15);
            hintlabel.TabIndex = 3;
            hintlabel.Text = "Please check the conversion(s) that you want:";
            hintlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            hintlabel.Click += label1_Click_1;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            checkBox2.AutoSize = true;
            checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBox2.Location = new System.Drawing.Point(157, 88);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(196, 19);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Zones, areas and firing positions";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            checkBox3.AutoSize = true;
            checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBox3.Location = new System.Drawing.Point(132, 116);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(246, 19);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Scenario object data (objects, spawns etc)";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // bsp_label
            // 
            bsp_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            bsp_label.AutoSize = true;
            bsp_label.Enabled = false;
            bsp_label.Location = new System.Drawing.Point(137, 202);
            bsp_label.Name = "bsp_label";
            bsp_label.Size = new System.Drawing.Size(235, 15);
            bsp_label.TabIndex = 6;
            bsp_label.Text = "Add BSP XML files to convert shaders from:";
            bsp_label.Click += label1_Click_2;
            // 
            // bsps_box
            // 
            bsps_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            bsps_box.BackColor = System.Drawing.SystemColors.Control;
            bsps_box.Enabled = false;
            bsps_box.FormattingEnabled = true;
            bsps_box.Location = new System.Drawing.Point(56, 227);
            bsps_box.Name = "bsps_box";
            bsps_box.Size = new System.Drawing.Size(397, 64);
            bsps_box.TabIndex = 8;
            bsps_box.SelectedIndexChanged += bsps_box_SelectedIndexChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(bsp_add, 0, 0);
            tableLayoutPanel2.Controls.Add(bsp_remove, 1, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(167, 297);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            tableLayoutPanel2.Size = new System.Drawing.Size(175, 28);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // bsp_add
            // 
            bsp_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            bsp_add.Enabled = false;
            bsp_add.Location = new System.Drawing.Point(10, 3);
            bsp_add.Name = "bsp_add";
            bsp_add.Size = new System.Drawing.Size(66, 22);
            bsp_add.TabIndex = 0;
            bsp_add.Text = "Add BSP";
            bsp_add.UseVisualStyleBackColor = true;
            bsp_add.Click += bsp_add_Click;
            // 
            // bsp_remove
            // 
            bsp_remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            bsp_remove.Enabled = false;
            bsp_remove.Location = new System.Drawing.Point(98, 3);
            bsp_remove.Name = "bsp_remove";
            bsp_remove.Size = new System.Drawing.Size(66, 22);
            bsp_remove.TabIndex = 1;
            bsp_remove.Text = "Remove";
            bsp_remove.UseVisualStyleBackColor = true;
            bsp_remove.Click += bsp_remove_Click;
            // 
            // scenario_label
            // 
            scenario_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            scenario_label.AutoSize = true;
            scenario_label.Enabled = false;
            scenario_label.Location = new System.Drawing.Point(192, 362);
            scenario_label.Name = "scenario_label";
            scenario_label.Size = new System.Drawing.Size(126, 15);
            scenario_label.TabIndex = 10;
            scenario_label.Text = "Select H3 scenario tag:";
            // 
            // layout_scenario
            // 
            layout_scenario.Anchor = System.Windows.Forms.AnchorStyles.None;
            layout_scenario.ColumnCount = 2;
            layout_scenario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.90543F));
            layout_scenario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.09456F));
            layout_scenario.Controls.Add(browse_scen, 1, 0);
            layout_scenario.Controls.Add(scen_box, 0, 0);
            layout_scenario.Location = new System.Drawing.Point(57, 387);
            layout_scenario.Name = "layout_scenario";
            layout_scenario.RowCount = 2;
            layout_scenario.RowStyles.Add(new System.Windows.Forms.RowStyle());
            layout_scenario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            layout_scenario.Size = new System.Drawing.Size(396, 28);
            layout_scenario.TabIndex = 11;
            // 
            // browse_scen
            // 
            browse_scen.Anchor = System.Windows.Forms.AnchorStyles.None;
            browse_scen.Enabled = false;
            browse_scen.Location = new System.Drawing.Point(323, 3);
            browse_scen.Name = "browse_scen";
            browse_scen.Size = new System.Drawing.Size(66, 22);
            browse_scen.TabIndex = 12;
            browse_scen.Text = "Browse";
            browse_scen.UseVisualStyleBackColor = true;
            browse_scen.Click += browse_scen_Click;
            // 
            // scen_box
            // 
            scen_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            scen_box.Enabled = false;
            scen_box.Location = new System.Drawing.Point(3, 3);
            scen_box.Name = "scen_box";
            scen_box.Size = new System.Drawing.Size(310, 23);
            scen_box.TabIndex = 13;
            // 
            // h2_scen_label
            // 
            h2_scen_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            h2_scen_label.AutoSize = true;
            h2_scen_label.Enabled = false;
            h2_scen_label.Location = new System.Drawing.Point(179, 508);
            h2_scen_label.Name = "h2_scen_label";
            h2_scen_label.Size = new System.Drawing.Size(152, 15);
            h2_scen_label.TabIndex = 14;
            h2_scen_label.Text = "Select H2 scenario XML file:";
            // 
            // start_button
            // 
            start_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            start_button.AutoSize = true;
            start_button.Enabled = false;
            start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            start_button.Location = new System.Drawing.Point(180, 654);
            start_button.Name = "start_button";
            start_button.Size = new System.Drawing.Size(149, 26);
            start_button.TabIndex = 13;
            start_button.Text = "Begin conversion!";
            start_button.UseVisualStyleBackColor = true;
            start_button.Click += start_button_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.16216F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.83784F));
            tableLayoutPanel3.Controls.Add(existing_bitmaps, 0, 0);
            tableLayoutPanel3.Controls.Add(info_label, 1, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(61, 422);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            tableLayoutPanel3.Size = new System.Drawing.Size(388, 24);
            tableLayoutPanel3.TabIndex = 15;
            // 
            // existing_bitmaps
            // 
            existing_bitmaps.Anchor = System.Windows.Forms.AnchorStyles.None;
            existing_bitmaps.AutoSize = true;
            existing_bitmaps.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            existing_bitmaps.Enabled = false;
            existing_bitmaps.Location = new System.Drawing.Point(9, 3);
            existing_bitmaps.Name = "existing_bitmaps";
            existing_bitmaps.Size = new System.Drawing.Size(319, 18);
            existing_bitmaps.TabIndex = 12;
            existing_bitmaps.Text = "Use existing .tif files from the scenario's bitmaps folder?";
            existing_bitmaps.UseVisualStyleBackColor = true;
            existing_bitmaps.CheckedChanged += existing_bitmaps_CheckedChanged;
            // 
            // info_label
            // 
            info_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            info_label.Enabled = false;
            info_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            info_label.Location = new System.Drawing.Point(341, 4);
            info_label.Name = "info_label";
            info_label.Size = new System.Drawing.Size(44, 15);
            info_label.TabIndex = 13;
            info_label.TabStop = true;
            info_label.Text = "help";
            info_label.LinkClicked += info_label_LinkClicked;
            // 
            // checkBox4
            // 
            checkBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            checkBox4.AutoSize = true;
            checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBox4.Location = new System.Drawing.Point(66, 144);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new System.Drawing.Size(377, 19);
            checkBox4.TabIndex = 16;
            checkBox4.Text = "Scenario AI/script data (jump/flight hints, flags, point sets, squads)";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.16216F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.83784F));
            tableLayoutPanel5.Controls.Add(use_squad_folder_names, 0, 0);
            tableLayoutPanel5.Controls.Add(help_squad_folders, 1, 0);
            tableLayoutPanel5.Location = new System.Drawing.Point(61, 567);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            tableLayoutPanel5.Size = new System.Drawing.Size(388, 24);
            tableLayoutPanel5.TabIndex = 17;
            tableLayoutPanel5.Paint += tableLayoutPanel5_Paint;
            // 
            // use_squad_folder_names
            // 
            use_squad_folder_names.Anchor = System.Windows.Forms.AnchorStyles.None;
            use_squad_folder_names.AutoSize = true;
            use_squad_folder_names.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            use_squad_folder_names.Enabled = false;
            use_squad_folder_names.Location = new System.Drawing.Point(41, 3);
            use_squad_folder_names.Name = "use_squad_folder_names";
            use_squad_folder_names.Size = new System.Drawing.Size(255, 18);
            use_squad_folder_names.TabIndex = 12;
            use_squad_folder_names.Text = "Use squad folder names TXT file? (Optional)";
            use_squad_folder_names.UseVisualStyleBackColor = true;
            use_squad_folder_names.CheckedChanged += use_squad_folder_names_CheckedChanged;
            // 
            // help_squad_folders
            // 
            help_squad_folders.Anchor = System.Windows.Forms.AnchorStyles.None;
            help_squad_folders.Enabled = false;
            help_squad_folders.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            help_squad_folders.Location = new System.Drawing.Point(342, 4);
            help_squad_folders.Name = "help_squad_folders";
            help_squad_folders.Size = new System.Drawing.Size(42, 15);
            help_squad_folders.TabIndex = 13;
            help_squad_folders.TabStop = true;
            help_squad_folders.Text = "help";
            help_squad_folders.LinkClicked += help_squad_folders_LinkClicked;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.16216F));
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.83784F));
            tableLayoutPanel6.Controls.Add(create_objects, 0, 0);
            tableLayoutPanel6.Controls.Add(help_create_objects, 1, 0);
            tableLayoutPanel6.Location = new System.Drawing.Point(80, 453);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            tableLayoutPanel6.Size = new System.Drawing.Size(350, 24);
            tableLayoutPanel6.TabIndex = 18;
            // 
            // create_objects
            // 
            create_objects.Anchor = System.Windows.Forms.AnchorStyles.None;
            create_objects.AutoSize = true;
            create_objects.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            create_objects.Enabled = false;
            create_objects.Location = new System.Drawing.Point(5, 3);
            create_objects.Name = "create_objects";
            create_objects.Size = new System.Drawing.Size(295, 18);
            create_objects.TabIndex = 12;
            create_objects.Text = "Port missing object tags? (Scenery, Crates, Devices)";
            create_objects.UseVisualStyleBackColor = true;
            create_objects.CheckedChanged += create_objects_CheckedChanged;
            // 
            // help_create_objects
            // 
            help_create_objects.Anchor = System.Windows.Forms.AnchorStyles.None;
            help_create_objects.Enabled = false;
            help_create_objects.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            help_create_objects.Location = new System.Drawing.Point(310, 4);
            help_create_objects.Name = "help_create_objects";
            help_create_objects.Size = new System.Drawing.Size(34, 15);
            help_create_objects.TabIndex = 13;
            help_create_objects.TabStop = true;
            help_create_objects.Text = "help";
            help_create_objects.LinkClicked += help_create_objects_LinkClicked;
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Location = new System.Drawing.Point(460, 698);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new System.Drawing.Size(38, 15);
            versionLabel.TabIndex = 4;
            versionLabel.Text = "label1";
            versionLabel.Click += versionLabel_Click;
            // 
            // form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(511, 722);
            Controls.Add(versionLabel);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "form1";
            Text = "Ascension";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            layout_h2_scen.ResumeLayout(false);
            layout_h2_scen.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            layout_scenario.ResumeLayout(false);
            layout_scenario.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label hintlabel;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label bsp_label;
        private System.Windows.Forms.ListBox bsps_box;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bsp_add;
        private System.Windows.Forms.Button bsp_remove;
        private System.Windows.Forms.Label scenario_label;
        private System.Windows.Forms.TableLayoutPanel layout_scenario;
        private System.Windows.Forms.Button browse_scen;
        private System.Windows.Forms.TextBox scen_box;
        private System.Windows.Forms.CheckBox existing_bitmaps;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label h2_scen_label;
        private System.Windows.Forms.TableLayoutPanel layout_h2_scen;
        private System.Windows.Forms.Button browse_scen_h2;
        private System.Windows.Forms.TextBox h2_scen_box;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.LinkLabel info_label;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button squad_folder_names_browse;
        private System.Windows.Forms.TextBox squad_folder_names_text;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox use_squad_folder_names;
        private System.Windows.Forms.LinkLabel help_squad_folders;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.CheckBox create_objects;
        private System.Windows.Forms.LinkLabel help_create_objects;
    }
}

