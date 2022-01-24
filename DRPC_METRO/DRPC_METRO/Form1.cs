using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Drawing;
using MetroFramework.Interfaces;
using System.IO;
using System.DirectoryServices;
using System.Runtime.InteropServices;
using DiscordRPC;

namespace DRPC_METRO
{


    
    public partial class Form1 : Form
    {
       
        bool changeMenuButtonsBack = false;
       
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(400, 469);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_main.BringToFront();
            panel_images.BringToFront();
            panel_buttons.BringToFront();
            panel_config.BringToFront();

            if (changeMenuButtonsBack == true)
            {
                menu_main.BackColor = Color.FromArgb(33, 36, 43);
            }

            if (!Directory.Exists("C:\\discord_presence_2") || !File.Exists("C:\\discord_presence_2\\main.ini"))
            {
                Directory.CreateDirectory("C:\\discord_presence_2");
                INIManager managerMain = new INIManager("C:\\discord_presence_2\\main.ini");
                managerMain.WritePrivateString("main", "config", "C:\\discord_presence_2\\configs\\settings.ini");
                managerMain.WritePrivateString("main", "hidden", "false");

                Directory.CreateDirectory("C:\\discord_presence_2\\configs");
                INIManager manager = new INIManager("C:\\discord_presence_2\\configs\\settings.ini");

                manager.WritePrivateString("main", "clientid", "847801650089426954");
                manager.WritePrivateString("main", "details", "Details");
                manager.WritePrivateString("main", "state", "State");

                //IMAGES
                manager.WritePrivateString("images", "1key", "large");
                manager.WritePrivateString("images", "1text", "Large image hovered");

                manager.WritePrivateString("images", "2key", "small");
                manager.WritePrivateString("images", "2text", "Small image hovered");

                //BUTTONS
                manager.WritePrivateString("buttons", "1text", "Button 1 text");
                manager.WritePrivateString("buttons", "1url", "https://google.com");

                manager.WritePrivateString("buttons", "2text", "Button 2 text");
                manager.WritePrivateString("buttons", "2url", "https://google.com");

                manager.WritePrivateString("buttons", "show", "true");


                Application.Restart();
                Environment.Exit(0);
            }
            else
            {
                if (File.Exists("C:\\discord_presence_2\\main.ini"))
                {
                    INIManager managerMain = new INIManager("C:\\discord_presence_2\\main.ini");
                    string savedConfig = managerMain.GetPrivateString("main", "config");
                    string savedHiddenState = managerMain.GetPrivateString("main", "hidden");
                    config_current.Text = savedConfig;

                    if (savedHiddenState == "true")
                    {
                        ch_hidden.Checked = true;
                        ShowInTaskbar = false;
                        Hide();
                    }
                    else
                    {
                        ch_hidden.Checked = false;
                        ShowInTaskbar = true;
                        Show();
                    }
                    
                    if (File.Exists(savedConfig))
                    {
                        //MessageBox.Show($"{savedConfig} exists");
                        INIManager manager = new INIManager(savedConfig);
                        string _clientid = manager.GetPrivateString("main", "clientid");
                        string _details = manager.GetPrivateString("main", "details");
                        string _state = manager.GetPrivateString("main", "state");

                        clientid.Text = _clientid;
                        details.Text = _details;
                        state.Text = _state;

                        //IMAGES
                        string _image1_key = manager.GetPrivateString("images", "1key");
                        string _image1_text = manager.GetPrivateString("images", "1text");
                        image1_key.Text = _image1_key;
                        image1_text.Text = _image1_text;

                        string _image2_key = manager.GetPrivateString("images", "2key");
                        string _image2_text = manager.GetPrivateString("images", "2text");
                        image2_key.Text = _image2_key;
                        image2_text.Text = _image2_text;

                        //BUTTONS
                        string _button1_text = manager.GetPrivateString("buttons", "1text");
                        string _button1_url = manager.GetPrivateString("buttons", "1url");
                        button1_text.Text = _button1_text;
                        button1_url.Text = _button1_url;
                        Uri convert1 = new Uri(button1_url.Text);
                        string button1_converted = convert1.AbsoluteUri;

                        string _button2_text = manager.GetPrivateString("buttons", "2text");
                        string _button2_url = manager.GetPrivateString("buttons", "2url");
                        button2_text.Text = _button2_text;
                        button2_url.Text = _button2_url;
                        Uri convert2 = new Uri(button2_url.Text);
                        string button2_converted = convert2.AbsoluteUri;

                        string _buttonstate = manager.GetPrivateString("buttons", "show");
                        DiscordRpcClient client = new DiscordRpcClient(clientid.Text);
                        if (_buttonstate == "true")
                        {
                            ch_showbuttons.Checked = true;
                            if (button2_text.Text == "")
                            {
                                client.Initialize();
                                {
                                    client.SetPresence(new DiscordRPC.RichPresence()
                                    {
                                        

                                    Details = details.Text, //details
                                        State = state.Text, //state
                                                            //Timestamps = Timestamps.Now, //что бы убрать счетчик времени просто удали эту строку
                                        Assets = new Assets()
                                        {
                                            LargeImageKey = image1_key.Text, //название большой картинки
                                            LargeImageText = image1_text.Text, //текст, отображаемый при наведении на большую картинку
                                            SmallImageKey = image2_key.Text, //название большой картинки
                                            SmallImageText = image2_text.Text //текст, отображаемый при наведении на маленькую картинку
                                        },

                                        //КНОПКИ
                                        Buttons = new DiscordRPC.Button[]
                                        {
                                            new DiscordRPC.Button() { Label = button1_text.Text, Url = $"{button1_converted}"},
                                        },
                                    });
                                }
                                
                            }
                            else
                            {      
                                client.Initialize();
                                {
                                    client.SetPresence(new DiscordRPC.RichPresence()
                                    {
                                        Details = details.Text, //details
                                        State = state.Text, //state
                                                            //Timestamps = Timestamps.Now, //что бы убрать счетчик времени просто удали эту строку
                                        Assets = new Assets()
                                        {
                                            LargeImageKey = image1_key.Text, //название большой картинки
                                            LargeImageText = image1_text.Text, //текст, отображаемый при наведении на большую картинку
                                            SmallImageKey = image2_key.Text, //название большой картинки
                                            SmallImageText = image2_text.Text //текст, отображаемый при наведении на маленькую картинку
                                        },

                                        //КНОПКИ
                                        Buttons = new DiscordRPC.Button[]
                                        {
                                            new DiscordRPC.Button() { Label = button1_text.Text, Url = $"{button1_converted}"},
                                            new DiscordRPC.Button() { Label = button2_text.Text, Url = $"{button2_converted}"},
                                        },
                                    });
                                }
                            }
                            
                        }
                        else
                        {
                            ch_showbuttons.Checked = false;
                            client.Initialize();
                            {
                                client.SetPresence(new DiscordRPC.RichPresence()
                                {
                                    Details = details.Text, //details
                                    State = state.Text, //state
                                    Assets = new Assets()
                                    {
                                        LargeImageKey = image1_key.Text, //название большой картинки
                                        LargeImageText = image1_text.Text, //текст, отображаемый при наведении на большую картинку
                                        SmallImageKey = image2_key.Text, //название большой картинки
                                        SmallImageText = image2_text.Text //текст, отображаемый при наведении на маленькую картинку
                                    },
                                });
                            }
                        }
                    }
                }
                else
                {
                    INIManager managerMain = new INIManager("C:\\discord_presence_2\\main.ini");
                    string savedConfig = managerMain.GetPrivateString("main", "config");
                }  
            }
        }

       

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void hide_Click(object sender, EventArgs e)
        {
            Hide();
            ShowInTaskbar = false;
            tray.Visible = true;
        }

