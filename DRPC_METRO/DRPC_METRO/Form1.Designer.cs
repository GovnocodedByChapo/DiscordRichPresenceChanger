
namespace DRPC_METRO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.close = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.ch_showbuttons1dd = new MetroFramework.Controls.MetroCheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.configFile = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.config_create = new System.Windows.Forms.SaveFileDialog();
            this.config_saveas = new System.Windows.Forms.SaveFileDialog();
            this.update_presence1 = new System.Windows.Forms.Button();
            this.menu_config1 = new System.Windows.Forms.Button();
            this.menu_buttons1 = new System.Windows.Forms.Button();
            this.menu_images1 = new System.Windows.Forms.Button();
            this.menu_main1 = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.menu_indicator = new System.Windows.Forms.Label();
            this.menu_config = new FontAwesome.Sharp.IconButton();
            this.update_presence = new FontAwesome.Sharp.IconButton();
            this.menu_main = new FontAwesome.Sharp.IconButton();
            this.menu_images = new FontAwesome.Sharp.IconButton();
            this.menu_buttons = new FontAwesome.Sharp.IconButton();
            this.panel_images = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.image2_text = new System.Windows.Forms.TextBox();
            this.image2_key = new System.Windows.Forms.TextBox();
            this.image1_text = new System.Windows.Forms.TextBox();
            this.image1_key = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.clientid = new System.Windows.Forms.TextBox();
            this.details = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel_config = new System.Windows.Forms.Panel();
            this.cfg_openfolder = new FontAwesome.Sharp.IconButton();
            this.cfg_saveas = new FontAwesome.Sharp.IconButton();
            this.cfg_create = new FontAwesome.Sharp.IconButton();
            this.cfg_select = new FontAwesome.Sharp.IconButton();
            this.ch_hidden = new MetroFramework.Controls.MetroCheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.config_current = new System.Windows.Forms.Label();
            this.startup = new System.Windows.Forms.Button();
            this.button_close = new FontAwesome.Sharp.IconButton();
            this.button_hide = new FontAwesome.Sharp.IconButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.config_savecurrentas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.config_button = new System.Windows.Forms.Button();
            this.autoupdate = new System.Windows.Forms.Timer(this.components);
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.ch_showbuttons = new MetroFramework.Controls.MetroCheckBox();
            this.ch_showbuttons_old = new System.Windows.Forms.CheckBox();
            this.button1_text = new System.Windows.Forms.TextBox();
            this.button2_url = new System.Windows.Forms.TextBox();
            this.button2_text = new System.Windows.Forms.TextBox();
            this.button1_url = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.show_hidden = new System.Windows.Forms.Timer(this.components);
            this.show_hidden_settings = new System.Windows.Forms.Button();
            this.hidden_client_deinitialize = new System.Windows.Forms.Button();
            this.hidden_client_initialize = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_images.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Black;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(1008, 19);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(24, 24);
            this.close.TabIndex = 21;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // hide
            // 
            this.hide.BackColor = System.Drawing.Color.Black;
            this.hide.FlatAppearance.BorderSize = 0;
            this.hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hide.ForeColor = System.Drawing.Color.White;
            this.hide.Location = new System.Drawing.Point(842, 74);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(24, 24);
            this.hide.TabIndex = 22;
            this.hide.Text = "-";
            this.hide.UseVisualStyleBackColor = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // tray
            // 
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "Discord Rich Presence Changer";
            this.tray.Visible = true;
            this.tray.Click += new System.EventHandler(this.tray_Click);
            // 
            // ch_showbuttons1dd
            // 
            this.ch_showbuttons1dd.CustomBackground = false;
            this.ch_showbuttons1dd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ch_showbuttons1dd.FontSize = MetroFramework.MetroLinkSize.Small;
            this.ch_showbuttons1dd.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.ch_showbuttons1dd.Location = new System.Drawing.Point(990, 630);
            this.ch_showbuttons1dd.Name = "ch_showbuttons1dd";
            this.ch_showbuttons1dd.Size = new System.Drawing.Size(94, 19);
            this.ch_showbuttons1dd.Style = MetroFramework.MetroColorStyle.Silver;
            this.ch_showbuttons1dd.StyleManager = null;
            this.ch_showbuttons1dd.TabIndex = 32;
            this.ch_showbuttons1dd.Text = "Show buttons";
            this.ch_showbuttons1dd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ch_showbuttons1dd.UseStyleColors = false;
            this.ch_showbuttons1dd.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
            this.label8.Location = new System.Drawing.Point(7, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "ge";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // configFile
            // 
            this.configFile.ShowReadOnly = true;
            this.configFile.FileOk += new System.ComponentModel.CancelEventHandler(this.configFile_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(877, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // config_create
            // 
            this.config_create.FileName = "emptyConfig.ini";
            this.config_create.FileOk += new System.ComponentModel.CancelEventHandler(this.config_create_FileOk);
            // 
            // config_saveas
            // 
            this.config_saveas.DefaultExt = "ini";
            this.config_saveas.FileName = "myConfig.ini";
            this.config_saveas.FileOk += new System.ComponentModel.CancelEventHandler(this.config_saveas_FileOk);
            // 
            // update_presence1
            // 
            this.update_presence1.BackColor = System.Drawing.Color.White;
            this.update_presence1.FlatAppearance.BorderSize = 0;
            this.update_presence1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_presence1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_presence1.ForeColor = System.Drawing.Color.Black;
            this.update_presence1.Location = new System.Drawing.Point(902, 237);
            this.update_presence1.Name = "update_presence1";
            this.update_presence1.Size = new System.Drawing.Size(139, 48);
            this.update_presence1.TabIndex = 40;
            this.update_presence1.Text = "Update presence";
            this.update_presence1.UseVisualStyleBackColor = false;
            // 
            // menu_config1
            // 
            this.menu_config1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.menu_config1.FlatAppearance.BorderSize = 0;
            this.menu_config1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_config1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu_config1.ForeColor = System.Drawing.Color.White;
            this.menu_config1.Location = new System.Drawing.Point(990, 425);
            this.menu_config1.Name = "menu_config1";
            this.menu_config1.Size = new System.Drawing.Size(139, 48);
            this.menu_config1.TabIndex = 44;
            this.menu_config1.Text = "Other";
            this.menu_config1.UseVisualStyleBackColor = false;
            // 
            // menu_buttons1
            // 
            this.menu_buttons1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.menu_buttons1.FlatAppearance.BorderSize = 0;
            this.menu_buttons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_buttons1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu_buttons1.ForeColor = System.Drawing.Color.White;
            this.menu_buttons1.Location = new System.Drawing.Point(1158, 515);
            this.menu_buttons1.Name = "menu_buttons1";
            this.menu_buttons1.Size = new System.Drawing.Size(139, 48);
            this.menu_buttons1.TabIndex = 43;
            this.menu_buttons1.Text = "Buttons";
            this.menu_buttons1.UseVisualStyleBackColor = false;
            // 
            // menu_images1
            // 
            this.menu_images1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.menu_images1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_images1.FlatAppearance.BorderSize = 0;
            this.menu_images1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_images1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu_images1.ForeColor = System.Drawing.Color.White;
            this.menu_images1.Location = new System.Drawing.Point(1158, 468);
            this.menu_images1.Name = "menu_images1";
            this.menu_images1.Size = new System.Drawing.Size(139, 48);
            this.menu_images1.TabIndex = 42;
            this.menu_images1.Text = "Images";
            this.menu_images1.UseVisualStyleBackColor = false;
            // 
            // menu_main1
            // 
            this.menu_main1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.menu_main1.FlatAppearance.BorderSize = 0;
            this.menu_main1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_main1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu_main1.ForeColor = System.Drawing.Color.White;
            this.menu_main1.Location = new System.Drawing.Point(902, 282);
            this.menu_main1.Name = "menu_main1";
            this.menu_main1.Size = new System.Drawing.Size(139, 48);
            this.menu_main1.TabIndex = 41;
            this.menu_main1.Text = " Main";
            this.menu_main1.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(902, 487);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(48, 33);
            this.iconButton1.TabIndex = 42;
            this.iconButton1.Text = "Hide window";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Visible = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(612, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 22);
            this.button4.TabIndex = 47;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseEnter += new System.EventHandler(this.button4_MouseEnter_1);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(574, 322);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 22);
            this.button5.TabIndex = 48;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.label14.Location = new System.Drawing.Point(0, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(400, 379);
            this.label14.TabIndex = 49;
            // 
            // menu_indicator
            // 
            this.menu_indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.menu_indicator.Location = new System.Drawing.Point(0, 52);
            this.menu_indicator.Name = "menu_indicator";
            this.menu_indicator.Size = new System.Drawing.Size(100, 5);
            this.menu_indicator.TabIndex = 55;
            // 
            // menu_config
            // 
            this.menu_config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.menu_config.FlatAppearance.BorderSize = 0;
            this.menu_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_config.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.menu_config.ForeColor = System.Drawing.Color.White;
            this.menu_config.IconChar = FontAwesome.Sharp.IconChar.EllipsisH;
            this.menu_config.IconColor = System.Drawing.Color.White;
            this.menu_config.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_config.IconSize = 24;
            this.menu_config.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_config.Location = new System.Drawing.Point(300, 25);
            this.menu_config.Name = "menu_config";
            this.menu_config.Size = new System.Drawing.Size(100, 32);
            this.menu_config.TabIndex = 54;
            this.menu_config.Text = "Other";
            this.menu_config.UseVisualStyleBackColor = false;
            this.menu_config.Click += new System.EventHandler(this.menu_config_Click_2);
            // 
            // update_presence
            // 
            this.update_presence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.update_presence.FlatAppearance.BorderSize = 0;
            this.update_presence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_presence.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.update_presence.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_presence.ForeColor = System.Drawing.Color.White;
            this.update_presence.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.update_presence.IconColor = System.Drawing.Color.White;
            this.update_presence.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.update_presence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_presence.Location = new System.Drawing.Point(0, 385);
            this.update_presence.Name = "update_presence";
            this.update_presence.Size = new System.Drawing.Size(400, 84);
            this.update_presence.TabIndex = 53;
            this.update_presence.Text = "Update presence";
            this.update_presence.UseVisualStyleBackColor = false;
            this.update_presence.Click += new System.EventHandler(this.update_presence_Click_3);
            // 
            // menu_main
            // 
            this.menu_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.menu_main.FlatAppearance.BorderSize = 0;
            this.menu_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_main.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.menu_main.ForeColor = System.Drawing.Color.White;
            this.menu_main.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menu_main.IconColor = System.Drawing.Color.White;
            this.menu_main.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_main.IconSize = 24;
            this.menu_main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_main.Location = new System.Drawing.Point(0, 25);
            this.menu_main.Name = "menu_main";
            this.menu_main.Size = new System.Drawing.Size(100, 32);
            this.menu_main.TabIndex = 50;
            this.menu_main.Text = "Main";
            this.menu_main.UseVisualStyleBackColor = false;
            this.menu_main.Click += new System.EventHandler(this.menu_main_Click_3);
            // 
            // menu_images
            // 
            this.menu_images.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.menu_images.FlatAppearance.BorderSize = 0;
            this.menu_images.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_images.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.menu_images.ForeColor = System.Drawing.Color.White;
            this.menu_images.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.menu_images.IconColor = System.Drawing.Color.White;
            this.menu_images.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_images.IconSize = 24;
            this.menu_images.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_images.Location = new System.Drawing.Point(100, 25);
            this.menu_images.Name = "menu_images";
            this.menu_images.Size = new System.Drawing.Size(100, 32);
            this.menu_images.TabIndex = 51;
            this.menu_images.Text = "Images";
            this.menu_images.UseVisualStyleBackColor = false;
            this.menu_images.Click += new System.EventHandler(this.menu_images_Click_3);
            // 
            // menu_buttons
            // 
            this.menu_buttons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.menu_buttons.FlatAppearance.BorderSize = 0;
            this.menu_buttons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_buttons.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.menu_buttons.ForeColor = System.Drawing.Color.White;
            this.menu_buttons.IconChar = FontAwesome.Sharp.IconChar.Equals;
            this.menu_buttons.IconColor = System.Drawing.Color.White;
            this.menu_buttons.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_buttons.IconSize = 24;
            this.menu_buttons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_buttons.Location = new System.Drawing.Point(200, 25);
            this.menu_buttons.Name = "menu_buttons";
            this.menu_buttons.Size = new System.Drawing.Size(100, 32);
            this.menu_buttons.TabIndex = 52;
            this.menu_buttons.Text = "Buttons";
            this.menu_buttons.UseVisualStyleBackColor = false;
            this.menu_buttons.Click += new System.EventHandler(this.menu_buttons_Click_3);
            // 
            // panel_images
            // 
            this.panel_images.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.panel_images.Controls.Add(this.label16);
            this.panel_images.Controls.Add(this.image2_text);
            this.panel_images.Controls.Add(this.image2_key);
            this.panel_images.Controls.Add(this.image1_text);
            this.panel_images.Controls.Add(this.image1_key);
            this.panel_images.Controls.Add(this.label9);
            this.panel_images.Controls.Add(this.label7);
            this.panel_images.Controls.Add(this.label6);
            this.panel_images.Controls.Add(this.label5);
            this.panel_images.Location = new System.Drawing.Point(10, 74);
            this.panel_images.Name = "panel_images";
            this.panel_images.Size = new System.Drawing.Size(380, 276);
            this.panel_images.TabIndex = 34;
            this.panel_images.Visible = false;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(20, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(340, 23);
            this.label16.TabIndex = 48;
            this.label16.Text = "All fields may not be filled";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // image2_text
            // 
            this.image2_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.image2_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image2_text.ForeColor = System.Drawing.Color.White;
            this.image2_text.Location = new System.Drawing.Point(20, 228);
            this.image2_text.Name = "image2_text";
            this.image2_text.Size = new System.Drawing.Size(340, 23);
            this.image2_text.TabIndex = 46;
            // 
            // image2_key
            // 
            this.image2_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.image2_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image2_key.ForeColor = System.Drawing.Color.White;
            this.image2_key.Location = new System.Drawing.Point(20, 177);
            this.image2_key.Name = "image2_key";
            this.image2_key.Size = new System.Drawing.Size(340, 23);
            this.image2_key.TabIndex = 45;
            // 
            // image1_text
            // 
            this.image1_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.image1_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image1_text.ForeColor = System.Drawing.Color.White;
            this.image1_text.Location = new System.Drawing.Point(20, 94);
            this.image1_text.Name = "image1_text";
            this.image1_text.Size = new System.Drawing.Size(340, 23);
            this.image1_text.TabIndex = 44;
            // 
            // image1_key
            // 
            this.image1_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.image1_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image1_key.ForeColor = System.Drawing.Color.White;
            this.image1_key.Location = new System.Drawing.Point(20, 43);
            this.image1_key.Name = "image1_key";
            this.image1_key.Size = new System.Drawing.Size(340, 23);
            this.image1_key.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(20, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(340, 23);
            this.label9.TabIndex = 32;
            this.label9.Text = "Large image key";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(340, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Large image text";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(340, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Small image text";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Small image key";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.panel_main.Controls.Add(this.label15);
            this.panel_main.Controls.Add(this.clientid);
            this.panel_main.Controls.Add(this.details);
            this.panel_main.Controls.Add(this.state);
            this.panel_main.Controls.Add(this.label12);
            this.panel_main.Controls.Add(this.label11);
            this.panel_main.Controls.Add(this.label10);
            this.panel_main.Location = new System.Drawing.Point(10, 74);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(380, 276);
            this.panel_main.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(20, 253);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(340, 23);
            this.label15.TabIndex = 47;
            this.label15.Text = "Fields \"Details\", \"State\" may not be filled";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientid
            // 
            this.clientid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.clientid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientid.ForeColor = System.Drawing.Color.White;
            this.clientid.Location = new System.Drawing.Point(20, 42);
            this.clientid.Name = "clientid";
            this.clientid.Size = new System.Drawing.Size(340, 23);
            this.clientid.TabIndex = 46;
            // 
            // details
            // 
            this.details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.details.ForeColor = System.Drawing.Color.White;
            this.details.Location = new System.Drawing.Point(20, 91);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(340, 23);
            this.details.TabIndex = 45;
            // 
            // state
            // 
            this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.state.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.state.ForeColor = System.Drawing.Color.White;
            this.state.Location = new System.Drawing.Point(20, 141);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(340, 23);
            this.state.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(20, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(340, 23);
            this.label12.TabIndex = 31;
            this.label12.Text = "Client id";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(20, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(340, 23);
            this.label11.TabIndex = 30;
            this.label11.Text = "Details";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(20, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(340, 23);
            this.label10.TabIndex = 29;
            this.label10.Text = "State";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_config
            // 
            this.panel_config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.panel_config.Controls.Add(this.cfg_openfolder);
            this.panel_config.Controls.Add(this.cfg_saveas);
            this.panel_config.Controls.Add(this.cfg_create);
            this.panel_config.Controls.Add(this.cfg_select);
            this.panel_config.Controls.Add(this.ch_hidden);
            this.panel_config.Controls.Add(this.label13);
            this.panel_config.Controls.Add(this.config_current);
            this.panel_config.Location = new System.Drawing.Point(10, 74);
            this.panel_config.Name = "panel_config";
            this.panel_config.Size = new System.Drawing.Size(380, 276);
            this.panel_config.TabIndex = 62;
            this.panel_config.Visible = false;
            // 
            // cfg_openfolder
            // 
            this.cfg_openfolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.cfg_openfolder.FlatAppearance.BorderSize = 0;
            this.cfg_openfolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cfg_openfolder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cfg_openfolder.ForeColor = System.Drawing.Color.White;
            this.cfg_openfolder.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.cfg_openfolder.IconColor = System.Drawing.Color.White;
            this.cfg_openfolder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cfg_openfolder.IconSize = 24;
            this.cfg_openfolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cfg_openfolder.Location = new System.Drawing.Point(20, 200);
            this.cfg_openfolder.Name = "cfg_openfolder";
            this.cfg_openfolder.Size = new System.Drawing.Size(340, 32);
            this.cfg_openfolder.TabIndex = 77;
            this.cfg_openfolder.Text = "Open configs folder";
            this.cfg_openfolder.UseVisualStyleBackColor = false;
            this.cfg_openfolder.Click += new System.EventHandler(this.cfg_openfolder_Click);
            // 
            // cfg_saveas
            // 
            this.cfg_saveas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.cfg_saveas.FlatAppearance.BorderSize = 0;
            this.cfg_saveas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cfg_saveas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cfg_saveas.ForeColor = System.Drawing.Color.White;
            this.cfg_saveas.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.cfg_saveas.IconColor = System.Drawing.Color.White;
            this.cfg_saveas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cfg_saveas.IconSize = 24;
            this.cfg_saveas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cfg_saveas.Location = new System.Drawing.Point(20, 162);
            this.cfg_saveas.Name = "cfg_saveas";
            this.cfg_saveas.Size = new System.Drawing.Size(340, 32);
            this.cfg_saveas.TabIndex = 76;
            this.cfg_saveas.Text = "Save current config";
            this.cfg_saveas.UseVisualStyleBackColor = false;
            this.cfg_saveas.Click += new System.EventHandler(this.cfg_saveas_Click);
            // 
            // cfg_create
            // 
            this.cfg_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.cfg_create.FlatAppearance.BorderSize = 0;
            this.cfg_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cfg_create.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cfg_create.ForeColor = System.Drawing.Color.White;
            this.cfg_create.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.cfg_create.IconColor = System.Drawing.Color.White;
            this.cfg_create.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cfg_create.IconSize = 24;
            this.cfg_create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cfg_create.Location = new System.Drawing.Point(20, 124);
            this.cfg_create.Name = "cfg_create";
            this.cfg_create.Size = new System.Drawing.Size(340, 32);
            this.cfg_create.TabIndex = 75;
            this.cfg_create.Text = "Create new config";
            this.cfg_create.UseVisualStyleBackColor = false;
            this.cfg_create.Click += new System.EventHandler(this.cfg_create_Click);
            // 
            // cfg_select
            // 
            this.cfg_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.cfg_select.FlatAppearance.BorderSize = 0;
            this.cfg_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cfg_select.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cfg_select.ForeColor = System.Drawing.Color.White;
            this.cfg_select.IconChar = FontAwesome.Sharp.IconChar.File;
            this.cfg_select.IconColor = System.Drawing.Color.White;
            this.cfg_select.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cfg_select.IconSize = 24;
            this.cfg_select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cfg_select.Location = new System.Drawing.Point(20, 86);
            this.cfg_select.Name = "cfg_select";
            this.cfg_select.Size = new System.Drawing.Size(340, 32);
            this.cfg_select.TabIndex = 74;
            this.cfg_select.Text = "Select config";
            this.cfg_select.UseVisualStyleBackColor = false;
            this.cfg_select.Click += new System.EventHandler(this.cfg_select_Click_1);
            // 
            // ch_hidden
            // 
            this.ch_hidden.AutoSize = true;
            this.ch_hidden.CustomBackground = true;
            this.ch_hidden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ch_hidden.FontSize = MetroFramework.MetroLinkSize.Small;
            this.ch_hidden.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.ch_hidden.Location = new System.Drawing.Point(20, 247);
            this.ch_hidden.Name = "ch_hidden";
            this.ch_hidden.Size = new System.Drawing.Size(101, 15);
            this.ch_hidden.Style = MetroFramework.MetroColorStyle.Silver;
            this.ch_hidden.StyleManager = null;
            this.ch_hidden.TabIndex = 38;
            this.ch_hidden.Text = "Hidden launch";
            this.ch_hidden.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ch_hidden.UseStyleColors = false;
            this.ch_hidden.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(380, 23);
            this.label13.TabIndex = 31;
            this.label13.Text = "Current config:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // config_current
            // 
            this.config_current.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.config_current.ForeColor = System.Drawing.Color.White;
            this.config_current.Location = new System.Drawing.Point(1, 24);
            this.config_current.Name = "config_current";
            this.config_current.Size = new System.Drawing.Size(378, 52);
            this.config_current.TabIndex = 30;
            this.config_current.Text = "C:\\discord_presence_2\\config\\settings.ini";
            this.config_current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startup
            // 
            this.startup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.startup.FlatAppearance.BorderSize = 0;
            this.startup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startup.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startup.ForeColor = System.Drawing.Color.White;
            this.startup.Location = new System.Drawing.Point(620, 355);
            this.startup.Name = "startup";
            this.startup.Size = new System.Drawing.Size(150, 28);
            this.startup.TabIndex = 39;
            this.startup.Text = "Add to autorun";
            this.startup.UseVisualStyleBackColor = false;
            this.startup.Visible = false;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.button_close.IconColor = System.Drawing.Color.White;
            this.button_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_close.IconSize = 24;
            this.button_close.Location = new System.Drawing.Point(370, -3);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(30, 35);
            this.button_close.TabIndex = 63;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_hide
            // 
            this.button_hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.button_hide.FlatAppearance.BorderSize = 0;
            this.button_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hide.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.button_hide.IconColor = System.Drawing.Color.White;
            this.button_hide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_hide.IconSize = 24;
            this.button_hide.Location = new System.Drawing.Point(340, -3);
            this.button_hide.Name = "button_hide";
            this.button_hide.Size = new System.Drawing.Size(30, 35);
            this.button_hide.TabIndex = 64;
            this.button_hide.UseVisualStyleBackColor = false;
            this.button_hide.Click += new System.EventHandler(this.button_hide_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel1.Location = new System.Drawing.Point(0, 353);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(400, 29);
            this.linkLabel1.TabIndex = 65;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Discord Application Portal";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_2);
            // 
            // config_savecurrentas
            // 
            this.config_savecurrentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.config_savecurrentas.FlatAppearance.BorderSize = 0;
            this.config_savecurrentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.config_savecurrentas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.config_savecurrentas.ForeColor = System.Drawing.Color.White;
            this.config_savecurrentas.Location = new System.Drawing.Point(541, 427);
            this.config_savecurrentas.Name = "config_savecurrentas";
            this.config_savecurrentas.Size = new System.Drawing.Size(340, 32);
            this.config_savecurrentas.TabIndex = 76;
            this.config_savecurrentas.Text = "Save current config as";
            this.config_savecurrentas.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(541, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(340, 32);
            this.button2.TabIndex = 75;
            this.button2.Text = "Create empty config";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // config_button
            // 
            this.config_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.config_button.FlatAppearance.BorderSize = 0;
            this.config_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.config_button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.config_button.ForeColor = System.Drawing.Color.White;
            this.config_button.Location = new System.Drawing.Point(541, 351);
            this.config_button.Name = "config_button";
            this.config_button.Size = new System.Drawing.Size(340, 32);
            this.config_button.TabIndex = 74;
            this.config_button.Text = "Select other config";
            this.config_button.UseVisualStyleBackColor = false;
            // 
            // autoupdate
            // 
            this.autoupdate.Enabled = true;
            this.autoupdate.Interval = 5000;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 44;
            this.iconPictureBox1.Location = new System.Drawing.Point(650, 302);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(48, 44);
            this.iconPictureBox1.TabIndex = 77;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel_buttons
            // 
            this.panel_buttons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.panel_buttons.Controls.Add(this.label17);
            this.panel_buttons.Controls.Add(this.iconButton2);
            this.panel_buttons.Controls.Add(this.ch_showbuttons);
            this.panel_buttons.Controls.Add(this.ch_showbuttons_old);
            this.panel_buttons.Controls.Add(this.button1_text);
            this.panel_buttons.Controls.Add(this.button2_url);
            this.panel_buttons.Controls.Add(this.button2_text);
            this.panel_buttons.Controls.Add(this.button1_url);
            this.panel_buttons.Controls.Add(this.label4);
            this.panel_buttons.Controls.Add(this.label3);
            this.panel_buttons.Controls.Add(this.label2);
            this.panel_buttons.Controls.Add(this.label1);
            this.panel_buttons.Location = new System.Drawing.Point(10, 74);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(380, 276);
            this.panel_buttons.TabIndex = 79;
            this.panel_buttons.Visible = false;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(20, 253);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(340, 23);
            this.label17.TabIndex = 48;
            this.label17.Text = "Do not fill \'button 2 text\' if you need only 1 button!";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(239, 153);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(23, 23);
            this.iconButton2.TabIndex = 46;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Visible = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // ch_showbuttons
            // 
            this.ch_showbuttons.AutoSize = true;
            this.ch_showbuttons.CustomBackground = true;
            this.ch_showbuttons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ch_showbuttons.FontSize = MetroFramework.MetroLinkSize.Small;
            this.ch_showbuttons.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.ch_showbuttons.Location = new System.Drawing.Point(20, 21);
            this.ch_showbuttons.Name = "ch_showbuttons";
            this.ch_showbuttons.Size = new System.Drawing.Size(96, 15);
            this.ch_showbuttons.Style = MetroFramework.MetroColorStyle.Silver;
            this.ch_showbuttons.StyleManager = null;
            this.ch_showbuttons.TabIndex = 45;
            this.ch_showbuttons.Text = "Show buttons";
            this.ch_showbuttons.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ch_showbuttons.UseStyleColors = false;
            this.ch_showbuttons.UseVisualStyleBackColor = true;
            // 
            // ch_showbuttons_old
            // 
            this.ch_showbuttons_old.AutoSize = true;
            this.ch_showbuttons_old.ForeColor = System.Drawing.Color.White;
            this.ch_showbuttons_old.Location = new System.Drawing.Point(261, 18);
            this.ch_showbuttons_old.Name = "ch_showbuttons_old";
            this.ch_showbuttons_old.Size = new System.Drawing.Size(99, 19);
            this.ch_showbuttons_old.TabIndex = 44;
            this.ch_showbuttons_old.Text = "Show Buttons";
            this.ch_showbuttons_old.UseVisualStyleBackColor = true;
            this.ch_showbuttons_old.Visible = false;
            // 
            // button1_text
            // 
            this.button1_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.button1_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button1_text.ForeColor = System.Drawing.Color.White;
            this.button1_text.Location = new System.Drawing.Point(20, 43);
            this.button1_text.Name = "button1_text";
            this.button1_text.Size = new System.Drawing.Size(340, 23);
            this.button1_text.TabIndex = 43;
            // 
            // button2_url
            // 
            this.button2_url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.button2_url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button2_url.ForeColor = System.Drawing.Color.White;
            this.button2_url.Location = new System.Drawing.Point(20, 228);
            this.button2_url.Name = "button2_url";
            this.button2_url.Size = new System.Drawing.Size(340, 23);
            this.button2_url.TabIndex = 42;
            // 
            // button2_text
            // 
            this.button2_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.button2_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button2_text.ForeColor = System.Drawing.Color.White;
            this.button2_text.Location = new System.Drawing.Point(20, 177);
            this.button2_text.Name = "button2_text";
            this.button2_text.Size = new System.Drawing.Size(340, 23);
            this.button2_text.TabIndex = 41;
            // 
            // button1_url
            // 
            this.button1_url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.button1_url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button1_url.ForeColor = System.Drawing.Color.White;
            this.button1_url.Location = new System.Drawing.Point(20, 95);
            this.button1_url.Name = "button1_url";
            this.button1_url.Size = new System.Drawing.Size(340, 23);
            this.button1_url.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Button 1 text";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Button 1 url";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Button 2 url";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Button 2 text";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(434, 278);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 80;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // show_hidden
            // 
            this.show_hidden.Enabled = true;
            // 
            // show_hidden_settings
            // 
            this.show_hidden_settings.Location = new System.Drawing.Point(421, 358);
            this.show_hidden_settings.Name = "show_hidden_settings";
            this.show_hidden_settings.Size = new System.Drawing.Size(68, 25);
            this.show_hidden_settings.TabIndex = 81;
            this.show_hidden_settings.Text = "button7";
            this.show_hidden_settings.UseVisualStyleBackColor = true;
            this.show_hidden_settings.Click += new System.EventHandler(this.show_hidden_settings_Click);
            // 
            // hidden_client_deinitialize
            // 
            this.hidden_client_deinitialize.Location = new System.Drawing.Point(531, 34);
            this.hidden_client_deinitialize.Name = "hidden_client_deinitialize";
            this.hidden_client_deinitialize.Size = new System.Drawing.Size(113, 23);
            this.hidden_client_deinitialize.TabIndex = 82;
            this.hidden_client_deinitialize.Text = "client.Deinitialize";
            this.hidden_client_deinitialize.UseVisualStyleBackColor = true;
            this.hidden_client_deinitialize.Click += new System.EventHandler(this.hidden_client_deinitialize_Click);
            // 
            // hidden_client_initialize
            // 
            this.hidden_client_initialize.Location = new System.Drawing.Point(531, 63);
            this.hidden_client_initialize.Name = "hidden_client_initialize";
            this.hidden_client_initialize.Size = new System.Drawing.Size(113, 23);
            this.hidden_client_initialize.TabIndex = 83;
            this.hidden_client_initialize.Text = "client.Initialize";
            this.hidden_client_initialize.UseVisualStyleBackColor = true;
            this.hidden_client_initialize.Click += new System.EventHandler(this.hidden_client_initialize_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(531, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 84;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(400, 469);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.hidden_client_initialize);
            this.Controls.Add(this.hidden_client_deinitialize);
            this.Controls.Add(this.show_hidden_settings);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel_buttons);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.config_savecurrentas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.config_button);
            this.Controls.Add(this.startup);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menu_indicator);
            this.Controls.Add(this.menu_config);
            this.Controls.Add(this.button_hide);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.update_presence);
            this.Controls.Add(this.menu_main);
            this.Controls.Add(this.menu_images);
            this.Controls.Add(this.menu_buttons);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ch_showbuttons1dd);
            this.Controls.Add(this.menu_config1);
            this.Controls.Add(this.menu_buttons1);
            this.Controls.Add(this.menu_images1);
            this.Controls.Add(this.menu_main1);
            this.Controls.Add(this.update_presence1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_config);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_images);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel_images.ResumeLayout(false);
            this.panel_images.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel_config.ResumeLayout(false);
            this.panel_config.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel_buttons.ResumeLayout(false);
            this.panel_buttons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog configFile;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroCheckBox ch_showbuttons1dd;
        private System.Windows.Forms.SaveFileDialog config_create;
        private System.Windows.Forms.SaveFileDialog config_saveas;
        private System.Windows.Forms.Button hidden_client_initialize;
        private System.Windows.Forms.Button update_presence1;
        private System.Windows.Forms.Button menu_config1;
        private System.Windows.Forms.Button menu_buttons1;
        private System.Windows.Forms.Button menu_images1;
        private System.Windows.Forms.Button menu_main1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label menu_indicator;
        private FontAwesome.Sharp.IconButton menu_config;
        private FontAwesome.Sharp.IconButton update_presence;
        private FontAwesome.Sharp.IconButton menu_main;
        private FontAwesome.Sharp.IconButton menu_images;
        private FontAwesome.Sharp.IconButton menu_buttons;
        private System.Windows.Forms.Panel panel_images;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.TextBox clientid;
        private System.Windows.Forms.TextBox details;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel_config;
        private System.Windows.Forms.Button startup;
        private MetroFramework.Controls.MetroCheckBox ch_hidden;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label config_current;
        private System.Windows.Forms.TextBox image2_text;
        private System.Windows.Forms.TextBox image2_key;
        private System.Windows.Forms.TextBox image1_text;
        private System.Windows.Forms.TextBox image1_key;
        private FontAwesome.Sharp.IconButton button_close;
        private FontAwesome.Sharp.IconButton button_hide;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private FontAwesome.Sharp.IconButton cfg_openfolder;
        private FontAwesome.Sharp.IconButton cfg_saveas;
        private FontAwesome.Sharp.IconButton cfg_create;
        private FontAwesome.Sharp.IconButton cfg_select;
        private System.Windows.Forms.Button config_savecurrentas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button config_button;
        private System.Windows.Forms.Timer autoupdate;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.CheckBox ch_showbuttons_old;
        private System.Windows.Forms.TextBox button1_text;
        private System.Windows.Forms.TextBox button2_url;
        private System.Windows.Forms.TextBox button2_text;
        private System.Windows.Forms.TextBox button1_url;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroCheckBox ch_showbuttons;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer show_hidden;
        private System.Windows.Forms.Button show_hidden_settings;
        private System.Windows.Forms.Button hidden_client_deinitialize;
        private System.Windows.Forms.Button button3;
    }
}

