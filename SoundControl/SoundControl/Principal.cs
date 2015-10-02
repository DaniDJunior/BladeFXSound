using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Xml.Serialization;
using System.IO;

namespace SoundControl
{
    public partial class Principal : Form
    {
        List<Som> Sons = new List<Som>();

        List<SomSave> SonsSaves = new List<SomSave>();

        int Quantidade = 36;

        float Presisao = 0.5f;

        public Principal()
        {
            InitializeComponent();
            for (int i = 0; i < Quantidade; i++)
            {
                Sons.Add(new Som());
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Microsoft.Xna.Framework.Input.Keys[] ListKeys = Keyboard.GetState().GetPressedKeys();
            if(ListKeys.Length == 1)
            {
                switch(ListKeys[0])
                {
                    case Microsoft.Xna.Framework.Input.Keys.F1:
                        if (Sons[0].Loop)
                        {
                            Sons[0].Toogle();
                        }
                        else
                        {
                            Sons[0].Play();
                        }
                        break;
                    case Microsoft.Xna.Framework.Input.Keys.F2:
                        if (Sons[1].Loop)
                        {
                            Sons[1].Toogle();
                        }
                        else
                        {
                            Sons[1].Play();
                        }
                        break;
                    case Microsoft.Xna.Framework.Input.Keys.F3:
                        if (Sons[2].Loop)
                        {
                            Sons[2].Toogle();
                        }
                        else
                        {
                            Sons[2].Play();
                        }
                        break;
                    case Microsoft.Xna.Framework.Input.Keys.F4:
                        if (Sons[3].Loop)
                        {
                            Sons[3].Toogle();
                        }
                        else
                        {
                            Sons[3].Play();
                        }
                        break;
                    case Microsoft.Xna.Framework.Input.Keys.F5:
                        if (Sons[4].Loop)
                        {
                            Sons[4].Toogle();
                        }
                        else
                        {
                            Sons[4].Play();
                        }
                        break;
                    case Microsoft.Xna.Framework.Input.Keys.F6:
                        if (Sons[5].Loop)
                        {
                            Sons[5].Toogle();
                        }
                        else
                        {
                            Sons[5].Play();
                        }
                        break;
                    case Microsoft.Xna.Framework.Input.Keys.F7:
                        if (Sons[6].Loop)
                        {
                            Sons[6].Toogle();
                        }
                        else
                        {
                            Sons[6].Play();
                        }
                        break;
                    case Microsoft.Xna.Framework.Input.Keys.F8:
                        if (Sons[7].Loop)
                        {
                            Sons[7].Toogle();
                        }
                        else
                        {
                            Sons[7].Play();
                        }
                        break;
                    case Microsoft.Xna.Framework.Input.Keys.F9:
                        if (Sons[8].Loop)
                        {
                            Sons[8].Toogle();
                        }
                        else
                        {
                            Sons[8].Play();
                        }
                        break;
                    case Microsoft.Xna.Framework.Input.Keys.F10:
                        if (Sons[9].Loop)
                        {
                            Sons[9].Toogle();
                        }
                        else
                        {
                            Sons[9].Play();
                        }
                        break;
                    case Microsoft.Xna.Framework.Input.Keys.F11:
                        if (Sons[10].Loop)
                        {
                            Sons[10].Toogle();
                        }
                        else
                        {
                            Sons[10].Play();
                        }
                        break;
                    case Microsoft.Xna.Framework.Input.Keys.F12:
                        if (Sons[11].Loop)
                        {
                            Sons[11].Toogle();
                        }
                        else
                        {
                            Sons[11].Play();
                        }
                        break;
                }
            }

            if (GamePad.GetState(PlayerIndex.One).IsConnected)
            {
                if (GamePad.GetState(PlayerIndex.One).Buttons.A == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    if (Sons[30].Loop)
                    {
                        Sons[30].Toogle();
                    }
                    else
                    {
                        Sons[30].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).Buttons.B == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    if (Sons[29].Loop)
                    {
                        Sons[29].Toogle();
                    }
                    else
                    {
                        Sons[29].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).Buttons.X == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    if (Sons[31].Loop)
                    {
                        Sons[31].Toogle();
                    }
                    else
                    {
                        Sons[31].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).Buttons.Y == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    if (Sons[28].Loop)
                    {
                        Sons[28].Toogle();
                    }
                    else
                    {
                        Sons[28].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).Buttons.Back == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    if (Sons[33].Loop)
                    {
                        Sons[33].Toogle();
                    }
                    else
                    {
                        Sons[33].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).Buttons.Start == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    if (Sons[32].Loop)
                    {
                        Sons[32].Toogle();
                    }
                    else
                    {
                        Sons[32].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).Buttons.LeftShoulder == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    if (Sons[13].Loop)
                    {
                        Sons[13].Toogle();
                    }
                    else
                    {
                        Sons[13].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).Buttons.RightShoulder == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    if (Sons[15].Loop)
                    {
                        Sons[15].Toogle();
                    }
                    else
                    {
                        Sons[15].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).Buttons.LeftStick == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    if (Sons[34].Loop)
                    {
                        Sons[34].Toogle();
                    }
                    else
                    {
                        Sons[34].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).Buttons.RightStick == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    if (Sons[35].Loop)
                    {
                        Sons[35].Toogle();
                    }
                    else
                    {
                        Sons[35].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).DPad.Up == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    if (Sons[20].Loop)
                    {
                        Sons[20].Toogle();
                    }
                    else
                    {
                        Sons[20].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).DPad.Left == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    if (Sons[23].Loop)
                    {
                        Sons[23].Toogle();
                    }
                    else
                    {
                        Sons[23].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).DPad.Right == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    if (Sons[21].Loop)
                    {
                        Sons[21].Toogle();
                    }
                    else
                    {
                        Sons[21].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).DPad.Down == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    if (Sons[22].Loop)
                    {
                        Sons[22].Toogle();
                    }
                    else
                    {
                        Sons[22].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).ThumbSticks.Left.X > Presisao)
                {
                    if (Sons[17].Loop)
                    {
                        Sons[17].Toogle();
                    }
                    else
                    {
                        Sons[17].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).ThumbSticks.Left.X < -Presisao)
                {
                    if (Sons[19].Loop)
                    {
                        Sons[19].Toogle();
                    }
                    else
                    {
                        Sons[19].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).ThumbSticks.Left.Y > Presisao)
                {
                    if (Sons[16].Loop)
                    {
                        Sons[16].Toogle();
                    }
                    else
                    {
                        Sons[16].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).ThumbSticks.Left.Y < -Presisao)
                {
                    if (Sons[18].Loop)
                    {
                        Sons[18].Toogle();
                    }
                    else
                    {
                        Sons[18].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).ThumbSticks.Right.X > Presisao)
                {
                    if (Sons[25].Loop)
                    {
                        Sons[25].Toogle();
                    }
                    else
                    {
                        Sons[25].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).ThumbSticks.Right.X < -Presisao)
                {
                    if (Sons[27].Loop)
                    {
                        Sons[27].Toogle();
                    }
                    else
                    {
                        Sons[27].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).ThumbSticks.Right.Y > Presisao)
                {
                    if (Sons[24].Loop)
                    {
                        Sons[24].Toogle();
                    }
                    else
                    {
                        Sons[24].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).ThumbSticks.Right.Y < -Presisao)
                {
                    if (Sons[26].Loop)
                    {
                        Sons[26].Toogle();
                    }
                    else
                    {
                        Sons[26].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).Triggers.Left > Presisao)
                {
                    if (Sons[12].Loop)
                    {
                        Sons[12].Toogle();
                    }
                    else
                    {
                        Sons[12].Play();
                    }
                }
                if (GamePad.GetState(PlayerIndex.One).Triggers.Right > Presisao)
                {
                    if (Sons[14].Loop)
                    {
                        Sons[14].Toogle();
                    }
                    else
                    {
                        Sons[14].Play();
                    }
                }
            }

            for (int i = 0; i < Sons.Count; i++)
            {
                int pos = i + 1;
                Panel pn = (Panel)Controls.Find("pnl_" + pos.ToString("00"), true)[0];
                Button btn_som = (Button)pn.Controls.Find("btn_som_" + pos.ToString("00"), true)[0];
                pn.BackColor = Sons[pos - 1].Cor;
                if (Sons[pos - 1].Rodando)
                {
                    btn_som.Image = img16.Images[1];
                }
                else
                {
                    btn_som.Image = img16.Images[0];
                }
            }
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(((Button)sender).Tag.ToString());
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Sons[pos - 1] = new Som(openFileDialog1.FileName);
                Panel pn = (Panel)Controls.Find("pnl_" + pos.ToString("00"), true)[0];
                Button btn_som = (Button)pn.Controls.Find("btn_som_" + pos.ToString("00"), true)[0];
                Button btn_loop = (Button)pn.Controls.Find("btn_loop_" + pos.ToString("00"), true)[0];
                btn_som.Enabled = true;
                btn_loop.Enabled = true;
            }
        }

