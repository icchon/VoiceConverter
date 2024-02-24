using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Gui;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;




namespace AudioPlayX
{
    public partial class Form1 : Form
    {
        private bool of_flg { get; set; } = false;
        private IWavePlayer wavePlayer {  get; set; }
        private IWavePlayer wavePlayerInput {  get; set; }
        private AudioFileReader audioFileReader { get; set; }
        private AudioFileReader audioFileReaderInput { get; set; }
        private string inputFileName;
        private string outputFileName;
        private int audioSecond {  get; set; }
        private int interval { get; set; } = 60;



        public Form1()
        {
            InitializeComponent();
        }

        private void mItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private IWavePlayer CreateWavePlayer(int sn)
        {
            switch (sn)
            {
                case 2:
                    return new WaveOutEvent();
                case 1:
                    return new WaveOut(WaveCallbackInfo.FunctionCallback());
                default:
                    return new WaveOut();
            }
        }

        private void EnableButtons(bool play_flg)
        {
            btnPlay.Enabled = play_flg;
            btnPause.Enabled = play_flg;
            btnPlayInput.Enabled = play_flg;
            btnPauseInput.Enabled = play_flg;   
        }

        private static string FormatTimeSpan(TimeSpan ts)
        {
            return string.Format("{0:D2}:{1:D2}", (int)ts.TotalMinutes, (int)ts.Seconds);
        }

        private void OnTimerTick1(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                var s1 = FormatTimeSpan(audioFileReader.CurrentTime);
                playTimeLabel.Text = s1;
                var s2 = FormatTimeSpan(audioFileReader.TotalTime);
                playTotalTime.Text = s2;

                var n  = (int)audioFileReader.TotalTime.TotalMilliseconds;
                progressBar1.Maximum = (int)(n*0.9);
                progressBar1.Increment(interval);
            }
        }

        private void OnTimerTick2(object sender, EventArgs e)
        {

            if (audioFileReaderInput != null)
            {
                var s1 = FormatTimeSpan(audioFileReaderInput.CurrentTime);
                playTimeLabelInput.Text = s1;
                var s2 = FormatTimeSpan(audioFileReaderInput.TotalTime);
                playTotalTimeInput.Text = s2;

                var n = (int)audioFileReaderInput.TotalTime.TotalMilliseconds;
                progressBar2.Maximum = (int)(n * 0.9);
                progressBar2.Increment(interval);
            }
        }

        private void OnPlayStopped(object sender, StoppedEventArgs e)
        {
            Debug.Assert(!InvokeRequired, "ワーニング・スレッドPlaybackStopped");
            CleanUp();
            btnPause.Enabled = false;
            btnPlay.Enabled = true;
            btnPauseInput.Enabled = false;
            btnPlayInput.Enabled = true;    
            InitializeTimer();
            if (e.Exception != null)
            {
                MessageBox.Show(String.Format("Playback Stoppedエラー{e.Exception.Message}"));
            }

        }

        private void InitializeTimer()
        {
            timer1.Enabled = false;

            playTimeLabel.Text = "00:00";
            playTotalTime.Text = "00:00";
            playTimeLabelInput.Text = "00:00";
            playTotalTimeInput.Text = "00:00";
            progressBar1.Value = 0;
            progressBar2.Value = 0;
        }

        private void CleanUp()
        {
            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }
            if (wavePlayer != null)
            {
                wavePlayer.Dispose();
                wavePlayer = null;
            }

