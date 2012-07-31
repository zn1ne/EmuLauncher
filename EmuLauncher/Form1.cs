using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EmuLauncher : Form
    {
        public EmuLauncher()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["EmuLauncher"].BringToFront();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void cancelSelectEmu_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEmu = comboBox1.GetItemText(comboBox1.SelectedItem);
        }

        private void aboutThisProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.Show();
        }

        private void selectEmu_Click(object sender, EventArgs e)
        {
            string selectedEmu = comboBox1.GetItemText(comboBox1.SelectedItem);           

            if (String.ReferenceEquals(selectedEmu, "NES"))
                if (System.IO.File.Exists(@"..\..\Emulators\NES\nestopia.exe"))
                    System.Diagnostics.Process.Start(@"..\..\Emulators\NES\nestopia.exe");
                else
                {
                    nesNoExist d = new nesNoExist();
                    d.Show();
                }
            else
                if (String.ReferenceEquals(selectedEmu, "SNES"))
                    System.Diagnostics.Process.Start(@"..\..\Emulators\SNES\snes9x.exe");
                else
                    if (String.ReferenceEquals(selectedEmu, "Get ROMS"))
                        System.Diagnostics.Process.Start("http://www.coolrom.com/roms/");
                    else
                        if (String.ReferenceEquals(selectedEmu, "Playstation 1"))
                            System.Diagnostics.Process.Start(@"..\..\Emulators\PS1\ePSXe.exe");
                        else
                            if (String.ReferenceEquals(selectedEmu, "Playstation 2"))
                                System.Diagnostics.Process.Start(@"..\..\Emulators\PS2\pcsx2.exe");
                            else
                                if (String.ReferenceEquals(selectedEmu, "Atari"))
                                    System.Diagnostics.Process.Start(@"..\..\Emulators\Atari\stella.exe");
                               
                                else
                                    if (String.ReferenceEquals(selectedEmu, "Gameboy / Gameboy Advance"))
                                        System.Diagnostics.Process.Start(@"..\..\Emulators\GBA\GBA.exe");
                                    else
                                            if (String.ReferenceEquals(selectedEmu, "GameCube / Wii"))
                                                System.Diagnostics.Process.Start(@"..\..\Emulators\WII\Dolphin.exe");
                                            else
                                                if (String.ReferenceEquals(selectedEmu, "DOS"))
                                                    System.Diagnostics.Process.Start(@"..\..\Emulators\DOS\DOSBox.exe");
                                                
                                                else
                                                   if (String.ReferenceEquals(selectedEmu, "DS"))
                                                    System.Diagnostics.Process.Start(@"..\..\Emulators\DS\DeSmuME.exe");
                                                       
                                                        else
                                                            if (String.ReferenceEquals(selectedEmu, "PSP - NYI"))
                                                            //System.Diagnostics.Process.Start(@"..\..\Emulators\PSP\psp.exe");
                                                            {
                                                                Nyi d = new Nyi();
                                                                d.Show();
                                                            }
                                                            else
                             {
                                 SoundPlayer simpleSound = new SoundPlayer(@"..\..\sounds\error.wav");
                                 simpleSound.Play();
                                 nonSelect c = new nonSelect();
                                 c.Show();
                             }
        }
    }

}