        private void btn_som_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(((Button)sender).Tag.ToString());
            Sons[pos - 1].Toogle();
            Panel pn = (Panel)Controls.Find("pnl_" + pos.ToString("00"), true)[0];
            Button btn_som = (Button)pn.Controls.Find("btn_som_" + pos.ToString("00"), true)[0];
            if (Sons[pos - 1].Rodando)
            {
                btn_som.Image = img16.Images[1];
            }
            else
            {
                btn_som.Image = img16.Images[0];
            }
        }

        private void btn_loop_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(((Button)sender).Tag.ToString());
            Panel pn = (Panel)Controls.Find("pnl_" + pos.ToString("00"), true)[0];
            Button btn_loop = (Button)pn.Controls.Find("btn_loop_" + pos.ToString("00"), true)[0];
            Sons[pos - 1].Loop = !Sons[pos - 1].Loop;
            if (Sons[pos - 1].Loop)
                btn_loop.Image = img16.Images[3];
            else
                btn_loop.Image = img16.Images[2];
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SonsSaves = new List<SomSave>();
                foreach (Som i in Sons)
                {
                    SonsSaves.Add(new SomSave(i.Origem, i.Loop));
                }
                Salvar(saveFileDialog1.FileName + ".blfx", typeof(List<SomSave>), SonsSaves);
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SonsSaves = (List<SomSave>)Abrir(openFileDialog1.FileName, typeof(List<SomSave>));
                Sons = new List<Som>();
                foreach (SomSave i in SonsSaves)
                {
                    Sons.Add(new Som(i.origem, i.loop));
                }