            if (audioFileReaderInput != null)
            {
                audioFileReaderInput.Dispose();
                audioFileReaderInput = null;
            }
            if (wavePlayerInput != null)
            {
                wavePlayerInput.Dispose();
                wavePlayerInput = null;
            }
            //of_flg = false;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            of_flg = false;
            EnableButtons(false);
            comboBoxOutputDriver.Items.Add("WaveOut Window コールバック");
            comboBoxOutputDriver.Items.Add("WaveOut 関数コールバック");
            comboBoxOutputDriver.Items.Add("WaveOut イベント・コールバック");
            comboBoxOutputDriver.SelectedIndex = 0;
            timer1.Interval = interval;
            timer2.Interval = interval;
            timer1.Tick += OnTimerTick1;
            timer2.Tick += OnTimerTick2;
            
        }

        private async void mItemOpen_Click(object sender, EventArgs e)
        {
            var of_dlg = new OpenFileDialog();
            of_dlg.Title = "サウンドファイルの選択";
            of_dlg.Filter = "WAV形式 *.wav|*.WAV| MP3形式 *.mp3|*.MP3| AIFF形式 *.aiff|*.AIFF";
            of_dlg.RestoreDirectory = true;
            of_dlg.CheckFileExists = true;

            if (of_dlg.ShowDialog() == DialogResult.OK)
            {
                var filePath = of_dlg.FileName;
                if (filePath != null)
                {
                    checkBox.Checked = false;
                    inputFileName = filePath;
                    toolStripStatusLabel1.Text = filePath;
                    of_flg = true;
                    
                    
                    CleanUp();
                    InitializeTimer();
                    PauseUI();

                    
                    using (var reader = new AudioFileReader(filePath))
                    {
                        using (var writer = new WaveFileWriter("input.wav", reader.WaveFormat))
                        {
                            reader.CopyTo(writer);
                        }
                    }
                    
                    //string destinationPath = "input.wav";
                    //File.Copy(filePath, destinationPath, true);
                    convert.Text = "変換中　";

                    await Task.Run(() => Wav2Text());

                    convert.Text = "変換終了";
                    RestartUI();


                }
            }

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
        
            if (audioFileReader == null)
            {
                audioFileReader = new AudioFileReader(outputFileName);
            }

            if (wavePlayer == null)
            {
                wavePlayer = CreateWavePlayer(comboBoxOutputDriver.SelectedIndex);
                wavePlayer.Init(audioFileReader);
                
            }

            audioFileReader.Volume = trackBar.Value;
            wavePlayer.PlaybackStopped += OnPlayStopped;
            wavePlayer.Play();
            btnPlay.Enabled = false;
            btnPause.Enabled = true;
            timer1.Enabled = true;

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (of_flg)
            {
                wavePlayer.Pause();
            }
            btnPlay.Enabled = true;
            btnPause.Enabled = false;
            timer1.Enabled = false;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            if (wavePlayer != null)
            {
                var volumeScaled = (float)(trackBar.Value - trackBar.Minimum) / (float)(trackBar.Maximum - trackBar.Minimum);
                wavePlayer.Volume = volumeScaled;
            }
        }

        private async void Wav2Text()
        {
            string myPythonApp = "audio_play.py";


            var myProcess = new Process
            {
                StartInfo = new ProcessStartInfo("python.exe")
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    Arguments = myPythonApp,
                }
            };

            
            myProcess.Start();
            //StreamReader myStreamReader = myProcess.StandardOutput;
            //string myString = myStreamReader.ReadLine();
            myProcess.WaitForExit();
            myProcess.Close();

            var outputString = File.ReadAllText("./output.txt", Encoding.Default);
           
            var synthesizer = new SpeechSynthesizer();
            outputFileName = "output.wav";
            synthesizer.SetOutputToWaveFile(outputFileName);
            synthesizer.Speak(outputString);
            synthesizer.SetOutputToDefaultAudioDevice();

      
             
        }

        private void playTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnPlayInput_Click(object sender, EventArgs e)
        {
            if (audioFileReaderInput == null)
            {
                audioFileReaderInput = new AudioFileReader(inputFileName);
            }

            if (wavePlayerInput == null)
            {
                wavePlayerInput = CreateWavePlayer(comboBoxOutputDriver.SelectedIndex);
                wavePlayerInput.Init(audioFileReaderInput);

            }

            audioFileReaderInput.Volume = trackBar.Value;
            wavePlayerInput.PlaybackStopped += OnPlayStopped;
            wavePlayerInput.Play();
            btnPlayInput.Enabled = false;
            btnPauseInput.Enabled = true;
            timer2.Enabled = true;
        }

        private void btnPauseInput_Click(object sender, EventArgs e)
        {
            if (of_flg)
            {
                wavePlayerInput.Pause();
            }
            btnPlayInput.Enabled = true;
            btnPauseInput.Enabled = false;
            timer2.Enabled = false;
        }

        private async void checkBox_CheckedChanged(object sender, EventArgs e)
        {  
            if(checkBox.Checked)
            {
                inputFileName = "./sample.wav";
                toolStripStatusLabel1.Text = inputFileName;
                of_flg = true;

                CleanUp();
                InitializeTimer();
                PauseUI();
                var destinationPath = "./input.wav";
                File.Copy(inputFileName, destinationPath, true);
                convert.Text = "変換中　";
                await Task.Run(() => Wav2Text());
                //outputFileName = await Wav2Text();
                convert.Text = "変換終了";
                RestartUI();
            }
            else
            {
                CleanUp();
                InitializeTimer();
                inputFileName = null;
                outputFileName = null;
                EnableButtons(false);
                toolStripStatusLabel1.Text = "";
                convert.Text = "";
            }
           
        }

        private void PauseUI()
        {
            mItemFile.Enabled = false;
            EnableButtons(false);
            checkBox.Enabled = false;
        }
        private void RestartUI()
        {
            mItemFile.Enabled = true;
            btnPlay.Enabled = true;
            btnPlayInput.Enabled = true;
            checkBox.Enabled = true;
        }
    }
}
