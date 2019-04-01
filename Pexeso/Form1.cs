using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pexeso
{
    public partial class PexesoForm : Form
    {
        const int N = 6;

        enum Stav { START, HRA, JEDNA, DVE, KONEC };
        Stav stav;
        Button one, two;

        int[,] dvojice;
        int pairsRemaining;
        int turnOvers = 0;
        int pairs;

        List<Button> karticky = new List<Button>();
        bool firstGenration = true;

        Bitmap[] textures;

        public PexesoForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bStart.Location = new Point(ClientRectangle.Width/2-bStart.Width/2, ClientRectangle.Height/2-bStart.Height/2);
            lNavod.Location = new Point(ClientRectangle.Width/2- lNavod.Width/2, ClientRectangle.Height/2-bStart.Height/2 + (lNavod.Height/2));
            bZahratJeste.Location = new Point(ClientRectangle.Width/2- bZahratJeste.Width/2, ClientRectangle.Height/2- bZahratJeste.Height/2);
            lVysledek.Location = new Point(ClientRectangle.Width / 2 - lVysledek.Width, ClientRectangle.Height / 2 - bZahratJeste.Height / 2+(lVysledek.Height*15/10));
            NastavStav(Stav.START);
        }

        private void NastavStav(Stav novyStav)
        {
            switch (novyStav)
            {
                case Stav.START:
                    lNavod.Visible = true;
                    lVysledek.Visible = false;
                    bStart.Visible = true;
                    bNaStart.Visible = false;
                    bZahratJeste.Visible = false;
                    bKonec.Visible = true;
                    KartickyVisible(false);
                    break;
                case Stav.HRA:
                    if ((stav == Stav.START) || (stav == Stav.KONEC))
                        VytvorKarticky();
                    lNavod.Visible = false;
                    lVysledek.Visible = false;
                    bStart.Visible = false;
                    bNaStart.Visible = true;
                    bZahratJeste.Visible = false;
                    bKonec.Visible = true;
                    //KartickyVisible(true);
                    break;
                case Stav.JEDNA:
                case Stav.DVE:
                    lNavod.Visible = false;
                    lVysledek.Visible = false;
                    bStart.Visible = false;
                    bNaStart.Visible = true;
                    bZahratJeste.Visible = false;
                    bKonec.Visible = true;
                    //KartickyVisible(true);
                    break;
                case Stav.KONEC:
                    lNavod.Visible = false;
                    lVysledek.Visible = true;
                    bStart.Visible = false;
                    bNaStart.Visible = false;
                    bZahratJeste.Visible = true;
                    bKonec.Visible = true;
                    KartickyVisible(false);
                    lVysledek.Text = "Máš " + (100*pairs/turnOvers) + "% úspěšnost hádání.";
                    break;
                default:
                    break;
            }

            stav = novyStav;

            //debug.Text = stav.ToString();
        }

        private void KartickyVisible(bool state)
        {
            foreach (Button karticka in karticky)
            {
                karticka.Visible = state;
            }
        }

        struct place
        {
            public int x, y;
            public place(int _x, int _y)
            {
                x = _x;
                y = _y;
            }
        }
        private void VytvorKarticky()
        {
            //N should be even
            if (N%2==1)
            {
                return;
            }
            //backend pairs preparation
            pairsRemaining = N * N / 2;
            pairs = pairsRemaining;
            dvojice = new int[N, N];
            List<place> emptySpaces = new List<place>();
            for (int x = 0; x < N; x++)
            {
                for (int y = 0; y < N; y++)
                {
                    emptySpaces.Add(new place(x, y));
                }
            }

            Random rnd = new Random();
            for (int pair = 0; pair < N * N / 2; pair++)
            {
                place last = emptySpaces[emptySpaces.Count - 1];
                dvojice[last.x, last.y] = pair;
                emptySpaces.RemoveAt(emptySpaces.Count - 1);
                int pickIndex = rnd.Next(0, emptySpaces.Count);
                place pick = emptySpaces[pickIndex];
                dvojice[pick.x, pick.y] = pair;
                emptySpaces.RemoveAt(pickIndex);
            }
            //genarating UI
            if (firstGenration)
            {
                int buttonWidth = ClientRectangle.Width / N;
                int buttonHeight = (ClientRectangle.Height - 50) / N;
                textures = new Bitmap[N * N / 2];
                for (int i = 0; i < textures.Length; i++)
                {
                    textures[i] = (Bitmap)Image.FromFile(@"../../imgs/export" + i + ".png");
                }
                for (int x = 0; x < N; x++)
                {
                    for (int y = 0; y < N; y++)
                    {
                        Button b = new Button();
                        karticky.Add(b);
                        b.Width = buttonWidth;
                        b.Height = buttonHeight;
                        b.Left = x * buttonWidth;
                        b.Top = y * buttonHeight;
                        b.Parent = this;
                        b.MouseClick += ClickOnButton;
                        b.BackgroundImageLayout = ImageLayout.Zoom;
                        RefreshButton(b, x, y);
                    }
                }
            }
            else
            {
                int c = 0;
                foreach (Button karticka in karticky)
                {
                    RefreshButton(karticka, c/N, c%N);
                    c++;
                }
            }
            
            
            firstGenration = false;
        }

        private void RefreshButton(Button b, int x,int y)
        {
            b.Tag = dvojice[x, y];
            b.Text = "";
            b.BackgroundImage = null;
            b.BackColor = Color.White;
            b.Visible = true;
        }

        private void ClickOnButton(object sender, EventArgs e)
        {
            if (stav == Stav.DVE)
            {
                NewMove(sender);
            }else
            if (sender is Button)
            {
                Button karticka = (Button)sender;

                if (stav == Stav.HRA)
                {
                    FirstTurned(karticka);
                }
                else
                if (stav == Stav.JEDNA)
                {
                    SecondTurned(karticka);
                }
            }
        }

        private void FirstTurned(Button karticka)
        {
            //karticka.Text = karticka.Tag.ToString();
            //karticka.BackColor = Color.Red;
            karticka.BackgroundImage = textures[(int)karticka.Tag];

            one = karticka;
            NastavStav(Stav.JEDNA);
        }

        private void SecondTurned(Button karticka)
        {
            if (karticka == one)
                return;

            //karticka.Text = karticka.Tag.ToString();
            //karticka.BackColor = Color.Blue;
            karticka.BackgroundImage = textures[(int)karticka.Tag];

            two = karticka;
            NastavStav(Stav.DVE);
        }

        private void NewMove(object sender)
        {
            turnOvers++;
            if (one.Tag.Equals(two.Tag))
            {
                debug.Text = one.Tag + " " + two.Tag;
                one.Visible = false;
                two.Visible = false;
                pairsRemaining--;
                if (pairsRemaining <= 0)
                {
                    NastavStav(Stav.KONEC);
                    return;
                }
            }
            else
            {
                /*one.BackColor = Color.White;
                two.BackColor = Color.White;
                one.Text = "";
                two.Text = "";*/
                one.BackgroundImage = null;
                two.BackgroundImage = null;
            }


            one = null;
            two = null;

            NastavStav(Stav.HRA);
        }

        #region buttons
        private void bStart_Click(object sender, EventArgs e)
        {
            NastavStav(Stav.HRA);
        }

        private void bNaStart_Click(object sender, EventArgs e)
        {
            NastavStav(Stav.START);
        }

        private void bZahratJeste_Click(object sender, EventArgs e)
        {
            turnOvers = 0;
            
            NastavStav(Stav.HRA);
        }

        private void Cutter_Click(object sender, EventArgs e)
        {
            ImgCutter.Cut(6);
        }

        private void bKonec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
