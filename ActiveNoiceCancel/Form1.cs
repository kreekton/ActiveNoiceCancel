using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;

namespace Tubitak_Active_Noice_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ses ses = (Ses)listSesCal.SelectedItem;
            var ses2 = CreateTersSes(ses.GetFreq());

            WaveOut outW = new WaveOut();
            RawSourceWaveStream input3 = new RawSourceWaveStream(new MemoryStream(ses.GetStream().ToArray()), new WaveFormat(44100, 16, 1));
            RawSourceWaveStream input4 = new RawSourceWaveStream(new MemoryStream(ses2.GetStream().ToArray()), new WaveFormat(44100, 16, 1));
            MultiplexingWaveProvider waveProvider = new MultiplexingWaveProvider(new IWaveProvider[] { input3, input4 }, 2);
            waveProvider.ConnectInputToOutput(0, 0);
            waveProvider.ConnectInputToOutput(1, 1);
            outW.Init(waveProvider);
            outW.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PlaySounds(Ses[] sesler)
        {
            WaveOut outW = new WaveOut();
            WaveBuffer s = new WaveBuffer(sesler[0].GetStream().GetBuffer());
            var input1 = new WaveFileReader(sesler[0].GetStream());
            var input2 = new WaveFileReader(sesler[0].GetStream());
            MultiplexingWaveProvider waveProvider = new MultiplexingWaveProvider(new IWaveProvider[] { input1, input2 }, 2);
            waveProvider.ConnectInputToOutput(0, 0);
            outW.Init(waveProvider);
            outW.Play();
        }

        private void PlayOneSound(Ses ses)
        {



            WaveOut outW = new WaveOut();
            RawSourceWaveStream input3 = new RawSourceWaveStream(new MemoryStream(ses.GetStream().ToArray()), new WaveFormat(44100, 16, 1));

            MultiplexingWaveProvider waveProvider = new MultiplexingWaveProvider(new IWaveProvider[] { input3 }, 1);
            waveProvider.ConnectInputToOutput(0, 0);
            waveProvider.ConnectInputToOutput(0, 0);
            outW.Init(waveProvider);
            outW.Play();
        }

        private Ses CreateSes(double freq)
        {
            MemoryStream stream = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(stream);
            int RIFF = 0x46464952;
            int WAVE = 0x45564157;
            int formatChunkSize = 16;
            int headerSize = 8;
            int format = 0x20746D66;
            short formatType = 1;
            short tracks = 1;
            int samplesPerSecond = 44100;
            short bitsPerSample = 16;
            short frameSize = (short)(tracks * ((bitsPerSample + 7) / 8));
            int bytesPerSecond = samplesPerSecond * frameSize;
            int waveSize = 4;
            int data = 0x61746164;
            int samples = 44100 * 10;
            int dataChunkSize = samples * frameSize;
            int fileSize = waveSize + headerSize + formatChunkSize + headerSize + dataChunkSize;
            writer.Write(RIFF);
            writer.Write(fileSize);
            writer.Write(WAVE);
            writer.Write(format);
            writer.Write(formatChunkSize);
            writer.Write(formatType);
            writer.Write(tracks);
            writer.Write(samplesPerSecond);
            writer.Write(bytesPerSecond);
            writer.Write(frameSize);
            writer.Write(bitsPerSample);
            writer.Write(data);
            writer.Write(dataChunkSize);
            double ampl = 10000;
            for (int i = 0; i < samples; i++)
            {
                double t = (double)i / (double)samplesPerSecond;
                short s = (short)(ampl * (Math.Sin(t * freq * 2.0 * Math.PI)));
                writer.Write(s);
            }
            Ses rses = new Ses("ses" + freq, freq, stream);
            return rses;
        }
        private Ses CreateSes2(double freq)
        {
            MemoryStream stream = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(stream);
            int RIFF = 0x46464952;
            int WAVE = 0x45564157;
            int formatChunkSize = 16;
            int headerSize = 8;
            int format = 0x20746D66;
            short formatType = 1;
            short tracks = 1;
            int samplesPerSecond = 44100;
            short bitsPerSample = 16;
            short frameSize = (short)(tracks * ((bitsPerSample + 7) / 8));
            int bytesPerSecond = samplesPerSecond * frameSize;
            int waveSize = 4;
            int data = 0x61746164;
            int samples = 44100 * 10;
            int dataChunkSize = samples * frameSize;
            int fileSize = waveSize + headerSize + formatChunkSize + headerSize + dataChunkSize;

            double ampl = 10000;
            for (int i = 0; i < samples; i++)
            {
                double t = (double)i / (double)samplesPerSecond;
                short s = (short)(ampl * (Math.Sin(t * freq * 2.0 * Math.PI)));
                writer.Write(s);
            }
            Ses rses = new Ses("ses" + freq, freq, stream);
            return rses;
        }

        private Ses CreateTersSes(double freq)
        {
            MemoryStream stream = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(stream);
            int RIFF = 0x46464952;
            int WAVE = 0x45564157;
            int formatChunkSize = 16;
            int headerSize = 8;
            int format = 0x20746D66;
            short formatType = 1;
            short tracks = 1;
            int samplesPerSecond = 44100;
            short bitsPerSample = 16;
            short frameSize = (short)(tracks * ((bitsPerSample + 7) / 8));
            int bytesPerSecond = samplesPerSecond * frameSize;
            int waveSize = 4;
            int data = 0x61746164;
            int samples = 44100 * 10;
            int dataChunkSize = samples * frameSize;
            int fileSize = waveSize + headerSize + formatChunkSize + headerSize + dataChunkSize;

            double ampl = 10000;
            Console.WriteLine("freakans başı sampel sayısı: " + samplesPerSecond / freq);
            for (int i = 0; i < samples; i++)
            {
                double t = (double)i / (double)samplesPerSecond;
                short s = (short)(ampl * (Math.Sin(t * freq * 2.0 * Math.PI)));
                s = (short)(s * -1);
                writer.Write(s);
            }
            Ses rses = new Ses("ters-ses" + freq, freq, stream);
            return rses;
        }

        private void btnSesEkle_Click(object sender, EventArgs e)
        {
            int frekans;
            if (int.TryParse(txtFrekans.Text, out frekans))
            {
                Ses kses = CreateSes2(frekans);
                listSesler.Items.Add(kses);
            }
            else
            {
                MessageBox.Show("Frekans değeri doğru girilmemiş gözüküyor.");
            }
        }

        private void btnSesMove_Click(object sender, EventArgs e)
        {
            if (listSesler.SelectedIndex >= 0)
            {
                listSesCal.Items.Add(listSesler.SelectedItem);
            }
        }

        private void btnPlaySelectSound_Click(object sender, EventArgs e)
        {
            Ses ses = (Ses)listSesCal.SelectedItem;
            PlayOneSound(ses);
        }

        private void btnSesTersEkle_Click(object sender, EventArgs e)
        {
            if (listSesler.SelectedIndex >= 0)
            {
                Ses ses = (Ses)listSesler.SelectedItem;
                int freq = ses.GetFreq();
                Ses ses2 = CreateTersSes(freq);
                listSesler.Items.Add(ses2);
            }
        }

        private void btnRemoveSelect_Click(object sender, EventArgs e)
        {
            if (listSesCal.SelectedIndex >= 0)
            {
                listSesCal.Items.Remove(listSesCal.SelectedItem);
            }
        }
    }

    class Ses
    {
        string Name;
        MemoryStream Stream;
        int Freq;

        public Ses(string name, double freq, MemoryStream stream)
        {
            Name = name;
            Stream = stream;
            Freq = (int)freq;
        }

        public string GetName()
        {
            return Name;
        }

        public MemoryStream GetStream()
        {
            return Stream;
        }

        public int GetFreq()
        {
            return Freq;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