        private void tray_Click(object sender, EventArgs e)
        {
            Show();
            ShowInTaskbar = true;
            tray.Visible = false;
            WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Normal;
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void config_button_Click(object sender, EventArgs e)
        {
            configFile.ShowDialog();
        }

        private void configFile_FileOk(object sender, CancelEventArgs e)
        {
            string selectedConffig = configFile.FileName;
            //MessageBox.Show("Config: " + selectedConffig);

            INIManager managerMain = new INIManager("C:\\discord_presence_2\\main.ini");
            //string savedConfig = managerMain.GetPrivateString("main", "config");
            managerMain.WritePrivateString("main", "config", selectedConffig);
            Application.Restart();
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            INIManager managerMain = new INIManager("C:\\discord_presence_2\\main.ini");
            string savedConfig = managerMain.GetPrivateString("main", "config");

            INIManager manager = new INIManager(savedConfig);
            manager.WritePrivateString("main", "clientid", clientid.Text);
            manager.WritePrivateString("main", "details", details.Text);
            manager.WritePrivateString("main", "state", state.Text);

            //IMAGES
            manager.WritePrivateString("images", "1key", image1_key.Text);
            manager.WritePrivateString("images", "1text", image1_text.Text);

            manager.WritePrivateString("images", "2key", image2_key.Text);
            manager.WritePrivateString("images", "2text", image2_text.Text);

            //BUTTONS
            manager.WritePrivateString("buttons", "1text", button1_text.Text);
            manager.WritePrivateString("buttons", "1url", button1_url.Text);

            manager.WritePrivateString("buttons", "2text", button2_text.Text);
            manager.WritePrivateString("buttons", "2url", button2_url.Text);

            if (ch_showbuttons.Checked == true)
            {
                manager.WritePrivateString("buttons", "show", "true");
            }
            else
            {
                manager.WritePrivateString("buttons", "show", "false");
            }
            
        }

        private void update_presence_Click_3(object sender, EventArgs e)
        {
            //MessageBox.Show(client.SteamID);
            INIManager managerMain = new INIManager("C:\\discord_presence_2\\main.ini");
            string savedConfig = managerMain.GetPrivateString("main", "config");
            //MessageBox.Show("Saving to: " + savedConfig);

            string savedHiddenState = managerMain.GetPrivateString("main", "hidden");

            INIManager manager = new INIManager(savedConfig);

            if (ch_showbuttons.Checked == true)
            {
                manager.WritePrivateString("buttons", "show", "true");
            }
            else
            {
                manager.WritePrivateString("buttons", "show", "false");
            }

            INIManager checkClient = new INIManager(savedConfig);
            string GetSavedClient = checkClient.GetPrivateString("main", "clientid");
            bool beta_no_restart = false;
            if (beta_no_restart == true/*clientid.Text == GetSavedClient*/)
            {

                if (ch_hidden.Checked == true)
                {
                    managerMain.WritePrivateString("main", "hidden", "true");
                }
                else
                {
                    managerMain.WritePrivateString("main", "hidden", "false");
                }


                manager.WritePrivateString("main", "clientid", clientid.Text);
                manager.WritePrivateString("main", "details", details.Text);
                manager.WritePrivateString("main", "state", state.Text);

                //IMAGES
                manager.WritePrivateString("images", "1key", image1_key.Text);
                manager.WritePrivateString("images", "1text", image1_text.Text);

                manager.WritePrivateString("images", "2key", image2_key.Text);
                manager.WritePrivateString("images", "2text", image2_text.Text);

                //BUTTONS
                manager.WritePrivateString("buttons", "1text", button1_text.Text);
                manager.WritePrivateString("buttons", "1url", button1_url.Text);

                manager.WritePrivateString("buttons", "2text", button2_text.Text);
                manager.WritePrivateString("buttons", "2url", button2_url.Text);
            }
            else
            {
                if (ch_hidden.Checked == true)
                {
                    managerMain.WritePrivateString("main", "hidden", "true");
                }
                else
                {
                    managerMain.WritePrivateString("main", "hidden", "false");
                }

                //INIManager manager = new INIManager(savedConfig);
                manager.WritePrivateString("main", "clientid", clientid.Text);
                manager.WritePrivateString("main", "details", details.Text);
                manager.WritePrivateString("main", "state", state.Text);

                //IMAGES
                manager.WritePrivateString("images", "1key", image1_key.Text);
                manager.WritePrivateString("images", "1text", image1_text.Text);

                manager.WritePrivateString("images", "2key", image2_key.Text);
                manager.WritePrivateString("images", "2text", image2_text.Text);

                //BUTTONS
                manager.WritePrivateString("buttons", "1text", button1_text.Text);
                manager.WritePrivateString("buttons", "1url", button1_url.Text);

                manager.WritePrivateString("buttons", "2text", button2_text.Text);
                manager.WritePrivateString("buttons", "2url", button2_url.Text);
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void menu_config_Click(object sender, EventArgs e)
        {
            menu_indicator.Location = new Point(0, 144);

            panel_main.Visible = false;
            panel_images.Visible = false;
            panel_buttons.Visible = false;
            panel_config.Visible = true;
        }

        private void config_button_Click_1(object sender, EventArgs e)
        {
            configFile.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            config_create.ShowDialog();
        }

        private void config_create_FileOk(object sender, CancelEventArgs e)
        {
            string createdFile = config_create.FileName;

            INIManager manager = new INIManager(createdFile);
            manager.WritePrivateString("main", "clientid", "847801650089426954");
            manager.WritePrivateString("main", "details", "Details");
            manager.WritePrivateString("main", "state", "State");

            //IMAGES
            manager.WritePrivateString("images", "1key", "large");
            manager.WritePrivateString("images", "1text", "Large image hovered");

            manager.WritePrivateString("images", "2key", "small");
            manager.WritePrivateString("images", "2text", "Small image hovered");

            //BUTTONS
            manager.WritePrivateString("buttons", "1text", "Button 1 text");
            manager.WritePrivateString("buttons", "1url", "https://google.com");

            manager.WritePrivateString("buttons", "2text", "Button 2 text");
            manager.WritePrivateString("buttons", "2url", "https://google.com");

            manager.WritePrivateString("buttons", "show", "true");

            MessageBox.Show("Config " + createdFile + " created!");  
        }

        private void config_savecurrentas_Click(object sender, EventArgs e)
        {
            config_saveas.ShowDialog();
        }

        private void config_saveas_FileOk(object sender, CancelEventArgs e)
        {
            string createdFile = config_saveas.FileName;
            INIManager manager = new INIManager(createdFile);
            manager.WritePrivateString("main", "clientid", clientid.Text);
            manager.WritePrivateString("main", "details", details.Text);
            manager.WritePrivateString("main", "state", state.Text);

            //IMAGES
            manager.WritePrivateString("images", "1key", image1_key.Text);
            manager.WritePrivateString("images", "1text", image1_text.Text);

            manager.WritePrivateString("images", "2key", image2_key.Text);
            manager.WritePrivateString("images", "2text", image2_text.Text);

            //BUTTONS
            manager.WritePrivateString("buttons", "1text", button1_text.Text);
            manager.WritePrivateString("buttons", "1url", button1_url.Text);

            manager.WritePrivateString("buttons", "2text", button2_text.Text);
            manager.WritePrivateString("buttons", "2url", button2_url.Text);

            if (ch_showbuttons.Checked == true)
            {
                manager.WritePrivateString("buttons", "show", "true");
            }
            else
            {
                manager.WritePrivateString("buttons", "show", "false");
            }
            MessageBox.Show("Current settings saved to " + createdFile + "!");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start("https://discord.com/developers/applications");
            System.Diagnostics.Process.Start("https://discord.com/developers/applications");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Hide();
            ShowInTaskbar = false;
            tray.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized && this.ShowInTaskbar == true && this.Visible == true)
            {
                Hide();
                ShowInTaskbar = false;
                tray.Visible = true;
                //MessageBox.Show("min");
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                //Hide();
                ShowInTaskbar = false;
                tray.Visible = true;
                this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button4_MouseEnter_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void button4_MouseLeave_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            ShowInTaskbar = false;
            tray.Visible = true;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
                button5.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");

        }

        private void menu_main_Click_3(object sender, EventArgs e)
        {
            menu_indicator.Location = new Point(0, 52);
            if (changeMenuButtonsBack == true)
            {
                menu_main.BackColor = Color.FromArgb(33, 36, 43);
                menu_images.BackColor = Color.FromArgb(51, 56, 69);
                menu_buttons.BackColor = Color.FromArgb(51, 56, 69);
                menu_config.BackColor = Color.FromArgb(51, 56, 69);
            }
            panel_main.Visible = true;
            panel_images.Visible = false;
            panel_buttons.Visible = false;
            panel_config.Visible = false;
        }

        private void menu_images_Click_3(object sender, EventArgs e)
        {
            menu_indicator.Location = new Point(100, 52);

            if (changeMenuButtonsBack == true)
            {
                menu_main.BackColor = Color.FromArgb(51, 56, 69);
                menu_images.BackColor = Color.FromArgb(33, 36, 43);
                menu_buttons.BackColor = Color.FromArgb(51, 56, 69);
                menu_config.BackColor = Color.FromArgb(51, 56, 69);
            }

            panel_main.Visible = false;
            panel_images.Visible = true;
            panel_buttons.Visible = false;
            panel_config.Visible = false;
        }

        private void menu_buttons_Click_3(object sender, EventArgs e)
        {
            menu_indicator.Location = new Point(200, 52);

            if (changeMenuButtonsBack == true)
            {
                menu_main.BackColor = Color.FromArgb(51, 56, 69);
                menu_images.BackColor = Color.FromArgb(51, 56, 69);
                menu_buttons.BackColor = Color.FromArgb(33, 36, 43);
                menu_config.BackColor = Color.FromArgb(51, 56, 69);
            }

            panel_main.Visible = false;
            panel_images.Visible = false;
            panel_buttons.Visible = true;
            panel_config.Visible = false;
        }

        private void menu_config_Click_2(object sender, EventArgs e)
        {
            menu_indicator.Location = new Point(300, 52);

            if (changeMenuButtonsBack == true)
            {
                menu_main.BackColor = Color.FromArgb(51, 56, 69);
                menu_images.BackColor = Color.FromArgb(51, 56, 69);
                menu_buttons.BackColor = Color.FromArgb(51, 56, 69);
                menu_config.BackColor = Color.FromArgb(33, 36, 43);
            }
            
            panel_main.Visible = false;
            panel_images.Visible = false;
            panel_buttons.Visible = false;
            panel_config.Visible = true;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_hide_Click(object sender, EventArgs e)
        {
            Hide();
            ShowInTaskbar = false;
            tray.Visible = true;
        }

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://discord.com/developers/applications");
        }

        private void cfg_select_Click_1(object sender, EventArgs e)
        {
            configFile.ShowDialog();
        }

        private void cfg_create_Click(object sender, EventArgs e)
        {
            config_create.ShowDialog();
        }

        private void cfg_saveas_Click(object sender, EventArgs e)
        {
            config_saveas.ShowDialog();
        }

        private void cfg_openfolder_Click(object sender, EventArgs e)
        {
            string user = Environment.UserName;
            System.Diagnostics.Process.Start("explorer", "C:\\discord_presence_2");
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do not fill 'button 2 text' if you need only 1 button!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            INIManager managerMain = new INIManager("C:\\discord_presence_2\\main.ini");
            string savedConfig = managerMain.GetPrivateString("main", "config");
            //MessageBox.Show("Saving to: " + savedConfig);

            string savedHiddenState = managerMain.GetPrivateString("main", "hidden");

            INIManager manager = new INIManager(savedConfig);

            if (ch_showbuttons.Checked == true)
            {
                manager.WritePrivateString("buttons", "show", "true");
            }
            else
            {
                manager.WritePrivateString("buttons", "show", "false");
            }

            INIManager checkClient = new INIManager(savedConfig);
            string GetSavedClient = checkClient.GetPrivateString("main", "clientid");
            if (clientid.Text == GetSavedClient)
            {
                if (ch_hidden.Checked == true)
                {
                    managerMain.WritePrivateString("main", "hidden", "true");
                }
                else
                {
                    managerMain.WritePrivateString("main", "hidden", "false");
                }


                manager.WritePrivateString("main", "clientid", clientid.Text);
                manager.WritePrivateString("main", "details", details.Text);
                manager.WritePrivateString("main", "state", state.Text);

                //IMAGES
                manager.WritePrivateString("images", "1key", image1_key.Text);
                manager.WritePrivateString("images", "1text", image1_text.Text);

                manager.WritePrivateString("images", "2key", image2_key.Text);
                manager.WritePrivateString("images", "2text", image2_text.Text);

                //BUTTONS
                manager.WritePrivateString("buttons", "1text", button1_text.Text);
                manager.WritePrivateString("buttons", "1url", button1_url.Text);

                manager.WritePrivateString("buttons", "2text", button2_text.Text);
                manager.WritePrivateString("buttons", "2url", button2_url.Text);
            }
            else
            {
                //MessageBox.Show($"Client id's:\nOLD: {GetSavedClient}\nNEW: {clientid.Text}\nchange status: NOT match");

                if (ch_hidden.Checked == true)
                {
                    managerMain.WritePrivateString("main", "hidden", "true");
                }
                else
                {
                    managerMain.WritePrivateString("main", "hidden", "false");
                }

                //INIManager manager = new INIManager(savedConfig);
                manager.WritePrivateString("main", "clientid", clientid.Text);
                manager.WritePrivateString("main", "details", details.Text);
                manager.WritePrivateString("main", "state", state.Text);

                //IMAGES
                manager.WritePrivateString("images", "1key", image1_key.Text);
                manager.WritePrivateString("images", "1text", image1_text.Text);

                manager.WritePrivateString("images", "2key", image2_key.Text);
                manager.WritePrivateString("images", "2text", image2_text.Text);

                //BUTTONS
                manager.WritePrivateString("buttons", "1text", button1_text.Text);
                manager.WritePrivateString("buttons", "1url", button1_url.Text);

                manager.WritePrivateString("buttons", "2text", button2_text.Text);
                manager.WritePrivateString("buttons", "2url", button2_url.Text);
                //Application.Restart();
                //Environment.Exit(0);
            }
        }

        private void show_hidden_settings_Click(object sender, EventArgs e)
        {
            int formHeight = this.Height;
            int formWidth = this.Width;

            if (formWidth == 400)
            {
                this.Size = new Size(700, 469);
            }
            else
            {
                this.Size = new Size(400, 469);
            }
        }

        private void hidden_client_initialize_Click(object sender, EventArgs e)
        {
            //client.Invoke();
            MessageBox.Show("Client initialized");
        }

        private void hidden_client_deinitialize_Click(object sender, EventArgs e)
        {
            //client.Deinitialize();
            MessageBox.Show("Client deinitialized");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form2 settingsForm = new Form2();
            settingsForm.Show();
            var t = Task.Delay(2000);
            t.Wait();
            settingsForm.Hide();
        }
    }


    public class INIManager
    {
        //Конструктор, принимающий путь к INI-файлу
        public INIManager(string aPath)
        {
            path = aPath;
        }

        //Конструктор без аргументов (путь к INI-файлу нужно будет задать отдельно)
        public INIManager() : this("") { }

        //Возвращает значение из INI-файла (по указанным секции и ключу) 
        public string GetPrivateString(string aSection, string aKey)
        {
            //Для получения значения
            StringBuilder buffer = new StringBuilder(SIZE);

            //Получить значение в buffer
            GetPrivateString(aSection, aKey, null, buffer, SIZE, path);

            //Вернуть полученное значение
            return buffer.ToString();
        }

        //Пишет значение в INI-файл (по указанным секции и ключу) 
        public void WritePrivateString(string aSection, string aKey, string aValue)
        {
            //Записать значение в INI-файл
            WritePrivateString(aSection, aKey, aValue, path);
        }

        //Возвращает или устанавливает путь к INI файлу
        public string Path { get { return path; } set { path = value; } }

        //Поля класса
        private const int SIZE = 1024; //Максимальный размер (для чтения значения из файла)
        private string path = null; //Для хранения пути к INI-файлу

        //Импорт функции GetPrivateProfileString (для чтения значений) из библиотеки kernel32.dll
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileString")]
        private static extern int GetPrivateString(string section, string key, string def, StringBuilder buffer, int size, string path);

        //Импорт функции WritePrivateProfileString (для записи значений) из библиотеки kernel32.dll
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileString")]
        private static extern int WritePrivateString(string section, string key, string str, string path);
    }

    
}