                for (int i = 0; i < Quantidade; i++)
                {
                    int pos = i + 1;
                    if (!string.IsNullOrEmpty(Sons[pos - 1].Origem))
                    {
                        Panel pn = (Panel)Controls.Find("pnl_" + pos.ToString("00"), true)[0];
                        Button btn_som = (Button)pn.Controls.Find("btn_som_" + pos.ToString("00"), true)[0];
                        Button btn_loop = (Button)pn.Controls.Find("btn_loop_" + pos.ToString("00"), true)[0];
                        btn_som.Enabled = true;
                        btn_loop.Enabled = true;
                        if (Sons[pos - 1].Loop)
                            btn_loop.Image = img16.Images[3];
                        else
                            btn_loop.Image = img16.Images[2];
                    }
                }
            }
        }

        /// <summary>
        /// Salva um objeto num arquivo XML
        /// </summary>
        /// <param name="Caminho">Caminho do arquivo, ele aceita qualquer extenção</param>
        /// <param name="Tipo">Tipo de classe que será salva, use typeof() para determinar o Type</param>
        /// <param name="Valor">Objeto que será salvo no arquivo</param>
        public static void Salvar(string Caminho, Type Tipo, object Valor)
        {
            StreamWriter Arquivo = new StreamWriter(Caminho);
            XmlSerializer serializer = new XmlSerializer(Tipo);
            serializer.Serialize(Arquivo, Valor);
            Arquivo.Close();
        }

        /// <summary>
        /// Abre um arquivo XML
        /// </summary>
        /// <param name="Caminho">Caminho do arquivo, ele aceita qualquer extenção</param>
        /// <param name="Tipo">Tipo de classe que será salva, use typeof() para determinar o Type</param>
        /// <returns>Objeto que estava salvo no arquivo</returns>
        public static object Abrir(string Caminho, Type Tipo)
        {
            StreamReader Arquivo = new StreamReader(Caminho);
            XmlSerializer serializer = new XmlSerializer(Tipo);
            return serializer.Deserialize(Arquivo);
        }

    }

    public class Som
    {
        private MediaPlayer Player;

        public string Origem { get; set; }

        public bool Loop { get; set; }

        public bool Rodando
        {
            get
            {
                if (string.IsNullOrEmpty(Origem))
                {
                    return false;
                }
                else
                {
                    if (Player.Position.Ticks != 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public System.Drawing.Color Cor
        {
            get
            {
                if (string.IsNullOrEmpty(Origem))
                {
                    return System.Drawing.Color.Yellow;
                }
                else
                {
                    if (Player.Position.Ticks > 0)
                        return System.Drawing.Color.Green;
                    else
                        return System.Drawing.Color.Red;
                }

            }
        }

        public Som()
        {
            Origem = string.Empty;
            Loop = false;
        }

        public Som(string origem)
        {
            Origem = origem;
            Loop = false;
            if (!string.IsNullOrEmpty(origem))
            {
                Player = new MediaPlayer();
                Player.Open(new System.Uri(Origem));
                Player.MediaEnded += new System.EventHandler(MediaEnded);
            }
        }

        public Som(string origem, bool loop)
        {
            Origem = origem;
            Loop = loop;
            if (!string.IsNullOrEmpty(origem))
            {
                Player = new MediaPlayer();
                Player.Open(new System.Uri(Origem));
                Player.MediaEnded += new System.EventHandler(MediaEnded);
            }
        }

        public void Play()
        {
            if (!string.IsNullOrEmpty(Origem))
            {
                Player.Play();
            }
        }

        public void Stop()
        {
            if (!string.IsNullOrEmpty(Origem))
            {
                Player.Stop();
            }
        }

        public void Toogle()
        {
            if (Rodando)
            {
                Stop();
            }
            else
            {
                Play();
            }
        }

        private void MediaEnded(object sender, EventArgs e)
        {
            Player.Stop();
            if (Loop)
            {
                Player.Play();
            }
        }
    }

    [Serializable]
    public class SomSave
    {
        public string origem { get; set; }
        public bool loop { get; set; }

        public SomSave()
        {
            origem = string.Empty;
            loop = false;
        }

        public SomSave(string ORIGEM, bool LOOP)
        {
            origem = ORIGEM;
            loop = LOOP;
        }
    }
}
